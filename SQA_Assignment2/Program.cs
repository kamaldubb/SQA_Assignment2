using System;

namespace SQA_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int j = 1;
            while(j < 2)
            { 
                Console.WriteLine("Press 1 to Enter Triangle dimensions");
                Console.WriteLine("Press 2 Exit");
                string str = Console.ReadLine();
                char firstChar = str[0];
                bool isNumber = Char.IsDigit(firstChar);
                if (j <= 0 || !isNumber)
                {
                    Console.WriteLine("Enter the valid number");
                }
                else
                {
                    Console.WriteLine(" ");
                    int i = Convert.ToInt32(str);
                    switch (i)
                    {
                        case 1:
                            Console.WriteLine("Enter the dimensions of triangle");
                            int a = Convert.ToInt32(Console.ReadLine());
                            int b = Convert.ToInt32(Console.ReadLine());
                            int c = Convert.ToInt32(Console.ReadLine());
                            TriangleSolver ts = new TriangleSolver();
                            string str1 = ts.Analyze(a, b, c);
                            Console.WriteLine(str1);
                            break;

                        case 2:
                            Environment.Exit(0);
                            break;


                    }
                }
            }

            
        }
    }
}
