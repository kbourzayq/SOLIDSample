using SRPDemoApp;

Product product = new Product("new product description", "new product", 20);
try
{
    product.ChangeDescription("");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    product.ChangePrice(0);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


try
{
    product.ChangePrice(18);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

product.Save();
product.GenerateReportFile();

