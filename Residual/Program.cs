using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Residual
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstDivizior = 3;
            int secondDivizior = 5;
            int maxNumber = 100;

            Random rand = new Random();
            int randomNumber = rand.Next(maxNumber + 1);

            string line = "";
            int sum = 0;

            for (int i = firstDivizior; i <= randomNumber; i++)
            {
                if (i % firstDivizior == 0 || i % secondDivizior == 0)
                {
                    line += i.ToString() + "+";
                    sum += i;
                }
            }
            Console.WriteLine($"рандомное число: {randomNumber}");
            Console.WriteLine($"числа кратные {firstDivizior} или {secondDivizior}: {line}\nсумма чисел: {sum}");
        }
    }
}
