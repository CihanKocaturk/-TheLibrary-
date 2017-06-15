<%@ Page Title="" Language="C#" MasterPageFile="~/TheLibrary.Master" AutoEventWireup="true" CodeBehind="Kitaplar.aspx.cs" Inherits="TheLibrary.WebUI.Kitaplar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
                        <th>Kitap Yazarı</th>
                        <th>ISBN</th>
                        <th>Basım Tarihi</th>
                        <th>Raf Numarası</th>
                        <th>Yayınevi</th>
                        <th>Türü</th>
                        <th>İşlemler</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="rptKitaplar" runat="server">
                        <ItemTemplate>
                            <tr class="gradeA">
                                <td>
                                    <%#Eval("Name") %>
                                </td>
                                <td>
                                    <%#Eval("Author.FullName") %>
                                </td>
                                <td>
                                    <%#Eval("ISBNNO") %>
                                </td>
                                <td>
                                    <%#Eval("DateOfPublish") %>
                                </td>
                                <td>
                                    <%#Eval("Shelf.ShelfNo") %>
                                </td>
                                <td>
                                    <%#Eval("Publisher.Name") %>
                                </td>
                                <td>
                                    <%#Eval("Category.Name") %>
                                </td>
                                <td>
                                    <a href='<%#Eval("ID","KitapGuncelle.aspx?bookID={0}") %>' class="btn btn-quaternary btn-small"><span class="icon-pen"></span>Düzenle</a><a href='<%#Eval("ID","Kitaplar.aspx?ID={0}") %>' class="btn btn-small btn-quaternary"><span class="icon-x"></span>Sil</a>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>


        </div>
        <!-- .widget-content -->

    </div>

</asp:Content>
