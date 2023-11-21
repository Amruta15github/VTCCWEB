<%@ Page Title="Tie-ups| VTCC" Language="C#" MasterPageFile="~/MasterParent.master" AutoEventWireup="true" CodeFile="tie-ups.aspx.cs" Inherits="tie_ups" %>
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
                    <h1 class="pageH1 clrWhite fontMedium">Tie-Ups</h1>
                    <ul class="bCrumb">
                        <li><a href="<%= Master.rootPath %>">Home</a></li>
                        <li>&raquo;</li>
                        <li>Tie-Ups</li>
                    </ul>
                    <div class="float_clear"></div>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Header Ends -->

  <span class="space50"></span>
    <section id="tieups"></section>
     <div class="container">
      <h2 class="pageH2 large themeClrThr text-center">VTCC Tie-Ups</h2>
      <span class="space30"></span>

       <%--  <div class="row">
         <span class="space30"></span>
         <div class="col-md-6">
          <p class=" other clrBlack regular fontRegular mrg_B_40"> logo </p>
          <p class="clrDarkGrey semiBold medium mrg_B_10"> Tieups title</p>
          <p class="clrBlack regular fontRegular mrg_B_40">Intro</p>
            <span class="space10"></span>
          <a href="https://www.indiabrand.co.in/bulk-whatsapp-marketing-software-Whatchat-Pro" class=" other clrBlack regular fontRegular mrg_B_40">View Certificate</a> 
         
         </div>
         
          <div class="col-md-6">
          <p class=" other clrBlack regular fontRegular mrg_B_40"> logo </p>
          <p class="clrDarkGrey semiBold medium mrg_B_10">Tieups title</p>
          <p class="clrBlack regular fontRegular mrg_B_40">Intro</p>
            <span class="space10"></span>
          <a href="https://www.indiabrand.co.in/bulk-whatsapp-marketing-software-Whatchat-Pro" class=" other clrBlack regular fontRegular mrg_B_40">View Certificate</a> 
         </div>
       
         
        </div>--%>
        
          <%=Gettieup()%>   
         </div>
</asp:Content>

