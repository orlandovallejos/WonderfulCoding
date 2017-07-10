using System;

namespace Pattern.AbstractFactory
{
    /// <summary>
    /// Concrete factory
    /// </summary>
    public class NationalFactory : ICreditUnionFactory
    {
        public ILoanAccount CreateLoanAccount()
        {
            return new NationalLoanAccount();
        }

        public ISavingsAccount CreateSavingsAccount()
        {
            return new NationalSavingsAccount();
        }
    }

    /// <summary>
    /// Concrete product A
    /// </summary>
    public class NationalLoanAccount : ILoanAccount
    {
        public NationalLoanAccount()
        {
            Console.WriteLine("NationalLoanAccount");
        }
    }

    /// <summary>
    /// Concrete product B
    /// </summary>
    public class NationalSavingsAccount : ISavingsAccount
    {
        public NationalSavingsAccount()
        {
            Console.WriteLine("NationalSavingsAccount");
        }
    }
}
