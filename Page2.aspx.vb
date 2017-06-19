
Partial Class Page2
    Inherits System.Web.UI.Page




    Protected Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Dim max, min, now As Integer

        max = Rec.Rows.Count
        min = 0

        now = Convert.ToInt32(ViewState("Now"))


        'display New Question
        now = now + 1
        If now < max Then
            loadData(now)
            
            ViewState("Now") = now
        End If

    End Sub



    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click

        Dim min, now As Integer


        min = 0
        now = Convert.ToInt32(ViewState("Now"))

        'display New Question
        now = now - 1
        If now >= min Then
            loadData(now)
            ViewState("Now") = now
        End If



    End Sub


    Protected Sub btnFinish_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFinish.Click
        Dim s As New cStdUser("")
        Dim std As cStdUser


        std = Session("std")

        s.ID = std.ID
        s.Finish = True

        s.calMark()
        s.Update()

        'Session("std") = Nothing
        Response.Redirect("~/Page3.aspx")


    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If (Not IsPostBack) Then

            Dim s As cStdUser
            s = Session("std")

            If s Is Nothing Then
                Response.Redirect("~/Default.aspx?Error=Your session is expired, Plz Login")
            End If




            Dim sPaper As String
            Dim iTotQue As String
            Dim sett As New cSetting("")
            Dim p As New cPaper("")
            Dim stdUser As New cStdUser("")


            'Pic1.ImageUrl = "Img/banner1.jpg"

            'get Paper Sub
            sPaper = Request.QueryString("Paper")

            'get Student ID
            lblstdID.Text = s.ID


            'Get Total Que
            sett = sett.getAll()
            lblqueNo.Text = sett.Question
            iTotQue = sett.Question

            'Get all Paper table
            Dim aListQPaper As New ArrayList

            aListQPaper = p.getAll(iTotQue, sPaper)
            Rec.DataSource = aListQPaper
            Rec.DataBind()

            'save to session for calculation
            Session("qPaper1") = aListQPaper


            Dim t As Integer
            t = stdUser.GetTime(s.ID)

            If t = -2 Then
                lblTime.Text = sett.Parper_Time
            Else
                lblTime.Text = t
            End If



            Try
                Dim min, max, i As Integer
                min = 1
                max = Rec.Rows.Count

                For i = min To max
                    lstQ.Items.Add(i)
                Next

                loadData(0)

                Timer1.Enabled = True

            Catch ex As Exception

            End Try

            ViewState("Now") = 0

        End If

    End Sub

  


    Private Sub setRedio(ByVal s As String)

        If s = "A" Then
            rdA.Checked = True
        ElseIf s = "B" Then
            rdB.Checked = True
        ElseIf s = "C" Then
            rdC.Checked = True
        Else
            rdD.Checked = True
        End If
    End Sub


    Private Function getRedio() As String
        If rdA.Checked Then
            rdA.Checked = False
            Return "A"
        ElseIf rdB.Checked Then
            rdB.Checked = False
            Return "B"
        ElseIf rdC.Checked Then
            rdC.Checked = False
            Return "C"
        Else
            rdD.Checked = False
            Return "D"
        End If
    End Function

    Private Sub clearRedio()
        rdA.Checked = False
        rdB.Checked = False
        rdC.Checked = False
        rdD.Checked = False
    End Sub

    Private Sub loadData(ByVal now As Integer)

        Dim stdPaper As New cStdPaper("")
        Dim att As String

        clearRedio()
        lblQno.Text = now + 1
        lblqID.Text = Rec.Rows(now).Cells(1).Text
        lblQue.Text = Rec.Rows(now).Cells(3).Text
        rdA.Text = Rec.Rows(now).Cells(4).Text
        rdB.Text = Rec.Rows(now).Cells(5).Text
        rdC.Text = Rec.Rows(now).Cells(6).Text
        rdD.Text = Rec.Rows(now).Cells(7).Text

        'Dim oCImg As New cImage1()
        'Dim ar As New ArrayList()

        'ar = oCImg.getImage(62)
        'GridView1.DataSource = ar
        'GridView1.DataBind()

        'check Att qustion
        Dim Qid, Sid As Integer
        Qid = Convert.ToInt32(lblqID.Text)
        Sid = Convert.ToInt32(lblstdID.Text)
        att = stdPaper.check(Qid, Sid)

        If att <> "0" Then
            setRedio(att)
        End If

    End Sub

    Protected Sub lstQ_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstQ.SelectedIndexChanged
        Dim i As Integer

        i = Convert.ToInt32(lstQ.SelectedItem.Text) - 1
        ViewState("Now") = i
        
        'display New Question
        loadData(i)

    End Sub



    Protected Sub rdA_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdA.CheckedChanged
        Dim stdPaper As New cStdPaper("")
        Dim rVal As String


        rVal = stdPaper.check(Convert.ToInt32(lblqID.Text), Convert.ToInt32(lblstdID.Text))

        stdPaper.StdID = Convert.ToInt32(lblstdID.Text)
        stdPaper.PaperID = Convert.ToInt32(lblqID.Text)
        stdPaper.Ans = "A"

        If rVal = "0" Then
            stdPaper.insert()
        ElseIf rVal <> "A" Then
            stdPaper.Update(Convert.ToInt32(lblqID.Text))
        End If

    End Sub

    Protected Sub rdB_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdB.CheckedChanged
        Dim stdPaper As New cStdPaper("")
        Dim rVal As String

        rVal = stdPaper.check(Convert.ToInt32(lblqID.Text), Convert.ToInt32(lblstdID.Text))

        stdPaper.StdID = Convert.ToInt32(lblstdID.Text)
        stdPaper.PaperID = Convert.ToInt32(lblqID.Text)
        stdPaper.Ans = "B"

        If rVal = "0" Then
            stdPaper.insert()
        ElseIf rVal <> "B" Then
            stdPaper.Update(Convert.ToInt32(lblqID.Text))
        End If
    End Sub

    Protected Sub rdC_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdC.CheckedChanged
        Dim stdPaper As New cStdPaper("")
        Dim rVal As String

        rVal = stdPaper.check(Convert.ToInt32(lblqID.Text), Convert.ToInt32(lblstdID.Text))

        stdPaper.StdID = Convert.ToInt32(lblstdID.Text)
        stdPaper.PaperID = Convert.ToInt32(lblqID.Text)
        stdPaper.Ans = "C"

        If rVal = "0" Then
            stdPaper.insert()
        ElseIf rVal <> "C" Then
            stdPaper.Update(Convert.ToInt32(lblqID.Text))
        End If
    End Sub

    Protected Sub rdD_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdD.CheckedChanged
        Dim stdPaper As New cStdPaper("")
        Dim rVal As String

        rVal = stdPaper.check(Convert.ToInt32(lblqID.Text), Convert.ToInt32(lblstdID.Text))

        stdPaper.StdID = Convert.ToInt32(lblstdID.Text)
        stdPaper.PaperID = Convert.ToInt32(lblqID.Text)
        stdPaper.Ans = "D"

        If rVal = "0" Then
            stdPaper.insert()
        ElseIf rVal <> "D" Then
            stdPaper.Update(Convert.ToInt32(lblqID.Text))
        End If
    End Sub

    Protected Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim t As Integer

        t = Convert.ToInt32(lblTime.Text)
        t = t - 1
        If t <= 0 Then
            Timer1.Enabled = False
            btnFinish_Click(sender, e)
        Else
            lblTime.Text = t
            Dim s As New cStdUser("")
            s.UpdateTime(Convert.ToInt32(lblstdID.Text), t)

        End If



    End Sub
End Class
