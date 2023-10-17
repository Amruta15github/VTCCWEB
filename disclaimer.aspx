<%@ Page Title="" Language="C#" MasterPageFile="~/MasterParent.master" AutoEventWireup="true" CodeFile="disclaimer.aspx.cs" Inherits="disclaimer" %>
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
                    <h1 class="pageH1 clrWhite fontMedium">Disclaimer</h1>
                    <ul class="bCrumb">
                        <li><a href="<%= Master.rootPath %>">Home</a></li>
                        <li>&raquo;</li>
                        <li>Disclamier</li>
                    </ul>
                    <div class="float_clear"></div>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Header Ends -->
     <span class="space50"></span>
    <section id="Disclamier">
         
        <div class="container">
             <h2 class="pageH2 large themeClrThr text-center">Disclamier</h2>
             <span class="space20"></span>
             <p class="fontRegular regular clrDarkGrey">The VTCC is a self-dependent Body who create won syllabus structure and examination pattern. <span class="semiBold clrBlack">VTCC </span> does not take any responsibility regarding the certificate issued by it shall be accepted by any government organizations or business organization.
                 <br />
                 The <span class="semiBold clrBlack">VTCC </span> issues the certificate as well as the mark sheet for courses designed and developed by VTCC skill team for self-employment purpose.</p>
            </div>
        </section>
</asp:Content>

