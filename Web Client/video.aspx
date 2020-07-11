<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="video.aspx.cs" Inherits="SiOAS.video" %>

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
<body onload="init();">
    <form id="videox" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" />
    </form>
    <!--  <p>
        <button onclick="startWebcam();return false">Start WebCam</button>
        <button onclick="downloadImage();return false">Stop WebCam</button>
        <button onclick="snapshot();return false">Take Snapshot</button>
        <img id="photo1" runat="server" src="#" />
    </p> -->
    <div class="video-container">
        <video onclick="snapshot(this);" id="video" loop autobuffer muted playsinline autoplay></video>
    </div>
    <!-- <canvas id="myCanvas"  width="400" height="350"></canvas> -->
</body>
<script>
    navigator.getUserMedia = (navigator.getUserMedia ||
        navigator.webkitGetUserMedia ||
        navigator.mozGetUserMedia ||
        navigator.msGetUserMedia);
    var video;
    var webcamStream;
    function to_image() {
        var canvas = document.getElementById("myCanvas");
        document.getElementById("photo1").src = canvas.toDataURL();
        Canvas2Image.saveAsPNG(canvas);
    }

    function downloadImage() {
        var canvas = document.getElementById("myCanvas");
        var image = canvas.toDataURL();
        var aLink = document.createElement('a');
        var evt = document.createEvent("HTMLEvents");
        evt.initEvent("click");
        aLink.download = 'image.png';
        aLink.href = image;
        aLink.dispatchEvent(evt);
    }

    function startWebcam() {
        if (navigator.getUserMedia) {
            navigator.getUserMedia(
                {
                    video: true,
                    audio: false
                },
                function (localMediaStream) {
                    video = document.querySelector('video');
                    video.src = window.URL.createObjectURL(localMediaStream);
                    webcamStream = localMediaStream;
                },
                function (err) {
                    console.log("The following error occured: " + err);
                }
            );
        } else {
            console.log("getUserMedia not supported");
        }
    }

    function stopWebcam() {
        webcamStream.stop();
    }

    var canvas, ctx;

    function init() {
        startWebcam()
        canvas = document.getElementById("myCanvas");
        ctx = canvas.getContext('2d');
    }

    function snapshot() {
        ctx.drawImage(video, 0, 0, canvas.width, canvas.height);
        to_image();
    }

</script>
</html>
