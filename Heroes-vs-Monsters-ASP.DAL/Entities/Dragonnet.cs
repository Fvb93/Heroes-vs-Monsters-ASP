using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_vs_Monsters_ASP.DAL.Entities
{
    internal class Dragonnet : Monstre
    {
        #region Propriétés
        #endregion
        #region Constructeurs
        public Dragonnet() : base()
        {
            Nom = NomAleatoire();
            Endurance++;
            PointsDeVie = Endurance + Modificateur(Endurance);
        }
        #endregion
        #region Méthodes
        private string NomAleatoire()
        {
            string nomaleatoire = "Dragonnet";
            Random r = new Random();
            int nbaleatoire = r.Next(1, 8);
            switch (nbaleatoire)
            {
                case 1:
                    nomaleatoire = "Le Gardien des Braises";
                    break;
                case 2:
                    nomaleatoire = "Le Veilleur des Flammes";
                    break;
                case 3:
                    nomaleatoire = "Le Souffle d'Azur";
                    break;
                case 4:
                    nomaleatoire = "L'Enfant des Vents";
                    break;
                case 5:
                    nomaleatoire = "L'Écaille de Feu";
                    break;
                case 6:
                    nomaleatoire = "L'Éclat d'Émeraude";
                    break;
                case 7:
                    nomaleatoire = "L'Esprit des Forges";
                    break;
            }
            return nomaleatoire;
        }
        #endregion
    }
}