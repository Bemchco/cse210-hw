public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public void set_customer(Customer customer)
    {
        _customer = customer;
    }
    public Customer get_customer()
    {
        return _customer;
    }
    public void set_products(List<Product> products)
    {
        _products = products;
    }
    public List<Product> get_products()
    {
        return _products;
    }
    public double get_total_cost()
    {
        double _total_cost = 0;
        foreach (var product in _products)
        {
            _total_cost += product.get_total_cost();
        }
        if (_customer.lives_in_usa())
        {
            _total_cost += 5;
        }
        else
        {
            _total_cost += 35;
        }
        return _total_cost;
    }

    public string get_packaging_label()
    {
        string _label = $"\nOrder Summary:\n";
        _label += "Products:\n";
        foreach (var product in _products)
        {
            _label += $"{product.get_product_id()} - {product.get_name()} \n";
        }
        return _label;
    }

    public string get_shipping_label()
    {

        string _label = $"Customer: {_customer.get_name()}\n";
        _label += $"Address: {_customer.get_address().get_full_address()}\n";
        return _label;
    }
}