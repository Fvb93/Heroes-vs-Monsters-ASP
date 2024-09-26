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
        public Orque(string nom) : base(nom)
        {
            Force++;
            Cuir = 0;
        }

        #endregion
        #region Méthodes

        #endregion
    }
}
