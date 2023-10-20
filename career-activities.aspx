<%@ Page Title="" Language="C#" MasterPageFile="~/MasterParent.master" AutoEventWireup="true" CodeFile="career-activities.aspx.cs" Inherits="career_activities" %>
<%@ MasterType VirtualPath="~/MasterParent.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
    .image-container {
    width: 300px;
    height: 300px;
    overflow: hidden; /* Hide any parts of the image that exceed the container */
      }

   .image-container img {
    width: 100%; /* Make the image expand to fill the container width */
    height: auto; /* Maintain the aspect ratio by adjusting the height automatically */
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
                    <h1 class="pageH1 clrWhite fontMedium">Career Activities</h1>
                    <ul class="bCrumb">
                        <li><a href="<%= Master.rootPath %>">Home</a></li>
                        <li>&raquo;</li>
                        <li>Career-Activities</li>
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
      <h2 class="pageH2 large themeClrThr text-center">Our Career Activities</h2>
      <span class="space30"></span>
          <%=careerstr %>
       <%-- <span class="semiBold medium themeClrPrime">Career Assessment</span>
        <span class="space10"></span>
        <span class="fontRegular">05 - Apr - 2023 | <span class="fontRegular">Mark Wiens</span></span>
        <span class="space20"></span>
        <p class="fontRegular line-ht-5 regular clrDarkGrey">Another career classroom lesson that you can use in your career counseling sessions for high school students is to have them complete questionnaires 
                    that help as young as 2nd-grade learners with career learning. Youngsters will find it easier to form career objectives when they are exposed to the different options available to them. 
        </p>
        <span class="space15"></span>
        <div class="row">
            <div class="col-md-4">                   
                <a href="images/carreract-img1.jpg" data-fancybox="imggroup1">
                <img class="img-fluid"  src="images/carreract-img1.jpg" alt=""/></a>             
            </div>
            <div class="col-md-4">  
                 <a href="images/carreract-img3.jpg" data-fancybox="imggroup1">
                <img class="img-fluid" src="images/carreract-img3.jpg" alt=""/></a>             
            </div>
            <div class="col-md-4">       
                 <a href="images/carreract-img2.jpg" data-fancybox="imggroup1">
                <img class="img-fluid" src ="images/carreract-img2.jpg" alt=""/></a>   
            </div>
        </div>      --%>
      

      
     </div>

    
</asp:Content>

