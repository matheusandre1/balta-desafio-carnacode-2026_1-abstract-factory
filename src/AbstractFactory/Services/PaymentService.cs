using AbstractFactory.Interfaces;
using AbstractFactory.Model;

namespace AbstractFactory.Services
{
    public class PaymentService
    {
        private readonly IPaymentProcessor _processTransaction;
        private readonly IPaymentLogger _logger;
        private readonly IPaymentValidator _validador;

        public PaymentService(IPaymentFactory factory)
        {
            _processTransaction = factory.CreateProcessor();
            _logger = factory.CreateLogger();
            _validador = factory.CreateValidator();
        }

        public void Process(Payment payment)
        {
            if (!_validador.ValidateCard(payment))
            {
                _logger.Log($"Cartão inválido para {payment.name}");
                return;
            }

            var result = _processTransaction.Process(payment);
            _logger.Log($"Transação processada: {result}");
        }
    }
}
