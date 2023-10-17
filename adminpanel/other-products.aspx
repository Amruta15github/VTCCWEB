<%@ Page Title="Other Products | VTCC" Language="C#" MasterPageFile="~/adminpanel/MasterAdmin.master" AutoEventWireup="true" CodeFile="other-products.aspx.cs" Inherits="adminpanel_other_products" %>
<%@ MasterType VirtualPath="~/adminpanel/MasterAdmin.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script>
		$(document).ready(function () {
            $('[id$=gvProjects]').DataTable({
                columnDefs: [
                    { orderable: false, targets: [0, 1, 2, 3, 4, 5] }
				],
				order: [[0, 'desc']]
			});
		});
     </script>
     <style type="text/css">
        /* .btn-primary {
             height: 26px;
         }*/
     </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <h2 class="pgTitle">Other Product Master</h2>
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
                <span class="space15"></span>
                <%-- From Row Start --%>
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label>Product Title:*</label>
                        <asp:TextBox ID="txtProdTitle" runat="server" CssClass="form-control" Width="100%" MaxLength="50"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label>Product link: </label>
                        <asp:TextBox ID="txtProdLink" runat="server" CssClass="form-control" Width="100%" 
                            MaxLength="100" ></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>
        <!-- Button controls starts -->
        <span class="space10"></span>
        <span class="space10"></span>
        <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" Text="Save" OnClick="btnSave_Click" />
        <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-outline-info" Text="Delete" OnClientClick="return confirm('Are you sure to delete?');" OnClick="btnDelete_Click" />
        <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-outline-dark" Text="Cancel" OnClick="btnCancel_Click" />
        <div class="float_clear"></div>
        <!-- Button controls ends -->
        <%--</ContentTemplate>
		</asp:UpdatePanel>--%>
    </div>
     <div id="viewinfo" runat="server">
         <a href="other-products.aspx?action=new" runat="server" class="btn btn-primary">Add New</a>
        <%--<a href="other-products.aspx?action=new" runat="server" class="btn btn-primary btn-md mb-5">Add New</a>--%>
		
        <span class="space20"></span>
        <div class="formPanel table-responsive-md">
            <asp:GridView ID="gvProducts" runat="server" CssClass="table table-striped table-bordered table-hover" GridLines="None" 
				AutoGenerateColumns="false" OnRowDataBound="gvProducts_RowDataBound"    >
				 <HeaderStyle CssClass="thead-dark" />
				<RowStyle CssClass="" />
				<AlternatingRowStyle CssClass="alt" />
				<Columns>
					 <asp:BoundField DataField="ProductId">
						<HeaderStyle CssClass="HideCol" />
						<ItemStyle  CssClass="HideCol"/>
					</asp:BoundField>
					
					 <asp:BoundField DataField="ProductTitle" HeaderText="Product Title">
						<ItemStyle Width="20%" />
					</asp:BoundField>

                    <asp:BoundField DataField="ProductLink" HeaderText="Product Link">
						<ItemStyle Width="20%" />
					</asp:BoundField>

					<asp:TemplateField>
						<ItemStyle Width="5%" />
						<ItemTemplate>
							<asp:Literal ID="litAnch" runat="server"></asp:Literal>
						</ItemTemplate>
					</asp:TemplateField>  
                  

				</Columns>
				<EmptyDataTemplate>
					<span class="warning">Its Empty Here... :(</span>
				</EmptyDataTemplate>
				<PagerStyle CssClass="" />
			</asp:GridView>
        </div>
    </div>
</asp:Content>

