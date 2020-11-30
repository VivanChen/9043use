<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" %>

<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {
        //存上傳的檔案
        string filePath = Server.MapPath("Upload/" + FileUpload1.FileName);
        FileUpload1.SaveAs(filePath);

        Prodcut p = new Prodcut() { 
            Name = TextBox1.Text ,
            Price =  int.Parse(TextBox2.Text),
            Amount =  int.Parse(TextBox3.Text),
            ImageFileName = FileUpload1.FileName
        };

        ProductUtility.InsertProduct(p);

        Response.Redirect("~/Index2.aspx");
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
        </div>

        <asp:Button ID="Button1" runat="server" Text="Button" class="w3-button w3-black w3-margin-bottom" OnClick="Button1_Click" />

    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="myJavaScript" runat="Server">
</asp:Content>

