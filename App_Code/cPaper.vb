Imports Microsoft.VisualBasic
Imports System.Data.OleDb

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
            Return MAns
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
            para.Value = img
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




    Public Function getAll(ByVal nos As Integer, ByVal Pname As String) As ArrayList
        Dim cmd As OleDbCommand
        Dim sQuery As String
        Dim oReader As OleDbDataReader
        Dim rval As String

        Dim arr As New ArrayList()

        rval = 0

        Try
            sQuery = "SELECT TOP " & nos & "  ID, Qno, Paper, Question, a, b, c, d, ans FROM tbmPaper WHERE (Paper = '" & Pname & "') order by  Rnd(ID);"
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
End Class


Public Class cImage1
    Public img As Byte()

    Public Sub New()

    End Sub

    Public Function getImage(ByVal ID As Integer) As ArrayList
        Dim conn As String
        Dim mConn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim sQuery As String
        Dim oReader As OleDbDataReader

        Dim arr As New ArrayList()

        conn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\OnlineExam.mdb"
        'conn = "Dsn=webExam"
        mConn = New OleDbConnection(conn)
       

        Try
            mConn.Open()
            sQuery = "SELECT [img] FROM tbmPaper WHERE ID = " & ID
            cmd = New OleDbCommand(sQuery, mConn)
            Dim obj = cmd.ExecuteScalar()

            'While oReader.Read
            '    Dim s As New cImage1()

            '    s.img = oReader("img")
            '    arr.Add(s)
            'End While
            mConn.Close()
            Dim s As New cImage1()
            s.img = obj
            arr.Add(s)

        Catch ex As Exception
            Throw ex
        End Try

        Return arr

    End Function
End Class