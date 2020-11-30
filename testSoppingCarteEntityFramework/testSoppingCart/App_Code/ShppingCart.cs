using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ShppingCart
/// </summary>
public class ShoppingCart
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public int Count { get; set; }
    public string ImageFileName { get; set; }
}