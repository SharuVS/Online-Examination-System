
Partial Class frmQuestionSet
    Inherits System.Web.UI.Page

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Response.Redirect("~/frmPaper.aspx?Paper=" & ddlPaper.Text)
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtPaper.Text <> "" Then
            Response.Redirect("~/frmPaper.aspx?Paper=" & txtPaper.Text)
        End If

    End Sub
End Class
