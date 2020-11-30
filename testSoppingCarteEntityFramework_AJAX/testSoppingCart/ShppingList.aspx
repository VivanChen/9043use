<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" %>

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            Dictionary<int, int> shoppintCart = Session["shoppintCart"] as Dictionary<int, int>;

            //Dictionary.keys => List<Product>
            List<int> idList = shoppintCart.Keys.ToList();
            List<Product> prodList = ProductUtility.GetAllProductsByIds(idList);

            //Dictionary.values + List<Product> => List<ShoppingCart>
            var query = from prod in prodList
                        select new ShoppingCart()
                        {
                            Id = prod.Id,
                            Name = prod.Name,
                            Price = prod.Price,
                            ImageFileName = prod.ImageFileName,
                            Count = shoppintCart[prod.Id]
                        };


            Repeater1.DataSource = query.ToList();
            Repeater1.DataBind();
        }

    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="myCSS" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="myContent" runat="Server">

    <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate>
            <%--表頭,標籤的上半段--%>
            <table class="w3-table-all w3-hoverable">
                <thead>
                    <tr class="w3-light-grey">
                        <th>圖片</th>
                        <th>產品名稱</th>
                        <th>價格</th>
                        <th>購買數量</th>
                    </tr>
                </thead>
        </HeaderTemplate>

        <ItemTemplate>
            <%--中間資料列,要加上繫結語法 Eval--%>
            <tr>
                <td>
                    <asp:Image ID="Image1" runat="server" style="width:15%" ImageUrl='<%# Eval("ImageFileName" , "~/Upload/{0}") %>' />
                </td>
                <td><%# Eval("Name") %></td>
                <td><%# Eval("Price") %></td>
                <td><%# Eval("Count") %></td>
            </tr>
        </ItemTemplate>

        <FooterTemplate>
            <%--表尾,標籤的後半段--%>
             </table>
        </FooterTemplate>

    </asp:Repeater>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="myJavaScript" runat="Server">
</asp:Content>

