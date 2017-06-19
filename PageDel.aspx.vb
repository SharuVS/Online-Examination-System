
Partial Class PageDel
    Inherits System.Web.UI.Page




    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim str, paper As String
        Dim i As Integer

        str = Request.QueryString("Del")
        paper = Request.QueryString("Paper")

        i = Convert.ToInt32(str)

        Try
            Dim s As New cPaper("")
            s.Delete(i)

        Catch ex As Exception

        End Try
        Response.Redirect("~/frmPaper.aspx?Paper=" & paper)

    End Sub


End Class
