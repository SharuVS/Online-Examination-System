Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Web.UI.Page


Public Class cAdminUser

    Dim mUserNm As String
    Dim mPwd As String

    Dim mFullNm As String
    Dim dpt As String
    

    Dim mConn As OleDbConnection



    

    Public Property UName() As String
        Get
            Return mUserNm
        End Get
        Set(ByVal value As String)
            mUserNm = value
        End Set
    End Property


    Public Property UPassword() As String
        Get
            Return mPwd
        End Get
        Set(ByVal value As String)
            mPwd = value
        End Set
    End Property


    Public Property FullNm() As String
        Get
            Return mFullNm
        End Get
        Set(ByVal value As String)
            mFullNm = value
        End Set
    End Property


    Public Property Department() As String
        Get
            Return dpt
        End Get
        Set(ByVal value As String)
            dpt = value
        End Set
    End Property


    



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



    Public Function getuser(ByVal uid As String) As cAdminUser
        Dim cmd As OleDbCommand
        'Dim param As oledbParameter
        Dim sQuery As String
        Dim oUser As New cAdminUser
        Dim oReader As OleDbDataReader

        uid = uid.ToUpper()
        sQuery = "Select * from tbmAdminAcc where uname='" & uid & "' ;"

        Try
            cmd = New OleDbCommand(sQuery, mConn)


            oReader = cmd.ExecuteReader()


            While oReader.Read()


                oUser.UName = oReader("Uname")
                oUser.UPassword = oReader("password")
                oUser.FullNm = oReader("Name")
                oUser.Department = oReader("Dep")




            End While

            'Else
            '  Throw New Exception(" Invalid user name. ")
            ' End If

        Catch ex As Exception
            Throw ex
        End Try

        Return oUser
    End Function



    Public Function insert() As Integer
        Dim cmd As OleDbCommand
        Dim SQLQuery As String

        SQLQuery = "Insert into tbmAdminAcc (Uname,Password,Name,Dep) values "

        SQLQuery = SQLQuery & "( '" & UName & "', '" & UPassword & "', '" & FullNm

        SQLQuery = SQLQuery & "', '" & Department & "')"

        Try
            cmd = New OleDbCommand(SQLQuery, mConn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        End Try

        Return 0
    End Function

End Class

