<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="listar.aspx.cs" Inherits="safeSubirArchivo.listar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:gridview runat="server" ID="gvArchivos" OnSelectedIndexChanged="Unnamed1_SelectedIndexChanged">
    </asp:gridview>
</asp:Content>
