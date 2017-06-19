
Partial Class frmSetting
    Inherits System.Web.UI.Page


    
    Protected Sub btnSet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSet.Click

        Try

            Dim oSet As New cSetting("")

            oSet.Parper_Time = Convert.ToInt32(txtMin.Text)
            oSet.Marks = Convert.ToInt32(txtMark.Text)
            oSet.Question = Convert.ToInt32(txtQue.Text)

            If ddlDispaly.Text = "Yes" Then
                oSet.Result = 1
            Else
                oSet.Result = 0
            End If

           
            oSet.Apply()
            lblMsg.Visible = True

        Catch ex As Exception

        End Try
    End Sub



    Protected Sub Page_LoadComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadComplete

        If Not IsPostBack Then
            Dim oSet As New cSetting("")

            oSet.getSetting()

            txtMin.Text = oSet.Parper_Time
            txtMark.Text = oSet.Marks
            txtQue.Text = oSet.Question
            If oSet.Result = 1 Then
                ddlDispaly.Text = "Yes" 'oSet.Result
            Else
                ddlDispaly.Text = "No" 'oSet.Result
            End If
        End If

    End Sub
End Class
