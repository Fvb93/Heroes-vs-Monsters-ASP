using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_vs_Monsters_ASP.DAL.Entities
{
    public class De
    {
        #region Propriétés
        public int Minimum { get; }
        public int Maximum { get; }
        #endregion
        #region Constructeur
        public De(int minimum, int maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }
        #endregion
        #region Méthodes
        public int Jetdede()
        {
            Random random = new Random();
            return random.Next(Minimum, Maximum + 1);
        }
        #endregion
    }
}
