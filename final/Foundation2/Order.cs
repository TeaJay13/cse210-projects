using System;
using System.Collections.Generic;
using System.Text;
public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private double _shippingCost;


    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
      _shippingCost = 0.0;

        if (_customer.isInUSA())
        {
            _shippingCost = 5.0;
        }
        else
        {
            _shippingCost = 35.0;
        }

    }

 
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0.0;

    foreach (Product product in _products)
        {
            totalCost += product.calcPrice();
        }
        return totalCost + _shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder("Packing Label:\n");
        foreach (Product product in _products)
        {
            packingLabel.AppendLine($"Product Name: {product.productName}, Product ID: {product.productId}");
        }
        return packingLabel.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder shippingLabel = new StringBuilder("Shipping Label:\n");
        shippingLabel.AppendLine($"Customer Name: {_customer.name}");
        shippingLabel.AppendLine($"Customer Address: {_customer.address.getFullAddress()}");
        return shippingLabel.ToString();
    }
}
