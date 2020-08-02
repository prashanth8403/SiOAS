<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/Dashboard/Dashboard.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SiOAS.Dashboard.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="main_content" runat="server">
    <div class="content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-3 col-md-6 col-sm-6">
                    <div class="card card-stats users">
                        <div class="total-fee">
                            <i class="material-icons" style="font-size: 70px;">perm_identity</i>
                            <hr style="background-color: #fff" />
                            <a style="float: left;">TOTAL USERS</a>
                            <div class="fee-anchor">
                                <a>
                                    <asp:Label ID="TotalUsers" runat="server" Text="351"></asp:Label>
                                </a>
                            </div>
                        </div>
                        <br />
                    </div>
                </div>
                <div class="col-lg-3 col-md-6 col-sm-6">
                    <div class="card card-stats payment">
                        <div class="total-fee">
                            <i class="material-icons" style="font-size: 70px;">done_all</i>
                            <hr style="background-color: #fff" />
                            <a style="float: left;">TOTAL RESPONSES</a>
                            <div class="fee-anchor">
                                <a>
                                    <asp:Label ID="TotalResponses" runat="server" Text="0.00"></asp:Label></a>
                            </div>
                        </div>
                        <br />
                    </div>
                </div>
                <div class="col-lg-3 col-md-6 col-sm-6">
                    <div class="card card-stats paid">
                        <div class="total-fee">
                            <i class="material-icons" style="font-size: 70px;">face</i>
                            <hr style="background-color: #fff" />
                            <a style="float: left;">YOUR RESPONSES</a>
                            <div class="fee-anchor">
                                <a>
                                    <asp:Label ID="UserResponses" runat="server" Text="0.00"></asp:Label></a>
                            </div>
                        </div>
                        <br />
                    </div>
                </div>
                <div class="col-lg-3 col-md-6 col-sm-6">
                    <div class="card card-stats card2">
                        <div class="total-fee">
                            <i class="material-icons" style="font-size: 70px;">assignment</i>
                            <hr style="background-color: #fff" />
                            <a style="float: left;">YOUR QUIZES</a>
                            <div class="fee-anchor">
                                <a>
                                    <asp:Label ID="UserQuiz" runat="server" Text="0.00"></asp:Label>
                                </a>
                            </div>
                        </div>
                        <br />
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <div class="card">
                        <div class="card-header card-header-primary">
                            <h4 class="card-title ">Fee Payment</h4>
                        </div>
                        <div class="card-body">
                            <div class="table-responsive">
                                <asp:Panel ID="GridPanel" runat="server">
                                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                                </asp:Panel>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
