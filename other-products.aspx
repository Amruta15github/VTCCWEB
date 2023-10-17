<%@ Page Title="" Language="C#" MasterPageFile="~/MasterParent.master" AutoEventWireup="true" CodeFile="other-products.aspx.cs" Inherits="other_products" %>
<%@ MasterType VirtualPath="~/MasterParent.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script type="text/javascript"
        src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCvO0AHfg1cuND1KXbw3t5xZr5p4PVrEk4">
    </script>
    <style>
        .other {
           color:black;
          
        }
            .other:hover {
                color:#d19563;
            }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- Page Header Starts -->
    <div class="pgHeader1">
        <div class="headerOverlay">           
            <div class="bottomLight"></div>
            <div class="container">
                <div class="pg_TB_pad">
                    <h1 class="pageH1 clrWhite fontMedium">VTCC Products</h1>
                    <ul class="bCrumb">
                        <li><a href="<%= Master.rootPath %>">Home</a></li>
                        <li>&raquo;</li>
                        <li>VTCC Products</li>
                    </ul>
                    <div class="float_clear"></div>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Header Ends -->
     <span class="space50"></span>
    <section id="aboutus"></section>
     <div class="container">
      <h2 class="pageH2 large themeClrThr text-center">VTCC Other Products</h2>
      <span class="space30"></span>
         <div class="text-center">
             <p class="semiBold medium mrg_B_10 mt-4 clrBlack">Digital Products</p>
             <div class="shortLine themeBgThr" style="margin:0 auto !important"></div>
         </div>
       <%--  <span class="space30"></span>
         <p class="clrDarkGrey semiBold medium mrg_B_10">ATC FREE Bonus 1</p>
          <a href="https://www.indiabrand.co.in/bulk-whatsapp-marketing-software-Whatchat-Pro" class=" other semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i> </span> WHATSAPP MARKETING SOFTWARE FOR FREE </a> 
          <p class="clrBlack regular fontRegular mrg_B_40">(REGULAR PRICE 2000/Year) </p>
         
          <span class="greyLine"></span>

          <p class="clrDarkGrey semiBold medium mrg_B_10">ATC FREE Bonus 2</p>
          <a href="#" class=" other semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i> </span> FREE ATC ONLINE DIGITAL CARD (REGULAR PRICE 599/YEAR) + ALL STAFF DIGITAL CARDS (MAX 4) </a> 
          <p class="clrBlack regular fontRegular mrg_B_40">REGULAR PRICEFOR2000/ONE YEAR </p>
         
          <span class="greyLine"></span>

          <p class="clrDarkGrey semiBold medium mrg_B_10">ATC FREE Bonus 3 </p>
          <a href="#" class=" other semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i> </span> Free Indian Festivals poster/Images with white label Project File (Center can add own logo, Name, courses etc. And promote it in social media). </a> 
          <p class="clrBlack regular fontRegular mrg_B_40">(REGULAR PRICE 4000/YEAR) </p>
       
          <span class="greyLine"></span>

          <p class="clrDarkGrey semiBold medium mrg_B_10">ATC FREE Bonus 4</p>
          <a href="#" class="other semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i> </span> Free Indian Festivals Videos with white label </a> 
         <p class="clrBlack regular fontRegular mrg_B_20">(REGULAR PRICE 4000/YEAR)</p>
        
        --%>
          <%=prodstr%>   
         </div>
</asp:Content>

