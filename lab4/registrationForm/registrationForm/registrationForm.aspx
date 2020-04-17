<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrationForm.aspx.cs" Inherits="registrationForm.registrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HiddenField  ID="hfUserID" runat="server" />
    <table>
        <tr>
            <td>
                <asp:Label runat="server" Text="First Name"></asp:Label>
            </td>
            <td colspan="2">
                <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
            </td>
        </tr>
                <tr>
            <td>
                <asp:Label  runat="server" Text="Last Name"></asp:Label>
            </td>
           <td colspan="2">
                <asp:TextBox ID="txtLastname" runat="server"></asp:TextBox>
            </td>
        </tr>
                <tr>
            <td>
                <asp:Label  runat="server" Text="Contact"></asp:Label>
            </td>
            <td colspan="2">
                <asp:TextBox ID="txtContact" runat="server"></asp:TextBox>
            </td>
        </tr>
                <tr>
            <td>
                <asp:Label runat="server" Text="Gender"></asp:Label>
            </td>
            <td colspan="2">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
                <tr>
            <td>
                <asp:Label runat="server" Text="Addres"></asp:Label>
                s</td>
           <td colspan="2">
                <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <hr />
            </td>
        </tr>
                <tr>

            <td>
                <asp:Label runat="server" Text="Username"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                <asp:Label runat="server" Text="*" ForeColor="Red"></asp:Label>
            </td>
        </tr>
                <tr>
            <td>
                <asp:Label runat="server" Text="Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:Label  runat="server" Text="*" ForeColor="Red"></asp:Label>
            </td>
        </tr>
                 <tr>
            <td>
                <asp:Label  runat="server" Text="Confirm Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtconfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td colspan="2">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" style="height: 26px" /></td>
        </tr>
        <tr>
            <td></td>
            <td colspan="2">
                <asp:Label ID="lblSuccessMessage" runat="server" ForeColor="Green"></asp:Label>

            </td>
        </tr>
         <tr>
            <td></td>
            <td colspan="2">
                <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red"></asp:Label>

            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
