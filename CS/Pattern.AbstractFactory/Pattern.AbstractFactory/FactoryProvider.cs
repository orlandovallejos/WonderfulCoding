namespace Pattern.AbstractFactory
{
    //Logic about factory creation goes here:
    public class FactoryProvider
    {
        public static ICreditUnionFactory GetConcreteFactory(string accountNumber)
        {
            if (accountNumber.Contains("CITI"))
            {
                return new CitiFactory();
            }
            else if (accountNumber.Contains("NATI"))
            {
                return new NationalFactory();
            }
            else
            {
                return null;
            }
        }
    }
}