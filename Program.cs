using System;
using System.Security.Cryptography.X509Certificates;
namespace exception
{

    class demo : Exception
    {
        public void devidebyzero()
        {
            Console.WriteLine("exception has occured!");
        }
    }
    class operation 
    {
        public double devisionOperation(double a, double b)
        {
            if (b==0)
            {
                demo d = new demo();    
                d.devidebyzero();
            }
               
            return a/b;
        }
    }


    public  class Program 
    {
        static void Main(string[] args)
        {
            operation op = new operation();
            double num = 5, den = 0, quotient;

            quotient = op.devisionOperation(num, den);
            Console.WriteLine(quotient);



        }
    }
}
