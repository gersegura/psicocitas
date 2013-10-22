<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
CodeBehind="InformacionPersonal.aspx.cs" Inherits="ITCR.PsicoCitas.Interfaz.CU.InformacionPersonal1" %>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <link href="bootstrap/dist/css/bootstrap.css" rel="stylesheet" type="text/css" />
    <title>Informaci&oacute;n Personal</title>
</asp:Content>


<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    
    <div class="row mostrar">
        <div class="col-md-12"><h1>Informaci&oacute;n Personal</h1></div>
        <div class="col-md-12">
            <h3>Datos Personales</h3>    
            <div class="row">
                <div class="col-md-2">
                    <h5>Nombre</h5>
                </div>
                <div class="col-md-3">
                    <div class="form-group">
                        <asp:TextBox runat="server" style="width:100%;" class="form-control" id="textoNombre" placeholder="Nombre Completo"/>
                    </div>
                </div>
                <div class="col-md-2">
                    <h5>Fecha de Nacimiento</h5>
                </div>
                <div class="col-md-3">



                    <asp:TextBox runat="server" style="width:100%;" class="form-control" id="textoFecha" placeholder="dia-mes-a&ntilde;o"/>

                    <!--<asp:RegularExpressionValidator
                        id="RegularExpressionValidator1" runat="server" 
                        ErrorMessage="Formato de Fecha Incorrecto" 
                        ValidationExpression="^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$" 
                        ControlToValidate="textoFecha"
                        class="alert alert-danger">
                    </asp:RegularExpressionValidator>-->

                </div>
            </div>
        </div>

        <div class="col-md-12">  
            <div class="row">
                <div class="col-md-2">
                    <h5>Carn&eacute;</h5>
                </div>
                <div class="col-md-3">
                    <div class="form-group">
                        <asp:TextBox runat="server" style="width:100%;" class="form-control" id="textoCarne" placeholder="N&uacute;mero de Carn&eacute;"/>
                    </div>
                </div>
                <div class="col-md-2">
                    <h5>Celular</h5>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" style="width:100%;" class="form-control" id="textoCelular" placeholder="Celular"/>
                </div>
            </div>
        </div>

        <div class="col-md-12">  
            <div class="row">
                <div class="col-md-2">
                    <h5>Carrera</h5>
                </div>
                <div class="col-md-3">
                    <div class="form-group">
                        <asp:TextBox runat="server" style="width:100%;" class="form-control" id="textoCarrera" placeholder="Carrera Actual"/>
                    </div>
                </div>
                <div class="col-md-2">
                    <h5>Otro Tel&eacute;fono</h5>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" style="width:100%;" class="form-control" id="textoTelefono" placeholder="Tel&eacute;fono"/>
                </div>
            </div>
        </div>

        <div class="col-md-12">
            <div class="row">
                <div class="col-md-2">
                    <h5>Correo Electr&oacute;nico</h5>
                </div>
                <div class="col-md-3">
                    <div class="form-group">
                        <asp:TextBox runat="server" style="width:100%;" class="form-control" id="textoCorreo" placeholder="Correo Electr&oacute;nico"/>
                    </div>
                </div>
            </div>
        </div>



        <div class="col-md-8">
            <h5 style="color:Blue;">
            Solo se pueden actualizar los n&uacute;meros de tel&eacute;fono, correo electr&oacute;nico y carrera (es necesario ingresar carn&eacute;)
            </h5>
        </div>
        <div class="col-md-3">
            <asp:button runat=server type="button" class="btn btn-info" ID="ActualizarDatos" onclick="ActualizarDatos_Click" Text="Actualizar Datos"/>
            <asp:button runat=server type="button" class="btn btn-primary" ID="EnviarDatos" text="enviar datos" onclick="EnviarDatos_Click"/>
        </div>
    </div>

    <div class="row mostrar">
        <div class="col-md-12">
            <h3>Informacion Adicional</h3>
            <div class="row">
                <div class="col-md-3">
                    <h5>¿Ha hecho Cambio de Carrera?</h5><h1></h1>
                </div>
                <div class="col-md-3">
                    <select runat="server"  class="form-control" id="DropDownList1">
                        <option value="Si">Si</option>
                        <option value="No">No</option>
                    </select>
                </div>
            </div>

            <div class="row">
                <div class="col-md-3">
                    <h5>Carrera Anterior</h5><h1></h1>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" style="width:100%;" class="form-control" id="textoCarreraAnterior" placeholder="Nombre de la Carrera Anterior"/>
                </div>
            </div>

            <div class="row">
                <div class="col-md-3">
                    <h5>¿Tiene Consultas Previas en el DOP?</h5><h1></h1>
                </div>
                <div class="col-md-3">
                    <select runat="server"  class="form-control" id="DropDownList2">
                        <option value="Si">Si</option>
                        <option value="No">No</option>
                    </select>
                </div>
            </div>

            <div class="row">
                <div class="col-md-3">
                    <h5>Semestre</h5><h1></h1>
                </div>
                <div class="col-md-3">
                    <select runat="server"  class="form-control" id="DropDownList3">
                        <option value="Si">Primer Semestre</option>
                        <option value="No">Segundo Semestre</option>
                    </select>                    
                </div>
            </div>

            <div class="row">
                <div class="col-md-3">
                    <h5>a&ntilde;o</h5><h1></h1>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" style="width:100%;" class="form-control" id="textoAno" placeholder="a&ntilde;o"/>
                </div>
            </div>

            <div class="row">
                <div class="col-md-3">
                    <h5>Motivo</h5><h1></h1>
                </div>
                <div class="col-md-3">
                    <textarea runat="server" class="form-control" rows="3" cols="2" id="textoMotivo" placeholder="Escriba su motivo aqu&iacute;"></textarea>
                </div>
            </div>
            <br />
            <div class="col-md-1">
            </div>
            <div class="col-md-3">
            <h5 style="color:Blue;">
                Es necesario ingresar su carn&eacute; arriba.
            </h5>
            </div>
            <div class="col-md-2">
            <asp:button runat=server type="button" class="btn btn-primary" onclick="InformacionAdicional_Click"  ID="Button3" Text="Enviar Informaci&oacute;n"/>
            </div>            
        </div>
    </div>
    <br />
    
    <div class="row mostrar">
        <div class="col-md-2">
        </div>
        <div class="col-md-10">
            <p>Desarrollado por Estudiantes de Ingenier&iacute;a en Computaci&oacute;n. Todos los derechos Reservados &reg;</p>    
        </div>
    </div>
        <br />
    <br />
    <br />
 
</asp:Content>
