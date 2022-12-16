Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class Form2


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Soal.Text = Form1.Total.Text

        Dim Res = Form1.Total.Text.Replace(",", "."

        Jawaban.Text = New DataTable().Compute(Res, Nothing)
    End Sub
    Private Sub Closed_Click(sender As Object, e As EventArgs) Handles Closed.Click
        Form1.Total.Text = 0
        Me.Close()
    End Sub
End Class