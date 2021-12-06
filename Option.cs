using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    class Option
    {
        public string Choix;
        public int place;
        //setters 
        public void setchoix(string name){
            this.Choix = name;
        }
        public void setplaces(int places)
        {
            this.place = places;
        }
        //getters
        public int Getplace()
        {
            return  place;
        }
        public int Getchoix()
        {
            return Choix;
        }
        public Option(string choix, int place)
        {
            this.Choix = choix;
            this.place = place;
        }

    }
}
