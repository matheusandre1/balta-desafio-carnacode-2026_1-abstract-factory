using AbstractFactory.Model;

namespace AbstractFactory.Interfaces
{
    public interface IPaymentValidator
    {
        bool ValidateCard(Payment payment);
    }
}
