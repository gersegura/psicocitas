<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vtnSolicitarCita.aspx.cs" MasterPageFile="~/Site.master" Inherits="ITCR.PsicoCitas.Interfaz.vtnSolicitarCita" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">

</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-11">
            <h1>Solicitud de Citas</h1>
        </div>
        <div class="col-md-1"></div>
        <div class="col-md-2"> 
            <h5>Nombre de Estudiante</h5>
        </div>
        <div class="col-md-2"> 
            <asp:TextBox ID="txtNombreEstudiante" runat="server" style="width:100%;"  class="form-control" placeholder="Nombre"/>
        </div>
        <div class="col-md-9"></div>
        <div class="col-md-1"></div>
        <div class="col-md-2"> 
            <h5>N&uacute;mero de Carn&eacute;</h5>
        </div>
        <div class="col-md-2"> 
            <asp:TextBox ID="txtCarnetEstudiante" runat="server" style="width:100%;"  class="form-control" placeholder="Carn&eacute;"/>
        </div>
        <div class="col-md-9"></div>
    </div>
    <br/>
    <!-- ========================== -->
    <!-- ======opcion 1============ -->
    <!-- ========================== -->
    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-11"> 
            <h3>Opcion 1</h3>
        </div>
        <div class="col-md-1"></div>
        <div class="col-md-11"> 
            <h4>Elija el día que desea la cita y luego el período correspondiente</h4>
        </div>
        <div class="col-md-1"></div>
        <div class="col-md-1"> 
            <h5>D&iacute;a</h5>
        </div>
        <div class="col-md-2"> 
            <select ID="ddlDias" runat="server" class="form-control">
                <option value="Lunes">Lunes</option>
                <option value="Martes">Martes</option>
                <option value="Miercoles">Mi&eacute;rcoles</option>
                <option value="Jueves">Jueves</option>
                <option value="Viernes">Viernes</option>
                <option value="Todos">Todos</option>
            </select>
        </div>
        <div class="col-md-1"></div>
        <div class="col-md-1"> 
            <h5>Per&iacute;odo</h5>
        </div>
        <div class="col-md-2"> 
            <select ID="ddlPeríodo" runat="server" class="form-control">
                <option value="Manana">Ma&ntilde;ana</option>
                <option value="Tarde">Tarde</option>
            </select>
        </div>
    </div>
    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-1">
            <h5>Inicio:</h5>
        </div>
        <div class="col-md-1"> 
            <select ID="ddlHorainicio" runat="server" class="form-control">
                <option value="7">7</option>
                <option value="8">8</option>
                <option value="9">9</option>
                <option value="10">10</option>
                <option value="11">11</option>
                <option value="12">12</option>
                <option value="13">13</option>
                <option value="14">14</option>
                <option value="15">15</option>
                <option value="16">16</option>
            </select>
        </div>
        <div class="col-md-1"> 
            <select ID="ddlMinsInicio" runat="server" class="form-control">
                <option value="00">0</option>
                <option value="15">15</option>
                <option value="30">30</option>
                <option value="45">45</option>
            </select>
        </div>
        <div class="col-md-8"> </div>
        <!-- ===================== -->
        <div class="col-md-1"></div>
        <div class="col-md-1">
            <h5>Final:</h5>
        </div>
        <div class="col-md-1"> 
            <select ID="ddlHoraFin" runat="server" class="form-control">
                <option value="7">7</option>
                <option value="8">8</option>
                <option value="9">9</option>
                <option value="10">10</option>
                <option value="11">11</option>
                <option value="12">12</option>
                <option value="13">13</option>
                <option value="14">14</option>
                <option value="15">15</option>
                <option value="16">16</option>
            </select>
        </div>
        <div class="col-md-1"> 
            <select ID="ddlMinsFin" runat="server" class="form-control">
                <option value="00">0</option>
                <option value="15">15</option>
                <option value="30">30</option>
                <option value="45">45</option>
            </select>
        </div>
        <div class="col-md-9"> </div>
        <!-- -->
    </div>
    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-11"> 
            <asp:LinkButton ID="lbtnConsultaHorarios" runat="server" Text="Consultar Horarios"/>
        </div>
    </div>
    <br />
    <!-- ===================== -->
    <!-- ========opcion 1===== -->
    <!-- ===================== -->





    <!-- ========================== -->
    <!-- ======opcion 2============ -->
    <!-- ========================== -->
    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-11"> 
            <h3>Opcion 2</h3>
        </div>
        <div class="col-md-1"></div>
        <div class="col-md-11"> 
            <h4>Elija el día que desea la cita y luego el período correspondiente</h4>
        </div>
        <div class="col-md-1"></div>
        <div class="col-md-1"> 
            <h5>D&iacute;a</h5>
        </div>
        <div class="col-md-2"> 
            <select ID="Select5" runat="server" class="form-control">
                <option value="Lunes">Lunes</option>
                <option value="Martes">Martes</option>
                <option value="Miercoles">Mi&eacute;rcoles</option>
                <option value="Jueves">Jueves</option>
                <option value="Viernes">Viernes</option>
                <option value="Todos">Todos</option>
            </select>
        </div>
        <div class="col-md-1"></div>
        <div class="col-md-1"> 
            <h5>Per&iacute;odo</h5>
        </div>
        <div class="col-md-2"> 
            <select ID="Select6" runat="server" class="form-control">
                <option value="Manana">Ma&ntilde;ana</option>
                <option value="Tarde">Tarde</option>
            </select>
        </div>
    </div>
    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-1">
            <h5>Inicio:</h5>
        </div>
        <div class="col-md-1"> 
            <select ID="Select7" runat="server" class="form-control">
                <option value="7">7</option>
                <option value="8">8</option>
                <option value="9">9</option>
                <option value="10">10</option>
                <option value="11">11</option>
                <option value="12">12</option>
                <option value="13">13</option>
                <option value="14">14</option>
                <option value="15">15</option>
                <option value="16">16</option>
            </select>
        </div>
        <div class="col-md-1"> 
            <select ID="Select8" runat="server" class="form-control">
                <option value="00">0</option>
                <option value="15">15</option>
                <option value="30">30</option>
                <option value="45">45</option>
            </select>
        </div>
        <div class="col-md-8"> </div>
        <!-- ===================== -->
        <div class="col-md-1"></div>
        <div class="col-md-1">
            <h5>Final:</h5>
        </div>
        <div class="col-md-1"> 
            <select ID="Select9" runat="server" class="form-control">
                <option value="7">7</option>
                <option value="8">8</option>
                <option value="9">9</option>
                <option value="10">10</option>
                <option value="11">11</option>
                <option value="12">12</option>
                <option value="13">13</option>
                <option value="14">14</option>
                <option value="15">15</option>
                <option value="16">16</option>
            </select>
        </div>
        <div class="col-md-1"> 
            <select ID="Select10" runat="server" class="form-control">
                <option value="00">0</option>
                <option value="15">15</option>
                <option value="30">30</option>
                <option value="45">45</option>
            </select>
        </div>
        <div class="col-md-9"> </div>
        <!-- -->
    </div>
    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-11"> 
            <asp:LinkButton ID="LinkButton1" runat="server" Text="Consultar Horarios"/>
        </div>
    </div>
    <br />
    <!-- ===================== -->
    <!-- ========opcion 2===== -->
    <!-- ===================== -->


       



    <!-- ========================== -->
    <!-- ======opcion 3============ -->
    <!-- ========================== -->
    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-11"> 
            <h3>Opcion 3</h3>
        </div>
        <div class="col-md-1"></div>
        <div class="col-md-11"> 
            <h4>Elija el día que desea la cita y luego el período correspondiente</h4>
        </div>
        <div class="col-md-1"></div>
        <div class="col-md-1"> 
            <h5>D&iacute;a</h5>
        </div>
        <div class="col-md-2"> 
            <select ID="ddlDias2" runat="server" class="form-control">
                <option value="Lunes">Lunes</option>
                <option value="Martes">Martes</option>
                <option value="Miercoles">Mi&eacute;rcoles</option>
                <option value="Jueves">Jueves</option>
                <option value="Viernes">Viernes</option>
                <option value="Todos">Todos</option>
            </select>
        </div>
        <div class="col-md-1"></div>
        <div class="col-md-1"> 
            <h5>Per&iacute;odo</h5>
        </div>
        <div class="col-md-2"> 
            <select ID="ddlPeríodo2" runat="server" class="form-control">
                <option value="Manana">Ma&ntilde;ana</option>
                <option value="Tarde">Tarde</option>
            </select>
        </div>
    </div>
    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-1">
            <h5>Inicio:</h5>
        </div>
        <div class="col-md-1"> 
            <select ID="Select1" runat="server" class="form-control">
                <option value="7">7</option>
                <option value="8">8</option>
                <option value="9">9</option>
                <option value="10">10</option>
                <option value="11">11</option>
                <option value="12">12</option>
                <option value="13">13</option>
                <option value="14">14</option>
                <option value="15">15</option>
                <option value="16">16</option>
            </select>
        </div>
        <div class="col-md-1"> 
            <select ID="Select2" runat="server" class="form-control">
                <option value="00">0</option>
                <option value="15">15</option>
                <option value="30">30</option>
                <option value="45">45</option>
            </select>
        </div>
        <div class="col-md-8"> </div>
        <!-- ===================== -->
        <div class="col-md-1"></div>
        <div class="col-md-1">
            <h5>Final:</h5>
        </div>
        <div class="col-md-1"> 
            <select ID="Select3" runat="server" class="form-control">
                <option value="7">7</option>
                <option value="8">8</option>
                <option value="9">9</option>
                <option value="10">10</option>
                <option value="11">11</option>
                <option value="12">12</option>
                <option value="13">13</option>
                <option value="14">14</option>
                <option value="15">15</option>
                <option value="16">16</option>
            </select>
        </div>
        <div class="col-md-1"> 
            <select ID="Select4" runat="server" class="form-control">
                <option value="00">0</option>
                <option value="15">15</option>
                <option value="30">30</option>
                <option value="45">45</option>
            </select>
        </div>
        <div class="col-md-9"> </div>
        <!-- -->
    </div>
    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-11"> 
            <asp:LinkButton ID="lbtnConsultaHorarios2" runat="server" Text="Consultar Horarios"/>
        </div>
    </div>
    <br />
    <!-- ===================== -->
    <!-- ========opcion 3===== -->
    <!-- ===================== -->
       

        
        
    <!-- =============== -->
    <div class="row">
        <div class="col-md-1"> </div>
        <div class="col-md-4"> 
            <h4>Su Motivo de Consulta es:</h4>
        </div>
        <!--=====================-->
        <div class="col-md-3">
            <select class="form-control" id="_rblMotivos" runat=server>
                <option value="Depresión">Depresión</option>
                <option value="Pareja">Pareja</option>
                <option value="Familiar">Familiar</option>
                <option value="Sexualidad">Sexualidad</option>
                <option value="Salud">Salud</option>
                <option value="Estres">Estr&eacute;s</option>
                <option value="Otro">Otro</option>
            </select>
        </div>
        <div class="col-md-4"> </div>
    </div>
    <!--=====================-->
    <div class="row">
        <div class="col-md-2"> </div>
        <div class="col-md-3"> 
            <h5>Otro, Especifique:</h5>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txtOtroMotivo" runat="server" style="width:100%;"  class="form-control" placeholder="Motivo"/>
        </div> 
    </div>
    <!--=====================-->
    <br />
    <div class="row">
        <div class="col-md-1"> </div>
        <div class="col-md-11"> 
            <h4>¿Considera usted que su caso es urgente?</h4>
        </div>
        <!--=====================-->
        <div class="col-md-1"> </div>
        <div class="col-md-6"> 
            <h5>Marque dentro del rango de 1 a 5 donde 5 es muy urgente y 1 poco urgente</h5>
        </div>
        <div class="col-md-1"> 
            <select class="form-control" ID="rbtnlcategorias" runat=server>
                <option value="1">1</option>
                <option value="2">2</option>
                <option value="3">3</option>
                <option value="4">4</option>
                <option value="5">5</option>
            </select>
        </div>
    </div><!--=====================-->
    <br />
    <div class="row">
        <div class="col-md-1"> </div>
        <div class="col-md-11">
            <h4>Si ha sido atendido complete lo siguiente:</h4>
        </div>
        <!--=====================-->
        <div class="col-md-1"></div>
        <div class="col-md-4">
            <h5>Nombre de la persona que lo atendi&oacute;:</h5>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txtNomPersonaAtendio" runat="server" style="width:100%;"  class="form-control" placeholder="Nombre"/>
        </div>
        <div class="col-md-4"></div>
    </div>
    <!--=====================-->
    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-4">
            <h5>Fecha de cuando fue antendido: </h5>
        </div>
        <div class="col-md-3">

            <!--
            hay que modificar el .cs para parsea la fecha
            -->
            
            <asp:TextBox runat="server" style="width:100%;" class="form-control" id="txtfechaAtencionPrevia" placeholder="dia-mes-a&ntilde;o"/>

        </div>
        <div class="col-md-4"></div>
    </div>
    <!--=====================-->
    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-4">
            <h5>¿Desea ser atendido de nuevo por esa persona?</h5>
        </div>
        <div class="col-md-3">
            <select class="form-control" ID="rbtnAtencion" runat=server>
                <option value="Si">Si</option>
                <option value="No">No</option>
            </select>
        </div>
    </div>
    <!--=====================-->
    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-7">
            <textarea runat="server" class="form-control" rows="4" cols="3" id="txtObservaciones" placeholder="Escriba su motivo aqu&iacute;"></textarea>
        </div>
        <div class="col-md-4"></div>
    </div>
    <!--=====================-->
    <br />
    <div class="row">
        <div class="col-md-5"></div>
        <div class="col-md-7">
            <asp:Button ID="btnSolicitarCita" class="btn btn-primary"  runat="server" Text="Enviar" onclick="btnSolicitarCita_Click" />
            <asp:Button Text="Mostrar Solicitudes"  class="btn btn-info" runat="server" ID="btnMostrarSolicitudes" onclick="btnMostrarSolicitudes_Click"/>
        </div>
    </div>
        <br />
    <br />
    <br />
</asp:Content>

