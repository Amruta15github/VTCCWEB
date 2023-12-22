<%@ Page Title="Center Photos | VTCC" Language="C#" MasterPageFile="~/centers/MasterAdmin.master" AutoEventWireup="true" CodeFile="add-centerphotos.aspx.cs" Inherits="centers_add_centerphotos" %>
<%@ MasterType VirtualPath="~/centers/MasterAdmin.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script>
		$(document).ready(function () {
            $('[id$=gvphotos]').DataTable({
				columnDefs: [
					{ orderable: false, targets: [0, 1, 2 ] }
				],
				order: [[0, 'desc']]
			});
		});
     </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- docupload form start -->
 <%--   <span class="space20"></span>--%>
     <h2 class="pgTitle">Center Photos</h2>
	<span class="space10"></span>
	 <div id="editinfo" runat="server">
  
   <div class="card card-primary">
	   <div class="card-header">
				<h3 class="card-title"><%=pgTitle %></h3>
			</div>
        	<%-- Card Body --%>
			<div class="card-body">
                <div class="colorLightBlue">
					<%--<span>Id</span>--%>
					<asp:Label ID="lblId" runat="server" Text="[New]"></asp:Label>
				</div>
        <span class="space10"></span>
                <h1 class="pageH1 fontRegular">Center Photos</h1>
                <span class="space20"></span>
                <div class="form-row">
                <div class="form-group col-md-6">
						<label>Center Title:*</label>
						<asp:TextBox ID="txttitle" runat="server" CssClass="form-control" MaxLength="30"></asp:TextBox>
					</div>

                <div class="form-group col-md-6">
						<label>Center Image:*</label>
						<asp:FileUpload ID="fuImage" runat="server" CssClass="form-control-file" />
						<span class="space10"></span>
						<%= centerphoto %>
                         <span class="space5"></span>
					
					</div>
				 </div>
              
            </div>
		 </div>
              	<!-- Button controls starts -->      
          <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" Text="Save" OnClick="btnSave_Click"  />
		 <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-outline-info" Text="Delete" OnClientClick="return confirm('Are you sure to delete?');" OnClick="btnDelete_Click" />
		<asp:Button ID="btnCancel" runat="server" CssClass="btn btn-outline-dark" Text="Cancel" OnClick="btnCancel_Click"  />
		<div class="float_clear"></div>
		<!-- Button controls ends -->                             
   </div>
        <div id="viewinfo" runat="server">
		<a href="add-centerphotos.aspx?action=new" runat="server" class="btn btn-primary btn-md">Add New</a>
		
		<span class="space20"></span>
		<div class="formPanel table-responsive-md">
			<asp:GridView ID="gvphotos" runat="server" CssClass="table table-striped table-bordered table-hover" GridLines="None" 
				AutoGenerateColumns="false" OnRowDataBound="gvphotos_RowDataBound">
				 <HeaderStyle CssClass="thead-dark" />
				<RowStyle CssClass="" />
				<AlternatingRowStyle CssClass="alt" />
				<Columns>
					 <asp:BoundField DataField="CentPhotoId">
						<HeaderStyle CssClass="HideCol" />
						<ItemStyle  CssClass="HideCol"/>
					</asp:BoundField>
					
					 <asp:BoundField DataField="CentPhotoTitle" HeaderText="Photo Title">
						<ItemStyle Width="20%" />
					</asp:BoundField>

					<asp:TemplateField>
						<ItemStyle Width="10%" />
						<ItemTemplate>
							<asp:Literal ID="litAnch" runat="server"></asp:Literal>
						</ItemTemplate>
					</asp:TemplateField> 

					 <%-- <asp:TemplateField>
						<ItemStyle Width="10%" />
						<ItemTemplate>
							<asp:Literal ID="litAnchphto" runat="server"></asp:Literal>
						</ItemTemplate>
					</asp:TemplateField> --%>
					</Columns>
				<EmptyDataTemplate>
					<span class="warning">Its Empty Here... :(</span>
				</EmptyDataTemplate>
				<PagerStyle CssClass="" />
			</asp:GridView>
			</div>
	</div>    
</asp:Content>

