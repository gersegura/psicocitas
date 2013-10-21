<%@ Page Language="C#" MasterPageFile="~/Site.master" 
AutoEventWireup="true" CodeBehind="AdministrarDocumentos.aspx.cs" Inherits="ITCR.PsicoCitas.Interfaz.AdministrarDocumentos" %>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <title>AdministrarDocumentos</title>
    <link href="bootstrap/js/dropdown.js" rel="stylesheet" type="text/css" />

</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="row">
        <div class="col-md-12"><h1>Administrar Documentos</h1></div>
        <!--=========================================-->
        <!--=================carrucel================-->
        <!--=========================================-->
        <div class="col-md-1"></div>
        <div class="col-md-10">
            <div id="carousel-example-generic" class="carousel slide" style="width:100%;">
                <!-- Indicators -->
                <ol class="carousel-indicators">
                    <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                    <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                    <li data-target="#carousel-example-generic" data-slide-to="2"></li>
                    <li data-target="#carousel-example-generic" data-slide-to="3"></li>
                </ol>

                <!-- Wrapper for slides -->
                <div class="carousel-inner">
                    <div class="item active">
                        <img src="imagenes/rojo.png" alt="primera imagen" style="width:100%; height:100%;" >
                    </div>
                    <div class="item">
                        <img src="imagenes/verde.png" alt="segunda imagen" style="width:100%; height:100%;" >
                    </div>
                    <div class="item">
                        <img src="imagenes/azul.png" alt="tercer imagen" style="width:100%; height:100%;" >
                    </div>
                    <div class="item">
                        <img src="imagenes/cafe.png" alt="cuarta imagen" style="width:100%; height:100%;" >
                    </div>
                </div>

                <!-- Controls -->
                <a class="left carousel-control" href="#carousel-example-generic" data-slide="prev">
                    <span class="icon-prev"></span>
                </a>
                <a class="right carousel-control" href="#carousel-example-generic" data-slide="next">
                    <span class="icon-next"></span>
                </a>
            </div>
        </div>
        <div class="col-md-1"></div>
        <!--=========================================-->
        <!--=================carrucel================-->
        <!--=========================================-->
    </div>
    <div class="row">
        <div class="col-md-12"><h4>Eliga el Documento que desee subir.</h4></div>
        <div class="col-md-5">
            <asp:FileUpload ID="FileUpload1" runat="server" class="btn btn-primary" />
        </div>
        <div class="col-md-7">
            <asp:Button ID="btnSubirArchivo" runat="server" Text="Subir Archivo" onclick="btnSubirArchivo_Click"  class="btn btn-primary"/>
            <asp:Button Text="Cancelar"  ID="btnCancelar" runat="server"  class="btn btn-info"/>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12"><h4>Documentos Actuales</h4></div>
        <div class="col-md-1"></div><!-- espacio -->
        <div class="col-md-10">
        <asp:RegularExpressionValidator 
             id="RegularExpressionValidator1" runat="server" 
             ErrorMessage="Solo documentos en pdf, son permitidos." 
             ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.pdf)$" 
             ControlToValidate="FileUpload1"
             class="alert alert-danger">
        </asp:RegularExpressionValidator>
            
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
            ForeColor="#333333" GridLines="None" onrowdeleting="GridView1_RowDeleting" DataKeyNames="Name">
            <RowStyle BackColor="#EFF3FB" />
            <Columns>
               <asp:TemplateField HeaderText="Eliminar Documento" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <asp:ImageButton ID="imgEliminar" runat="server" CommandName="Delete"  ImageUrl="imagenes/delete.png" Width="24px" Height="24px"/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nombre del Documento">
                    <ItemTemplate>
                        <asp:HyperLink ID="nombre" runat="server" NavigateUrl='<%# Eval("Name", "/files/{0}") %>'
                            Text='<%# Eval("Name") %>'>
                        </asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Length" HeaderText="Tamaño del Documento" />
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




