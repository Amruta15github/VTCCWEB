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
              
                <div class="form-group col-md-6">
						<label>Center Title:*</label>
						<asp:TextBox ID="txttitle" runat="server" CssClass="form-control" Width="100%"></asp:TextBox>
					</div>

                <div class="form-group col-md-6">
						<label>Center Image:</label>
						<asp:FileUpload ID="fuImage" runat="server" CssClass="form-control-file" />
						<span class="space10"></span>
						<%--<%= nwsPhoto %>--%>
                         <span class="space5"></span>
					
					</div>
                    
                <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" Text="Save"  />

                    
                </div>
              
            </div>
   </div>
        
      
</asp:Content>

