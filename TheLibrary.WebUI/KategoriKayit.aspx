<%@ Page Title="" Language="C#" MasterPageFile="~/TheLibrary.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="KategoriKayit.aspx.cs" Inherits="TheLibrary.WebUI.KategoriKayit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="widget">
						
						<div class="widget-header">
							<span class="icon-article"></span>
							<h3>Tür Kayıt</h3>
						</div> <!-- .widget-header -->
						
						<div class="widget-content">
							
							<form class="form uniformForm validateForm">
								
								<div class="field-group">
									<label> Tür Adı:</label>
									<div class="field">
                                        <asp:TextBox type="text" id="txtTurAdi" runat="server" />  	
									</div>
								</div> <!-- .field-group -->   
                                <br />                           
					 
                                <div class="field-group">
									<label>Tür Açıklaması:</label>
									<div class="field">
                                        <asp:TextBox type="text" id="TxtTurAciklamasi" runat="server" />  	
									</div>
								</div>
                                <br />    
                                    
								<div class="actions">						
                                    <asp:Button Text="Tür Ekle" ID="btnKaydet" CssClass="btn btn-secondary" OnClick="btnKaydet_Click"  runat="server" />
								</div> <!-- .actions -->
								
							</form>
							
							
						</div> <!-- .widget-content -->
						
					</div>

</asp:Content>
