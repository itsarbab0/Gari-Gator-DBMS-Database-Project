<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="aboutus.aspx.cs" Inherits="DBLABPROJECT.aboutus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>About Us</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container py-5">
        <div class="row" style="background-color: black; color: white;">
            <div class="col text-center" style="align-content: center">
                <h1>ABOUT US</h1>
            </div>
        </div>
        <br />
        <br />
        <br />
        <br />
        <div class="row">
      
            <div class="col-md-3 mb-4">
                <div class="card">
                    <img src="imgs/arbabs.jpg" class="card-img-top" alt=" Leader " />
                    <div class="card-body">
                        <h5 class="card-title">Arbab Kareem</h5>
                        <p class="card-text">Founder</p>
                    </div>
                </div>
            </div>
            
           
        </div>
        <div class="row" style="align-content: center; text-align: center;">
            <div class="col">
                <h1>What We Do</h1>
                <br />
                <br />
                <p>
                    Welcome to our website! Welcome to GariGator, your go-to place for affordable and convenient online purchasing.
          Because we at GariGator are aware of the hectic nature of contemporary life, we have developed a one-stop platform
          to make purchasing easier for you. We have everything you need related any car of your choice.It's never been easier to
          get what you need thanks to an intuitive search tool and user-friendly UI. Our sophisticated algorithms provide you with
          recommendations based on your browsing history and interests, making your buying experience more personalized.
          At GariGator, we're dedicated to providing outstanding customer service at every turn.Our committed staff is available
          to help with any questions or issues you may have, making sure your shopping experience is easy and pleasurable.
                </p>
                <br />
                <br />
                <br />
            </div>
        </div>

        <asp:LinkButton ID="about_to_home" runat="server" Text="Home page" href="/homepage.aspx"></asp:LinkButton>



    </div>
</asp:Content>
