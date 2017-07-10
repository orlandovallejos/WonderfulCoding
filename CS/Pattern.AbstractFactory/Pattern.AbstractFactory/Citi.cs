using System;

namespace Pattern.AbstractFactory
{
    /// <summary>
    /// Concrete factory
    /// </summary>
    public class CitiFactory : ICreditUnionFactory
    {
        public ILoanAccount CreateLoanAccount()
        {
            return new CitiLoanAccount();
        }

        public ISavingsAccount CreateSavingsAccount()
        {
            return new CitiSavingsAccount();
        }
    }

    /// <summary>
    /// Concrete product A
    /// </summary>
    public class CitiLoanAccount : ILoanAccount
    {
        public CitiLoanAccount()
        {
            Console.WriteLine("CitiLoanAccount");
        }
    }

    /// <summary>
    /// Concrete product B
    /// </summary>
    public class CitiSavingsAccount : ISavingsAccount
    {
        public CitiSavingsAccount()
        {
            Console.WriteLine("CitiSavingsAccount");
        }
    }
}
