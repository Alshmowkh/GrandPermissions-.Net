Imports System.Data.SqlClient

Public Class Main
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim i, j, k As Integer
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

    End Sub

    Private Sub btnSavDo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavDo.Click
        constr()
        'Dim n As Integer = Val(Me.txtdocid.Text)
        'Dim sav As New SqlCommand
        'sav.Connection = conn
        'sav.CommandType = CommandType.Text
        'sav.CommandText = "insert into doctors (doc_id)values(" & n & ")"
        'conn.Open()
        'sav.ExecuteNonQuery()
        'conn.Close()
        'da = New SqlDataAdapter("select * from doctors", conn)
        'da.Fill(ds, "tbl")
        'Me.Label63.Text = ds.Tables("tbl").Rows(ds.Tables("tbl").Rows.Count - 1).Item(0)
    End Sub
End Class
