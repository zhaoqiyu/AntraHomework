<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebForm3.aspx.cs" Inherits="WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table width="auto" align="center">
            <tr>
                <td colspan="2" align="center">

                    <h1>Sign Up </h1>
                </td>
            </tr>
            <tr>
                <td>Username</td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password">

                    </asp:TextBox>
                </td>
            </tr>
           
            <tr>
                <td>Address</td>
                <td>
                    <asp:TextBox ID ="txtAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnCreateAccount" runat="server" Text="Create Account" OnClick="btnCreateAccount_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblSummary" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
