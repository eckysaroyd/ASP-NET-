using System;

namespace lab_evolution_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            float bonus, total;
            Console.WriteLine("Enter the salary amount of User");
            float sa = Convert.ToInt32(Console.ReadLine());
            if (sa >= 10000 && sa < 20000)
            
                {
                    bonus = (10 * sa / 100);
                    Console.WriteLine("Bonus Amount Is " + bonus);
                    

                    total = sa + bonus;
                    Console.WriteLine("money afte bonus is  " + total);
                   
                }
            else if (sa >= 20000 && sa < 30000)
            {
                bonus = (20 * sa / 100);
                Console.WriteLine("Bonus Amount Is" + bonus);
                

                total = sa + bonus;
                Console.WriteLine("money afte bonus is " + total);
                
            }
            else if (sa >= 30000 && sa < 40000)
            {
                bonus = (30 * sa / 100);
                Console.WriteLine("Bonus Amount Is" + bonus);
               

                total = sa + bonus;
                Console.WriteLine("money afte bonus is" + total);
                
            }
            else if (sa >= 40000 && sa < 50000)
            {
                bonus = (40 * sa / 100);
                Console.WriteLine("Bonus Amount Is" + bonus);
                

                total = sa + bonus;
                Console.WriteLine("money afte bonus is" + total);
                
            }
            else if (sa >= 50000)
            {
                bonus = (50 * sa / 100);
                Console.WriteLine("Bonus Amount Is" + bonus);
                

                total = sa + bonus;
                Console.WriteLine("Bonus Amount Is" + total);
                
            }
            else
            {
                Console.WriteLine("There is an error with entered salary. we dont offer it");
            }
        }
    }
}
