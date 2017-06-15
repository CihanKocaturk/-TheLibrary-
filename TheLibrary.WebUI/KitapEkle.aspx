<%@ Page Title="" Language="C#" MasterPageFile="~/TheLibrary.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="KitapEkle.aspx.cs" Inherits="TheLibrary.WebUI.KitapEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="widget">
						
						<div class="widget-header">
							<span class="icon-article"></span>
							<h3>Kitap Kayıt</h3>
						</div> <!-- .widget-header -->
						
						<div class="widget-content">
							
							<form class="form uniformForm validateForm">
								
								<div class="field-group">
									<label>Kitap Adı:</label>
									<div class="field">
                                        <asp:TextBox type="text" ID="txtKitapAdi" runat="server" />  	
									</div>
								</div> <!-- .field-group -->   
                                <br />                           
								
                                <div class="field-group">		
									<label>Yazar Adı:</label>
			
									<div class="field">
										<asp:DropDownList ID="cmbKitapYazari" runat="server">
                                    </asp:DropDownList>
									</div>		
								</div> <!-- .field-group -->
                                <br />    
								<div class="field-group">
									<label>Basım Tarihi:</label>
									<div class="field">
										<asp:TextBox ID="dtpBasimTarihi" CssClass="datepicker" runat="server"></asp:TextBox>	
									</div>
								</div> <!-- .field-group -->
								<br />    
                                <div class="field-group">
									<label>ISBN No:</label>
									<div class="field">
                                        <asp:TextBox type="text" id="txtISBNNo" runat="server" />  	
									</div>
								</div>
                                <br />    
                                <div class="field-group">		
									<label>Türü:</label>
			
									<div class="field">
										<asp:DropDownList ID="cmbTur" runat="server">
                                    </asp:DropDownList>										
									</div>		
								</div>
                                <br />    
                                <div class="field-group">		
									<label>Raf Numarası:</label>
			
									<div class="field">
										<asp:DropDownList ID="cmbRafNo" runat="server">
                                    </asp:DropDownList>
									</div>		
								</div>
                                <br />    
                                <div class="field-group">		
									<label>Yayınevi:</label>
			
									<div class="field">
										<asp:DropDownList ID="cmbYayinEvi" runat="server">

                                    </asp:DropDownList>
									</div>		
								</div>
							    <br />    
								<div class="actions">						
                                    <asp:Button Text="Kaydet" ID="btnKaydet" CssClass="btn btn-secondary" OnClick="btnKaydet_Click" runat="server" />
								</div> <!-- .actions -->
								
							</form>
							
							
						</div> <!-- .widget-content -->
						
					</div>
    <script>
        $(function () {
            $(".datepicker").datepicker({ dateFormat: 'dd.mm.yy' });
            $(".datepicker_inline").datepicker();
        });

    </script>
</asp:Content>
