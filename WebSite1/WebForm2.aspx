<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebForm2.aspx.cs" Inherits="WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 400px;
           
            border: 1px solid #000000;
            background-color: #FFCCFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <table align="center" class="auto-style1">
            <tr>
                <td colspan="2" align="center">
                    <h1>Arithematic 
               
                    Operations</h1>
                </td>
            </tr>
            <tr>
                <td>First Number</td>
                <td>
                    <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Second Number</td>
                <td><asp:TextBox ID="txtSecond" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>

                    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                     <asp:Button ID="btnSubtract" runat="server" Text="Subtract" OnClick="btnSubtract_Click" />
                </td>
                <td>
                    <asp:Button ID="btnMultiply" runat="server" Text="Muliply" />
                     <asp:Button ID="btnDivide" runat="server" Text="Divide" />
                </td>
            </tr>
            <tr>
                <td>Result</td>
                <td>
                    <asp:TextBox ID="txtResult" runat="server" Enabled="false"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">


                    <asp:Label ID="lblError" runat="server" ForeColor="Red" Font-Bold="true"></asp:Label>


                </td>
            </tr>
            <tr>
                <td colspan="2">

                    &copy; All rights reserved
                </td>
            </tr>
        </table>

    </form>
</body>
</html>
