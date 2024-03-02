<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Opening.aspx.cs" Inherits="BonusHunt.Opening" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"> </asp:ScriptManager>
    <div class="row justify-content-left">
        <div class="col-4">
            <label class="form-label">Ingresar bet:</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtBet" Width="25%" />
        </div>
        <div class="col-4">
            <label class="form-label">Ingresar Win:</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtWin" Text="0" Width="25%" />
        </div>
    </div>

    <br />
    <asp:UpdatePanel ID="updatePanel1" runat="server">
        <ContentTemplate>  
    <asp:GridView runat="server" ID="dgvBonusOpening" DataKeyNames="Id" CssClass="table"
        autoGenerateColumns="false" OnSelectedIndexChanged="dgvBonusOpening_SelectedIndexChanged" >
        <Columns>
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="MaxWin" DataField="MaxWin" />
            <asp:BoundField HeaderText="Bet" DataField="Bet" />
            <asp:BoundField HeaderText="Win" DataField="Win" />
            <asp:BoundField HeaderText="Multi" DataField="Multi" />
            <asp:CommandField HeaderText="Ingresar" ShowSelectButton="true" SelectText="✅" />
        </Columns>
    </asp:GridView>
        </ContentTemplate> 
        </asp:UpdatePanel>
    <div class="row justify-content-center">
        <div class="col-4">
            <asp:Button Text="Finalizar Opening" ID="btnFinalizar" CssClass="btn btn-primary" runat="server" />
        </div>
    </div>
</asp:Content>
