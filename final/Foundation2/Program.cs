using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Address address1 = new Address("1234 Cherry Lane", "Rexburg", "ID", "US", "83440");
        Customer customer1 = new Customer("Billy Bob", address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product("Cherries", "627DF8", 6, 2);
        Product product2 = new Product("Lightbulbs", "7289GFH9", 10, 1);
        Product product3 = new Product("Flowers", "2GFHD9", 15, 1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Address address2 = new Address("786 Bumblebee Road", "Daegu", "Korea", "Korea");
        Customer customer2 = new Customer("Daniel Choi", address2);
        Order order2 = new Order(customer2);
        Product product4 = new Product("Ramen", "CYJ913", 3, 5);
        Product product5 = new Product("Jacket", "C31BG3", 1, 50);
        Product product6 = new Product("Hot cheetos", "205KTH", 3, 2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        orders.Add(order1);
        orders.Add(order2);

        foreach (Order order in orders) 
        {
            order.DisplayPackingLabel();
            Console.WriteLine();
            order.DisplayShippingLabel();
        }

    }
}