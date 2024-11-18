Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO

Public Class Form1
    'variables para almacenar los valores
    'de las cajas de texto.
    Dim log As Double
    Dim causa As String
    Dim planactn As String
    Dim proy As Double

    Dim dbconx As New DBconexion()

    'se asignan los valores de las cajas
    'a las variables.
    'asegurarse de que se utilizan los nombres correctos de las
    'cajas de texto en el formulario.
    log = logro.Text
    causa = causa.Text
    planactn = plan.Text
    proy = proy.Text

    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    'evento que manda a llamar a la funcion <validar> una vez que el usuario 
    'ingresa informacion en la casilla de <logro>.
    'asegurarse de que el evento se usa con el nombre de la casilla <logro>.
    Private Sub txtTargetControl(sender As Object, e As EventArgs) Handles txtControl.TextChanged

        dbconx.Validacion(log, proy)

    End Sub


    'evento que manda a llamar a la funcion <insertar> una vez que el usuario 
    'hace click en el boton de guargar informacion.
    'asegurarse de que el evento se usa con el nombre del boton que guarda los datos.
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click

        'asegurarse de que el metodo se ejecute con el mismo numero de variables 
        'que cajas de texto en el formulario.
        dbconx.Insertar(log, causa, planactn)

    End Sub




End Class
