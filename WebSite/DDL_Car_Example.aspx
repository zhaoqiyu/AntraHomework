<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DDL_Car_Example.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <h3>Car selection page:</h3>
                </td>
            </tr>
            <tr>
                <td>
                    Select Make:
                </td>
                <td>
                    <asp:DropDownList id ="ddlCarMake" runat="server" AutoPostBack ="true" OnSelectedIndexChanged ="ddlCarMake_SelectedIndexChanged" >         
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Select Model:
                </td>
                <td>
                    <asp:DropDownList id ="ddlCarModel" runat="server" AutoPostBack ="true" OnSelectedIndexChanged ="ddlCarModel_SelectedIndexChanged" >                      
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Select Color:
                </td>
                <td>
                    <asp:DropDownList id ="ddlCarColor" runat="server" AutoPostBack ="true" >
                        
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSubMit" runat="server" Text="Submit"  OnClick ="btnSubmit_Click">
                    </asp:Button>
                </td>
                <td>
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel"  OnClick ="btnCancel_Click" >
                    </asp:Button>
                </td>
            </tr>
            <tr>
            </tr>
        </table>
    
    </div>
    </form>
    <p>
        <asp:Label ID="labResult" runat="server" Text="Please make your choics."></asp:Label>
    </p>
</body>
</html>
