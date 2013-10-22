<%@ Page Language="C#" MasterPageFile="~/Site.master"
AutoEventWireup="true" CodeBehind="AdministrarDocumentosEstudiantes.aspx.cs" Inherits="ITCR.PsicoCitas.Interfaz.AdministrarDocumentosEstudiantes" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <title>Descargar Documentos</title>
    <link href="bootstrap/js/dropdown.js" rel="stylesheet" type="text/css" />

</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="row">
        <div class="col-md-12"><h1>Descargar Documentos</h1></div>
        <!--=========================================-->
        <!--=================carrucel================-->
        <!--=========================================-->
    </div>
    <div class="row">
        <div class="col-md-1"></div><!-- espacio -->
        <div class="col-md-10">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
            ForeColor="#333333" GridLines="None" onrowdeleting="GridView1_RowDeleting" DataKeyNames="Name">
            <RowStyle BackColor="#EFF3FB" />
            <Columns>
                <asp:TemplateField HeaderText="Nombre del Documento">
                    <ItemTemplate>
                        <asp:HyperLink ID="nombre" runat="server" NavigateUrl='<%# Eval("Name", "/files/{0}") %>'
                            Text='<%# Eval("Name") %>'>
                        </asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Descargar Documento" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <asp:HyperLink ID="descarga" runat="server" NavigateUrl='<%# Eval("Name", "Download.aspx?filename={0}") %>'>
                               <img src="../imagenes/download.gif" alt="" width="30px" height="30px" style="border-width:0px;" />
                        </asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>



        </div>
        <div class="col-md-1"></div><!-- espacio -->
    </div>
    <br />
    <br />
    <br />
</asp:Content>




