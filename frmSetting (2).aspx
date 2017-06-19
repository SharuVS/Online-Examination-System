<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="frmSetting.aspx.vb" Inherits="frmSetting" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p align="left">
    &nbsp;</p>
<p align="left" style="margin-left: 40px">
&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Paper Setting :"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblMsg" runat="server" BackColor="Yellow" 
        Text="Save Satting Successful" Visible="False"></asp:Label>
    <br />
</p>
<p style="width: 640px; margin-left: 40px">
    <table align="right" style="width:100%;">
        <tr>
            <td align="right">
                Paper Time :</td>
            <td align="left">
                <asp:TextBox ID="txtMin" runat="server" Width="99px"></asp:TextBox>
&nbsp;Minute</td>
            <td>
                <asp:RangeValidator ID="RangeValidator1" runat="server" 
                    ErrorMessage="Invalid Time Range" MaximumValue="180" MinimumValue="5" 
                    Type="Integer" ControlToValidate="txtMin"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td align="right">
                Total No of Question:</td>
            <td align="left">
                <asp:TextBox ID="txtQue" runat="server" Width="99px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtQue" ErrorMessage="Enter Value"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right">
                Mark on each Qution :</td>
            <td align="left">
                <asp:TextBox ID="txtMark" runat="server" Width="99px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtMark" ErrorMessage="Enter Value"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right">
                Result Display :</td>
            <td align="left">
                <asp:DropDownList ID="ddlDispaly" runat="server">
                    <asp:ListItem>Yes</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btnSet" runat="server" Text="Set" Width="111px" />
&nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</p>
</asp:Content>

