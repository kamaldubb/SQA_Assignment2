using System;
namespace SQA_Assignment2
{
    public class TriangleSolver
    {

       
        public int a, b, c;
        public string st;
        public TriangleSolver()
        {
           
        }
        public string Analyze(int a1, int b1, int c1)
        {
            a = a1;
            b = b1;
            c = c1;
            
            if(Convert.ToBoolean(a) == Convert.ToBoolean(b) == Convert.ToBoolean(c))
            {
                st =  "Its is an equilateral triangle";
                
            }
            else if(Convert.ToBoolean(a) == Convert.ToBoolean(b) != Convert.ToBoolean(c) || Convert.ToBoolean(a) != Convert.ToBoolean(b) == Convert.ToBoolean(c) || Convert.ToBoolean(a) != Convert.ToBoolean(c) == Convert.ToBoolean(b))
            {
                st = "Its is an isosceles triangle";
            }
            else if (Convert.ToBoolean(a) != Convert.ToBoolean(b) != Convert.ToBoolean(c))
            {
                st = "Its is an scalene triangle";

            }
            
            return st;
        }
    }
}
