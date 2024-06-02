
public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;

    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public string  CalculateTotalCost()
    {
        double totalCoast = 0;
            totalCoast += _customer.IsInUSA()? 5 : 35;

        foreach (Product product1 in _products)
        {
            totalCoast += product1.GetTotalcost();
        }
        return $"Total Cost \t:${Math.Round(totalCoast, 2)}";

    }
    public string GetPackingLabel ()
    {
        string packingLabel = "Packing Label :\n";
        foreach (var Product in _products)
        {
            packingLabel += $"{Product.GetName()}\t(ID:{Product.GetProductId()})\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label:\nName of customer:{_customer.GetName()} \nAddress \t:{_customer.GetAdress()}";
    }
}
    