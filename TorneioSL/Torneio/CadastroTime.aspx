<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastroTime.aspx.cs" Inherits="CadastroTime" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 113px">
            <p>
                 <asp:DropDownList ID="ddlTimes" runat="server" style="margin-left: 7px">
                </asp:DropDownList>
            </p>
            <p style="width: 676px; margin-left: 7px">
                 <asp:TextBox ID="tbNomeTime" runat="server"></asp:TextBox>
            </p>
            <p>

                <asp:Button ID="btnCadTime" runat="server"  OnClick="btnCadTime_Click" Text="Cadastrar Time" style="margin-left: 6px" />

            </p>
        </div>
    </form>
</body>
</html>
