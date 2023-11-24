<%@ Page Title="CommitteeMembers | VTCC" Language="C#" MasterPageFile="~/adminpanel/MasterAdmin.master" AutoEventWireup="true" CodeFile="committeemembers-master.aspx.cs" Inherits="adminpanel_committeemembers_master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script>
		$(document).ready(function () {
            $('[id$=gvcommitteemember]').DataTable({
				columnDefs: [
					{ orderable: false, targets: [0, 1, 2, 3, 4, 5, 6] }
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

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<h2 class="pgTitle">Committee Member Master</h2>
    <span class="space10"></span>
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
         <ContentTemplate>
   <div id="editinfo" runat="server">
   <div class="card card-primary">
			<div class="card-header">
				<h3 class="card-title">Committee Member Master</h3>
			</div>
       	<%-- Card Body --%>
			<div class="card-body">
				<div class="colorLightBlue">
					<%--<span>Id</span>--%>
					<asp:Label ID="lblId" runat="server" Text="[New]"></asp:Label>
				</div>
				<span class="space15"></span>
				<%-- From Row Start --%>
				
                <span class="space10"></span>
				<div class="form-row">
                        <div class="form-group col-md-6">
                            <label for="inputdate" class="fontRegular semiBold clrBlack">Date: </label>
                            <asp:TextBox ID="txtDate" class="form-control"  runat="server"></asp:TextBox>
                        </div>

                        <div class="form-group col-md-6">
                            <label for="inputname" class="fontRegular semiBold clrBlack">Full Name: *</label>
                            <asp:TextBox ID="txtName" class="form-control" MaxLength="30" runat="server"></asp:TextBox>
                        </div>

                        <div class="form-group col-md-6">
                            <label for="inputEmail" class="fontRegular semiBold clrBlack">Email: *</label>
                            <asp:TextBox ID="txtemail" class="form-control"  MaxLength="50" runat="server"></asp:TextBox>
                        </div>

                            <div class="form-group col-md-6">
                                <label for="inputmobile" class="fontRegular semiBold clrBlack">Mobile no: *</label>
                                <asp:TextBox ID="txtmobileno" MaxLength="10" class="form-control"  runat="server"></asp:TextBox>
                            </div>

                            <div class="form-group col-md-6">
                                <label for="typeoforg" class="fontRegular semiBold clrBlack">State: *</label>
                                <asp:DropDownList ID="ddlstate" CssClass="form-control" runat="server"  AutoPostBack="true" OnSelectedIndexChanged="ddlstate_SelectedIndexChanged" >
                                    <asp:ListItem Value="0"><- Select State -></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                       
                              <div class="form-group col-md-6">
                                <label for="typeoforg" class="fontRegular semiBold clrBlack">District: *</label>
                                <asp:DropDownList ID="ddldistrict" CssClass="form-control" runat="server"  AutoPostBack="true" >
                                    <asp:ListItem Value="0"><- Select District -></asp:ListItem>
                                </asp:DropDownList>
                            </div>


                       <div class="form-group col-md-6">
                            <label for="inputcity" class="fontRegular semiBold clrBlack">City: *</label>
                            <asp:TextBox ID="txtcity" class="form-control"  MaxLength="30" runat="server"></asp:TextBox>
                        </div>

                      </div>
                </div>
       </div>
    <asp:Button ID="btnApprove" runat="server" CssClass="btn btn-sm btn-info" Text="Approve" OnClick="btnApprove_Click" />
	<asp:Button ID="btnUpdate" runat="server" CssClass="btn btn-sm btn-secondary" Text="Update" OnClick="btnUpdate_Click"/>
	<asp:Button ID="btnBack" runat="server" CssClass="btn btn-sm btn-outline-dark" Text="Back" OnClick="btnBack_Click"/>
</div>
 </ContentTemplate>
    </asp:UpdatePanel> 

    <div id="viewinfo" runat="server">
		<%--<a href="jobopenings-master.aspx?action=new" runat="server" class="btn btn-primary btn-md">Add New</a>--%>
		
		<span class="space20"></span>
		<div class="formPanel table-responsive-md">
			<asp:GridView ID="gvcommitteemember" runat="server" CssClass="table table-striped table-bordered table-hover" GridLines="None" 
				AutoGenerateColumns="false" OnRowDataBound="gvcommitteemember_RowDataBound">
				<HeaderStyle CssClass="thead-dark" />
				<RowStyle CssClass="" />
				<AlternatingRowStyle CssClass="alt" />
				<Columns>
					 <asp:BoundField DataField="ComMemberId">
						<HeaderStyle CssClass="HideCol" />
						<ItemStyle  CssClass="HideCol"/>
					</asp:BoundField>

					 <asp:BoundField DataField="ComMemberDate" HeaderText="Date">
						<ItemStyle Width="20%" />
					</asp:BoundField>

					 <asp:BoundField DataField="ComMemberName" HeaderText=" Name">
						<ItemStyle Width="20%" />
					</asp:BoundField>

					 <asp:BoundField DataField="ComMemberEmail" HeaderText="Email ">
						<ItemStyle Width="20%" />
					</asp:BoundField>

					 <asp:BoundField DataField="ComMemberCity" HeaderText="City">
						<ItemStyle Width="20%" />
					</asp:BoundField>

					 <asp:templatefield headertext="Status">
						<itemstyle width="10%" />
						<itemtemplate>
							<asp:literal id="litstatus" runat="server"></asp:literal>
						</itemtemplate>
					</asp:templatefield>

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

