Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim message As String
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Message As String

        If Now.DayOfWeek.Monday Then
            Message = "Have a nice week"
        Else
            If Now.DayOfWeek >= System.DayOfWeek.Tuesday And
            Now.DayOfWeek <= System.DayOfWeek.Monday Then
                Message = "Welcome back!"
            Else
                Message = "Have a nice weekend!"

            End If
        End If
        MessageBox.Show(Message, "If Statement", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim message As String
        Select Case Now.DayOfWeek
            Case System.DayOfWeek.Monday
                message = "Have a nice week!"
            Case System.DayOfWeek.Tuesday, System.DayOfWeek.Wednesday,
            System.DayOfWeek.Thursday, System.DayOfWeek.Friday
                message = "Welcome back!"
            Case DayOfWeek.Saturday, System.DayOfWeek.Sunday
                message = "Have a nice weekend!"


        End Select
        MessageBox.Show(message, "Case Statement", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub
End Class
