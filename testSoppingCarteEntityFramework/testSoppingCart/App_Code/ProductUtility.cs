using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public static class ProductUtility
{
    public static List<Product> GetAllProducts()
    {
        MyDBEntities db = new MyDBEntities();

        return db.Products.ToList();

    }

    public static List<Product> GetAllProductsByName(string name)
    {
        MyDBEntities db = new MyDBEntities();

        var query = from prod in db.Products
                    where prod.Name.Contains(name)
                    select prod;

        return query.ToList();

    }

    public static Product GetAllProductsById(int id)
    {
        MyDBEntities db = new MyDBEntities();

        var query = from prod in db.Products
                    where prod.Id == id
                    select prod;

        return query.SingleOrDefault();

    }

    public static List<Product> GetAllProductsByIds(List<int> idList)
    {
        MyDBEntities db = new MyDBEntities();

        var query = from prod in db.Products
                    where idList.Contains(prod.Id)
                    select prod;

        return query.ToList();
    }

    public static void InsertProduct(Product p)
    {
        MyDBEntities db = new MyDBEntities();

        db.Products.Add(p);

        db.SaveChanges();
    }

    public static void UpdateProduct(Product p)
    {
        MyDBEntities db = new MyDBEntities();

        db.Entry(p).State = System.Data.Entity.EntityState.Modified;

        db.SaveChanges();
    }

    public static void DeleteProduct(int id)
    {
        MyDBEntities db = new MyDBEntities();

        var query = from prod in db.Products
                    where prod.Id == id
                    select prod;

        Product p = query.SingleOrDefault();

        db.Products.Remove(p);

        db.SaveChanges();

    }
}