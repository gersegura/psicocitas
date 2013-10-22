<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="ModificarHorario.aspx.cs" Inherits="ITCR.PsicoCitas.Interfaz._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <link href="bootstrap/dist/css/bootstrap.css" rel="stylesheet" type="text/css" />
    <title>Horario de Disponibilidad</title>

</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="row mostrar">
        <div class="col-md-2"></div>
        <div class="col-md-3">
            <h3 style="color: #00386b">Seleccione un D&iacute;a</h3>
        </div>
        <div class="col-md-3">        
            <br />
            
        <asp:DropDownList ID="DropDownList1" runat="server" onselectedindexchanged="Cambiardia" 
           ontextchanged="Cambiardia" AutoPostBack="True" CssClass="form-control">

        </asp:DropDownList>
            
  
        </div>
    </div>

    <!---====================-->
    <!---cuadro base         -->
    <!---====================-->

    <div class="row mostrar">
        <div class="col-md-1"></div><!--espacio vacio-->
        <div class="col-md-10">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                onselectedindexchanged="Eliminar_Bloque" Height="400px" Width="100%" 
                DataKeyNames="ID">
                <HeaderStyle BackColor="#00386b" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                <Columns>
                    <asp:BoundField AccessibleHeaderText="Dia" DataField="Dia" HeaderText="D&iacute;a" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="Hora Inicio" HeaderText="Hora Inicio" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="Hora Final" HeaderText="Hora Final" ItemStyle-HorizontalAlign="Center"/>
                    <asp:CommandField ButtonType="Button" SelectText="Eliminar" ShowSelectButton="True" ItemStyle-HorizontalAlign="Center" />
                </Columns>
            </asp:GridView>
        </div>
        <div class="col-md-1"></div><!--espacio vacio-->
    </div>

    <div class="row mostrar">
        <div class="col-md-2"></div>
        <div class="col-md-10">
            <h3>Agregar Nuevo Bloque</h3>
        </div><!--titulo-->
    </div>
    <!--=============================================-->
    <div class="row">
        <div class="col-md-2"></div><!--espacio vacio-->
        <div class="col-md-2"><h5>D&iacute;a:</h5></div>
        <div class="col-md-2">
            <!--===============================-->
            <!--dia seleccionado               -->
            <!--===============================-->
            <select runat="server" class="form-control"  ID="Dias2">
                <option value="Lunes">Lunes</option>
                <option value="Martes">Martes</option>
                <option value="Miercoles">Miercoles</option>
                <option value="Jueves">Jueves</option>
                <option value="Viernes">Viernes</option>
            </select>
        </div>
    </div>
    <!--=============================================-->
    <div class="row">
        <div class="col-md-2"></div><!--espacio vacio-->
        <div class="col-md-2"><h5>Hora Inicio:</h5></div>
        <div class="col-md-2">
            <!--===============================-->
            <!--hora de finalizacion           -->
            <!--===============================-->
            <select runat="server" class="form-control"  ID="horainicio2">
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
        <div class="col-md-2">
            <select runat="server" class="form-control"  ID="MinutosInicio">
                <option value="00">00</option>
                <option value="15">15</option>
                <option value="30">30</option>
                <option value="45">45</option>
            </select>
        </div>
    </div>
    <!--=============================================-->
    <div class="row">
        <div class="col-md-2"></div><!--espacio vacio-->
        <div class="col-md-2"><h5>Hora Final:</h5></div>
        <div class="col-md-2">
            <!--===============================-->
            <!--hora de finalizacion           -->
            <!--===============================-->
            <select runat="server" class="form-control"  ID="HoraFinal">
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
        <div class="col-md-2">
            <select runat="server" class="form-control"  ID="MinutosFinal">
                <option value="00">00</option>
                <option value="15">15</option>
                <option value="30">30</option>
                <option value="45">45</option>
            </select>
        </div>
    </div>
        <!--=============================================-->
    <div class="row">
        <div class="col-md-2"></div><!--espacio vacio-->
        <div class="col-md-2">
            <asp:button runat=server type="button" class="btn btn-primary" ID="Button1" onclick="Button1_Click" Text="Agregar Bloque"/>
        </div>
    </div>
    <br />
    <br />
    <br />
</asp:Content>
