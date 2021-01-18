using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace root
{
    public class OddNumbers
    {
        public int[] Numbers { get; set; }

        public OddNumbers()
        {
            Console.WriteLine("Odd number instance");
        }

        public OddNumbers(int[] numbers)
        {
            this.Numbers = numbers;
        }

        public void GetOddNumbers()
        {
            Console.WriteLine($"Odd numbers");

            IEnumerable<int> oddNumbers = from number in Numbers where number % 2 != 0 select number;

            foreach (var i in oddNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
