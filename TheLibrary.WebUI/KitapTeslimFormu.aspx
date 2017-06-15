<%@ Page Title="" Language="C#" MasterPageFile="~/TheLibrary.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="KitapTeslimFormu.aspx.cs" Inherits="TheLibrary.WebUI.KitapTeslimFormu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="widget">

        <div class="widget-header">
            <span class="icon-article"></span>
            <h3>Kitap Teslim Formu</h3>
        </div>
        <!-- .widget-header -->

        <div class="widget-content">

            <form class="form uniformForm validateForm">
                
                <br />

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
                            <th>Üye Adı</th>
                            <th>ISBN Numarası</th>
                            <th>Kitap Alım Tarihi</th>
                            <th>Son Teslim Tarihi</th>
                            <th>Personel Adı</th>
                            <th>Teslim Al</th>
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
                                        <%#Eval("Member.FullName") %>
                                    </td>
                                    <td>
                                        <%#Eval("Book.ISBNNo") %>
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
                                    <a href='<%#Eval("ID","KitapTeslimFormu.aspx?ID={0}") %>' class="btn btn-quaternary btn-small"><span class="icon-pen"></span>Teslim Al</a>
                                </td>                            
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>


            </div>
            <!-- .widget-content -->

        </div>
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
