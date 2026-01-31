using System;
using System.Collections.Generic;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, string stringAddress)
    {
        _name = name;

        string[] addressParts = stringAddress.Split(", ");
        Address address = new Address(addressParts[0], addressParts[1], addressParts[2], addressParts[3]);
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address.GetFullAddress();
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
}