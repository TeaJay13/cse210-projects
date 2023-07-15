using System;
using System.Collections.Generic;
using System.Text;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Address address
    {
        get { return _address; }
        set { _address = value; }
    }

    public bool isInUSA()
    {
        return _address.isInUSA();
    }
}
