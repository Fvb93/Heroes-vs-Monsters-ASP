using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_vs_Monsters_ASP.DAL.Entities
{
    public abstract class Personnage
    {
        #region Propriétés
        public string? Nom { get; protected set; }
        public int Endurance { get; protected set; }
        public int Force { get; protected set; }
        public int PointsDeVie { get; protected set; }
        public int Or { get; protected set; }
        public int Cuir { get; protected set; }
        #endregion
        #region Constructeur
        protected Personnage()
        { 
            Endurance = CalculForceouEndu();
            Force = CalculForceouEndu();
            PointsDeVie = Endurance + Modificateur(Endurance);
            Or = 0;
            Cuir = 0;
        }
        protected Personnage(string nom)
        {
            Nom = nom;
            Endurance = CalculForceouEndu();
            Force = CalculForceouEndu();
            PointsDeVie = Endurance + Modificateur(Endurance);
        }
        #endregion
        #region Méthodes
        private int CalculForceouEndu()
        {
            List<int> ListLancer = new List<int>();
            De d6 = new De(1, 6);

            for (int jetdedes = 1; jetdedes <= 4; jetdedes++)
            {
                ListLancer.Add(d6.Jetdede());
            }
            ListLancer.Remove(ListLancer.Min());

            return ListLancer.Sum();
        }
        protected int Modificateur(int attribut)
        {
            int modificateur = 0;
            if (attribut < 5)
            {
                modificateur = -1;
            }
            else if (attribut < 10)
            {
                modificateur = 0;
            }
            else if (attribut < 15)
            {
                modificateur = 1;
            }
            else
            {
                modificateur = 2;
            }
            return modificateur;
        }
        public int Frappe(Personnage p)
        {
            De d4 = new De(1, 4);
            int modificateur = Modificateur(Force);
            int degat = d4.Jetdede() + modificateur;
            p.PointsDeVie -= degat;
            return degat;
        }
        public void AffichageDegat(Personnage attaquant, Personnage recevant,int degat) {
            Console.WriteLine($"{attaquant.Nom} frappe {recevant.Nom}");
            if (degat > 1)
            {
                Console.WriteLine($"{recevant.Nom} perd {degat} points de vie");
            }
            else
            {
                Console.WriteLine($"{recevant.Nom} perd {degat} point de vie");
            }
            #endregion
        }
    }
}