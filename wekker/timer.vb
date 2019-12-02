Public Class teller
    Dim waarde As Integer
    Dim hoogstewaarde As Integer
    Public Sub New(ByVal einde As Integer)
        hoogstewaarde = einde
        waarde = 0
    End Sub

    Public Property mwaarde As Integer
        Get
            Return waarde
        End Get
        Set(value As Integer)
            If value >= hoogstewaarde Or value < 0 Then
                MessageBox.Show("Foute waarde, het wordt op 0 ingesteld")
                waarde = 0
            Else
                waarde = value

            End If
        End Set
    End Property

    Public Sub verhoog()
        If waarde = hoogstewaarde - 1 Then
            waarde = 0
        Else
            waarde += 1
        End If
    End Sub

    Public Function watskeburt()
        If waarde < 10 Then
            Return "0" & waarde.ToString
        Else
            Return waarde.ToString
        End If
    End Function
    Public Property mtimer As Integer




End Class
