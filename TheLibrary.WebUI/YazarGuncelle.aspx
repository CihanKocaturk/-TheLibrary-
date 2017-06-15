<%@ Page Title="" Language="C#" MasterPageFile="~/TheLibrary.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="YazarGuncelle.aspx.cs" Inherits="TheLibrary.WebUI.YazarGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="widget">

        <div class="widget-header">
            <span class="icon-article"></span>
            <h3>Yazar Düzenle</h3>
        </div>
        <!-- .widget-header -->

        <div class="widget-content">

            <form class="form uniformForm validateForm">

                <div class="field-group">
                    <label for="yazarAdi">Yazar Adı:</label>
                    <div class="field">
                        <asp:TextBox type="text" ID="txtYazarAdi" runat="server" />
                    </div>
                </div>
                <!-- .field-group -->
                <br />

                <div class="field-group">
                    <label for="yazarSoyadi">Yazar Soyadı:</label>
                    <div class="field">
                        <asp:TextBox type="text"  ID="txtYazarSoyadi" runat="server" />
                    </div>
                </div>
                <br />

                <div class="actions">
                    <asp:Button Text="Güncelle" ID="btnGuncelle" CssClass="btn btn-secondary"  OnClick="btnGuncelle_Click"  runat="server" />            
                </div>           
            </form>
        </div>     
    </div>

</asp:Content>
