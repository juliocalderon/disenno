<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login-registro.aspx.cs" Inherits="WebApplication6.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="Content" runat="server">
				<div class="cols-a">
					<div style="margin: 0 auto;">
						<h3> Home / Mi Cuenta / Login o Registro de Cuenta </h3>
						<div class="double-c">
							<div method="post" class="form-b">
								<fieldset>
									<legend>Información Personal:</legend>
									<p>
										<label for="fba">Nombre</label>
										<asp:TextBox ID="inputnombre" type="text" runat="server"></asp:TextBox>
									</p>
									<p>
										<label for="fbb">Contraseña</label>
										<asp:TextBox ID="inputcontrasenna" type="password"  runat="server"></asp:TextBox>
									</p>
									<p class="submit">
                                        <asp:Button ID="Button2" runat="server" Text="Ingresar" OnClick="ingresar" />
										<a href="./">Olvidaste la Contraseña?</a>
									</p>
								</fieldset>
							</div>
							<div method="post" class="form-b">
								<fieldset>
									<legend>Registrarse</legend>
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
									<p class="submit">
                                        <asp:Button ID="Button1" runat="server" Text="Registrarse" OnClick="registrarme" />
									</p>
								</fieldset>
							</div>
						</div>
					</div>
				</div>
		</form>
</asp:Content>
