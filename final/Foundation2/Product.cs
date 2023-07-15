using System;
using System.Collections.Generic;
using System.Text;

public class Product
{
     private string _productName;

    public string productName
    {
        get {return _productName;}
        set {_productName = value;}
    }
    private int _productId;

    public int productId
    {
        get {return _productId;}
        set {_productId = value;}
    }
    private double _price;

     public double price
    {
        get {return _price;}
        set {_price = value;}
    }

    private int _quantity;
    public int quantity
    {
        get {return _quantity;}
        set {_quantity = value;}
    }


    public double calcPrice()
    {
        return price * quantity;
    }


}