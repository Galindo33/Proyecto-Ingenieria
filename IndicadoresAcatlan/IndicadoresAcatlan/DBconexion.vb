'antes de ejecutar se debera configurar de manera
'adecuada la conexion con la base de datos
'de lo contrario marca error
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO


Public Class DBconexion

    Dim conexion As New SqlConnection()
    Dim direccion As ConnectionStringSettings
    Dim comando As SqlCommand

    Sub conectar()

        'obtener nombre de la conexion desde el app config
        direccion = ConfigurationManager.ConnectionStrings("nombre de la conexion")
        conexion.ConnectionString = direccion.ConnectionString
        conexion.Open()
        MsgBox("CONEXION EXITOSA")

    End Sub

    Sub desconectar()

        conexion.Close()

    End Sub

    Sub insertar(logro As Double, causa As String, plnAcn As String)

        conectar()
        comando = New SqlCommand("insert into database values(" + logro + "," + causa + "," + plnAcn + ")", conexion)
        comando.ExecuteNonQuery()
        desconectar()

    End Sub

End Class
