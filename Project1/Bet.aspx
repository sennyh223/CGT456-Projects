<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bet.aspx.cs" Inherits="BlackjackGame.Bet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bet</title>
    <style type="text/css">
    #header{
        position:absolute;
        top:25px;
        width:380px;
        left:85px;
        border-radius:15px;
     
    }
    #BetDisplay{
        position:absolute;
        top:150px;
        left:85px;
        width:375px;
        height:50px;
        font-size:20px;
        text-align:center;
    }
    #NumberButton1{
        background-color:#56BFFF;
        position:absolute;
        height:100px;
        width:100px;
        font-size:24pt;
        border-radius: 15px;
        top:485px;
        left:85px;
    }
    #NumberButton2{
        background-color:#56BFFF;
        position:absolute;
        height:100px;
        width:100px;
        font-size:24pt;
        border-radius: 15px;
        top:485px;
        left:225px;
    }
    #NumberButton3{
        background-color:#56BFFF;
        position:absolute;
        height:100px;
        width:100px;
        font-size:24pt;
        border-radius: 15px;
        top:485px;
        left:367px;
    }
    #NumberButton4{
        background-color:#56BFFF;
        position:absolute;
        height:100px;
        width:100px;
        font-size:24pt;
        border-radius: 15px;
        top:365px;
        left:85px;
    }
    #NumberButton5{
        background-color:#56BFFF;
        position:absolute;
        height:100px;
        width:100px;
        font-size:24pt;
        border-radius: 15px;
        top:365px;
        left:225px;
    }
    #NumberButton6{
        background-color:#56BFFF;
        position:absolute;
        height:100px;
        width:100px;
        font-size:24pt;
        border-radius: 15px;
        top:365px;
        left:367px;
    }
    #NumberButton7{
        background-color:#56BFFF;
        position:absolute;
        height:100px;
        width:100px;
        font-size:24pt;
        border-radius: 15px;
        top:245px;
        left:85px;
    }
    #NumberButton8{
        background-color:#56BFFF;
        position:absolute;
        height:100px;
        width:100px;
        font-size:24pt;
        border-radius: 15px;
        top:245px;
        left:225px;
    }
    #NumberButton9{
        background-color:#56BFFF;
        position:absolute;
        height:100px;
        width:100px;
        font-size:24pt;
        border-radius: 15px;
        top:245px;
        left:367px;
    }
    #NumberButton0{
        background-color:#56BFFF;
        position:absolute;
        height:100px;
        width:100px;
        font-size:24pt;
        border-radius: 15px;
        top:600px;
        left:85px;
    }

    #Btn20{
        position:absolute;
        height:60px;
        width:100px;
        font-size:24pt;
        top:725px;
        left:85px;
        border-radius: 15px;
        background-color: #00D9FF;

    }
    #Btn50{
        position:absolute;
        height:60px;
        width:100px;
        font-size:24pt;
        top:725px;
        left:225px;
        border-radius: 15px;
        background-color: #00D9FF;
    }
    #Btn100{
        position:absolute;
        height:60px;
        width:100px;
        font-size:24pt;
        top:725px;
        left:367px;
        border-radius: 15px;
        background-color: #00D9FF;
    }
    #ClearButton{
        position:absolute;
        height:100px;
        width:240px;
        font-size:24pt;
        background-color:#0B00FF;
        border-radius:15px;
        top:600px;
        left:225px;
    }
    #StartButton{
        position:absolute;
        height:100px;
        width:382px;
        font-size:24pt;
        top:800px;
        left:85px;
        border-radius:15px;
        background-color:#008DFF;
    }

    /* Start of Hover CSS for Buttons */
    #NumberButton1:hover{
        background-color: #95D7FF;
    }
    #NumberButton2:hover{
        background-color: #95D7FF;
    }
    #NumberButton3:hover{
        background-color: #95D7FF;
    }
    #NumberButton4:hover{
        background-color: #95D7FF;
    }
    #NumberButton5:hover{
        background-color: #95D7FF;
    }
    #NumberButton6:hover{
        background-color: #95D7FF;
    }
    #NumberButton7:hover{
        background-color: #95D7FF;
    }
    #NumberButton8:hover{
        background-color: #95D7FF;
    }
    #NumberButton9:hover {
        background-color: #95D7FF;
    }
    #NumberButton0:hover{
        background-color: #95D7FF;
    }
    #ClearButton:hover{
        background-color: #0092FF;
    }
    #Btn20:hover{
        background-color: #0092FF;
    }
    #Btn50:hover{
        background-color: #0092FF;
    }
    #Btn100:hover{
        background-color: #0092FF;
    }
    #StartButton:hover{
        background-color: #80C6FF;
    }

</style>
</head>
<body>
    <img id="header" src="header.png" />
    <form id="betForm" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

                <asp:Button ID="NumberButton0" runat="server" Text="0" OnClick="NumberButton_Click" />
                <asp:Button ID="NumberButton1" runat="server" Text="1" OnClick="NumberButton_Click" />
                <asp:Button ID="NumberButton2" runat="server" Text="2" OnClick="NumberButton_Click" />
                <asp:Button ID="NumberButton3" runat="server" Text="3" OnClick="NumberButton_Click" />
                <asp:Button ID="NumberButton4" runat="server" Text="4" OnClick="NumberButton_Click" /><br />
                <asp:Button ID="NumberButton5" runat="server" Text="5" OnClick="NumberButton_Click" />
                <asp:Button ID="NumberButton6" runat="server" Text="6" OnClick="NumberButton_Click" />
                <asp:Button ID="NumberButton7" runat="server" Text="7" OnClick="NumberButton_Click" />
                <asp:Button ID="NumberButton8" runat="server" Text="8" OnClick="NumberButton_Click" />
                <asp:Button ID="NumberButton9" runat="server" Text="9" OnClick="NumberButton_Click" /> <br />
                <asp:Button ID="Btn20" runat="server" Text="+$20" OnClick="Btn20_Click" />
                <asp:Button ID="Btn50" runat="server" Text="+$50" OnClick="Btn50_Click" />
                <asp:Button ID="Btn100" runat="server" Text="+$100" OnClick="Btn100_Click" /><br />
                <asp:TextBox ID="BetDisplay" runat="server" ReadOnly="true"></asp:TextBox><br />
                <asp:Button ID="StartButton" runat="server" Text="Place Bet" OnClick="StartButton_Click" />
                <asp:Button ID="ClearButton" runat="server" Text="Clear" OnClick="ClearButton_Click" /><br />

            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
