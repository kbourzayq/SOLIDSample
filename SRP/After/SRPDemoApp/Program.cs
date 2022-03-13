using SRPDemoApp;

Product product = new("this is a new product", "product 1", 20);
Console.WriteLine("Change description with empty string");
try
{
    product.ChangeDescription("");
}
catch (ProductBusinessException productBusinessException)
{
    Console.WriteLine(productBusinessException.Message);
}
Console.WriteLine("Change price with 0");
try
{
    product.ChangePrice(0);
}
catch (ProductBusinessException productBusinessException)
{
    Console.WriteLine(productBusinessException.Message);
}
Console.WriteLine("Change price with lower price");
try
{
    product.ChangePrice(18);
}
catch (ProductBusinessException productBusinessException)
{
    Console.WriteLine(productBusinessException);
}

IProductRepository repository = new ProductRepository();
Console.WriteLine("save product to file");
repository.Save(product);
Console.WriteLine("Generate report file");
IProductTextReporting  report = new ProductTextReporting();
report.GenerateReportFile(product);