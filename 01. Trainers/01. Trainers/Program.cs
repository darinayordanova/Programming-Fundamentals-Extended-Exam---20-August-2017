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
            int n = int.Parse(Console.ReadLine());

            double technicalEarned = 0;
            double theoreticalEarned = 0;
            double practicalEarned = 0;
            
            for (int i = 0; i < n; i++)
            {
                int distance = int.Parse(Console.ReadLine());
                float cargo = float.Parse(Console.ReadLine());
                string team = Console.ReadLine();

                if (team == "Technical")
                { technicalEarned += (cargo * 1000 * 1.5) - (0.7 * distance * 1600 * 2.5); }
                else if (team == "Practical")
                { practicalEarned += (cargo * 1000 * 1.5) - (0.7 * distance * 1600 * 2.5); }
                else if (team == "Theoretical")
                { theoreticalEarned += (cargo * 1000 * 1.5) - (0.7 * distance * 1600 * 2.5); }
            }

            if (technicalEarned >= practicalEarned && technicalEarned >= theoreticalEarned)
            {
                Console.WriteLine("The Technical Trainers win with ${0:f3}.", technicalEarned);
            }
            else if (practicalEarned > technicalEarned && practicalEarned >= theoreticalEarned)
            {
                Console.WriteLine("The Practical Trainers win with ${0:f3}.", practicalEarned);
            }
            else if (theoreticalEarned > technicalEarned && theoreticalEarned > practicalEarned)
            {
                Console.WriteLine("The Theoretical Trainers win with ${0:f3}.", theoreticalEarned);
            }
        }
    }
}