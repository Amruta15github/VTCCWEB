<%@ Page Title="" Language="C#" MasterPageFile="~/MasterParent.master" AutoEventWireup="true" CodeFile="sample-certificates.aspx.cs" Inherits="sample_certificates" %>
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
                    <h1 class="pageH1 clrWhite fontMedium">Sample Certificates</h1>
                    <ul class="bCrumb">
                        <li><a href="<%= Master.rootPath %>">Home</a></li>
                        <li>&raquo;</li>
                        <li>Sample Certificates</li>
                    </ul>
                    <div class="float_clear"></div>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Header Ends -->

      <%-- sample Certificate starts--%>
     <span class="space50"></span>
    <section id="aboutus"></section>
     <div class="container">        
         <h2 class="pageH2 large themeClrThr text-center">VTCC Sample Certifications</h2>
         <span class="space30"></span>

         <div class="row justify-content-center">
            <div class="col-md-6 text-center">
                <div class="p-2">
                    <div class="border p-3">
                        <a href="images/about-us/ATC-certificate.jpg" data-fancybox="imggroup1">
                            <img src="images/about-us/ATC-certificate.jpg" class="img-fluid" /></a>
                        <span class="space20"></span>
                        <div class="border">
                            <div class="p-2">
                                <span class="fontRegular semiBold clrDarkGrey"> ATC Accreditation Certification </span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

             <div class="col-md-6 text-center">
                <div class="p-2">
                    <div class="border p-3">
                        <a href="images/about-us/studentcertificate.jpg" data-fancybox="imggroup1">
                            <img src="images/about-us/studentcertificate.jpg" class="img-fluid" /></a>
                        <span class="space20"></span>
                        <div class="border">
                            <div class="p-2">
                                <span class="fontRegular semiBold clrDarkGrey">Student Sample Certification</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

              <div class="col-md-6 text-center">
                <div class="p-2">
                    <div class="border p-3">
                        <a href="images/about-us/marklistsample.jpg" data-fancybox="imggroup1">
                            <img src="images/about-us/marklistsample.jpg" class="img-fluid" /></a>
                        <span class="space20"></span>
                        <div class="border">
                            <div class="p-2">
                                <span class="fontRegular semiBold clrDarkGrey">Student Sample Mark list</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
         </div>
         </div>
</asp:Content>

