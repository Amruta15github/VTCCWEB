<%@ Page Title="Download | VTCC" Language="C#" MasterPageFile="~/adminpanel/MasterAdmin.master" AutoEventWireup="true" CodeFile="download-master.aspx.cs" Inherits="adminpanel_download_master" %>
<%@ MasterType VirtualPath="~/adminpanel/MasterAdmin.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   <script>
        $(document).ready(function () {
            $('[id$=gvDocument]').DataTable({
                columnDefs: [
                    { orderable: false, targets: [0, 1, 2, 3, 4, 5, 6, 7] }
                ],
                order: [[0, 'desc']]
            });
        });
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2 class="pgTitle">Download Master</h2>
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
                        <label>Document Name:*</label>
                        <asp:TextBox ID="txtdocname" runat="server" CssClass="form-control" Width="100%"
                            MaxLength="100"></asp:TextBox>
                    </div>

                    <div class="form-group col-md-6">
                        <label>Document Upload:* </label>
                        <asp:FileUpload ID="fileuploaddoc" runat="server" CssClass="form-control-file" />
                        <%= docfile %>
                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label>Document Size:* </label>
                        <asp:TextBox ID="txtdocsize" runat="server" CssClass="form-control" Width="100%"
                            MaxLength="15"></asp:TextBox>
                    </div>

                      <div class="form-group col-md-6">
                          <label>Document Type:* </label>
                          <asp:DropDownList ID="ddldoctype" CssClass="form-control" runat="server" AutoPostBack="true">
                              <asp:ListItem Value="0"><- Select Document Type -></asp:ListItem>
                              <asp:ListItem Value="1">Document</asp:ListItem>
                              <asp:ListItem Value="2">Online demo exam</asp:ListItem>
                              <asp:ListItem Value="3">Proposal</asp:ListItem>
                          </asp:DropDownList>
                      </div>
                  </div>

                <div class="form-group col-md-6">
                    <label>Document Description :</label>
                    <asp:TextBox ID="txtdocDesc" runat="server" CssClass="form-control textarea" Height="200px" Width="100%" TextMode="MultiLine"></asp:TextBox>
                </div>
            </div>
         </div>
       
     <!-- Button controls starts -->
        <span class="space10"></span>
        <span class="space10"></span>
        <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" Text="Save" OnClick="btnSave_Click" />
        <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-outline-info" Text="Delete" OnClientClick="return confirm('Are you sure to delete?');" OnClick="btnDelete_Click" />
        <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-outline-dark" Text="Cancel" OnClick="btnCancel_Click" />
        <div class="float_clear"></div>
        <!-- Button controls ends -->
    </div>
    </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="btnSave" />
        </Triggers>
    </asp:UpdatePanel>

   <%--gridview--%>
    <div id="viewinfo" runat="server">
		<a href="download-master.aspx?action=new" runat="server" class="btn btn-primary btn-md">Add New</a>
		<%--<a href="contactdata.aspx?action=new" runat="server" class="btn btn-primary btn-md">Add New</a>--%>
		<span class="space20"></span>
		<div class="formPanel table-responsive-md">
            <asp:GridView ID="gvDocument" runat="server" CssClass="table table-striped table-bordered table-hover" GridLines="None" 
              AutoGenerateColumns="false" OnRowDataBound="gvDocument_RowDataBound" > 
                 <HeaderStyle CssClass="thead-dark" />
				<RowStyle CssClass="" />
				<AlternatingRowStyle CssClass="alt" />
				<Columns>
                    
                     <asp:BoundField DataField="DocId">
						<HeaderStyle CssClass="HideCol"/>
						<ItemStyle  CssClass="HideCol"/>
					</asp:BoundField>

                     <asp:BoundField DataField="DocLink">
						<HeaderStyle CssClass="HideCol"/>
						<ItemStyle  CssClass="HideCol"/>
					</asp:BoundField>

                    <asp:BoundField DataField="DocName" HeaderText="Doc Name">
						<ItemStyle Width="20%" />
					</asp:BoundField>

                      <asp:BoundField DataField="DocLink" HeaderText="Doc Link">
						<ItemStyle Width="20%" />
					</asp:BoundField>

                       <asp:BoundField DataField="DocSize" HeaderText="Doc Size">
						<ItemStyle Width="20%" />
					</asp:BoundField>

                     <asp:BoundField DataField="DownCount" HeaderText="Views">
						<ItemStyle Width="10%" />
					</asp:BoundField>

                    <asp:TemplateField>
						<ItemStyle Width="10%" />
						<ItemTemplate>
							<asp:Literal ID="litAnch" runat="server"></asp:Literal>
						</ItemTemplate>
					</asp:TemplateField> 

                     <asp:TemplateField>
						<ItemStyle Width="10%" />
						<ItemTemplate>
							<asp:Literal ID="litanchdoc" runat="server"></asp:Literal>
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

