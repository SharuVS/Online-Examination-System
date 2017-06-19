<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="frmQuestionSet.aspx.vb" Inherits="frmQuestionSet" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p align="left">
        <br />
&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Add New Question :"></asp:Label>
                                        </p>
                                        <p align="left">
                                            <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
                                                DataFile="~/App_Data/OnlineExam.mdb" 
                                                SelectCommand="SELECT DISTINCT [Paper] FROM [tbmPaper]">
                                            </asp:AccessDataSource>
                                        </p>
                                        <p align="left" style="margin-left: 40px">
                                            Paper :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:DropDownList ID="ddlPaper" runat="server" 
                                                DataSourceID="AccessDataSource1" DataTextField="Paper" Width="148px">
                                            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Button ID="Button2" runat="server" Text="Add / Edit" />
                                        </p>
                                        <p align="left" style="margin-left: 40px">
                                            &nbsp;</p>
                                        <p align="left" style="margin-left: 40px">
                                            &nbsp;</p>
                                        <p align="left" style="margin-left: 40px">
                                            Create New Paper     </p>
    <p align="left" style="margin-left: 40px">
        Paper Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPaper" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    <p align="left" style="margin-left: 440px">
        <asp:Button ID="Button1" runat="server" Text="Create" />
    </p>
    <p align="left" style="margin-left: 40px">
        &nbsp;</p>
    <p align="left" style="margin-left: 40px">
        &nbsp;</p>
</asp:Content>

