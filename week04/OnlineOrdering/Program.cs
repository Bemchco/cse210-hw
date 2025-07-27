using System;

class Program
{
    static void Main(string[] args)
    {
        Product _product1 = new Product();
        _product1.set_name("Laptop");
        _product1.set_product_id("P001");
        _product1.set_price(20);
        _product1.set_quantity(1);
        Product _product2 = new Product();
        _product2.set_name("Mouse");
        _product2.set_product_id("P002");
        _product2.set_price(20);
        _product2.set_quantity(2);
        List<Product> _products = new List<Product> { _product1, _product2 };
        Address _address = new Address();
        _address.set_address("123 Main St", "Springfield", "IL", "Guatemala");
        Customer _customer = new Customer();
        _customer.set_name("John Doe");
        _customer.set_address(_address);
        Order _order = new Order();
        _order.set_customer(_customer);
        _order.set_products(_products);
        Console.WriteLine(_order.get_packaging_label());
        Console.WriteLine(_order.get_shipping_label());
        Console.WriteLine("Total Cost: $" + _order.get_total_cost() + "\n");

        Product _product3 = new Product();
        _product3.set_name("Keyboard");
        _product3.set_product_id("P003");
        _product3.set_price(15);
        _product3.set_quantity(1);
        Product _product4 = new Product();
        _product4.set_name("Monitor");
        _product4.set_product_id("P004");
        _product4.set_price(150);
        _product4.set_quantity(1);
        List<Product> _products2 = new List<Product> { _product3, _product4 };
        Address _address2 = new Address();
        _address2.set_address("456 Elm St", "Springfield", "IL", "USA");
        Customer _customer2 = new Customer();
        _customer2.set_name("Jane Smith");
        _customer2.set_address(_address2);
        Order _order2 = new Order();
        _order2.set_customer(_customer2);
        _order2.set_products(_products2);
        Console.WriteLine(_order2.get_packaging_label());
        Console.WriteLine(_order2.get_shipping_label());
        Console.WriteLine("Total Cost: $" + _order2.get_total_cost() + "\n");
    }
}