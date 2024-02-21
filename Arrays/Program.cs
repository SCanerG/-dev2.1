using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays");
            string[] students1 = new string[4];
            students1[0] = "Sabri";
            students1[1] = "Caner";
            students1[2] = "Genco";
            string[] students2 = new[] { "Genco0", "Genco1", "Genco2", "Genco3" };
            string[] students3 = { "012", "Caner00" };
            string[][] students4 = { students1, students2, students3 };

            string[,] regions = new string[5, 3];

            string[,] regions2 = new string[3, 2] { { "ax0", "ax1" }, { "bx0", "bxy0" }, { "abxy0", "abx1" } };

            foreach (string[] students in students4)
            {
                foreach (string student in students)
                {
                    Console.WriteLine(student);
                }
            }
            Console.WriteLine("Çok Boyutlu Kullanım Şekli");
            for (int i = 0; i <= regions2.GetUpperBound(0); i++)
                for (int j = 0; j <= regions2.GetUpperBound(1); j++)
                    Console.WriteLine(regions2[i, j]);
            Console.ReadLine();
        }
    }
}
