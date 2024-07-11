<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="win.aspx.cs" Inherits="BlackjackGame.win" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>You Win!</title>
    <style type="text/css">
    #header{
        position:absolute;
        top:25px;
        width:380px;
        left:85px;
        border-radius:15px;
     
    }
    #winForm{
        position:absolute;
        top:150px;
        left:75px;
        text-align:center;
        font-weight:bold;
        font-family:Arial;
        font-size:15px;
    }
    #PlayAgainButton{
        background-color:#008DFF;
        position:absolute;
        height:50px;
        width:200px;
        font-size:16pt;
        border-radius: 15px;
        top:100px;
        left:100px;
    }

    #PlayAgainButton:hover{
        background-color:#80C6FF;
    }
    </style>
</head>
<body>
    <img id="header" src="win.png" />
    <form id="winForm" runat="server">
    <div>
        <asp:Label ID="BetLabel" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Button ID="PlayAgainButton" runat="server" Text="Play again" OnClick="PlayAgainButton_Click" />
    </div>
    </form>
</body>
</html>
