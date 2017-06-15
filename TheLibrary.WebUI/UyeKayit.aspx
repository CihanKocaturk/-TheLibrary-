<%@ Page Title="" Language="C#" MasterPageFile="~/TheLibrary.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="UyeKayit.aspx.cs" Inherits="TheLibrary.WebUI.UyeKayit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="widget">
						
						<div class="widget-header">
							<span class="icon-article"></span>
							<h3>Üye Kayıt</h3>
						</div> <!-- .widget-header -->
						
						<div class="widget-content">
							
							<form class="form uniformForm validateForm">
								
								<div class="field-group">
									<label> TC Numarası:</label>
									<div class="field">
                                        <asp:TextBox type="text" id="txtTCNo" size="20" class="validate[required]" runat="server" />  	
									</div>
								</div> <!-- .field-group -->   
                                <br />                           
					 
                                <div class="field-group">
									<label for="uyeAdi">Üye Adı:</label>
									<div class="field">
                                        <asp:TextBox type="text" name="uyeAdi" id="txtAdi" size="20" class="validate[required]" runat="server" />  	
									</div>
								</div>
                                <br /> 
                                
                                <div class="field-group">
									<label> Üye Soyadı:</label>
									<div class="field">
                                        <asp:TextBox type="text" id="txtSoyadi" size="20" class="validate[required]" runat="server" />  	
									</div>
								</div>
                                <br />
                                
                                <div class="field-group">
									<label> Cep Numarası:</label>
									<div class="field">
                                        <asp:TextBox type="text" ID="txtCepNo" size="20" class="validate[required]" runat="server" />                                               	
									</div>
								</div>
                                <br />
                                
                                <div class="field-group">
									<label> Adres:</label>
									<div class="field">
                                        <asp:TextBox type="text" id="txtAdres" size="20" class="validate[required]" runat="server" />  	
									</div>
								</div>
                                <br />   
                                    
								<div class="actions">						
                                    <asp:Button Text="Kaydet" ID="btnKaydet" CssClass="btn btn-secondary" OnClick="btnKaydet_Click" runat="server" />
								</div> <!-- .actions -->
								
							</form>
							
							
						</div> <!-- .widget-content -->
						
					</div>

</asp:Content>
