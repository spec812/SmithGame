Public Class Form1

    Dim speed As Integer
    Dim s As Integer
    Dim countdown As Integer = 30

    Dim up As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.D And Pbplayer.Location.X < ClientSize.Width - Pbplayer.Width) Then
            Pbplayer.Left += speed
            If (s = 1) Then
                Pbplayer.Image = My.Resources.walk1right

            ElseIf (s = 2) Then
                Pbplayer.Image = My.Resources.walk2right

            ElseIf (s = 3) Then
                Pbplayer.Image = My.Resources.walk3right

            ElseIf (s = 4) Then
                Pbplayer.Image = My.Resources.walk4right

            End If
            s += 1
        End If
        If (e.KeyCode = Keys.A And Pbplayer.Location.X > 0) Then
            Pbplayer.Left -= speed
            If (s = 1) Then
                Pbplayer.Image = My.Resources.walk1left

            ElseIf (s = 2) Then
                Pbplayer.Image = My.Resources.walk2left

            ElseIf (s = 3) Then
                Pbplayer.Image = My.Resources.walk3left

            ElseIf (s = 4) Then
                Pbplayer.Image = My.Resources.walk4left
                s = 0
            End If
            s += 1
        End If



    End Sub

    Private Sub tmrclock_Tick(sender As Object, e As EventArgs) Handles tmrclock.Tick
        countdown -= 1
        lbltime.Text = countdown
        If (countdown = 0) Then
            tmrclock.Stop()


        End If
    End Sub
End Class
