<%@ Page Title="" Language="C#" MasterPageFile="~/centers/MasterAdmin.master" AutoEventWireup="true" CodeFile="searchstudent.aspx.cs" Inherits="centers_searchstudent" %>
<%@ MasterType VirtualPath="~/centers/MasterAdmin.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <style>
        .splitscreen {display: flex;}
            .splitscreen .left,
            .splitscreen .right {flex: 1;}

        table {font-family: arial, sans-serif; border-collapse: collapse; width: 100%;}
        td, th {border: 1px solid #dddddd; text-align: left; padding: 8px; color: #000000}
        tr:nth-child(even) {background-color: #dddddd;}
        th {font-weight: 600; color: #000000;}
    </style>

    <style>
table {
  font-family: arial, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

td, th {
  border: 1px solid #dddddd;
  text-align: left;
  padding: 8px;
}

tr:nth-child(even) {
  background-color:rgba(250, 243, 246, 0.8);
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="container">
	 <h2>Search Students</h2>
	<span class="space10"></span>

	<div class="card card-primary">
			<div class="card-header">
				<h3>Search Students</h3>
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
							MaxLength="15" ></asp:TextBox>
					</div>
					<div class="form-group col-md-6">
						<label>Email:*</label>
						<asp:TextBox ID="txtemail" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="50" ></asp:TextBox>
					</div>
					</div>
				</div>
		</div>
	
		<span class="space10"></span>
	 <asp:Button ID="btnSearch" CssClass="btn btn-primary" runat="server" Text="Search" OnClick="btnSearch_Click"/>

	 <span class="space30"></span>

        <div id="viewtable" runat="server">
		<div class="formPanel table-responsive-md">

			<asp:GridView ID="gvsearch" runat="server" GridLines="None"
                AutoGenerateColumns="false">
				
				<Columns>
                 <asp:BoundField DataField="StudID">
						<HeaderStyle CssClass="HideCol" />
						<ItemStyle  CssClass="HideCol"/>
					</asp:BoundField>
     
                 <asp:BoundField DataField="StudRegNo" HeaderText="Register No">
						<ItemStyle Width="20%" />
					</asp:BoundField>

					    <asp:BoundField DataField="StudFullName" HeaderText=" Student Name">
						<ItemStyle Width="20%" />
					</asp:BoundField>

					  <asp:BoundField DataField="StudCity" HeaderText="City">
						<ItemStyle Width="20%" />
					</asp:BoundField>

                 <asp:BoundField DataField="StudCourseName" HeaderText="Course Name">
						<ItemStyle Width="20%" />
					</asp:BoundField>

					 
                </Columns>

                <EmptyDataTemplate>
					<span class="warning">Its Empty Here... :(</span>
				</EmptyDataTemplate>
				
			</asp:GridView>
			</div>
       
        </div>
      </div>
</asp:Content>

