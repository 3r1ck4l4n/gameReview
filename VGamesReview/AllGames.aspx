<%@ Page Title="" Language="C#" MasterPageFile="~/SideBar.Master" AutoEventWireup="true" CodeBehind="AllGames.aspx.cs" Inherits="VGamesReview.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="FeaturedGames" runat="server">
        <h2>Featured Games </h2>
        <div id="container1">
        </div>
    </div>

    <div id="PopularGames" runat="server">
        <h2>Popular Games</h2>
        <div runat="server" id="container2">
        </div>
    </div>
</asp:Content>
