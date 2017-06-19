Imports Microsoft.VisualBasic
Imports System.Data.Odbc
Imports System.Data.OleDb


Public Class cSetting
    Dim mTime As Integer
    Dim mQue As Integer
    Dim mMark As Integer

    Dim mResult As Integer

    Dim mConn As OleDbConnection
    'Dim mConn As OdbcConnection

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

    'Public Sub New(ByVal conn As String)

    '    'conn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\OnlineExam.mdb;Persist Security Info=True"
    '    conn = "Dsn=webExam"
    '    mConn = New OdbcConnection(conn)
    '    Try
    '        mConn.Open()
    '    Catch ex As Exception
    '        Throw ex
    '    End Try


    'End Sub


    Public Property Parper_Time() As Integer
        Get
            Return mTime
        End Get
        Set(ByVal value As Integer)
            mTime = value
        End Set
    End Property


    Public Property Question() As Integer
        Get
            Return mQue
        End Get
        Set(ByVal value As Integer)
            mQue = value
        End Set
    End Property


    Public Property Marks() As Integer
        Get
            Return mMark
        End Get
        Set(ByVal value As Integer)
            mMark = value
        End Set
    End Property





    Public Property Result() As Integer
        Get
            Return mResult
        End Get
        Set(ByVal value As Integer)
            mResult = value
        End Set
    End Property



    Public Function getAll() As cSetting
        Dim cmd As OleDbCommand
        Dim sQuery As String
        Dim o As New cSetting
        Dim oReder As OleDbDataReader


        sQuery = "Select * from tbxFormSetting where ID=1"


        Try
            cmd = New OleDbCommand(sQuery, mConn)
            oReder = cmd.ExecuteReader()

            While oReder.Read

                o.Question = oReder("tQue")
                o.Parper_Time = oReder("tTime")
                o.Marks = oReder("tMark")

                o.Result = oReder("Result")


            End While
        Catch ex As Exception

        End Try

        Return o
    End Function


    Public Function Apply() As Integer
        Dim cmd As OleDbCommand
        Dim sQuery As String

        Try
            sQuery = "Update tbxFormSetting set tQue= " & Question & ", tTime= " & Parper_Time & ", tMark=" & Marks & ", Result = " & Result & " where ID = 1 "

            cmd = New OleDbCommand(sQuery, mConn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        End Try

    End Function



    Public Function getSetting() As Integer
        Dim cmd As OleDbCommand
        Dim sQuery As String
        Dim oReader As OleDbDataReader

        Try
            sQuery = "select * from tbxFormSetting"

            cmd = New OleDbCommand(sQuery, mConn)
            oReader = cmd.ExecuteReader()

            While oReader.Read()
                Parper_Time = oReader("tTime")
                Question = oReader("tQue")
                Marks = oReader("tMark")
                Result = oReader("result")

            End While

        Catch ex As Exception
            Throw ex
        End Try

    End Function





End Class
