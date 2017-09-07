using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {

            Regex reg = new Regex(@"^(<\[[^a-zA-Z0-9]*\]\.)(\.\[[a-zA-Z0-9]*\]\.)*?$");

            List<string> results = new List<string>();

            var inputLine = Console.ReadLine();


            while (inputLine != "Traincode!")
            {

                Match match = reg.Match(inputLine);
                if (match.Success)
                {

                    results.Add(inputLine);

                }
                inputLine = Console.ReadLine();
            }

            for (int i = 0; i < results.Count; i++)
            {
                Console.WriteLine(results[i]);
            }

        }
    }
}