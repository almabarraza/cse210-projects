using System;

using System.Collections.Generic;
using System.Runtime.Intrinsics.Wasm;

public class Customer
{
    private string _nameCustomer;
    private Address _address;



public Customer(string name, Address address)
{
    _nameCustomer = name;
    _address = address;

}


public bool IfLiveUsa()
{
    if(_address.IsUsaContry() == true)
    {
        return true;
    }
    else
    {
        return false;   
    }

}

public string GetDisplayCustomer()
{

    return   $"{_nameCustomer} {_address.GetDisplayAddress()}";

}
}

    


