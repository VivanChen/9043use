<%@ WebService Language="C#" Class="WebService" %>

using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Collections.Generic;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{
    [WebMethod]
    public void ProductAdd(string name, int price, int amount)
    {
        Product p = new Product()
        {
            Name = name,
            Price = price,
            Amount = amount
        };

        ProductUtility.InsertProduct(p);
    }

    [WebMethod]
    public List<Product> ProductQuery(string name)
    {
        return ProductUtility.GetAllProductsByName(name);
    }

    [WebMethod]
    public List<Member> MemberList()
    {
        return MemberUtility.GetAllMembers();
    }


}