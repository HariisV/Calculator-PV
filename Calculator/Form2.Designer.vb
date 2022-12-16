<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Soal = New System.Windows.Forms.Label()
        Me.Jawaban = New System.Windows.Forms.Label()
        Me.Closed = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Soal
        '
        Me.Soal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Soal.Location = New System.Drawing.Point(1, 81)
        Me.Soal.Name = "Soal"
        Me.Soal.Size = New System.Drawing.Size(379, 33)
        Me.Soal.TabIndex = 0
        Me.Soal.Text = "Soal"
        Me.Soal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Jawaban
        '
        Me.Jawaban.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Jawaban.Location = New System.Drawing.Point(1, 140)
        Me.Jawaban.Name = "Jawaban"
        Me.Jawaban.Size = New System.Drawing.Size(379, 33)
        Me.Jawaban.TabIndex = 1
        Me.Jawaban.Text = "Jawaban"
        Me.Jawaban.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Closed
        '
        Me.Closed.Location = New System.Drawing.Point(129, 242)
        Me.Closed.Name = "Closed"
        Me.Closed.Size = New System.Drawing.Size(131, 51)
        Me.Closed.TabIndex = 2
        Me.Closed.Text = "Ok"
        Me.Closed.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 344)
        Me.ControlBox = False
        Me.Controls.Add(Me.Closed)
        Me.Controls.Add(Me.Jawaban)
        Me.Controls.Add(Me.Soal)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 400)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 400)
        Me.Name = "Form2"
        Me.Text = "Result"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Soal As Label
    Friend WithEvents Jawaban As Label
    Friend WithEvents Closed As Button
End Class
