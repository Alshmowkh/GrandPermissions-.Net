Module Module1
    Public conn As New SqlClient.SqlConnection
    Public Sub constr()

        conn.ConnectionString = "data source=.\sqlexpress;attachdbfilename=E:\������\VB graduation\Promotions System\Promotions db.mdf;integrated security=true;user instance=true"

    End Sub
End Module
