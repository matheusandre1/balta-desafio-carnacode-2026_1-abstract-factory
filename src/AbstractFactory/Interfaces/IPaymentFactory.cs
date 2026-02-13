namespace AbstractFactory.Interfaces
{
    public interface IPaymentFactory
    {
        IPaymentValidator CreateValidator();
        IPaymentProcessor CreateProcessor();
        IPaymentLogger CreateLogger();
    }
}
