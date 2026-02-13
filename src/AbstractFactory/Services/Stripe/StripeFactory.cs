using AbstractFactory.Interfaces;

namespace AbstractFactory.Services.Stripe;

public class StripeFactory : IPaymentFactory
{
    public IPaymentValidator CreateValidator() => new StripeValidator();
    public IPaymentProcessor CreateProcessor() => new StripeProcessor();
    public IPaymentLogger CreateLogger() => new StripeLogger(); 
}
