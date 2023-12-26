<%@ Page Title="ApproveCenters | VTCC" Language="C#" MasterPageFile="~/adminpanel/MasterAdmin.master" AutoEventWireup="true" CodeFile="approve-atc.aspx.cs" Inherits="adminpanel_approve_atc" %>
<%@ MasterType VirtualPath="~/adminpanel/MasterAdmin.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
  <script>
         $(document).ready(function () {
             $('[id$=gvapprove]').DataTable({
                 columnDefs: [
                     { orderable: false, targets: [0, 1, 2, 3, 4, 5, 6, 7, 8] }
                 ],
                 order: [[0, 'desc']]
             });
         });

  </script>

	<%--<script type="text/javascript">
         function setupcalendar() {
             duDatepicker('#<%= txtbday.ClientID %>', {
                 auto: true, inline: true, format: 'dd/mm/yyyy',
             });
         }
     </script>--%>



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
 <%--  <p>view redirect info</p>--%>
	  <!-- registration form start -->
     <h2 class="pgTitle">Approve Center Master</h2>
    <span class="space10"></span>
   
   <div id="editinfo" runat="server">
   
        <div class="card card-primary">
            	<div class="card-header">
				<h3 class="card-title">Approve Centers Master</h3>
			</div>
            <!-- Card Body -->
            <div class="card-body">
                <div class="colorLightBlue">
                    <asp:Label ID="lblId" runat="server" Text="[New]"></asp:Label>
                </div>
                <span class="space20"></span>
                <div class="row">
                    <div class="col-md-12">                                                             
                                <div class="row">
                                    <div class="col-md-6">
                                        <div>
                                            <p>Center Registration Date : <%= arrData[0] %></p>
                                            <p>Center Renew Date : <%= arrData[1] %></p>
                                            <p>ATC Register Number : <%= arrData[2] %></p>
                                            <p>Name of Organization/ Center : <%= arrData[3] %></p>
                                            <p>Type of Organization : <%= arrData[4] %></p>
                                            <p>Center State : <%=arrData[5] %></p>
                                            <p>Center District : <%=arrData[6] %></p>
                                            <p>Taluka : <%=arrData[7] %></p>
                                            <p>City : <%=arrData[8] %></p>
                                            <p>Email Id : <%= arrData[9] %></p>
                                            <p>Mobile No.: <%= arrData[10] %></p>
                                            <p>Pincode : <%= arrData[11] %></p>
                                            <!--  basic details... -->
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div>
                                            <p>Owner Name : <%= arrData[12] %></p>
                                            <p>Gender : <%= arrData[13] %></p>
                                            <p>Birth Date : <%= arrData[14] %></p>
                                            <p>Owner Photo : <%= arrData[15] %></p>
                                            <p>Role : <%= arrData[16] %></p>

                                            <p>Username : <%= arrData[17] %></p>
                                            <p>UserPassword : <%= arrData[18] %></p>
                                            <p>Center Logo: <%= arrData[19] %></p>
                                            <p>Profcourses : <%= arrData[20] %></p>
                                            <p>Educertificate : <%= arrData[21] %></p>
                                            <p>IDproof : <%= arrData[22] %></p>

                                            <!-- Other details... -->
                                        </div>
                                    </div>
                                    
                                    
                                </div>
                           
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- registration form Ends -->
    <span class="space30"></span>



    <div id="viewinfo" runat="server">
		<span class="space20"></span>
		<div class="formPanel table-responsive-md">
		<asp:GridView ID="gvapprove" runat="server" CssClass="table table-striped table-bordered table-hover" GridLines="None" 
				AutoGenerateColumns="false" OnRowDataBound="gvapprove_RowDataBound" >
			 <HeaderStyle CssClass="thead-dark" />
				<RowStyle CssClass="" />
				<AlternatingRowStyle CssClass="alt" />
			<Columns>
					 <asp:BoundField DataField="CenterID">
						<HeaderStyle CssClass="HideCol" />
						<ItemStyle  CssClass="HideCol"/>
					</asp:BoundField>

                     <asp:BoundField DataField="CenterRegDate" HeaderText="RegDate">
                       <ItemStyle Width="10%" />
                     </asp:BoundField>
					
					 <asp:BoundField DataField="CenterName" HeaderText=" Center Name">
						<ItemStyle Width="15%" />
					</asp:BoundField>

                 <asp:BoundField DataField="CenterCity" HeaderText=" Center City">
						<ItemStyle Width="15%" />
					</asp:BoundField>

					 <asp:BoundField DataField="CenterOwnerName" HeaderText="OwnerName">
						<ItemStyle Width="15%" />
					</asp:BoundField>


				 <asp:BoundField DataField="CenterMobile" HeaderText="Mobileno">
						<ItemStyle Width="15%" />
					</asp:BoundField>

				 <asp:BoundField DataField="CenterEmailId" HeaderText="EmailId">
						<ItemStyle Width="10%" />
					</asp:BoundField>

				   <asp:templatefield headertext="Status">
						<itemstyle width="5%" />
						<itemtemplate>
							<asp:literal id="litstatus" runat="server"></asp:literal>
						</itemtemplate>
					</asp:templatefield>

					<asp:TemplateField headertext="View">
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

