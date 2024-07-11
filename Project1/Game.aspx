<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Game.aspx.cs" Inherits="BlackjackGame.Game" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Blackjack Game</title>
    <style type="text/css">
    #header{
        position:absolute;
        top:25px;
        width:380px;
        left:85px;
        border-radius:15px;
     
    }
    #gameForm{
        position:absolute;
        top:150px;
        left:100px;
        font-weight:bold;
        font-family:Arial;
        font-size:24px;
    }
    #HitButton{
        background-color:#008DFF;
        position:absolute;
        height:50px;
        width:100px;
        font-size:16pt;
        border-radius: 15px;
        top:100px;
        left:0px;
    }
    #StandButton{
        background-color:#008DFF;
        position:absolute;
        height:50px;
        width:100px;
        font-size:16pt;
        border-radius: 15px;
        top:100px;
        left:125px;
    }

    #HitButton:hover{
        background-color:#80C6FF;
    }
    #StandButton:hover{
        background-color:#80C6FF;
    }
    </style>
</head>
<body>
    <img id="header" src="game.png" />
    <form id="gameForm" runat="server">
    <div>
        Your Hand: <asp:Label ID="UserHandLabel" runat="server" Text=""></asp:Label><br />
        Dealer Hand: <asp:Label ID="DealerHandLabel" runat="server" Text=""></asp:Label><br />
        <asp:Button ID="HitButton" runat="server" Text="Hit" OnClick="HitButton_Click" /><br />
        <asp:Button ID="StandButton" runat="server" Text="Stand" OnClick="StandButton_Click" /><br />
    </div>
    </form>
</body>
</html>
