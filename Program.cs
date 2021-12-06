using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Donner le nombre d'etudiants: ");
            int size = int.Parse(Console.ReadLine());

            string[] tab = new string[size];

            Option gl = new Option("gl", 1);
            Option abd = new Option("abd", 1);
            Option asr = new Option("asr", 1);
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("Donner le nom d'etudiant N " + (i + 1) + ":");
                string nom = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Donner la note d'etudiant N" + (i + 1) + ":");
                double note = double.Parse(Console.ReadLine());

                Console.WriteLine("Donner le premier choix d'etudiant N" + (i + 1) + ":");
                string op1 = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Donner le 2eme choix d'etudiant N" + (i + 1) + ":");
                string op2 = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Donner le 3eme choix d'etudiant N" + (i + 1) + ":");
                string op3 = Convert.ToString(Console.ReadLine());

                Console.WriteLine("||Donner autre etudiant||");

                Etudiant etud = new Etudiant(nom, note);

                var tuple = Tuple.Create(etud, op1, op2, op3);

                liste.Add(tuple);
            }
            // Warning : les places  des filiéres vous pouvez donner qu'est ce que vous voulez!!

            var liste = new List<Tuple<Etudiant, string, string, string>>();


            liste.Sort((x, y) => y.Item1.note.CompareTo(x.Item1.note));

            for (int i = 0; i < size; i++)
            {

                switch (liste[i].Item2)
                {
                    case "gl":
                        if (gl.place > 0)
                        {
                            tab[i] = liste[i].Item1.Nom + " => " + gl.Choix;
                            --gl.place;
                        }
                        break;
                    case "abd":
                        if (abd.place > 0)
                        {
                            tab[i] = liste[i].Item1.Nom + " => " + abd.Choix;
                            --abd.place;
                        }
                        break;
                    case "asr":
                        if (asr.place > 0)
                        {
                            tab[i] = liste[i].Item1.Nom + " => " + asr.Choix;
                            --asr.place;
                        }
                        break;
                }
                if (tab[i] == null)
                {
                    switch (liste[i].Item3)
                    {

                        case "gl":
                            if (gl.place > 0)
                            {
                                tab[i] = liste[i].Item1.Nom + " => " + gl.Choix;
                                --gl.place;
                            }
                            break;
                        case "abd":
                            if (abd.place > 0)
                            {
                                tab[i] = liste[i].Item1.Nom + " => " + abd.Choix;
                                --abd.place;
                            }
                            break;
                        case "asr":
                            if (asr.place > 0)
                            {
                                tab[i] = liste[i].Item1.Nom + " => " + asr.Choix;
                                --asr.place;
                            }
                            break;
                    }

                }
                if (tab[i] == null)
                {
                    switch (liste[i].Item4)
                    {

                        case "gl":
                            if (gl.place > 0)
                            {
                                tab[i] = liste[i].Item1.Nom + " => " + gl.Choix;
                                --gl.place;
                            }
                            break;
                        case "abd":
                            if (abd.place > 0)
                            {
                                tab[i] = liste[i].Item1.Nom + " => " + abd.Choix;
                                --abd.place;
                            }
                            break;
                        case "asr":
                            if (asr.place > 0)
                            {
                                tab[i] = liste[i].Item1.Nom + " => " + asr.Choix;
                                --asr.place;
                            }
                            break;
                    }
                    Console.WriteLine("les etudiants avec leurs filieres : ");
                    Console.WriteLine("Nom     Filiere");

                    for (int j = 0; j < size; j++)
                    {
                        Console.WriteLine(tab[j] + "\t");
                        Console.WriteLine("-----");
                    }





                }
            }








        }
    }
}
