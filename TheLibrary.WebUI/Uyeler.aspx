<%@ Page Title="" Language="C#" MasterPageFile="~/TheLibrary.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="Uyeler.aspx.cs" Inherits="TheLibrary.WebUI.Uyeler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="widget widget-table">

        <div class="widget-header">
            <span class="icon-list"></span>
            <h3 class="icon chart">Üyeler</h3>
        </div>

        <div class="widget-content">

            <table class="table table-bordered table-striped data-table">
                <thead>
                    <tr>
                        <th>TC Numarası</th>
                        <th>Adı</th>
                        <th>Soyadı</th>
                        <th>Numarası</th>
                        <th>Adresi</th>
                        <th>İşlemler</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="rptUyeler" runat="server">
                        <ItemTemplate>
                            <tr class="gradeA">
                                <td>
                                    <%#Eval("TCNo") %>
                                </td>
                                <td>
                                    <%#Eval("FirstName") %>
                                </td>
                                <td>
                                    <%#Eval("LastName") %>
                                </td>
                                <td>
                                    <%#Eval("Phone") %>
                                </td>
                                <td>
                                    <%#Eval("Address") %>
                                </td>
                                <td>
                                    <a href='<%#Eval("ID","UyeGuncelle.aspx?memberID={0}") %>' class="btn btn-quaternary btn-small"><span class="icon-pen"></span>Düzenle</a><a href='<%#Eval("ID","Uyeler.aspx?ID={0}") %>' class="btn btn-small btn-quaternary"><span class="icon-x"></span>Sil</a>
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
