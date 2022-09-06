<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtICNumber = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.btnExtract = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IC Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Gender"
        '
        'txtICNumber
        '
        Me.txtICNumber.Location = New System.Drawing.Point(138, 64)
        Me.txtICNumber.Name = "txtICNumber"
        Me.txtICNumber.Size = New System.Drawing.Size(294, 22)
        Me.txtICNumber.TabIndex = 2
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(138, 135)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(294, 22)
        Me.txtGender.TabIndex = 3
        '
        'btnExtract
        '
        Me.btnExtract.Location = New System.Drawing.Point(530, 62)
        Me.btnExtract.Name = "btnExtract"
        Me.btnExtract.Size = New System.Drawing.Size(75, 23)
        Me.btnExtract.TabIndex = 4
        Me.btnExtract.Text = "Extract"
        Me.btnExtract.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(530, 132)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnExtract)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtICNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtICNumber As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents btnExtract As Button
    Friend WithEvents btnClose As Button
End Class
