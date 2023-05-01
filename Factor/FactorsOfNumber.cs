using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factor
{
    internal class Class1
    { 
        public static void DisplayFactors()
        {
            Console.WriteLine("Enter the Number to find the prime factors");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num); 
            for (int i = 2; i <= num; i++)
            {
                
                while(num%i== 0)
                {
                    Console.WriteLine("the fact is :{0}",i);
                   
                    i++;
                }
            }

        }
    }
}
