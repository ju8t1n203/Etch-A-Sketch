﻿'Justin Bell
'RCET0265
'Fall24
'Etch-A-Sketch
'link

Public Class EtchASketch


    Function penColor(Optional newColor As Color = Nothing) As Color
        Static _color As Color

        If newColor <> Nothing Then
            _color = newColor
        End If

        Return _color
    End Function

    Sub MouseDraw(startX As Integer, startY As Integer, endX As Integer, endY As Integer)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics()
        Dim pen As New Pen(penColor())

        g.DrawLine(pen, startX, startY, endX, endY)

        g.Dispose()
    End Sub

    Sub DrawDivisions()
        Dim xSpace As Integer = DrawingPictureBox.Width \ 10
        Dim ySpace As Integer = DrawingPictureBox.Height \ 8

        penColor(Color.LightGray)

        For i = 1 To 10
            MouseDraw(i * xSpace, 0, i * xSpace, DrawingPictureBox.Height)
        Next

        For i = 1 To 8
            MouseDraw(0, i * ySpace, DrawingPictureBox.Width, i * ySpace)
        Next
    End Sub

    Sub DrawSineWave()
        Dim degrees As Double = Math.PI / 180
        Dim peak As Integer = DrawingPictureBox.Height / 4
        Dim currentY As Integer
        Dim lastY As Integer = peak * Math.Sin(0) + 2 * peak
        Dim lastX As Integer = 0

        For i As Integer = 1 To DrawingPictureBox.Width
            currentY = peak * Math.Sin(i * degrees) + 2 * peak
            MouseDraw(lastX, lastY, i, currentY)
            lastX = i
            lastY = currentY
        Next

    End Sub

    'Buttons----------------------
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DrawingPictureBox.Image = Nothing
        DrawingPictureBox.BackColor = Color.White
        penColor(Color.Black)
    End Sub

    Private Sub ColorSelectButton_Click(sender As Object, e As EventArgs) Handles ColorSelectButton.Click
        Dim ColorDialog As New ColorDialog
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            penColor(ColorDialog.Color)
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub WaveFormButton_Click(sender As Object, e As EventArgs) Handles WaveFormButton.Click
        DrawSineWave()
        DrawDivisions()
    End Sub

    '-----------------------------
    Private Sub GraphicsExample_Load(sender As Object, e As EventArgs) Handles Me.Load
        penColor(Color.Black)
        DrawingPictureBox.BackColor = Color.White
    End Sub

    Private Sub DrawingPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseDown, DrawingPictureBox.MouseMove
        Me.Text = $"({e.X.ToString}, {e.Y.ToString}) Button: {e.Button} Color: {penColor().Name}"
        Static oldX%, oldY%

        If e.Button = MouseButtons.Left Then
            MouseDraw(oldX, oldY, e.X, e.Y)
        End If

        oldX = e.X
        oldY = e.Y

    End Sub

End Class