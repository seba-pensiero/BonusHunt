<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="NuevoBonus.aspx.cs" Inherits="BonusHunt.NuevoBonus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label Text="Nombre del Bonus a Agregar: " runat="server" />
    <asp:TextBox ID="txtAgregarBonus" runat="server" />
    <asp:Button Text="Agregar" ID="btnAgregarNuevo" CssClass="btn btn-primary" OnClick="btnAgregarNuevo_Click" runat="server" />
</asp:Content>
