<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="checkout.aspx.cs" Inherits="WebApplication6.checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="content" runat="server">
				<div class="cols-a">
					<div>
                        <div>
                            <div id="contenedor" class="category-item-container category-list-container">
                            <asp:Panel ID="panelhistorial1" runat="server"></asp:Panel>
                        </div>
                        </div>
						<div>
							<h3>Modos de Pago: </h3>
							<ul class="check-a">
								<li><label for="cac"><input type="radio" id="cac" name="caa"> Pay pal</label> </li>
							</ul>
							<p class="submit"><button type="submit">Finish</button></p>
						</div>
                    </div>
				</div>
			</form>
</asp:Content>
