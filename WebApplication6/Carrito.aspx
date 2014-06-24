<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebApplication6.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="content" runat="server">
				<div class="cols-a">
					<fieldset>
						<h2 class="header-b">Home / Compras / Mi Carrito</h2>
						<table class="table-b">
							<tr>                    	                                                    	        	           
								<th scope="col">Eliminar</th>
								<th scope="col">Imagen</th>
								<th scope="col">Producto</th>
								<th scope="col">Precio</th>
								<th scope="col">Cantidad</th>
								<th scope="col">Total</th>
							</tr>
						</table>

                        <div id="contenedor" class="category-item-container category-list-container">
                            <asp:Panel ID="panelcarrito" runat="server"></asp:Panel>
                        </div>

					</fieldset>
				</div>
			</form>
</asp:Content>