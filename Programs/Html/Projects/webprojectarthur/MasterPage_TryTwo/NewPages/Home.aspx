<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MasterPage_TryTwo.NewPages.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Scripts/Script_First.js"></script>
      <link href="../Css/HomePage.css" rel="stylesheet"/>
</asp:Content>
 
  
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    	<section id="about-us">
		<h2>About Us</h2>
		<p>At Donkey Tales, we are passionate about donkeys and their incredible contributions in various fields. We believe that every donkey has a unique story to tell. Let us introduce you to out magical specias of donkies and what we know about them.</p>
	</section>
    <img src="../Pic/Group%20of%20Donkies2.jpg" class ="DonkeyHomePagePic"/>
    <img src="../Pic/Group%20of%20Donkies.jpg" class ="DonkeyHomePagePic"/>
<footer>
	<p>&copy; 2023 Donkey Tales. All rights reserved.</p>
</footer>
    </asp:Content>
