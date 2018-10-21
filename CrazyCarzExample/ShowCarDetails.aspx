<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShowCarDetails.aspx.cs" Inherits="ShowCarDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="container-fluid">
    <div class="card">
        <div class="card-header bg-success">
            <h2>Car search</h2>
        </div>
        <div class="card-body">
         Car Registration<asp:DropDownList ID="listNumbers" css="form control" runat="server"></asp:DropDownList>
            <br />
        <asp:Label ID="lblCarType" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnGetcartype" class="btn btn-success" runat="server" Text="Get Car Type" OnClick="btnGetcartype_Click" />
        </div>
     </div>
    </div>
</asp:Content>

