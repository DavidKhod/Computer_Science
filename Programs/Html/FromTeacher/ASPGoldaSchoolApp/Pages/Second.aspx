<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Second.aspx.cs" Inherits="ASPGoldaSchoolApp.Pages.Second" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Second Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <h1>This a Second Page</h1>

        <br />
        <br />

        <div class="container">
            <label for="UserName">User Name:</label>
            <input type="text" name="UserName" id="UserName" placeholder="enter user name" />
            <br />
            <br />
           
            <label for="password">Password:</label>
            <input type="password" name="password" id="password" placeholder="enter password" />
            <br />
            <br />
            
     </div>

        <br />
        <br />


        <asp:Button ID="Button1" runat="server" Text="Send to Server" OnClick="Button1_Click" />
    </form>
</body>
</html>
