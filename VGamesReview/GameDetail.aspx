<%@ Page Title="" Language="C#" MasterPageFile="~/SideBar.Master" AutoEventWireup="true" CodeBehind="GameDetail.aspx.cs" Inherits="VGamesReview.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div runat="server" id="container1">

    </div>
    <div  runat="server" id="reviews">

    </div>
    <div  runat="server" id="reviewForm" class="w-50 mx-auto" >
        <label for="TextArea1" class="form-label">Review</label>
        <textarea runat="server" id="TextArea1" cols="20" rows="2" class="form-control w-50 mx-auto"></textarea>
        <label for="DropDownList1">Score</label>
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control w-25 mx-auto">
           
        </asp:DropDownList>

        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
    </div>
    
</asp:Content>
