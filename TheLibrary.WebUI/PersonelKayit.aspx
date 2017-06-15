<%@ Page Title="" Language="C#" MasterPageFile="~/TheLibrary.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="PersonelKayit.aspx.cs" Inherits="TheLibrary.WebUI.PersonelKayit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="widget">
						
						<div class="widget-header">
							<span class="icon-article"></span>
							<h3>Personel Kayıt</h3>
						</div> <!-- .widget-header -->
						
						<div class="widget-content">
							
							<form class="form uniformForm validateForm">
								
								<div class="field-group">
									<label> TC Numarası:</label>
									<div class="field">
                                        <asp:TextBox type="text" id="txtTCNo" size="11" runat="server" />  	
									</div>
								</div> <!-- .field-group -->   
                                <br />                           
					 
                                <div class="field-group">
									<label>Personel Adı:</label>
									<div class="field">
                                        <asp:TextBox type="text" id="txtAdi" runat="server" />  	
									</div>
								</div>
                                <br /> 
                                
                                <div class="field-group">
									<label> Personel Soyadı:</label>
									<div class="field">
                                        <asp:TextBox type="text" id="txtSoyadi" runat="server" />  	
									</div>
								</div>
                                <br />
                                
                                <div class="field-group">
									<label > Cep Numarası:</label>
									<div class="field">
                                        <asp:TextBox type="number" id="txtCepNo" size="11" runat="server" />                                               	
									</div>
								</div>
                                <br />
                                
                                <div class="field-group">
									<label > Adres:</label>
									<div class="field">
                                        <asp:TextBox type="text" id="txtAdres" runat="server" />  	
									</div>
								</div>
                                <br />
                                <div class="field-group">
									<label > Kullanıcı Adı:</label>
									<div class="field">
                                        <asp:TextBox type="text" id="txtKullaniciAdi" runat="server" />  	
									</div>
								</div>
                                <br />
                                <div class="field-group">
									<label > Şifre:</label>
									<div class="field">
                                        <asp:TextBox type="password" id="txtSifre" runat="server" />  	
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
