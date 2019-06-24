using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int no1 = Convert.ToInt32(Console.ReadLine());
            int no2 = Convert.ToInt32(Console.ReadLine());

            int temp;

            temp = no1;
            no1 = no2;
            no2 = temp;

            Console.WriteLine("After swaping numbers=\n"+no1+" \n"+no2);
            Console.ReadLine();
        }
    }
}
