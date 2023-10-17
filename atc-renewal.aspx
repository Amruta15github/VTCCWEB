<%@ Page Title="" Language="C#" MasterPageFile="~/MasterParent.master" AutoEventWireup="true" CodeFile="atc-renewal.aspx.cs" Inherits="atc_renewal" %>
<%@ MasterType VirtualPath="~/MasterParent.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script type="text/javascript"
        src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCvO0AHfg1cuND1KXbw3t5xZr5p4PVrEk4">
    </script>
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
           <div class="row ">
             <%--<%=jobstr %>--%>
          
                    <span class="space10"></span>
                     <div class="form-group col-sm-12">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
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
                    <asp:Button ID="btnSubmit" runat="server" CssClass="btn themeBgThr clrWhite" Text="Submit"  />
                    <%--<button type="submit" class="btn btn-primary">Submit</button>--%>

                </div>
            </div>          
      </div>
         </div>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
                     </div>
           </div>
     </div>
</asp:Content>

