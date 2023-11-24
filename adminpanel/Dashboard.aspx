<%@ Page Title="Dashboard | VTCC" Language="C#" MasterPageFile="~/adminpanel/MasterAdmin.master" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="adminpanel_Dashboard" %>
<%@ MasterType VirtualPath="~/adminpanel/MasterAdmin.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2 class="pgTitle">Dashboard</h2>
    <span class="space20"></span>
    <%-- Card Box --%>
    <div class="container-fluid">
        <div class="row">
            <%-- Small Boxces --%>
            <div class="col-lg-3 col-6">
                <div class="small-box bg-info">
                    <div class="inner">
                        <h3><%=arrCounts[0]%></h3>
                        <p>News</p>
                    </div>
                    <div class="icon">
                        <i class="ion ion-bag"></i>

                    </div>
                    <a href="news-master.aspx" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i> </a>
                </div>
            </div>


            <div class="col-lg-3 col-6">
                <div class="small-box bg-pink">
                    <div class="inner">
                        <h3><%=arrCounts[1]%></h3>
                        <p>Other Products </p>
                    </div>
                    <div class="icon">
                        <i class="ion ion-bag"></i>

                    </div>
                    <a href="other-products.aspx" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i> </a>
                </div>
            </div>

            <%-- Small Box --%>
            <div class="col-lg-3 col-6">
                <div class="small-box bg-purple">
                    <div class="inner">
                        <h3><%=arrCounts[3] %></h3>
                        <p>Center Registration</p>
                    </div>
                    <div class="icon">
                        <i class="ion ion-bag"></i>
                    </div>
                    <a href="center-registrationMaster.aspx" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i></a>
                </div>
            </div>

              <%-- Small Box --%>
            <div class="col-lg-3 col-6">
                <div class="small-box bg-primary">
                    <div class="inner">
                        <h3><%=arrCounts[8] %></h3>
                        <p>Upload Certificate</p>
                    </div>
                    <div class="icon">
                        <i class="ion ion-bag"></i>
                    </div>
                    <a href="upload-certificate-list.aspx" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i></a>
                </div>
            </div>

             <%-- Small Boxces --%>
             <div class="col-lg-3 col-6">
                <div class="small-box bg-red">
                    <div class="inner">
                        <h3><%=arrCounts[4]%></h3>
                        <p>Download Data</p>
                    </div>
                    <div class="icon">
                        <i class="ion ion-bag"></i>
                    </div>
                    <a href="download-master.aspx" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i> </a>
                </div>
            </div>


            <%-- Small Boxces --%>
            <div class="col-lg-3 col-6">
                <div class="small-box bg-primary">
                    <div class="inner">
                        <h3><%=arrCounts[5]%></h3>
                        <p>Job Openings</p>
                    </div>
                    <div class="icon">
                        <i class="ion ion-bag"></i>
                    </div>
                    <a href="jobopenings-master.aspx" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i> </a>
                </div>
            </div>

              <%-- Small Boxces --%>
            <div class="col-lg-3 col-6">
                <div class="small-box bg-green">
                    <div class="inner">
                        <h3><%=arrCounts[6]%></h3>
                        <p>Student Placement</p>
                    </div>
                    <div class="icon">
                        <i class="ion ion-bag"></i>
                    </div>
                    <a href="studentplacement-master.aspx" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i> </a>
                </div>
            </div>

               <%-- Small Boxces --%>
            <div class="col-lg-3 col-6">
                <div class="small-box bg-warning">
                    <div class="inner">
                        <h3><%=arrCounts[7]%></h3>
                        <p>Career Activity</p>
                    </div>
                    <div class="icon">
                        <i class="ion ion-bag"></i>
                    </div>
                    <a href="careeractivity-master.aspx" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i> </a>
                </div>
            </div>

              <%-- Small Boxces --%>
            <div class="col-lg-3 col-6">
                <div class="small-box bg-warning">
                    <div class="inner">
                        <h3><%=arrCounts[9]%></h3>
                        <p>Certificate Data</p>
                    </div>
                    <div class="icon">
                        <i class="ion ion-bag"></i>
                    </div>
                    <a href="certificate-data-entry.aspx" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i> </a>
                </div>
            </div>

              <%-- Small Boxces --%>
            <div class="col-lg-3 col-6">
                <div class="small-box bg-purple">
                    <div class="inner">
                        <h3><%=arrCounts[10]%></h3>
                        <p>Tie-ups</p>
                    </div>
                    <div class="icon">
                        <i class="ion ion-bag"></i>
                    </div>
                    <a href="tieups-master.aspx" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i> </a>
                </div>
            </div>

              <%-- Small Boxces --%>
            <div class="col-lg-3 col-6">
                <div class="small-box bg-purple">
                    <div class="inner">
                        <h3><%=arrCounts[11]%></h3>
                        <p>Committee Members</p>
                    </div>
                    <div class="icon">
                        <i class="ion ion-bag"></i>
                    </div>
                    <a href="committeemembers-master.aspx" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i> </a>
                </div>
            </div>

              <%-- Small Boxces --%>
             <div class="col-lg-3 col-6">
                <div class="small-box bg-info">
                    <div class="inner">
                        <h3><%=arrCounts[2]%></h3>
                        <p>Testimonials </p>
                    </div>
                    <div class="icon">
                        <i class="ion ion-bag"></i>
                    </div>
                    <a href="testimonials-master.aspx" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i> </a>
                </div>
            </div>

            </div>
        </div>    
</asp:Content>

