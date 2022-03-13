using System.Text;

namespace SRPDemoApp;

public class ProductValidator
{
    public static void ValidatePrice(double price)
    {
        if (price == 0)
            throw new ProductBusinessException(BusinessExceptionMessages.PriceIsnullErrorMessage);
    }

    public static void ValidateDescription(string description)
    {
        if (string.IsNullOrWhiteSpace(description))
            throw new ProductBusinessException(BusinessExceptionMessages.DescriptionIsnullErrorMessage);
    }
}