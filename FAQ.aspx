<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FAQ.aspx.cs" Inherits="DBLABPROJECT.FAQ" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container py-5">
        <div class="row">
            <div class="col">
                <h2>FAQs</h2>
                <div class="accordion" id="faqAccordion">
                    <div class="card">
                        <div class="card-header" id="headingOne">
                            <h5 class="mb-0">
                                <a href="#" class="collapsed" data-toggle="collapse" data-target="#collapseOne" aria-expanded="false" aria-controls="collapseOne">
                                    What types of cars can I find at GariGator dealerships?
                                </a>
                            </h5>
                        </div>
                        <div id="collapseOne" class="collapse" aria-labelledby="headingOne" data-parent="#faqAccordion">
                            <div class="card-body">
                                GariGator dealerships offer a wide variety of cars to suit your needs and budget. You'll find new and used cars from popular brands, including sedans, SUVs, trucks, sports cars, and more.
                            </div>
                        </div>
                    </div>
                    <div class="card">
                        <div class="card-header" id="headingEleven">
                            <h5 class="mb-0">
                                <a href="#" class="collapsed" data-toggle="collapse" data-target="#collapseEleven" aria-expanded="false" aria-controls="collapseEleven">
                                    How can I contact GariGator customer support?
                                </a>
                            </h5>
                        </div>
                        <div id="collapseEleven" class="collapse" aria-labelledby="headingEleven" data-parent="#faqAccordion">
                            <div class="card-body">
                                You can reach GariGator customer support by phone at <span class="font-weight-bold">0320-4870303 or by email at kareemarbab00000@gmail.com 
                            </div>-
                        </div>
                    </div>
                </div>
            </div>
            
<asp:LinkButton ID="about_to_home" runat="server" Text="Home page" href="/homepage.aspx"></asp:LinkButton>


        </div>
    </div>
</asp:Content>
