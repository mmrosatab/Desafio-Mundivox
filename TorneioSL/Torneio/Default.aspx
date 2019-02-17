<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Torneio</title>
    <script type="text/javascript">

        function ePotenciaDois(num)
        {
            if ((num & (num - 1)) == 0)
            {
                return true;
            }
            return false;
        }

        function configTorneioValida(num)
        {
            if (ePotenciaDois(num) && (num >= 2))
            {
                return true;
            }
            return false;
        }

        // verificar se num. times torneio eh valido
        function numTimesValido(numTimes, numChaves)
        {
         
            if (numTimes >= numChaves)
            {
                return true; 
            }
            return false;
        }

        // valida parametros formulario
        function validar()
        {
           
            var numChaves = document.getElementById('<%=tbNumChaves.ClientID%>').value;
            var numTimes = document.getElementById('<%=tbNumTimes.ClientID%>').value;

            if (numChaves == '')
            {
                alert('Campo N° de chaves está vazio');

                document.getElementById('<%=tbNumChaves.ClientID%>').focus();
                return false;
            }
            else if (numTimes == '')
            {
                alert('Campo N° de times está vazio');

                document.getElementById('<%=tbNumTimes.ClientID%>').focus();
                return false;
            }
            else if (!configTorneioValida(numTimes))
            {
                alert("O n° de times deve ser uma potencia de 2.");
                document.getElementById('<%=tbNumTimes.ClientID%>').focus();
                return false;
            }
            else if (!configTorneioValida(numChaves))
            {

                alert("O n° de chaves deve ser uma potencia de 2.");
                document.getElementById('<%=tbNumChaves.ClientID%>').focus();
                return false;
            }
            else if (!numTimesValido(numTimes, numChaves))
            {
                alert("O n° de times deve ser maior ou igual que o n° de chaves.");
                document.getElementById('<%=tbNumTimes.ClientID%>').focus();
                return false;
            }
            else
            {
                return true;
            }
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
			    <asp:Label ID="lNumChaves" runat="server" Text="N° de chaves:"></asp:Label>
		    </p>
        
    	    <p>
			    <asp:TextBox ID="tbNumChaves" runat="server"></asp:TextBox>
		    </p>
		    <p>
			    <asp:Label ID="lNumTimes" runat="server" Text="N° de times:"></asp:Label>
		    </p>
		    <p>
			    <asp:TextBox ID="tbNumTimes" runat="server"></asp:TextBox>
		    </p>
            <p>
		    <asp:Button ID="btnCriarTorneio" runat="server" OnClick="btnCriarTorneio_Click" OnClientClick="return validar()" Text="Criar Torneio" />
            </p>
        </div>
    </form>
</body>
</html>
