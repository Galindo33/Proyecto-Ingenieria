Public Class DataBase

    Dim ind_logro As Double
    Dim ind_causa As String
    Dim ind_plnAcn As String

    Public Property Logro() As Double
        Get
            Return Me.ind_logro
        End Get
        Set(value As Double)
            Me.ind_logro = value
        End Set
    End Property

    Public Property Causa() As String
        Get
            Return Me.ind_causa
        End Get
        Set(value As String)
            Me.ind_causa = value
        End Set
    End Property

    Public Property PlnAcn() As String
        Get
            Return Me.ind_plnAcn
        End Get
        Set(value As String)
            Me.ind_plnAcn = value
        End Set
    End Property


End Class
