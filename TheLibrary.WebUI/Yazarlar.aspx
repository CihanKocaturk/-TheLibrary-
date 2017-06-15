<%@ Page Title="" Language="C#" MasterPageFile="~/TheLibrary.Master" AutoEventWireup="true" CodeBehind="Yazarlar.aspx.cs" Inherits="TheLibrary.WebUI.Yazarlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="widget widget-table">

        <div class="widget-header">
            <span class="icon-list"></span>
            <h3 class="icon chart">Yazarlar</h3>
        </div>

        <div class="widget-content">

            <table class="table table-bordered table-striped data-table">
                <thead>
                    <tr>
                        <th>Yazar Adı</th>
                        <th>Yazar Soyadı</th>
                        <th>İşlemler</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="rptYazarlar" runat="server">
                        <ItemTemplate>
                            <tr class="gradeA">
                                <td>
                                    <%#Eval("FirstName") %>
                                </td>
                                <td>
                                    <%#Eval("LastName") %>
                                </td>
                                <td>
                                    <a href='<%#Eval("ID","YazarGuncelle.aspx?yazarID={0}") %>' class="btn btn-quaternary btn-small"><span class="icon-pen"></span>Düzenle</a><a href='<%#Eval("ID","Yazarlar.aspx?ID={0}") %>' class="btn btn-small btn-quaternary"><span class="icon-x"></span>Sil</a>
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
