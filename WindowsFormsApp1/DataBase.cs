using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorsDB
{
    class DataBase
    {
        List<State> db;

        public DataBase()
        {
            db = new List<State>();
        }
        internal List<State> Db { get => db;}

        public bool AddState(State state)
        {
            bool result = false;
           
            try
            {
                Db.Add(state);
                result = true;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            return result;
        }

        public string toString()
        {
            string result = "";
            
            foreach (State item in Db)
            {
                result += item.toString() + '\n';
            }

            return result;
        }
    }
}
