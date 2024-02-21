using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("methods");
          
            Console.WriteLine(Multiply(2,3));
            Console.WriteLine(Multiply(3,4,9));
            Console.WriteLine(Add4(1,2,3,4,5));

            Console.ReadLine();
        }
        static void Add() { Console.WriteLine("İnsert"); }
        static int Add2(int a, int b) { return a + b; }
        static int Add3(int a, int b = 15, int c = 51)
        {
            a = 5;
            return a + b + c;
        }
        static int Add4(out int a, int b)
        {
            a = 14;
            return a + b;
        }

        //method overloading
        static int Multiply(int number1, int number2) { return number1 * number2; }
        static int Multiply(int number1, int number2, int number3) { return number1 * number2 * number3; }

        static int Add4(params int [] numbers) { return numbers.Sum(); }
        
    }
}
