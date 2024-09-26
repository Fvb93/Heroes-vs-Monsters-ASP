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
        public Dragonnet(string nom) : base(nom)
        {
            Endurance++;
            PointsDeVie = Endurance + Modificateur(Endurance);
        }
        #endregion
        #region Méthodes
        #endregion
    }
}