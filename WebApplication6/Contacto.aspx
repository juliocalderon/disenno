<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="WebApplication6.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section id="content">
				<div class="cols-a">
					<article>
						<h3>Contact Details:</h3>
						<p>The contact form is functional below powered by Javascript and PHP script packaged with the template. You can test it. Please enter valid email address below and check the checkbox on bottom to have the email sent to you. The information you enter here is not being saved anywhere and will never be misused for any means.</p>
						
						<div id="alert">
								<div class="message"></div>
						</div>
						
						<form onSubmit="return submitForm();" action="" method="post" class="form-a" name="homefrm1" id="homefrm1">
						   <input type="hidden"  name="event" value="start" />
							<fieldset>
								<legend>Send us a e-mail:</legend>
								<p>
									<span>
										<label for="ca">Your name:</label>
										<input type="text" id="ca" name="name" required>
									</span>
									<span>
										<label for="cb">Your email:</label>
										<input type="text" id="cb" name="email" required>
									</span>
								</p>
								<p>
									<label for="cd">Subject:</label>
									<input name="subject" type="text" id="cd" required>
								</p>
								<p>
									<label for="cc">Message:</label>
									<textarea id="cc" name="msg" required></textarea>
								</p>
								<p class="contact-check"> <input type="checkbox" name="copyemail_check" />Send copy to email you entered above?</p>
								<p><button type="submit">Send</button></p>
							</fieldset>
						</form>
					</article>
					<aside class="vcard">
						<h3>Contact Info:</h3>
						<h4 class="fn org">Just the best CAKES company</h4>
						<p class="tel">9876.543.210</p>
						<p><a class="email">info//loremipsum/com</a></p>
						<p class="adr"><span class="locality">London</span>, <span class="street-address">Street 28/A</span></p>
					</aside>
				</div>
			</section>
</asp:Content>
