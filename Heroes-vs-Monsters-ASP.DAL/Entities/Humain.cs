using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_vs_Monsters_ASP.DAL.Entities
{
    public class Humain : Heros
    {
        #region Constructeurs
        public Humain(string nom) : base(nom)
        {
            Endurance++;
            Force++;
            PointsDeVie = Endurance + Modificateur(Endurance);
        }
        #endregion
        #region Méthodes

        #endregion
    }
}