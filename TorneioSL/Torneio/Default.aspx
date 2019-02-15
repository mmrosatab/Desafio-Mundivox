<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<p>
				<asp:Label ID="lNumChaves" runat="server" Text="N° de chaves:"></asp:Label>
			</p>
        </div>
    	<p>
			<asp:TextBox ID="tbNumChaves" runat="server"></asp:TextBox>
		</p>
		<p>
			<asp:Label ID="lNumTimes" runat="server" Text="N° de times:"></asp:Label>
		</p>
		<p>
			<asp:TextBox ID="tbNumTimes" runat="server"></asp:TextBox>
		</p>
		<asp:Button ID="btnCriarTorneio" runat="server" OnClick="btnCriarTorneio_Click" Text="Criar Torneio" />
    </form>
</body>
</html>
