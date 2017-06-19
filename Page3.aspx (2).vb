
Partial Class Page3
    Inherits System.Web.UI.Page

    Dim reloadPage As Boolean = True

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim s As cStdUser
        s = Session("std")
        lblStdId.Text = s.ID
        lblRoll.Text = s.RollNo



    End Sub

    Protected Sub Page_LoadComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadComplete

        If reloadPage Then
            If (Not IsPostBack) Then

                Try
                    Dim min, max, i As Integer
                    Dim stdPaper As New cStdPaper("")
                    Dim stdUser As New cStdUser("")
                    Dim st As New cSetting("")

                    Dim Qid, Sid As Integer
                    Dim att, ans, score As String

                    st = st.getAll()

                    'set qpaper grid

                    gridPaper.DataSource = Session("qPaper1")
                    gridPaper.DataBind()

                    Session("qPaper1") = Nothing

                    Dim count As Integer

                    count = 0
                    min = 0
                    'max = Rec.Rows.Count
                    max = st.Question


                    Sid = Convert.ToInt32(lblStdId.Text)

                    For i = 0 To gridPaper.Rows.Count - 1
                        Qid = gridPaper.Rows(i).Cells(1).Text
                        ans = gridPaper.Rows(i).Cells(8).Text

                        att = stdPaper.check(Qid, Sid)

                        If (ans = att) Then
                            count = count + 1
                        End If

                    Next


                    score = (count / max) * 100

                    lblScore.Text = lblScore.Text & score

                    stdUser.UpdateScore(Sid, score)

                    'AccessDataSource2.Select(System.Web.UI.DataSourceSelectArguments.Empty)


                    If st.Result = 0 Then
                        lblScore.Text = "For Result contact to administrator."
                    Else
                        'AccessDataSource2.Select(DataSourceSelectArguments.Empty)


                    End If

                    stdUser = Session("std")



                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                ViewState("Now") = 0
                Session("std") = Nothing

            End If
        End If
    End Sub

    
End Class
