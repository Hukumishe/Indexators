using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexators
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            MyArray arr = new MyArray(5);

            for (int i = 0; i < 5; i++)
            {
                int check;
                arr[i] = check =  rnd.Next(1,10);
                Console.WriteLine("Исходное число: " + check);
                Console.WriteLine("Число в массиве: " + arr[i]);
            }
        }
    }
}
