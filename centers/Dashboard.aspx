<%@ Page Title="Dashboard | VTCC" Language="C#" MasterPageFile="~/centers/MasterAdmin.master" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="centers_Dashboard" %>
<%@ MasterType VirtualPath="~/centers/MasterAdmin.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2 class="pgTitle">Dashboard</h2>
    <span class="space20"></span>
    <%-- Card Box --%>
    <div class="container-fluid">
        <div class="row">
           <%--  <%-- Small Boxces --%>
            <div class="col-lg-3 col-6">
                <div class="small-box bg-info">
                    <div class="inner">
                        <h3><%=arrCounts[0]%></h3>
                        <p>Student Admission form</p>
                    </div>
                    <div class="icon">
                        <i class="ion ion-bag"></i>

                    </div>
                    <a href="student-form.aspx" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i> </a>
                </div>
            </div>
            </div>
        </div>
</asp:Content>

