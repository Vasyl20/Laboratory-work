using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Піраміда
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[15];
            int g;
            int height = mas.GetLength(0);
            int numdr1 = 1, numbr2 = 1, numbr3 = 1;

            


            Console.WriteLine("Бажаєте вести елементи масива з клавiатури чи автоматично?");
            Console.WriteLine(" 1 - з клавiатури, 2 - вести автоматично");
            g = Convert.ToInt32(Console.ReadLine());

        povtor2:
            if (g == 1)
            {
                //Вод з клавіатури
                Console.WriteLine("Ведiть елементи масива");
                for (int i = 0; i < 15; i++)
                {
                        Console.Write($"{numdr1})");
                        mas[i] = Convert.ToInt32(Console.ReadLine());
                        numdr1++;
                }
            }

            if (g == 2)
            {
                //Вод авто.
                Random random = new Random();
                for (int ps = 0; ps < 15; ps++)
                {
                     mas[ps] = random.Next(1, 101);
                }
            }
            else
            {
                Console.WriteLine("Ви вибрали невiрну вiдповiдь ");
                Console.WriteLine("Бажаєте повторити ?");
                Console.ReadLine();
                goto povtor2;
            }

            Console.Clear();//Очистка консолі
            Console.WriteLine("1) Вивод матрицi:\n");

            //Функція виводу масива(матриці), рядки  
            for (int t = 0; t < height; t++)
            {
                  Console.Write(numbr2+")"+mas[t] + "\t");
                numbr2++;
            }

            int temp;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }


            
            Console.WriteLine("\n\n2) Вывод отсортированного массива:\n\n");
            for (int t = 0; t < height; t++)
            {
                Console.Write(numbr3+")"+mas[t] + "\t");
                numbr3++;
            }



            //Вивод пірамідки
            Console.WriteLine("\n\n\n");
            Console.WriteLine("3) Вывод матрицi пiрамiдой:\n\n\n");
            Console.WriteLine("               " + mas[14]);
            Console.WriteLine("            " + mas[13] + "   " + mas[12]);
            Console.WriteLine("         " + mas[11] + "   " + mas[10] + "   " + mas[9]);
            Console.WriteLine("      " + mas[8] + "   " + mas[7] + "   " + mas[6] + "   " + mas[5]);
            Console.WriteLine("    " + mas[4] + "   " + mas[3] + "   " + mas[2] + "   " + mas[1] + "   " + mas[0]);
            Console.WriteLine("\n\n\n");





        }
    }
    
}
