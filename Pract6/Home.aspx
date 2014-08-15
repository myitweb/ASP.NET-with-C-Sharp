<%@ Page Title="" Language="C#" MasterPageFile="~/MastePages/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="_Default" %>

<%@ Register src="Control/WebUserControl.ascx" tagname="WebUserControl" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style7
    {
        font-size: x-large;
        color: #FF0066;
        background-color: #66FFFF;
    }
    .style8
    {
        font-size: xx-large;
        color: #FF0066;
        background-color: #66FFFF;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <p class="style7">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    WELCOME TO THE WORLD OF GAMES
    <span class="st"><span class="style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Welcome to play 
    </span><em><span class="style8"><a href="Fruit.aspx">Fruit Ninja Game</a></span></em><span class="style7">. This is a funny games.&nbsp;Mini games and free games online.In this games,you will find a 
    funny show</span>.</span></p>
   
</asp:Content>

