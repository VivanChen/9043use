<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" %>

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {
        Repeater1.DataSource = ProductUtility.GetAllProducts();
        Repeater1.DataBind();

    }

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="myCSS" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="myContent" runat="Server">
    <h1>首頁</h1>
    <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate>
            <div class="w3-row-padding">
        </HeaderTemplate>

        <ItemTemplate>
            <div class="w3-third w3-container w3-margin-bottom">
                <img src='<%# Eval("ImageFileName" , "Upload/{0}") %>' alt="Norway" style="width: 50%" class="w3-hover-opacity">
                <div class="w3-container w3-white">
                    <p><b><%# Eval("Name") %></b></p>
                    <p>價格 : <%# Eval("Price" , "{0:C}" ) %> 元</p>
                </div>
            </div>
        </ItemTemplate>

        <FooterTemplate>
            </div>
        </FooterTemplate>
    </asp:Repeater>



</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="myJavaScript" runat="Server">
</asp:Content>

