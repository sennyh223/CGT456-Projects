<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Part1.aspx.cs" Inherits="Assign05.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="select" EventName ="Click" />
                    <asp:AsyncPostBackTrigger ControlID="selectOne" EventName ="Click" />
                    <asp:AsyncPostBackTrigger ControlID="insert" EventName ="Click" />
                    <asp:AsyncPostBackTrigger ControlID="update" EventName ="Click" />
                    <asp:AsyncPostBackTrigger ControlID="delete" EventName ="Click" />
                    <asp:AsyncPostBackTrigger ControlID="deleteAll" EventName ="Click" />
                    <asp:AsyncPostBackTrigger ControlID="truncate" EventName ="Click" />

                </Triggers>
                <ContentTemplate>
                    <asp:Button ID="select" runat="server" Text="Select All" OnClick="Select_Click" />
                    <asp:Button ID="selectOne" runat="server" Text="Select One" OnClick="SelectOne_Click" />
                    <asp:Button ID="insert" runat="server" Text="Insert" OnClick="Insert_Click" />
                    <asp:Button ID="update" runat="server" Text="Update" OnClick="Update_Click" />
                    <asp:Button ID="delete" runat="server" Text="Delete" OnClick="Delete_Click" />
                    <asp:Button ID="deleteAll" runat="server" Text="Delete All" OnClick="DeleteAll_Click" />
                    <asp:Button ID="truncate" runat="server" Text="Truncate" OnClick="Truncate_Click" />

                    <asp:DataGrid runat="server" ID="results" />
                </ContentTemplate>
            </asp:UpdatePanel>

        </div>
    </form>
    <a href="Part2.aspx">
        <button>Part 2</button>
    </a>

    <a href="sqlqueries.txt">
        <button>Txt file</button>
    </a>
</body>
</html>
