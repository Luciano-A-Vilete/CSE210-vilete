using System.Collections.Generic;
using System.Linq;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        this._products = products;
        this._customer = customer;
    }

    public List<Product> Products { get => _products; set => _products = value; }
    public Customer Customer { get => _customer; set => _customer = value; }

    public double TotalCost()
    {
        double totalProductCost = _products.Sum(p => p.TotalCost());
        double shippingCost = _customer.LivesInUSA() ? 5 : 35;
        return totalProductCost + shippingCost;
    }

    public string PackingLabel()
    {
        return string.Join("\n", _products.Select(p => $"{p.Name} ({p.ProductId})"));
    }

    public string ShippingLabel()
    {
        return $"{_customer.Name}\n{_customer.Address}";
    }
}