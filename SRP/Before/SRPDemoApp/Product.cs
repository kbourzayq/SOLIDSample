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
        if (price == 0)
        {
            Console.WriteLine("price can't be zero!");
            throw new ArgumentNullException(nameof(price));
        } if (price < Price)
            _priceActions.Append($"New price applied to the product : ' {Label} '" +
                                 $". \n Old price {Price} " +
                                 $"\n New Price is {price}");
        Price = price;
    }

    public void ChangeDescription(string desc)
    {
        if (string.IsNullOrWhiteSpace(desc))
        {
            Console.WriteLine("description can't be null");
            throw new ArgumentNullException(nameof(desc));
        }
        Description = desc;
    }

    public void Save()
    {
        var fs = new FileStream("products.txt", FileMode.Append, FileAccess.Write);
        var writer = new StreamWriter(fs);
        writer.WriteLine($"Label:{Label},Description:{Description},Price:{Price}");
        writer.Close();
        fs.Close();
    }

    public void GenerateReportFile()
    {
        var fs = new FileStream("report.txt", FileMode.Create, FileAccess.Write);
        var writer = new StreamWriter(fs);
        writer.WriteLine("****this is a report****");
        writer.WriteLine("product basic infos");
        writer.WriteLine("-----------------------------------");
        writer.WriteLine($"{Label} - {Price}");
        writer.WriteLine($"Description : {Description}");
        writer.WriteLine("-----------------------------------");
        writer.WriteLine("price actions");
        writer.WriteLine($"{_priceActions}");
        writer.Close();
        fs.Close();
    }
}