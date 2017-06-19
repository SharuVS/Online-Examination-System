<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Page1.aspx.vb" Inherits="Page1" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style8
        {
            text-align: justify;
            width: 431px;
            margin-left: 19px;
        }
    .style10
    {
        text-align: justify;
    }
        .style11
        {
            width: 163px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p align="left">
        <br />
&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Exam Instructions" Font-Bold="True"></asp:Label>
    </p>
<p class="style10" style="width: 651px; margin-left: 40px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        Admission to exam room Late students will not be admitted to exam rooms after 
        the first 30 minutes of writing time. Student must remain in the room during the 
        first 30 minutes of writing time, and the last 15 minutes of writing time. Once 
        you have entered the exam room and reading time has commenced the option of a 
        deferred examination is not available. All seats are numbered. You must sit at a 
        desk allocated to your unit. Seat allocations are displayed outside the exam 
        room. Materials permitted in exam rooms Severe penalties apply for misconduct, 
        cheating, possession of unauthorised materials, improper use of materials, 
        unauthorised removal of materials from examination rooms or ignoring the 
        instructions given by supervisors. Penalties may include failure for the unit 
        and exclusion from the University. Please read carefully the materials permitted 
        for each examination listed on your timetable. </p>
<p align="left" >
        &nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Student Info :"></asp:Label>
    </p>
    <p align="left" style="width: 642px; margin-left: 40px" >
        <table align="center" style="width:100%;">
            <tr>
                <td align="right" class="style11">
                    Student Name :</td>
                <td>
                    <asp:Label ID="lblNm" runat="server"></asp:Label>
                &nbsp;&nbsp;
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style11">
                    Roll No :</td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text=" "></asp:Label>
                    <asp:Label ID="lblRollNo" runat="server"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style11">
                    Section :</td>
                <td>
                    <asp:Label ID="Label5" runat="server" Text=" "></asp:Label>
                    <asp:Label ID="lblSection" runat="server"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style11">
                    Branch :</td>
                <td>
                    <asp:Label ID="lblBranch" runat="server"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style11">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style11">
                    <b>Paper :</b></td>
                <td>
                    <asp:Label ID="lblPaper" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style11">
                    Total Qustion :</td>
                <td>
                    <asp:Label ID="lblQue" runat="server"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style11">
                    Time :
                </td>
                <td>
                    <asp:Label ID="lblTime" runat="server"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style11">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style11">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="lblFinish" runat="server" ForeColor="#FF3300" 
                        Text="You Finish your Exam !" Visible="False" Font-Bold="True"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style11">
                    &nbsp;</td>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Exam Start" 
            Width="139px" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </p>
<p align="left" class="style10" style="width: 651px; margin-left: 40px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
</asp:Content>

