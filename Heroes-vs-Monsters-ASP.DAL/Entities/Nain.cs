using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_vs_Monsters_ASP.DAL.Entities
{
    public class Nain : Heros
    {
        #region Propriétés
        #endregion
        #region Constructeurs
        public Nain(string nom) : base(nom)
        {
            Endurance += 2;
            PointsDeVie = Endurance + Modificateur(Endurance);
        }
        #endregion
        #region Méthodes
        #endregion
    }
}
