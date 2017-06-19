<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Page3.aspx.vb" Inherits="Page3" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p align="center">
        <br />
&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" 
            Font-Size="Large" Text="Finish Exam."></asp:Label>
    </p>
    <p align="left">
&nbsp;&nbsp;&nbsp;&nbsp; Roll No :
        <asp:Label ID="lblRoll" runat="server" Text="Roll"></asp:Label>
    </p>
                                        <p align="left">
        <asp:Label ID="lblStdId" runat="server" Text="ID" Visible="False"></asp:Label>
    </p>
    <p align="left">
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblStates" runat="server" Text="...Ok" Visible="False"></asp:Label>
    </p>
    <p align="left">
&nbsp;&nbsp;
        <asp:Label ID="lblScore" runat="server" Font-Bold="True" Font-Size="X-Large" 
            Text="Your Score : "></asp:Label>
    </p>
    <p align="left">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" PostBackUrl="~/Default.aspx" 
            Text="Login Page" Width="81px" />
    </p>
    <br />
    <asp:GridView ID="gridPaper" runat="server" Width="482px" Visible="False">
    </asp:GridView>
    <br />
    <asp:AccessDataSource ID="AccessDataSource2" runat="server" 
        DataFile="~/App_Data/OnlineExam.mdb" 
        
        
        
        
        SelectCommand="SELECT Name, RollNo, [Section], Branch, sub, Score FROM tbmStdAcc WHERE (Finish = yes) AND (ID = ?)">
        <SelectParameters>
            <asp:ControlParameter ControlID="lblStdId" Name="ID" PropertyName="Text" />
        </SelectParameters>
    </asp:AccessDataSource>
    <asp:GridView ID="GridView1" runat="server" DataSourceID="AccessDataSource2" 
        Width="100%" Visible="False">
    </asp:GridView>
    <br />
    <p>
        &nbsp;</p>
</asp:Content>

