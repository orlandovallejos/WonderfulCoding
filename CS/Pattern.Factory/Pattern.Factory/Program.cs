using System;

namespace Pattern.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello FACTORY World!");

            var fac = new SavingsAccountFactory();

            var acc1 = fac.GetSavingsAccount("CITI-12312");
            var acc2 = fac.GetSavingsAccount("NATI-12312");

            Console.ReadLine();
        }
    }

    //Product:
    public interface ISavingsAccount
    {
    }

    //Concrete product A:
    public class NationalSavingsAccount : ISavingsAccount
    {
        public NationalSavingsAccount(string num)
        {
            Console.WriteLine("national savings account!: " + num);
        }
    }

    //Concrete product B:
    public class CitiSavingsAccount : ISavingsAccount
    {
        public CitiSavingsAccount(string num)
        {
            Console.WriteLine("citi savings account!: " + num);
        }
    }

    //Creator:
    public interface ICreditUnionFactory
    {
        ISavingsAccount GetSavingsAccount(string num);
    }

    //Concrete creator:
    public class SavingsAccountFactory : ICreditUnionFactory
    {
        public ISavingsAccount GetSavingsAccount(string num)
        {
            if (num.Contains("NATI"))
            {
                return new NationalSavingsAccount(num);
            }
            else if (num.Contains("CITI"))
            {
                return new CitiSavingsAccount(num);
            }

            return null;
        }
    }
}