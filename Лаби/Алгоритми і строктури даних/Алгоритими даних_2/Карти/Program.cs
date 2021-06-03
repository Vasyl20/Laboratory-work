using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Карти
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] cart = new string[4] { "♣", "♠", "♦", "♥" };
            string[] mast = new string[8] { "6", "7", "8", "9", "J", "Q", "K", "A" };
            List<string> masttt = new List<string>(8) { "6", "7", "8", "9", "J", "Q", "K", "A" };

            Random random = new Random();
            

            Console.WriteLine("\n");
            for (int i = 0; i < 8; i++)
            {
                for (int l = 0; l < 4; l++)
                {
                    Console.Write("\t" + mast[random.Next(0,8)] + cart[random.Next(0, 4)] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");

            Console.WriteLine("       ====================================================");

            Console.WriteLine("\n");
            for (int i = 0; i < 8; i++)
            {
                for (int l = 0; l < 4; l++)
                {
                    Console.Write("\t"+mast[i]+cart[l]+"\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");

        }
    }
}
