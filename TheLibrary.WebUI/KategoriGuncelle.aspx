<%@ Page Title="" Language="C#" MasterPageFile="~/TheLibrary.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="KategoriGuncelle.aspx.cs" Inherits="TheLibrary.WebUI.KategoriGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="widget">

        <div class="widget-header">
            <span class="icon-article"></span>
            <h3>Tür Güncelle</h3>
        </div>
        <!-- .widget-header -->

        <div class="widget-content">

            <form class="form uniformForm validateForm">

                <div class="field-group">
                    <label>Tür Adı:</label>
                    <div class="field">
                        <asp:TextBox type="text" ID="txtTurAdi" runat="server" />
                    </div>
                </div>
                <!-- .field-group -->
                <br />

                <div class="field-group">
                    <label>Tür Açıklaması:</label>
                    <div class="field">
                        <asp:TextBox type="text" ID="TxtTurAciklamasi" runat="server" />
                    </div>
                </div>
                <br />

                <div class="actions">
                    <asp:Button Text="Güncelle" ID="btnGuncelle" CssClass="btn btn-secondary" OnClick="btnGuncelle_Click" runat="server" />
                </div>
                <!-- .actions -->

            </form>


        </div>
        <!-- .widget-content -->

    </div>

</asp:Content>
