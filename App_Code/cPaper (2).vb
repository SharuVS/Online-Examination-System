Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data

Public Class cPaper

    Dim mID As Integer
    Dim mNo As Integer
    Dim mPaper As String
    Dim mQue As String
    Dim ma As String
    Dim mb As String
    Dim mc As String
    Dim md As String
    Dim mAns As String
    Public img As Byte()
    Public isImg As Boolean


    Dim mConn As OleDbConnection


    Public Sub New()    'Default connecting string

    End Sub

    Public Sub New(ByVal conn As String)

        conn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\OnlineExam.mdb"
        'conn = "Dsn=webExam"
        mConn = New OleDbConnection(conn)
        Try
            mConn.Open()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Property QNo() As Integer
        Get
            Return mNo
        End Get
        Set(ByVal value As Integer)
            mNo = value
        End Set
    End Property


    Public Property ID() As Integer
        Get
            Return mID
        End Get
        Set(ByVal value As Integer)
            mID = value
        End Set
    End Property


    Public Property Paper() As String
        Get
            Return mPaper
        End Get
        Set(ByVal value As String)
            mPaper = value
        End Set
    End Property


    Public Property Que() As String
        Get
            Return mQue
        End Get
        Set(ByVal value As String)
            mQue = value
        End Set
    End Property


    Public Property A() As String
        Get
            Return ma
        End Get
        Set(ByVal value As String)
            ma = value
        End Set
    End Property


    Public Property B() As String
        Get
            Return mb
        End Get
        Set(ByVal value As String)
            mb = value
        End Set
    End Property


    Public Property C() As String
        Get
            Return mc
        End Get
        Set(ByVal value As String)
            mc = value
        End Set
    End Property


    Public Property D() As String
        Get
            Return md
        End Get
        Set(ByVal value As String)
            md = value
        End Set
    End Property


    Public Property Ans() As String
        Get
            Return mAns
        End Get
        Set(ByVal value As String)
            mAns = value
        End Set
    End Property


    Public Sub Delete(ByVal uid As Integer)
        Dim cmd As OleDbCommand
        Dim sQuery As String

        Try
            sQuery = "Delete from tbmPaper where ID= " & uid
            cmd = New OleDbCommand(sQuery, mConn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        End Try


    End Sub



    Public Function insert() As Integer
        Dim cmd As OleDbCommand
        Dim SQLQuery As String
        Dim para As OleDbParameter

        SQLQuery = "Insert into tbmPaper ( Qno,Paper,Question,a,b,c,d,ans,[Img]) values (?,?,?,?,?,?,?,?,?)"

        'SQLQuery = SQLQuery & "( " & QNo & ",'" & Paper & "', '" & Que & "', '" & A

        'SQLQuery = SQLQuery & "', '" & B & "', '" & C & "', '" & D & "', '" & Ans & "')"

        Try
            cmd = New OleDbCommand(SQLQuery, mConn)

            para = New OleDbParameter()
            para.Value = QNo
            cmd.Parameters.Add(para)

            para = New OleDbParameter()
            para.Value = Paper
            cmd.Parameters.Add(para)

            para = New OleDbParameter()
            para.Value = Que
            cmd.Parameters.Add(para)

            para = New OleDbParameter()
            para.Value = A
            cmd.Parameters.Add(para)

            para = New OleDbParameter()
            para.Value = B
            cmd.Parameters.Add(para)

            para = New OleDbParameter()
            para.Value = C
            cmd.Parameters.Add(para)

            para = New OleDbParameter()
            para.Value = D
            cmd.Parameters.Add(para)

            para = New OleDbParameter()
            para.Value = Ans
            cmd.Parameters.Add(para)

            para = New OleDbParameter()
            para.Value = IIf(img Is Nothing, DBNull.Value, img)
            cmd.Parameters.Add(para)

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        End Try

        Return 0
    End Function


    Public Function getAll() As cPaper

        Dim cmd As OleDbCommand
        Dim SQLQuery As String
        Dim p As New cPaper
        Dim oRed As OleDbDataReader

        SQLQuery = "select * from tbmPaper"

        Try
            cmd = New OleDbCommand(SQLQuery, mConn)
            oRed = cmd.ExecuteReader()

            While oRed.Read
                p.Ans = oRed("ans")
                p.ID = oRed("ID")
                p.Ans = oRed("ans")
                p.Ans = oRed("ans")

            End While

        Catch ex As Exception
            Throw ex
        End Try

        Return p

    End Function




    Public Function getAll(ByVal nos As Integer, ByVal Pname As String, ByVal stdID As Integer) As ArrayList
        Dim cmd As OleDbCommand
        Dim sQuery As String
        Dim oReader As OleDbDataReader
        Dim rval As String
        Dim arr As New ArrayList()

        rval = 0

        Try
            sQuery = "SELECT TOP " & nos & " tbmPaper.ID, tbmPaper.Qno, tbmPaper.Paper, tbmPaper.Question, tbmPaper.a, tbmPaper.b, tbmPaper.c, tbmPaper.d, tbmPaper.ans FROM (tbmPaper INNER JOIN  tbmstdQuePaper ON tbmstdQuePaper.PaperID = tbmPaper.ID) WHERE (tbmPaper.Paper = '" & Pname & "') AND (tbmstdQuePaper.STDID = " & stdID & ")"
            'sQuery = "SELECT TOP " & nos & "  ID, Qno, Paper, Question, a, b, c, d, ans FROM tbmPaper WHERE (Paper = '" & Pname & "') order by  Rnd(ID);"
            'sQuery = "SELECT TOP " & nos & "  ID, Qno, Paper, Question, a, b, c, d, ans FROM tbmPaper WHERE (Paper = '" & Pname & "') order by ID;"

            cmd = New OleDbCommand(sQuery, mConn)
            oReader = cmd.ExecuteReader()

            While oReader.Read
                Dim s As New cPaper

                s.ID = oReader("ID")
                s.QNo = oReader("Qno")
                s.Paper = oReader("Paper")
                s.Que = oReader("Question")
                s.A = oReader("a")
                s.B = oReader("b")
                s.C = oReader("c")
                s.D = oReader("d")
                s.Ans = oReader("ans")
                's.img = oReader("img")

                arr.Add(s)
            End While

        Catch ex As Exception
            Throw ex
        End Try

        Return arr
    End Function

    'Public Function getAll(ByVal nos As Integer, ByVal Pname As String, ByVal stdID As Integer) As ArrayList
    '    Dim cmd As OleDbCommand
    '    Dim sQuery As String
    '    Dim oReader As OleDbDataReader
    '    Dim rval As String
    '    Dim arr As New ArrayList()

    '    rval = 0

    '    Try
    '        sQuery = "SELECT TOP " & nos & " tbmPaper.ID, tbmPaper.Qno, tbmPaper.Paper, tbmPaper.Question, tbmPaper.a, tbmPaper.b, tbmPaper.c, tbmPaper.d, tbmPaper.ans,tbmPaper.img FROM (tbmPaper INNER JOIN  tbmstdQuePaper ON tbmstdQuePaper.PaperID = tbmPaper.ID) WHERE (tbmPaper.Paper = '" & Pname & "') AND (tbmstdQuePaper.STDID = " & stdID & ")"
    '        'sQuery = "SELECT TOP " & nos & "  ID, Qno, Paper, Question, a, b, c, d, ans FROM tbmPaper WHERE (Paper = '" & Pname & "') order by  Rnd(ID);"

    '        cmd = New OleDbCommand(sQuery, mConn)
    '        oReader = cmd.ExecuteReader()
    '        Dim img_temp As Byte()

    '        While oReader.Read
    '            Dim s As New cPaper

    '            s.ID = oReader("ID")
    '            s.QNo = oReader("Qno")
    '            s.Paper = oReader("Paper")
    '            s.Que = oReader("Question")
    '            s.A = oReader("a")
    '            s.B = oReader("b")
    '            s.C = oReader("c")
    '            s.D = oReader("d")
    '            s.Ans = oReader("ans")
    '            s.isImg = False

    '            '------IMAGE---------------------------------
    '            img_temp = IIf(oReader("img") IsNot DBNull.Value, oReader("img"), Nothing)

    '            If img_temp IsNot Nothing Then

    '                Dim oCImg As New cImage1()
    '                Dim obj = oCImg.getImage(Val(lblqID.Text))
    '                Dim tempPath As String = Server.MapPath("img" & Val(lblqID.Text) & ".jpg")
    '                Dim imgInfo As New FileInfo(tempPath)

    '                If imgInfo.Exists Then
    '                    imgInfo.Delete()
    '                End If
    '                If obj.Length > 100 Then
    '                    ' Create a file
    '                    Dim newFile As New FileStream(tempPath, FileMode.Create)

    '                    ' Write data to the file
    '                    newFile.Write(obj, 0, obj.Length)

    '                    ' Close file
    '                    newFile.Close()

    '                    'Pic1.ImageUrl = tempPath
    '                    ' Pic1.ImageUrl = "Img/banner1.jpg"
    '                    pic1.ImageUrl = "~/img" & Val(lblqID.Text) & ".jpg"
    '                    pic1.Visible = True
    '                Else
    '                    pic1.ImageUrl = ""
    '                    pic1.Visible = False
    '                End If

    '                If imgInfo.Exists Then
    '                    imgInfo.Delete()
    '                End If

    '            End If

    '            '-----------------------------------------------

    '            arr.Add(s)
    '        End While

    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    '    Return arr
    'End Function


    Public Sub CreateQPaper(ByVal nos As Integer, ByVal Pname As String, ByVal stdID As Integer)
        Dim cmd As OleDbCommand
        Dim sQuery As String
        Dim rval As String
        Dim arr As New ArrayList()

        rval = 0

        Try

            sQuery = "SELECT COUNT(STDID)AS Expr1 FROM tbmstdQuePaper WHERE (STDID = " & stdID & ")"
            ' p Left Join tbmstdQuePaper Qp on)
            cmd = New OleDbCommand(sQuery, mConn)
            Dim c As Integer = cmd.ExecuteScalar()

            If c <= 0 Then
                'sQuery = "SELECT TOP " & nos & "  ID, Qno, Paper, Question, a, b, c, d, ans FROM tbmPaper WHERE (Paper = '" & Pname & "') order by  Rnd(ID);"
                sQuery = "Insert into tbmstdQuePaper(STDID,PaperID) SELECT TOP " & nos & "  " & stdID & " , ID FROM tbmPaper WHERE (Paper = '" & Pname & "')  order by Rnd(ID);"
                ' p Left Join tbmstdQuePaper Qp on(Qp.STDID <> " & stdID & " )
                cmd = New OleDbCommand(sQuery, mConn)
                cmd.ExecuteNonQuery()
            End If
            
        Catch ex As Exception
            Throw ex
        End Try


    End Sub



End Class


Public Class cImage1
    Public img As Byte()

    Public Sub New()

    End Sub

    Public Function getImage(ByVal ID As Integer) As Byte()
        Dim conn As String
        Dim mConn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim sQuery As String
        Dim dt As New DataTable()
        Dim obj As Byte() = {0}

        Dim arr As New ArrayList()

        conn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\OnlineExam.mdb"
        'conn = "Dsn=webExam"
        mConn = New OleDbConnection(conn)


        Try
            mConn.Open()
            sQuery = "SELECT [img] FROM tbmPaper WHERE ID = " & ID
            cmd = New OleDbCommand(sQuery, mConn)
            obj = cmd.ExecuteScalar()

            'While oReader.Read
            '    Dim s As New cImage1()

            '    s.img = oReader("img")
            '    arr.Add(s)
            'End While

            mConn.Close()
            'Dim s As New cImage1()
            's.img = obj
            'arr.Add(s)
            dt.Columns.Add("pic1")
            dt.Rows.Add(obj)

            Return obj

        Catch ex As Exception
            Return obj
        End Try

    End Function
End Class