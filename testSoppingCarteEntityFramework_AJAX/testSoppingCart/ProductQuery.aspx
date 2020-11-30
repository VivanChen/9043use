<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" %>

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

        //Repeater1.DataSource = ProductUtility.GetAllProducts();
        //Repeater1.DataBind();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != "")
        {
            Repeater1.DataSource = ProductUtility.GetAllProductsByName(TextBox1.Text);
            Repeater1.DataBind();
        }

    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="myCSS" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="myContent" runat="Server">

    <p>
        <asp:TextBox ID="TextBox1" runat="server" placeholder="產品名稱">

        </asp:TextBox><asp:Button ID="Button1" runat="server" Text="Button" OnClientClick="return false" />
    </p>

    <table class="w3-table-all w3-hoverable">
        <thead>
            <tr class="w3-light-grey">
                <th>編號</th>
                <th>產品名稱</th>
                <th>價格</th>
                <th>數量</th>
            </tr>
        </thead>
        <tbody id="myTableBody">
            <%--資料在這邊產生--%>

        </tbody>
    </table>


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

        $(function () {

            $("#myContent_Button1").click(function () {

                var myData = {
                    name: $("#myContent_TextBox1").val()
                };

                $.ajax({
                    type: 'POST',
                    url: 'WebService.asmx/ProductQuery',
                    contentType: "application/json;charset=utf-8",
                    data: JSON.stringify(myData),
                    success: function (data) {
                        //console.log(data.d);
                        //console.log(data.d[0].Name);

                        //foreach(var item  in data.d)

                        $(data.d).each(function (index , item) {
                            //console.log(item.Name);
                            //生標籤
                            //$("tr")  //找tr
                            //$("<tr>")//產生tr
                            //<tr>CPU</tr>
                            //$("<tr>").html(item.Name).appendTo("#myTableBody");

                            //方法一
                            //var $id = $("<td>").html(item.Id);
                            //var $name = $("<td>").html(item.Name)
                            //var $price = $("<td>").html(item.Price)
                            //var $amount = $("<td>").html(item.Amount)
                            //var $tr = $("<tr>");
                            //$tr.append($id).append($name).append($price).append($amount);
                            //$tr.appendTo("#myTableBody");


                            //方法二  "Hello"  'Hello'  `Hello`
                            $("#myTableBody").append(
                                `<tr>
                                    <td>${item.Id}</td>
                                    <td>${item.Name}</td>
                                    <td>${item.Price}</td>
                                    <td>${item.Amount}</td>
                                </tr>`);
                        })

                    },
                    error: function (x) {
                        alert("error");
                    }
                });

            });
        });



    </script>


</asp:Content>

