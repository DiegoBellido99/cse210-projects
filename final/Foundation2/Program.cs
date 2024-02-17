using System;
// In this code I was able to create 3 orders, each one //
// shows the list of products purchased, the person who //
// placed the order, and the total cost of their order  //


class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("Husares de junin","comas","lima","Peru");

        Customer customer1 = new Customer("Diego Bellido",address);

        List<Product> products = new List<Product>()
        {
            new Product ("Tv","140299",1200,2),
            new Product ("Washing Machine","159487",500,1),
            new Product("Microwave","895623",350,3)
        };

        Order order1 = new Order(customer1,products);
        
        order1.ShippingLabel();
        order1.PackingLabel();
        Console.WriteLine($"{order1.TotalPrice()}");
        Console.WriteLine();


       Address address2 = new Address("E 400 N","American Fork","Utah","USA");

        Customer customer2 = new Customer("Salvador Lopez",address2);

        List<Product> products2 = new List<Product>()
        {
            new Product ("PS5","741258",1500,1),
            new Product ("TV","140299",500,3),
            new Product("Cooker","123654",350,1),
            new Product("Iphone 14 pro max","101203",460,1),
            new Product("Refrigerator","789410",550,1)
        };

        Order order2 = new Order(customer2,products2);
        
        order2.ShippingLabel();
        order2.PackingLabel();
        Console.WriteLine($"{order2.TotalPrice()}");  
        Console.WriteLine();  

        Address address3 = new Address("17th st","Mission district","San Francisco","USA");

        Customer customer3 = new Customer("Ariana Molina",address3);

        List<Product> products3 = new List<Product>()
        {
            new Product ("dryer","791346",250,1),
            new Product ("TV","140299",500,1),
            new Product("stereo","852963",300,2)
        };

        Order order3 = new Order(customer3,products3);
        
        order3.ShippingLabel();
        order3.PackingLabel();
        Console.WriteLine($"{order3.TotalPrice()}");  
        Console.WriteLine();         
    }
}