using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_practice.project_euler
{
    class ProjectEulerDriver
    {
        static void Main()
        {
            Console.WriteLine("\nProject Euler Problem 039:");
            P039 p039 = new P039();
            p039.Solution();

            Console.WriteLine("\nProject Euler Problem 040:");
            P040 p040 = new P040();
            p040.Solution();

            Console.ReadLine();
        }
    }
}
