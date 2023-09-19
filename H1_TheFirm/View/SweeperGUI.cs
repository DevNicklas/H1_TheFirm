using H1_TheFirm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheFirm.View
{
    /// <summary>
    /// Class <see cref="SweeperGUI"/> represents all graphical about a sweeper
    /// </summary>
    internal class SweeperGUI
    {
        /// <summary>
        /// Writes all information about a sweeper
        /// </summary>
        /// <param name="sweeper">the sweeper which will be shown</param>
        public void ShowSweeper(Sweeper sweeper)
        {
            Console.WriteLine("Sweeper:");
            Console.WriteLine(sweeper.ToString());
            Console.WriteLine();
        }
    }
}
