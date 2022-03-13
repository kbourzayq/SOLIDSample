using System.Reflection.Emit;

namespace SRPDemoApp;

public class ProductRepository : IProductRepository
{
    public void Save(Product product)
    {
        var fs = new FileStream("products.txt", FileMode.Append, FileAccess.Write);
        var writer = new StreamWriter(fs);
        writer.WriteLine($"Label:{product.Label},Description:{product.Description},Price:{product.Price}");
        writer.Close();
        fs.Close();
    }
}