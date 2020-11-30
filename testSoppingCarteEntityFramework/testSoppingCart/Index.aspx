<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" %>

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {
        //Label1.Text = Common.DBConnectionString;
    }

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="myCSS" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="myContent" Runat="Server">
    <h1>首頁</h1>
<p>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</p>
    <p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" 
        DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display." 
        >
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
            <asp:BoundField DataField="Amount" HeaderText="Amount" SortExpression="Amount" />
            <asp:TemplateField HeaderText="ImageFileName" SortExpression="ImageFileName">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ImageFileName") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("ImageFileName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MyDBConnectionString1 %>" DeleteCommand="DELETE FROM [Products] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Products] ([Name], [Price], [Amount], [ImageFileName]) VALUES (@Name, @Price, @Amount, @ImageFileName)" ProviderName="<%$ ConnectionStrings:MyDBConnectionString1.ProviderName %>" SelectCommand="SELECT [Id], [Name], [Price], [Amount], [ImageFileName] FROM [Products]" UpdateCommand="UPDATE [Products] SET [Name] = @Name, [Price] = @Price, [Amount] = @Amount, [ImageFileName] = @ImageFileName WHERE [Id] = @Id">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Price" Type="Int32" />
            <asp:Parameter Name="Amount" Type="Int32" />
            <asp:Parameter Name="ImageFileName" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Price" Type="Int32" />
            <asp:Parameter Name="Amount" Type="Int32" />
            <asp:Parameter Name="ImageFileName" Type="String" />
            <asp:Parameter Name="Id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</p>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="myJavaScript" Runat="Server">
</asp:Content>

