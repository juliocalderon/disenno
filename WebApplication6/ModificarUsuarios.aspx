<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="ModificarUsuarios.aspx.cs" Inherits="WebApplication6.ModificarUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent2" runat="server">
    <form id="Content" runat="server">
                                    <p>
										<label for="fbc">Nombre</label>
										<asp:TextBox ID="inputnombrere" type="text" runat="server"></asp:TextBox>
									</p>
									<p class="error">
										<label for="fbd">Email</label>
										<asp:TextBox ID="inputemail" type="email" runat="server"></asp:TextBox>
									</p>
									<p>
										<label for="fbe">NombreLogin</label>
										<asp:TextBox ID="inputnombrelogin" type="text" runat="server"></asp:TextBox>
									</p>
									<p>
										<label for="fbf">Contraseña</label>
										<asp:TextBox ID="inputconfircontra" type="password" runat="server"></asp:TextBox>
									</p>
                                    <p>
										<label for="fbe">Confirmar contraseña</label>
										<asp:TextBox ID="inputconfirmacontra" type="password" runat="server"></asp:TextBox>
									</p>
                                    <p>
										<label for="fbe">Direccion</label>
										<asp:TextBox ID="direccion" type="text" runat="server"></asp:TextBox>
									</p>
                                    <p>
										<label for="fbe">Cedula</label>
										<asp:TextBox ID="inputcedula" type="text" runat="server"></asp:TextBox>
									</p>
                                    <p>
										<label for="fbe">Telefono</label>
										<asp:TextBox ID="inputtelefono" type="text" runat="server"></asp:TextBox>
									</p>
        </form>
</asp:Content>
