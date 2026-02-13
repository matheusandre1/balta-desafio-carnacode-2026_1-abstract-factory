using AbstractFactory.Interfaces;
using AbstractFactory.Model;

namespace AbstractFactory.Services.Stripe;

public class StripeProcessor : IPaymentProcessor
{
    public string Process(Payment payment)
    {
        Console.WriteLine($"{payment.name}: Processando {payment.amount:C}...");
        return $"STRIPE-{Guid.NewGuid().ToString().Substring(0, 8)}";
    }
}
