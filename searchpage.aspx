<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="searchpage.aspx.cs" Inherits="DBLABPROJECT.searchpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="search-bar mb-2 mt-2 bg-info search-section "> 

    <div class="container">
        <form>
            <div class="form-row align-items-center ">
                <div class="col-5">
                    <input type="text" class="form-control" placeholder="Make and Model">
                </div>
                <div class="col-auto">
                    <input type="text" class="form-control" placeholder="Min Price">
                </div>
                <div class="col-auto">
                    <input type="text" class="form-control" placeholder="Max Price">
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
                    <button type="submit" class="btn btn-dark mb-2 mt-2">Go</button>
                </div>
            </div>
        </form>
    </div>
       
</section>



    <div class="row mx-auto justify-content-center">

        <div class="col-md-2">

            <center>

                <div class="card" style="width: 18rem;">
                    <img src="..." class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">Card title</h5>
                        <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                        <a href="#" class="btn btn-primary">Call</a>
                    </div>
                </div>
        </center>
        </div>


         <div class="col-md-2">

             <center>

                 <div class="card" style="width: 18rem;">
                     <img src="..." class="card-img-top" alt="...">
                     <div class="card-body">
                         <h5 class="card-title">Card title</h5>
                         <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                         <a href="#" class="btn btn-primary">Call</a>
                     </div>
                 </div>
        </center>
         </div>

         <div class="col-md-2">

     <center>

         <div class="card" style="width: 18rem;">
             <img src="..." class="card-img-top" alt="...">
             <div class="card-body">
                 <h5 class="card-title">Card title</h5>
                 <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                 <a href="#" class="btn btn-primary">Call</a>
             </div>
         </div>
</center>
 </div>

         <div class="col-md-2">

     <center>

         <div class="card" style="width: 18rem;">
             <img src="..." class="card-img-top" alt="...">
             <div class="card-body">
                 <h5 class="card-title">Card title</h5>
                 <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                 <a href="#" class="btn btn-primary">Call</a>
             </div>
         </div>
</center>
 </div>


    </div>




       

   


</asp:Content>
