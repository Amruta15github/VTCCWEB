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
     <h2 class="pgTitle">Approve Center Details</h2>
    <span class="space10"></span>
   
   <div id="editinfo" runat="server">
   
        <div class="card card-primary">
            	<div class="card-header">
				<h3 class="card-title">Approve Centers Details</h3>
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
                                            <p><strong>Registration Date :</strong> <%= arrData[0] %></p>
                                            <p><strong>Renew Date :</strong> <%= arrData[1] %></p>
                                            <p><strong>ATC Register Number : </strong><%= arrData[2] %></p>
                                            <p><strong>Name :</strong> <%= arrData[3] %></p>
                                            <p><strong>Type of Organization :</strong> <%= arrData[4] %></p>
                                            <p><strong>State :</strong> <%=arrData[5] %></p>
                                            <p><strong>District :</strong> <%=arrData[6] %></p>
                                            <p><strong>Taluka :</strong> <%=arrData[7] %></p>
                                            <p><strong>City :</strong> <%=arrData[8] %></p>
                                            <p><strong>Email Id :</strong> <%= arrData[9] %></p>
                                            <p><strong>Mobile No.:</strong> <%= arrData[10] %></p>
                                            <p><strong>Pincode :</strong> <%= arrData[11] %></p>
                                            <p><strong>Owner Name :</strong> <%= arrData[12] %></p>
                                            <p><strong>Gender :</strong> <%= arrData[13] %></p>
                                            <p><strong>Birth Date : </strong><%= arrData[14] %></p>
                                            <p><strong>Role :</strong> <%= arrData[16] %></p>
                                            <p><strong>Username :</strong> <%= arrData[17] %></p>
                                            <p><strong>UserPassword :</strong> <%= arrData[18] %></p>
                                            <!--  basic details... -->
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div>

                                            <p><strong>Owner Photo :</strong> <%= arrData[15] %> 
                                                <span class="space10"></span> <%= centerphoto %></p>

                                            <p><strong>Center Logo:</strong> <%= arrData[19] %>
                                                <span class="space10"></span> <%= centerlogo %></p>

                                            <p><strong>Professional Courses Completed :</strong> <%= arrData[20] %>  
                                                 <span class="space10"></span><%= centerprofcourse %></p>

                                            <p><strong>Photo ID proof :</strong> <%= arrData[22] %>  
                                                 <span class="space10"></span><%= centeridproof %></p>

                                            <p><strong>Educational Qualification :</strong> <%= arrData[21] %>  
                                                <span class="space10"></span> <%= centereducerti %></p>

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

