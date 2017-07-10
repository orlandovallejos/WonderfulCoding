namespace Pattern.AbstractFactory
{
    /// <summary>
    /// Abstract factory
    /// </summary>
    public interface ICreditUnionFactory
    {
        ILoanAccount CreateLoanAccount();
        ISavingsAccount CreateSavingsAccount();
    }

    /// <summary>
    /// Abstract product A
    /// </summary>
    public interface ILoanAccount
    {
    }

    /// <summary>
    /// Abstract product B
    /// </summary>
    public interface ISavingsAccount
    {
    }
}