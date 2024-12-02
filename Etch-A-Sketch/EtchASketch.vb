Public Class EtchASketch


    Function penColor(Optional newColor As Color = Nothing) As Color
        Static _color As Color

        If newColor <> Nothing Then
            _color = newColor
        End If

        Return _color
    End Function

    Sub MouseDraw(startX As Integer, startY As Integer, endX As Integer, endY As Integer)
        Dim bmp As New Bitmap(DrawingPictureBox.Image)
        Dim g As Graphics = Graphics.FromImage(bmp)
        Dim pen As New Pen(penColor())

        g.DrawLine(pen, startX, startY, endX, endY)

        g.Dispose()
    End Sub

    Sub DrawDivisions()
        Dim xSpace As Integer = DrawingPictureBox.Width \ 10
        Dim ySpace As Integer = DrawingPictureBox.Height \ 8

        penColor(Color.LightGray)
        DrawingPictureBox.BackColor = Color.Black

        For i = 1 To 10
            MouseDraw(i * xSpace, 0, i * xSpace, DrawingPictureBox.Height)
        Next

        For i = 1 To 8
            MouseDraw(0, i * ySpace, DrawingPictureBox.Width, i * ySpace)
        Next
    End Sub


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
