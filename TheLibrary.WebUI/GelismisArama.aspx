<%@ Page Title="" Language="C#" MasterPageFile="~/TheLibrary.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="GelismisArama.aspx.cs" Inherits="TheLibrary.WebUI.GelismisArama" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">

        <div class="grid-24">
            <div class="row">

                <div class="widget">
                    <div class="widget-content">

                        <asp:Label Text="Arama sonucunuzu daraltmak istediğiniz kriterleri seçiniz." runat="server" /><br />
                        <asp:CheckBox ID="chbYazar" Text="Yazar" AutoPostBack="true" runat="server" /><br />
                        <asp:CheckBox ID="chbYayinevi" Text="Yayınevi" AutoPostBack="true" runat="server" /><br />
                        <asp:CheckBox ID="chbTur" Text="Tür" AutoPostBack="true" runat="server" /><br />
                        <asp:CheckBox ID="chbRaf" Text="Raf Numarası" AutoPostBack="true" runat="server" />

                    </div>
                </div>

            </div>
        </div>


        <div class="grid-6">
            <div class="row">

                <div class="widget">
                    <div class="widget-content">

                        <asp:Panel ID="panelTur" Enabled="false" runat="server">  
                            <asp:Label Text="Lütfen bir tür seçiniz." runat="server" /><br />

                            <asp:DropDownList ID="cmbTur" runat="server">
                            </asp:DropDownList>
                        </asp:Panel>
          
                    </div>
                </div>

            </div>
        </div>
        <div class="grid-6">
            <div class="row">
                <div class="widget">
                    <div class="widget-content">

                        <asp:Panel ID="panelRaf" Enabled="false" runat="server">  
                            <asp:Label Text="Lütfen bir raf seçiniz." runat="server" /><br />

                            <asp:DropDownList ID="cmbRafNo" runat="server">
                            </asp:DropDownList>
                        </asp:Panel>

                    </div>
                </div>
            </div>
        </div>

        <div class="grid-6">
            <div class="row">

                <div class="widget">
                    <div class="widget-content">

                        <asp:Panel ID="panelKitapYazari" Enabled="false" runat="server">  
                            <asp:Label Text="Lütfen bir yazar seçiniz." runat="server" /><br />

                            <asp:DropDownList ID="cmbKitapYazari" runat="server">
                            </asp:DropDownList>
                        </asp:Panel>
                    </div>
                </div>
                
            </div>
        </div>

        <div class="grid-6">
                
            <div class="row">
                
                <div class="widget">
                    <div class="widget-content">

                        <asp:Panel ID="panelYayinEvi" Enabled="false" runat="server">
                            <asp:Label Text="Lütfen bir yayınevi seçiniz." runat="server" /><br />

                            <asp:DropDownList ID="cmbYayinEvi" runat="server">
                            </asp:DropDownList>
                        </asp:Panel>

                    </div>
                </div>
                <br />
                <asp:Button Text="Ara" ID="btnAra" CssClass="btn btn-purple" BorderColor="Black" OnClick="btnAra_Click" runat="server" />
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

    </div>
</asp:Content>
