<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BonusHunt.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Hola</h1>
    <asp:Label Text="Bonus Obtenido" runat="server" />
    <asp:TextBox runat="server" ID="txtAgregarBonus" />
    <asp:Button Text="Agregar" ID="btnAgregar" CssClass="btn btn-primary" runat="server" />

    <asp:GridView ID="dgvBonus" runat="server" DataKeyNames="Id" CssClass="table" AutoGenerateColumns="false"
        OnSelectedIndexChanged="dgvBonus_SelectedIndexChanged" OnPageIndexChanging="dgvBonus_PageIndexChanging"
        AllowPaging="true" PageSize="5">
        <Columns>
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="MaxWin" DataField="MaxWin" />
            <asp:BoundField HeaderText="Bet" DataField="Bet" />
            <asp:BoundField HeaderText="Activo" DataField="Activo" />
            <asp:CommandField HeaderText="Activar" ShowSelectButton="true" SelectText="✅" />
        </Columns>
    </asp:GridView>
</asp:Content>
