using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;


    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;

    }

    public string PackingLabel()
    {   
        string packing;
        string packingPrint = "";

        foreach(Product product in _products)
        {
          
             packing = product.GetDisplayproduct();
             packingPrint =$"{packingPrint}\n" + $"{packing}";
        }
      
        return packingPrint;
        
    }

    public string ShippingLabel()
    {   
        return $"{_customer.GetDisplayCustomer()}";

    }

    public double TotalPrice()
    {
        double totalPriceOrder = 0.00;
        double shippingCost = 0.00;
        double sumTotalCost = TotalCostOrder();

        if (_customer.IfLiveUsa() == true)
        {
            shippingCost = 5.0;
        }
        else
        {
            shippingCost = 35.00;
        }

        totalPriceOrder = sumTotalCost + shippingCost;

        return totalPriceOrder;
    }

    public void DisplayOrder()
    {

            Console.WriteLine($"Products:\n{_products}");
        
    }


    public double TotalCostOrder()
    {
        double sumTotalCost = 0.0;
        foreach(Product productCost in _products)
        {
            sumTotalCost = sumTotalCost + productCost.TotalCostProduct();
        }
        return sumTotalCost;
    }




}