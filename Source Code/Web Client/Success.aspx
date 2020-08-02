<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Success.aspx.cs" Inherits="SiOAS.Success" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- TITLE -->
    <title>QUIZ&nbsp&nbsp|&nbsp&nbsp SiOAS
    </title>
    <!-- MOBILE VIEW ADJUSTMENT TAG -->
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0, shrink-to-fit=no' name='viewport' />
    <!-- FAVICON ICON -->
    <link rel="icon" type="image/png" href="Resource/Images/logo.png" />
    <!-- FONTS  & ICONS -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons|Pacifico&display=swap" type="text/css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css" />
    <!-- STYLESHEET -->
    <link rel="stylesheet" href="Resource/Styles/styles.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="min-width:400px; width:80vw; margin-left:auto; margin-right:auto;">
            <div class="main main-raised" style="margin-top:60px; height:80%; margin-bottom: 60px; z-index: 1">
                <div class="row" >
                    <div class="col-md-8 ml-auto mr-auto">
                        <div class="update-progress" >
                            <br />
                            <br />
                            <div style="width: 80px; position: center; margin-left: auto; margin-right: auto;">
                                <img src="Resource/Images/tick.png" height="80" width="80" />
                            </div>
                            <div style="text-align: center; padding-top: 20px;">
                                <a style="padding-top: 60px; font-family: Calibri; font-size: 30px; font-weight: 600;">Success!</a>
                            </div>
                            <br />
                            <p style="text-align: center; font-family: Verdana, Roboto; padding-left: 8px; font-size: 15px; font-weight: 400">
                                You submission is complete.<br />
                                You can verify your details from the information page.
                            </p>
                            <div class="container-fluid text-center" style="margin-bottom: 30vh; margin-top:100px;">
                                <div>
                                    <asp:Button ID="Download" CssClass="btn btn-rose" runat="server" Text="📄 Download PDF" OnClick="Download_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
