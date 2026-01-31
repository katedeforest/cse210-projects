using System;
using System.Collections.Generic;

public class Product
{
    private string _name;
    private int _productId;
    private decimal _price;
    private int _quantity;

    public Product(string name, int productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductName()
    {
        return _name;
    }
    public int GetProductId()
    {
        return _productId;
    }

    public decimal GetTotalCost()
    {
        decimal totalCost = _price * _quantity;
        return totalCost;
    }
}