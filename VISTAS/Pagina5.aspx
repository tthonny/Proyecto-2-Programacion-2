<%@ Page Title="" Language="C#" MasterPageFile="~/VISTAS/Pagina.Master" AutoEventWireup="true" CodeBehind="Pagina5.aspx.cs" Inherits="ExamenProgra2.VISTAS.Pagina_5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link href="../CSS/totalVotaciones.css" rel="stylesheet" />
    <div>
        <h2>VOTACIONES TOTALES</h2>
        <table>
            <thead>
                <tr>
                    <th>ELECTOS</th>
                    <th>VOTOS</th>
                </tr>
            </thead>
            <tbody id="votosTabla" runat="server">
              
            </tbody>
        </table>
    </div>
</asp:Content>