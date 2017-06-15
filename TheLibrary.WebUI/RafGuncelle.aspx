<%@ Page Title="" Language="C#" MasterPageFile="~/TheLibrary.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="RafGuncelle.aspx.cs" Inherits="TheLibrary.WebUI.RafGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="widget">
						
						<div class="widget-header">
							<span class="icon-article"></span>
							<h3>Raf Kayıt</h3>
						</div> <!-- .widget-header -->
						
						<div class="widget-content">
							
							<form class="form uniformForm validateForm">
								
								<div class="field-group">
									<label> Raf Numarası:</label>
									<div class="field">
                                        <asp:TextBox type="text" name="rafNo" id="txtRafNo" size="20" class="validate[required]" runat="server" />  	
									</div>
								</div> <!-- .field-group -->   
                                <br /> 
                                
                                <div class="field-group">		
									<label>Raf Türü:</label>
			
									<div class="field">
										<asp:DropDownList ID="cmbRafTuru" runat="server">
                                    </asp:DropDownList>
									</div>		
								</div>
                                
                                <br />                          	                                      
								<div class="actions">						
                                    <asp:Button Text="Güncelle" ID="btnGuncelle" CssClass="btn btn-secondary" OnClick="btnGuncelle_Click"  runat="server" />
								</div> <!-- .actions -->
								
							</form>
							
							
						</div> <!-- .widget-content -->
						
					</div>
</asp:Content>
