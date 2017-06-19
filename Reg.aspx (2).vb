
Partial Class Reg
    Inherits System.Web.UI.Page

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        If txtFullNm.Text = "" Then
            Exit Sub
        End If


        Dim oUser As New cStdUser("")
        On Error Resume Next

        With oUser
            .FullNm = txtFullNm.Text
            .RollNo = txtRollNo.Text
            .Section = txtSection.Text
            .Branch = txtBranch.Text
            .Subject = txtPaper.Text
            .Score = "-1"

            .UName = txtUNm.Text
            .UPassword = txtPassword.Text


            If .CheckRollNo(Convert.ToInt32(txtRollNo.Text)) = 0 Then
                If .CheckUid(txtUNm.Text) = 0 Then
                    .insert()


                    Response.Write("<SCRIPT LANGUAGE='javascript'> alert('Student Register Seccessfull.') </SCRIPT>")
                    ' MsgBox("Student Register Seccessfull.", MsgBoxStyle.Information, "Online Exam")
                    'Response.Write("alert('Student Register Seccessfull');")
                    'Response.Write("<script language='javascript'>window.alert('Student Register Seccessfull.');</script>")

                    ' Response.Redirect("~/Default.aspx")
                Else
                    MsgBox("User ID already in Used")
                    lblInvalidUserID.Text = "User ID already in Used"
                    lblInvalidUserID.Visible = True
                End If
            Else
                'MsgBox("Roll-No Already Registor.", MsgBoxStyle.Information)
                lblInvalidUserID.Text = "Roll-No Already Registor."
                lblInvalidUserID.Visible = True


            End If


        End With
       
        txtFullNm.Text = ""

    End Sub
End Class
