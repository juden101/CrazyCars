<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddCar.aspx.cs" Inherits="AddCar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="container-fluid">
    <div class="card ">
        <div class="card-header bg-info">
        <h2>Add Car</h2>
            </div>
        <div class="card-body">
       Car Registration<asp:TextBox ID="txtRegistration" CssClass="form-control col-md-4" runat="server"></asp:TextBox>
        <br />
        Car Type <asp:TextBox ID="txtCarType" CssClass="form-control col-md-4" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnSave" CssClass="btn-info" runat="server" Text="Save" OnClick="btnSave_Click" />
  </div>
            </div>
        </div>
</asp:Content>

