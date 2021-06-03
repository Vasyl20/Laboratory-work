using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подорож
{
    class Program
    {
        static void Main(string[] args)
        {
            seva1:
            int a1, a2;
            Console.WriteLine("Виберiть транспорт:");
            Console.WriteLine("[1] - Автобус \n" +
                "[2] - Машиною \n" +
                "[3] - Велосипедом \n" +
                "[4] - Пiшки");
            a1 = Convert.ToInt32(Console.ReadLine());
            switch (a1)
            {
                case 1:
                    seve2:
                    Console.Clear();
                    Console.WriteLine("Якiй ви напрямов виберете ");
                    Console.WriteLine("[1] - Легкiй \n" +
                        "[2] - Важкiй");
                    a2 = Convert.ToInt32(Console.ReadLine());
                    switch (a2)
                    {
                        case 1:

                            break;
                        case 2:

                            break;
                        default:
                            goto seve2;
                    }
                    break;
                    
                        
                default:
                    goto seva1;
            }
            
        }
    }
}
