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
    <section id="vtcc tieups"></section>
     <div class="container">
      <h2 class="pageH2 large themeClrThr text-center">VTCC Tie-Ups</h2>
      <span class="space30"></span>
         <div class="form-row">
             <div class="form-group col-md-6">
                 <label for="inputtitle" class="fontRegular semiBold clrBlack">Tieup Title  : </label>
                 <asp:TextBox ID="txttieuptitle"  class="form-control"  runat="server"></asp:TextBox>
             </div>

             <div class="form-group col-md-6">
                  <label for="inputintro" class="fontRegular semiBold clrBlack">Logos or Certificate Upload: </label>
                 <asp:FileUpload ID="fuImage" runat="server" CssClass="form-control-file" />
                 <span class="space10"></span>
             </div>

              <div class="form-group col-md-6">
                 <label for="inputintro" class="fontRegular semiBold clrBlack">Introduction : </label>
                 <asp:TextBox ID="txtintro" class="form-control"  runat="server" TextMode="MultiLine"></asp:TextBox>
             </div>

             
         </div>

         </div>
</asp:Content>

