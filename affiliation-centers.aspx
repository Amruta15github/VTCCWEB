<%@ Page Title="" Language="C#" MasterPageFile="~/MasterParent.master" AutoEventWireup="true" CodeFile="affiliation-centers.aspx.cs" Inherits="affiliation_centers" %>
<%@ MasterType VirtualPath="~/MasterParent.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <style>
        .splitscreen {display: flex;}
            .splitscreen .left,
            .splitscreen .right {flex: 1;}

        table {font-family: arial, sans-serif; border-collapse: collapse; width: 100%;}
        td, th {border: 1px solid #dddddd; text-align: left; padding: 8px; color: #000000}
        tr:nth-child(even) {background-color: #dddddd;}
        th {font-weight: 600; color: #000000;}
    </style>
     <style>
table {
  font-family: arial, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

td, th {
  border: 1px solid #dddddd;
  text-align: left;
  padding: 8px;
}

tr:nth-child(even) {
  background-color:rgba(250, 243, 246, 0.8);
}
</style>

     <%-- <style>
        .other {
           color:black;
          
        }
            .other:hover {
                color:#d19563;
            }
    </style>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <!-- Page Header Starts -->
    <div class="pgHeader1">
        <div class="headerOverlay">           
            <div class="bottomLight"></div>
            <div class="container">
                <div class="pg_TB_pad">
                    <h1 class="pageH1 clrWhite fontMedium">Affiliation </h1>
                    <ul class="bCrumb">
                        <li><a href="<%= Master.rootPath %>">Home</a></li>
                        <li>&raquo;</li>
                        <li>VTCC ATC Affiliation</li>
                    </ul>
                    <div class="float_clear"></div>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Header Ends -->
     <span class="space50"></span>
    <section id="Affiliation"></section>
     <div class="container">
      <h2 class="pageH2 large themeClrThr text-center">VTCC ATC Affiliation :- </h2>
      <span class="space30"></span>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">VOCATIONAL TRAINING AND CERTIFICATION COMMITTEE, NEW DELHI, INDIA (VTCC) open all over India affiliations for institutes which are imparting Technical Education/training to students and sending them for the qualifying Examinations conducted by the COMMITTEE. </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">ATC can start short terms and diploma courses approved by VTCC Expert Committee.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20"><span class="semiBold semiMedium mrg_B_10 mt-4 themeClrThr">VTCC ATC Affiliation :-</span></p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20"><span class="semiBold clrDarkGrey">AFFILIATION FEE, RENEWAL AFFILIATION ARE AS FOLLOWS :-</span></p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20"><span class="semiBold clrDarkGrey">VTCC NEW DELHI AFFILIATION FEE IS ₹ 5500 /YEAR (NON-REFUNDABLE)</span></p>
         <li class="clrDarkGrey regular fontRegular mrg_B_20"><span class="semiBold clrDarkGrey">ATC renewal FEE ₹ 5000 /YEAR (Non-Refundable)</span></li>
         <p class="clrDarkGrey regular fontRegular mrg_B_20"><span class="semiBold clrBlack">CERTIFICATION CHARGES FOR COMPUTER & VOCATIONAL COURSES</span></p>
        <%-- table--%>
          <table>
       <tr>
    <th>Sr.no</th>
    <th>Course duration in months</th>
    <th>Certificate/Diploma</th>
    <th>REGISTRATION +Exam +Certification charges</th>
   </tr>
   <tr>
    <td>1</td>
    <td>Any 1 Month</td>
    <td>Certificate Course</td>
    <td>150 ₹</td>
  </tr>
  <tr>
    <td>2</td>
    <td>Any 2 Months</td>
       <td>Certificate Course</td>
    <td>200 ₹</td>
  </tr>
  <tr>
    <td>3</td>
    <td>Any 3 Months</td>
       <td>Certificate Course</td>
    <td>300 ₹</td>
  </tr>
  <tr>
    <td>4</td>
    <td>Any 4 Months</td>
       <td>Certificate Course</td>
    <td>400 ₹</td>
  </tr>
  <tr>
    <td>5</td>
    <td>Any 6 Months</td>
       <td>Certificate Course</td>
    <td>500 ₹</td>
  </tr>
  <tr>
    <td>6</td>
    <td>Any 6 Months</td>
       <td>Diploma Course</td>
    <td>600 ₹</td>
  </tr>
  <tr>
    <td>7</td>
    <td>Any 12 Months  </td>
       <td>Diploma Course</td>
   <td>`1200 ₹</td>
  </tr>
  <tr>
    <td>8</td>
    <td>Any 72 Hours</td>
       <td>Certificate Course</td>
    <td>150 ₹</td>
  </tr>
           <tr>
    <td>9</td>
    <td>Any 40 Hours</td>
       <td>Certificate Course</td>
    <td>150 ₹</td>
  </tr>
           <tr>
    <td>10</td>
    <td>Any 120 Hours  </td>
       <td>Certificate Course</td>
    <td>175 ₹</td>
  </tr>
           <tr>
    <td>11</td>
    <td>Any 30 Hours or Below 30 Hrs.   </td>
       <td>Certificate Course</td>
    <td>150 ₹</td>
  </tr>
           <tr>
    <td>12</td>
    <td>Work shop Certificate from 1-4 Days</td>
       <td>Certificate Course</td>
    <td>150 ₹</td>
  </tr>
           <tr>
    <td>13</td>
    <td>Participation Certification </td>
       <td>Certificate Course</td>
    <td>150 ₹</td>
  </tr>
</table>
     <span class="space30"></span>    
         <p class="clrDarkGrey regular fontRegular mrg_B_20"><span class="semiBold semiMedium clrBlack">Required Documents for ATC :-</span></p>
         <p class="clrDarkGrey regular fontRegular mrg_B_10">After provisional registration, the training center must complete its profile with the required documents for receiving the VTCC final registration code.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_10">Upload the Following documents in ATC login after provisional approval. The Center will receive the final registration certificate after VTCC Team does document verification.</p>
         <li class="clrDarkGrey regular fontRegular mrg_B_10"> I card size scan copy of the Photo the Owner </li>
         <li class="clrDarkGrey regular fontRegular mrg_B_10"> Centre owner Identity proof. (Pan Card/ Aadhaar /Voter ID Card/any other). </li>
         <li class="clrDarkGrey regular fontRegular mrg_B_10"> Centre setup photos (Outdoor, Display Board, LAB, Classroom, Office, Computers, Machinery, Computers etc. as per required courses ) </li>
         <li class="clrDarkGrey regular fontRegular mrg_B_10"> Staff/Owner Educational Qualification Documents  </li>
         <li class="clrDarkGrey regular fontRegular mrg_B_10"> Rental Agreement or ownership document  </li>
         <li class="clrDarkGrey regular fontRegular mrg_B_10"> Undertaking by the Coordinator. </li>
         <li class="clrDarkGrey regular fontRegular mrg_B_20"> Center out door photo (eg. Board Photo)  </li>

         <a href="center-registration">Apply for ATC click here </a>
          <span class="greyLine"></span>

         <p class="clrDarkGrey regular fontRegular mrg_B_20"><span class="semiBold semiMedium mrg_B_10 mt-4 themeClrThr">Franchisee (ATC) Benefits  :-</span></p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20"><span class="semiBold clrDarkGrey">ATC benefits after Getting Franchisee from VOCATIONAL TRAINING AND CERTIFICATION COMMITTEE, NEW DELHI, INDIA (VTCC)</span></p>
          <li class="clrDarkGrey regular fontRegular mrg_B_10"> ATC will use VOCATIONAL TRAINING AND CERTIFICATION COMMITTEE, NEW DELHI, INDIA (VTCC) brand name and logo on their advertisements/Banners etc.</li>
          <li class="clrDarkGrey regular fontRegular mrg_B_10"> Internationally valid certification for students. </li>
          <li class="clrDarkGrey regular fontRegular mrg_B_10"> ATC will receive the ATC center code after getting affiliation from VTCC. </li>
          <li class="clrDarkGrey regular fontRegular mrg_B_10"> ATC will use a center login ID and Password for various login facilities. </li>
          <li class="clrDarkGrey regular fontRegular mrg_B_10"> Online Student Certificate verification facility </li>
          <li class="clrDarkGrey regular fontRegular mrg_B_10"> Online Student Registration facility. </li>
          <li class="clrDarkGrey regular fontRegular mrg_B_10"> Online examination facility free online exam. No extra online exam charges for ATC. </li>
          <li class="clrDarkGrey regular fontRegular mrg_B_10"> Area-wise Online Job alert facilities to students. </li>
          <li class="clrDarkGrey regular fontRegular mrg_B_10"> ATC can post their local jobs from their login. And is automatically displayed on the VTCC website with center name, address, mobile number  </li>
          <li class="clrDarkGrey regular fontRegular mrg_B_10"> ATC can post their placed students from their login, and it's automatically displayed on the VTCC web site with the center name, address, and mobile number. This will also help generate student inquiries. </li>
          <li class="clrDarkGrey regular fontRegular mrg_B_10"> ATC will get student practice exam application on mobile  </li>
          <li class="clrDarkGrey regular fontRegular mrg_B_10"> Discount on various Digital Marketing Materials Eg. Marketing Images, Marketing Software like WhatsApp Marketing software, Online Digital Card and many more. </li>
          <li class="clrDarkGrey regular fontRegular mrg_B_10"> ATCs Can Download a Student certificate digital copy at any time from their login. </li>
          <li class="clrDarkGrey regular fontRegular mrg_B_10"> Internationally valid certification for students. </li>
          <li class="clrDarkGrey regular fontRegular mrg_B_10"> VTCC- Digital Job alert card </li>
          <li class="clrDarkGrey regular fontRegular mrg_B_10"> Free Bonuses worth 20,000/- after final accreditation of the center. </li>
          <span class="greyLine"></span>

         <p class="clrDarkGrey regular fontRegular mrg_B_20"><span class="semiBold semiMedium mrg_B_10 mt-4 themeClrThr">FREE ATC KIT UNDER BUSINESS BOOSTER SCHEME FOR ATC :-</span></p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">VTCC NEW Delhi will send a <span class="semiBold clrBlack">Franchisee certification  </span> to the AUTHORIZED TRAINING CENTER (2 Original Copies, 1 with frame and a second copy for official purposes). Refer to the sample copies in the sample certificate page section.</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_30">VTCC NEW Delhi will send a  <span class="semiBold clrBlack">candidate Sample certifications  </span> to an AUTHORIZED TRAINING CENTER (2 Sets – 1 For Notice Board and a second copy for the student inquiry table/notice board).</p>

        
         </div>
</asp:Content>

