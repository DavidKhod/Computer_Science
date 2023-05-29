<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="FirstWithMaster.aspx.cs" Inherits="ASPGoldaSchoolApp.PagesWithMasterPage.FirstWithMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
            <label for="UserName">User Name:</label>
            <input type="text" name="UserName" id="UserName" placeholder="enter user name" />
            <br />
            <br />
           
            <label for="password">Password:</label>
            <input type="password" name="password" id="password" placeholder="enter password" />
            <br />
            <br />
    <input type="submit" value="Send" />
            
     </div>


</asp:Content>
