using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public static class ProductUtility
{
    public static List<Prodcut> GetAllProducts()
    {
        SqlDataAdapter da = new SqlDataAdapter(
            "select * from Products",
            Common.DBConnectionString);

        DataTable dt = new DataTable();

        da.Fill(dt);

        //方法1 迴圈
        //List<Prodcut> prodList = new List<Prodcut>();

        //foreach (DataRow row in dt.Rows)
        //{
        //    prodList.Add(new Prodcut() {
        //        Id = Convert.ToInt32(row["id"]),
        //        Name = row["Name"].ToString(),
        //        Price = (int)row["Price"],
        //        Amount = (int)row["Amount"],
        //        ImageFileName = row["ImageFileName"] is DBNull ? "" : row["ImageFileName"].ToString()
        //    });
        //}

        //方法2 LINQ
        var query = from row in dt.AsEnumerable()
                    select new Prodcut() {
                        Id = Convert.ToInt32(row["id"]),
                        Name = row["Name"].ToString(),
                        Price = (int)row["Price"],
                        Amount = (int)row["Amount"],
                        ImageFileName = row["ImageFileName"] is DBNull ? "" : row["ImageFileName"].ToString()
                    };

        List<Prodcut> prodList = query.ToList();

        return prodList;

    }

    public static List<Prodcut> GetAllProductsByName(string name)
    {
        SqlDataAdapter da = new SqlDataAdapter(
            "select * from Products where Name like  '%'+ @Name +'%' ",
            Common.DBConnectionString);

        da.SelectCommand.Parameters.AddWithValue("@Name", name);

        DataTable dt = new DataTable();

        da.Fill(dt);

        //方法2 LINQ
        var query = from row in dt.AsEnumerable()
                    select new Prodcut()
                    {
                        Id = Convert.ToInt32(row["id"]),
                        Name = row["Name"].ToString(),
                        Price = (int)row["Price"],
                        Amount = (int)row["Amount"],
                        ImageFileName = row["ImageFileName"] is DBNull ? "" : row["ImageFileName"].ToString()
                    };

        List<Prodcut> prodList = query.ToList();

        return prodList;

    }

    public static Prodcut GetAllProductsById(int id)
    {
        SqlDataAdapter da = new SqlDataAdapter(
            "select * from Products where Id = @Id ",
            Common.DBConnectionString);

        da.SelectCommand.Parameters.AddWithValue("@Id", id);

        DataTable dt = new DataTable();

        da.Fill(dt);

        DataRow row = dt.Rows[0];

        //方法2 LINQ
        Prodcut p =  new Prodcut()
                    {
                        Id = Convert.ToInt32(row["id"]),
                        Name = row["Name"].ToString(),
                        Price = (int)row["Price"],
                        Amount = (int)row["Amount"],
                        ImageFileName = row["ImageFileName"] is DBNull ? "" : row["ImageFileName"].ToString()
                    };
        return p;

    }

    public static void InsertProduct(Prodcut p)
    {
        SqlConnection cn = new SqlConnection(Common.DBConnectionString);

        SqlCommand cmd = new SqlCommand(
            "insert into Products (Name , Price , Amount , ImageFileName) values (@Name , @Price , @Amount ,@ImageFileName)",
            cn);

        cmd.Parameters.AddWithValue("@Name", p.Name);
        cmd.Parameters.AddWithValue("@Price", p.Price);
        cmd.Parameters.AddWithValue("@Amount", p.Amount);
        cmd.Parameters.AddWithValue("@ImageFileName", p.ImageFileName);

        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
    }

    public static void UpdateProduct(Prodcut p)
    {
        SqlConnection cn = new SqlConnection(Common.DBConnectionString);

        SqlCommand cmd = new SqlCommand(
            "UPDATE Products set Name=@Name , Price=@Price , Amount=@Amount , ImageFileName=@ImageFileName where Id=@Id",
            cn);

        cmd.Parameters.AddWithValue("@Id", p.Id);
        cmd.Parameters.AddWithValue("@Name", p.Name);
        cmd.Parameters.AddWithValue("@Price", p.Price);
        cmd.Parameters.AddWithValue("@Amount", p.Amount);
        cmd.Parameters.AddWithValue("@ImageFileName", p.ImageFileName);

        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
    }

    public static void DeleteProduct(int id)
    {
        SqlConnection cn = new SqlConnection(Common.DBConnectionString);

        SqlCommand cmd = new SqlCommand(
            "DELETE FROM Products where Id=@Id",
            cn);

        cmd.Parameters.AddWithValue("@Id", id);

        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
    }
}