using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_vs_Monsters_ASP.DAL.Entities
{
    public class Orque : Monstre
    {
        #region Propriétés
        #endregion
        #region Constructeurs
        public Orque() : base()
        {
            Nom = NomAleatoire();
            Force++;
            Cuir = 0;
        }

        #endregion
        #region Méthodes
        private string NomAleatoire()
        {
            string nomaleatoire = "Orque";
            Random r = new Random();
            int nbaleatoire = r.Next(1, 8);
            switch (nbaleatoire)
            {
                case 1:
                    nomaleatoire = "Le Destructeur des Montagnes";
                    break;
                case 2:
                    nomaleatoire = "Le Briseur de Crânes";
                    break;
                case 3:
                    nomaleatoire = "Le Chef de Guerre Noir";
                    break;
                case 4:
                    nomaleatoire = "Le Maître du Chaos";
                    break;
                case 5:
                    nomaleatoire = "Le Fendeur de Boucliers";
                    break;
                case 6:
                    nomaleatoire = "L'Enfant de la Fureur";
                    break;
                case 7:
                    nomaleatoire = "Le Ravageur des Plaines";
                    break;
            }
            return nomaleatoire;
        }
        #endregion
    }
}
