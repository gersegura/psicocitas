<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Reporte.aspx.cs" Inherits="ITCR.PsicoCitas.Interfaz.Reporte" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">

</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   
   <div id="titulo"><h1>Reporte</h1>
       
       
             <div class="col-md-4">
           <asp:DropDownList ID="ddlreporte" runat="server" class="form-control" 
               DataTextField="Nombre" DataValueField="ID" onselectedindexchanged="mostrardetalle" 
           ontextchanged="mostrardetalle" AutoPostBack="True">
           </asp:DropDownList>
             
        </div>
         
         <asp:Label ID="lbldescripcion" runat="server" Text=""></asp:Label>
      
           <div class="col-md-10">   
         <h3>Fecha Inicio</h3>
         <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
         <h3>Fecha Fin</h3>
         <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
            </div>

         

   <asp:Button  class="btn btn-primary" ID="btngenerar" runat="server" 
           Text="Generar" onclick="btngenerar_Click" />


  
        
    </div> 

   <div id="contenido" style="margin-left:20px">
       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True" 
                Height="400px" Width="100%">
                <HeaderStyle BackColor="#00386b" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
               
        </asp:GridView>
      
       
    </div>    
        <br />
    <br />
    <br />
</asp:Content>