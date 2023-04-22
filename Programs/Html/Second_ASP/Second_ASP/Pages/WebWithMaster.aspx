<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MySite.Master" AutoEventWireup="true" CodeBehind="WebWithMaster.aspx.cs" Inherits="Second_ASP.Pages.WebWithMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <head>
    <meta charset="utf-8" />
    <title>Home Page</title>
    <link href="../Style/Css.css" rel="stylesheet" />
</head>
<body>
    <div class="NavBar" id="NavBar">
        <div class="Logo">
            <img src="../Pictures/Donkey-06.jpg" width="50" height="50" alt="Site Logo" id="Img-Logo" />
        </div>
        <div class="Caption">
            <a id="Name" href="Home.html">Donkey's  Pages</a>
        </div>
        <div class="Pages">
            <a class="Link" href="Register.html">Register</a>
            <a class="Link" href="LogIn.html">LogIn</a>
            <a class="Link" href="Admin.html">Admin</a>
            <a class="Link" href="Home.html">Home</a>
        </div>
    </div>
    <h1>This is the home page</h1>
    <h3>Donkyes for sale</h3>
</body>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

</asp:Content>
