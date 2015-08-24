<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="SignUp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        /* Add whatever you need to your CSS reset */html, body, h1, form, fieldset, input
        {
            margin: 0;
            padding: 0;
            border: none;
        }
        body
        {
            font-family: Helvetica, Arial, sans-serif;
            font-size: 12px;
        }
        #registration
        {
            color: #fff;
            background: #2d2d2d;
            background: -webkit-gradient(
                            linear,
                            left bottom,
                            left top,
                            color-stop(0, rgb(60,60,60)),
                            color-stop(0.74, rgb(43,43,43)),
                            color-stop(1, rgb(60,60,60))
                        );
            background: -moz-linear-gradient(
                            center bottom,
                            rgb(60,60,60) 0%,
                            rgb(43,43,43) 74%,
                            rgb(60,60,60) 100%
                        );
            -moz-border-radius: 10px;
            -webkit-border-radius: 10px;
            border-radius: 10px;
            margin: 10px;
            width: 430px;
        }
        #registration a
        {
            color: #8c910b;
            text-shadow: 0px -1px 0px #000;
        }
        #registration fieldset
        {
            padding: 20px;
        }
        input.text
        {
            -webkit-border-radius: 15px;
            -moz-border-radius: 15px;
            border-radius: 15px;
            border: solid 1px #444;
            font-size: 14px;
            width: 90%;
            padding: 7px 8px 7px 30px;
            -moz-box-shadow: 0px 1px 0px #777;
            -webkit-box-shadow: 0px 1px 0px #777;
            background: #ddd url('img/inputSprite.png') no-repeat 4px 5px;
            background: url('img/inputSprite.png') no-repeat 4px 5px, -moz-linear-gradient(
           center bottom,
           rgb(225,225,225) 0%,
           rgb(215,215,215) 54%,
           rgb(173,173,173) 100%
           );
            background: url('img/inputSprite.png') no-repeat 4px 5px, -webkit-gradient(
          linear,
          left bottom,
          left top,
          color-stop(0, rgb(225,225,225)),
          color-stop(0.54, rgb(215,215,215)),
          color-stop(1, rgb(173,173,173))
          );
            color: #333;
            text-shadow: 0px 1px 0px #FFF;
        }
        input#email
        {
            background-position: 4px 5px;
            background-position: 4px 5px, 0px 0px;
        }
        input#password
        {
            background-position: 4px -20px;
            background-position: 4px -20px, 0px 0px;
        }
        input#name
        {
            background-position: 4px -46px;
            background-position: 4px -46px, 0px 0px;
        }
        input#tel
        {
            background-position: 4px -76px;
            background-position: 4px -76px, 0px 0px;
        }
        #registration h2
        {
            color: #fff;
            text-shadow: 0px -1px 0px #000;
            border-bottom: solid #181818 1px;
            -moz-box-shadow: 0px 1px 0px #3a3a3a;
            text-align: center;
            padding: 18px;
            margin: 0px;
            font-weight: normal;
            font-size: 24px;
            font-family: Lucida Grande, Helvetica, Arial, sans-serif;
        }
        #registerNew
        {
            width: 203px;
            height: 40px;
            border: none;
            text-indent: -9999px;
            background: url('img/createAccountButton.png') no-repeat;
            cursor: pointer;
            float: right;
        }
        #registerNew:hover
        {
            background-position: 0px -41px;
        }
        #registerNew:active
        {
            background-position: 0px -82px;
        }
        #registration p
        {
            position: relative;
        }
        fieldset label.infield /* .infield label added by JS */
        {
            color: #333;
            text-shadow: 0px 1px 0px #fff;
            position: absolute;
            text-align: left;
            top: 3px !important;
            left: 35px !important;
            line-height: 29px;
        }
    </style>
</head>
<body>
    <div id="registration">
        <form id="form1" runat="server">
        <fieldset>
            <p>
                <label for="name">
                    Name</label>
                <asp:TextBox ID="txtName" MaxLength="10" runat="server" CssClass="text"></asp:TextBox><br />
                <asp:RequiredFieldValidator Text="*" ID="RequiredFieldValidator1" runat="server"
                    ErrorMessage="Name is Required" ValidationGroup="sign" ForeColor="Red" ControlToValidate="txtName"
                    Display="Dynamic"></asp:RequiredFieldValidator>
            </p>
            <p>
                <label for="tel">
                    Phone Number</label>
                <asp:TextBox ID="txtPhone" runat="server" CssClass="text"></asp:TextBox><br />
                <asp:RequiredFieldValidator Text="*" ValidationGroup="sign" ID="RequiredFieldValidator2"
                    runat="server" ErrorMessage="Phone Number Required" ForeColor="Red" ControlToValidate="txtPhone"
                    Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator Text="*" ValidationGroup="sign" ID="RegularExpressionValidator2"
                    runat="server" ErrorMessage="Invalid Phone Number" ControlToValidate="txtPhone"
                    Display="Dynamic" ForeColor="Red" ValidationExpression="^[0-9]{10}"></asp:RegularExpressionValidator>
            </p>
            <p>
                <label for="email">
                    Email</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="text"></asp:TextBox><br />
                <asp:RequiredFieldValidator Text="*" ValidationGroup="sign" ID="RequiredFieldValidator3"
                    runat="server" ErrorMessage="Email Required" ControlToValidate="txtEmail" ForeColor="Red"
                    Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator Text="*" ValidationGroup="sign" ID="RegularExpressionValidator1"
                    runat="server" ErrorMessage="Invalid Email" ControlToValidate="txtEmail" Display="Dynamic"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </p>
            <p>
                <label for="password">
                    Password</label>
                <asp:TextBox runat="server" ID="txtPass" TextMode="Password" CssClass="text"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator Text="*" ValidationGroup="sign" ID="RequiredFieldValidator4"
                    runat="server" ErrorMessage="Password is required" ControlToValidate="txtPass"
                    Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
            </p>
            <p>
                <label for="Confirm password">
                    Confirm Password</label>
                <asp:TextBox runat="server" ID="txtConfirm" TextMode="Password" CssClass="text"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator Text="*" ValidationGroup="sign" ID="RequiredFieldValidator5"
                    runat="server" ErrorMessage="Confirm Password is required" ControlToValidate="txtConfirm"
                    Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:CompareValidator Text="*" ValidationGroup="sign" ID="CompareValidator1" runat="server"
                    ErrorMessage="Password Mismatch" Display="Dynamic" ForeColor="Red" ControlToValidate="txtConfirm"
                    ControlToCompare="txtPass"></asp:CompareValidator>
            </p>
            <p>
                <label for="select country">
                    select country</label>
                <asp:DropDownList ID="ddlCountry" runat="server" CssClass="text">
                    <asp:ListItem Text="Select" Value="Select"></asp:ListItem>
                    <asp:ListItem Text="India" Value="India"></asp:ListItem>
                    <asp:ListItem Text="Germany" Value="Germany"></asp:ListItem>
                    <asp:ListItem Text="Brazil" Value="Brazil"></asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator Text="*" ValidationGroup="sign" ID="req1" runat="server"
                    ErrorMessage="Select a country" ControlToValidate="ddlCountry" ForeColor="Red"
                    Display="Dynamic" InitialValue="Select"></asp:RequiredFieldValidator>
            </p>
            <p>
                <label for="select country">
                    Age</label>
                <asp:TextBox ID="txtAge" runat="server" CssClass="text"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ValidationGroup="sign" Text="*" ID="reqage" runat="server" ErrorMessage="Age Required"
                    Display="Dynamic" ForeColor="Red" ControlToValidate="txtAge"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ValidationGroup="sign" Text="*" ControlToValidate="txtAge" runat="server" ID="rangAge" MinimumValue="18" MaximumValue="70" Type="Integer" ErrorMessage="Age must be in between 18 -70"></asp:RangeValidator>
            </p>
            <p>
                <input id="acceptTerms" name="acceptTerms" type="checkbox" />
                <label for="acceptTerms">
                    I agree to the <a href="">Terms and Conditions</a> and <a href="">Privacy Policy</a>
                </label>
            </p>
            <p>
                <asp:Button ID="btnCreateAccount" runat="server" Text="Create Account" Height="30px"
                    ValidationGroup="sign" OnClick="btnCreateAccount_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Clear" Height="30px" Width="100px" />
            </p>
            <p>
                <asp:ValidationSummary ValidationGroup="sign" ID="valsumm" runat="server" ShowMessageBox="true"
                    ShowSummary="false" />
            </p>
        </fieldset>
        </form>
    </div>
</body>
</html>
