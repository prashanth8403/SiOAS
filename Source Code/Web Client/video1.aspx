<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="video1.aspx.cs" Inherits="SiOAS.video1" %>

<!DOCTYPE html>
<html>
<head>
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
<body style="background-color:#fff;">
    <div id="VideoDivision" class="video-container">
        <video autoplay="autoplay" id="videoElement"> </video>
    </div>
    <div  class="capture-button">
         <a id="CaptureButton" class="btn btn-rose btn-fab btn-round" >
             <img height="65" src="Resource/icons/2.png" />
         </a>
    </div>
   
    <script>
        var video = document.querySelector("#videoElement");
        if (navigator.mediaDevices.getUserMedia) {
            navigator.mediaDevices.getUserMedia({ video: true })
                .then(function (stream) {
                    video.srcObject = stream;
                })
                .catch(function (err0r) {
                    window.alert("Couldn't connect to the camera!");
                });
        }
    </script>
</body>
</html>
