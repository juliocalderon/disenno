<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="WebApplication6.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        function redireccion(sender) {
            var valor = window.event.srcElement.getAttribute("Value1")
            var doc = document.getElementById(window.event.srcElement.getAttribute("id") + 1)
            var pagina = 'http://localhost:6409/' + valor + '&val2=' + doc.value
            window.setTimeout(function() {
            window.location = pagina;},0);
        }
    </script>

    <form id="content" runat="server">
		<div class="container">
            <div class="row">
        	    <div class="col-md-12">
        				
        		    <div class="row">
        				    <div class="md-margin"></div>
                        	
                        <div id="contenedor" class="category-item-container category-list-container">
                            <asp:Panel ID="panelproductos1" runat="server"></asp:Panel>
                        </div>


					</div>
							
				</div>
                </div>
            </div>
			</form>

            <form action="https://www.paypal.com/cgi-bin/webscr" method="post" target="_top">
            <input type="hidden" name="cmd" value="_xclick">
            <input type="hidden" name="business" value="machameche@gmail.com">
            <input type="hidden" name="lc" value="ES">
            <input type="hidden" name="item_name" value="Queque con Fresas">
            <input type="hidden" name="item_number" value="1">
            <input type="hidden" name="amount" value="35.00">
            <input type="hidden" name="currency_code" value="EUR">
            <input type="hidden" name="button_subtype" value="services">
            <input type="hidden" name="no_note" value="0">
            <input type="hidden" name="tax_rate" value="1.000">
            <input type="hidden" name="shipping" value="2.00">
            <input type="hidden" name="bn" value="PP-BuyNowBF:btn_buynowCC_LG.gif:NonHostedGuest">
            <input type="image" src="https://www.paypalobjects.com/es_ES/ES/i/btn/btn_buynowCC_LG.gif" border="0" name="submit" alt="PayPal. La forma rápida y segura de pagar en Internet.">
            <img alt="" border="0" src="https://www.paypalobjects.com/es_ES/i/scr/pixel.gif" width="1" height="1">
            </form>


</asp:Content>
