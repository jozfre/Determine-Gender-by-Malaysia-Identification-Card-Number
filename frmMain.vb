Public Class frmMain
    Private Sub btnExtract_Click(sender As Object, e As EventArgs) Handles btnExtract.Click
        Dim strLastDigit As String
        Dim strIC As String = txtICNumber.Text
        Dim dblRemainder As Double

        If strIC.Length <> 12 Then
            MessageBox.Show(Me, "The digit of the IC Number must be 12!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        strLastDigit = strIC.Substring(strIC.Length - 1, 1)
        'MessageBox.Show(Me, strLastDigit)

        dblRemainder = Val(strLastDigit) Mod 2

        If dblRemainder = 0 Then
            txtGender.Text = "Female"
        Else
            txtGender.Text = "Male"
        End If

        'MessageBox.Show(Me, dblRemainder)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
