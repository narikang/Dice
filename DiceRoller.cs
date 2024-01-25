using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    internal class DiceRoller
    {
        private Random random = new Random();

        public int[] RollDice(int X)
        {
            int[] results = new int[13]; // Indices 2-12 will be used

            for (int i = 0; i < X; i++)
            {
                int rollOne = random.Next(1, 7);
                int rollTwo = random.Next(1, 7);
                results[rollOne + rollTwo]++;
            }

            return results;
        }
    }
}
