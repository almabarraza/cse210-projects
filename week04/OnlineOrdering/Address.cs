using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _contry;

    public Address(string street, string city, string state, string contry)
    {
        _street = street;
        _city = city;
        _state = state;
        _contry = contry;


    }

    public bool IsUsaContry()
    {
        if (_contry != "USA")
        {   
            return false;
        }
        else
        {
            return true;
        }

    }

    public string GetDisplayAddress()
    {

        string fullAddress = $"Street: {_street}\nCity: {_city}\nState: {_state}\nCountry: {_contry}";
                             
        return fullAddress;

    }







}