<%@ Page Language="C#" Title="Login" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web_Application_19_04_2023.Login" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="signup">
        <asp:Label ID="EmailLabel" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="EmailTextBox" runat="server" CssClass="form-control input-group-lg" TextMode="Email"></asp:TextBox>
        <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="PasswordTextBox" runat="server" CssClass="form-control input-group-lg" TextMode="Password" required></asp:TextBox>
        <asp:Label ID="WarningLabel" runat="server" ></asp:Label>
        <br />
        <asp:Button ID="LoginButton" runat="server" CssClass="btn btn-default" Text="Login" OnClick="LoginButton_Click" />
    </div>
</asp:Content>
