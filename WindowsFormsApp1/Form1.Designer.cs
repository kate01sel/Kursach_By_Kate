namespace InvestorsDB
{
    partial class StateFormDb
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.States = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateCapital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContinentState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatePopulation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Square = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToSave = new System.Windows.Forms.Button();
            this.txtSquare = new System.Windows.Forms.TextBox();
            this.txtPopulation = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.NomerDogovora = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContinent = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.StatesEdit = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtDeletePopulation = new System.Windows.Forms.TextBox();
            this.labelPopulation = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContinentSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSquareSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCapitalSearch = new System.Windows.Forms.TextBox();
            this.StateViewSearch = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateNameSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitalSearchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.continentSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.считатьДанныеИзФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cacheBoxSession = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.States)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatesEdit)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StateViewSearch)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 27);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1528, 405);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.States);
            this.tabPage1.Controls.Add(this.ToSave);
            this.tabPage1.Controls.Add(this.txtSquare);
            this.tabPage1.Controls.Add(this.txtPopulation);
            this.tabPage1.Controls.Add(this.Address);
            this.tabPage1.Controls.Add(this.NomerDogovora);
            this.tabPage1.Controls.Add(this.LastName);
            this.tabPage1.Controls.Add(this.txtState);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtContinent);
            this.tabPage1.Controls.Add(this.FirstName);
            this.tabPage1.Controls.Add(this.txtCapital);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage1.Size = new System.Drawing.Size(1520, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Государства";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // States
            // 
            this.States.AllowUserToDeleteRows = false;
            this.States.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.States.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14,
            this.State,
            this.StateCapital,
            this.ContinentState,
            this.StatePopulation,
            this.Square});
            this.States.Location = new System.Drawing.Point(312, 0);
            this.States.Margin = new System.Windows.Forms.Padding(4);
            this.States.Name = "States";
            this.States.Size = new System.Drawing.Size(1211, 369);
            this.States.TabIndex = 51;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "№";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 25;
            // 
            // State
            // 
            this.State.HeaderText = "StateName";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 125;
            // 
            // StateCapital
            // 
            this.StateCapital.HeaderText = "Capital";
            this.StateCapital.Name = "StateCapital";
            this.StateCapital.ReadOnly = true;
            this.StateCapital.Width = 125;
            // 
            // ContinentState
            // 
            this.ContinentState.HeaderText = "Continent";
            this.ContinentState.Name = "ContinentState";
            this.ContinentState.ReadOnly = true;
            this.ContinentState.Width = 125;
            // 
            // StatePopulation
            // 
            this.StatePopulation.HeaderText = "Population";
            this.StatePopulation.Name = "StatePopulation";
            this.StatePopulation.ReadOnly = true;
            this.StatePopulation.Width = 125;
            // 
            // Square
            // 
            this.Square.HeaderText = "SquareState";
            this.Square.Name = "Square";
            this.Square.ReadOnly = true;
            this.Square.Width = 150;
            // 
            // ToSave
            // 
            this.ToSave.Location = new System.Drawing.Point(83, 343);
            this.ToSave.Margin = new System.Windows.Forms.Padding(4);
            this.ToSave.Name = "ToSave";
            this.ToSave.Size = new System.Drawing.Size(143, 26);
            this.ToSave.TabIndex = 8;
            this.ToSave.Text = "Save to base";
            this.ToSave.UseVisualStyleBackColor = true;
            this.ToSave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtSquare
            // 
            this.txtSquare.Location = new System.Drawing.Point(156, 228);
            this.txtSquare.Margin = new System.Windows.Forms.Padding(1);
            this.txtSquare.Name = "txtSquare";
            this.txtSquare.Size = new System.Drawing.Size(141, 22);
            this.txtSquare.TabIndex = 5;
            // 
            // txtPopulation
            // 
            this.txtPopulation.Location = new System.Drawing.Point(156, 171);
            this.txtPopulation.Margin = new System.Windows.Forms.Padding(1);
            this.txtPopulation.Name = "txtPopulation";
            this.txtPopulation.Size = new System.Drawing.Size(141, 22);
            this.txtPopulation.TabIndex = 4;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(1, 231);
            this.Address.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(54, 17);
            this.Address.TabIndex = 43;
            this.Address.Text = "Square";
            // 
            // NomerDogovora
            // 
            this.NomerDogovora.AutoSize = true;
            this.NomerDogovora.Location = new System.Drawing.Point(2, 174);
            this.NomerDogovora.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.NomerDogovora.Name = "NomerDogovora";
            this.NomerDogovora.Size = new System.Drawing.Size(75, 17);
            this.NomerDogovora.TabIndex = 42;
            this.NomerDogovora.Text = "Population";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(5, 133);
            this.LastName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(68, 17);
            this.LastName.TabIndex = 41;
            this.LastName.Text = "Continent";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(156, 43);
            this.txtState.Margin = new System.Windows.Forms.Padding(1);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(141, 22);
            this.txtState.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "State";
            // 
            // txtContinent
            // 
            this.txtContinent.Location = new System.Drawing.Point(156, 130);
            this.txtContinent.Margin = new System.Windows.Forms.Padding(1);
            this.txtContinent.Name = "txtContinent";
            this.txtContinent.Size = new System.Drawing.Size(141, 22);
            this.txtContinent.TabIndex = 2;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(2, 90);
            this.FirstName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(51, 17);
            this.FirstName.TabIndex = 37;
            this.FirstName.Text = "Capital";
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(156, 87);
            this.txtCapital.Margin = new System.Windows.Forms.Padding(1);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(141, 22);
            this.txtCapital.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.StatesEdit);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage2.Size = new System.Drawing.Size(1520, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Правка";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // StatesEdit
            // 
            this.StatesEdit.AllowUserToDeleteRows = false;
            this.StatesEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatesEdit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.StatesEdit.Location = new System.Drawing.Point(0, 0);
            this.StatesEdit.Margin = new System.Windows.Forms.Padding(4);
            this.StatesEdit.Name = "StatesEdit";
            this.StatesEdit.Size = new System.Drawing.Size(1211, 369);
            this.StatesEdit.TabIndex = 52;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 25;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "StateName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Capital";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Continent";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Population";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Square";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1279, 280);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtDeletePopulation);
            this.tabPage3.Controls.Add(this.labelPopulation);
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Controls.Add(this.btnSearch);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtContinentSearch);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtSquareSearch);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtCapitalSearch);
            this.tabPage3.Controls.Add(this.StateViewSearch);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1520, 376);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Поиск";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtDeletePopulation
            // 
            this.txtDeletePopulation.Location = new System.Drawing.Point(141, 157);
            this.txtDeletePopulation.Name = "txtDeletePopulation";
            this.txtDeletePopulation.Size = new System.Drawing.Size(141, 22);
            this.txtDeletePopulation.TabIndex = 59;
            // 
            // labelPopulation
            // 
            this.labelPopulation.AutoSize = true;
            this.labelPopulation.Location = new System.Drawing.Point(14, 160);
            this.labelPopulation.Name = "labelPopulation";
            this.labelPopulation.Size = new System.Drawing.Size(75, 17);
            this.labelPopulation.TabIndex = 58;
            this.labelPopulation.Text = "Population";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(76, 285);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 84);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete State which have small population";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(107, 199);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 56;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 114);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 55;
            this.label10.Text = "Continent";
            // 
            // txtContinentSearch
            // 
            this.txtContinentSearch.Location = new System.Drawing.Point(141, 111);
            this.txtContinentSearch.Margin = new System.Windows.Forms.Padding(1);
            this.txtContinentSearch.Name = "txtContinentSearch";
            this.txtContinentSearch.Size = new System.Drawing.Size(141, 22);
            this.txtContinentSearch.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 73);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 53;
            this.label9.Text = "Square";
            // 
            // txtSquareSearch
            // 
            this.txtSquareSearch.Location = new System.Drawing.Point(141, 69);
            this.txtSquareSearch.Margin = new System.Windows.Forms.Padding(1);
            this.txtSquareSearch.Name = "txtSquareSearch";
            this.txtSquareSearch.Size = new System.Drawing.Size(141, 22);
            this.txtSquareSearch.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 51;
            this.label8.Text = "Capital";
            // 
            // txtCapitalSearch
            // 
            this.txtCapitalSearch.Location = new System.Drawing.Point(141, 28);
            this.txtCapitalSearch.Margin = new System.Windows.Forms.Padding(1);
            this.txtCapitalSearch.Name = "txtCapitalSearch";
            this.txtCapitalSearch.Size = new System.Drawing.Size(141, 22);
            this.txtCapitalSearch.TabIndex = 50;
            // 
            // StateViewSearch
            // 
            this.StateViewSearch.AllowUserToDeleteRows = false;
            this.StateViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StateViewSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.stateNameSearch,
            this.capitalSearchName,
            this.continentSearch,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.StateViewSearch.Location = new System.Drawing.Point(307, 0);
            this.StateViewSearch.Margin = new System.Windows.Forms.Padding(4);
            this.StateViewSearch.Name = "StateViewSearch";
            this.StateViewSearch.Size = new System.Drawing.Size(1211, 369);
            this.StateViewSearch.TabIndex = 49;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "№";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 25;
            // 
            // stateNameSearch
            // 
            this.stateNameSearch.HeaderText = "StateName";
            this.stateNameSearch.Name = "stateNameSearch";
            this.stateNameSearch.ReadOnly = true;
            this.stateNameSearch.Width = 125;
            // 
            // capitalSearchName
            // 
            this.capitalSearchName.HeaderText = "Capital";
            this.capitalSearchName.Name = "capitalSearchName";
            this.capitalSearchName.ReadOnly = true;
            this.capitalSearchName.Width = 125;
            // 
            // continentSearch
            // 
            this.continentSearch.HeaderText = "Continent";
            this.continentSearch.Name = "continentSearch";
            this.continentSearch.ReadOnly = true;
            this.continentSearch.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Population";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Square";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1400, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьВФайлToolStripMenuItem,
            this.считатьДанныеИзФайлаToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьВФайлToolStripMenuItem
            // 
            this.сохранитьВФайлToolStripMenuItem.Name = "сохранитьВФайлToolStripMenuItem";
            this.сохранитьВФайлToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.сохранитьВФайлToolStripMenuItem.Text = "Сохранить в файл";
            this.сохранитьВФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВФайлToolStripMenuItem_Click);
            // 
            // считатьДанныеИзФайлаToolStripMenuItem
            // 
            this.считатьДанныеИзФайлаToolStripMenuItem.Name = "считатьДанныеИзФайлаToolStripMenuItem";
            this.считатьДанныеИзФайлаToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.считатьДанныеИзФайлаToolStripMenuItem.Text = "Считать данные из файла";
            this.считатьДанныеИзФайлаToolStripMenuItem.Click += new System.EventHandler(this.считатьДанныеИзФайлаToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.helpToolStripMenuItem.Text = "Помощь";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.aboutToolStripMenuItem.Text = "Об программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // cacheBoxSession
            // 
            this.cacheBoxSession.Location = new System.Drawing.Point(410, 474);
            this.cacheBoxSession.Name = "cacheBoxSession";
            this.cacheBoxSession.ReadOnly = true;
            this.cacheBoxSession.Size = new System.Drawing.Size(567, 282);
            this.cacheBoxSession.TabIndex = 3;
            this.cacheBoxSession.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(455, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cache into last session of the application";
            // 
            // StateFormDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cacheBoxSession);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "StateFormDb";
            this.Text = "State database";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.States)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StatesEdit)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StateViewSearch)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSquare;
        private System.Windows.Forms.TextBox txtPopulation;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label NomerDogovora;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContinent;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.Button ToSave;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВФайлToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtContinentSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSquareSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCapitalSearch;
        private System.Windows.Forms.DataGridView StateViewSearch;
        private System.Windows.Forms.DataGridView States;
        private System.Windows.Forms.DataGridView StatesEdit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem считатьДанныеИзФайлаToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateCapital;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContinentState;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatePopulation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Square;
        private System.Windows.Forms.TextBox txtDeletePopulation;
        private System.Windows.Forms.Label labelPopulation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateNameSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitalSearchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn continentSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.RichTextBox cacheBoxSession;
        private System.Windows.Forms.Label label1;
    }
}

