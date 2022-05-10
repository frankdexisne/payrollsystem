Imports System.Data.Odbc
Public Class DBConnection

    Public connectionString As String = "DRIVER={MySQL ODBC 8.0 ANSI Driver}; SERVER=localhost; DATABASE=payroll; UID=root; PASSWORD=secret; OPTION=3;"
    Dim connString As String = "Dsn=payroll;uid=root;allowMultiQueries=true"
    Public objConn As New OdbcConnection
    Public objCmd As New OdbcCommand
    Public objDa As New OdbcDataAdapter
    Public objDataTable As New DataTable
    Public strsql As String

    Public Sub New()
        Me.objConn = New OdbcConnection(connString)
    End Sub

    Public Function nonQuery() As Integer
        Me.objConn.Open()
        Me.objCmd.Connection = Me.objConn
        Me.objCmd.CommandText = Me.strsql
        Dim rowsAffected As Integer = Me.objCmd.ExecuteNonQuery()
        Me.objConn.Close()
        Return rowsAffected
    End Function

    Public Function getLastInsertedId() As Integer
        Me.objConn.Open()
        Me.objCmd.Connection = Me.objConn
        Me.objCmd.CommandText = Me.strsql
        Dim lastInsertedId As Integer = Convert.ToInt32(Me.objCmd.ExecuteScalar())
        Me.objConn.Close()
        Return lastInsertedId
    End Function

    Public Function Dtable() As DataTable
        Dim dt As New DataTable
        With Me.objConn
            .Open()
            With Me.objCmd
                .CommandText = Me.strsql
                .Connection = Me.objConn
                .CommandType = CommandType.Text

                Me.objDa = New OdbcDataAdapter(Me.objCmd)
                Me.objDa.Fill(dt)
            End With
            .Close()
        End With
        Return dt
    End Function


End Class
