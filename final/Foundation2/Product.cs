public class Product 
{
    protected string _nameProduct;
    protected string _ID;
    private double _costOfProduct ;
    private int _quantity;

    public Product(string name , string ID ,double cost , int quantity)
    {
       _nameProduct = name;
       _ID = ID;
       _costOfProduct = cost;
       _quantity = quantity;
    }
    public Product()
    {

    }
    public double GetTotalCost()
    {
       double total = _costOfProduct * _quantity;
       return total;
    }
    
    public string GetName()
    {
        return _nameProduct;
    }
    
    public string GetID()
    {
        return _ID;
    }
    
}
