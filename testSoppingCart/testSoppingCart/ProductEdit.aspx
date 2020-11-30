<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" %>

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            int id = int.Parse(Request.QueryString["id"]);

            Prodcut p = ProductUtility.GetAllProductsById(id);

            TextBox1.Text = p.Name;
            TextBox2.Text = p.Price.ToString();
            TextBox3.Text = p.Amount.ToString();
            Image1.ImageUrl = $"~/Upload/{p.ImageFileName}";

            HiddenField1.Value = p.Id.ToString();
            HiddenField2.Value = p.ImageFileName;

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)  //如果使用者有上傳檔案,才去另存新檔
        {
            string filePath = Server.MapPath("Upload/" + FileUpload1.FileName);
            FileUpload1.SaveAs(filePath);
        }


        Prodcut p = new Prodcut()
        {
            Id = int.Parse(HiddenField1.Value),
            Name = TextBox1.Text,
            Price = int.Parse(TextBox2.Text),
            Amount = int.Parse(TextBox3.Text),
            ImageFileName = FileUpload1.HasFile ? FileUpload1.FileName : HiddenField2.Value
        };

        ProductUtility.UpdateProduct(p);

        Response.Redirect("~/ProductList2.aspx");
    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="myCSS" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="myContent" runat="Server">

    <div class="w3-container w3-padding-large w3-grey">
        <h4 id="contact"><b>新增產品</b></h4>

        <hr class="w3-opacity">

        <div class="w3-section">
            <label>產品名稱</label>
            <%--<input class="w3-input w3-border" type="text" name="Name" required>--%>
            <asp:TextBox ID="TextBox1" runat="server" class="w3-input w3-border"></asp:TextBox>
        </div>
        <div class="w3-section">
            <label>價格</label>
            <asp:TextBox ID="TextBox2" runat="server" class="w3-input w3-border"></asp:TextBox>
        </div>
        <div class="w3-section">
            <label>數量</label>
            <asp:TextBox ID="TextBox3" runat="server" class="w3-input w3-border"></asp:TextBox>
        </div>
        <div class="w3-section">
            <label>圖片</label>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Image ID="Image1" runat="server" />
        </div>
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <asp:HiddenField ID="HiddenField2" runat="server" />

        <asp:Button ID="Button1" runat="server" Text="Button" class="w3-button w3-black w3-margin-bottom" OnClick="Button1_Click" />

    </div>


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="myJavaScript" runat="Server">
</asp:Content>

