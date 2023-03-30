<%@ Page Title="" Async="true" Language="vb" AutoEventWireup="false" MasterPageFile="~/Views/MasterPage.Master" CodeBehind="Home.aspx.vb" Inherits="ThalesWebApp.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="margin-top: 60px">
        <div class="row">
            <div class="col-sm-12">
                <div class="card m-2 pb-2 shadow bg-white rounded" style="overflow-y: auto">
                    <div class="card-body">

                        <div class="col-sm-6">
                            <asp:Label ID="LblBuscar" runat="server" CssClass="form-label" Text="Select a Employee"></asp:Label>
                            <div class="row">
                                <div class="col-sm-12">
                                    <asp:DropDownList ID="DdlEmployee" CssClass="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DdlEmployee_SelectedIndexChanged"></asp:DropDownList>
                                </div>
                            </div>
                        </div>

                        <div class="col-sm-12 mt-3">
                            <asp:GridView ID="GrwEmployee" runat="server" CssClass="table table-bordered table-condensed table-responsive table-hover">
                                
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
