<%@ Page Language="VB" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <link href="PageSetting.css" rel="Stylesheet" type="text/css" />
    <style type="text/css">
        .login
        {
            font-size: medium;
        }
        .style4
        {
        }
        .style6
        {
            width: 161px;
        }
        .style7
        {
            height: 31px;
        }
        .style8
        {
            width: 161px;
            height: 31px;
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
                  </div>
              </td>
             </tr>
             
            <tr>
             <td>
             
              <div class="LoginSide">
              <p>
              
                  &nbsp;</p>
                                    <p style="text-align: justify; width: 455px; margin-left: 40px">
              
              &nbsp;<b>Questions About Your Test?</b></p>
                  <p style="text-align: justify; width: 455px; margin-left: 40px">
              
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Are you wondering what other 
                      students have to say about your upcoming exam? Maybe you just need to talk to 
                      someone who has already taken it.</p>
                                    <p style="text-align: justify; width: 455px; margin-left: 40px">
              
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Online Examination 
                                        is an Internet Based Testing (IBT) which provides extensibility of distance 
                                        Examination. This computer-based tests can be offered at different times, 
                                        locations or even different tests to different students. This System Enables 
                                        registered students to attend online Courses and undergo training. The student 
                                        can then measure their profficiency in such Courses and Module themselves using 
                                        the computer based tests.</p>
                  <p style="text-align: justify; width: 455px; margin-left: 40px">
              
                                        &nbsp;</p>
              </div>
              
              <div class="Login" align="left" style="margin-right: 10px">
              <br />
              
              &nbsp; Login User:&nbsp;
                  <asp:Label ID="lblMsg" runat="server" BackColor="#FFFF99" Font-Bold="True" 
                      ForeColor="Red"></asp:Label>
                  <table style="width:100%;">
                      <tr>
                          <td class="style4">
                              &nbsp;</td>
                          <td class="style6">
                              &nbsp;</td>
                          <td>
                              &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="right" style="margin-left: 40px" class="style4">
                                                <asp:Label ID="Label2" runat="server" Text="Enter User ID :"></asp:Label>
                                            </td>
                                            <td class="style6">
                                                <asp:TextBox ID="txtUserNm" runat="server" Width="150px"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                    ControlToValidate="txtUserNm" ErrorMessage="Invalid"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style4">
                                                <asp:Label ID="Label3" runat="server" Text="Password :"></asp:Label>
                                            </td>
                                            <td class="style6">
                                                <asp:TextBox ID="txtPwd" runat="server" Width="150px" TextMode="Password"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                    ControlToValidate="txtPwd" ErrorMessage="Invalid"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style4" align="right">
                                                <asp:Label ID="Label4" runat="server" Text="User Type :"></asp:Label>
                                            </td>
                                            <td class="style6">
                                                <asp:RadioButton ID="rbStd" runat="server" Text="Student" 
                                                    GroupName="utype" Checked="True" />
&nbsp;&nbsp;&nbsp;
                                                <asp:RadioButton ID="rbAdmin" runat="server" Text="Admin" GroupName="utype" />
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style7">
                                                </td>
                                            <td class="style8">
                                                <asp:Label ID="lblError" runat="server" BackColor="Yellow" Text="Invalid ID" 
                                                    Visible="False"></asp:Label>
                                            </td>
                                            <td class="style7">
                                                <asp:Button ID="btnSubmit" runat="server" Text="Login     " style="width: 47px" 
                                                    Width="100%" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style4">
                                                &nbsp;</td>
                                            <td class="style6">
                                                &nbsp;</td>
                                            <td style="margin-left: 40px">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style4" colspan="3">
                                                &nbsp;&nbsp;&nbsp; If You Don&#39;t have ID
                                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Reg.aspx"> 
                                                Click here
                                                </asp:HyperLink>
                                                (New Student)</td>
                                        </tr>
                                    </table>
              
              </div>
              
              
             </td>
            </tr>
                 
            <tr>
             <td style="font-size: small">
             
                 <Div class="Banner_Footer" >
                  <br />
                 </Div>
                 
                
             
             </td>
            </tr>
            </table>
        </div>
        </center>

    </form>
</body>
</html>
