'Justin Bell
'RCET0265
'Fall24
'Etch-A-Sketch
'https://github.com/ju8t1n203/Etch-A-Sketch

Public Class EtchASketch

    Function penColor(Optional newColor As Color = Nothing) As Color
        'holds and updates the drawing tool color
        Static _color As Color

        If newColor <> Nothing Then
            _color = newColor
        End If

        Return _color
    End Function

    Sub MouseDraw(startX As Integer, startY As Integer, endX As Integer, endY As Integer)
        'tracks the mouse for drawing
        Dim g As Graphics = DrawingPictureBox.CreateGraphics()
        Dim pen As New Pen(penColor())

        g.DrawLine(pen, startX, startY, endX, endY)

        g.Dispose()
    End Sub

    Sub DrawDivisions()
        'creates a 10x10 grid to plot on
        Dim xSpace As Integer = DrawingPictureBox.Width \ 10
        Dim ySpace As Integer = DrawingPictureBox.Height \ 10

        penColor(Color.LightGray)

        For i = 1 To 10
            MouseDraw(i * xSpace, 0, i * xSpace, DrawingPictureBox.Height)
        Next

        For i = 1 To 8
            MouseDraw(0, i * ySpace, DrawingPictureBox.Width, i * ySpace)
        Next
    End Sub

    Sub DrawCosineWave()
        'all the matmatics for the cosine wave
        Dim degrees As Double = Math.PI / 180
        Dim peak As Integer = DrawingPictureBox.Height / 4
        Dim currentY As Integer
        Dim lastY As Integer = peak * Math.Cos(0) + 2 * peak
        Dim lastX As Integer = 0

        penColor(Color.Blue)

        For i As Integer = 1 To DrawingPictureBox.Width
            currentY = peak * Math.Cos(i * degrees) + 2 * peak
            MouseDraw(lastX, lastY, i, currentY)
            lastX = i
            lastY = currentY
        Next

    End Sub

    Sub DrawSineWave()
        'all the matmatics for the sine wave
        Dim degrees As Double = Math.PI / 180
        Dim peak As Integer = DrawingPictureBox.Height / 4
        Dim currentY As Integer
        Dim lastY As Integer = peak * Math.Sin(0) + 2 * peak
        Dim lastX As Integer = 0

        penColor(Color.Red)

        For i As Integer = 1 To DrawingPictureBox.Width
            currentY = peak * Math.Sin(i * degrees) + 2 * peak
            MouseDraw(lastX, lastY, i, currentY)
            lastX = i
            lastY = currentY
        Next

    End Sub

    Sub DrawTangentWave()
        'all the matmatics for the tangent wave
        Dim degrees As Double = Math.PI / 180
        Dim peak As Integer = DrawingPictureBox.Height / 4
        Dim currentY As Double
        Dim lastY As Double = peak * Math.Tan(0) + 2 * peak
        Dim lastX As Integer = 0

        penColor(Color.Green)
        'prevents arithmatic overflow
        For i As Integer = 1 To DrawingPictureBox.Width
            currentY = peak * Math.Tan(i * degrees) + 2 * peak
            If Math.Abs(currentY) <= 1000 Then
                MouseDraw(lastX, lastY, i, currentY)
                lastX = i
                lastY = currentY
            Else
                lastX = i
                lastY = peak * Math.Tan((i - 1) * degrees) + 2 * peak
            End If
        Next

    End Sub

    'Buttons----------------------
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'clears the drawing space
        DrawingPictureBox.Image = Nothing
        DrawingPictureBox.BackColor = Color.White
        penColor(Color.Black)
    End Sub

    Private Sub ColorSelectButton_Click(sender As Object, e As EventArgs) Handles ColorSelectButton.Click
        'opens a dialog for the user to change the tool color
        Dim ColorDialog As New ColorDialog
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            penColor(ColorDialog.Color)
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub WaveFormButton_Click(sender As Object, e As EventArgs) Handles WaveFormButton.Click
        DrawDivisions()
        DrawSineWave()
        DrawCosineWave()
        DrawTangentWave()
    End Sub

    'Other Events------------------
    Private Sub GraphicsExample_Load(sender As Object, e As EventArgs) Handles Me.Load
        'sets the defaults
        penColor(Color.Black)
        DrawingPictureBox.BackColor = Color.White
    End Sub

    Private Sub DrawingPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseDown, DrawingPictureBox.MouseMove
        'shows the coordinates and current tool color on the top of the form
        Me.Text = $"({e.X.ToString}, {e.Y.ToString})    Color: {penColor().Name}"
        Static oldX%, oldY%

        If e.Button = MouseButtons.Left Then
            MouseDraw(oldX, oldY, e.X, e.Y)
        End If

        oldX = e.X
        oldY = e.Y

    End Sub

    'Context Things---------------
    Private Sub SelectColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectColorToolStripMenuItem.Click
        ColorSelectButton.PerformClick()
    End Sub

    Private Sub DrawWaveformsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrawWaveformsToolStripMenuItem.Click
        WaveFormButton.PerformClick()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ClearButton.PerformClick()
    End Sub

    'Menu Things------------------
    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        ExitButton.PerformClick()
    End Sub

    Private Sub AboutToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem2.Click
        MsgBox("Welcome to the colorful kingdom of Etch-A-Sketch,
 where imagination meets pixel perfection!
 In this digital wonderland, every mouse click and brush stroke
 brings your ideas to life with a splash of creativity!")
    End Sub
End Class