<%@ Page Title="" Language="C#" MasterPageFile="~/TheLibrary.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="KitapKiralama.aspx.cs" Inherits="TheLibrary.WebUI.KitapKiralama" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="widget">

        <div class="widget-header">
            <span class="icon-article"></span>
            <h3>Kitap Verme Formu</h3>
        </div>
        <!-- .widget-header -->

        <div class="widget-content">

            <form class="form uniformForm validateForm">
                <div class="field-group">
                    <label>Verilen Kitap:</label>

                    <div class="field">
                        <asp:DropDownList ID="cmbVerilenKitap" runat="server">
                        </asp:DropDownList>
                    </div>
                </div>               
                <br />
                <div class="field-group inlineField">
                    <label>Teslim Tarihi:</label>
                    <div class="field">
                        <asp:TextBox ID="dtpExpireDate" CssClass="datepicker" runat="server"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="field-group">
                    <label>Üye Adı:</label>

                    <div class="field">
                        <asp:DropDownList ID="cmbMembers" runat="server">
                        </asp:DropDownList>
                    </div>
                </div>
                <br />
                <div class="field-group">
                    <label>Çalışan Adı:</label>

                    <div class="field">
                        <asp:DropDownList ID="cmbEmployees" runat="server">
                        </asp:DropDownList>
                    </div>
                </div>
                <br />
                <div class="actions">
                    <asp:Button Text="Kaydet" ID="btnKaydet" CssClass="btn btn-secondary" runat="server" OnClick="btnKaydet_Click" />
                </div>
                <!-- .actions -->

            </form>


        </div>
        <!-- .widget-content -->

    </div>

    <script>
        $(function () {
            $(".datepicker").datepicker({ dateFormat: 'dd.mm.yy' });
            $(".datepicker_inline").datepicker();
        });

    </script>
</asp:Content>
