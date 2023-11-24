<%@ Page Title="CommitteeMembers | VTCC" Language="C#" MasterPageFile="~/MasterParent.master" AutoEventWireup="true" CodeFile="committeemembers.aspx.cs" Inherits="committeemembers" %>
<%@ MasterType VirtualPath="~/MasterParent.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- Page Header Starts -->
    <div class="pgHeader1">
        <div class="headerOverlay">           
            <div class="bottomLight"></div>
            <div class="container">
                <div class="pg_TB_pad">
                    <h1 class="pageH1 clrWhite fontMedium">Committee Members</h1>
                    <ul class="bCrumb">
                        <li><a href="<%= Master.rootPath %>">Home</a></li>
                        <li>&raquo;</li>
                        <li>Committee-Members</li>
                    </ul>
                    <div class="float_clear"></div>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Header Ends -->

     <!-- committee members starts -->
     <span class="space50"></span>
     <section id="committeemembers"></section>
     <div class="container ">
      <h2 class="pageH2 large themeClrThr text-center">Committee Members</h2>
        <br />
         <span class="space30"></span>
         <div class="row">
          <div class="col-md-8">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <form>
                         <div class="form-row">
                      <%--  <div class="form-group col-md-6">
                            <label for="inputdate" class="fontRegular semiBold clrBlack">Date: </label>
                            <asp:TextBox ID="txtDate" class="form-control" placeholder="Date" runat="server"></asp:TextBox>
                        </div>--%>

                        <div class="form-group col-md-6">
                            <label for="inputname" class="fontRegular semiBold clrBlack">Full Name: *</label>
                            <asp:TextBox ID="txtName" class="form-control" MaxLength="30" placeholder="Name" runat="server"></asp:TextBox>
                        </div>

                        <div class="form-group col-md-6">
                            <label for="inputEmail" class="fontRegular semiBold clrBlack">Email: *</label>
                            <asp:TextBox ID="txtemail" class="form-control" placeholder="Email" MaxLength="50" runat="server"></asp:TextBox>
                        </div>

                            <div class="form-group col-md-6">
                                <label for="inputmobile" class="fontRegular semiBold clrBlack">Mobile no: *</label>
                                <asp:TextBox ID="txtmobileno" MaxLength="10" class="form-control" placeholder="Mobile No" runat="server"></asp:TextBox>
                            </div>

                            <div class="form-group col-md-6">
                                <label for="typeoforg" class="fontRegular semiBold clrBlack">State: *</label>
                                <asp:DropDownList ID="ddlstate" CssClass="cmbBox" runat="server"  AutoPostBack="true" OnSelectedIndexChanged="ddlstate_SelectedIndexChanged">
                                    <asp:ListItem Value="0"><- Select State -></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                       
                              <div class="form-group col-md-6">
                                <label for="typeoforg" class="fontRegular semiBold clrBlack">District: *</label>
                                <asp:DropDownList ID="ddldistrict" CssClass="cmbBox" runat="server"  AutoPostBack="true" >
                                    <asp:ListItem Value="0"><- Select District -></asp:ListItem>
                                </asp:DropDownList>
                            </div>


                       <div class="form-group col-md-6">
                            <label for="inputcity" class="fontRegular semiBold clrBlack">City: *</label>
                            <asp:TextBox ID="txtcity" class="form-control" placeholder="City" MaxLength="30" runat="server"></asp:TextBox>
                        </div>
                             </div>
                        <asp:Button ID="btnSubmit" CssClass="btn themeBgThr clrWhite" class="secbtn" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    </form>
                </ContentTemplate>
            </asp:UpdatePanel>
            <%--  add/edit --%>
         </div>
         </div>
         </div>
</asp:Content>

