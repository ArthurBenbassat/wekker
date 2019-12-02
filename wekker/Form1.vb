Public Class Form1
    Dim minuten As teller
    Dim uren As teller

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        Timer1.Start()

        minuten = New teller(60)
        uren = New teller(24)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim alarm As String
        minuten.verhoog()
        If minuten.mwaarde = 0 Then
            uren.verhoog()
        End If
        lblMinuut.Text = minuten.watskeburt
        lblUur.Text = uren.watskeburt()
        If chkAlarm.Checked = True Then
            alarm = Label3.Text
            If minuten.mwaarde = alarm.Substring(3, 2) And uren.mwaarde = alarm.Substring(0, 2) Then
                Beep()
                MessageBox.Show("Gelieve de pc-speaker aan te sluiten")
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tijd As String
        Try
            tijd = InputBox("Voer de tijd in (00:00)")

            minuten.mwaarde = tijd.Substring(3, 2)
            uren.mwaarde = tijd.Substring(0, 2)
        Catch ex As Exception
            MessageBox.Show("probeer het nog een smet een echte tijd")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tijd As String
        Try
            tijd = InputBox("Voer de tijd in (00:00)")

            Label3.Text = tijd
        Catch ex As Exception
            MessageBox.Show("probeer het nog een smet een echte tijd")
        End Try
    End Sub
End Class
