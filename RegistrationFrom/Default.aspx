<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" UnobtrusiveValidationMode="None" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>This is the registartion form</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>The Membership registration form</h1>
    <table>
        <tr>
            <td>
                First Name
            </td>
            <td>
                <asp:TextBox ID ="txtFirstName" placeholder ="Please enter your first name" runat="server" width ="200px"/>
                <asp:RequiredFieldValidator runat="server" ID ="valFirstName" Text="*" ErrorMessage="Please enter your first name" ControlToValidate="txtFirstName" ForeColor="Red" Display ="dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td>
                Last Name
            </td>
            <td>
                <asp:TextBox ID ="txtLastName" placeholder ="Please enter your last name" runat="server" width ="200px"/>
                <asp:RequiredFieldValidator runat="server" ID ="valLastName" Text="*" ErrorMessage="Please enter your last name" ControlToValidate="txtLastName" ForeColor="Red" Display ="dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td>
                Email Address
            </td>
            <td>
                <asp:TextBox ID ="txtEmail" placeholder ="Please enter your Email address" runat="server" width ="200px"/>
                <asp:RequiredFieldValidator runat="server" ID ="valEmail" Text="*" ErrorMessage="Please enter your Email address" ControlToValidate="txtEmail" ForeColor="Red" Display ="dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="validEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Please enter a valid email address" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red" text ="Please enter a valid email address"></asp:RegularExpressionValidator>
            </td>
        </tr>

        <tr>
            <td>
                Phone Nomber
            </td>
            <td>
                <asp:TextBox ID ="txtPhone" placeholder ="Please enter your phone number" runat="server" width ="200px"/>
                <asp:RequiredFieldValidator runat="server" ID ="valPhone" Text="*" ErrorMessage="Please enter your phone numebr" ControlToValidate="txtPhone" ForeColor="Red" Display ="dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="validNumber" runat="server" ErrorMessage="Enter valid Phone number" text="Please enter valid Phone number" ControlToValidate="txtPhone" ForeColor ="red"  ValidationExpression ="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" ></asp:RegularExpressionValidator>
            </td>
        </tr>

        <tr>
            <td>
                Address 
            </td>
            <td>
                <asp:TextBox ID ="txtAddress" placeholder ="Please enter your address" runat="server" width ="200px"/>
                <asp:RequiredFieldValidator runat="server" ID ="txt" Text="*" ErrorMessage="Please enter your address" ControlToValidate="txtAddress" ForeColor="Red" Display ="dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Button runat="server" Text ="Submit" OnClick="Submit_Click" />
            </td>
        </tr>
        
                
            
        
    </table>
        <asp:label id ="labSubmit" runat="server" text="Please fill the form to registrate" ></asp:label>
    </div>
    </form>
</body>
</html>
