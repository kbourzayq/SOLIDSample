using System.Text;

namespace SRPDemoApp;

public class Product
{
    public string Label { get; set; }
    public string Description { get; private set; }
    public double Price { get; private set; }

    private readonly StringBuilder _priceActions = new();

    public Product(string description, string label, double price)
    {
        Label = label;
        ChangeDescription(description);
        ChangePrice(price);
    }

    public void ChangePrice(double price)
    {
        ProductValidator.ValidatePrice(price);
        if (price < Price)
            _priceActions.Append($"New price applied to the product : ' {Label} '" +
                                 $". \n Old price {Price} " +
                                 $"\n New Price is {price}");
        Price = price;
    }

    public void ChangeDescription(string desc)
    {
        ProductValidator.ValidateDescription(desc);
        Description = desc;
    }

    public string GetPriceChanges()
    {
        return _priceActions.ToString();
    }
}