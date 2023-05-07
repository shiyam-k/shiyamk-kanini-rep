<%@ Page Language="C#" AutoEventWireup="true" Title="Signup" MasterPageFile="~/Site.Master" CodeBehind="Signup.aspx.cs" Inherits="Web_Application_19_04_2023.Signup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="signup">
        <asp:Label ID="EmailLabel" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="EmailTextBox" runat="server" CssClass="form-control input-group-lg" TextMode="Email"></asp:TextBox>
        <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="PasswordTextBox" runat="server" CssClass="form-control input-group-lg" TextMode="Password" required></asp:TextBox>
        <asp:Label ID="UsernameLabel" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="UsernameTextBox" runat="server" CssClass="form-control input-group-lg" required></asp:TextBox>
        <asp:Label ID="WarningLabel" runat="server" ></asp:Label>
        <br />
        <asp:Button ID="SignupButton" runat="server" CssClass="btn btn-default" Text="Signup" OnClick="SignupButton_Click" />
    </div>
</asp:Content>

