using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorsDB
{    
    class State
    {
        String stateName;
        String capital;
        String continent;
        int population;
        double square;


        public State()
        {

        }

        public State(string stateName, string capital, string continent, int population, double square)
        {
           
            this.stateName = stateName;
            this.capital = capital;
            this.continent = continent;
            this.population = population;
            this.square = square;
        }
       
        public string StateName { get => stateName; set => stateName = value; }
        public string Capital { get => capital; set => capital = value; }
        public string Continent { get => continent; set => continent = value; }
        public int Population { get => population; set => population = value; }
        public double Square { get => square; set => square = value; }
        public string toString()
        {
            return this.StateName + " " + this.Capital + " " + this.Continent + " " + " " + this.Population + " "
                + this.Square;
        }
    }
}
