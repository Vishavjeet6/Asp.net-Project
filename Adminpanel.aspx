<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Adminpanel.aspx.cs" Inherits="Adminpanel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="text-align: center">
    &nbsp;<asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/newuser.aspx">New User</asp:LinkButton>
</p>
<p style="text-align: center">
    <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/Display.aspx">Display User</asp:LinkButton>
    </p>
    <p style="text-align: center">
        <asp:LinkButton ID="LinkButton4" runat="server" PostBackUrl="~/Dropuser.aspx">Drop User</asp:LinkButton>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Sign Out" />
    </p>
</asp:Content>

