using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_vs_Monsters_ASP.DAL.Entities
{

    public class Loup : Monstre
    {
        #region Propriétés
        #endregion
        #region Constructeurs
        public Loup() : base()
        {
            Nom = NomAleatoire();
            Or = 0;
        }
        #endregion
        #region Méthodes
        private string NomAleatoire ()
        {
            string nomaleatoire = "Loup";
            Random r = new Random();
            int nbaleatoire = r.Next(1, 8);
            switch (nbaleatoire)
            {
                case 1: nomaleatoire = "Le Gardien de la Lune";
                    break;
                case 2:
                    nomaleatoire = "L'Alpha du Crépuscule";
                    break;
                case 3:
                    nomaleatoire = "Le Hurleur des Ombres";
                    break;
                case 4:
                    nomaleatoire = "Le Seigneur des Cimes";
                    break;
                case 5:
                    nomaleatoire = "L'Œil du Nord";
                    break;
                case 6:
                    nomaleatoire = "Le Maître de la Meute";
                    break;
                case 7:
                    nomaleatoire = "L'Esprit du Givre";
                    break;
            }
            return nomaleatoire;
        }
        #endregion
    }
}
