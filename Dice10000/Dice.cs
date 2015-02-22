using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice10000
{
    class Dice
    {
        //int d; 
        public int d { get; set; }
        public static Random rand = new Random();

        public Dice()
        {
            
            d = rand.Next(1, 7);

        }

        public static int rollDice()
        {
            return new Dice().d;

        }

        public static List<int> rollSixtet()
        {
            List<int> myDiceList = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                int v = rollDice();
                myDiceList.Add(v);
                Console.WriteLine(v);
            }
            return myDiceList;
        }
    }
}
