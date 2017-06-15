<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" EnableEventValidation="false" Inherits="TheLibrary.WebUI.Login" %>

<!DOCTYPE html>

<!--[if lt IE 7]> <html class="no-js ie6 oldie" lang="en"> <![endif]-->
<!--[if IE 7]>    <html class="no-js ie7 oldie" lang="en"> <![endif]-->
<!--[if IE 8]>    <html class="no-js ie8 oldie" lang="en"> <![endif]-->
<!--[if gt IE 8]><!-->
<html class="no-js" lang="en">
<!--<![endif]-->
<head>

    <title>Canvas Admin - Login</title>

    <meta charset="utf-8" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <meta name="viewport" content="width=device-width,initial-scale=1" />

    <link rel="stylesheet" href="Admin/stylesheets/reset.css" type="text/css" media="screen" title="no title" />
    <link rel="stylesheet" href="Admin/stylesheets/text.css" type="text/css" media="screen" title="no title" />
    <link rel="stylesheet" href="Admin/stylesheets/buttons.css" type="text/css" media="screen" title="no title" />
    <link rel="stylesheet" href="Admin/stylesheets/theme-default.css" type="text/css" media="screen" title="no title" />
    <link rel="stylesheet" href="Admin/stylesheets/login.css" type="text/css" media="screen" title="no title" />
</head>

<body>

    <div id="login">
        <h1>Dashboard</h1>
        <div id="login_panel">
            <form class="form uniformForm validateForm" runat="server">
                <div class="login_fields">
                    <div class="field">
                        <label>Kullanıcı Adı</label>
                        <asp:TextBox type="text" name="txtKullaniciAdi" ID="txtKullaniciAdi" size="20" runat="server" />
                    </div>

                    <div class="field">
                        <label>Şifre</label>
                        <asp:TextBox type="password" name="txtSifre" ID="txtSifre" size="20" runat="server" />
                    </div>
                </div>
                <!-- .login_fields -->

                <div class="login_actions">
                    <asp:Button Text="Giriş Yap" CssClass="btn btn-primary" ID="btnGirisYap" OnClick="btnGirisYap_Click" runat="server" />
                </div>
            </form>
        </div>
        <!-- #login_panel -->
    </div>
    <!-- #login -->

    <script src="Admin/javascripts/all.js"></script>


</body>
</html>
