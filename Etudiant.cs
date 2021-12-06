using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    class Etudiant
    {

        public string Nom;
        public string prenom;
        public float note;
        

        public Etudiant(string nom, double note)
        {
            this.Nom = nom;
            this.note = note;
        }

        public Etudiant(string nom, string prenom, float noteMoy)
        {
            this.Nom = nom;
            this.prenom = prenom;
            this.note = noteMoy;
        }
    }
}
