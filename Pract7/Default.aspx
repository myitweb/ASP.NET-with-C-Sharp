<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 46%;
            height: 122px;
        }
        .style2
        {
            width: 100%;
            background-color: #3399FF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <table class="style1">
            <tr>
                <td colspan="2" style="text-align: center; background-color: #3399FF">
                    Student Information</td>
            </tr>
            <tr>
                <td>
                    Roll No</td>
                <td>
                    <asp:TextBox ID="Txtrollno" runat="server" Width="60px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    First Name</td>
                <td>
                    <asp:TextBox ID="txtfname" runat="server" Width="157px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Last Name</td>
                <td>
                    <asp:TextBox ID="txtlname" runat="server" Width="158px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    DOB</td>
                <td>
                    <asp:TextBox ID="txtdob" runat="server" Width="79px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="But_Add" runat="server" onclick="But_Add_Click" Text="Add " />
                    <asp:Button ID="But_Update" runat="server" Text="Update" 
                        onclick="But_Update_Click" />
                    <asp:Button ID="But_delete" runat="server" Text="Delete" 
                        onclick="But_Edit_Click" />
                    <asp:Button ID="But_Exit" runat="server" Text="Exit"  />
                </td>
            </tr>
        </table>
        </div>
    <table class="style2">
        <tr>
            <td>
                <br />
                </td>
                </tr>
</table>
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" 
        ForeColor="#333333" GridLines="Horizontal" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" 
        AutoGenerateSelectButton="True" BorderStyle="Solid">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    &nbsp;&nbsp;&nbsp;&nbsp;
    </form>
    

    </body>
</html>