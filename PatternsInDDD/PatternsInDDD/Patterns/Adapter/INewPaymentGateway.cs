namespace PatternsInDDD.Patterns.Adapter;

public interface INewPaymentGateway
{
    public string MakePayment(string cardNum, string expiryDate, decimal totalAmount)
    {
        // Imagine this method processes payments differently.
        return $"Payment of {totalAmount:C} processed for card {cardNum}";
    }
}