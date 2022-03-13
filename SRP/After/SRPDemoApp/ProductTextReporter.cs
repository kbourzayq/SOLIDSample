using System.Reflection.Emit;
using System.Text;

namespace SRPDemoApp;

public class ProductTextReporting : IProductTextReporting
{
    public void GenerateReportFile(Product product)
    {
        var fs = new FileStream("report.txt", FileMode.Create, FileAccess.Write);
        var writer = new StreamWriter(fs);
        writer.WriteLine("****this is a report****");
        writer.WriteLine("product basic infos");
        writer.WriteLine("-----------------------------------");
        writer.WriteLine($"{product.Label} - {product.Price}");
        writer.WriteLine($"Description : {product.Description}");
        writer.WriteLine("-----------------------------------");
        writer.WriteLine("price actions");
        writer.WriteLine($"{product.GetPriceChanges()}");
        writer.Close();
        fs.Close();
    }
}