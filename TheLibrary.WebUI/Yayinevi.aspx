<%@ Page Title="" Language="C#" MasterPageFile="~/TheLibrary.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="Yayinevi.aspx.cs" Inherits="TheLibrary.WebUI.Yayinevi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="widget">
						
						<div class="widget-header">
							<span class="icon-article"></span>
							<h3>Yayınevi Kayıt</h3>
						</div> <!-- .widget-header -->
						
						<div class="widget-content">
							
							<form class="form uniformForm validateForm">
								
								<div class="field-group">
									<label for="yayineviAdi"> Yayınevi Adı:</label>
									<div class="field">
                                        <asp:TextBox type="text" id="txtYayineviAdi" size="20" class="validate[required]" runat="server" />  	
									</div>
								</div> <!-- .field-group -->   
                                <br />                           	  
                                    
								<div class="actions">						
									<asp:Button Text="Kaydet" ID="btnKaydet" CssClass="btn btn-secondary" OnClick="btnKaydet_Click" runat="server" />
								</div> <!-- .actions -->
								
							</form>
							
							
						</div> <!-- .widget-content -->
						
					</div>

</asp:Content>
