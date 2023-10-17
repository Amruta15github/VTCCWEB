<%@ Page Title="Center-Registration | VTCC" Language="C#" MasterPageFile="~/adminpanel/MasterAdmin.master" AutoEventWireup="true" CodeFile="center-registrationMaster.aspx.cs" Inherits="adminpanel_center_registrationMaster" %>
<%@ MasterType VirtualPath="~/adminpanel/MasterAdmin.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script>
		$(document).ready(function () {
			$('[id$=gvreg]').DataTable({
				columnDefs: [
					{ orderable: false, targets: [0, 1, 2, 3, 4, 5, 6, 7, 8] }
				],
				order: [[0, 'desc']]
			});
		});
     </script>

      <script type="text/javascript">
          function setupcalendar() {
              duDatepicker('#<%= txtbday.ClientID %>', {
                  auto: true, inline: true, format: 'dd/mm/yyyy',
              });
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
	 <h2 class="pgTitle">Center Registration Master</h2>
    <span class="space10"></span>
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
         <ContentTemplate>
   <div id="editreg" runat="server">
   <div class="card card-primary">
			<div class="card-header">
				<h3 class="card-title">Registration Master</h3>
			</div>
       	<%-- Card Body --%>
			<div class="card-body">
				<div class="colorLightBlue">
					<%--<span>Id</span>--%>
					<asp:Label ID="lblId" runat="server"></asp:Label>
				</div>
				<span class="space15"></span>
				<%-- From Row Start --%>
				
                <span class="space10"></span>

                       <div class="form-row">
					 <div class="form-group col-md-6">
						<label>Name of the Organization/Center: *</label>
						<asp:TextBox ID="txtorgname" runat="server" CssClass="form-control"  MaxLength="50"></asp:TextBox>
					</div>
                    
                           <div class="form-group col-md-6">
                               <label for="typeoforg" class="fontRegular semiBold clrBlack">Type of Organization: *</label>
                               <asp:DropDownList ID="ddltypeoforg" CssClass="form-control" runat="server" AutoPostBack="true">                                
                                   <asp:ListItem Value="0"><- Select Organization -></asp:ListItem>
                               </asp:DropDownList>
                           </div>
					 <%--<div class="form-group col-md-6">
						<label>Institute affilliation:</label>
						<asp:TextBox ID="txtinstaffi" runat="server" CssClass="form-control" 
							MaxLength="200" ></asp:TextBox>
					</div>--%>
                           </div>

                  <div class="form-row">
                            <div class="form-group col-md-6">
                            <label for="exampleFormControlSelect1" class="fontRegular semiBold clrBlack">Select State: *</label>
                                <asp:DropDownList ID="ddrstate" CssClass="form-control" runat="server"  AutoPostBack="true" OnSelectedIndexChanged="ddrState_SelectedIndexChanged" > 
                                </asp:DropDownList>
                                 <%-- <select class="form-control" id="ddrState">
                                <option>1</option>
                                <option>2</option>
                                <option>3</option>
                                <option>4</option>  
                                <option>5</option>
                            </select>--%>
                        </div>
                        <div class="form-group col-md-6">
                            <label for="exampleFormControlSelect2" class="fontRegular semiBold clrBlack">Select District: *</label>
                            <asp:DropDownList ID="ddrdist" CssClass="form-control" runat="server">
                                    <asp:ListItem Value="0"><-Select District-></asp:ListItem>
                                </asp:DropDownList>
                            <%--<select class="form-control" id="exampleFormControlSelect1">
                                <option>1</option>
                                <option>2</option>
                                <option>3</option>
                                <option>4</option>
                                <option>5</option>
                            </select--%>
                         </div>
                        </div>



                     <div class="form-row">
                          <div class="form-group col-md-6">
                                <label for="inputtaluka" class="fontRegular semiBold clrBlack">Taluka: *</label>
                                <asp:TextBox ID="txttaluka"  class="form-control" Maxlength="30"   runat="server" ></asp:TextBox>
                            </div>
                          <div class="form-group col-md-6">
                                <label for="inputCity" class="fontRegular semiBold clrBlack">City Name: *</label>
                                <asp:TextBox ID="txtcity"  class="form-control" MaxLength="30"  runat="server"></asp:TextBox>
                            </div>
					 <%--<div class="form-group col-md-6">
						<label>From year: *</label>
						<asp:TextBox ID="txtfromyear" runat="server" CssClass="form-control" 
							 ></asp:TextBox>
					</div>
                   <div class="form-group col-md-6">
                                <label for="inputpin" class="fontRegular semiBold clrBlack">PinCode: *</label>
                                <asp:TextBox ID="txtPin"  class="form-control" Maxlength="15"  runat="server"></asp:TextBox>
                            </div>--%>
                         </div>

                <%-- <div class="form-row">
					<div class="form-group col-md-6">
						<label for="inputAddress1" class="fontRegular semiBold clrBlack">The detailed configuration of Computers available at the institute</label>
                        <asp:TextBox ID="txtcompconfig"  class="form-control" TextMode="MultiLine" Height="100" Maxlength="200"   runat="server"></asp:TextBox>
                       </div> 
                
                            <div class="form-group col-md-6">
                             <label for="inputAddress2" class="fontRegular semiBold clrBlack">Address of the institute: *</label>
                            <asp:TextBox ID="txtInstituteAdd"  class="form-control" TextMode="MultiLine" Height="100" Maxlength="200" runat="server"></asp:TextBox>
                        </div>
                      </div>--%>
                  

                     <div class="form-row">
					 <div class="form-group col-md-6">
						<label>Name of Owner: *</label>
						<asp:TextBox ID="txtowner" runat="server" CssClass="form-control" 
							MaxLength="50" ></asp:TextBox>
					    </div>
					 <div class="form-group col-md-6">
                                <label for="inputgender" class="fontRegular semiBold clrBlack">Gender: *</label>
                                <br />
                                <asp:RadioButton ID="Radiomale" value="1" GroupName="gender" style="margin-left: 10px" runat="server" />
                                <label for="male">Male</label>
                                <asp:RadioButton ID="Radiofemale" value="2" GroupName="gender" style="margin-left: 10px" runat="server" />
                                <label for="Female">Female</label>
                                <asp:RadioButton ID="Radiotransgender" value="3" GroupName="gender" style="margin-left: 10px" runat="server" />
                                <label for="Transgender">Transgender</label>
                            </div>  
                        </div>

                        

                          <div class="form-row">
                            <div class="form-group col-md-6">
                                <label for="inputbday" class="fontRegular semiBold clrBlack">Birth Date: *</label>
                                <asp:TextBox ID="txtbday" class="form-control" runat="server" ></asp:TextBox>
                            </div>
                            <div class="form-group col-md-6">
                            <label for="exampleFormControlSelect1" class="fontRegular semiBold clrBlack">Role: *</label>
                          <asp:TextBox ID="txtrole" class="form-control" MaxLength="30" runat="server" ></asp:TextBox>
                            </div>

                        </div>
                      
                        <div class="form-row">
                             <div class="form-group col-md-6">
                                <label for="inputemailid" class="fontRegular semiBold clrBlack">Email Id:*</label>
                                <asp:TextBox ID="txtemail"  class="form-control" Maxlength="50" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group col-md-6">
                                <label for="inputmobno" class="fontRegular semiBold clrBlack">Mobile No.:*</label>
                                <asp:TextBox ID="txtMobNo"  class="form-control" Maxlength="10"  runat="server"></asp:TextBox>
                            </div>
                        </div>

                       <%-- <div class="form-row">
                            <div class="form-group col-md-6">
                                <label for="inputemailid" class="fontRegular semiBold clrBlack">Email Id:*</label>
                                <asp:TextBox ID="txtemailid"  class="form-control" Maxlength="50" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group col-md-6">
                                <label for="inputwebadd" class="fontRegular semiBold clrBlack">Website address:</label>
                                <asp:TextBox ID="txtWebAdd"  class="form-control" Maxlength="50"  runat="server"></asp:TextBox>
                            </div>
                        </div>--%>
     				
				 <%--actregno,username--%>
				<span class="space20"></span>           
                    <span class="h4">For Office Use</span>
					 <span class="space5"></span>
                    <br />
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="inputactregno" class="fontRegular semiBold clrBlack">ACT RegNo.:*</label>
                        <asp:TextBox ID="txtactregno" class="form-control"  runat="server" Maxlength="30" ></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="inputusername" class="fontRegular semiBold clrBlack">Username:</label>
                        <asp:TextBox ID="txtusername" class="form-control"  runat="server" ReadOnly="true"  Maxlength="50"></asp:TextBox>
                    </div>
                               
              
               </div>
            </div>
	   </div>
          
    <asp:Button ID="btnApprove" runat="server" CssClass="btn btn-sm btn-info" Text="Approve" OnClick="btnApprove_Click"/>
	<asp:Button ID="btnUpdate" runat="server" CssClass="btn btn-sm btn-secondary" Text="Update" OnClick="btnUpdate_Click"/>
	<asp:Button ID="btnBack" runat="server" CssClass="btn btn-sm btn-outline-dark" Text="Back" OnClick="btnBack_Click"/>
	<asp:Button ID="btnDelete" runat="server" CssClass="btn btn-sm btn-dark" Text="Delete" OnClientClick="return confirm('Are you sure to delete?');" OnClick="btnDelete_Click"/>
</div>
 </ContentTemplate>
    </asp:UpdatePanel> 

	<%--<h2 class="pgTitle">Center Registration Master</h2>--%>
    <%--<span class="space10"></span>--%>
	<div id="viewreg" runat="server">
		<span class="space20"></span>
		<div class="formPanel table-responsive-md">
		<asp:GridView ID="gvreg" runat="server" CssClass="table table-striped table-bordered table-hover" GridLines="None" 
				AutoGenerateColumns="false" OnRowDataBound="gvreg_RowDataBound" >
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

