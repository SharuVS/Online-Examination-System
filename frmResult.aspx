<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="frmResult.aspx.vb" Inherits="frmResult" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p align="left">
    &nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Exam Result :"></asp:Label>
</p>
<p align="left">
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
        DataFile="~/App_Data/OnlineExam.mdb" 
        
        
        
        SelectCommand="SELECT [Name], [RollNo], [sub], [Score], [Uname], [Section1] FROM [tbmStdAcc]">
    </asp:AccessDataSource>
</p>
<p align="left">
    <asp:GridView ID="GridView1" runat="server" DataSourceID="AccessDataSource1" 
        Width="100%" AutoGenerateColumns="False" BackColor="#DEBA84" 
        BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        CellSpacing="2">
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="RollNo" HeaderText="Roll No" 
                SortExpression="RollNo" />
            <asp:BoundField DataField="Uname" HeaderText="User name" 
                SortExpression="Uname" />
            <asp:BoundField DataField="sub" HeaderText="subject" SortExpression="sub" />
            <asp:BoundField DataField="Section1" HeaderText="Section" 
                SortExpression="Section1" />
            <asp:BoundField DataField="Score" HeaderText="Score" SortExpression="Score" />
        </Columns>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
</p>
</asp:Content>

