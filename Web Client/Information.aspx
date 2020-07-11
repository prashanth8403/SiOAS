<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Information.aspx.cs" Inherits="SiOAS.Information" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <!-- TITLE -->
    <title>Instructions&nbsp&nbsp|&nbsp&nbsp SiOAS
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
<body onload="window.open('fullScreenPage.html, '', 'fullscreen=yes, scrollbars=auto');">
    <form id="form1" runat="server">
        <div class="container">
            <div class="main main-raised" style="margin-top: 60px; margin-bottom: 50px; z-index: 1">
                <div class="row">
                    <div class="col-md-8 ml-auto mr-auto">
                        <div class="brand" style="margin-left: 30px; margin-right: 30px;">
                            <h1 style="user-select: none; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">SiOAS</h1>
                            <h3>INSTRUCTIONS</h3>
                            <div>
                                <hr />
                                1. All questions are mandatory.
                                <hr />
                                2. Make sure you click the submit button. Don't close the tab without submitting.
                                 <hr />
                                3. Don't refresh or post back the page once you start the quiz.
                                <hr />
                                4. After Submission a PDF will be downloaded automatically, the same would be used for record purpose.
                                <hr />
                                5.  <a style="color: #ff0000;">In case of any error, close all brower page(s) and start afresh.</a>
                            </div>
                            <br />
                            <br />
                            <div style="width:150px; margin-left:auto;margin-right:auto; position:center;">
                                <asp:Button ID="InstrBtn" CssClass="btn btn-warning" runat="server" Text="START QUIZ" OnClick="InstrBtn_Click" />
                                <br />
                                <br />
                                <br />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div>
        </div>
    </form>
</body>
<script>
    window.onload = Fullscreen();
    function esc(e) {
        e = e || window.event || {};
        var charCode = e.charCode || e.keyCode || e.which;
        if (charCode == 27) {
            return false;
        }
    }
    function Fullscreen() {
        document.documentElement.requestFullscreen();
    }
</script>
</html>
