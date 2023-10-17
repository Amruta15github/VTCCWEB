<%@ Page Title="" Language="C#" MasterPageFile="~/MasterParent.master" AutoEventWireup="true" CodeFile="job-openings.aspx.cs" Inherits="job_openings" %>
<%@ MasterType VirtualPath="~/MasterParent.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .jobopen {
            border-radius:10px;
        }

        .server {
            border-radius:10px;
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
                    <h1 class="pageH1 clrWhite fontMedium">Job Openings</h1>
                    <ul class="bCrumb">
                        <li><a href="<%= Master.rootPath %>">Home</a></li>
                        <li>&raquo;</li>
                        <li>Job Openings</li>
                    </ul>
                    <div class="float_clear"></div>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Header Ends -->

     <!-- job opening Starts -->
    <span class="space50"></span>
    <section id="jobopenings "></section>
     <div class="container ">
      <h2 class="pageH2 large themeClrThr text-center">Current Job Openings </h2>
      <span class="space50"></span>
           <div class="row ">
             <%=jobstr %>

           <%-- <div class="col-md-6 mb-4">
                <div class=" jobopen p-3 boxShadow border ">
                    <div class=" p-2">
                        <a href="#">
                            <h3 class="semiBold semiMedium themeClrThr ">Lic Housing 200</h3>
                        </a>
                        <span class="shortLine themeBgPrime"></span>
                    </div>
                    <span class="space10"></span>
                    <div class="p-2">
                    <div class="regular fontRegular semiBold">Posted On-<span class="fontRegular small line-ht-5"> 20/10/2022</span></div>
                    <span class="space10"></span>
                    <div class="regular fontRegular semiBold">Posted By-<span class="fontRegular small line-ht-5"> Admin</span></div>
                    </div>
                </div>
            </div>   
               --%>
              <%--  <div class="col-md-6 mb-4">
                <div class=" jobopen p-3 boxShadow border ">
                    <div class=" p-2">
                        <a href="#">
                            <h3 class="semiBold semiMedium themeClrThr ">Lic Housing 200</h3>
                        </a>
                        <span class="shortLine themeBgPrime"></span>
                    </div>
                    <span class="space10"></span>
                    <div class="p-2">
                    <div class="regular fontRegular semiBold">Posted On-<span class="fontRegular small line-ht-5"> 20/10/2022</span></div>
                    <span class="space10"></span>
                    <div class="regular fontRegular semiBold">Posted By-<span class="fontRegular small line-ht-5"> Admin</span></div>
                    </div>
                </div>
            </div> --%>

              <%--  <div class="col-md-6 mb-4">
                <div class=" jobopen p-3 boxShadow border ">
                    <div class=" p-2">
                        <a href="#">
                            <h3 class="semiBold semiMedium themeClrThr ">Lic Housing 200</h3>
                        </a>
                        <span class="shortLine themeBgPrime"></span>
                    </div>
                    <span class="space10"></span>
                    <div class="p-2">
                    <div class="regular fontRegular semiBold">Posted On-<span class="fontRegular small line-ht-5"> 20/10/2022</span></div>
                    <span class="space10"></span>
                    <div class="regular fontRegular semiBold">Posted By-<span class="fontRegular small line-ht-5"> Admin</span></div>
                    </div>
                </div>
            </div> --%>
               
      </div>
         </div>
     <%--view source--%>
    <%-- <div class="container ">
           <h2 class="pageH2 themeClrThr mrg_B_5 capitalize">Software Testing</h2>
               <span class="space15"></span>
              
               <p class="jobspost"> VTCC Education | 07 Oct 2023</p>
               <span class="space15"></span>
              
               <span class="semiMedium themeClrSec fontRegular">Total Views : 29</span>
               <span class="space20"></span>
               
               <div class="line-ht-5 fontRegular"> Job Skills : java.QA testing</div>
               <span class="space15"></span>
               <p class="line-ht-5 fontRegular"> Job Experience : 1 year</p>
               <span class="space15"></span>
               <p class="fontregular line-ht-5">Software testing is the act of examining the artifacts and the behavior of the software under test by validation and verification.</p>
              
          </div>--%>
</asp:Content>

