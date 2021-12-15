<%@ Page Title="" Language="C#" MasterPageFile="~/SideBar.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="VGamesReview.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card w-50 m-auto border-primary mt-5">
        <div class="card-header bg-light text-primary p-2">
            <p class="text-center"><b> Login to start</b></p>
        </div>
        <div class="card-body">
            <div class="container">
                <label for="email" class="form-label text-primary">Email</label>
                <asp:TextBox id="email" runat="server" class="form-control m-auto w-75"></asp:TextBox>
            </div>
            <div class="container">
                <label for="password" class="form-label text-primary">Password</label>
                <input id="Password1" type="password" runat="server" class="form-control w-75 m-auto" />
            </div>
            <asp:Button class="btn-primary form-control w-25 mx-auto mt-5" runat="server" Text="Start" OnClick="Unnamed1_Click" />
        </div>
        


    </div>
</asp:Content>
