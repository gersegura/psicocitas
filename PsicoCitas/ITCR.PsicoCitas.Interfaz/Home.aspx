<%@ Page Language="C#" MasterPageFile="~/Site.master" 
    AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ITCR.PsicoCitas.Interfaz.Home" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <title>Bienvenidos</title>

</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-10">
            <div class="jumbotron mostrar">
                <div class="container">
                    <h2>Departamento de Orientaci&oacute;n y Psicolog&iacute;a</h2> 
                    <br />
                    <!-- 
                        mensaje previo
                    -->

                    <p>Sitio en Desarrollo.... Los datos actualmente pueden variar....Solo usar para pruebas </p>

                    <!-- 
                        mensaje previo
                    -->
                    <br />
                    <p><a data-toggle="modal" href="#leermas" class="btn btn-primary btn-lg">Leer M&aacute;s</a></p>
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />
    <br />
    <!-- Modal -->
    <div class="modal fade" id="leermas" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">
        <div class="modal-header">
            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
            <h4 class="modal-title">Bienvenido</h4>
        </div>
        <div class="modal-body">
            <!-- 
                esta es la bienvenida
            -->
            <h2>Aqui va la bienvenida</h2>

            <!-- 
                esta es la bienvenida
            -->
        </div>
        <div class="modal-footer">
            <button type="button" class="btn btn-primary" data-dismiss="modal">OK</button>
        </div>
        </div><!-- /.modal-content -->
    </div><!-- /.modal-dialog -->
    </div><!-- /.modal -->
    <!-- modal -->
</asp:Content>
