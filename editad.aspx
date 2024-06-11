<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="editad.aspx.cs" Inherits="DBLABPROJECT.editad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-8 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col" >
                                <center>
                                    <h3>Edit Your Ad</h3>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>
                        <div class="row" style="background-color: white;">
                    <div class="col-md-6" >
                             <label>Title</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TitleTextBox" runat="server" required placeholder="Enter a catchy title"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Description</label>
                                <div class="form-group">
                                    <asp:TextBox TextMode="MultiLine" Rows="4" CssClass="form-control" ID="DescriptionTextBox" runat="server" required placeholder="Describe your car's features and condition"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <label>Car Color</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="CarColorTextBox" runat="server" required placeholder="e.g., Red, Black, Silver" ></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Mileage</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="MileageTextBox" runat="server" required TextMode="Number" placeholder="Enter mileage in kilometers"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Price</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="PriceTextBox" runat="server"  required TextMode="Number" placeholder="Price"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <label>Condition</label>
                                <div class="form-group">
                                    <asp:DropDownList CssClass="form-control" ID="ConditionDropDown" runat="server">
                                        <asp:ListItem Text="Excellent" Value="Excellent" />
                                        <asp:ListItem Text="Very Good" Value="VeryGood" />
                                        <asp:ListItem Text="Good" Value="Good" />
                                        <asp:ListItem Text="Fair" Value="Fair" />
                                        <asp:ListItem Text="Needs Work" Value="NeedsWork" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6">
                                <label>Brand Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="BrandTextBox" runat="server"  required placeholder="e.g., Toyota, Honda, Ford"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Model Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="ModelTextBox" runat="server" required placeholder="e.g., Camry, Civic, Mustang"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <%-- --%>
                                    <asp:Button CssClass="btn btn-primary btn-block btn-lg" ID="SubmitButton" runat="server" Text="Submit Ad" OnClick="SubmitAd_Click"  />
                                </div>
                                <div class="row">
    <div class="col">
        <label>Car Image</label>
        <div class="form-group">
            <asp:FileUpload ID="CarImageFileUpload" runat="server"  CssClass="form-control" />
        </div>
    </div>
</div>
                            </div>
</asp:Content>
