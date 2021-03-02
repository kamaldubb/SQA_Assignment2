using System;
namespace SQA_Assignment2
{
    public static class TriangleSolver
    {

       
        public static int a, b, c;
        public static string st;
        
        public static string Analyze(int a1, int b1, int c1)
        {
            a = a1;
            b = b1;
            c = c1;    
            if(a == b && b == c && a == c )
            {
                st =  "Its is an equilateral triangle";   
            }
            else if((a == b || b == c || c == a) || ((a+b) < c || (a+c) < b || (b+c) < a))
            {
                st = "Its is an isosceles triangle";
            }
            else if (a != b && b != c && c != a && (a+b) != c && (b+c) != a && (a+c) != b)
            {
                st = "Its is an scalene triangle";
            }
            else
            {
                st = "The three dimensions does not form equilateral, isosceles or scalene of triangle";
            }
            return st;
        }
    }
}
