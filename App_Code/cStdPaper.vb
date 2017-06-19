Imports Microsoft.VisualBasic
Imports System.Data.OleDb

Public Class cStdPaper

    Dim mID As Integer
    Dim mStdID As Integer
    Dim mPaperID As Integer
    Dim mAns As String
    Dim Matt As String


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


    Public Property ID() As Integer
        Get
            Return mID
        End Get
        Set(ByVal value As Integer)
            mID = value
        End Set
    End Property


    Public Property StdID() As Integer
        Get
            Return mStdID
        End Get
        Set(ByVal value As Integer)
            mStdID = value
        End Set
    End Property


    Public Property PaperID() As Integer
        Get
            Return mPaperID
        End Get
        Set(ByVal value As Integer)
            mPaperID = value
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


    Public Property Att() As String
        Get
            Return Matt
        End Get
        Set(ByVal value As String)
            Matt = value
        End Set
    End Property




    Public Function check(ByVal paperId As Integer, ByVal roll As Integer) As String

        Dim cmd As OleDbCommand
        Dim sQuery As String
        Dim oReader As OleDbDataReader
        Dim rval As String

        rval = 0

        Try
            sQuery = "select * from tbxstdPaper where paperID = " & paperId & " and stdId= " & roll
            cmd = New OleDbCommand(sQuery, mConn)
            oReader = cmd.ExecuteReader()

            While oReader.Read
                rval = oReader("ans")
            End While

        Catch ex As Exception
            Throw ex
        End Try

        Return rval

    End Function



    Public Function insert() As Integer
        Dim cmd As OleDbCommand
        Dim SQLQuery As String

        SQLQuery = "Insert into tbxstdPaper (stdID,paperID,ans) values "

        SQLQuery = SQLQuery & "( " & StdID & ", " & PaperID & ", '" & Ans & "')"

        Try
            cmd = New OleDbCommand(SQLQuery, mConn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        End Try

        Return 0
    End Function


    Public Function Update(ByVal pid As Integer) As Integer
        Dim cmd As OleDbCommand
        Dim sQuery As String

        Try
            sQuery = "Update tbxstdPaper set ans= '" & Ans & "' where PaperID =  " & pid

            cmd = New OleDbCommand(sQuery, mConn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        End Try

    End Function




    Public Function getAll() As cStdPaper
        Dim cmd As OleDbCommand
        Dim sQuery As String
        Dim oReader As OleDbDataReader
        Dim rval As String
        Dim s As New cStdPaper

        rval = 0

        Try
            sQuery = "select * from tbxstdPaper"
            cmd = New OleDbCommand(sQuery, mConn)
            oReader = cmd.ExecuteReader()

            While oReader.Read
                s.Ans = oReader("ans")
                s.ID = oReader("ID")
                s.PaperID = oReader("paperID")
                s.StdID = oReader("stdID")

            End While

        Catch ex As Exception
            Throw ex
        End Try

        Return s

    End Function





   
End Class
