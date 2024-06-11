<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="viewads.aspx.cs" Inherits="DBLABPROJECT.viewads" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/homepagestylesheet.css" rel="stylesheet" />

    <link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Raleway:ital,wght@0,100..900;1,100..900&display=swap" rel="stylesheet">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script src="js/customjs.js"></script>


    <section>
        <img src="imgs/car-5.jpg" class ="img-fluid" />
    </section>


    <section class="search-bar mb-2 mt-2 search-section "> 

        <div class="container">
            <form>
                <div class="form-row align-items-center p-2 ">
                    <div class="col-5">
                          <asp:TextBox CssClass="form-control" ID="MakeModelTextBox" runat="server"  placeholder="Make or Model"></asp:TextBox>

                    </div>
                    <div class="col-auto">
                          <asp:TextBox CssClass="form-control" ID="MinPriceTextBox" runat="server"  placeholder="Min Price"></asp:TextBox>


                    </div>
                    <div class="col-auto">
                          <asp:TextBox CssClass="form-control" ID="MaxPriceTextBox" runat="server"  placeholder="Max Price"></asp:TextBox>

                    </div>
                    <div class="col-auto">

                        <select class="form-select city-selector rounded border-0 font-weight-light" aria-label="Default select example">
                            <option selected>City</option>
                            <option value="1">One</option>
                            <option value="2">Two</option>
                            <option value="3">Three</option>
                        </select>

                    </div>

                    <div class="col-auto">
                    </div>
                    <div class="col-auto ">
                         <asp:Button CssClass="btn search-btn mb-2 mt-2" ID="SearchButton" runat="server" Text="Go" OnClick="SearchButton_Click"  />

                    </div>
                </div>
            </form>
        </div>
           
    </section>

 <%--   <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="title" HeaderText="Product Name" />
            <asp:BoundField DataField="ad_desc" HeaderText="Description" />
            <asp:BoundField DataField="price" HeaderText="Price" />
        </Columns>
    </asp:GridView>--%>

   <%-- <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="product-grid">
    <Columns>
        <asp:TemplateField>
            <ItemTemplate>
                <div class="card">
                    <div class="card-body">
                        <h5 class="title"><%# Eval("title") %></h5>
                        <p class="ad_desc"><%# Eval("ad_desc") %></p>
                        <p class="price">$<%# Eval("price") %></p>
                        <a href="#" class="btn btn-primary">Add to Cart</a>
                    </div>
                    
                </div>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
    </asp:GridView>--%>

    <div class="mx-auto"style ="width:65%; margin: 0 auto;">


         <%--<asp:DataList ID="ListView1" RepeatDirection="Horizontal" RepeatColumns="4" runat="server">
     <ItemTemplate>

         <div class="card ml-2 mr-2" style="width: 18rem;">
             <img class="card-img-top" id="imgItem" ImageUrl=<%# "ImageHandler.ashx?id=" + Eval("ImageId") %> alt="Card image cap">
             <div class="card-body">
                 <h5 class="card-title"><%# Eval("title") %></h5>
                 <p class="card-text"><%# Eval("ad_desc") %></p>
                 <a href="#" class="btn btn-primary"><%# Eval("price") %></a>
             </div>
         </div>

         
     </ItemTemplate>
 </asp:DataList>--%>

        <asp:DataList ID="DataList1" RepeatDirection="Horizontal" RepeatColumns="4" runat="server">
    <ItemTemplate>

        <div class="card ml-2 mr-2 mt-2 mb-2 car-card" style="width: 18rem;">
            <img class="card-img-top" src='<%# "data:image/gif;base64," + Convert.ToBase64String((byte[])Eval("img")) %>'  alt="Product Image" width="400px" height="auto"/>
            <div class="card-body">
                <div class="p-1">
                <h5 class="card-title font-weight-bold car-title text-center"><%# Eval("title") %></h5>
                <p class="card-title car-desc"><%#  FormatMileage((string)Eval("mileage")) %> kms</p>
                <p class="card-text car-desc"><%# Eval("ad_desc") %></p>
                </div>
                <%--<a href="#" class="btn btn-primary"> PKR <%# Eval("price") %></a>--%>
                <a href='Details.aspx?adId=<%# Eval("ad_id") %>' class="btn car-btn"> PKR <%# FormatPrice((int)Eval("price")) %></a>
                <a href='editad.aspx?adId=<%# Eval("ad_id") %>' class="btn car-btn"> EDIT AD</a>
                <a href='deletead.aspx?adId=<%# Eval("ad_id") %>' class="btn car-btn"> Delete AD</a>




            </div>
        </div>

        
    </ItemTemplate>
</asp:DataList>

    </div>


   




    <div class="d-md-flex flex-md-equal w-100 my-md-3 pl-md-3 justify-content-center bg-dark">
      <div class="bg-dark mr-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center text-white overflow-hidden">
        <div class="my-3 py-3">
          <h2 class="display-5">How GariGator Works</h2>
          <div class ="text-box">
            <p class="lead">We aggregate millions of listings from dealers and private sellers, showing all the results for your search from each of our listings partners. We also generate comparison links for the remaining large sites we don't yet have partnerships with. Our goal is to capture all the results in single search, to save you time and help you find your ideal next car.</p>

          </div>

        </div>
      </div>
      
    </div>


    <section class="testimonials">
        <h3 class="testimonials-title">What People Are Saying
        </h3>
        <div class="testimonials-cards">
            <div class="card border-0 mr-1">
                <div class="card-content">
                    <i class="fa fa-quote-left fa-4" aria-hidden="true"></i>
                    <p class="card-content-desc">
                        I have been able to use GariGator to research exactly what car I want, in what trim and average prices for it. It’s a great tool to have available to me.
                    </p>
                </div>

            </div>
            <div class="card border-0 mr-1">
                <div class="card-content">
                    <i class="fa fa-quote-left fa-4" aria-hidden="true"></i>

                    <p class="card-content-desc">
GariGator is really easy and simple to use with a couple clicks and features. The vehicle you want will pull up and you can compare prices.                    </p>
                </div>

            </div>
            <div class="card border-0 mr-1">
                <div class="card-content">
                    <i class="fa fa-quote-left fa-4" aria-hidden="true"></i>

                    <p class="card-content-desc">
Your website is a great resource, and the next time I am in the market for a vehicle, I will definitely make GariGator my first (and last) place to look.                    </p>
                </div>

            </div>

        </div>


    </section>

</asp:Content>
