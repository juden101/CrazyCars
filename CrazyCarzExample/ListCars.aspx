<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListCars.aspx.cs" Inherits="ListCars" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div class="container-fluid">
    <div class="card ">
        <div class="card-header bg-secondary">
        <h2>List of Cars</h2>
            </div>
        <div class="card-body">
    
   Car Registration<br />
&nbsp;<asp:DropDownList ID="listCarTypes" CssClass="form-control col-md-4" runat="server"></asp:DropDownList>
    <br />
</div>
        </div>
            </div>
</asp:Content>

