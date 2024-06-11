
<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="DBLABPROJECT.userlogin" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">

    <link href="css/userlogin.css" rel="stylesheet" />
    <script src="js/userlogin.js"></script>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div id="particles-js"></div>

  <div class="container">
    <div class="login-container-wrapper clearfix">
      <div class="logo">
        <i class="fa fa-sign-in"></i>
      </div>
      <div class="welcome"><strong>Welcome,</strong> please login</div>

      <form class="form-horizontal login-form">
        <div class="form-group relative">
         <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" required placeholder="Email"></asp:TextBox>

          <i class="fa fa-user"></i>
        </div>
        <div class="form-group relative password">
                                       <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Password" required TextMode="Password"></asp:TextBox>

          <i class="fa fa-lock"></i>
        </div>
        <div class="form-group">
           <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />

        </div>
        <div class="checkbox pull-left">
          <label><input type="checkbox"> Remember</label>
        </div>
        <div class="checkbox pull-right">
          <label> <a class="forget" href="" title="forget">Forgot your password</a> </label>
        </div>
      </form>
    </div>

    <h4 class="text-center">
      <a target="_blank" href="https://codepen.io/Peeyush200/pen/mLwvJB">
        
      </a>
    </h4>
  </div>


</asp:Content>
