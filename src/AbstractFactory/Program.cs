using AbstractFactory.Model;
using AbstractFactory.Services;
using AbstractFactory.Services.MercadoPago;
using AbstractFactory.Services.PagSeguro;
using AbstractFactory.Services.Stripe;

namespace DesignPatternChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Pagamentos ===\n");

            Console.WriteLine("--- PagSeguro ---");
            var pagSeguroPayment = new Payment { name = "PagSeguro", amount = 150.00m, cardNumber = "1234567890123456" };
            var pagSeguroService = new PaymentService(new PagSeguroFactory());
            pagSeguroService.Process(pagSeguroPayment);

            Console.WriteLine();

            Console.WriteLine("--- MercadoPago ---");
            var mercadoPagoPayment = new Payment { name = "MercadoPago", amount = 200.00m, cardNumber = "5234567890123456" };
            var mercadoPagoService = new PaymentService(new MercadoPagoFactory());
            mercadoPagoService.Process(mercadoPagoPayment);

            Console.WriteLine();

            Console.WriteLine("--- Stripe ---");
            var stripePayment = new Payment { name = "Stripe", amount = 300.00m, cardNumber = "4234567890123456" }; 
            var stripeService = new PaymentService(new StripeFactory());
            stripeService.Process(stripePayment);

            Console.WriteLine("\n=== Fim do Processamento ===");
        }
    }
}
