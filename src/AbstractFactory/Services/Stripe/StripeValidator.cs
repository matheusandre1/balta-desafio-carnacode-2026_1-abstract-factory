using AbstractFactory.Interfaces;
using AbstractFactory.Model;

namespace AbstractFactory.Services.Stripe;

public class StripeValidator : IPaymentValidator
{
    public bool ValidateCard(Payment payment)
    {
        Console.WriteLine($"{payment.name}: Validando cartão...");
        return payment.cardNumber.Length == 16;
    }
}
