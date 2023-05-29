using System;
using System.Globalization;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 1;
            while (choice !=0 )
            {
                Console.WriteLine("Menu ");
                Console.WriteLine("1 . hcn ");
                Console.WriteLine("2 . tgv1 ");
                Console.WriteLine("3 . tgv2 ");
                Console.WriteLine("4 . tgc ");
                Console.WriteLine("0 . out ");
                Console.Write("ur choice : ");
                choice =Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0: Environment.Exit(0); break;
                    case 1: 
                        for (int i = 1;i<=3;i++)
                        {
                            for (int j= 1;j<=5;j++)
                            {
                                Console.Write(" * ");
                                if (j == 5) { Console.WriteLine(" "); }
                            }
                        }

                        break;
                    case 2: 
                        for ( int i = 1; i <= 6; i++)
                        {
                            for (int j= 1; j<=i-1; j++)
                            {
                                Console.Write(" * ");
                               
                            }
                            Console.WriteLine(" ");
                        }
                        break;

                    case 3:
                        for (int i = 6; i >=1 ; i--)
                        {
                            for (int j = i-1; j >= 1; j--)
                            {
                                Console.Write(" * ");

                            }
                            Console.WriteLine(" ");
                        }
                        break;
                    case 4:
                        int k = 5 % 2;
                        k++;
                        for (int i = 1; i <= 3; i++)
                        {   
                            for (int j = 1; j <= 5; j++)
                            {
                                if (j <= k || j>=5-k)
                                {
                                    Console.Write("   ");
                                   
                                }
                                else
                                {
                                    Console.Write(" * ");
                                }
                            }
                            Console.WriteLine("");
                            k--;
                        }
                        break;

                    default: Console.WriteLine("no choice");
                        break;

                }
            }
        }
    }
}
