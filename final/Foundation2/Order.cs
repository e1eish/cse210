public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetPrice();
        }
        if (_customer.IsInUS())
        {
            total += 5;
        } else {
            total += 35;
        }
        return total;
    }

    public void GetPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetPackingInfo());
        }
    }

    public void GetShippingLabel()
    {
        Console.WriteLine(_customer.GetShippingInfo());
    }

    public void DisplayTotalCost()
    {
        Console.WriteLine($"Total Cost: ${Math.Round(CalculateTotalCost(), 2)}");
    }
}