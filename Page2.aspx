<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Page2.aspx.vb" Inherits="Page2" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style10
        {
            width: 543px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p align="right">
        &nbsp;<asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </p>
    <p align="right">
        <asp:Timer ID="Timer1" runat="server" Enabled="False">
        </asp:Timer>
    </p>
    
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID ="Timer1" EventName ="Tick" />
        
    </Triggers>
        <ContentTemplate>
            <div align="left">
                <p align="left">
                    <asp:Label ID="lblqID" runat="server" Visible="False"></asp:Label>
                    &nbsp;
                    <asp:Label ID="lblstdID" runat="server" Visible="False"></asp:Label>
                    &nbsp;
                    <asp:Label ID="lblqueNo" runat="server" Text="10" Visible="False"></asp:Label>
                </p>
                <p align="right">
                    Time Remaing (Minutes) :&nbsp;
                    <asp:Label ID="lblTime" runat="server" BackColor="#FFFF66" Font-Bold="True" 
                        Font-Italic="False" Font-Size="Large" Text="0.0"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </p>
                <p align="left">
                    <table style="width:100%;">
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="Q"></asp:Label>
                                &nbsp;<asp:Label ID="lblQno" runat="server"></asp:Label>&nbsp;:
                            </td>
                            <td colspan="2">
                                <asp:Label ID="lblQue" runat="server" Width="600px"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Image ID="Pic1" runat="server" Height="70%" Width="90%"  />
                                </td>
                            <td align="left" rowspan="5">
                                <asp:ListBox ID="lstQ" runat="server" Height="100%" Width="100%" 
                                    AutoPostBack="True"></asp:ListBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:RadioButton ID="rdA" runat="server" AutoPostBack="True" GroupName="a" />
                            </td>
                        </tr>
                          <tr>
                            <td colspan="2">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                
                                <asp:RadioButton ID="rdB" runat="server" AutoPostBack="True" GroupName="a" />
                                
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:RadioButton ID="rdC" runat="server" GroupName="a" AutoPostBack="True" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:RadioButton ID="rdD" runat="server" GroupName="a" AutoPostBack="True" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblSecRc" runat="server"></asp:Label>
                            </td>
                            <td class="style10">
                                
                                    <asp:Button ID="btnBack" runat="server" Text="&lt;&lt; Back" />
                                    &nbsp;
                                    <asp:Button ID="btnNext" runat="server" Text="Next &gt;&gt;" />
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                                    <asp:Button ID="btnFinish" runat="server" Text="Finish" />
                                
                            </td>
                        </tr>
                    </table>
                </p>
                <p align="left" style="margin-left: 80px">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns=true  >
                        <Columns>
                            <asp:ImageField DataAlternateTextField="img">
                            </asp:ImageField>
                        </Columns>
                    </asp:GridView>
                </p>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <p align="left">
        <asp:GridView ID="Rec" runat="server" Width="100%" Visible="False">
        </asp:GridView>
    </p>
</asp:Content>

