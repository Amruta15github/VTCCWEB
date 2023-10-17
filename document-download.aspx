<%@ Page Title="" Language="C#" MasterPageFile="~/MasterParent.master" AutoEventWireup="true" CodeFile="document-download.aspx.cs" Inherits="document_download" %>
<%@ MasterType VirtualPath="~/MasterParent.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- Page Header Starts -->
    <div class="pgHeader1">
        <div class="headerOverlay">           
            <div class="bottomLight"></div>
            <div class="container">
                <div class="pg_TB_pad">
                    <h1 class="pageH1 clrWhite fontMedium">Download</h1>
                    <ul class="bCrumb">
                        <li><a href="<%= Master.rootPath %>">Home</a></li>
                        <li>&raquo;</li>
                        <li>Download Document</li>
                    </ul>
                    <div class="float_clear"></div>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Header Ends -->

      <!-- doc starts -->
     <span class="space50"></span>
    <section id="news "></section>
     <div class="container ">
      <h2 class="pageH2 large themeClrThr text-center">Download library</h2>
      <span class="space40"></span>
           <div class="row">
                <%=GetDocuments() %>
          <%-- <div class="col-sm-4">
                <a href="#" class="news-Tag fontRegular regular">Lorem Ipsum is simply dummy text of the printing.
                </a>
                <span class="space10"></span>
                <a href="#" class="pdfAnch">Download &#10230;</a>
            </div>
            <div class="col-sm-4">
                <a href="#" class="news-Tag fontRegular regular">Lorem Ipsum is simply dummy text of the printing.
                </a>
                <span class="space10"></span>
                <a href="#" class="pdfAnch">Download &#10230;</a>
            </div>
            <div class="col-sm-4">
                <a href="#" class="news-Tag fontRegular regular">Lorem Ipsum is simply dummy text of the printing.
                </a>
                <span class="space10"></span>
                <a href="#" class="pdfAnch">Download &#10230;</a>
            </div>--%>
               </div>
        </div>
    
    <!-- download pdfs end -->
         
</asp:Content>

