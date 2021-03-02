using System;

namespace SQA_Assignment2
{
    class Program
    {
        private static int a;
        private static int b;
        private static int c;

        static void Main(string[] args)
        {

            int j = 1;
            while (j < 2)
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

                            string s1 = Console.ReadLine();
                            char firstChar1 = s1[0];
                            bool isNumber1 = Char.IsDigit(firstChar1);
                            if (!isNumber1)
                            {
                                Console.WriteLine("Enter a number");
                                Console.ReadLine();
                            }
                            else
                            {

                                a = Convert.ToInt32(s1);
                            }
                            string s2 = Console.ReadLine();
                            char firstChar2 = s2[0];
                            bool isNumber2 = Char.IsDigit(firstChar2);
                            if (!isNumber2)
                            {
                                Console.WriteLine("Enter a number");
                                Console.ReadLine();
                            }
                            else
                            {

                                b = Convert.ToInt32(s2);
                            }
                            string s3 = Console.ReadLine();
                            char firstChar3 = s3[0];
                            bool isNumber3 = Char.IsDigit(firstChar3);
                            if (!isNumber3)
                            {
                                Console.WriteLine("Enter a number");
                                Console.ReadLine();
                            }
                            else
                            {

                                c = Convert.ToInt32(s3);
                            }

                            var ts = TriangleSolver.Analyze(a,b,c);
                            string str1 = ts;
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
