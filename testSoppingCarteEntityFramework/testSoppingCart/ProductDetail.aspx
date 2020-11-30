<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" %>

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            int id = int.Parse(Request.QueryString["id"]);

            Product prod = ProductUtility.GetAllProductsById(id);

            Image1.ImageUrl = $"~/Upload/{prod.ImageFileName}";

            Label1.Text = prod.Name;

            Label2.Text = prod.Price.ToString();

            HiddenField1.Value = id.ToString();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //判斷session有沒有被加過,沒有初始化一個Dictionary
        if (Session["shoppintCart"] == null)
        {
            Session["shoppintCart"]= new Dictionary<int, int>();
        }


        //產品ID + 數量
        Dictionary<int, int> shoppintCart = Session["shoppintCart"] as Dictionary<int, int>;

        int id = int.Parse(HiddenField1.Value);
        int count = int.Parse(TextBox1.Text);

        //判斷id有沒有加過,有加過的話數量累加,沒有加過的話新增
        if (shoppintCart.ContainsKey(id) == true)
        {
            shoppintCart[id] += count;
        }
        else
        {
            shoppintCart.Add(id, count);
        }

        
    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="myCSS" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="myContent" Runat="Server">

    <asp:Image ID="Image1" runat="server" />
    <br />
    產品名稱 : <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
    價格 : <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <hr />
    <asp:HiddenField ID="HiddenField1" runat="server" />
    數量<asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="加入購物車" OnClick="Button1_Click" />

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="myJavaScript" Runat="Server">
</asp:Content>

