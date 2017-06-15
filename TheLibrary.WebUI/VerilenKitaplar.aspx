<%@ Page Title="" Language="C#" MasterPageFile="~/TheLibrary.Master" AutoEventWireup="true" CodeBehind="VerilenKitaplar.aspx.cs" Inherits="TheLibrary.WebUI.VerilenKitaplar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="widget widget-table">

        <div class="widget-header">
            <span class="icon-list"></span>
            <h3 class="icon chart">Widget Table</h3>
        </div>

        <div class="widget-content">

            <table class="table table-bordered table-striped">
                <thead>
                    <tr>
                        <th>Kategori Adı</th>
                        <th>Açıklama</th>
                        <th>İşlemler</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="rptVerilenKitaplar" runat="server">
                        <ItemTemplate>
                            <tr class="gradeA">
                                <td>
                                    <%#Eval("CategoryName") %>
                                </td>
                                <td>
                                    <%#Eval("Description") %>
                                </td>
                                <td>
                                    <a href='<%#Eval("ID","KategoriGuncelle.aspx?catID={0}") %>' class="btn btn-quaternary btn-small"><span class="icon-pen"></span>Düzenle</a><a href='<%#Eval("ID","Kategoriler.aspx?cmd=delete&ID={0}") %>' class="btn btn-small btn-quaternary" onclick="return window.confirm('Silmek istediğinizden emin misiniz?')"><span class="icon-x"></span>Sil</a>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>


        </div>
        <!-- .widget-content -->

    </div>
    <!-- .widget -->
</asp:Content>
