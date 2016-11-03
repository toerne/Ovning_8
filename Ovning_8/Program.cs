using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personVektor = new string[5];
            Console.WriteLine("Knappa in fem namn:");
            for (int i = 0; i < personVektor.Length; i++)
            {
                Console.Write($"Namn {i}: ");
                personVektor[i] = Console.ReadLine();
            }

            for (int i = personVektor.Length - 1; i >= 0; i--)
            {
                Console.Write($"Namn {i}: ");
                Console.WriteLine(personVektor[i]);
            }

            Console.Write("Byt namn på index: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nytt namn: ");
            string newName = Console.ReadLine();

            personVektor[index] = newName;

            Console.WriteLine("Hur många väderstationsmätningar har du gjort?" );
            index = Convert.ToInt32(Console.ReadLine());

            int[] temp = new int[index];

            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write($"Temperaturmätning {i}: ");
                temp[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;

            for (int i = 0; i < temp.Length; i++)
            {
                sum = +temp[i];
            }

            Console.WriteLine($"Medeltemperaturen är {sum / temp.Length}"); //Testkommentar

            Console.ReadKey();
        }
    }
}
