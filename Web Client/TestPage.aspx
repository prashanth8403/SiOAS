<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestPage.aspx.cs" Inherits="SiOAS.TestPage" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta charset="utf-8" />
    <link rel="icon" type="image/png" href="Resource/Images/logo.png" />
    <title>Instruction&nbsp&nbsp|&nbsp&nbsp SiOAS
    </title>
    <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css" />
    <link href="Resource/Styles/styles.css" rel="stylesheet" />
</head>
<body onload="Fullscreen()">
    <form id="form1" runat="server">
        <div class="container">
            <div class="main main-raised" style="margin-top: 60px; margin-bottom: 50px; z-index: 1">
                <div class="row">
                    <div class="col-md-8 ml-auto mr-auto">
                        <div class="brand" style="margin-left: 30px; margin-right: 30px;">
                            <h1 style="user-select: none; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">SiOAS</h1>
                            <h3>INSTRUCTIONS</h3>
                            <p style="text-align: justify">
                                <hr />
                                1. This Quiz consists of 30 Questions. All questions are mandatory.
                                 <hr />
                                2. Make sure you click the submit button. Don't close the tab without submitting.
                                 <hr />
                                3. Don't refresh or post back the page once you start the quiz.
                                <hr />
                                4. After Submission a PDF will be downloaded automatically, the same would be used for record purpose.
                                <hr />
                                5.  <a style="color: #ff0000;">In case of any error, close all brower page(s) and start afresh.</a>
                            </p>
                            <br />
                            <br />
                            <br />
                            <br />
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
    function Fullscreen() {
        document.documentElement.requestFullscreen();
    }

</script>
</html>
