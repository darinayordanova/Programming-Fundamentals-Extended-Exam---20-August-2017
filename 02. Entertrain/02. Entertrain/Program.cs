using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            List<int> wagons = new List<int>();

            int sum = 0;

            int best = 1000;
            int bestI = 0;

            while (input != "All ofboard!")
            {

                int wag = int.Parse(input);
                wagons.Add(wag);
                sum += wag;
                if (sum > power)
                {
                    int average = (int)wagons.Average();
                    int nearest = wagons.OrderBy(x => Math.Abs((long)x - average)).First();

                    wagons.Remove(nearest);
                }
                input = Console.ReadLine();
            }

            for (int i = wagons.Count - 1; i >= 0; i--)
            {
                Console.Write(wagons[i] + " ");
            }
            Console.WriteLine(power);
        }
    }
}