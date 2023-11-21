<%@ Page Title="Tieups | VTCC" Language="C#" MasterPageFile="~/adminpanel/MasterAdmin.master" AutoEventWireup="true" CodeFile="tieups-master.aspx.cs" Inherits="adminpanel_tieups_master" %>
<%@ MasterType VirtualPath="~/adminpanel/MasterAdmin.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script>
		$(document).ready(function () {
            $('[id$=gvtieups]').DataTable({
                columnDefs: [
                    { orderable: false, targets: [0, 1, 2]}
				],
				order: [[0, 'desc']]
			});
		});
     </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <h2 class="pgTitle">Tie-Ups Master</h2>
    <span class="space10"></span>
	<div id="editinfo" runat="server">
        <div class="card card-primary">
            <div class="card-header">
                <h3 class="card-title"><%=pgTitle %></h3>
            </div>
           
            <div class="card-body">
                <div class="colorLightBlue">
                  
                    <asp:Label ID="lblId" runat="server" Text="[New]"></asp:Label>
                </div>
                <span class="space15"></span>
              
                <div class="form-row">
                     <div class="form-group col-md-6">
                 <label for="inputtitle" class="fontRegular semiBold clrBlack">Tieup Title  :* </label>
                 <asp:TextBox ID="txttieuptitle"  class="form-control"  runat="server" MaxLength="30"></asp:TextBox>
             </div>

              <div class="form-group col-md-6">
                 <label for="inputintro" class="fontRegular semiBold clrBlack">Introduction :* </label>
                 <asp:TextBox ID="txtintro" class="form-control"  runat="server"  MaxLength="200"></asp:TextBox>
             </div> 

             <div class="form-group col-md-6">
                  <label for="inputintro" class="fontRegular semiBold clrBlack">Logos Upload:* </label>
                 <asp:FileUpload ID="fulogo" runat="server" CssClass="form-control-file" />
                 <span class="space10"></span>
                 	<%= tieuplogo %><span class="space5"></span>
               
             </div>

                 <div class="form-group col-md-6">
                 <label for="inputintro" class="fontRegular semiBold clrBlack"> Certificate Upload: </label>
                 <asp:FileUpload ID="fucertificate" runat="server" CssClass="form-control-file" />
                 <span class="space10"></span>
                  <%= tieupcerti %>
                <%--  <a href="#">view certificate</a>--%>
                  <span class="space5"></span>
                 <asp:Button ID="btnRemove" runat="server" CssClass="btn btn-secondary" Text="Remove Photo"  OnClientClick="return confirm('Are you sure to remove photo?');" OnClick="btnRemove_Click" />
             </div>

                    </div>
                </div>
            </div>
          <!-- Button controls starts -->
        <span class="space10"></span>
        <span class="space10"></span>
        <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" Text="Save" OnClick="btnSave_Click" />
        <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-outline-info" Text="Delete" OnClientClick="return confirm('Are you sure to delete?');" OnClick="btnDelete_Click"/>
        <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-outline-dark" Text="Cancel" OnClick="btnCancel_Click"  />
        <div class="float_clear"></div>
        <!-- Button controls ends -->
        </div>

     <div id="viewinfo" runat="server">
        <a href="tieups-master.aspx?action=new" runat="server" class="btn btn-primary btn-md">Add New</a>
	
        <span class="space20"></span>
        <div class="formPanel table-responsive-md">
            <asp:GridView ID="gvtieups" runat="server" CssClass="table table-striped table-bordered table-hover" GridLines="None" 
				AutoGenerateColumns="false" OnRowDataBound="gvtieups_RowDataBound" >
				 <HeaderStyle CssClass="thead-dark" />
				<RowStyle CssClass="" />
				<AlternatingRowStyle CssClass="alt" />
				<Columns>
					 <asp:BoundField DataField="TieUpID">
						<HeaderStyle CssClass="HideCol" />
						<ItemStyle  CssClass="HideCol"/>
					</asp:BoundField>
					
                     <asp:BoundField DataField="TieUpTitle" HeaderText="TieUP Title">
						<ItemStyle Width="20%" />
					</asp:BoundField>


                    <asp:TemplateField>
						<ItemStyle Width="10%" />
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

