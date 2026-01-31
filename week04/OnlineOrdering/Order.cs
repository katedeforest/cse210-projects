using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(string name, int productId, decimal price, int quantity)
    {
        Product product = new Product(name, productId, price, quantity);
        _products.Add(product);
    }
    public decimal GetTotalCost()
    {
        decimal totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        decimal shippingCost;
        if (_customer.IsInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        totalCost += shippingCost;

        return totalCost;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "Products: ";

        foreach (Product product in _products)
        {
            if (packingLabel != "Products: ")
            {
                packingLabel += ", ";
            }
            
            string productLabel = $"{product.GetProductName()}-{product.GetProductId()}";
            packingLabel += productLabel;
        }
        
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        string shippingLabel = $"Name: {_customer.GetName()}\nAddress: {_customer.GetAddress()}";
        return shippingLabel;
    }
}