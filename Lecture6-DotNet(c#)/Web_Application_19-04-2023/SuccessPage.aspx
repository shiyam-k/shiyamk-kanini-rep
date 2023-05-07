<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SuccessPage.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Web_Application_19_04_2023.SuccessPage" %>

<asp:Content ID="SuccessPage" ContentPlaceHolderID="MainContent" runat="server" >
    <h1>Successfully Registered</h1>
    <br />
    <asp:Button ID="ViewProfileButton" runat="server" CssClass="btn btn-default" Text="View Profile" OnClick="ViewProfileButton_Click" />
    <br />
    <asp:Label ID="WarningLabel" runat="server"></asp:Label>

</asp:Content>
