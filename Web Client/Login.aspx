<%@ Page Language="C#" UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SiOAS.Register" %>


<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8" />
    <link rel="icon" type="image/png" href="Resource/Images/logo.png">
    <title>REGISTER&nbsp&nbsp|&nbsp&nbsp SiOAS
    </title>
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0, shrink-to-fit=no' name='viewport' />
    <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons" />
    <link href="https://fonts.googleapis.com/css2?family=Pacifico&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css">
    <link href="Resource/Styles/styles.css" rel="stylesheet" />

</head>

<body onload="Fullscreen()">
    <style>
        .modal-load {
            /* Hidden by default */
            position: fixed; /* Stay in place */
            z-index: 2; /* Sit on top */
            padding-top: 100px; /* Location of the box */
            left: 0;
            top: 0;
            width: 100%; /* Full width */
            height: 100%; /* Full height */
            overflow: auto; /* Enable scroll if needed */
            background-color: rgb(0,0,0); /* Fallback color */
            background-color: rgba(225,225,225,0.6); /* Black w/ opacity */
        }

        .modal-content {
            margin-top: 150px;
            width: 400px;
            max-width: 90%;
            margin-left: auto;
            margin-right: auto;
        }


        .modal-load-content {
            margin: auto;
            background-image: url("Source/Resource/load5.gif");
            padding: 0;
            background-size: 50px;
            width: 50px;
            background-repeat: no-repeat;
            height: 70px;
            position: center;
            margin-top: 30vh;
            -webkit-animation-name: animatetop;
            -webkit-animation-duration: 0.4s;
            animation-name: animatetop;
            animation-duration: 0.4s
        }

        @-webkit-keyframes animatetop {
            from {
                top: -300px;
                opacity: 0
            }

            to {
                top: 0;
                opacity: 1
            }
        }

        @keyframes animatetop {
            from {
                top: -300px;
                opacity: 0
            }

            to {
                top: 0;
                opacity: 1
            }
        }

        /* The Close Button */
        .close {
            color: white;
            float: right;
            font-size: 28px;
            font-weight: bold;
        }

            .close:hover,
            .close:focus {
                color: #000;
                text-decoration: none;
                cursor: pointer;
            }

        .modal-load-header {
            padding: 2px 16px;
            background-color: #5cb85c;
            color: white;
        }

        .modal-load-body {
            padding: 2px 16px;
        }

        .modal-load-footer {
            padding: 2px 16px;
            background-color: #5cb85c;
            color: white;
        }
    </style>
    <form id="Login" runat="server" style="z-index: 1">
        <nav class="navbar navbar-transparent fixed-top navbar-expand-lg" id="sectionsNav">
            <div class="container">
                <div class="navbar-translate">
                    <div>
                        <div style="float: left; padding-right: 10px;">
                            <img id="logoid" src="Resource/Images/logo.png" height="60" />
                        </div>
                        <div style="float: right; padding-top: 10px;">
                            <a id="bmsit1" class="bmsit-text">BMS</a><br />
                            <a id="bmsit2" class="bmsit-text-s">INSTITUTE OF TECHNOLOGY</a>
                        </div>
                    </div>
                    <button class="navbar-toggler" type="button" data-toggle="collapse" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="navbar-toggler-icon"></span>
                        <span class="navbar-toggler-icon"></span>
                        <span class="navbar-toggler-icon"></span>
                    </button>
                </div>
                <div class="collapse navbar-collapse">
                    <ul class="navbar-nav ml-auto">
                        <li class="nav-item">
                            <a class="nav-link" href="Home" onclick="scrollToDownload()">
                                <i class="material-icons">home</i>Home
                            </a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#" onclick="scrollToDownload()">
                                <i class="material-icons">info</i> About
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        <div class="page-header" style="filter: blur(9px); background-image: url('Resource/Images/bg2.jpg');">
        </div>
        <div class="container" style="margin-top: -100vh; padding-top: 15vh;">
            <asp:ScriptManager ID="LoginScript" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="LoginUpdate" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="row">
                        <div class="col-lg-4 col-md-6 ml-auto mr-auto">
                            <div class="card card-login">
                                <div class="card-body" style="min-height: 450px;">
                                    <div class="logo">
                                        <a style="font-family: Arial; font-size: 25px; font-weight: 600;">LOGIN</a>
                                        <br />
                                    </div>
                                    <asp:Panel ID="Panel1" runat="server">
                                        <div class="validation-container">
                                            <asp:RegularExpressionValidator
                                                ID="UserNameValid"
                                                CssClass="validation-class-text" runat="server"
                                                ErrorMessage="*Invalid USN"
                                                ControlToValidate="StudentUsn"
                                                ValidationExpression="^1+[bByY]{2}\d{2}[A-aZ-z]{2}[0-9]{3}$"
                                                Display="Dynamic">
                                            </asp:RegularExpressionValidator>
                                            <asp:RequiredFieldValidator CssClass="validation-class-text" ControlToValidate="StudentUsn" ID="UsnRequired" runat="server" ErrorMessage="*Required Field">
                                            </asp:RequiredFieldValidator>
                                        </div>
                                        <div class="input-group" style="margin-top: -5px;">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text">
                                                    <i class="material-icons">face</i>
                                                </span>
                                            </div>
                                            <asp:TextBox ID="StudentUsn" CausesValidation="false" class="form-control" placeholder="User Id..." runat="server" ValidationGroup="login"></asp:TextBox>
                                        </div>
                                        <div class="validation-container">
                                            <asp:RequiredFieldValidator CssClass="validation-class-text" ControlToValidate="Password" ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Required Field">
                                            </asp:RequiredFieldValidator>
                                        </div>
                                        <div class="input-group" style="margin-top: -5px;">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text">
                                                    <i class="material-icons">lock</i>
                                                </span>
                                            </div>
                                            <asp:TextBox TextMode="Password" AutoPostBack="false" ID="Password" CausesValidation="false" class="form-control" placeholder="Password..." runat="server" ValidationGroup="login"></asp:TextBox>
                                        </div>
                                        <div class="validation-container">
                                            <asp:RegularExpressionValidator
                                                ID="RegularExpressionValidator2"
                                                CssClass="validation-class-text" runat="server"
                                                ErrorMessage="*Invalid Passcode"
                                                ControlToValidate="Code"
                                                ValidationExpression="^[0-9]{6}$"
                                                Display="Dynamic">
                                            </asp:RegularExpressionValidator>
                                            <asp:RequiredFieldValidator CssClass="validation-class-text" ControlToValidate="Code" ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Required Field">
                                            </asp:RequiredFieldValidator>
                                        </div>
                                        <div class="input-group" style="margin-top: -5px;">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text">
                                                    <i class="material-icons">assignment</i>
                                                </span>
                                            </div>
                                            <asp:TextBox ID="Code" CausesValidation="false" class="form-control" placeholder="Passcode..." runat="server" ValidateRequestMode="Disabled"></asp:TextBox>
                                        </div>
                                    </asp:Panel>
                                    <div class="text-center">
                                        <br />
                                        <br />
                                        <br />
                                        <asp:Button ID="Submit" CssClass="btn btn-info" runat="server" Text="LOGIN" OnClick="Submit_Click" />
                                    </div>
                                </div>
                                <br />
                            </div>
                        </div>
                    </div>
                    <asp:Panel ID="MessagePanel" runat="server">
                        <div class="update-progress">
                            <div id="myModal1" class="modal-load">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h5 class="modal-title" style="font-weight: 600; font-size: 20px;">
                                            <asp:Label ID="MessageHeader" runat="server" Text="Label"></asp:Label>
                                        </h5>
                                    </div>
                                    <div class="modal-body">
                                        <p style="text-align: center;">
                                            <asp:Label ID="MessageLabel" runat="server" Text="Label"></asp:Label>
                                        </p>
                                    </div>
                                    <div style="position: center; margin-left: auto; margin-right: auto;">
                                        <asp:Button CausesValidation="false" ID="_messagebutton" class="btn btn-info" runat="server" Text="OK" OnClick="_messagebutton_Click" />
                                    </div>
                                    <br />
                                </div>
                            </div>
                        </div>
                    </asp:Panel>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Submit" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
    </form>
    <script>
        function fullscreen() {
            document.documentElement.requestFullscreen();
        }
    </script>
    <script src="Resource/Scripts/core/jquery.min.js" type="text/javascript"></script>
    <script src="Resource/Scripts/core/bootstrap-material-design.min.js" type="text/javascript"></script>
    <script src="Resource/Scripts/silicon.js" type="text/javascript"></script>
</body>
</html>
