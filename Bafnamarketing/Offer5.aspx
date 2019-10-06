<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Offer5.aspx.cs" Inherits="Offer5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <style>
body{
	background-image: url(images/background1.jpg);
}
.Offer1{
	padding-left:15px;
}
</style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
           <div style="padding-top:50px">
    
    </div>
                <table>
                      <tr>
                        <td rowspan="7">
                            <img src="images/Offer5.jpg" hieght:90% align="left" style="height: 370px; width: 99%"/>
                        </td>
                    
                        <td colspan="2">
                            <asp:Label ID="Label1" runat="server" Text="Full Name "></asp:Label>
                        </td>
                        <td colspan="3">
                            <asp:TextBox ID="txtName" runat="server" Width="227px"></asp:TextBox>
                        </td>
                   </tr>

                
                    <tr>
                        <td></td>
                        <td >
                            <asp:Label ID="Label2" runat="server" Text="Address"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:TextBox ID="txtAddress" runat="server" Height="51px" TextMode="MultiLine" Width="246px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td></td>
                        <td >
                            <asp:Label ID="Label3" runat="server" Text="Email ID"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:TextBox ID="txtEmail" runat="server" Width="243px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td></td>
                        <td >
                            <asp:Label ID="Label4" runat="server" Text="Mobile No."></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:TextBox ID="txtMobile" runat="server" Width="227px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td></td>
                        <td >
                            <asp:Label ID="Label5" runat="server" style="text-align: left" Text="Existing Customer ?"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" CellSpacing="1" RepeatLayout="Flow" Width="63px">
                            <asp:ListItem>Yes</asp:ListItem>
                            <asp:ListItem>No</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>

                    <tr>
                        <td></td>
                        <td >
                            <asp:Label ID="Label6" runat="server" Text="Comments"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:TextBox ID="txtComments" runat="server" Height="55px" TextMode="MultiLine" Width="255px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td></td>
                        <td></td>
                        <td colspan="3">
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                        </td>
                    </tr>
                            <tr>
                        <td></td>
                        <td></td>
                        <td colspan="3">
                            <asp:Label ID="lblSuccess" runat="server" Text="" ForeColor="Green"></asp:Label>
                        </td>
                    </tr>
                      <tr>
                        <td></td>
                        <td></td>
                        <td colspan="3">
                            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                    </table>
    </div>
    </form>
</body>
</html>
