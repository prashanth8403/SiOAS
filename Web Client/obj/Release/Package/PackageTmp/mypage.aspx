<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mypage.aspx.cs" Inherits="SiOAS.mypage" %>


<!DOCTYPE html>
<html lang="en">

<head>
    <!-- TITLE -->
    <title>Quiz&nbsp&nbsp|&nbsp&nbsp SiOAS
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

<body id="quizbody" oncontextmenu="return false" onkeydown="return false;" onmousedown="return false;">
    <form id="MyPage" runat="server" style="margin-bottom: 0px;">
        <div id="fullscreen-div">
            <asp:Panel ID="QuestionPanel" runat="server">
                <nav class="navbar fixed-top navbar-expand-lg" style="max-width: 100vw; background-color: #363491; z-index: 2;">
                    <div class="container" style="background-color: #fff; padding-top: -15px;">
                        <div>
                            <div style="float: right; padding-top: 10px; font-size: 18px;">
                                <asp:Label ID="SubjectLabel" runat="server" Text="Label"></asp:Label><br />
                                <asp:Label ID="NameLabel" runat="server" Text="Label"></asp:Label>
                            </div>
                        </div>
                        <div>
                            <a class="time-text">TIME LEFT:</a><br />
                            <p class="timertext" id="demo">00:00:00</p>
                        </div>
                    </div>
                </nav>
                <div class="main main-raised" style="margin-top: 100px; margin-bottom: 50px; z-index: 1">
                    <div class="section section-feature">
                        <div class="container">
                            <div class="container-fluid">
                                <div id="questionsection">
                                    <asp:Label ID="SubjectCode" CssClass="code-tt" runat="server" Text=""></asp:Label>
                                    <asp:Repeater ID="QuestionLoader" runat="server">
                                        <ItemTemplate>
                                            <div class="question-section">
                                                <div class="question-section-label">
                                                    <asp:Label runat="server" ID="lblRowNumber" Text='<%# Container.ItemIndex + 1 %>' /><a>.&nbsp </a>
                                                    <asp:Label ID="QuestionLabel" runat="server" Text='<%#Eval("Question")%>'></asp:Label>
                                                    <asp:Label ID="QuestionID" CssClass="label-white" runat="server" Text='<%#Eval("ID")%>'></asp:Label>
                                                </div>
                                                <div class="imageholder">
                                                    <asp:Image ID="QuestionImage" CssClass="imagebox" ImageUrl='<%# "focalimages\\"+Eval("ImageID")+".JPG" %>' runat="server" />
                                                </div>
                                                <div class="option-section">
                                                    <asp:RadioButton ID="Option1" CssClass="radio-option" Text='<%#Eval("Option1")%>' runat="server" GroupName="Options" value="1" /><br />
                                                    <asp:RadioButton ID="Option2" CssClass="radio-option" Text='<%#Eval("Option2")%>' runat="server" GroupName="Options" value="2" /><br />
                                                    <asp:RadioButton ID="Option3" CssClass="radio-option" Text='<%#Eval("Option3")%>' runat="server" GroupName="Options" value="3" /><br />
                                                    <asp:RadioButton ID="Option4" CssClass="radio-option" Text='<%#Eval("Option4")%>' runat="server" GroupName="Options" value="4" /><br />
                                                </div>
                                            </div>
                                            <div>
                                                <asp:Label ID="LabSelected" runat="server" Text=""></asp:Label><br />
                                                <asp:Label ID="QueryA2" CssClass="lab-review" runat="server" Visible="false" Text='<%# _hasher(Eval("Answer").ToString())%>'></asp:Label>
                                            </div>
                                            <br />
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>
                            </div>
                        </div>
                        <div class="button-section">
                            <br />
                            <asp:Button ID="BtnNext" CssClass="btn btn-info" runat="server" Text="SUBMIT RESPONSE" OnClick="BtnNext_Click" />
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel ID="SuccessPanel" Visible="false" runat="server">
                <div style="min-width: 470px; width: 80vw; margin-left: auto; margin-right: auto;">
                    <div class="main main-raised" style="margin-top: 60px; height: 80%; margin-bottom: 60px; z-index: 1">
                        <div class="row">
                            <div class="col-md-8 ml-auto mr-auto">
                                <div class="update-progress">
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
                                    <div class="container-fluid text-center" style="margin-bottom: 30vh; margin-top: 100px;">
                                        <div>
                                            <a href="Home" class="btn btn-rose">Home</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
        </div>
    </form>
    <script>
        function getUrlVars() {
            var vars = {};
            var parts = window.location.href.replace(/[?&]+([^=&]+)=([^&]*)/gi, function (m, key, value) {
                vars[key] = value;
            });
            return vars;
        }

        var locktime = getUrlVars()["buffer"];

        var x = setInterval(function Test() {
            var hours = Math.floor((locktime / 3600));
            var minutes = Math.floor((locktime % 3600) / 60);
            var seconds = Math.floor(locktime % 60);
            if (hours < 10) {
                hours = "0" + hours;
            }
            if (minutes < 10) {
                minutes = "0" + minutes;
            }
            if (seconds < 10) {
                seconds = "0" + seconds;
            }
            document.getElementById("demo").innerHTML = hours + ":" + minutes + ":" + seconds;
            if (locktime == 1) {
                document.getElementById("BtnNext").click();
            }
            else {
                locktime--;
            }
        }, 1000);

        function esc(e) {
            e = e || window.event || {};
            var charCode = e.charCode || e.keyCode || e.which;
            if (charCode == 27) {
                return false;
            }
        }

        function fullscreen() {
            document.documentElement.requestFullscreen();
        }
    </script>
    <script src="Resource/Scripts/mypage-timer.js"></script>
    <script src="Resource/Scripts/core/jquery.min.js" type="text/javascript"></script>
    <script src="Resource/Scripts/core/popper.min.js" type="text/javascript"></script>
    <script src="Resource/Scripts/core/bootstrap-material-design.min.js" type="text/javascript"></script>
    <script src="Resource/Scripts/silicon.js" type="text/javascript"></script>
</body>
</html>
