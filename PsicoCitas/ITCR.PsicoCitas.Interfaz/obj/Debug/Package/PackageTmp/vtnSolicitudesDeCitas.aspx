<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="vtnSolicitudesDeCitas.aspx.cs" Inherits="ITCR.PsicoCitas.Interfaz.vtnSolicitudesDeCitas" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">

</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   
   <div id="titulo"><h1>Solicitudes de Citas Realizadas</h1></div>
   <div class="row mostrar">
        <div class="col-md-1"></div><!--espacio vacio-->
        <div class="col-md-10">
       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            onselectedindexchanged="Ver_Detalle" Height="400px" Width="100%" 
            DataKeyNames="ID">
            <HeaderStyle BackColor="#00386b" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
            <Columns>
                <asp:BoundField AccessibleHeaderText="Fecha de Solicitud" DataField="Fecha de Solicitud" HeaderText="Fecha de Solicitud" ItemStyle-HorizontalAlign="Center" />
                <asp:BoundField DataField="Urgencia" HeaderText="Urgencia" ItemStyle-HorizontalAlign="Center" />
                <asp:BoundField DataField="Estudiante" HeaderText="Estudiante" ItemStyle-HorizontalAlign="Center"/>
                    <asp:BoundField DataField="Carnet" HeaderText="Carnet" ItemStyle-HorizontalAlign="Center" />
                <asp:BoundField DataField="Carrera" HeaderText="Carrera" ItemStyle-HorizontalAlign="Center"/>
                <asp:CommandField ButtonType="Button" SelectText="Ver Detalle" ShowSelectButton="True" ItemStyle-HorizontalAlign="Center" />
            </Columns>
        </asp:GridView>
        </div>
        <div class="col-md-1"></div><!--espacio vacio-->
    </div>    
    <br />
    <br />
    <br />
</asp:Content>
