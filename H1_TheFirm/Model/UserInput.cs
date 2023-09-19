using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheFirm.Model
{
    /// <summary>
    /// Class <see cref="UserInput"/> represents input from the user of the program
    /// </summary>
    internal class UserInput
    {
        /// <summary>
        /// Waits for the user to press a key, and fetches the key when a key is pressed
        /// </summary>
        /// <returns>The key which is pressed</returns>
        public ConsoleKey GetPressedKey()
        {
            return Console.ReadKey(true).Key;
        }
    }
}
