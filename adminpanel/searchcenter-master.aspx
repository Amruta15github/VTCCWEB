<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/MasterAdmin.master" AutoEventWireup="true" CodeFile="searchcenter-master.aspx.cs" Inherits="adminpanel_searchcenter_master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	 <h2 >Search Center Master</h2>
	<span class="space10"></span>
	<div class="card card-primary">
			<div class="card-header">
				<h3>Search Center</h3>
				</div>
			<%-- Card Body --%>
			<div class="card-body">
				<div class="colorLightBlue">
					
					<asp:Label ID="lblId" runat="server" Text="[New]"></asp:Label>
				</div>
				<span class="space15"></span>
					<%-- From Row Start --%>
				<div class="form-row">
					<div class="form-group col-md-6">
						<label>Mobile Number:*</label>
						<asp:TextBox ID="txtmobnumber" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="10" ></asp:TextBox>
					</div>
					<div class="form-group col-md-6">
						<label>Email:*</label>
						<asp:TextBox ID="txtemail" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="50" ></asp:TextBox>
					</div>
					</div>
				</div>
		</div>
	 <!-- Button controls starts -->
		<span class="space10"></span>
	 <asp:Button ID="btnSearch" CssClass="btn btn-primary" runat="server" Text="Search"  />
</asp:Content>

