<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Site1.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="MasterPage_TryTwo.NewPages.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
           <div class="editError">
            <p id="editError" runat="server" style="color: red;"></p>
        </div>
        <div class="register-container">
            <div class="register-form">
                <table class="register-table" style="border-spacing: 10px; border: solid 2px black;">
                    <tr>
                        <td class="tbl-right">
                            <asp:Label ID="lblUser" runat="server" Text="Username:"></asp:Label>
                        </td>
                        <td>
                            <input id="UserName" type="text" name="UserName" runat="server" onblur="userNameVal()" />
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
                            <input id="Password" type="text" name="Password" runat="server" onchange="passwordVal()" />
                        </td>
                        <td>
                            <input id="messPassword" type="text" style="color: red; display: none; border-style: none;" />
                        </td>
                    </tr>
              

                    <tr>
                        <td class="tbl-right">
                            <asp:Label ID="Label1" runat="server" Text="Firstname:"></asp:Label>
                        </td>
                        <td>
                            <input id="FirstName" type="text" name="FirstName" runat="server" onblur="userFirstNameVal()" />
                        </td>
                        <td>
                            <input id="messFirstName" type="text" style="color: red; display: none; border-style: none;" />
                        </td>
                    </tr>
                    <tr>
                        <td class="tbl-right">
                            <asp:Label ID="Label2" runat="server" Text="Lastname:"></asp:Label>
                        </td>
                        <td>
                            <input id="LastName" type="text" name="LastName" runat="server" onblur="userLastNameVal()" />
                        </td>
                        <td>
                            <input id="messLastName" type="text" style="color: red; display: none; border-style: none;" />
                        </td>
                    </tr>

                    <tr>
                        <td class="tbl-right">
                            <asp:Label ID="Label4" runat="server" Text="Email:"></asp:Label>
                        </td>
                        <td>
                            <input id="Email" type="text" name="Email" runat="server" onchange="confirmEmail()" />
                        </td>
                        <td>
                            <input id="messEmail" type="text" style="color: red; display: none; border-style: none;" />
                        </td>
                    </tr>

                    <tr>
                        <td></td>
                        <td>
                            <input type="button" id="Update" name="Update" value="Update" class="btn-login" runat="server" onserverclick="UpdateUser" />
                        </td>
                    </tr>
                </table>
            </div>

        </div>
</asp:Content>
