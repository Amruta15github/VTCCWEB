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
        	<%-- Card Body --%>
			<div class="card-body">
                <div class="colorLightBlue">
					<%--<span>Id</span>--%>
					<asp:Label ID="lblId" runat="server" Text="[New]"></asp:Label>
				</div>
        <span class="space30"></span>
        <div class="row">
            <div class="col-md-8">
                 <h1 class="pageH1 fontRegular">ATC Registration Information</h1>
                 <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
                <ContentTemplate>
                <div class="pad_15">
                  
                    <span class="semiBold semiMedium themeClrQtr">Basic Details:</span>
                    <span class="space20"></span>

                    <form>
                    <div>
                        <span class="space10"></span>

                        <asp:Label ID="lblnamecenter" class="fontRegular semiBold clrBlack" runat="server">Name of Organization/Center : </asp:Label>
                        <br />
                
                        <asp:Label ID="lbltypeorg" class="fontRegular semiBold clrBlack" runat="server">Type of Organization: </asp:Label>
                        <br />
                       

                        <asp:Label ID="lblstate" class="fontRegular semiBold clrBlack" runat="server">Select State: </asp:Label>
                        <br />
                     

                        <asp:Label ID="lbldist" class="fontRegular semiBold clrBlack" runat="server">Select District: </asp:Label>
                        <br />

                        <asp:Label ID="lbltaluka" class="fontRegular semiBold clrBlack" runat="server">Taluka:</asp:Label>
                        <br />

                        <asp:Label ID="lblCity" class="fontRegular semiBold clrBlack" runat="server">City Name: </asp:Label>
                        <br />

                        <span class="space20"></span>
                        <span class="semiBold semiMedium  themeClrQtr">Other Details:</span>
                        <span class="space20"></span>

                        <asp:Label ID="lblOwner" class="fontRegular semiBold clrBlack" runat="server">Owner Name/ Competent Authority: </asp:Label>
                        <br />

                        <asp:Label ID="lblgender" class="fontRegular semiBold clrBlack" runat="server">Gender: </asp:Label>
                        <br />
                     
                        <asp:Label ID="lblbday" class="fontRegular semiBold clrBlack" runat="server">Birth Date: </asp:Label>
                        <br />

                        <asp:Label ID="lblrole" class="fontRegular semiBold clrBlack" runat="server">Role :</asp:Label>
                        <br />
                      

                        <span class="space20"></span>
                        <span class="semiBold semiMedium  themeClrQtr">Contact Details:</span>
                        <span class="space20"></span>


                        <asp:Label ID="lblEmail" class="fontRegular semiBold clrBlack" runat="server">Email Id:</asp:Label>
                        <br />

                        <asp:Label ID="lblMobNo" class="fontRegular semiBold clrBlack" runat="server">Mobile No.:</asp:Label>
                        <br />

                        <asp:Label ID="lblpincode" class="fontRegular semiBold clrBlack" runat="server">Pincode :</asp:Label>
                        <br />

                        <!-- Display data corresponding to the fields -->
                        <asp:Label ID="lblData1" runat="server"></asp:Label><br />
                        <asp:Label ID="lblData2" runat="server"></asp:Label><br />
                        <asp:Label ID="lblData3" runat="server"></asp:Label><br />
                        <asp:Label ID="lblData4" runat="server"></asp:Label><br />
                        <asp:Label ID="lblData5" runat="server"></asp:Label><br />
                        <asp:Label ID="lblData6" runat="server"></asp:Label><br />
                        <asp:Label ID="lblData7" runat="server"></asp:Label><br />
                        <asp:Label ID="lblData8" runat="server"></asp:Label><br />
                        <asp:Label ID="lblData9" runat="server"></asp:Label><br />
                        <asp:Label ID="lblData10" runat="server"></asp:Label><br />
                        <asp:Label ID="lblData11" runat="server"></asp:Label><br />
                        <asp:Label ID="lblData12" runat="server"></asp:Label><br />
                        <asp:Label ID="lblData13" runat="server"></asp:Label><br />
                        <!-- Add more labels for displaying data of other fields -->

                    </div>
                    </form>

                
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

