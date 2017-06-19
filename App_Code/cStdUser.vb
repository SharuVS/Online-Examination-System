Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Web.UI.Page


Public Class cStdUser


    Dim mUserNm As String
    Dim mPwd As String
    Dim mTime As String
    Dim mID As Integer
    Dim mFullNm As String
    Dim mRollNo As Integer
    Dim mSection As String
    Dim mBranch As String
    Dim mSub As String
    Dim mScore As String
    Dim mFinish As Boolean


    Dim mConn As OleDbConnection


    Public Property Time() As String
        Get
            Return mTime
        End Get
        Set(ByVal value As String)
            mTime = value
        End Set
    End Property



    Public Property Finish() As Boolean
        Get
            Return mFinish
        End Get
        Set(ByVal value As Boolean)
            mFinish = value
        End Set
    End Property

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


    Public Property Section() As String
        Get
            Return mSection
        End Get
        Set(ByVal value As String)
            mSection = value
        End Set
    End Property


    Public Property Branch() As String
        Get
            Return mBranch
        End Get
        Set(ByVal value As String)
            mBranch = value
        End Set
    End Property


    Public Property RollNo() As Integer
        Get
            Return mRollNo
        End Get
        Set(ByVal value As Integer)
            mRollNo = value
        End Set
    End Property


    Public Property Subject() As String
        Get
            Return mSub
        End Get
        Set(ByVal value As String)
            mSub = value
        End Set
    End Property


    Public Property Score() As String
        Get
            Return mScore
        End Get
        Set(ByVal value As String)
            mScore = value
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



    Public Function getuser(ByVal uid As String) As cStdUser
        Dim cmd As oledbCommand

        Dim sQuery As String
        Dim oUser As New cStdUser
        Dim oReader As oledbDataReader

        uid = uid.ToUpper()
        sQuery = "Select * from tbmStdAcc where uname='" & uid & "' ;"

        Try
            cmd = New oledbCommand(sQuery, mConn)


            oReader = cmd.ExecuteReader()


            While oReader.Read()


                oUser.UName = oReader("Uname")
                oUser.UPassword = oReader("password1")
                oUser.FullNm = oReader("Name")
                oUser.Section = oReader("Section1")
                oUser.Branch = oReader("Branch")
                oUser.Subject = oReader("sub")
                oUser.Score = oReader("Score")
                oUser.Finish = oReader("Finish")
                oUser.RollNo = oReader("RollNo")
                oUser.ID = oReader("ID")
                oUser.Time = Convert.ToString(oReader("RTime"))



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
        Dim cmd As oledbCommand
        Dim SQLQuery As String

        SQLQuery = "insert into tbmStdAcc (Name,RollNo,Section1,Branch,Sub,Score,Uname,Password1,Rtime) values "

        SQLQuery = SQLQuery & "('" & FullNm & "', " & RollNo & ", '" & Section

        SQLQuery = SQLQuery & "', '" & Branch & "', '" & Subject & "', '" & Score & "', '" & UName & "', '" & UPassword & "', " & -2 & ");"

        'SQLQuery = "insert into tbmStdAcc (Name,RollNo,Section1,Branch,Sub,Score,Uname,password1) values ('hh',56,'kl','i','ii','0','2','pass') "

        Try
            cmd = New oledbCommand(SQLQuery, mConn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        End Try

        Return 0
    End Function


    Public Function CheckRollNo(ByVal roll As Integer) As Integer

        Dim cmd As oledbCommand
        Dim sQuery As String
        Dim oReader As oledbDataReader

        sQuery = "Select * from tbmStdAcc;"

        Try
            cmd = New oledbCommand(sQuery, mConn)
            oReader = cmd.ExecuteReader()

            While oReader.Read()
                If oReader("RollNo") = roll Then
                    Return 1
                End If
            End While
        Catch ex As Exception
            Throw ex
        End Try

        Return 0

    End Function

    Public Function CheckUid(ByVal uid As String) As Integer

        Dim cmd As oledbCommand
        Dim sQuery As String
        Dim oReader As oledbDataReader

        sQuery = "Select * from tbmStdAcc;"

        Try
            cmd = New oledbCommand(sQuery, mConn)
            oReader = cmd.ExecuteReader()

            While oReader.Read()
                If oReader("Uname") = uid Then
                    Return 1
                End If
            End While

        Catch ex As Exception
            Throw ex
        End Try

        Return 0

    End Function


    Public Function Update() As Integer

        Dim cmd As oledbCommand
        Dim sQuery As String


        sQuery = "update tbmStdAcc set Finish=1 where ID = " & ID

        Try
            cmd = New oledbCommand(sQuery, mConn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        End Try

        Return 0

    End Function


    Public Function UpdateScore(ByVal id As Integer, ByVal s As String) As Integer

        Dim cmd As oledbCommand
        Dim sQuery As String


        sQuery = "update tbmStdAcc set Score='" & s & "' where ID = " & id

        Try
            cmd = New oledbCommand(sQuery, mConn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        End Try

        Return 0

    End Function

    Public Function UpdateTime(ByVal id As Integer, ByVal t As String) As Integer
        Dim cmd As oledbCommand
        Dim sQuery As String

        sQuery = "update tbmStdAcc set RTime='" & t & "' where ID = " & id

        Try
            cmd = New oledbCommand(sQuery, mConn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        End Try

        Return 0

    End Function


    Public Function GetTime(ByVal uid As String) As Integer

        Dim cmd As oledbCommand
        Dim sQuery As String
        Dim oReader As oledbDataReader
        Dim t As Integer

        t = -2

        sQuery = "Select * from tbmStdAcc where id= " & uid

        Try
            cmd = New oledbCommand(sQuery, mConn)
            oReader = cmd.ExecuteReader()

            While oReader.Read()
                t = Convert.ToInt32(oReader("RTime"))
            End While

        Catch ex As Exception
            Throw ex
        End Try

        Return t

    End Function



    Public Function calMark() As Integer
        Dim s As New cStdPaper("")
        Dim p As New cPaper("")

        Try
            s.getAll()
            p.getAll()





        Catch ex As Exception

        End Try


    End Function

End Class
