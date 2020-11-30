<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" %>

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

        GridView1.DataSource = ProductUtility.GetAllProducts();
        GridView1.DataBind();

    }

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="myCSS" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="myContent" Runat="Server">
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="myJavaScript" Runat="Server">
</asp:Content>

