<%@ Page Title="" Language="C#" MasterPageFile="~/MasterParent.master" AutoEventWireup="true" CodeFile="training-centers.aspx.cs" Inherits="training_centers" %>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- Page Header Starts -->
    <div class="pgHeader1">
        <div class="headerOverlay">           
            <div class="bottomLight"></div>
            <div class="container">
                <div class="pg_TB_pad">
                    <h1 class="pageH1 clrWhite fontMedium">Affiliation Centers</h1>
                    <ul class="bCrumb">
                        <li><a href="<%= Master.rootPath %>">Home</a></li>
                        <li>&raquo;</li>
                        <li>Exam Center</li>
                    </ul>
                    <div class="float_clear"></div>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Header Ends -->

    <!-- VTCC ATC Affiliation starts -->
     <span class="space50"></span>  
     <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
     <ContentTemplate>
    <section id="Affiliation"></section>
     <div class="container">
      <h2 class="pageH2 large themeClrThr text-center">ATC List (Authorized Training Centers List) </h2>
        
      <span class="space50"></span>

      <asp:Label ID="lblId" runat="server" Text="[New]"></asp:Label>
      <div class="form-row">
           <div class="form-group col-md-6">
             <label for="typeoforg" class="fontRegular semiBold clrBlack"> Select State : </label>
             <asp:DropDownList ID="ddlstate" CssClass="cmbBox" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlstate_SelectedIndexChanged">
               
                 <asp:ListItem Value="0"><- Select State -></asp:ListItem>
             </asp:DropDownList>
          </div>

             <div class="form-group col-md-6">
             <label for="typeoforg" class="fontRegular semiBold clrBlack"> Select District : </label>
             <asp:DropDownList ID="ddldist" CssClass="cmbBox" runat="server" AutoPostBack="true">
               
                 <asp:ListItem Value="0"><- Select District -></asp:ListItem>
             </asp:DropDownList>
             </div> 
           
           <div class="form-group col-md-6">          
             <label for="inputpincode" class="fontRegular semiBold clrBlack">Pincode : </label>
             <asp:TextBox ID="txtpin"  class="form-control"  runat="server"></asp:TextBox>
           </div>
         </div> 

            
          <span class="space20"></span>
            <asp:Button ID="btnSearch" CssClass="btn themeBgThr clrWhite" runat="server" Text="Search" OnClick="btnSearch_Click" />
              <span class="space20"></span>

         
        <div id="viewtable" runat="server">
         <%--table--%>
         <table class="table">
  <thead>
    <tr>
      <th scope="col">Center Name</th>    
      <th scope="col">Pincode</th>
      <th scope="col">Mobile No</th>
      <th scope="col">Email</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope="row">shreecpmputers</th>
      <td>Mark</td>
      <td>Otto</td>
      <td>@mdo</td>
    
    </tr>
    <tr>
      <th scope="row">jspider</th>
      <td>Jacob</td>
      <td>Thornton</td>
      <td>@fat</td>
      
    </tr>
    <tr>
      <th scope="row">wisdom</th>
      <td>Larry</td>
      <td>the Bird</td>
      <td>@twitter</td>
     
    </tr>
     
  </tbody>
</table>
        </div>
      
     </div>

        </ContentTemplate>
    </asp:UpdatePanel> 
</asp:Content>

