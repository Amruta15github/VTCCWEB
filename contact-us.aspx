<%@ Page Title="" Language="C#" MasterPageFile="~/MasterParent.master" AutoEventWireup="true" CodeFile="contact-us.aspx.cs" Inherits="contact_us" %>

<%@ MasterType VirtualPath="~/MasterParent.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   <script type="text/javascript"
        src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCvO0AHfg1cuND1KXbw3t5xZr5p4PVrEk4">
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- Page Header Starts -->
    <div class="pgHeader1">
        <div class="headerOverlay">           
            <div class="bottomLight"></div>
            <div class="container">
                <div class="pg_TB_pad">
                    <h1 class="pageH1 clrWhite fontMedium">Contact Us</h1>
                    <ul class="bCrumb">
                        <li><a href="<%= Master.rootPath %>">Home</a></li>
                        <li>&raquo;</li>
                        <li>Contact Us</li>
                    </ul>
                    <div class="float_clear"></div>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Header Ends -->
   
 <div class="container mt-5">    
       <h2 class="pageH2 large themeClrThr text-center">GET IN TOUCH WITH US</h2>
      <span class="space40"></span>   
      <div class="row">
        <div class="box col-md-4">
           <img src="images/icons/address.png" />
           <span class="space5"></span>
          <h5 class="card-title">Address</h5>              
          <h4 class="card-title clrDarkGrey">Vocational Training and Certification Committee,New Delhi,India</h4>         
          <p class="card-text">Sangeet Ratna Abdul Karim Kha Smruti Bhavan, Shivaji Road, In Front of Priyadarshini Hotel, Miraj, Tal-Miraj, Dist-Sangli, Maharashtra-416410</p>
        </div>

        <div class=" box col-md-4">
             <img src="images/icons/user.png" alt=" "/>
             <span class="space5"></span>
             <h5 class="card-title">Contact No</h5>
             <span class="space5"></span>
          <p class="card-text">+91-9975327900</p>
        </div>

        <div class=" box col-md-4">
             <img src="images/icons/email1.png" alt=" "/>
            <span class="space5"></span>           
            <h5 class="card-title">Email</h5>
            <span class="space5"></span>  
          <p class="card-text">vtccdelhi&#64;gmail&#46;com</p>
        </div>
      </div> 
  </div>

</asp:Content>

