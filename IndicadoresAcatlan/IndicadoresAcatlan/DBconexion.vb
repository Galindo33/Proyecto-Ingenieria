'antes de ejecutar se debera configurar de manera
'adecuada la conexion con la base de datos
'de lo contrario marca error.
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO


Public Class DBconexion

    Dim log As Double
    Dim causa As String
    Dim plnAcn As String
    Dim proy As Double


    Dim conexion As New SqlConnection()
    Dim direccion As ConnectionStringSettings
    Dim comando As SqlCommand

    Sub Conectar()

        'obtener nombre de la conexion desde el app config.
        direccion = ConfigurationManager.ConnectionStrings("nombre de la conexion")
        conexion.ConnectionString = direccion.ConnectionString
        conexion.Open()
        MsgBox("CONEXION EXITOSA")

    End Sub

    Sub Desconectar()

        conexion.Close()

    End Sub

    'metodo que almacena en sql la informacion ingresada por el usuario.
    Sub Insertar(logro, causa, plnAcn)

        Conectar()
        comando = New SqlCommand("insert into database values(" + logro + "," + causa + "," + plnAcn + ")", conexion)
        comando.ExecuteNonQuery()
        desconectar()

    End Sub

    'metodo que valida el valor de la casilla <logro>
    'ingresado por el usuario.
    Sub Validacion(logro, proy)

        'si el porcentaje del logro con respecto a la proyeccion
        'es mayor a 80, las casillas de causa y plan de accion
        'no se habilitan para su escritura.
        If (logro * 100) / proy >= 80 Then

            'txtTarget1 ytxtTarget2 hacen referencia a los nombres
            'de las cajas de texto para causa y plan.
            'asegurarse de usar los nombres correctos.
            txtTarget1.Enabled = False
            txtTarget2.Enabled = False

            'si el porcentaje del logro con respecto a la proyeccion
            'es menor a 80, las casillas de causa y plan de accion
            'se habilitan para su escritura.
        ElseIf (logro * 100) / proy <= 80 And (logro * 100) / proy >= 70 Then

            'txtTarget1 ytxtTarget2 hacen referencia a los nombres
            'de las cajas de texto para causa y plan.
            'asegurarse de usar los nombres correctos.
            txtTarget1.Enabled = True
            txtTarget2.Enabled = True

        End If
    End Sub

End Class
