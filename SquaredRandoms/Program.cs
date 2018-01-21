using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNum = random.Next(1, 50);

            Console.WriteLine(randomNum);
            Console.ReadKey();

        }
    }
}
