<%@ Page Title="Student Placement| VTCC" Language="C#" MasterPageFile="~/adminpanel/MasterAdmin.master" AutoEventWireup="true" CodeFile="studentplacement-master.aspx.cs" Inherits="adminpanel_studentplacement" %>
<%@ MasterType VirtualPath="~/adminpanel/MasterAdmin.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script>
		$(document).ready(function () {
            $('[id$=gvstudplacement]').DataTable({
				columnDefs: [
					{ orderable: false, targets: [0, 1, 2, 3, 4 ,5] }
				],
				order: [[0, 'desc']]
			});
		});
    </script>

	<script type="text/javascript">
        window.onload = function () {
            //alert("window load");

            duDatepicker('#<%= txtDate.ClientID %>', {
                auto: true, inline: true, format: 'dd/mm/yyyy',
            });
        }
    </script>
    <style type="text/css">
        .btn-secondary {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	 <h2 class="pgTitle">StudentPlacement Master</h2>
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
						<label>Date:*</label>
						<asp:TextBox ID="txtDate" runat="server" CssClass="form-control" Width="100%"></asp:TextBox>
					</div>

					<div class="form-group col-md-6">
						<label>Student Name:*</label>
						<asp:TextBox ID="txtstudplcname" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="30" ></asp:TextBox>
					</div>

					<div class="form-group col-md-6">
						<label>Course Name:*</label>
						<asp:TextBox ID="txtcoursename" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="50" ></asp:TextBox>
					</div>

					<div class="form-group col-md-6">
						<label>Placed Company:*</label>
						<asp:TextBox ID="txtcompanyname" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="50" ></asp:TextBox>
					</div>

					<div class="form-group col-md-6">
						<label>Job Post:*</label>
						<asp:TextBox ID="txtjobpost" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="30" ></asp:TextBox>
					</div>

					<div class="form-group col-md-6">
						<label>Placed Country:*</label>
						<asp:TextBox ID="txtplccountry" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="30" ></asp:TextBox>
					</div>

					 <div class="form-group col-md-6">
                        <label>Student Photo: </label>
                        <asp:FileUpload ID="fileuploadphoto" runat="server" CssClass="form-control-file" MaxLength="30" />
						 <span class="space10"></span>
                         <%= placstudPhoto %> <span class="space5"></span>
						 <asp:Button ID="btnRemove" runat="server" CssClass="btn btn-secondary" Text="Remove Photo"  OnClientClick="return confirm('Are you sure to remove photo?');" OnClick="btnRemove_Click"/>
                    </div>
					 </div>
            </div>
        </div>
		 	<!-- Button controls starts -->
		<span class="space10"></span>
		<span class="space10"></span>
		<asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" Text="Save" OnClick="btnSave_Click"  />
		<asp:Button ID="btnDelete" runat="server" CssClass="btn btn-outline-info" Text="Delete" OnClientClick="return confirm('Are you sure to delete?');" OnClick="btnDelete_Click"/>
		<asp:Button ID="btnCancel" runat="server" CssClass="btn btn-outline-dark" Text="Cancel" OnClick="btnCancel_Click" />
		<div class="float_clear"></div>
		<!-- Button controls ends -->	
	</div>

	<div id="viewinfo" runat="server">
		<a href="studentplacement-master.aspx?action=new" runat="server" class="btn btn-primary btn-md">Add New</a>
		<%--<a href="contactdata.aspx?action=new" runat="server" class="btn btn-primary btn-md">Add New</a>--%>
		<span class="space20"></span>
		<div class="formPanel table-responsive-md">
			<asp:GridView ID="gvstudplacement" runat="server" CssClass="table table-striped table-bordered table-hover" GridLines="None"
				AutoGenerateColumns="false" OnRowDataBound="gvstudplacement_RowDataBound">
				<HeaderStyle CssClass="thead-dark" />
				<RowStyle CssClass="" />
				<AlternatingRowStyle CssClass="alt" />

				<Columns>
					 <asp:BoundField DataField="StudPlcId">
						<HeaderStyle CssClass="HideCol" />
						<ItemStyle  CssClass="HideCol"/>
					</asp:BoundField>

					 <asp:BoundField DataField="StudPlcDate" HeaderText="Placement Date">
						<ItemStyle Width="20%" />
					</asp:BoundField>

					 <asp:BoundField DataField="StudPlcStudentName" HeaderText="Student Name">
						<ItemStyle Width="20%" />
					</asp:BoundField>

					 <asp:BoundField DataField="StudPlcCompanyName" HeaderText="Placed Company ">
						<ItemStyle Width="20%" />
					</asp:BoundField>

					 <asp:BoundField DataField="StudPlcJobPost" HeaderText="Job Post">
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

