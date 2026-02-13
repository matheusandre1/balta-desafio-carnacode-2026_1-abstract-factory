using AbstractFactory.Interfaces;
using AbstractFactory.Model;

namespace AbstractFactory.Services.MercadoPago;

public class MercadoPagoValidator : IPaymentValidator
{
    public bool ValidateCard(Payment payment)
    {
        Console.WriteLine($"{payment.name}: Validando cartão...");
        return payment.cardNumber.Length == 16;
    }
}
