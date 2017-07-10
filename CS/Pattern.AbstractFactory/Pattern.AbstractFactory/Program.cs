using System;
using System.Collections.Generic;

namespace Pattern.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> accounts = new List<string>();
            accounts.Add("CITI-32424");
            accounts.Add("OTHE-61158");
            accounts.Add("NATI-67356");

            foreach (var item in accounts)
            {
                ICreditUnionFactory concreteFactory = FactoryProvider.GetConcreteFactory(item);
                if (concreteFactory != null)
                {
                    concreteFactory.CreateLoanAccount();
                    concreteFactory.CreateSavingsAccount();
                }
                else
                {
                    Console.WriteLine("No known bank.");
                }
            }

            Console.ReadLine();
        }
    }
}