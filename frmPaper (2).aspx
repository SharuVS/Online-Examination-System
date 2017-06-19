<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="frmPaper.aspx.vb" Inherits="frmPaper" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style10
        {
            height: 21px;
            width: 301px;
        }
    </style>







</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" 
            Font-Underline="True" Text="Question Paper"></asp:Label>
    &nbsp;[
        <asp:Label ID="lblPaper" runat="server" Font-Bold="True"></asp:Label>
&nbsp;]</p>
    <p>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/OnlineExam.mdb" 
            SelectCommand="SELECT * FROM [tbmPaper] where Paper=? order by ID">
            <SelectParameters>
                <asp:ControlParameter ControlID="lblPaper" Name="Paper1" PropertyName="Text" />
            </SelectParameters>
        </asp:AccessDataSource>
        
        
    </p>
    
    
    
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" 
            CellPadding="4" DataSourceID="AccessDataSource1" 
            ForeColor="Black" Width="100%" AllowPaging="True" 
        AllowSorting="True" GridLines="Vertical"  >
            <FooterStyle BackColor="#CCCC99" />
            <RowStyle BackColor="#F7F7DE" />
            
            <Columns>
        
                <asp:BoundField DataField="Question" HeaderText="Question" 
                    SortExpression="Question">
                    <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="a" HeaderText="A" SortExpression="a">
                    <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="c" HeaderText="C" SortExpression="c">
                    <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="b" HeaderText="B" SortExpression="b">
                    <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="d" HeaderText="D" SortExpression="d">
                    <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="ans" HeaderText="Ans" SortExpression="ans">
                    <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:HyperLinkField DataNavigateUrlFields="ID,Paper" 
                    DataNavigateUrlFormatString="~/PageDel.aspx?Del={0}&Paper={1}" HeaderText="Delete" 
                    Text="Delete" />
            </Columns>
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        
    <p>
        &nbsp;</p>
        

        
    <p>
        <table style="width:100%;">
            <tr>
                <td align="left" colspan="3">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" 
                        Text="Add New Question :"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblQue" runat="server"> Que No : </asp:Label>
                </td>
                <td colspan="2" align="justify">
                    <asp:TextBox ID="txtQue" runat="server" Height="58px" TextMode="MultiLine" 
                        Width="625px"></asp:TextBox>
                </td>
            </tr>
            
              <tr>
                <td>
                    <asp:Label ID="Label2" runat="server"> Image : </asp:Label>
                </td>
                <td colspan="2" align="justify">
                    <asp:Image ID="imgFile" runat="server" Height="282px" Visible="False" 
                        Width="620px" />
                </td>
            </tr>
            
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Label ID="lblImgSize" runat="server" Text="--"></asp:Label>
                    <asp:TextBox ID="lblSize1" runat="server" BorderStyle="None" Enabled="False" 
                        ReadOnly="True" Visible="False"></asp:TextBox>
                                                    </td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" Width="236px" />
                    <asp:Button ID="btnLoad" 
                        runat="server" CausesValidation="False" Text="Load Image" 
                        Visible="False" />
                                                    </td>
            </tr>
            <tr>
                <td class="style10">
                    A)</td>
                <td class="style10" colspan="2" align="left">
                    <asp:TextBox ID="txtA" runat="server" Width="626px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    B)</td>
                <td colspan="2" align="left">
                    <asp:TextBox ID="txtB" runat="server" Width="625px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    C)</td>
                <td colspan="2" align="left">
                    <asp:TextBox ID="txtC" runat="server" Width="626px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    D)</td>
                <td colspan="2" align="left">
                    <asp:TextBox ID="txtD" runat="server" Width="626px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtQue" Display="Dynamic" ErrorMessage="Enter Question"></asp:RequiredFieldValidator><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtA" Display="Dynamic" ErrorMessage="Option A"></asp:RequiredFieldValidator><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtB" Display="Dynamic" ErrorMessage="Option  B"></asp:RequiredFieldValidator><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="txtD" Display="Dynamic" ErrorMessage="Option D"></asp:RequiredFieldValidator><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="txtC" Display="Dynamic" ErrorMessage="Option C "></asp:RequiredFieldValidator></td>
            </tr>
                        <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:RangeValidator ID="RangeValidator2" runat="server" 
                        ControlToValidate="lblSize1" Display="Dynamic" 
                        ErrorMessage="Image Size large (100Kb Only)" MaximumValue="100000"></asp:RangeValidator>
                        
                        
            </tr>
            <tr>
                <td>
                    Ans :</td>
                <td align="left">
                    <asp:DropDownList ID="txtAns" runat="server" Width="85px">
                        <asp:ListItem>A</asp:ListItem>
                        <asp:ListItem Value="B"></asp:ListItem>
                        <asp:ListItem Value="C"></asp:ListItem>
                        <asp:ListItem Value="D"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Button ID="btnSave" runat="server" Text="Add New Question" Width="157px" />
                </td>
            </tr>
            <tr>
                <td colspan="3">
&nbsp;
                    &nbsp;&nbsp;
                    </td>
            </tr>
            </table>
      </p> 
    <p>
        &nbsp;</p>
    <br />
    <br />
</asp:Content>

