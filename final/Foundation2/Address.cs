using System;
using System.Collections.Generic;
using System.Text;
public class Address
{
    private string _street;
    public string street
    {
        get {return _street;}
        set {_street = value;}
    }

    private string _city;
    public string city
    {
        get {return _city;}
        set {_city = value;}
    }

    private string _stateOrProvince;
    public string stateOrProvince
    {
        get {return _stateOrProvince;}
        set {_stateOrProvince = value;}
    }

    private string _country;
    public string country
    {
        get {return _country;}
        set {_country = value;}
    }

    public Address(string street, string city, string stateOrProvince, string country)
   {
    _street = street;
    _city = city;
    _stateOrProvince = stateOrProvince;
    _country = country;
   }

   public bool isInUSA()
   {
    return country == "USA";
   }

   public string getFullAddress()
   {
    return $"Street:{street}, City:{city}, State/Province:{stateOrProvince}, Country:{country}";
   }
}