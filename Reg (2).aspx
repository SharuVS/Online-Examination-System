<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Reg.aspx.vb" Inherits="Reg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="PageSetting.css" rel="Stylesheet" type="text/css" />
    <style type="text/css">
        .style2
        {
            width: 376px;
        }
        .style3
        {
            width: 154px;
        }
        .login
        {
            font-size: medium;
        }
        .style4
        {
        }
        .style5
        {
            height: 24px;
        }
        .style6
        {
            height: 27px;
        }
    </style>
</head>



<body>
    <form id="form1" runat="server">
    
        <center>
        <div style="border: medium solid #4A4AFF; background-color: #FFFFFF; width: 900px; top: 30px">
        <table style="width:100%;">
             <tr>
                
                
              <td>
                  <div class="Banner">
                  <table style="width:100%;" align="left">
                      <tr>
                          <td class="style2">
                              </td>
                          <td class="style3">
                              &nbsp;</td>
                          <td class="style5" rowspan="2">
                              <br />
                              <br />
                              <br />
                              </td>
                      </tr>
                      <tr>
                          <td class="style2">
                              &nbsp;</td>
                          <td class="style3">
                              &nbsp;</td>
                      </tr>
                      <tr>
                          <td class="style2">
                              &nbsp;</td>
                          <td class="style3">
                              &nbsp;</td>
                          <td>
                              &nbsp;</td>
                      </tr>
                  </table>
                  </div>
              </td>
             </tr>
             
            <tr>
             <td>
             
              <div class="LoginSide2">
              
              
              
              <div align="left">
              <br />
              
              &nbsp; <b>Student Registation :</b><table style="width:100%;" align="right">
                      <tr>
                          <td class="style5">
                                            <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
                                                DataFile="~/App_Data/OnlineExam.mdb" 
                                                SelectCommand="SELECT DISTINCT [Paper] FROM [tbmPaper]">
                                            </asp:AccessDataSource>
                                        </td>
                          <td class="style5">
                              &nbsp;</td>
                          <td class="style5">
                              </td>
                                        </tr>
                      <tr>
                          <td class="style4" align="right">
                                                <asp:Label ID="Label5" runat="server" Text="Student Name :"></asp:Label>
                                            </td>
                          <td>
                                                <asp:TextBox ID="txtFullNm" runat="server"></asp:TextBox>
                                            </td>
                          <td>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                  ControlToValidate="txtFullNm" ErrorMessage="Enter Name"></asp:RequiredFieldValidator>
                          </td>
                                        </tr>
                      <tr>
                          <td class="style4" align="right">
                                                <asp:Label ID="Label6" runat="server" Text="Roll No :"></asp:Label>
                                            </td>
                          <td>
                                                <asp:TextBox ID="txtRollNo" runat="server"></asp:TextBox>
                                            </td>
                          <td>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                  ControlToValidate="txtRollNo" Display="Dynamic" ErrorMessage="Enter Roll No"></asp:RequiredFieldValidator>
                              <asp:RangeValidator ID="RangeValidator1" runat="server" 
                                  ControlToValidate="txtRollNo" Display="Dynamic" ErrorMessage="Invalid Roll No" 
                                  MaximumValue="99999" MinimumValue="1" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
                          </td>
                                        </tr>
                      <tr>
                          <td class="style4" align="right">
                                                <asp:Label ID="Label7" runat="server" Text="Branch :"></asp:Label>
                                            </td>
                          <td>
                                                <asp:TextBox ID="txtBranch" runat="server"></asp:TextBox>
                                            </td>
                          <td>
                              &nbsp;</td>
                                        </tr>
                      <tr>
                          <td class="style4" align="right">
                                                <asp:Label ID="Label8" runat="server" Text="Section :"></asp:Label>
                                            </td>
                          <td>
                                                <asp:TextBox ID="txtSection" runat="server"></asp:TextBox>
                                            </td>
                          <td>
                              &nbsp;</td>
                                        </tr>
                      <tr>
                          <td class="style6" align="right">
                                                <asp:Label ID="Label9" runat="server" Text="Exam Subject :"></asp:Label>
                                            </td>
                          <td class="style6">
                              <asp:DropDownList ID="txtPaper" runat="server" Width="144px" 
                                  DataSourceID="AccessDataSource1" DataTextField="Paper">
                              </asp:DropDownList>
                          </td>
                          <td class="style6">
                              </td>
                                        </tr>
                      <tr>
                          <td class="style4">
                              &nbsp;</td>
                          <td>
                              &nbsp;</td>
                          <td>
                              &nbsp;</td>
                                        </tr>
                      <tr>
                          <td class="style4">
                              &nbsp;</td>
                          <td>
                              <asp:Label ID="lblInvalidUserID" runat="server" Font-Bold="True" 
                                  Font-Size="Large" ForeColor="Red" Text="--" Visible="False"></asp:Label>
                                                </td>
                          <td>
                              &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="right" style="margin-left: 40px" class="style4">
                                                <asp:Label ID="Label2" runat="server" Text="Enter User ID :"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtUNm" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                    ControlToValidate="txtUNm" ErrorMessage="Enter User ID"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style4">
                                                <asp:Label ID="Label3" runat="server" Text="Password :"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                    ControlToValidate="txtPassword" ErrorMessage="Enter Password"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style4" align="right">
                                                <asp:Label ID="Label4" runat="server" Text="Retype Password :"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtrePwd" runat="server" TextMode="Password"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                                    ControlToCompare="txtPassword" ControlToValidate="txtrePwd" 
                                                    ErrorMessage="Password Not Match"></asp:CompareValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style4">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td style="margin-left: 40px">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style4">
                                                &nbsp;</td>
                                            <td>
                                                <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                                                    onclick="btnSubmit_Click" Width="133px" />
                                            </td>
                                            <td style="margin-left: 40px">
                                                <asp:Button ID="Button1" runat="server" CausesValidation="False" 
                                                    PostBackUrl="~/Default.aspx" Text="Login" Width="129px" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style4" colspan="3">
                                                &nbsp;</td>
                                        </tr>
                                    </table>
              
              </div>
              
              
              
                                    
              </div>
              
              
             </td>
            </tr>
                 
            <tr>
             <td style="font-size: small">
             
                 <br />
             
             </td>
            </tr>
            </table>
        </div>
        </center>

    </form>
</body>


</html>
