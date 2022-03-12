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
            int minResidual = 3;
            int maxResidual = 5;
            int step = 2;

            Random rand = new Random();
            int maxRandomLevel = 100;
            string line = "";
            int sum = 0;

            int randomNumber = rand.Next(maxRandomLevel + 1);

            for (int i = minResidual; i < maxResidual + 1; i += step)
            {
                for (int ii = 0; ii <= randomNumber; ii++)
                {
                    if (ii % i == 0)
                    {
                        line += ii.ToString() + "+";
                        sum += ii;
                    }
                }

                Console.WriteLine($"рандомное число: {randomNumber}");
                Console.WriteLine($"числа кратные {i}: {line}\nсумма чисел: {sum}");

                line = "";
                sum = 0;
            }
        }
    }
}
