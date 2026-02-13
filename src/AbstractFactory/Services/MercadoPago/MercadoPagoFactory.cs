using AbstractFactory.Interfaces;

namespace AbstractFactory.Services.MercadoPago;

public class MercadoPagoFactory : IPaymentFactory
{
    public IPaymentValidator CreateValidator() => new MercadoPagoValidator();
    public IPaymentProcessor CreateProcessor() => new MercadoPagoProcessor();
    public IPaymentLogger CreateLogger() => new MercadoPagoLogger();
}
