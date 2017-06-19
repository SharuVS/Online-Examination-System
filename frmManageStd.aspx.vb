
Partial Class frmManageStd
    Inherits System.Web.UI.Page

    Protected Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand

        Dim nm = e.CommandName

        Dim inx As Integer = Val(IIf(e.CommandArgument = "", 0, e.CommandArgument))


        Dim ID As Integer = GridView1.Rows(inx).Cells(3).Text
        Session("STDID11") = ID
        AccessDataSource1.Update()

        Response.Write("<SCRIPT LANGUAGE='javascript'> alert('New Password is: 12345') </SCRIPT>")

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub
End Class
