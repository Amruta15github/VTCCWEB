<%@ Page Title="ATC-Data | VTCC" Language="C#" MasterPageFile="~/centers/MasterAdmin.master" AutoEventWireup="true" CodeFile="atc-data.aspx.cs" Inherits="centers_atc_data" %>
<%@ MasterType VirtualPath="~/MasterParent.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script type="text/javascript"
        src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCvO0AHfg1cuND1KXbw3t5xZr5p4PVrEk4">
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
    
    <!-- registration form start -->
    <span class="space20"></span>
     <h2 class="pgTitle">ATC Registration Information</h2>
    <span class="space10"></span>
   
   
        <div class="card card-primary">
            <div class="card-header">
				<h3 class="card-title">ATC Registration Information</h3>
			</div>
            <!-- Card Body -->
            <div class="card-body">
                <div class="colorLightBlue">
                    <asp:Label ID="lblId" runat="server" Text="[New]"></asp:Label>
                </div>
                <span class="space20"></span>
                <div class="row">
                    <div class="col-md-8">                                                             
                                <div class="row">
                                    <div class="col-md-6">
                                        <span class=" semiMedium themeClrThr"><strong>Basic Details</strong></span>
                                        <span class="space20"></span>
                                        <div>
                                            <p>Center Name : <%= arrData[0] %></p>
                                            <p>Type of Organization : <%= arrData[1] %></p>
                                             <p>State : <%=arrData[2] %></p>
                                              <p>District : <%=arrData[3] %></p>
                                             <p>Taluka : <%=arrData[4] %></p>
                                             <p>City Name : <%=arrData[5] %></p>
                                            <!--  basic details... -->
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <span class="bold semiMedium themeClrThr"><strong>Other Details</strong></span>
                                        <span class="space20"></span>
                                        <div>
                                            <p>Owner Name : <%= arrData[6] %></p>
                                            <p>Gender : <%= arrData[7] %></p>
                                             <p>Birth date : <%= arrData[8] %></p>
                                             <p>Role : <%= arrData[9] %></p>

                                            <!-- Other details... -->
                                        </div>
                                    </div>
                                     <div class="col-md-6">
                                        <span class="bold semiMedium themeClrThr"><strong>Contact Details</strong></span>
                                        <span class="space20"></span>
                                        <div>
                                            <p>Email Id : <%= arrData[10] %></p>
                                            <p>Mobile No.: <%= arrData[11] %></p>
                                             <p>Pincode : <%= arrData[12] %></p>                                       
                                            <!-- contact details... -->
                                        </div>
                                    </div>
                                    
                                </div>
                           
                    </div>
                </div>
            </div>
        </div>
    
    <!-- registration form Ends -->
    <span class="space30"></span>
</asp:Content>








  