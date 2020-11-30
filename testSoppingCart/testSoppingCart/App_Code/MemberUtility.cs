using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MemberUtility
/// </summary>
public class MemberUtility
{
    public static List<Member> GetAllMembers()
    {
        SqlDataAdapter da = new SqlDataAdapter(
            "select * from Members",
            Common.DBConnectionString);

        DataTable dt = new DataTable();

        da.Fill(dt);


        //方法2 LINQ
        var query = from row in dt.AsEnumerable()
                    select new Member()
                    {
                        Id = Convert.ToInt32(row["id"]),
                        UserName = row["UserName"].ToString(),
                        Password = row["Password"].ToString(),
                        ImageFileName = row["ImageFileName"] is DBNull ? "" : row["ImageFileName"].ToString()
                    };

        List<Member> memberList = query.ToList();

        return memberList;

    }

    public static void InsertMember(Member m)
    {
        SqlConnection cn = new SqlConnection(Common.DBConnectionString);

        SqlCommand cmd = new SqlCommand(
            "insert into Members (UserName , Password , ImageFileName) values (@UserName , @Password ,@ImageFileName)",
            cn);

        cmd.Parameters.AddWithValue("@UserName", m.UserName);
        cmd.Parameters.AddWithValue("@Password", m.Password);
        cmd.Parameters.AddWithValue("@ImageFileName", m.ImageFileName);

        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
    }

    public static Member FindMember(string userName , string password)
    {
        SqlDataAdapter da = new SqlDataAdapter(
            "select * from Members where UserName=@UserName and Password=@Password",
            Common.DBConnectionString);

        da.SelectCommand.Parameters.AddWithValue("@UserName", userName);
        da.SelectCommand.Parameters.AddWithValue("@Password", password);

        DataTable dt = new DataTable();

        da.Fill(dt);

        if (dt.Rows.Count  == 0) //找不到
        {
            return null;
        }

        DataRow row = dt.Rows[0];

        //方法2 LINQ
       Member m =  new Member()
                    {
                        Id = Convert.ToInt32(row["id"]),
                        UserName = row["UserName"].ToString(),
                        Password = row["Password"].ToString(),
                        ImageFileName = row["ImageFileName"] is DBNull ? "" : row["ImageFileName"].ToString()
                    };

        return m;

    }

    public static Member FindMemberById(int id)
    {
        SqlDataAdapter da = new SqlDataAdapter(
            "select * from Members where Id=@Id",
            Common.DBConnectionString);

        da.SelectCommand.Parameters.AddWithValue("@Id", id);

        DataTable dt = new DataTable();

        da.Fill(dt);

        DataRow row = dt.Rows[0];

        //方法2 LINQ
        Member m = new Member()
        {
            Id = Convert.ToInt32(row["id"]),
            UserName = row["UserName"].ToString(),
            Password = row["Password"].ToString(),
            ImageFileName = row["ImageFileName"] is DBNull ? "" : row["ImageFileName"].ToString()
        };

        return m;

    }
}