namespace SRPDemoApp;

public class ProductBusinessException : Exception
{
    public ProductBusinessException(string message) : base(message)
    {
    }
}

public static class BusinessExceptionMessages
{
    public const string PriceIsnullErrorMessage = "price can't be zero!";
    public const string DescriptionIsnullErrorMessage = "description can't be null";
}