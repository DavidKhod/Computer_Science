<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="First.aspx.cs" Inherits="ASPGoldaSchoolApp.Pages.First" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>First Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <h1>This is a First Page</h1>
        <asp:Button ID="Button1" runat="server" Text="To Second Page" OnClick="Button1_Click" />
        <br />
        <br />

        <div class="container">
            <label for="FirstName">First Name:</label>
            <input type="text" name="FirstName" id="FirstName" placeholder="enter first name" />
            <br />
            <br />
            <label>Last Name:</label>
            <input type="text" name="LastName" id="LastName" placeholder="enter last name" />
            <br />
            <br />
            <label>Password:</label>
            <input type="password" name="password" id="password" placeholder="enter password" />
            <br />
            <br />
            <input type="submit" value="Send" />
     </div>

        <br />
        <br />

       <%="First Name is : " + Request.Form["FirstName"] + "<br/> Last Name is : "+ Request.Form["LastName"] + "<br/>Passord is : " + Request.Form["password"] %>

        <br />
        <br />
        <%=PrintMessage() %>
      
    </form>
</body>
</html>
