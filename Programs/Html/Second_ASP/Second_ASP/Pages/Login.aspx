<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Second_ASP.Pages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 27px;
            width: 133px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="Login">
        <h1>This is the log in page(:</h1>
        <label for="FirstName">First Name:</label>
        <input type="text" name="FirstName" id="FirstName"  />
            <br />
            <br />
        <label for ="LastName">Last Name</label>
            <input type="text" name="LastName" id="LastName"  />
            <br />
            <br />
        <label for ="Password">Password</label>
            <input type="password" name="Password" id="Password"  />
            <br />
            <br />
            <input type="submit" value="Send" />
        </div>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="To Another Page" OnClick="Button1_Click1" />
        <br />
        <br />
        <%= $"Welcome {Request.Form["FirstName"]} Your pass is : {Request.Form["Password"]}"+"<br/><br/>" %>
        <%= PringMassage() %>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Login" OnClick="Button2_Click" />
    </form>
</body>
</html>
