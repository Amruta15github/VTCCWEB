<%@ Page Title="" Language="C#" MasterPageFile="~/MasterParent.master" AutoEventWireup="true" CodeFile="download-proposal.aspx.cs" Inherits="download_proposal" %>
<%@ MasterType VirtualPath="~/MasterParent.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <%-- <script type="text/javascript">
        var onloadCallback = function () {
            grecaptcha.render('recaptcha', {
                'sitekey': '6LcNBIUUAAAAADbX-_n6UhdJhtAxQDgiypcyZqSN'
            });
        };
      </script>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- Page Header Starts -->
    <div class="pgHeader1">
        <div class="headerOverlay">           
            <div class="bottomLight"></div>
            <div class="container">
                <div class="pg_TB_pad">
                    <h1 class="pageH1 clrWhite fontMedium">Download Proposal</h1>
                    <ul class="bCrumb">
                        <li><a href="<%= Master.rootPath %>">Home</a></li>
                        <li>&raquo;</li>
                        <li>Download-Proposal</li>
                    </ul>
                    <div class="float_clear"></div>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Header Ends -->

     <!-- download proposal starts -->
     <span class="space50"></span>
    <section id="jobopenings "></section>
     <div class="container ">
      <h2 class="pageH2 large themeClrThr text-center">Download Proposal</h2>
        <br />
        <span class="fontRegular line-ht-5 semiBold clrBlack">Please enter Centre / Institute details for download your proposal</span>
        <span class="space30"></span>
          <div class="col-md-8">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server"><%--OnLoad="UpdatePanel1_Load"--%>
                <ContentTemplate>
                    <form>
                        <div class="form-group">
                            <label for="inputEmail4" class="fontRegular semiBold clrBlack">Training Center Name: *</label>
                            <asp:TextBox ID="txtcenterNm" class="form-control" placeholder="Center Name" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="inputEmail4" class="fontRegular semiBold clrBlack">Full Address: *</label>
                            <asp:TextBox ID="txtAdd" class="form-control" placeholder="Address" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="inputEmail4" class="fontRegular semiBold clrBlack">Contact Person: *</label>
                            <asp:TextBox ID="txtName" class="form-control" placeholder="Person Name" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-row">
                            <div class="form-group col-md-6">
                                <label for="inputPassword4" class="fontRegular semiBold clrBlack">Area Pin Code: *</label>
                                <asp:TextBox ID="txtpincode" MaxLength="6" class="form-control" placeholder="Pin Code" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group col-md-6">
                                <label for="inputEmail4" class="fontRegular semiBold clrBlack">Mobile No: *</label>
                                <asp:TextBox ID="txtmobile" MaxLength="10" class="form-control" placeholder="Mobile Number" runat="server"></asp:TextBox>
                            </div>
                        </div>
                       <div class="form-group">
                            <label for="inputEmail4" class="fontRegular semiBold clrBlack">Email Id: *</label>
                            <asp:TextBox ID="txtemail" class="form-control" placeholder="Email" runat="server"></asp:TextBox>
                        </div>
                     

                        <asp:Button ID="btnSubmit" CssClass="btn themeBgThr clrWhite" class="secbtn" runat="server" Text="Submit" OnClick="btnSubmit_Click"  />
                    </form>
                </ContentTemplate>
            </asp:UpdatePanel>
            <%--  add/edit --%>
         </div>
         </div>
</asp:Content>

