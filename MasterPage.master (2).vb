
Partial Class MasterPage
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim s As String
        's = Request.QueryString("Type")
        Dim obj As cAdminUser
        Dim oStd As cStdUser

        obj = Session("admin")


        If obj Is Nothing Then

            oStd = Session("std")

            If oStd Is Nothing Then

                Response.Redirect("~/Default.aspx?Error=Your session is expired, Plz Login")

            Else
                lblMsg.Text = "Welcome " & oStd.FullNm
                Menu1.Visible = False
            End If
        Else

            lblMsg.Text = "Welcome " & obj.FullNm
            Menu1.Visible = True
        End If

    End Sub

End Class

