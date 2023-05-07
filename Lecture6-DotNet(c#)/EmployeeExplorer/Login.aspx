<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EmployeeExplorer.Login" %>


<asp:Content ID="Login" ContentPlaceHolderID="MainContent" runat="server">
    
      <div class="login-container">
          <div class="form-outline mb-4 ">
              <asp:Label CssClass="form-label " runat="server">Email </asp:Label>
              <asp:TextBox ID="loginEmail" runat="server"  class="form-control inp" TextMode="Email" required></asp:TextBox>
          </div>
          <div class="form-outline mb-4">
            <asp:Label CssClass="form-label " runat="server">Password</asp:Label>
              <asp:TextBox ID="loginPassword" runat="server"  class="form-control inp" TextMode="Password" required></asp:TextBox>
          </div>
          <div class="form-outline mb-4 text-danger">
            <asp:Label CssClass="form-label text-danger" ID="warningLabel" runat="server"></asp:Label>
          </div>
          <asp:Button ID="loginSubmit" runat="server" Text="submit" CssClass="btn btn-primary" OnClick="loginSubmit_Click"/>         
      </div>
</asp:Content>