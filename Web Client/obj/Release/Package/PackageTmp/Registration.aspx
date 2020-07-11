<%@ Page Language="C#" UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="SiOAS.Registration" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <!-- TITLE -->
    <title>Registration&nbsp&nbsp|&nbsp&nbsp SiOAS
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
    <div class="top-silicon" style="background-color: #fff; width: 100%; margin-top: -15px; box-shadow: 0px 1px 21px -7px rgba(0,0,0,1);">
       <nav class="navbar  navbar-color-on-scroll fixed-top navbar-expand-lg" color-on-scroll="100" id="sectionsNav">
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
                            <a class="nav-link" href="Home">
                                <i class="material-icons">home</i> Home
                            </a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="Login">
                                <i class="material-icons">perm_identity</i> Login
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </div>
    
    <style>
        .modal-load {
            /* Hidden by default */
            position: fixed; /* Stay in place */
            z-index: 1; /* Sit on top */
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
            background-image: url("Resource/Images/load5.gif");
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
    <div class="main-content">
        <form id="Register" runat="server">
            <asp:ScriptManager ID="UpdateScript" runat="server">
            </asp:ScriptManager>
            <asp:Panel ID="MainPanel" runat="server">
                <asp:Panel ID="FortificationController" runat="server">
                    <div class="container-fluid">
                        <div id="MainRow" class="row">
                            <div class="col-lg-4 col-md-6 ml-auto mr-auto">
                                <div class="card card-profile" style="margin-top:20vh;">
                                    <div class="card-header card-header-primary text-center">
                                        <h4 class="card-title">New  Registration</h4>
                                    </div>
                                    <div class="card-body" style="min-height: 500px;">
                                        <asp:UpdatePanel ID="UserInterface" UpdateMode="Conditional" runat="server">
                                            <ContentTemplate>
                                                <br />
                                                <asp:Panel ID="UserDetails" runat="server">
                                                    <!-- USN -->
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
                                                    <div class="input-group">
                                                        <div class="input-group-prepend" style="text-transform: uppercase">
                                                            <span class="input-group-text">
                                                                <i class="material-icons">assignment</i>
                                                            </span>
                                                        </div>
                                                        <asp:TextBox ID="StudentUsn" class="form-control" placeholder="University seat number..." data-toggle="tooltip" data-placement="top" title="University Seat Number" data-container="body" runat="server"></asp:TextBox>
                                                    </div>
                                                    <!-- NAME -->
                                                    <div class="validation-container">
                                                        <asp:RegularExpressionValidator
                                                            ID="RegularExpressionValidator1"
                                                            CssClass="validation-class-text" runat="server"
                                                            ErrorMessage="Invalid Name"
                                                            ControlToValidate="StudentName"
                                                            ValidationExpression="^[aA-zZ ]+$"
                                                            Display="Dynamic">
                                                        </asp:RegularExpressionValidator>
                                                        <asp:RequiredFieldValidator CssClass="validation-class-text" ControlToValidate="StudentName" ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Required Field">
                                                        </asp:RequiredFieldValidator>
                                                    </div>
                                                    <div class="input-group">
                                                        <div class="input-group-prepend">
                                                            <span class="input-group-text">
                                                                <i class="material-icons">face</i>
                                                            </span>
                                                        </div>
                                                        <asp:TextBox ID="StudentName" class="form-control" placeholder="Full Name..." data-toggle="tooltip" data-placement="top" title="Phone Number" data-container="body" runat="server"></asp:TextBox>
                                                    </div>
                                                    <!-- PHONE -->
                                                    <div class="validation-container">
                                                        <asp:RegularExpressionValidator
                                                            ID="RegularExpressionValidator4"
                                                            CssClass="validation-class-text" runat="server"
                                                            ErrorMessage="*Invalid PhoneNo."
                                                            ControlToValidate="PhoneNo"
                                                            ValidationExpression="^[0-9]{10}$"
                                                            Display="Dynamic">
                                                        </asp:RegularExpressionValidator>
                                                        <asp:RequiredFieldValidator CssClass="validation-class-text" ControlToValidate="PhoneNo" ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Required Field">
                                                        </asp:RequiredFieldValidator>
                                                        <br />
                                                    </div>
                                                    <div class="input-group">
                                                        <div class="input-group-prepend">
                                                            <span class="input-group-text">
                                                                <i class="material-icons">call</i>
                                                            </span>
                                                        </div>
                                                        <asp:TextBox ID="PhoneNo" class="form-control" placeholder="Phone Number (+91)..." data-toggle="tooltip" data-placement="top" title="Phone Number" data-container="body" runat="server"></asp:TextBox>
                                                    </div>
                                                    <!-- SEMESTER -->
                                                    <div class="validation-container">
                                                        <asp:RequiredFieldValidator CssClass="validation-class-text" ControlToValidate="Semester" InitialValue="0" ID="RequiredFieldValidator4" runat="server" ErrorMessage="*Select Semester">
                                                        </asp:RequiredFieldValidator>
                                                    </div>
                                                    <div class="input-group">
                                                        <div class="input-group-prepend">
                                                            <span class="input-group-text">
                                                                <i class="material-icons">face</i>
                                                            </span>
                                                        </div>
                                                        <asp:DropDownList ID="Semester" CssClass="form-control" runat="server">
                                                            <asp:ListItem Value="0">--Select Semester--</asp:ListItem>
                                                            <asp:ListItem>1</asp:ListItem>
                                                            <asp:ListItem>2</asp:ListItem>
                                                            <asp:ListItem>3</asp:ListItem>
                                                            <asp:ListItem>4</asp:ListItem>
                                                            <asp:ListItem>5</asp:ListItem>
                                                            <asp:ListItem>6</asp:ListItem>
                                                            <asp:ListItem>7</asp:ListItem>
                                                            <asp:ListItem>8</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </div>
                                                    <!-- SECTION -->
                                                    <div class="validation-container">
                                                        <asp:RequiredFieldValidator CssClass="validation-class-text" ControlToValidate="Semester" InitialValue="0" ID="RequiredFieldValidator5" runat="server" ErrorMessage="*Select Section">
                                                        </asp:RequiredFieldValidator>
                                                        <br />
                                                    </div>
                                                    <div class="input-group">
                                                        <div class="input-group-prepend">
                                                            <span class="input-group-text">
                                                                <i class="material-icons">face</i>
                                                            </span>
                                                        </div>
                                                        <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server">
                                                            <asp:ListItem value="0">--Select Section--</asp:ListItem>
                                                            <asp:ListItem>A</asp:ListItem>
                                                            <asp:ListItem>B</asp:ListItem>
                                                            <asp:ListItem>C</asp:ListItem>
                                                            <asp:ListItem>D</asp:ListItem>
                                                            <asp:ListItem>E</asp:ListItem>
                                                            <asp:ListItem>F</asp:ListItem>
                                                            <asp:ListItem>G</asp:ListItem>
                                                            <asp:ListItem>H</asp:ListItem>
                                                            <asp:ListItem>I</asp:ListItem>
                                                            <asp:ListItem>J</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </div>
                                                </asp:Panel>
                                                <asp:Panel ID="UserAuthentication" runat="server">
                                                    <div class="otp-section">
                                                        <a>Enter the OTP sent to: </a>
                                                        <asp:Label CssClass="otp-label" ID="EmailLabel" runat="server" Text="prashanth8983@gmail.com"></asp:Label>
                                                    </div>
                                                    <div class="validation-container">
                                                        <asp:RegularExpressionValidator
                                                            ID="EmailOTPValid"
                                                            CssClass="validation-class-text" runat="server"
                                                            ErrorMessage="*Invalid OTP"
                                                            ControlToValidate="EmailOTP"
                                                            ValidationExpression="^[0-9]{6}$"
                                                            Display="Dynamic">
                                                        </asp:RegularExpressionValidator>
                                                        <asp:RequiredFieldValidator CssClass="validation-class-text" ControlToValidate="EmailOTP" ID="EmailOTPRequired" runat="server" ErrorMessage="*Required Field">
                                                        </asp:RequiredFieldValidator>
                                                    </div>
                                                    <div class="input-group">
                                                        <div class="input-group-prepend">
                                                            <span class="input-group-text">
                                                                <i class="material-icons">vpn_lock</i>
                                                            </span>
                                                        </div>
                                                        <asp:TextBox ID="EmailOTP" runat="server" class="form-control" placeholder="Email OTP..."></asp:TextBox>
                                                    </div>
                                                </asp:Panel>
                                                <asp:Panel ID="UserSelection" runat="server">
                                                    <br />
                                                    <div class="validation-container">
                                                        <asp:RegularExpressionValidator
                                                            ID="RegularExpressionValidator7"
                                                            CssClass="validation-class-text" runat="server"
                                                            ErrorMessage="*Invalid Prefix"
                                                            ControlToValidate="Prefix"
                                                            ValidationExpression="^[aA-zZ ]+$"
                                                            Display="Dynamic">
                                                        </asp:RegularExpressionValidator>
                                                    </div>
                                                    <div class="input-group">
                                                        <div class="input-group">
                                                            <div class="input-group-prepend">
                                                                <span class="input-group-text">
                                                                    <i class="material-icons">title</i>
                                                                </span>
                                                            </div>
                                                            <asp:DropDownList class="form-control" ID="Prefix" runat="server">
                                                                <asp:ListItem Text="Select Prefix(if any)..." Value="" />
                                                                <asp:ListItem Text="Visualization of" Value="Visualization" />
                                                                <asp:ListItem Text="Simulation of" Value="Simulation of" />
                                                                <asp:ListItem Text="Virtual" Value="Virtual" />
                                                            </asp:DropDownList>
                                                        </div>
                                                    </div>
                                                    <!-- TITLE -->
                                                    <div style="padding: 20px; color: #ff0000;">
                                                        <a>&nbsp Enter only the title:</a><br />
                                                        <a>➊&nbsp Don't include any prefix or suffix, like virutal,simulation etc.</a><br />
                                                        <a>➋&nbsp Don't include any special character.</a>
                                                    </div>
                                                    <div class="validation-container">
                                                        <asp:RegularExpressionValidator
                                                            ID="RegularExpressionValidator5"
                                                            CssClass="validation-class-text" runat="server"
                                                            ErrorMessage="*Invalid Title"
                                                            ControlToValidate="ProjectTitle"
                                                            ValidationExpression="^[aA-zZ0-9 ]+$"
                                                            Display="Dynamic">
                                                        </asp:RegularExpressionValidator>
                                                        <asp:RequiredFieldValidator CssClass="validation-class-text" ControlToValidate="ProjectTitle" ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Required Field">
                                                        </asp:RequiredFieldValidator>
                                                    </div>
                                                    <div class="input-group">
                                                        <div class="input-group">
                                                            <div class="input-group-prepend">
                                                                <span class="input-group-text">
                                                                    <i class="material-icons">title</i>
                                                                </span>
                                                            </div>
                                                            <asp:TextBox ID="ProjectTitle" runat="server" class="form-control" placeholder="Project title..."></asp:TextBox>
                                                        </div>
                                                    </div>
                                                    <br />
                                                    <div class="input-group">
                                                        <div class="input-group">
                                                            <div class="input-group-prepend">
                                                                <span class="input-group-text">
                                                                    <i class="material-icons">text_fields</i>
                                                                </span>
                                                            </div>
                                                            <asp:DropDownList class="form-control" ID="Suffix" runat="server">
                                                                <asp:ListItem Text="Select Suffix(if any)..." Value="" />
                                                                <asp:ListItem Text="process" Value="process" />
                                                                <asp:ListItem Text="system" Value="system" />
                                                                <asp:ListItem Text="simulation" Value="simulation" />
                                                                <asp:ListItem Text="game" Value="game" />
                                                                <asp:ListItem Text="scheduling" Value="scheduling" />
                                                                <asp:ListItem Text="visualization" Value="visualization" />
                                                                <asp:ListItem Text="simulation" Value="simulation" />
                                                                <asp:ListItem Text="algorithm" Value="algorithm" />
                                                            </asp:DropDownList>
                                                        </div>
                                                    </div>
                                                    <br />
                                                </asp:Panel>
                                                <div class="button-div">
                                                    <br />
                                                    <div class="footer text-center">
                                                        <asp:Button ID="BackButton" CssClass="btn" CausesValidation="false" runat="server" Text="BACK" OnClick="BackButton_Click" />
                                                        <asp:Button ID="SubmitButton" runat="server" CssClass="btn btn-primary" Text="NEXT" OnClick="SubmitButton_Click" />
                                                    </div>
                                                    <br />
                                                </div>
                                                <asp:Panel ID="SucessPanel" runat="server">
                                                    <div class="update-progress">
                                                        <div class="modal-load">
                                                            <div class="modal-content" style="margin-top: 80px;">
                                                                <div class="modal-body">
                                                                    <div style="width: 80px; position: center; margin-left: auto; margin-right: auto;">
                                                                        <img src="Resource/Images/tick.png" height="80" width="80" />
                                                                    </div>
                                                                    <div style="text-align: center; padding-top: 20px;">
                                                                        <a style="padding-top: 60px; font-family: Calibri; font-size: 30px; font-weight: 600;">Success!</a>
                                                                    </div>
                                                                    <br />
                                                                    <p style="text-align: center; font-family: Verdana, Roboto; padding-left: 8px; font-size: 15px; font-weight: 400">
                                                                        You registration is complete.<br />
                                                                        You can verify your details from the information page.
                                                                    </p>
                                                                </div>

                                                                <div class="footer" style="position: center; margin-left: auto; margin-right: auto;">
                                                                    <asp:Button CausesValidation="false" Font-Size="Small" ID="SucessBtn" class="btn btn-rose" runat="server" Text="Awesome!" OnClick="SucessBtn_Click" />
                                                                </div>
                                                                <br />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </asp:Panel>
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
                                                <asp:AsyncPostBackTrigger ControlID="SubmitButton" />
                                            </Triggers>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </asp:Panel>
            </asp:Panel>
        </form>
    </div>
   
        <script src="Resource/Scripts/core/jquery.min.js" type="text/javascript"></script>
        <script src="Resource/Scripts/core/bootstrap-material-design.min.js" type="text/javascript"></script>
        <script src="Resource/Scripts/silicon.js" type="text/javascript"></script>
</body>
</html>


