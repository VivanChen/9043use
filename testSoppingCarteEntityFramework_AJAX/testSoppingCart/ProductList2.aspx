<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" %>

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            Repeater1.DataSource = ProductUtility.GetAllProducts();
            Repeater1.DataBind();
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Button btn = sender as Button;

        int id = int.Parse(btn.CommandArgument);
        ProductUtility.DeleteProduct(id);

        Repeater1.DataSource = ProductUtility.GetAllProducts();
        Repeater1.DataBind();
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
                        <th>編號</th>
                        <th>產品名稱</th>
                        <th>價格</th>
                        <th>數量</th>
                        <th>功能</th>
                    </tr>
                </thead>
        </HeaderTemplate>


        <ItemTemplate>
            <%--中間資料列,要加上繫結語法 Eval--%>
            <tr>
                <td><%# Eval("Id") %></td>
                <td><%# Eval("Name") %></td>
                <td><%# Eval("Price") %></td>
                <td><%# Eval("Amount") %></td>
                <td>
                    <asp:HyperLink ID="HyperLink1" CssClass="w3-button w3-black" runat="server"
                        NavigateUrl='<%# Eval("Id" , "ProductEdit.aspx?id={0}") %>'>編輯</asp:HyperLink>

                    <asp:HyperLink ID="HyperLink2" CssClass="w3-button w3-black" runat="server"
                        NavigateUrl='<%# Eval("Id" , "ProductDelete.aspx?id={0}") %>' onclick="check()">刪除</asp:HyperLink>

                    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" CommandArgument='<%# Eval("Id") %>'
                        OnClientClick="return confirm('delete?');"    />
                </td>
            </tr>
        </ItemTemplate>

        <FooterTemplate>
            <%--表尾,標籤的後半段--%>
             </table>
        </FooterTemplate>

    </asp:Repeater>



</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="myJavaScript" runat="Server">

    <script>
        function check() {
            //alert("check");

            if (confirm("Delete?") == false) {
                event.preventDefault();  //停止導向
            }

        }


    </script>

</asp:Content>

