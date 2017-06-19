
Partial Class frmUser
    Inherits System.Web.UI.Page

    Protected Sub txtSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSubmit.Click

        Try
            Dim oUser As New cAdminUser("")
            oUser.FullNm = txtFullNm.Text
            oUser.Department = txtDep.Text
            oUser.UName = txtUNm.Text
            oUser.UPassword = txtPwd.Text

            oUser.insert()
            lblMsg.Visible = True

        Catch ex As Exception
            lblMsg.Text = "Error "
            lblMsg.Visible = True
        End Try



    End Sub
End Class
