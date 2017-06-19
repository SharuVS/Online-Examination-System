<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="frmManageStd.aspx.vb" Inherits="frmManageStd" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    DataSourceID="AccessDataSource1" Width="100%" AllowPaging="True" 
        CellPadding="4" DataKeyNames="ID" ForeColor="#333333" GridLines="None">
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
    <Columns>
        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
        <asp:BoundField DataField="RollNo" HeaderText="RollNo" 
            SortExpression="RollNo" />
        <asp:BoundField DataField="sub" HeaderText="sub" SortExpression="sub" />
        <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
            ReadOnly="True" SortExpression="ID" />
        <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
        <asp:ButtonField ButtonType="Button" Text="Pwd_Reset" />
    </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" />
</asp:GridView>


<asp:AccessDataSource ID="AccessDataSource1" runat="server" 
    DataFile="~/App_Data/OnlineExam.mdb" 
    SelectCommand="SELECT [Name], [RollNo], [sub], [ID] FROM [tbmStdAcc]" 
        DeleteCommand="DELETE FROM [tbmStdAcc] WHERE [ID] = ?" 
        InsertCommand="INSERT INTO [tbmStdAcc] ([Name], [RollNo], [sub], [ID]) VALUES (?, ?, ?, ?)" UpdateCommand="UPDATE       tbmStdAcc
SET                Password1 = '12345'
WHERE        (ID = ?)">
    <DeleteParameters>
        <asp:Parameter Name="ID" Type="Int32" />
    </DeleteParameters>
    <UpdateParameters>
        <asp:SessionParameter DefaultValue="0" Name="STDID" SessionField="STDID11" />
    </UpdateParameters>
    <InsertParameters>
        <asp:Parameter Name="Name" Type="String" />
        <asp:Parameter Name="RollNo" Type="Int32" />
        <asp:Parameter Name="sub" Type="String" />
        <asp:Parameter Name="ID" Type="Int32" />
    </InsertParameters>
</asp:AccessDataSource>



</asp:Content>

