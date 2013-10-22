<%@ Page Language="C#" MasterPageFile="~/Site.master"
 AutoEventWireup="true" CodeBehind="AsignarPsicologo.aspx.cs" Inherits="ITCR.PsicoCitas.Interfaz.AsignarPsicologo"  %>

 <%@ PreviousPageType VirtualPath="~/vtnSolicitudesDeCitas.aspx"%>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <title>Asignar Psic&oacute;logo</title>

</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="jumbotron mostrar">
        <div class="container">
            <div class="col-md-12">
            <div class="row">

                <div class="col-md-2"> 
                </div>


                <div class="col-md-2">
                    <h5>Nombre Estudiante</h5>
                    <h1></h1>
                    <h5>Carné</h5>
                    <h1></h1>
                    <h5>Carrera</h5>
                    <h1></h1>
                    <h5>Fecha de solicitud</h5>
                    <h1></h1>
                    <h5>Motivo</h5>
                    <h1></h1>
                    <h5>Urgencia</h5>
                    <h1></h1>
                    <h5>Asesor Psicoeducativo previo</h5>
                    <h1></h1>
                    <h5>Fecha previa </h5>
                    <h1></h1>
                    <h5>Observacion</h5>
                    <h1></h1>
                     <h5>Horario Disponibilidad</h5>
                    <h1></h1>
                    
                    
                    
     
                    
                    <h5>Psic&oacute;logo</h5>
                </div>
                <div class="col-md-4">
                    <div class="form-group">
                        <asp:Label ID="textoNomEstudiante" class="form-control" runat="server" Text="<Nombre Estudiante>"></asp:Label>
                        <asp:Label ID="carnet" class="form-control" runat="server" Text="<Carné>"></asp:Label>
                        <asp:Label ID="carrera" class="form-control" runat="server" Text="<Carrera>"></asp:Label>
                        <asp:Label ID="fecha_solicitud" class="form-control" runat="server" Text="<fecha_solicitud>"></asp:Label>
                        <asp:Label ID="Motivo" class="form-control" runat="server" Text="<motivo>"></asp:Label>
                        <asp:Label ID="Urgencia" class="form-control" runat="server" Text="<Urgencia>"></asp:Label>
                        <asp:Label ID="Nombre_previo" class="form-control" runat="server" Text="<Nombre_previo>"></asp:Label>
                        <asp:Label ID="Fecha_previo" class="form-control" runat="server" Text="<Fecha_previo>"></asp:Label>
                        <asp:Label ID="Observacion" class="form-control" runat="server" Text="<observacion>"></asp:Label>
                        <asp:Label ID="Horario_1" class="form-control" runat="server" Text="<Horario_1>"></asp:Label>
                    </div>
                </div>
            </div>
            <h3>Asignar</h3>
            <div class="row">

            <div class="col-md-2">
                    <h5> Nombre de Psic&oacute;logo</h5>
            </div>

            <div class="col-md-4">
                    <div class="form-group">
                        <asp:DropDownList ID="ddlPsicologos" class="form-control" runat="server" 
                            DataTextField="Nombre" DataValueField="ID">
                        </asp:DropDownList>
                    </div>
            </div>

            </div>
                
            <div class="row">
        <div class="col-md-5"></div>
        <div class="col-md-7">
            <asp:Button ID="btnAsignarCita" class="btn btn-primary"  runat="server" 
                Text="Guardar" onclick="btnAsignarCita_Click" />
            <asp:Button Text="Cancelar"  class="btn btn-info" runat="server" ID="btnCancelar"/>
        </div>
    </div>
        </div>

        </div>
    </div>
    <br />
    <br />
    <br />
</asp:Content>
