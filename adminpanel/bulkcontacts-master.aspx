<%@ Page Title="Bulk Contacts| VTCC" Language="C#" MasterPageFile="~/adminpanel/MasterAdmin.master" AutoEventWireup="true" CodeFile="bulkcontacts-master.aspx.cs" Inherits="adminpanel_bulkcontacts_master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript">
	window.onload = function () {
		//alert("window load");

		duDatepicker('#<%= txtfromdate.ClientID %>', {
			auto: true, inline: true, format: 'dd/mm/yyyy',
        });

        duDatepicker('#<%= txttodate.ClientID %>', {
            auto: true, inline: true, format: 'dd/mm/yyyy',
        });
	}
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <h2 class="pgTitle">Bulk Contact Master</h2>
        <span class="space10"></span>
        <div class="card card-primary">
            <div class="card-header">
                <h3 class="card-title">Bulk Contacts </h3>
            </div>
            <%-- Card Body --%>
            <div class="card-body">
              
                <span class="space15"></span>
                <%-- From Row Start --%>

                <div class="form-row">
                    <div class="form-group col-md-3">
                        <label>From Date: *</label>
                        <asp:TextBox ID="txtfromdate" runat="server" CssClass="form-control" Width="50%"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-3">
                        <label>To Date: *</label>
                        <asp:TextBox ID="txttodate" runat="server" CssClass="form-control" Width="50%"></asp:TextBox>
                    </div>
                </div>
                <span class="space10"></span>
                <asp:CheckBox ID="chkAll" runat="server" Text="&nbsp;&nbsp; All Days" />
                <span class="space20"></span>
                <asp:Button ID="btngetdata" runat="server" CssClass="btn btn-primary" Text="Get Data" OnClick="btngetdata_Click" />
                <span class="space30"></span>

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label>Email :</label>
                        <asp:TextBox ID="txtemail" runat="server" CssClass="form-control textarea" Height="200px" Width="100%" TextMode="MultiLine"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label>Mobile No :</label>
                        <asp:TextBox ID="txtmobileno" runat="server" CssClass="form-control textarea" Height="200px" Width="100%" TextMode="MultiLine"></asp:TextBox>
                    </div>
                </div>


            </div>
        </div>

    </div>
</asp:Content>

