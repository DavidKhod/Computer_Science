<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="MasterPage_First.Pages.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
        <br />
        <br />
       <%-- <%="Login Data is : <br/>"%>
        <%=PrintMessage() %>--%>
     </div>
</asp:Content>
