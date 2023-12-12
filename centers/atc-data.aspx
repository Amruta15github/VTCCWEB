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
    <div class="container">
        <div class="card card-primary">
            <!-- Card Body -->
            <div class="card-body">
                <div class="colorLightBlue">
                    <asp:Label ID="lblId" runat="server" Text="[New]"></asp:Label>
                </div>
                <span class="space30"></span>
                <div class="row">
                    <div class="col-md-8">
                        <h1 class="pageH1 fontRegular">ATC Registration Information</h1>
                        <span class="space20"></span>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <div class="row">
                                    <div class="col-md-6">
                                        <span class=" bold semiMedium">Basic Details</span>
                                        <span class="space20"></span>
                                        <div>
                                            <p>Name of Organization/Center: <%= arrData[0] %></p>
                                            <p>Type of Organization: <%= arrData[1] %></p>
                                             <p>Select State: <%=arrData[2] %></p>
                                              <p>Select District: <%=arrData[3] %></p>
                                             <p>Taluka: <%=arrData[4] %></p>
                                             <p>City Name: <%=arrData[5] %></p>
                                            <!--  basic details... -->
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <span class="bold semiMedium">Other Details</span>
                                        <span class="space20"></span>
                                        <div>
                                            <p>Owner Name/ Competent Authority: <%= arrData[6] %></p>
                                            <p>Gender: <%= arrData[7] %></p>
                                             <p>Birth date: <%= arrData[8] %></p>
                                             <p>Role: <%= arrData[9] %></p>

                                            <!-- Other details... -->
                                        </div>
                                    </div>
                                     <div class="col-md-6">
                                        <span class="bold semiMedium ">Contact Details</span>
                                        <span class="space20"></span>
                                        <div>
                                            <p>Email Id: <%= arrData[10] %></p>
                                            <p>Mobile No.: <%= arrData[11] %></p>
                                             <p>Pincode: <%= arrData[12] %></p>
                                            

                                            <!-- contact details... -->
                                        </div>
                                    </div>
                                    
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- registration form Ends -->
    <span class="space30"></span>
</asp:Content>








  