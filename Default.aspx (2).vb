
Partial Class Login
    Inherits System.Web.UI.Page




    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim type As Boolean

        type = rbStd.Checked

        Session.Clear()
        Session.Timeout = 160

        If type Then
            Dim oUser As New cStdUser("")
            Try
                oUser = oUser.getuser(txtUserNm.Text)


                If oUser.UPassword = txtPwd.Text Then
                    Session("std") = oUser
                    Response.Redirect("~/page1.aspx?Type=std")
                Else
                    lblError.Visible = True

                End If

            Catch ex As Exception
                lblError.Text = ex.Message
                lblError.Visible = True
            End Try

        Else

            Dim oUser As New cAdminUser("")
            Try
                oUser = oUser.getuser(txtUserNm.Text)


                If oUser.UPassword = txtPwd.Text Then
                    Session("admin") = oUser
                    Response.Redirect("~/frmWelcome.aspx?Type=Admin")
                Else
                    lblError.Visible = True

                End If

            Catch ex As Exception
                lblError.Text = ex.Message
                lblError.Visible = True
            End Try

        End If


    End Sub


    Protected Sub btnSubmit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Load
        Session.Clear()
        lblMsg.Text = Request.QueryString("Error")
    End Sub

 
End Class
