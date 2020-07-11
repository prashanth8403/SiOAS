﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SiOAS.Default" %>


<!DOCTYPE html oncontextmenu="return false">
<html lang="en">

<head>
    <meta charset="utf-8" />
    <link rel="icon" type="image/png" href="Resource/Images/logo.png">
    <title>HOME&nbsp&nbsp|&nbsp&nbsp SiOAS
    </title>
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0, shrink-to-fit=no' name='viewport' />
    <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css">
    <link href="Resource/Styles/styles.css" rel="stylesheet" />
</head>

<body class="index-page sidebar-collapse" oncontextmenu="return false" onkeydown="return false;" onmousedown="return false;">
    <form id="form1" style="margin-bottom: 0px;">
        <nav class="navbar navbar-transparent navbar-color-on-scroll fixed-top navbar-expand-lg" color-on-scroll="100" id="sectionsNav">
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
                            <a class="nav-link" href="Register">
                                <i class="material-icons">perm_identity</i> Register
                            </a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">
                                <i class="material-icons">info</i> About
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        <div class="page-header" style="height: 100vh; background-image: url('Resource/Images/bg4.jpg');">
            <div class="container">
                <div class="row">
                    <div class="col-md-8 ml-auto mr-auto">
                        <div class="brand">
                            <h1 style="user-select: none; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">SiOAS</h1>
                            <h3>Online smart Quiz portal.</h3>
                            <br />
                            <a class="btn btn-warning" href="Login.aspx">TAKE QUIZ</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <footer>
            <div class="container-fluid text-center">
                <hr />
                <br />
                <br />
                <div class="row">
                    <div class="col-md-4">
                        <h4 class="footer-header">ABOUT US</h4>
                        <p class="footer-text">
                            <br />
                            <br />
                            &copy; 2020 BMSIT & M. All Rights Reserved.
                            <br />
                            Avalahalli, Yelahanka, Bangalore-560064.
                            <br />
                        </p>
                    </div>
                    <div class="col-md-4">
                        <h4 class="footer-header">LINKS</h4>
                        <br />

                        <div class="footer-links">
                            <a class="link2d" href="#">Developer </a>
                            <br />
                            <a href="#">Terms of services</a><br />
                            <a href="#">Privacy Policy</a>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <h4 class="footer-header">GET IN TOUCH</h4>
                    </div>
                </div>
            </div>
        </footer>
        <script src="Resource/Scripts/core/jquery.min.js" type="text/javascript"></script>
        <script src="Resource/Scripts/core/popper.min.js" type="text/javascript"></script>
        <script src="Resource/Scripts/core/bootstrap-material-design.min.js" type="text/javascript"></script>
        <script src="Resource/Scripts/silicon.js" type="text/javascript"></script>
    </form>
</body>
</html>

