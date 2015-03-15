<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PdfTest._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />

    <script language="javascript">
        function openPdf(pdfName) {
            window.open(pdfName);
        }
    </script>

</asp:Content>
