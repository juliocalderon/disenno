<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Promos.aspx.cs" Inherits="WebApplication6.Promos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="content" runat="server">
		<div class="container">
            <div class="row">
        	    <div class="col-md-12">
        				
        		    <div class="row">
        				    <div class="md-margin"></div>
							<h2>Nuestros Productos Especiales: </h2>
							
                            </div>
						</div>
                        <div id="contenedor" class="category-item-container category-list-container">
                            <asp:Panel ID="panelpromos1" runat="server"></asp:Panel>
                        </div>
					</div>
				</div>
			</form>
</asp:Content>
