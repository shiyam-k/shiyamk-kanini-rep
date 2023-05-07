<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="EmployeeExplorer.Signup" %>

<asp:Content ID="Signup" ContentPlaceHolderID="MainContent" runat="server">
    <div class="signup-container">
          <div class="form-outline mb-4 ">
              <asp:Label CssClass="form-label" runat="server" TextMode="Email" >Email</asp:Label>
              <asp:TextBox ID="signupEmail" runat="server"  class="form-control inp" required></asp:TextBox>
          </div>
          <div class="form-outline mb-4">
            <asp:Label CssClass="form-label" runat="server">Password</asp:Label>
              <asp:TextBox ID="signupPassword" runat="server"  class="form-control inp" TextMode="Password" required></asp:TextBox>
          </div>
          
        <div class="form-outline mb-4">
            <asp:Label CssClass="form-label" runat="server">User Name</asp:Label>
              <asp:TextBox ID="userName" runat="server"  class="form-control inp" TextMode="Password" required></asp:TextBox>
          </div>
         
           
          <asp:Button ID="signupSubmit" runat="server" Text="submit" CssClass="btn btn-primary"/>         
      </div>
</asp:Content>
