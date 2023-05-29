<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ASPGoldaSchoolApp.PagesWithMasterPage.LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/login_style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="login-container">
        <div class="login-form">

            <table style="border-spacing: 10px;">
                <tr>
                    <td>
                        <asp:Label ID="lblUser" runat="server" Text="Username:"></asp:Label>
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
                        <input id="Password" type="Password" name="Password" oninput="getPassVal()" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <input type="submit" id="submit" name="Login" class="btn-login" value="Login" />
                    </td>
                </tr>

            </table>

        </div>

        <div class="error-container">
            <p id="errMsg" runat="server" class="errMsg"></p>
        </div>
    </div>


</asp:Content>
