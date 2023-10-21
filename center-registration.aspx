<%@ Page Title="Center-Registration | VTCC" Language="C#" MasterPageFile="~/MasterParent.master" AutoEventWireup="true" CodeFile="center-registration.aspx.cs" Inherits="center_registration" %>
<%@ MasterType VirtualPath="~/MasterParent.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script type="text/javascript"
        src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCvO0AHfg1cuND1KXbw3t5xZr5p4PVrEk4">
    </script>


   <%-- <script type="text/javascript">
        window.onload = function () {
            //alert("window load");

            duDatepicker('#<%= txtbday.ClientID %>', {
                auto: true, inline: true, format: 'dd/mm/yyyy',
            });
        }
    </script>--%>
   

    <script type="text/javascript">
        function setupcalendar() {
            duDatepicker('#<%= txtbday.ClientID %>', {
                auto: true, inline: true, format: 'dd/mm/yyyy',
            });
        }
     </script>



    <script type="text/javascript">
        function pageLoad(sender, args) {
            if (args.get_isPartialLoad()) {
                setupcalendar();
            }
        }
     </script>

    <script type="text/javascript">
        // Call setupAutocomplete on initial page load
        $(document).ready(function () {
            setupcalendar();
        });
    </script>
     
 

   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <!-- Page Header Starts -->
    <div class="pgHeader1">
        <div class="headerOverlay">           
            <div class="bottomLight"></div>
            <div class="container">
                <div class="pg_TB_pad">
                    <h1 class="pageH1 clrWhite fontMedium">Registration</h1>
                    <ul class="bCrumb">
                        <li><a href="<%= Master.rootPath %>">Home</a></li>
                        <li>&raquo;</li>
                        <li>Registration</li>
                    </ul>
                    <div class="float_clear"></div>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Header Ends -->

     <!-- registration form start -->
    <span class="space50"></span>
    <div class="container">
    <h2 class="pageH2 large themeClrThr text-center">Complete Your Registration Process </h2>
       
        <span class="space30"></span>
        <div class="row">
            <div class="col-md-8">
                 <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
                <ContentTemplate>
                <div class="pad_15">
                    <span class="semiBold semiMedium themeClrQtr">Basic Details:</span>
                    <span class="space20"></span>
                    <form>

                    <!-- Your form fields and other HTML elements go here -->
                    <!-- For example, you have input fields, checkboxes, and the submit button -->

                        <span class="space10"></span>
                       <%-- <div class="form-group">
                            <label class="semiBold regular mr-30 clrBlack">I wish to register for: *</label>
                            <asp:RadioButton ID="compcourse" runat="server" Checked="true"/>
                            <label class="regular fontRegular">Computer Course</label>
                            <span class="space20"></span>
                            </div>--%>
                         <div class="form-row">
                         <div class="form-group col-md-6">
                            <label for="inputorgname" class="fontRegular semiBold clrBlack">Name of Organization/Center : *</label>
                            <asp:TextBox ID="txtorgname"   MaxLength="50" class="form-control" placeholder="Organization/Center Name" runat="server"></asp:TextBox>
                             </div>

                              <div class="form-group col-md-6">
                            <label for="typeoforg" class="fontRegular semiBold clrBlack">Type of Organization: *</label>
                                <asp:DropDownList ID="ddltypeoforg" CssClass="cmbBox" runat="server"  AutoPostBack="true" ><%--OnSelectedIndexChanged="ddrState_SelectedIndexChanged"--%>
                                    <asp:ListItem Value="0"><- Select Organization -></asp:ListItem>
                                </asp:DropDownList>
                                  </div>
                        </div>
                     
                           <div class="form-row">
                            <div class="form-group col-md-6">
                            <label for="exampleFormControlSelect1" class="fontRegular semiBold clrBlack">Select State: *</label>
                                <asp:DropDownList ID="ddrState" CssClass="cmbBox" runat="server"  AutoPostBack="true" OnSelectedIndexChanged="ddrState_SelectedIndexChanged">
                                    <asp:ListItem Value="0"><-Select State-></asp:ListItem>
                                </asp:DropDownList>
                                
                        </div>
                        <div class="form-group col-md-6">
                            <label for="exampleFormControlSelect1" class="fontRegular semiBold clrBlack">Select District: *</label>
                            <asp:DropDownList ID="ddrDistrict" CssClass="cmbBox"  runat="server">
                                    <asp:ListItem Value="0"><-Select District-></asp:ListItem>
                                </asp:DropDownList>
                         
                        </div>
                        </div>

                         <div class="form-row">
                            
                            <div class="form-group col-md-6">
                                <label for="inputtaluka" class="fontRegular semiBold clrBlack">Taluka: *</label>
                                <asp:TextBox ID="txttaluka"  class="form-control" Maxlength="30" placeholder="Taluka"  runat="server" ></asp:TextBox>
                            </div>
                             <div class="form-group col-md-6">
                                <label for="inputCity" class="fontRegular semiBold clrBlack">City Name: *</label>
                                <asp:TextBox ID="txtCity"  class="form-control"  runat="server" placeholder="City" MaxLength="30"></asp:TextBox>
                            </div>
                        </div>

                        <span class="space20"></span>                        
                        <span class="semiBold semiMedium  themeClrQtr">Other Details:</span>
                        <span class="space20"></span>

                        <div class="form-row">
                            <div class="form-group col-md-6">
                                <label for="inputOwner" class="fontRegular semiBold clrBlack">Owner Name/ Competent Authority: *</label>
                                <asp:TextBox ID="txtOwner" class="form-control" placeholder="Owner Name" runat="server" MaxLength="50"></asp:TextBox>
                            </div>
                                 <div class="form-group col-md-6">
                                <label for="inputgender" class="fontRegular semiBold clrBlack">Gender: *</label>
                                <br />
                                <asp:RadioButton ID="Radiomale" value="1" GroupName="gender" style="margin-left: 10px" runat="server" />
                                <label for="male">Male</label>
                                <asp:RadioButton ID="Radiofemale" value="2" GroupName="gender" style="margin-left: 10px" runat="server" />
                                <label for="Female">Female</label>
                                <asp:RadioButton ID="Radiotransgender" value="3" GroupName="gender" style="margin-left: 10px" runat="server" />
                                <label for="Transgender">Transgender</label>
                            </div>
                                
                        </div>

                        <div class="form-row">
                            <div class="form-group col-md-6">
                                <label for="inputbdayr" class="fontRegular semiBold clrBlack">Birth Date: *</label>
                                <asp:TextBox ID="txtbday" class="form-control" placeholder="Birth Date" runat="server" ></asp:TextBox>
                            </div>
                            <div class="form-group col-md-6">
                            <label for="exampleFormControlSelect1" class="fontRegular semiBold clrBlack">Role: *</label>
                          <asp:TextBox ID="txtrole" class="form-control" placeholder="Role" MaxLength="30" runat="server" ></asp:TextBox>
                            </div>

                        </div>
                     

                         <span class="space20"></span>                        
                        <span class="semiBold semiMedium  themeClrQtr">Contact Details:</span>
                        <span class="space20"></span>

                        <div class="form-row">
                            <div class="form-group col-md-6">
                                <label for="inputemailid" class="fontRegular semiBold clrBlack">Email Id:*</label>
                                <asp:TextBox ID="txtEmail"  class="form-control"  Maxlength="50" placeholder="Email" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group col-md-6">
                                <label for="inputmobno" class="fontRegular semiBold clrBlack">Mobile No.:*</label>
                                <asp:TextBox ID="txtMobNo"  class="form-control" Maxlength="10" placeholder="Mobile Number" runat="server"></asp:TextBox>
                            </div>
                        </div>
                      
                      
                        <%--<asp:Button ID="btnSubmit" CssClass="btn themeBgThr clrWhite" runat="server" Text="Submit" OnClick="btnSubmit_Click" />--%>
                        <%--<asp:Button ID="btnCancel" CssClass="btn btn-secondary" runat="server" Text="Cancel" />--%>
                    </form>
                </div>
                    </ContentTemplate>
            </asp:UpdatePanel> 
            </div>
        </div>
         
        <span class="space30"></span>
        <p class="semiBold medium mrg_B_10 mt-4 clrBlack"><span class="tiny"><i class="fa fa-circle " aria-hidden="true"></i></span> We, ATC (PROPOSED AUTHORIZED TRAINING CENTER) understand and agree that</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">1. The location of the proposed Centre shall be fixed only in the specific Area as selected by us and the selected location shall not be changed by us anytime during, and subsequent to the Network Partner Registration Process </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">2. VTTC New Delhi reserves the right</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">a. To modify the terms and conditions of the ATC Registration Process without any prior notice and VTCC New Delhi shall not be liable to anyone for any such modification/s</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">b. Of granting and/or rejecting authorization to any applicant/s, without assigning any reason/s whatsoever to anyone and fully responsible for all activities that occur thereunder</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">3. In case we are granted authorization</p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">a. We are responsible for maintaining the confidentiality of the password and login account given by VTCC New Delhi </p>
         <p class="clrDarkGrey regular fontRegular mrg_B_20">b. We shall abide by the various guidelines, communications, norms issued and specified by VTCC from time to time</p>
         <span class="space10"></span>
         <asp:CheckBox ID="Chkagree" runat="server" /> <a href="#">Accept terms and conditions for continue the from</a>
         <span class="space20"></span>
        <div style="display: flex; justify-content: center; align-items: center;">
        <asp:Button ID="btnSubmit" CssClass="btn themeBgThr clrWhite" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
        </div>
    </div>
    <!-- registration form Ends -->
    <span class="space30"></span>
</asp:Content>

