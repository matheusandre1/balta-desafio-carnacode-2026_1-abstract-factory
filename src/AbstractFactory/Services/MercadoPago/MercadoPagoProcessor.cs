using AbstractFactory.Interfaces;
using AbstractFactory.Model;

namespace AbstractFactory.Services.MercadoPago;

public class MercadoPagoProcessor : IPaymentProcessor
{
    public string Process(Payment payment)
    {
        Console.WriteLine($"{payment.name}: Processando {payment.amount:C}...");
        return $"MERCADOPAGO-{Guid.NewGuid().ToString().Substring(0, 8)}";
    }
}
