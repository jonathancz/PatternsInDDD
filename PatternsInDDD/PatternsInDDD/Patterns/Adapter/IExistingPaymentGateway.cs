namespace PatternsInDDD.Patterns.Adapter;

/// <summary>
/// The existing interface that your application uses for Payments.
/// </summary>
public interface IExistingPaymentGateway
{
    bool ProcessPayment(string creditCardNumber, decimal amount);
}