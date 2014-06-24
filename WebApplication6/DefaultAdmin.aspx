<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="DefaultAdmin.aspx.cs" Inherits="WebApplication6.DefaultAdmin2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent2" runat="server">
    <form id="content" runat="server">
        <h2>Pagina Administrador</h2>
		<article class="triple-a">
			<div>
				<asp:Button ID="ModificarProductosAdmin" runat="server" Text="Administrar Productos" OnClick="ModificarProductos" />
			</div>	
			<div>
                <asp:Button ID="ModificarInventario" runat="server" Text="Administrar Inventario" OnClick="AdministrarInventario" />
			</div>	
			<div>
			    <asp:Button ID="ModificarPromociones" runat="server" Text="Administrar Promociones" OnClick="AdministrarPromociones" />	
			</div>
		</article>
        <div>
		    <asp:Button ID="ModificarUsuarios" runat="server" Text="Administrar Administradores" OnClick="AdministrarUsuarios" />	
		</div>	
	</form>
</asp:Content>
