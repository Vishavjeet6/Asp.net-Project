<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Display.aspx.cs" Inherits="Display" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <p>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Adminpanel.aspx" style="font-size: xx-small; color: #C0C0C0">&lt;--Back</asp:LinkButton>
        <span style="font-size: xx-small; color: #C0C0C0">&nbsp;&nbsp;&nbsp; </span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; All user</p>
    <p>&nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="name" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:BoundField DataField="name" HeaderText="name" ReadOnly="True" SortExpression="name" />
                <asp:BoundField DataField="phone" HeaderText="phone" SortExpression="phone" />
                <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                <asp:BoundField DataField="service" HeaderText="service" SortExpression="service" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [adduser]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [tblogin]"></asp:SqlDataSource>
    </p>
    <p>&nbsp;</p>
    <span class="auto-style1"><strong>Account Details</strong></span><br />
    &nbsp;
    <div>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" DataKeyNames="uname" DataSourceID="SqlDataSource1" GridLines="None" Height="169px" Width="392px">
            <Columns>
                <asp:BoundField DataField="uname" HeaderText="uname" ReadOnly="True" SortExpression="uname" />
                <asp:BoundField DataField="upass" HeaderText="upass" SortExpression="upass" />
            </Columns>
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />
        </asp:GridView>
    </div>
    <p>&nbsp;</p>
</asp:Content>

