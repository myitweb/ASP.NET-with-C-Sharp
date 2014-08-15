<%@ Page Title="" Language="C#" MasterPageFile="~/MastePages/MasterPage.master" AutoEventWireup="true" CodeFile="Customer.aspx.cs" Inherits="Customer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Log out" 
        Width="117px" />
</p>
<p>
    Customer Name: Sakshi Arora.
</p>
<p>
    Favourate Game: Fruit Ninja</p>
<p>
    Date Of&nbsp; Birth:&nbsp;&nbsp;&nbsp; 15/09/2000</p>
</asp:Content>

