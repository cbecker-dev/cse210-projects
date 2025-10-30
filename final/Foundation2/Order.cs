using System;

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

    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }

        if (_customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product p in _products)
        {
            label += p.GetName() + " (" + p.GetProductId() + ")\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = _customer.GetName() + "\n" + _customer.GetAddress().GetFullAddress();
        return label;
    }
}