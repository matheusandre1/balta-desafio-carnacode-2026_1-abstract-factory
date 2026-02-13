using AbstractFactory.Interfaces;

namespace AbstractFactory.Services.PagSeguro;

public class PagSeguroFactory : IPaymentFactory
{
    public IPaymentValidator CreateValidator() => new PagSeguroValidator();

    public IPaymentProcessor CreateProcessor() => new PagSeguroProcessor();

    public IPaymentLogger CreateLogger() => new PagSeguroLogger();
}
