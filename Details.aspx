<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="DBLABPROJECT.Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

           
    
    <link href="css/Details.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="outer-container">
        <!-- Image Container -->
        <div class="image-container">
            <asp:Image ID="imgCar" runat="server" />
        </div>

        <!-- Main Container -->
        <div class="container">
            <!-- Your existing content goes here -->
            <div class="details-box">
                <div class="container-box">
                    <h3>Title</h3>
                    <div class="title-box">
                        <h2><asp:Label ID="carTitle" runat="server" /></h2>
                    </div>
                </div>
                <div class="container-box">
                    <h3>Description</h3>
                    <div class="description-box">
                         <p><strong>Color:</strong> <asp:Label ID="colorLabel" runat="server" Allot="Color: " /></p>
                         <p><strong>Mileage:</strong> <asp:Label ID="mileageLabel" runat="server" Allot="Mileage: " /></p>
                         <p><strong>Condition:</strong> <asp:Label ID="conditionLabel" runat="server" Allot="Condition: " /></p>
                         <p><strong>Model:</strong> <asp:Label ID="modelLabel" runat="server" Allot="Model: " /></p>
                         <p><strong>Price:</strong> <asp:Label ID="priceLabel" runat="server" Allot="Price: " /></p>
                    </div>
                </div>
                <div class="container-box">
                    <h3>Features</h3>
                    <div class="features-box">
                        <ul>
                            <li><asp:Label ID="transmissionTypeLabel" runat="server" Allot="Transmission Type: " /></li>
                            <li><asp:Label ID="maxGearLabel" runat="server" Allot="Max Gear: " /></li>
                            <li><asp:Label ID="engineCapacityLabel" runat="server" Allot="Engine Capacity: " /></li>
                            <li><asp:Label ID="bodyTypeLabel" runat="server" Allot="Body Type: " /></li>
                            <li><asp:Label ID="carTypeLabel" runat="server" Allot="Car Type: " /></li> 
                            <li><asp:Label ID="airBagsLabel" runat="server" Allot="Air Bags: " /></li>
                            <li><asp:Label ID="hpLabel" runat="server" Allot="HP: " /></li>
                            <li><asp:Label ID="torqueLabel" runat="server" Allot="Torque: " /></li>
                            <li><asp:Label ID="tyreSizeLabel" runat="server" Allot="Tyre Size: " /></li>
                            <li><asp:Label ID="seatingCapacityLabel" runat="server" Allot="Seating Capacity: " /></li>
                            <li><asp:Label ID="cruiseControlLabel" runat="server" Allot="Cruise Control: " /></li>
                            <li><asp:Label ID="antiLockBSPowerMirrorLabel" runat="server" Allot="Anti-Lock BS Power Mirror: " /></li>
                            <li><asp:Label ID="powerSteeringLabel" runat="server" Allot="Power Steering: " /></li>
                            <li><asp:Label ID="powerWindowsLabel" runat="server" Allot="Power Windows: " /></li>
                            <li><asp:Label ID="sunRoofLabel" runat="server" Allot="Sun Roof: " /></li>
                            <li><asp:Label ID="powerLocksLabel" runat="server" Allot="Power Locks: " /></li>
                            <li><asp:Label ID="alloyRimsLabel" runat="server" Allot="Alloy Rims: " /></li>
                            <li><asp:Label ID="airConditioningLabel" runat="server" Allot="Air Conditioning: " /></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
