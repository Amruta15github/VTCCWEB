<%@ Page Title="Student Admission | VTCC" Language="C#" MasterPageFile="~/centers/MasterAdmin.master" AutoEventWireup="true" CodeFile="student-form.aspx.cs" Inherits="centers_student_form" %>
<%@ MasterType VirtualPath="~/centers/MasterAdmin.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script type="text/javascript"
        src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCvO0AHfg1cuND1KXbw3t5xZr5p4PVrEk4">
    </script>

       <script>
		$(document).ready(function () {
            $('[id$=gvstudform]').DataTable({
				columnDefs: [
					{ orderable: false, targets: [0, 1, 2, 3, 4 ,5, 6, 7, 8] }
				],
				order: [[0, 'desc']]
			});
		});
       </script>

		<%--<script type="text/javascript">
            window.onload = function () {
                //alert("window load");

                duDatepicker('#<%= txtDate.ClientID %>', {
                    auto: true, inline: true, format: 'dd/mm/yyyy',
                });
            }
        </script>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <h2 class="pgTitle">Student Admission Form</h2>
	<span class="space10"></span>
	  <asp:UpdatePanel ID="UpdatePanel1" runat="server">
         <ContentTemplate>
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
						<label>Student Register No:</label>
						<asp:TextBox ID="txtregno" runat="server" CssClass="form-control" Width="100%" MaxLength="30"></asp:TextBox>
					</div>
					
					<div class="form-group col-md-6">
						<label>First Name:*</label>
						<asp:TextBox ID="txtfirstname" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="20" ></asp:TextBox>
					</div>
					<div class="form-group col-md-6">
						<label>Middle Name:*</label>
						<asp:TextBox ID="txtmiddlename" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="20" ></asp:TextBox>
					</div>
					<div class="form-group col-md-6">
						<label>Last Name:*</label>
						<asp:TextBox ID="txtlastname" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="20" ></asp:TextBox>
					</div>

					<div class="form-group col-md-6">
						<label>Mobile No:*</label>
						<asp:TextBox ID="txtmobile" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="15" ></asp:TextBox>
					</div>
					<div class="form-group col-md-6">
						<label>Email:*</label>
						<asp:TextBox ID="txtemail" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="50" ></asp:TextBox>
					</div>
					<div class="form-group col-md-6">
						<label>WhatsApp:</label>
						<asp:TextBox ID="txtwhatsapp" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="15" ></asp:TextBox>
						</div>

						<div class="form-group col-md-6">
						<label>Education:</label>
						<asp:TextBox ID="txteduc" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="50" ></asp:TextBox>
					</div>
					

					<div class="form-group col-md-6">
                    <label>State:* </label>
                    <asp:DropDownList ID="ddlstate" CssClass="form-control" runat="server" AutoPostBack="true"  OnSelectedIndexChanged="ddlstate_SelectedIndexChanged1">
                        <asp:ListItem Value="0"><- Select State -></asp:ListItem>                                    
                    </asp:DropDownList>
                    </div>

					<div class="form-group col-md-6">
                    <label>District:* </label>
                    <asp:DropDownList ID="ddldist" CssClass="form-control" runat="server" >
                        <asp:ListItem Value="0"><- Select District -></asp:ListItem>                                           
                    </asp:DropDownList>
                    </div>

					
					<div class="form-group col-md-6">
						<label>City:</label>
						<asp:TextBox ID="txtcity" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="30" ></asp:TextBox>
					</div>
					<div class="form-group col-md-6">
						<label>Address:</label>
						<asp:TextBox ID="txtaddress" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="200" ></asp:TextBox>
					</div>
					<div class="form-group col-md-6">
						<label>Birth Date:</label>
						<asp:TextBox ID="txtbirthdate" runat="server" CssClass="form-control"  placeholder="dd/MM/yyy" Width="100%"
							MaxLength="20" ></asp:TextBox>
					</div>
					<div class="form-group col-md-6">
						<label>Course Name:*</label>
						<asp:TextBox ID="txtcoursename" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="50" ></asp:TextBox>
					</div>

					<div class="form-group col-md-6">
						<label>Student Photo:</label>
						<asp:FileUpload ID="fustudImage" runat="server" CssClass="form-control-file" />
						<span class="space10"></span>
						<%= studphoto %>
						<span class="space5"></span>
						<%--<asp:Button ID="btnRemove" runat="server" CssClass="btn btn-secondary" Text="Remove Photo"  OnClientClick="return confirm('Are you sure to remove photo?');" />--%>
					</div>
					<div class="form-group col-md-6">
						<label>Sign Photo:</label>
						<asp:FileUpload ID="fusignImage" runat="server" CssClass="form-control-file" />
						<span class="space10"></span>
						<%= studsign %>
						<span class="space5"></span>
						<%--<asp:Button ID="Button1" runat="server" CssClass="btn btn-secondary" Text="Remove Photo"  OnClientClick="return confirm('Are you sure to remove photo?');"  />--%>
					</div>
					</div>
            </div>
        </div>
		 <!-- Button controls starts -->
		<span class="space10"></span>
		<span class="space10"></span>
		<asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" Text="Save" OnClick="btnSave_Click"  />
		<asp:Button ID="btnDelete" runat="server" CssClass="btn btn-outline-info" Text="Delete" OnClientClick="return confirm('Are you sure to delete?');" OnClick="btnDelete_Click" />
		<asp:Button ID="btnCancel" runat="server" CssClass="btn btn-outline-dark" Text="Cancel" OnClick="btnCancel_Click" />
		<div class="float_clear"></div>
		<!-- Button controls ends -->	
	</div>
	</ContentTemplate>
    </asp:UpdatePanel>
	<div id="viewinfo" runat="server">
		<a href="student-form.aspx?action=new" runat="server" class="btn btn-primary btn-md">Add New</a>
		
		<span class="space20"></span>
		<div class="formPanel table-responsive-md">
			<asp:GridView ID="gvstudform" runat="server" CssClass="table table-striped table-bordered table-hover" GridLines="None" 
				AutoGenerateColumns="false" OnRowDataBound="gvstudform_RowDataBound">
				<HeaderStyle CssClass="thead-dark" />
				<RowStyle CssClass="" />
				<AlternatingRowStyle CssClass="alt" />
				<Columns>
					 <asp:BoundField DataField="StudID">
						<HeaderStyle CssClass="HideCol" />
						<ItemStyle  CssClass="HideCol"/>
					</asp:BoundField>

					 <asp:BoundField DataField="StudRegNo" HeaderText="Registration No">
						<ItemStyle Width="10%" />
					</asp:BoundField>

					 <asp:BoundField DataField="StudFirstName" HeaderText="First Name">
						<ItemStyle Width="10%" />
					</asp:BoundField>

					 <asp:BoundField DataField="StudLastName" HeaderText="Last Name ">
						<ItemStyle Width="10%" />
					</asp:BoundField>

					 <asp:BoundField DataField="StudEmailId" HeaderText="EmailId">
						<ItemStyle Width="10%" />
					</asp:BoundField>

					 <asp:BoundField DataField="StudCity" HeaderText="City ">
						<ItemStyle Width="10%" />
					</asp:BoundField>

					 <asp:BoundField DataField="StudCourseName" HeaderText="Course Name ">
						<ItemStyle Width="10%" />
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

