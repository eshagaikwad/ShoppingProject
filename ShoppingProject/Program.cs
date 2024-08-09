using ShoppingProject.Model;

public class Program
{
 
    public static void PrintCustomerDetails(Customer customer)
    {
        Console.WriteLine("Customer Id: "+customer.CustomerId);
        Console.WriteLine("Customer Name: "+customer.CustomerName);
        Console.WriteLine();
    }
    public static void PrintOrderDetails(Order order)
    {

        Console.WriteLine("Order Id: " + order.Id);
        Console.WriteLine("Order Date:  " + order.Date);

        Console.WriteLine(new String('-', 80));
     
        Console.WriteLine($"{"LineItem",-10}|{"ProductId",-10}|{"prodName",-10}|{"Quantity",-10}|{"Price",-10}|{"Discount",-10}|{"After Discount",-10}");
        Console.WriteLine(new String('-', 80));

        foreach (var item in order.Items)
        {
            var product = item.Product;
            Console.WriteLine($"{item.Id,-10}|{product.ProductId,-10}|{product.ProductName,-10}|{item.quantity,-10}|{product.ProductPrice,-10}|{product.ProductDiscountPrice + "%",-10}|{product.GetDiscountPrice(product.ProductPrice, product.ProductDiscountPrice),-10}");
        }

        Console.WriteLine(new String('-', 80));
        Console.WriteLine($"Total Cost:  {order.CalculateOrderPrice(),-10}");
        Console.WriteLine();


    }

    public static void Main(string[] args)
    {
        Customer customer = new Customer(1, "Esha");
        PrintCustomerDetails(customer);

        Product product1 = new Product(1, "Soap", 100, 10);
        Product product2 = new Product(2, "Dahi", 70, 5);
        Product product3 = new Product(3, "Shampoo", 130, 10);
        Product product4 = new Product(4, "Waffers", 50, 5);

        Order order1 = new Order(1, DateTime.Now);
        
        order1.AddItem(new LineItem(1, 2, product1));
        order1.AddItem(new LineItem(2, 3, product2));
        order1.AddItem(new LineItem(3, 4, product3));
        order1.AddItem(new LineItem(4, 3, product4));

        PrintOrderDetails(order1);
       
    }
}
