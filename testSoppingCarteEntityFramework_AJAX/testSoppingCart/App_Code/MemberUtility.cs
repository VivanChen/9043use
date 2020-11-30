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

        MyDBEntities db = new MyDBEntities();

        return db.Members.ToList();


    }

    public static void InsertMember(Member m)
    {
        MyDBEntities db = new MyDBEntities();

        db.Members.Add(m);

        db.SaveChanges();
    }

    public static Member FindMember(string userName , string password)
    {
        MyDBEntities db = new MyDBEntities();

        var query = from m in db.Members
                    where m.UserName == userName && m.Password == password
                    select m;

        return query.SingleOrDefault();

    }

    public static Member FindMemberById(int id)
    {
        MyDBEntities db = new MyDBEntities();

        var query = from m in db.Members
                    where m.Id == id
                    select m;

        return query.SingleOrDefault();

    }
}