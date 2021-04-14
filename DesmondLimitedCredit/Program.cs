using System;
using System.Collections.Generic;

namespace DesmondLimitedCredit
{
    class Program
    {
        delegate decimal InterestDel(decimal P, int R, int T);
        static void Main(string[] args)
        {
            InterestDel interest = SimpleInterest;
            InterestDel interest2 = CompoundInterest;

            IEnumerable<Customer> customers = new List<Customer>(){
                new Customer("Tola Seedy", 5000M, 5, 5),
                new Customer("Tosin Gabby", 3000M,4, 5),
                new Customer("Daniel Schiffer", 3000M,5, 3),
                new Customer("Josh Aby", 4000M,2, 5),
                new Customer("Abram Trump", 5800M,3, 4),
                new Customer("Joe Banjo", 5500M,5, 5),
                new Customer("Barrack Kings", 9000M,6, 2),
                new Customer("Clinton Banks", 5000M,5, 5),
                new Customer("Kay Strings", 8000M,4, 4),
                new Customer("Abigail Bozak", 7000M,3, 2)
            };

            Customer customer1 = new Customer("Tola Seedy", 5000M,5, 5);
            Customer customer2 = new Customer("Tosin Gabby", 3000M,4, 5);
            Customer customer3 = new Customer("Daniel Schiffer", 3000M,5, 3);
            Customer customer4 = new Customer("Josh Aby", 4000M,2, 5);
            Customer customer5 = new Customer("Abram Trump", 5800M,3, 4);
            Customer customer6 = new Customer("Joe Banjo", 5500M,5, 5);
            Customer customer7 = new Customer("Barrack Kings", 9000M,6, 2);
            Customer customer8 = new Customer("Clinton Banks", 5000M,5, 5);
            Customer customer9 = new Customer("Kay Strings", 8000M,4, 4);
            Customer customer10 = new Customer("Abigail Bozak", 7000M,3, 2);

            Console.WriteLine($"{customer2}\nSimple Interest: {interest(5000M,5, 5)}\nCompound Interest: {interest2(5000M,5, 5)}\n");
            Console.WriteLine($"{customer3}\nSimple Interest: {interest(3000M,4, 5)}\nCompound Interest: {interest2(3000M,4, 5)}\n");
            Console.WriteLine($"{customer1}\nSimple Interest: {interest(3000M,5, 3)}\nCompound Interest: {interest2(3000M,5, 3)}\n");
            Console.WriteLine($"{customer4}\nSimple Interest: {interest(4000M,2, 5)}\nCompound Interest: {interest2(4000M,2, 5)}\n");
            Console.WriteLine($"{customer5}\nSimple Interest: {interest(5800M,3, 4)}\nCompound Interest: {interest2(5800M,3, 4)}\n");
            Console.WriteLine($"{customer6}\nSimple Interest: {interest(5500M,5, 5)}\nCompound Interest: {interest2(5500M,5, 5)}\n");
            Console.WriteLine($"{customer7}\nSimple Interest: {interest(9000M,6, 2)}\nCompound Interest: {interest2(9000M,6, 2)}\n");
            Console.WriteLine($"{customer8}\nSimple Interest: {interest(5000M,5, 5)}\nCompound Interest: {interest2(5000M,5, 5)}\n");
            Console.WriteLine($"{customer9}\nSimple Interest: {interest(8000M,4, 4)}\nCompound Interest: {interest2(8000M,4, 4)}\n");
            Console.WriteLine($"{customer10}\nSimple Interest: {interest(7000M,3, 2)}\nCompound Interest: {interest2(7000M,3, 2)}\n");
        }
        static decimal SimpleInterest(decimal P, int R, int T)
        {
            return(P * (R/100) * T)/100;
        }

        static decimal CompoundInterest(decimal P, int R, int T)
        {
            return P * (decimal)Math.Pow((1 + (R/100)), T);
        }
    }
}
