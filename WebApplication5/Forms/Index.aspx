<%@ 
    Page Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="Index.aspx.cs" 
    Inherits="WebApplication5.Forms.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculadora de IMC</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table style="background-color:beige">
                <tr>
                    <td colspan="2">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align:center;"  >
                        <asp:Label ID="lbTitulo"  runat="server" Text="Calculadora IMC" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2"  style="background-color:lightblue">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td style="background-color:lightblue">
                        <asp:Label ID="lbCodigo" runat="server"
                            Text="Código   " />

                    </td>
                    <td style="background-color:lightblue">
                        <asp:TextBox ID="txCodigo" Width="100px" runat="server" />

                    </td>
                </tr>
                <tr>
                    <td style="background-color:lightblue">
                        <asp:Label ID="lbNome" runat="server"
                            Text="Nome   " />

                    </td>
                    <td style="background-color:lightblue">
                        <asp:TextBox ID="txNome" Width="100px" runat="server" />

                    </td>
                </tr>
                <tr>
                    <td style="background-color:lightblue">
                        <asp:Label ID="lbSexo" runat="server"
                            Text="Sexo   " />

                    </td>
                    <td style="background-color:lightblue">
                        <asp:Label ID="lbMasc" runat="server" Text="Masc."/><asp:RadioButton ID="rbMasc" runat="server" GroupName ="sexo"/>
                        <asp:Label ID="lbFem" runat="server" Text ="Fem. "/><asp:RadioButton ID="rbFem" runat="server" GroupName ="sexo"/>

                    </td>
                </tr>
                <tr>
                    <td style="background-color:lightblue">
                        <asp:Label ID="lbPeso" runat="server"
                            Text="Peso   " />

                    </td>
                    <td style="background-color:lightblue">
                        <asp:TextBox ID="txPeso" Width="100px" runat="server" />

                    </td>
                </tr>
                <tr>
                    <td style="background-color:lightblue">
                        <asp:Label ID="lbAltura" runat="server" Text="Altura   " />
                    </td>
                    <td style="background-color:lightblue">
                        <asp:TextBox ID="txAltura" Width="100px" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2"  style="background-color:lightblue">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align:center; background-color:lightblue">
                        <asp:Button ID="btOk" runat="server" Text="  Cadastrar  "
                             OnClick  ="btOk_Click"  />
                        <asp:Button ID="btnLimparPacientes" runat="server" OnClick="btnLimparPacientes_Click" Text="Limpar" />
                        <asp:Button ID="btnGerarRelatorio" runat="server" OnClick="btnGerarRelatorio_Click1" Text="Gerar Relatório" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2"  style="background-color:lightblue">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lbResultado" runat="server" Text=""/> 
                    </td>
                </tr>

                <tr>
                    <td colspan="2">
                        <asp:TextBox ID="lbRelatorio" runat="server" Height="199px" TextMode="MultiLine" Width="482px" /> 
                    </td>
                </tr>

            </table>


         </div>
    </form>
</body>
</html>
