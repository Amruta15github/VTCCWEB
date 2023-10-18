<%@ Page Title="" Language="C#" MasterPageFile="~/MasterParent.master" AutoEventWireup="true" CodeFile="placed-students.aspx.cs" Inherits="placed_students" %>
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
                    <h1 class="pageH1 clrWhite fontMedium">Placed Students</h1>
                    <ul class="bCrumb">
                        <li><a href="<%= Master.rootPath %>">Home</a></li>
                        <li>&raquo;</li>
                        <li>Placed Students</li>
                    </ul>
                    <div class="float_clear"></div>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Header Ends -->

     <!-- placed student Starts -->
    <span class="space50"></span>
    <section id="jobopenings "></section>
     <div class="container ">
      <h2 class="pageH2 large themeClrThr text-center">Successfully Placed Students </h2>
      <span class="space30"></span>
        <%= GetStudentPlacements() %>

        <%-- <div class="fontRegular regular semiBold clrBlack text-center ">
           Jyoti Computers, Malgaon<br />
            <span class="fontRegular regular clrBlack">demo@gmail.com<span class="fontRegular regular small ml-3"> Contact: 9975327900</span></span>
               <span class="space20"></span>
        </div> 
           <span class="space40"></span>--%>

       <%-- <div class="row">
            <div class="col-md-6">
                <div class="row">
                      <div class="col-md-3 d-flex align-items-center justify-content-center">
                         <img src="images/placed.jpg" class="img-fluid w-100" /><br />                   
                    </div> --%>

                     <%--<span class="space10"></span>
                    <div class="col-md-9">
                        <div class="semiBold semiMedium  mb-2">Amit AGARWAL</div>
                    <div class="regular fontRegular semiBold mb-1">Date - <span class="fontRegular small line-ht-5">tesst</span></div>

                    <div class="regular fontRegular semiBold mb-1">Course - <span class="fontRegular small line-ht-5">Full Stack Development Professional</span></div>

                    <div class="regular fontRegular semiBold mb-1">Comapny  - <span class="fontRegular small line-ht-5">Tech Mahindra Ltd.</span></div>--%>

                   <%-- <div class="regular fontRegular semiBold mb-1">Designation  - <span class="fontRegular small line-ht-5">test</span></div>--%>

                  <%-- <div class="regular fontRegular semiBold mb-1">Country  - <span class="fontRegular small line-ht-5">India</span></div>
                    </div>
                </div>
            </div>--%>

            <%-- <div class="col-md-6">
                <div class="row">
                      <div class="col-md-3 d-flex align-items-center justify-content-center">
                         <img src="images/placed.jpg" class="img-fluid w-100" /><br />
                          <%-- <span class="shortLine themeBgThr"></span>--%>
                  <%--  </div> 
                     <span class="space10"></span>
                    <div class="col-md-9">
                        <div class="semiBold semiMedium  mb-2">Amit AGARWAL</div>--%>
                    <%--<div class="regular fontRegular semiBold mb-1">Date - <span class="fontRegular small line-ht-5">tesst</span></div>--%>

                   <%-- <div class="regular fontRegular semiBold mb-1">Course - <span class="fontRegular small line-ht-5">Full Stack Development Professional</span></div>

                    <div class="regular fontRegular semiBold mb-1">Comapny  - <span class="fontRegular small line-ht-5">Tech Mahindra Ltd.</span></div>--%>

                   <%-- <div class="regular fontRegular semiBold mb-1">Designation  - <span class="fontRegular small line-ht-5">test</span></div>--%>

                  <%-- <div class="regular fontRegular semiBold mb-1">Country  - <span class="fontRegular small line-ht-5">India</span></div>
                    </div>
                </div>
            </div>

         </div>
            <span class="greyLine"></span>--%>
      <%--  <div class="row">
            <div class="col-md-6">
                <div class="row">
                      <div class="col-md-3 d-flex align-items-center justify-content-center">
                         <img src="images/placed.jpg" class="img-fluid w-100" /><br />
                         
                    </div> 

                     <span class="space10"></span>
                    <div class="col-md-9">
                        <div class="semiBold semiMedium  mb-2">Amit AGARWAL</div>--%>
                    <%--<div class="regular fontRegular semiBold mb-1">Date - <span class="fontRegular small line-ht-5">tesst</span></div>--%>

                   <%-- <div class="regular fontRegular semiBold mb-1">Course - <span class="fontRegular small line-ht-5">Full Stack Development Professional</span></div>

                    <div class="regular fontRegular semiBold mb-1">Comapny  - <span class="fontRegular small line-ht-5">Tech Mahindra Ltd.</span></div>--%>

                   <%-- <div class="regular fontRegular semiBold mb-1">Designation  - <span class="fontRegular small line-ht-5">test</span></div>--%>

                   <%-- <div class="regular fontRegular semiBold mb-1">Country  - <span class="fontRegular small line-ht-5">India</span></div>
                    </div>
                </div>
            </div>
             </div>
          <span class="greyLine"></span>--%>
         </div>
</asp:Content>

