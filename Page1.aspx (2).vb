
Partial Class Page1
    Inherits System.Web.UI.Page


    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Response.Redirect("~/Page2.aspx?Paper=" & lblPaper.Text) ' & lblPaper.Text & "&topno=5")
    End Sub



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            Dim finish As Boolean
            Dim o As New cSetting("")
            o = o.getAll()

            lblTime.Text = o.Parper_Time
            lblQue.Text = o.Question

            Dim s As cStdUser
            s = Session("std")

            Session("Qp") = s.Subject

            lblNm.Text = s.FullNm
            lblBranch.Text = s.Branch
            lblPaper.Text = s.Subject
            lblRollNo.Text = s.RollNo
            lblSection.Text = s.Section
            finish = s.Finish

            If finish Then
                lblFinish.Visible = True
                Button1.Visible = False
            End If

        Catch ex As Exception

        End Try
    End Sub



End Class
