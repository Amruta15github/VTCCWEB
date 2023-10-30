<%@ Page Title="Verify Student certificate" Language="C#" MasterPageFile="~/MasterParent.master" AutoEventWireup="true" CodeFile="verify-student-certificate.aspx.cs" Inherits="verify_student_certificate" %>

<%@ MasterType VirtualPath="~/MasterParent.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        table {
            font-family: arial, sans-serif;
            border-collapse: collapse;
            width: 100%;
        }
        th{font-weight:600; color:#000000}
        td, th {
            border: 1px solid #dddddd;
            text-align: left;
            padding: 8px;
        }

        tr:nth-child(even) {
            background-color: #dddddd;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
     <!-- Page Header Starts -->
    <div class="pgHeader1">
        <div class="headerOverlay">           
            <div class="bottomLight"></div>
            <div class="container">
                <div class="pg_TB_pad">
                    <h1 class="pageH1 clrWhite fontMedium">Verify Certificate</h1>
                    <ul class="bCrumb">
                        <li><a href="<%= Master.rootPath %>">Home</a></li>
                        <li>&raquo;</li>
                        <li>Verify Student Certificate</li>
                    </ul>
                    <div class="float_clear"></div>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Header Ends -->
    <span class="space30"></span>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container">
                <div class="card card-primary">
                    <%--<div class="card-header">
                        <h3 class="card-title"><%=pgTitle %></h3>
                    </div>--%>
                    <div class="card-body">
                        <span class="space15"></span>
                        <%-- From Row Start --%>
                        <div class="form-row">
                            <div class="form-group col-md-6">

                                <label class="bold">Enter Certificate Number:*</label>
                                <asp:TextBox ID="txtcertificateNo" runat="server" CssClass="form-control" Width="100%" MaxLength="20"></asp:TextBox>
                                <span class="space15"></span>
                                <asp:Button ID="btnverify" runat="server" CssClass="btn btn-primary" Text="Verify" OnClick="btnverify_Click" />
                            </div>

                        </div>
                    </div>
                </div>
               <%-- <span class="space30"></span>--%>

                <div id="table" runat="server" class="mt-5">
                    <table>
                        <tr class="bold">
                            <th>Certificate No</th>
                            <th>Student Name</th>
                            <th>Course Name</th>
                            <th>Center Name</th>
                        </tr>
                        <tr>
                            <td><%= ordCertData[0] %></td>
                            <td><%= ordCertData[1] %></td>
                            <td><%= ordCertData[2] %></td>
                            <td><%= ordCertData[3] %></td>
                        </tr>
                        <%--<tr>
                        <td>ordCertData[1]</td>
                        <td>Francisco Chang</td>
                        <td>Mexico</td>
                        <td>Pallavi Dhadake</td>
                    </tr>
                    <tr>
                        <td>ordCertData[2]</td>
                        <td>Roland Mendel</td>
                        <td>Austria</td>
                        <td>Pallavi Dhadake</td>
                    </tr>
                    <tr>
                        <td>ordCertData[3]</td>
                        <td>Helen Bennett</td>
                        <td>UK</td>
                        <td>Pallavi Dhadake</td>
                    </tr>
                    <tr>
                        <td>Laughing  </td>
                        <td>Yoshi Tannamuri</td>
                        <td>Canada</td>
                        <td>Pallavi Dhadake</td>
                    </tr>
                    <tr>
                        <td>Magazzini  </td>
                        <td>Giovanni Rovelli</td>
                        <td>Italy</td>
                        <td>Pallavi Dhadake</td>
                    </tr>--%>
                    </table>
                </div>
               
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

