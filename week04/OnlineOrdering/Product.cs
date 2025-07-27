public class Product
{
    private string _name;
    private string _product_id;
    private double _price;
    private int _quantity;


    public string get_name()
    {
        return _name;
    }
    public string get_product_id()
    {
        return _product_id;
    }
 public void set_name(string name)
    {
        _name = name;
    }
     public int get_quantity()
    {
        return _quantity;
    }
    public double get_price()
    {
        return _price;
    }
   
    public double get_total_cost()
    {
        return _price * _quantity;
    }


    public void set_product_id(string product_id)
    {
        _product_id = product_id;
    }

    public void set_price(double price)
    {
        _price = price;
    }

    public void set_quantity(int quantity)
    {
        _quantity = quantity;
    }
   
}