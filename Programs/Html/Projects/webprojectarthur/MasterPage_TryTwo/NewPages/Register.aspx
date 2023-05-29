<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="MasterPage_TryTwo.NewPages.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <script src="../Scripts/Validate.js"></script>
    <link href="../Css/Register.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <div>
             <h2>Register</h2>
             <p>Please fill out the form below to create an account:</p>
        </div>
           <div class="regError">
            <p id="regError" runat="server" style="color: red;"></p>
        </div>
        <div class="register-container">
            <div class="register-form">
                <table class="register-table" style="border-spacing: 10px; border: solid 2px black;">
                    <tr>
                        <td class="tbl-right">
                            <asp:Label ID="lblUser" runat="server" Text="Username:"></asp:Label>
                        </td>
                        <td>
                            <input id="UserName" type="text" name="UserName" onblur="userNameVal()" />
                        </td>
                        <td>
                            <input id="messUserName" type="text" style="color: red; display: none; border-style: none;" />
                        </td>
                    </tr>
                    <tr>
                        <td class="tbl-right">
                            <asp:Label ID="lblPass" runat="server" Text="Password:"></asp:Label>
                        </td>
                        <td>
                            <input id="Password" type="Password" name="Password" onchange="passwordVal()" />
                        </td>
                        <td>
                            <input id="messPassword" type="text" style="color: red; display: none; border-style: none;" />
                        </td>
                    </tr>
                    <tr>
                        <td class="tbl-right">
                            <asp:Label ID="Label5" runat="server" Text="Confirm Password:"></asp:Label>
                        </td>
                        <td>
                            <input id="ConfPassword" type="Password" name="ConfPassword" onchange="confirmPassFun()" />
                        </td>
                        <td>
                            <input id="messConfPassword" type="text" style="color: red; display: none; border-style: none;" />
                        </td>
                    </tr>

                    <tr>
                        <td class="tbl-right">
                            <asp:Label ID="Label1" runat="server" Text="Firstname:"></asp:Label>
                        </td>
                        <td>
                            <input id="FirstName" type="text" name="FirstName" onblur="userFirstNameVal()" />
                        </td>
                        <td>
                            <input id="messFirstName" type="text" style="color: red; display: none; border-style: none;" />
                        </td>
                    </tr>
                    <tr>
                        <td class="tbl-right">
                            <asp:Label ID="Label2" runat="server" Text="Last Name:"></asp:Label>
                        </td>
                        <td>
                            <input id="SecondName" type="text" name="SecondName" onblur="userSecondNAmeVal()" />
                        </td>
                        <td>
                            <input id="messSecondName" type="text" style="color: red; display: none; border-style: none;" />
                        </td>
                    </tr>
                    <tr>
                        <td class="tbl-right">
                            <asp:Label ID="Label4" runat="server" Text="Email:"></asp:Label>
                        </td>
                        <td>
                            <input id="Email" type="text" name="Email" onchange="confirmEmail()" />
                        </td>
                        <td>
                            <input id="messEmail" type="text" style="color: red; display: none; border-style: none;" />
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <input type="submit" id="submit" name="Login" class="btn-login" value="Register" disabled="disabled" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
</asp:Content>
