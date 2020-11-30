<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" %>

<script runat="server">

    //請參考Index2.aspx

    protected void Page_Load(object sender, EventArgs e)
    {
        //Repeater1.DataSource = MemberUtility.GetAllMembers();
        //Repeater1.DataBind();
    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="myCSS" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="myContent" runat="Server">

    <h1>會員列表</h1>

    <div class="w3-row-padding" id="myDiv">

    </div>

    <%--    <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate>
            <div class="w3-row-padding">
        </HeaderTemplate>

        <ItemTemplate>
            <div class="w3-third w3-container w3-margin-bottom">
                <img src='<%# Eval("ImageFileName" , "photo/{0}") %>' alt="Norway" style="width: 50%" class="w3-hover-opacity">
                <div class="w3-container w3-white">
                    <p>帳號 : <b><%# Eval("UserName") %></b></p>
                    <p>密碼 : <%# Eval("Password") %> </p>
                </div>
            </div>
        </ItemTemplate>

        <FooterTemplate>
            </div>
        </FooterTemplate>
    </asp:Repeater>--%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="myJavaScript" runat="Server">

    <script>

        $(function () {

            $.ajax({
                type: 'POST',
                url: 'WebService.asmx/MemberList',
                contentType: "application/json;charset=utf-8",
                success: function (data) {

                    $(data.d).each(function (index, item) {

                        $("#myDiv").append(
                            `<div class="w3-third w3-container w3-margin-bottom">
                                <img src="photo/${item.ImageFileName}" alt="Norway" style="width: 50%" class="w3-hover-opacity">
                                <div class="w3-container w3-white">
                                    <p>帳號aaa : <b>${item.UserName}</b></p>
                                    <p>密碼 : ${item.Password} </p>
                                </div>
                            </div>`
                        );
                    })

                },
                error: function (x) {
                    alert("error");
                }
            });

        });

    </script>
</asp:Content>

