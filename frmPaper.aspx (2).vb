Imports System.IO

Partial Class frmPaper
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            lblPaper.Text = Request.QueryString("Paper")
            'ViewState("Paper") = lblPaper.Text
        End If


    End Sub

    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim p As New cPaper("")

            p.Paper = lblPaper.Text
            p.Que = txtQue.Text
            p.A = txtA.Text
            p.B = txtB.Text
            p.C = txtC.Text
            p.D = txtD.Text
            p.Ans = txtAns.Text
            p.img = Nothing


            If FileUpload1.PostedFile IsNot Nothing Then
                ' Get a reference to PostedFile object
                Dim myFile As HttpPostedFile = FileUpload1.PostedFile

                ' Get size of uploaded file
                Dim nFileLen As Integer = myFile.ContentLength

                ' make sure the size of the file is > 0
                If nFileLen > 0 Then
                    ' Allocate a buffer for reading of the file
                    Dim myData As Byte() = New Byte(nFileLen - 1) {}

                    ' Read uploaded file from the Stream
                    myFile.InputStream.Read(myData, 0, nFileLen)

                    ' Create a name for the file to store
                    ' Dim strFilename As String = Path.GetFileName(myFile.FileName)

                    ' Write data into a file
                    'WriteToFile(Server.MapPath(strFilename), myData)

                    ' Store it in database
                    'Dim nFileID As Integer = WriteToDB(strFilename, myFile.ContentType, myData)

                    p.img = myData
                End If
            End If


            p.insert()
            GridView1.Sort("Qno", SortDirection.Ascending)
            GridView1.DataBind()

            txtQue.Text = ""
            txtA.Text = ""
            txtB.Text = ""
            txtC.Text = ""
            txtD.Text = ""
            txtAns.Text = "A"

            'Page_Load(sender, e)
            'Response.Redirect("~/frmPaper.aspx?Paper=" & lblPaper.Text)

            Response.AddHeader("Refresh", "1")

        Catch ex As Exception

        End Try



    End Sub




    Protected Sub btnLoad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        ' Check to see if file was uploaded
        If FileUpload1.PostedFile IsNot Nothing Then
            ' Get a reference to PostedFile object
            Dim myFile As HttpPostedFile = FileUpload1.PostedFile

            ' Get size of uploaded file
            Dim nFileLen As Integer = myFile.ContentLength

            ' make sure the size of the file is > 0
            If nFileLen > 0 Then
                ' Allocate a buffer for reading of the file
                Dim myData As Byte() = New Byte(nFileLen - 1) {}

                ' Read uploaded file from the Stream
                myFile.InputStream.Read(myData, 0, nFileLen)

                ' Create a name for the file to store
                Dim strFilename As String = Path.GetFileName(myFile.FileName)

                ' Write data into a file
                ' WriteToFile(Server.MapPath(strFilename), myData)

                '' Store it in database
                'Dim nFileID As Integer = WriteToDB(strFilename, myFile.ContentType, myData)

                ' Set label's text
                lblImgSize.Text = "Image Size : "
                lblSize1.Text = nFileLen.ToString()


                ' Set URL of the the object to point to the file we've just saved
                imgFile.ImageUrl = strFilename
                imgFile.ToolTip = "This file was stored to as file."


                
                ' show the images and text
                imgFile.Visible = True
                lblImgSize.Visible = True
                lblSize1.Visible = True

            End If
        End If

    End Sub


    Private Sub WriteToFile(ByVal strPath As String, ByRef Buffer As Byte())

        ' Create a file
        Dim newFile As New FileStream(strPath, FileMode.Create)

        ' Write data to the file
        newFile.Write(Buffer, 0, Buffer.Length)

        ' Close file
        newFile.Close()
    End Sub


End Class
