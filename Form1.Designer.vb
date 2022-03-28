<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(59, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a number :"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblResult.Location = New System.Drawing.Point(59, 137)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 21)
        Me.lblResult.TabIndex = 1
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(266, 64)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 23)
        Me.txtInput.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(266, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 40)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Check it!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 240)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents Button1 As Button
End Class
