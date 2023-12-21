<%@ Page Title="" Language="C#" MasterPageFile="~/centers/MasterAdmin.master" AutoEventWireup="true" CodeFile="add-centerphotos.aspx.cs" Inherits="centers_add_centerphotos" %>
<%@ MasterType VirtualPath="~/centers/MasterAdmin.master" %>
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
                <h1 class="pageH1 fontRegular">Center Photos</h1>
                <span class="space20"></span>
      <%--  <div class="row">--%>

                <div class="col-md-8">
                    <div class="form-group col-md-6">
                        <label>Photos of institute :</label>
                        <div class="row">
                            <div class="col-md-8">
                                <asp:FileUpload ID="fuphotos" runat="server" CssClass="form-control-file" />
                            </div>
                          
                             
                            <div class="col-md-4">
                                <asp:Button ID="btnsavephoto" runat="server" CssClass="btn btn-secondary" Text="Save" Width="70" />
                            </div>
                             <span class="space10"></span>
                         <%--   <%= centerlogo %>--%>
                            <span class="space5"></span>
                                                   
                  
                        </div>
                    </div>

                    <span class="greyLine"></span>

                    <div class="form-group col-md-6">
                        <label>Office Room photo : </label>
                        <div class="row">
                            <div class="col-md-8">
                                <asp:FileUpload ID="furoomphoto" runat="server" CssClass="form-control-file" />
                            </div>
                            
                          
                            <div class="col-md-4">
                                <asp:Button ID="btnroomphoto" runat="server" CssClass="btn btn-secondary" Text="Save" Width="70"/>
                            </div>
                            <span class="space10"></span>
                          <%--  <%= centerphoto %>--%>
                            <span class="space5"></span>
                        </div>
                    </div>

                    <span class="greyLine"></span>

                    <div class="form-group col-md-6">
                        <label>Lab Photo: </label>
                        <div class="row">
                            <div class="col-md-8">
                                <asp:FileUpload ID="fulabphoto" runat="server" CssClass="form-control-file" />
                            </div>
                           
                            
                            <div class="col-md-4">
                                <asp:Button ID="btnlabphoto" runat="server" CssClass="btn btn-secondary" Text="Save" Width="70"/>
                            </div>
                            <span class="space10"></span>
                          <%--  <%= centeridproof %>--%>
                            <span class="space5"></span>
                        </div>
                    </div>
                    <span class="greyLine"></span>

                    <div class="form-group col-md-6">
                        <label>ATC Upload PDF: </label>
                        <div class="row">
                            <div class="col-md-8">
                                <asp:FileUpload ID="fuploadpdf" runat="server" CssClass="form-control-file" />
                            </div>
                           
                            
                            <div class="col-md-4">
                                <asp:Button ID="btnuploadpdf" runat="server" CssClass="btn btn-secondary" Text="Save" Width="70" />
                            </div>
                             <span class="space10"></span>
                          <%--  <%= centereducerti %>--%>
                            <span class="space5"></span>
                        </div>
                    </div>

                    <span class="greyLine"></span>

                    <div class="form-group col-md-6">
                        <label>Center out door photo: </label>
                        <div class="row">
                            <div class="col-md-8">
                                <asp:FileUpload ID="fuoutdoorphoto" runat="server" CssClass="form-control-file" />
                            </div>
                          
                           
                            <div class="col-md-4">
                                <asp:Button ID="btnoutdoorphoto" runat="server" CssClass="btn btn-secondary" Text="Save" Width="70" />
                            </div>
                              <span class="space10"></span>
                           <%-- <%= centerprofcourse %>--%>
                            <span class="space5"></span>
                        </div>
                    </div>

                    
                </div>
              
            </div>
   </div>
        
        </div>
</asp:Content>

