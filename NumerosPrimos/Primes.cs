using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    static class Primes
    {
        public static void Primos(int range)
        {
            HashSet<int> numbers = new HashSet<int>();
            HashSet<int> primes =  new HashSet<int>();
            for (int i = 2; i < range; i++)
            {
                numbers.Add(i);
                primes.Add(i);
            }
            foreach(int i in numbers)
            {
                foreach(int j in numbers)
                {
                    if(j % i == 0 && i != j)
                    {
                        primes.Remove(j);
                    }
                }
            }
            foreach(int i in primes)
            {
                Console.WriteLine(i);
            }
        }
    }
}
