<%@ Page Title="" Language="C#" MasterPageFile="~/MasterParent.master" AutoEventWireup="true" CodeFile="atc-renewal.aspx.cs" Inherits="atc_renewal" %>
<%@ MasterType VirtualPath="~/MasterParent.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script type="text/javascript"
        src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCvO0AHfg1cuND1KXbw3t5xZr5p4PVrEk4">
    </script>
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
                    <h1 class="pageH1 clrWhite fontMedium">Renewal</h1>
                    <ul class="bCrumb">
                        <li><a href="<%= Master.rootPath %>">Home</a></li>
                        <li>&raquo;</li>
                        <li>Renewal Process</li>
                    </ul>
                    <div class="float_clear"></div>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Header Ends -->
     <span class="space50"></span>
    <section id="actrenewal "></section>
     <div class="container ">
      <h2 class="pageH2 large themeClrThr text-center">Renewal Process</h2>
      <span class="space40"></span>
         <%-- <asp:Label ID="lblId" runat="server" Text="[New]"></asp:Label>--%>
          <asp:UpdatePanel ID="UpdatePanel1" runat="server">
          <ContentTemplate>
           <div class="row ">
             <%--<%=jobstr %>--%>

               <span class="space10"></span>

               <div class="form-group col-sm-12">

                   <span class="semiBold regular mr-30">Search ATC: *</span>
                   <asp:RadioButton ID="rdoAtc" runat="server" Checked="true" GroupName="Radio Atc" />

                   <label class="semiBold regular mr-30">By ATC Code</label>
                   <asp:RadioButton ID="rdoEmail" runat="server" GroupName="Radio Atc" />

                   <label class="semiBold regular">By Registered Email</label>
                   <span class="space20"></span>

                   <label for="inputEmail4" class="fontRegular semiBold">Enter ATC Code / Email Id:*</label>
                   <span class="space10"></span>

                   <asp:TextBox ID="txtsearchbx" class="form-control w-50" placeholder="ATC Code/ Email" runat="server"></asp:TextBox>
                   <span class="space30"></span>
               </div>
           </div>

              <asp:Button ID="btnSubmit" runat="server" CssClass="btn themeBgThr clrWhite" Text="Search" OnClick="btnSubmit_Click" />
              <span class="space30"></span>

              <div id="viewtable" runat="server">
                  
                   <table>
                            <tr>
                                <th>Center Name</th>                              
                                <th>Registration Date</th>
                                <th>Renew Date</th>
                            </tr>
                            <tr>
                                <td><%= arrAtc[0] %></td>
                                <td><%= arrAtc[1] %></td>
                                <td><%= arrAtc[2] %></td>
                              
                            </tr>
                        </table>
                    
                       <span class="space30"></span>
                      <a href="<%=arrAtc[3] %>" class="btn btn-outline-secondary">Proceed to Pay</a>
                
              </div>
                   
          </ContentTemplate>
          </asp:UpdatePanel>
          </div>
</asp:Content>

