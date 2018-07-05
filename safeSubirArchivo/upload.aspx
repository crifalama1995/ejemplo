<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="upload.aspx.cs" Inherits="safeSubirArchivo.upload" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>subir archivos</h1>
    <br />
    <asp:FileUpload ID="fuArchivo" runat="server" />
    <br />
    <asp:Button ID="btnUpload" runat="server" Text="Upload..." OnClick="btnUpload_Click" />
    <br />
    <asp:Label ID="lblComprobar" runat="server" Text=""></asp:Label>
</asp:Content>
