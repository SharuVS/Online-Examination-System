<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="frmUser.aspx.vb" Inherits="frmUser" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p align="left">
    <br />
&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" 
        Text="Create New Administrator User  "></asp:Label>
</p>
                                        <p align="center">
                                            <asp:Label ID="lblMsg" runat="server" BackColor="#FFFF66" Font-Bold="True" 
                                                ForeColor="#009900" Text="New User Has been Created " Visible="False"></asp:Label>
</p>
<p>
    <table style="width:100%;">
        <tr>
            <td align="right">
                Full Name :</td>
            <td align="left">
                <asp:TextBox ID="txtFullNm" runat="server" Width="195px"></asp:TextBox>
                *</td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtFullNm" ErrorMessage="Enter Name"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right">
                Deparment :</td>
            <td align="left">
                <asp:TextBox ID="txtDep" runat="server" Width="195px"></asp:TextBox>
            </td>
            <td>
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
        <tr>
            <td align="right">
                UserName :</td>
            <td align="left">
                <asp:TextBox ID="txtUNm" runat="server" Width="195px"></asp:TextBox>
                *</td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtUNm" ErrorMessage="Enter UserName"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right">
                Password :</td>
            <td align="left">
                <asp:TextBox ID="txtPwd" runat="server" Width="195px" TextMode="Password"></asp:TextBox>
                *</td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtPwd" ErrorMessage="Enter Password"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right">
                Re-Password :</td>
            <td align="left">
                <asp:TextBox ID="txtRePwd" runat="server" Width="195px" TextMode="Password"></asp:TextBox>
                *</td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="txtPwd" ControlToValidate="txtRePwd" 
                    ErrorMessage="Password Not Match"></asp:CompareValidator>
            </td>
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
            <td align="right">
                &nbsp;</td>
            <td align="left">
                &nbsp;</td>
            <td>
                <asp:Button ID="txtSubmit" runat="server" Text="Submit" />
            </td>
        </tr>
    </table>
</p>
<p>
</p>
</asp:Content>

