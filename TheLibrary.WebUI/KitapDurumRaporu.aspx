<%@ Page Title="" Language="C#" MasterPageFile="~/TheLibrary.Master" AutoEventWireup="true" CodeBehind="KitapDurumRaporu.aspx.cs" Inherits="TheLibrary.WebUI.KitapDurumRaporu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">

        <div class="grid-24">
            <div class="row">

                <div class="widget">
                    <div class="widget-content">

                        <asp:Label Text="Arama sonucunuzu daraltmak istediğiniz kriterleri seçiniz." runat="server" /><br />
                        <asp:CheckBox ID="chbDisarda" Text="Ödünç verilmiş olan kitaplar" AutoPostBack="true" runat="server" /><br />
                        <asp:CheckBox ID="chbGecikmis" Text="Teslim tarihi gecikmiş kitaplar" AutoPostBack="true" runat="server" /><br />
                        <asp:CheckBox ID="chbGecTeslim" Text="Teslim tarihinden sonra teslim alınan kitaplar " AutoPostBack="true" runat="server" />

                    </div>
                </div>

            </div>
        </div>

        <div class="widget widget-table">

            <div class="widget-header">
                <span class="icon-list"></span>
                <h3 class="icon chart">Kitaplar</h3>
            </div>

            <div class="widget-content">

                <table class="table table-bordered table-striped data-table">
                    <thead>
                        <tr>
                            <th>Kitap Adı</th>
                            <th>Kitap Alım Tarihi</th>
                            <th>Teslim Tarihi</th>
                            <th>Personel Adı</th>
                            <th>Üye Adı</th>
                            <th>Teslim Ettiği Tarih</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="rptKitaplar" runat="server">
                            <ItemTemplate>
                                <tr class="gradeA">
                                    <td>
                                        <%#Eval("Book.Name") %>
                                    </td>                                    
                                    <td>
                                        <%#Eval("DateOfBorrow") %>
                                    </td>
                                    <td>
                                        <%#Eval("ExpireDate") %>
                                    </td>
                                    <td>
                                        <%#Eval("Employee.FullName") %>
                                    </td>
                                    <td>
                                        <%#Eval("Member.FullName") %>
                                    </td>
                                    <td>
                                        <%#Eval("DateOfReturn") %>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>


            </div>
            <!-- .widget-content -->

        </div>

    </div>
</asp:Content>
