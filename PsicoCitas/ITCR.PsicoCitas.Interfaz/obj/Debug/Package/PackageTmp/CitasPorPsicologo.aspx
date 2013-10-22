<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="CitasPorPsicologo.aspx.cs" Inherits="ITCR.PsicoCitas.Interfaz.CitasPorPsicologo" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">

</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   
   <div id="titulo"><h1>Solicitudes de Citas Pendientes</h1>
       
       
       <h5>Nombre de Psicólogo</h5>
             <div class="col-md-4">
           <asp:DropDownList ID="ddlPsicologos" runat="server" class="form-control" 
               DataTextField="Nombre" DataValueField="ID" onselectedindexchanged="MostrarCitas" 
           ontextchanged="MostrarCitas" AutoPostBack="True">
           </asp:DropDownList>
        </div>
    </div>
   <div id="contenido" style="margin-left:20px">
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
                    <asp:CommandField ButtonType="Button" SelectText="Asignar" ShowSelectButton="True" ItemStyle-HorizontalAlign="Center" />
                </Columns>
        </asp:GridView>
       
    </div>    
        <br />
    <br />
    <br />
</asp:Content>