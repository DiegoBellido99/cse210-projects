public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order ( Customer customer , List<Product> products)
    {
        _products = products;
        _customer = customer; 
    } 

    public string TotalPrice()
    {
        double totalPrice = 0;

        foreach(Product product in _products)
        {
            totalPrice = totalPrice + product.GetTotalCost();
        }

        double totalSumCost= _customer.IsInUSA();
        return $"the total cost of the order is ${totalPrice + totalSumCost}";
    }

    public void PackingLabel()
    {
        foreach(Product product in _products)
        {
            Console.WriteLine($"-Product :{product.GetName()}, ID : {product.GetID()}");
        }
    }
    
    public void ShippingLabel()
    {
        Console.WriteLine($"-Name : {_customer.GetName()}--Address :{_customer.GetAddress()}");
    }
}