using AbstractFactory.Model;

namespace AbstractFactory.Interfaces
{
    public interface IPaymentProcessor
    {
        string Process(Payment payment);
    }
}
