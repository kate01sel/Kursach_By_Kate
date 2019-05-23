using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace InvestorsDB
{
    public partial class StateFormDb : Form
    {
        DataBase db = new DataBase();
        int currentElement;

        public StateFormDb()
        {
            InitializeComponent();
            currentElement = 0;
            backgroundWorker1.RunWorkerAsync();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("База данных государств мира (c) 2019 by Kate");
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            txtState.BackColor = Color.White;
            txtCapital.BackColor = Color.White;
            txtContinent.BackColor = Color.White;
            txtPopulation.BackColor = Color.White;
            txtSquare.BackColor = Color.White;

            if (txtCapital.Text == "" || txtContinent.Text == "" || txtState.Text == "" ||
                txtPopulation.Text == "" || txtSquare.Text == "")

            {
                MessageBox.Show("Заполните поля!");
                if (txtState.Text == "")
                    txtState.BackColor = Color.Red;

                if (txtCapital.Text == "")
                    txtCapital.BackColor = Color.Red;

                if (txtContinent.Text == "")
                    txtContinent.BackColor = Color.Red;

                if (txtPopulation.Text == "")
                    txtPopulation.BackColor = Color.Red;

                if (txtSquare.Text == "")
                    txtSquare.BackColor = Color.Red;

            }

            else if (CorrectName(txtState.Text) || CorrectName(txtCapital.Text) ||
                CorrectName(txtContinent.Text) || CorrectPopulation(txtPopulation.Text) ||
                CorrectPopulation(txtSquare.Text))
            {
                MessageBox.Show("Недопустимые форматы для полей!");
                if (CorrectName(txtState.Text))
                    txtCapital.BackColor = Color.Red;

                if (CorrectName(txtCapital.Text))
                    txtContinent.BackColor = Color.Red;

                if (CorrectName(txtContinent.Text))
                    txtState.BackColor = Color.Red;

                if (CorrectPopulation(txtPopulation.Text))
                    txtPopulation.BackColor = Color.Red;

                if (CorrectSquare(txtSquare.Text))
                    txtSquare.BackColor = Color.Red;
            }

            else
            {
                currentElement++;

                States.Rows.Add(currentElement, txtState.Text, txtCapital.Text, txtContinent.Text,
                    txtPopulation.Text, txtSquare.Text);

                StatesEdit.Rows.Add(currentElement, txtState.Text, txtCapital.Text, txtContinent.Text,
                    txtPopulation.Text, txtSquare.Text);

                db.Db.Add(new State(txtState.Text, txtCapital.Text, txtContinent.Text,
                     Convert.ToInt32(txtPopulation.Text), Convert.ToDouble(txtSquare.Text)));                
            }
        }
      
        bool CorrectName(string input)
        {
            bool result = false;
            foreach (char item in input)
            {
                if (Char.IsNumber(item))
                    result = true;
                else if (Char.IsPunctuation(item))
                    result = true;
                else if (Char.IsSymbol(item))
                    result = true;
            }
            return result;
        }
        
        bool CorrectPopulation(string input)
        {
            bool result = false;
            foreach (char item in input)
            {
                if (Char.IsPunctuation(item))
                    result = true;
                else if (Char.IsSymbol(item))
                    result = true;
                else if (Char.IsLetter(item))
                    result = true;
                else if (Convert.ToDouble(txtPopulation.Text) > 2000000000 || Convert.ToInt32(txtPopulation.Text) <= 0)
                    result = true;
            }
            return result;
        }
        
        bool CorrectSquare(string input)
        {
            bool result = false;
            foreach (char item in input)
            {
                if (Char.IsPunctuation(item))
                    result = true;
                else if (Char.IsSymbol(item))
                    result = true;
                else if (Char.IsLetter(item))
                    result = true;
                else if (Convert.ToDouble(txtSquare.Text) > 18000000 || Convert.ToDouble(txtSquare.Text) <= 0)
                    result = true;
            }
            return result;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            for (int i = 0; i < currentElement; i++)
            {
                bool result = true;
                String[] ss1 = new string[6];
                for (int j = 1; j < States.ColumnCount; j++)
                {
                    StatesEdit.Rows[i].Cells[j].Style.BackColor = Color.White;

                    if ((j == 1 || j == 2 || j == 3) && CorrectName(StatesEdit.Rows[i].Cells[j].Value.ToString()))
                    {
                        StatesEdit.Rows[i].Cells[j].Style.BackColor = Color.Red;
                        result = false;
                    }

                    if (j == 4 && CorrectPopulation(StatesEdit.Rows[i].Cells[j].Value.ToString()))
                    {
                        StatesEdit.Rows[i].Cells[j].Style.BackColor = Color.Red;
                        result = false;
                    }

                    if (j == 5 && CorrectSquare(StatesEdit.Rows[i].Cells[j].Value.ToString()))
                    {
                        StatesEdit.Rows[i].Cells[j].Style.BackColor = Color.Red;
                        result = false;
                    }

                    ss1[j] = StatesEdit.Rows[i].Cells[j].Value.ToString();
                }

                if (result)
                {
                    for (int k = 1; k < 6; k++)
                    {
                        States.Rows[i].Cells[k].Value = ss1[k];
                    }
                    db.Db.ElementAt(i).StateName = StatesEdit.Rows[i].Cells[1].Value.ToString();
                    db.Db.ElementAt(i).Capital = StatesEdit.Rows[i].Cells[2].Value.ToString();
                    db.Db.ElementAt(i).Continent = StatesEdit.Rows[i].Cells[3].Value.ToString();
                    db.Db.ElementAt(i).Population = Convert.ToInt32(StatesEdit.Rows[i].Cells[4].Value.ToString());
                    db.Db.ElementAt(i).Square = Convert.ToDouble(StatesEdit.Rows[i].Cells[5].Value.ToString());
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StateViewSearch.Rows.Clear();
            if (txtCapitalSearch.Text != "")
            {
                int kolSur = 0;
                for (int i = 0; i < currentElement; i++)
                {
                    if (txtCapitalSearch.Text == db.Db.ElementAt(i).Capital)
                    {
                        kolSur++;
                        StateViewSearch.Rows.Add(kolSur, 
                            db.Db.ElementAt(i).StateName, 
                            db.Db.ElementAt(i).Capital, 
                            db.Db.ElementAt(i).Continent,
                            db.Db.ElementAt(i).Population, 
                            db.Db.ElementAt(i).Square);
                    }
                }
                txtCapitalSearch.Text = "";
            }

            else if (txtSquareSearch.Text != "")
            {
                int kolSum = 0;
                for (int i = 0; i < currentElement; i++)
                {
                    if (Convert.ToDouble(txtSquareSearch.Text) <= db.Db.ElementAt(i).Square)
                    {
                        kolSum++;
                        StateViewSearch.Rows.Add(kolSum, 
                            db.Db.ElementAt(i).StateName, 
                            db.Db.ElementAt(i).Capital, 
                            db.Db.ElementAt(i).Continent,
                            db.Db.ElementAt(i).Population, 
                            db.Db.ElementAt(i).Square);
                    }
                }
                txtSquareSearch.Text = "";
            }

            else if (txtContinentSearch.Text != "")
            {
                int kolTerm = 0;
                for (int i = 0; i < currentElement; i++)
                {
                    if (txtContinentSearch.Text == db.Db.ElementAt(i).Continent)
                    {
                        kolTerm++;
                        StateViewSearch.Rows.Add(kolTerm, 
                            db.Db.ElementAt(i).StateName, 
                            db.Db.ElementAt(i).Capital, 
                            db.Db.ElementAt(i).Continent,
                            db.Db.ElementAt(i).Population, 
                            db.Db.ElementAt(i).Square);
                    }
                }
                txtContinentSearch.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < currentElement; i++)
            {
                currentElement--;
            }

            States.Rows.Clear();
            StatesEdit.Rows.Clear();
            StateViewSearch.Rows.Clear();

            for (int j = 0; j < currentElement; j++)
            {
                if (db.Db.ElementAt(j).Population < Convert.ToInt32(txtDeletePopulation.Text))
                {
                    States.Rows.Add(j + 1, db.Db.ElementAt(j).StateName, db.Db.ElementAt(j).Capital, db.Db.ElementAt(j).Continent,
                            db.Db.ElementAt(j).Population, db.Db.ElementAt(j).Square);

                    StatesEdit.Rows.Add(j + 1, db.Db.ElementAt(j).StateName, db.Db.ElementAt(j).Capital, db.Db.ElementAt(j).Continent,
                                db.Db.ElementAt(j).Population, db.Db.ElementAt(j).Square);
                }
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"fon.wav");
            player.Play();
            player.PlayLooping();
        }

        private void сохранитьВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (TextWriter writer = new StreamWriter(File.Create($@"C:\Users\{SystemInformation.UserName}\Desktop\kurs.txt"),Encoding.Default))
            {
                try
                {
                    if(States.Rows.Count - 1 != 0)
                    {
                        for (int i = 0; i < States.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < States.Columns.Count; j++)
                            {
                                if (j == 6)
                                    writer.Write(States.Rows[i].Cells[j].Value.ToString() + '\n');
                                else
                                    writer.Write(States.Rows[i].Cells[j].Value.ToString() + '\t');
                            }
                        }
                        MessageBox.Show("All information from table was cached");
                    }
                    else
                    {
                        MessageBox.Show("Write in table more information");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    writer.Close();
                }
            }
        }

        private void считатьДанныеИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (TextReader text = new StreamReader(File.OpenRead($@"C:\Users\{SystemInformation.UserName}\Desktop\kurs.txt"), Encoding.Default))
            {
                try
                {
                    foreach (var item in text.ReadLine().Skip('\t'))
                    {
                        cacheBoxSession.Text += item.ToString();
                    }
                    MessageBox.Show("Information was wrote in cacheBox under table");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);              
                }
                finally
                {
                    text.Close();
                }
            }            
        }
    }
}