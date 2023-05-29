<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MasterPage_TryTwo.NewPages.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Css/Login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="login-container">
        <div class="login-form">
            <table class="login-form-content">
                <tr>
                    <td>
                        <asp:Label ID="lblUser" runat="server" Text="Username:"></asp:Label><br />
                    </td>
                    <td>
                        <input id="UserName" type="text" name="UserName" oninput="getUserVal()" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPass" runat="server" Text="Password:"></asp:Label>
                    </td>
                    <td>
                        <input id="Password" type="Password" name="Password" oninput="getPassVal()" /><br />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <input type="submit" id="submit" name="Login" class="btn-login" value="Login" /><br />
                    </td>
                </tr>
            </table>
              <div class="error-container">
                      <p id="errMsg" runat="server" class="errMsg"></p>
                 </div>
        </div>

       

    </div>

</asp:Content>
