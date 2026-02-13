using AbstractFactory.Interfaces;
using AbstractFactory.Model;

namespace AbstractFactory.Services.PagSeguro;

public class PagSeguroProcessor : IPaymentProcessor
{
    public string Process(Payment payment)
    {
        Console.WriteLine($"{payment.name}: Processando {payment.amount:C}...");
        return $"PAGSEGURO-{Guid.NewGuid().ToString().Substring(0, 8)}";
    }
}
