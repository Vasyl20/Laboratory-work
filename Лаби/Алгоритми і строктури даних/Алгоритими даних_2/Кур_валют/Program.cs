using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кур_валют
{
    class Massts
    {
       public double[] dolarmas = new double[7] { 27.46, 28.17, 28.59, 28.23, 27.80, 27.37, 27.05 };
       public double[] eurmas1 = new double[7] { 33.54, 33.61, 33.90, 34.19, 34.44, 34.29, 33.89 };

          public string[] date3 = new string[7]
          {
                   "25.05.2021" , "26.05.2021", "27.05.2021", "28.05.2021", "29.05.2021", "30.05.2021", "31.05.2021"
          };
    }
    class Program
    {

        static void Mast()
        {

            string[] date = new string[7]
            {
                 "25.05.2021" , "26.05.2021", "27.05.2021", "28.05.2021", "29.05.2021", "30.05.2021", "31.05.2021"
            };

            string[] dolar = new string[7]
            {
                "USD: 27.46 грн" , "USD: 28.17 грн", "USD: 28.59 грн", "USD: 28.23 грн", "USD: 27.80 грн", "USD: 27.36 грн", "USD: 27.05 грн"
            };

            string[] eur = new string[7]
            {
                "EUR: 33.54 грн" , "EUR: 33.61 грн", "EUR: 33.90 грн", "EUR: 34.19 грн", "EUR: 34.44 грн", "EUR: 34.29 грн", "EUR: 33.89 грн"
            };


            for (int t = 0; t < 7; t++)
            {
                Console.Write(" " + date[t] + "\t     ");
            }
            Console.WriteLine();
            for (int t = 0; t < 7; t++)
            {
                Console.Write("|" + dolar[t] + "|" + "       ");
            }
            Console.WriteLine();
            for (int t = 0; t < 7; t++)
            {
                Console.Write("|" + eur[t] + "|" + "       ");
            }

            Console.WriteLine("\n==================================================================================================="+
                "===========================================================");
        }

        static void VigitKypDol()
        {
            string[] date2 = new string[7]
           {
               "24.05.2021" , "25.05.2021", "26.05.2021", "26.05.2021", "28.05.2021", "29.05.2021", "30.05.2021"
           };
           double[] dolarmas2 = new double[7] { 27.46, 28.17, 28.59, 28.23, 27.80, 27.37, 27.05 };

            double temp;
            for (int i = 0; i < dolarmas2.Length - 1; i++)
            {
                for (int j = i + 1; j < dolarmas2.Length; j++)
                {
                    if (dolarmas2[i] > dolarmas2[j])
                    {
                        temp = dolarmas2[i];
                        dolarmas2[i] = dolarmas2[j];
                        dolarmas2[j] = temp;
                    }
                }
            }

            Console.Write("       " + date2[2] + "\t     \n");
            Console.Write("    |" + "USD: " + $"{dolarmas2[6]} грн" + "|" + "       \n\n");

        }

        static void VigitKypEur()
        {

            string[] date3 = new string[7]
            {
               "24.05.2021" , "25.05.2021", "26.05.2021", "26.05.2021", "28.05.2021", "29.05.2021", "30.05.2021"
            };

            double[] eurmas2 = new double[7] { 33.54, 33.61, 33.90, 34.19, 34.44, 34.29, 33.89 };

            double temp;
            for (int i = 0; i < eurmas2.Length - 1; i++)
            {
                for (int j = i + 1; j < eurmas2.Length; j++)
                {
                    if (eurmas2[i] > eurmas2[j])
                    {
                        temp = eurmas2[i];
                        eurmas2[i] = eurmas2[j];
                        eurmas2[j] = temp;
                    }
                }
            }

            Console.Write("       " + date3[0] + "\t     \n");
            Console.Write("    |" + "EUR: " + $"{eurmas2[6]} грн" + "|" + "       \n\n");

        }

        static void VigitProdDolar()
        {
            Massts massts = new Massts();

            double temp;
            for (int i = 0; i < massts.dolarmas.Length - 1; i++)
            {
                for (int j = i + 1; j < massts.dolarmas.Length; j++)
                {
                    if (massts.dolarmas[i] > massts.dolarmas[j])
                    {
                        temp = massts.dolarmas[i];
                        massts.dolarmas[i] = massts.dolarmas[j];
                        massts.dolarmas[j] = temp;
                    }
                }
            }


            Console.Write("       " + massts.date3[6] + "\t     \n");
            Console.Write("    |" + "USD: " + $"{massts.dolarmas[0]} грн" + "|" + "       \n\n");

        }


        static void VifitProdEur()
        {
            Massts massts = new Massts();

            double temp;
            for (int i = 0; i < massts.eurmas1.Length - 1; i++)
            {
                for (int j = i + 1; j < massts.eurmas1.Length; j++)
                {
                    if (massts.eurmas1[i] > massts.eurmas1[j])
                    {
                        temp = massts.eurmas1[i];
                        massts.eurmas1[i] = massts.eurmas1[j];
                        massts.eurmas1[j] = temp;
                    }
                }
            }


            Console.Write("       " + massts.date3[0] + "\t     \n");
            Console.Write("    |" + "EUR: " + $"{massts.eurmas1[0]} грн" + "|" + "       \n\n");

        }

        static void Main(string[] args)
        {

        save1:
            int sol = 0, viv1 = 0, viv2 = 0;
            int vibor = 0, vibor1 = 0;

            Console.Clear();
            Mast();

            Console.WriteLine("\n");

            Console.WriteLine("[1] - подивитсиь коли вигодно купити");
            Console.WriteLine("[2] - подивитсиь коли вигодно продати");
            sol = Convert.ToInt32(Console.ReadLine());

            switch (sol)
            {
                case 1:
                    Console.Clear();
                    Mast();
                    Console.WriteLine("\n\nЯку валюту ви хочете вигодно придбати ?");
                    Console.WriteLine("[1] - Долари");
                    Console.WriteLine("[2] - Євро");
                    Console.WriteLine("\n[3] - вийти назад\n");
                    
                    viv1 = Convert.ToInt32(Console.ReadLine());
                    switch (viv1)
                    {
                        case 1:
                            Console.Clear();
                        save2:
                            Mast();
                            Console.WriteLine("\nНайвигiднiше купляти долари: \n");

                            VigitKypDol();

                            Console.WriteLine("\nБажаєте вийти назад ?");
                            Console.WriteLine("[1] - Так");
                            Console.WriteLine("[2] - нi, остатись тут");

                            vibor = Convert.ToInt32(Console.ReadLine());
                            switch (vibor)
                            {
                                case 1:
                                    Console.Clear();
                                    goto save1;
                                    break;
                                case 2:
                                    Console.Clear();
                                    goto save2;
                                    break;
                                default:
                                    Console.Clear();
                                    Mast();
                                    Console.WriteLine("Ви вибрали непрвільну відповідь, вас перекине на головне меню");
                                    Console.ReadLine();
                                    goto save1;
                            }
                            break;
                        case 2:
                            Console.Clear();
                        save3:
                            Mast();
                            Console.WriteLine("\nНайвигiднiше купляти долари: \n");
                            VigitKypEur();

                            Console.WriteLine("\nБажаєте вийти назад ?");
                            Console.WriteLine("[1] - Так");
                            Console.WriteLine("[2] - нi, остатись тут");

                            vibor1 = Convert.ToInt32(Console.ReadLine());
                            switch (vibor1)
                            {
                                case 1:
                                    Console.Clear();
                                    goto save1;
                                    break;
                                case 2:
                                    Console.Clear();
                                    goto save3;
                                    break;
                                default:
                                    Console.Clear();
                                    Mast();
                                    Console.WriteLine("Ви вибрали непрвільну відповідь, вас перекине на головне меню");
                                    Console.ReadLine();
                                    goto save1;
                            }

                            break;
                        case 3:
                            Console.Clear();
                            goto save1;
                            break;
                        //default:
                    }
                    break;
                case 2:
                    Console.Clear();
                    Mast();
                    Console.WriteLine("\n\nЯку валюту ви хочете вигодно проадити ?");
                    Console.WriteLine("[1] - Долари");
                    Console.WriteLine("[2] - Євро");
                    Console.WriteLine("\n[3] - вийти назад\n");
                    viv2 = Convert.ToInt32(Console.ReadLine());
                    switch (viv2)
                    {
                        case 1:
                            Console.Clear();
                        save4:
                            Mast();
                            Console.WriteLine("\nНайвигiднiше купляти долари: \n");
                            VigitProdDolar();

                            Console.WriteLine("\nБажаєте вийти назад ?");
                            Console.WriteLine("[1] - Так");
                            Console.WriteLine("[2] - нi, остатись тут");

                            vibor1 = Convert.ToInt32(Console.ReadLine());
                            switch (vibor1)
                            {
                                case 1:
                                    Console.Clear();
                                    goto save1;
                                    break;
                                case 2:
                                    Console.Clear();
                                    goto save4;
                                    break;
                                default:
                                    Console.Clear();
                                    Mast();
                                    Console.WriteLine("Ви вибрали непрвільну відповідь, вас перекине на головне меню");
                                    Console.ReadLine();
                                    goto save1;
                            }
                            break;
                        case 2:
                            Console.Clear();
                        save5:
                            Mast();
                            Console.WriteLine("\nНайвигiднiше купляти Євро \n");
                            VifitProdEur();

                            Console.WriteLine("\nБажаєте вийти назад ?");
                            Console.WriteLine("[1] - Так");
                            Console.WriteLine("[2] - нi, остатись тут");

                            vibor1 = Convert.ToInt32(Console.ReadLine());
                            switch (vibor1)
                            {
                                case 1:
                                    Console.Clear();
                                    goto save1;
                                    break;
                                case 2:
                                    Console.Clear();
                                    goto save5;
                                    break;
                                default:
                                    Console.Clear();
                                    Mast();
                                    Console.WriteLine("Ви вибрали непрвільну відповідь, вас перекине на головне меню");
                                    Console.ReadLine();
                                    goto save1;
                            }
                            break;
                        case 3:
                            Console.Clear();
                            goto save1;
                            break;
                        //default:
                    }
                    break;

                    //default:
            }



        }
    }
}
