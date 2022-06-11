<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LandingPage.aspx.cs" Inherits="Pages_LandingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log In</title>
    <link rel="stylesheet" type="text/css" href="../Resources/CSS/landing.css" />
</head>
<body>
    <form id="form1" runat="server" method="post">
        <div class="container">
            <label for="pNumber"><b>Personal Number</b></label>
            <input type="text" placeholder="Enter Personal Number" id="pNumber" name="pNumber" required="required" />

            <label for="psw"><b>Password</b></label>
            <input type="password" placeholder="Enter Password" id="psw" name="psw" required="required" />

            <button type="submit">Login</button>

            <div id="message" name="message" runat="server"></div>
        </div>
    </form>
</body>
</html>
