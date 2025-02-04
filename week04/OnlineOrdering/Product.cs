using System;

public class Product
{
    private string _nameProduct;
    private int _productId;
    private double _price;
    private int _quantityEachProduct;

    public Product(string nameProduct, int productId, double price, int quantityEachProduct)
    {
        _nameProduct = nameProduct;
        _productId = productId;
        _price = price;
        _quantityEachProduct = quantityEachProduct;

    }

    public double TotalCostProduct()
    {

        double totalCost = _price * _quantityEachProduct;
        return totalCost;
    }

        
    public string GetDisplayproduct()
    {
        string productInf = $"Product name: {_nameProduct} ID-Product: {_productId}";
        return productInf;

    }



    
}