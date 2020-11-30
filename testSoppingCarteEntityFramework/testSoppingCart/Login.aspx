<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {

        Member m = MemberUtility.FindMember(TextBox1.Text, TextBox2.Text);

        if (m != null)
        {
            //登入
            FormsAuthentication.SetAuthCookie(m.Id.ToString(), false);
            Response.Redirect("~/Index2.aspx");
            //User.Identity.Name
        }
        else
        {
            //登入失敗
            Label1.Text = "帳號或密碼錯誤";
        }

    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <style>
        body {
            font-family: Arial, Helvetica, sans-serif;
        }

        form {
            border: 3px solid #f1f1f1;
        }

        input[type=text], input[type=password] {
            width: 100%;
            padding: 12px 20px;
            margin: 8px 0;
            display: inline-block;
            border: 1px solid #ccc;
            box-sizing: border-box;
        }

        .button {
            background-color: #4CAF50;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            cursor: pointer;
            width: 100%;
        }

            .button:hover {
                opacity: 0.8;
            }

        .cancelbtn {
            width: auto;
            padding: 10px 18px;
            background-color: #f44336;
        }

        .imgcontainer {
            text-align: center;
            margin: 24px 0 12px 0;
        }

        img.avatar {
            width: 20%;
            border-radius: 50%;
        }

        .container {
            padding: 16px;
        }

        span.psw {
            float: right;
            padding-top: 16px;
        }

        /* Change styles for span and cancel button on extra small screens */
        @media screen and (max-width: 300px) {
            span.psw {
                display: block;
                float: none;
            }

            .cancelbtn {
                width: 100%;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="imgcontainer">
            <img src="Photo/avataaars1.png" alt="Avatar" class="avatar" />
        </div>

        <div class="container">
            <label for="uname"><b>Username</b></label>
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter Username"></asp:TextBox>

            <label for="psw"><b>Password</b></label>
            <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter Password"></asp:TextBox>

            <%--<button type="submit">Login</button>--%>
            <asp:Button ID="Button1" runat="server" Text="Login" CssClass="button" OnClick="Button1_Click" />
            <label>
                <input type="checkbox" checked="checked" name="remember"/>
                Remember me
            <br />
            </label>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>

        <div class="container" style="background-color: #f1f1f1">
            <button type="button" class="cancelbtn">Cancel</button>
            <span class="psw">Forgot <a href="#">password?</a></span>
        </div>
    </form>

</body>
</html>
