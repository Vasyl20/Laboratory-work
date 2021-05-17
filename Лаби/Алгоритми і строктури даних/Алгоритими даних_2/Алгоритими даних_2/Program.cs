using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Алгоритими_даних_2
{
    class Program
    {
        static void Main(string[] args)
        {
            povtor1:
            int[,] mas = new int[4, 4];
            int height = mas.GetLength(0);
            int width = mas.GetLength(1);
            int numdr1 = 1;
            int x, g, j = 0, l = 1;
            int pic1 =0, pic2=0, pic3=0, pic4=0, hil=0;
            int pac1 = 0, pac2 = 0, pac3 = 0, pac4 = 0, host = 0;

            Console.WriteLine("Бажаєте вести елементи масива з клавiатури чи автоматично?");
            Console.WriteLine(" 1 - з клавiатури, 2 - вести автоматично");
            g = Convert.ToInt32(Console.ReadLine());

            povtor2:
            if (g == 1)
            {
                Console.WriteLine("Ведiть елементи масива");
                for (int i = 0; i < 4; i++)
                {
                    for (int f = 0; f < 4; f++)
                    {
                        Console.Write($"{numdr1})");
                        mas[i, f] = Convert.ToInt32(Console.ReadLine());
                        numdr1++;

                        if (i == 0 && f == 0)
                        {
                            pic1 = mas[0, 0];
                        }
                        if (i == 1 && f == 1)
                        {
                            pic2 = mas[1, 1];
                        }
                        if (i == 2 && f == 2)
                        {
                            pic3 = mas[2, 2];
                        }
                        if (i == 3 && f == 3)
                        {
                            pic4 = mas[3, 3];
                        }


                        if (i == 0 && f == 3)
                        {
                            pac1 = mas[0, 3];
                        }
                        if (i == 1 && f == 2)
                        {
                            pac2 = mas[1, 2];
                        }
                        if (i == 2 && f == 1)
                        {
                            pac3 = mas[2, 1];
                        }
                        if (i == 3 && f == 0)
                        {
                            pac4 = mas[3, 0];
                        }

                    }
                }
            }

            if (g == 2)
            {
                Random random = new Random();
                for (int ps = 0; ps < 4; ps++)
                {
                    for (int kl = 0; kl < 4; kl++)
                    {
                        mas[ps, kl] = random.Next(1,101);

                        if (ps == 0 && kl == 0)
                        {
                            pic1 = mas[0, 0];
                        }
                        if (ps == 1 && kl == 1)
                        {
                            pic2 = mas[1, 1];
                        }
                        if (ps == 2 && kl == 2)
                        {
                            pic3 = mas[2, 2];
                        }
                        if (ps == 3 && kl == 3)
                        {
                            pic4 = mas[3, 3];
                        }


                        if (ps == 0 && kl == 3)
                        {
                            pac1 = mas[0, 3];
                        }
                        if (ps == 1 && kl == 2)
                        {
                            pac2 = mas[1, 2];
                        }
                        if (ps == 2 && kl == 1)
                        {
                            pac3 = mas[2, 1];
                        }
                        if (ps == 3 && kl == 0)
                        {
                            pac4 = mas[3, 0];
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Ви вибрали невiрну вiдповiдь ");
                Console.WriteLine("Бажаєте повторити ?");
                Console.ReadLine();
                goto povtor2;
            }

                hil = pic1 + pic2 + pic3 + pic4;
                host = pac1 * pac2 * pac3 * pac4;
            

            Console.Clear();//Очистка консолі
            Console.WriteLine("Вивод матрицi:\n");

            //Функція виводу масива(матриці), стобчикі - рядки  
            for (int t = 0; t < height; t++)
            {
                for (int y = 0; y < width; y++)
                {
                    Console.Write(mas[t, y] + "\t");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine($"\n\nCума елементiв по дiагоналi дорiвнює: {hil}");
            Console.WriteLine($"\nМноження елементiв по дiагоналi дорiвнює: {host}");
            Console.WriteLine("\n\n");


            Console.WriteLine("Бажаєте замiнити елементи в масивi на 0 i 1 ?");
            Console.WriteLine("\n\n1 - так, 2 - нi");
            x = Convert.ToInt32(Console.ReadLine());

            if (x == 1)
            {
                mas[0, 0] = j;
                mas[1, 1] = j;
                mas[2, 2] = j;
                mas[3, 3] = j;

                mas[0, 3] = l;
                mas[1, 2] = l;
                mas[2, 1] = l;
                mas[3, 0] = l;
            }
            else
            {
                Environment.Exit(0);
            }

            Console.Clear();//Очистка консолі
            Console.WriteLine("Вивод матрицi:\n");

            //Функція виводу масива(матриці), стобчикі - рядки  
            for (int b = 0; b < height; b++)
            {
                for (int z = 0; z < width; z++)
                {
                    Console.Write(mas[b, z] + "\t");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Повторити 1 - да, 2 - нi");
            g = Convert.ToInt32(Console.ReadLine());
            if (g == 1)
            {
                Console.Clear();//Очистка консолі
                goto povtor1; 
            }
            else
            {
                Environment.Exit(0);
            }

        }
    }
}
