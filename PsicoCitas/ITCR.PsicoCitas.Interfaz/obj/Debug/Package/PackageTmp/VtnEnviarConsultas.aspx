<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master"
 CodeBehind="VtnEnviarConsultas.aspx.cs" Inherits="ITCR.PsicoCitas.Interfaz.VtnEnviarConsultas" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <title>Ver Dudas y Consultas</title>
    <link href="bootstrap/js/dropdown.js" rel="stylesheet" type="text/css" />

</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="container">
        <div class="row">
            <!-- 
                primer panel
            -->
            <div class="col-md-5">
                <fieldset>
                    <legend>Dudas</legend>
                    <div class="row">
                        <div class="col-md-5">
                            <h5>Nombre</h5>
                        </div>
                        <div class="col-md-7">
                            <asp:TextBox runat="server" class="form-control" id="nombreEstudiante" placeholder="Nombre::.."/>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-5">
                            <h5>Edad</h5>
                        </div>
                        <div class="col-md-7">
                            <asp:TextBox runat="server" class="form-control" id="edadEstudiante" placeholder="Edad::.."/>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-md-5">
                            <h5>Carrera</h5>
                        </div>
                        <div class="col-md-7">
                            <select id="SelectCarreras" class="form-control" runat="server"></select>
                        </div>
                    </div>




                    <div class="row">
                        <div class="col-md-5">
                            <h5>Carn&eacute;</h5>
                        </div>
                        <div class="col-md-7">
                            <asp:TextBox runat="server" class="form-control" id="carneEstadiente" placeholder="Carnet::.."/>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-5">
                            <h5>Correo Electr&oacute;nico</h5>
                        </div>
                        <div class="col-md-7">
                            <asp:TextBox runat="server" class="form-control" id="correoEstudiante" placeholder="Correo::.."/>
                        </div>
                    </div>
                </fieldset>
                <br />
                <fieldset>
                    <legend>Duda del estudiante</legend>
                    <textarea runat="server" class="form-control" rows="9" cols="5" id="dudaEstudiante" placeholder="Duda del estudiante"></textarea>    
                </fieldset>
                 <br />
                <asp:Button Text="Enviar Consulta" runat="server" type="button" 
                    class="btn btn-primary" ID="enviarRespuestabtn" 
                    onclick="enviarRespuestabtn_Click"/>
            </div>
            
        </div>
    </div>
</asp:Content>
