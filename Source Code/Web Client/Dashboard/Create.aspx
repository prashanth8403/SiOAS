<%@ Page Title="Create" Language="C#" MasterPageFile="~/Dashboard/Dashboard.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="SiOAS.Dashboard.Create" %>

<asp:Content ID="Content1" ContentPlaceHolderID="main_content" runat="server">

    <div class="content">
        <div class="container-fluid">
            <br />
            <br />
            <asp:Panel ID="DescriptionPanel" runat="server">
                <div>
                    <div class="card">
                        <div class="card-header card-header-rose">
                            <h4 class="card-title">New Quiz</h4>
                        </div>
                        <br />
                        <div class="card-body ml-auto mr-auto">
                            <div class="row">
                                <div class="input-group">
                                    <div class="new-labels">
                                        <a class="new-label">Subject:</a>
                                    </div>
                                    <div class="new-inputs">
                                        <input class="new-text" />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="input-group">
                                    <div class="new-labels" >
                                        <a class="new-label">Subject Code:</a>
                                    </div>
                                    <div class="new-inputs">
                                        <input class="new-text" />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="input-group">
                                    <div class="new-labels">
                                        <a class="new-label">Quiz Title</a>
                                    </div>
                                    <div class="new-inputs">
                                        <input class="new-text" />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="input-group" >
                                    <div class="new-labels">
                                        <a class="new-label">Description</a>
                                    </div>
                                    <div class="new-inputs">
                                        <input class="new-text" />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="input-group" >
                                    <div class="new-labels">
                                        <a class="new-label">Time:</a>
                                    </div>
                                    <div class="new-inputs">
                                        <input class="new-text" />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="input-group" >
                                    <div class="new-labels">
                                        <a class="new-label">Branch:</a>
                                    </div>
                                    <div class="new-inputs">
                                        <input class="new-text" />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="input-group" >
                                    <div class="new-labels">
                                        <a class="new-label">Quiz Duration: </a>
                                    </div>
                                    <div class="new-inputs">
                                        <input class="new-text" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel ID="QuestionPanel" runat="server" Visible="false">
                <div class="row">
                    <div class="col-md-12">
                        <div class="card">
                            <div class="card-body">
                                <div class="table-responsive">
                                    <div>
                                        <asp:GridView CssClass="table table-bordered" AutoGenerateColumns="False" Width="100%" OnRowDataBound="OnRowDataBound"
                                            EmptyDataText="No Question Added" ID="ClassList" runat="server" OnRowDeleting="OnRowDeleting">
                                            <Columns>
                                                <asp:BoundField DataField="Question" HeaderText="Question" />
                                                <asp:BoundField DataField="Option1" HeaderText="Option-1" />
                                                <asp:BoundField DataField="Option2" HeaderText="Option-2" />
                                                <asp:BoundField DataField="Option3" HeaderText="Option-3" />
                                                <asp:BoundField DataField="Option4" HeaderText="Option-4" />
                                                <asp:CommandField ShowDeleteButton="True" ControlStyle-CssClass="btn btn-danger" ButtonType="Button" />
                                            </Columns>
                                        </asp:GridView>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
        </div>
    </div>
</asp:Content>
