<%@ Page Title="CertificateData | VTCC" Language="C#" MasterPageFile="~/adminpanel/MasterAdmin.master" AutoEventWireup="true" CodeFile="certificate-data-entry.aspx.cs" Inherits="adminpanel_certificate_data_entry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script>
		$(document).ready(function () {
            $('[id$=gvcertdata]').DataTable({
				columnDefs: [
					{ orderable: false, targets: [0, 1, 2, 3, 4 ,5] }
				],
				order: [[0, 'desc']]
			});
		});
     </script>
	<%--<script type="text/javascript">
        window.onload = function () {--%>
            //alert("window load");

            <%-- duDatepicker('#<%= txtDate.ClientID %>', {
                auto: true, inline: true, format: 'dd/mm/yyyy',
			});--%>
           <%--duDatepicker('#<%= txtexammon.ClientID %>', {
                auto: true, inline: true, format: 'dd/mm/yyyy',
			});
            duDatepicker('#<%= txtissuedate.ClientID %>', {
                auto: true, inline: true, format: 'dd/mm/yyyy',
			});
            duDatepicker('#<%= txtfromdate.ClientID %>', {
                auto: true, inline: true, format: 'dd/mm/yyyy',
			});
            duDatepicker('#<%= txttodate.ClientID %>', {
                auto: true, inline: true, format: 'dd/mm/yyyy',
			});
            duDatepicker('#<%= txtstudregdate.ClientID %>', {
                auto: true, inline: true, format: 'dd/mm/yyyy',
            });
        }--%>
   <%-- </script>--%>

	<script type="text/javascript">
            function setupcalendar() {
            <%-- $('#<% =txtBirthDate.ClientID%>').datepick({ onSelect: function (dates) { getAge() }, dateFormat: 'dd/mm/yyyy' });--%>
			 <%-- $('#<%=txtTrDate.ClientID %>').datepick({ dateFormat: 'dd/mm/yyyy' });--%>


             <%-- duDatepicker('#<%= txtexammon.ClientID %>', {
                  auto: true, inline: true, format: 'dd/mm/yyyy',
              });
              duDatepicker('#<%= txtissuedate.ClientID %>', {
                  auto: true, inline: true, format: 'dd/mm/yyyy',
              });
              duDatepicker('#<%= txtfromdate.ClientID %>', {
                  auto: true, inline: true, format: 'dd/mm/yyyy',
              });
              duDatepicker('#<%= txttodate.ClientID %>', {
                auto: true, inline: true, format: 'dd/mm/yyyy',
			});
              duDatepicker('#<%= txtstudregdate.ClientID %>', {
                  auto: true, inline: true, format: 'dd/mm/yyyy',
              });--%>

          }
      </script>


	 <script type="text/javascript">
         function pageLoad(sender, args) {
             if (args.get_isPartialLoad()) {
                 setupcalendar();
             }
         }
     </script>

    <script type="text/javascript">
            // Call setupAutocomplete on initial page load
            $(document).ready(function () {
                setupcalendar();
            });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <h2 class="pgTitle">Certificate Data Entry Master</h2>
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
					
					<asp:Label ID="lblId" runat="server" Text="[New]"></asp:Label>
				</div>
				<span class="space15"></span>
					<%-- From Row Start --%>
				<div class="form-row">
					
					<%--<div class="form-group col-md-6">
						<label>CertUploadDate:*</label>
						<asp:TextBox ID="txtDate" runat="server" CssClass="form-control" Width="100%"></asp:TextBox>
					</div> --%><%--datatime.now--%>
					
					<div class="form-group col-md-6">
						<label>Certificate Number:*</label>
						<asp:TextBox ID="txtcertnumber" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="30" ></asp:TextBox>
					</div>
					
					
					<div class="form-group col-md-6">
						<label>Course Name:*</label>
						<asp:TextBox ID="txtcoursename" runat="server" CssClass="form-control" Width="100%" 
							 ></asp:TextBox>					
				    </div>

						<div class="form-group col-md-6">
						<label>Duration:*</label>
						<asp:TextBox ID="txtduration" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="10" ></asp:TextBox>					
				    </div>

						<div class="form-group col-md-6">
						<label>Average Marks:*</label>
						<asp:TextBox ID="txtavgmarks" runat="server" CssClass="form-control" Width="100%" 
							 ></asp:TextBox>					
				    </div>

					<div class="form-group col-md-6">
						<label>Grade:*</label>
						<asp:TextBox ID="txtgrade" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="10" ></asp:TextBox>					
				    </div>

					<%--<div class="form-group col-md-6">
						<label>Exam Month:*</label>
						<asp:TextBox ID="txtexammon" runat="server" CssClass="form-control" Width="100%" 
							></asp:TextBox>					
				    </div>--%>

					<%--<div class="form-group col-md-6">
						<label>Issue Date:*</label>
						<asp:TextBox ID="txtissuedate" runat="server" CssClass="form-control" Width="100%" 
							></asp:TextBox>					
				    </div>--%>

						<div class="form-group col-md-6">
						<label>Student Name:*</label>
						<asp:TextBox ID="txtstudname" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="50" ></asp:TextBox>					
				    </div>

					<div class="form-group col-md-6">
						<label>Center Name:*</label>
						<asp:TextBox ID="txtcentername" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="150" ></asp:TextBox>					
				    </div>

					<%--<div class="form-group col-md-6">
						<label>From Date:*</label>
						<asp:TextBox ID="txtfromdate" runat="server" CssClass="form-control" Width="100%" 
							 ></asp:TextBox>					
				    </div>--%>
					<%--<div class="form-group col-md-6">
						<label>To Date:*</label>
						<asp:TextBox ID="txttodate" runat="server" CssClass="form-control" Width="100%" 
							 ></asp:TextBox>					
				    </div>--%>
					<%--<div class="form-group col-md-6">
						<label>Student Registration Date:*</label>
						<asp:TextBox ID="txtstudregdate" runat="server" CssClass="form-control" Width="100%" 
							 ></asp:TextBox>					
				    </div>--%>

					<div class="form-group col-md-6">
						<label>Place:</label>
						<asp:TextBox ID="txtcertplace" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="40" ></asp:TextBox>					
				    </div>


					<div class="form-group col-md-6">
						<label>Center Number:</label>
						<asp:TextBox ID="txtcenterno" runat="server" CssClass="form-control" Width="100%" 
				 			MaxLength="50" ></asp:TextBox>					
				    </div>
										
                </div>
            </div>
        </div>
		 <!-- Button controls starts -->
		<span class="space10"></span>
		<span class="space10"></span>
		
		<asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" Text="Save" OnClick="btnSave_Click" />
		<asp:Button ID="btnDelete" runat="server" CssClass="btn btn-outline-info" Text="Delete" OnClientClick="return confirm('Are you sure to delete?');" OnClick="btnDelete_Click"/>
		<asp:Button ID="btnCancel" runat="server" CssClass="btn btn-outline-dark" Text="Cancel" OnClick="btnCancel_Click" />
		<div class="float_clear"></div>
		<!-- Button controls ends -->	
		 </div>
			</ContentTemplate>
    </asp:UpdatePanel>
	<div id="viewinfo" runat="server">
		<a href="certificate-data-entry.aspx?action=new" runat="server" class="btn btn-primary btn-md">Add New</a>
		
		<span class="space20"></span>
		<div class="formPanel table-responsive-md">
			<asp:GridView ID="gvcertdata" runat="server" CssClass="table table-striped table-bordered table-hover" GridLines="None" 
				AutoGenerateColumns="false" OnRowDataBound="gvcertdata_RowDataBound">
				<HeaderStyle CssClass="thead-dark" />
				<RowStyle CssClass="" />
				<AlternatingRowStyle CssClass="alt" />
				<Columns>
					 <asp:BoundField DataField="CertID">
						<HeaderStyle CssClass="HideCol" />
						<ItemStyle  CssClass="HideCol"/>
					</asp:BoundField>

					 <asp:BoundField DataField="CertUploadDate" HeaderText="Certificate UploadDate">
						<ItemStyle Width="20%" />
					</asp:BoundField>

					 <asp:BoundField DataField="CertNumber" HeaderText="Certificate Number">
						<ItemStyle Width="20%" />
					</asp:BoundField>

					 <asp:BoundField DataField="CertStudentName" HeaderText="Student Name ">
						<ItemStyle Width="20%" />
					</asp:BoundField>

					 <asp:BoundField DataField="CertCenterName" HeaderText="Center Name">
						<ItemStyle Width="10%" />
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

