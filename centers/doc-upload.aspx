<%@ Page Title="document-upload | VTCC" Language="C#" MasterPageFile="~/centers/MasterAdmin.master" AutoEventWireup="true" CodeFile="doc-upload.aspx.cs" Inherits="centers_doc_upload" %>
<%@ MasterType VirtualPath="~/MasterParent.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <!-- docupload form start -->
 <%--   <span class="space20"></span>--%>
    <div class="container"> 
   <div class="card card-primary">
        	<%-- Card Body --%>
			<div class="card-body">
                <div class="colorLightBlue">
					<%--<span>Id</span>--%>
					<asp:Label ID="lblId" runat="server" Text="[New]"></asp:Label>
				</div>
        <span class="space10"></span>
                <h1 class="pageH1 fontRegular">Documents Upload</h1>
                <span class="space20"></span>
      <%--  <div class="row">--%>

                <div class="col-md-8">
                    <div class="form-group col-md-6">
                        <label>Center Logo:</label>
                        <div class="row">
                            <div class="col-md-8">
                                <asp:FileUpload ID="fulogo" runat="server" CssClass="form-control-file" />
                            </div>
                            <span class="space10"></span>
                            <%= centerlogo %>
                            <span class="space5"></span>
                             
                            <div class="col-md-4">
                                <asp:Button ID="btnsavelogo" runat="server" CssClass="btn btn-secondary" Text="Save" Width="70" OnClick="btnsavelogo_Click" />
                            </div>
                                                   
                        </div>
                    </div>

                    <span class="greyLine"></span>

                    <div class="form-group col-md-6">
                        <label>Owner Photo: </label>
                        <div class="row">
                            <div class="col-md-8">
                                <asp:FileUpload ID="fuownerphoto" runat="server" CssClass="form-control-file" />
                            </div>
                            <span class="space10"></span>
                            <%--<%= tieupcerti %>--%>
                            <span class="space5"></span>
                      
                            <div class="col-md-4">
                                <asp:Button ID="btnownerphoto" runat="server" CssClass="btn btn-secondary" Text="Save" Width="70" />
                            </div>
                        </div>
                    </div>

                    <span class="greyLine"></span>

                    <div class="form-group col-md-6">
                        <label>ID Proof: </label>
                        <div class="row">
                            <div class="col-md-8">
                                <asp:FileUpload ID="fuid" runat="server" CssClass="form-control-file" />
                            </div>
                            <span class="space10"></span>
                            <%--<%= tieupcerti %>--%>
                            <span class="space5"></span>
                           
                            <div class="col-md-4">
                                <asp:Button ID="btnidproof" runat="server" CssClass="btn btn-secondary" Text="Save" Width="70" />
                            </div>
                        </div>
                    </div>
                    <span class="greyLine"></span>

                    <div class="form-group col-md-6">
                        <label>Education Certificate: </label>
                        <div class="row">
                            <div class="col-md-8">
                                <asp:FileUpload ID="fueducerti" runat="server" CssClass="form-control-file" />
                            </div>
                            <span class="space10"></span>
                            <%--<%= tieupcerti %>--%>
                            <span class="space5"></span>
                           
                            <div class="col-md-4">
                                <asp:Button ID="btneducerti" runat="server" CssClass="btn btn-secondary" Text="Save" Width="70" />
                            </div>
                        </div>
                    </div>

                    <span class="greyLine"></span>

                    <div class="form-group col-md-6">
                        <label>Professional Courses: </label>
                        <div class="row">
                            <div class="col-md-8">
                                <asp:FileUpload ID="fuprofcourses" runat="server" CssClass="form-control-file" />
                            </div>
                            <span class="space10"></span>
                            <%--<%= tieupcerti %>--%>
                            <span class="space5"></span>
                           
                            <div class="col-md-4">
                                <asp:Button ID="btnprofcourses" runat="server" CssClass="btn btn-secondary" Text="Save" Width="70" />
                            </div>
                        </div>
                    </div>

                    <span class="greyLine"></span>
                </div>
                <%--  </div>--%>
            </div>
   </div>
         <%--<span class="space10"></span>
        <span class="space10"></span>
        <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" Text="Save" OnClick="btnSave_Click" />
        <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-outline-info" Text="Delete" OnClientClick="return confirm('Are you sure to delete?');" OnClick="btnDelete_Click"/>
        <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-outline-dark" Text="Cancel" OnClick="btnCancel_Click"/>
        <div class="float_clear"></div>
        <!-- Button controls ends -->--%>
        </div>
    
</asp:Content>

