﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intNum As Integer
        If IsNumeric(txtInput.Text) Then
            intNum = txtInput.Text
            If (intNum Mod 2 <> 0) Then
                lblResult.Text = txtInput.Text & " is odd"
            Else
                lblResult.Text = txtInput.Text & " is even"
            End If
        Else
            lblResult.Text = "Value must be numeric"
        End If
        txtInput.Text = ""
        txtInput.Focus()
    End Sub
End Class
