<%@ Page Title="" Language="C#" MasterPageFile="~/MasterParent.master" AutoEventWireup="true" CodeFile="courses.aspx.cs" Inherits="courses" %>
<%@ MasterType VirtualPath="~/MasterParent.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <style>
    .course-thumbnail {
      width: 300px;
      height: 169px; 
      padding: 20px;
      border: 1px solid #e0e0e0;
      border-radius: 5px;
      background-color: #fff;
      box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
      text-align: center;
      cursor: pointer;
    }

         .course:hover {
            
             background: #e8ba99;
         }

    .course-title {
      font-weight: bold;
      margin-top: 10px;
    }

    .course-description {
      margin-top: 10px;
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
                    <h1 class="pageH1 clrWhite fontMedium">Courses</h1>
                    <ul class="bCrumb">
                        <li><a href="<%= Master.rootPath %>">Home</a></li>
                        <li>&raquo;</li>
                        <li>Courses</li>
                    </ul>
                    <div class="float_clear"></div>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Header Ends -->

     <span class="space50"></span>
    <section id="jobopenings "></section>
     <div class="container ">
      <h2 class="pageH2 large themeClrThr text-center">Courses We Offer</h2>
      <span class="space30"></span>

         <a href="~/courseinfo.aspx" runat="server">
             <div class="course course-thumbnail">
                 <div class="course-title clrBlack">Course Title</div>
                 <div class="course-description clrBlack">A brief description of the course goes here.</div>
             </div>
         </a>

         </div>
        
</asp:Content>

