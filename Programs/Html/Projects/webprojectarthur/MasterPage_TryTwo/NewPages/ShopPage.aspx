<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Site1.Master" AutoEventWireup="true" CodeBehind="ShopPage.aspx.cs" Inherits="MasterPage_TryTwo.NewPages.ShopPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Scripts/Script_First.js"></script>
    <link href="../Css/Shop.css" rel="stylesheet" />
    <style type="text/css">
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="picture-row">
    <div class="picture-item">
        <img src="../Pic/US%20donkey.jpg" class="picture-img" />
        <asp:Button ID="Button1" runat="server" Text="Press" class="picture-button" OnClick="Button1_Click"/>
        <div class="picture-text">US Donkey</div>
    </div>
    <div class="picture-item">
        <img src="../Pic/Vecation%20Donkey.jpg" class="picture-img" />
        <asp:Button ID="Button2" runat="server" Text="Press" class="picture-button" OnClick="Button2_Click"/>
        <div class="picture-text">Vacation Donkey</div>
    </div>
    <div class="picture-item">
        <img src="../Pic/Just%20Donkey.jpg" class="picture-img" />
        <asp:Button ID="Button3" runat="server" Text="Press" class="picture-button" OnClick="Button3_Click"/>
        <div class="picture-text">Just Donkey</div>
    </div>
</div>
<div class="picture-row">
    <div class="picture-item">
        <img src="../Pic/Army%20Donkey.jpg" class="picture-img" />
        <asp:Button ID="Button4" runat="server" Text="Press" class="picture-button" OnClick="Button4_Click"/>
        <div class="picture-text">Army Donkey</div>
    </div>
    <div class="picture-item">
        <img src="../Pic/Lazy%20Donkey.jpg" class="picture-img" />
        <asp:Button ID="Button5" runat="server" Text="Press" class="picture-button" OnClick="Button5_Click"/>
        <div class="picture-text">Lazy Donkey</div>
    </div>
    <div class="picture-item">
        <img src="../Pic/Flying%20Donkey.jpg" class="picture-img" />
        <asp:Button ID="Button6" runat="server" Text="Press" class="picture-button" OnClick="Button6_Click"/>
        <div class="picture-text">Flying Donkey</div>
    </div>
</div>

</asp:Content>
