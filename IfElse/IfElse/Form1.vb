Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largNum As Double
        num1 = CDbl(txtFirstNum.Text)
        num2 = CDbl(txtSecondNum.Text)

        If (num1 > num2) Then
            largNum = num1
            txtResult.Text = CStr(largNum)
        ElseIf (num1 < num2) Then
            largNum = num2
            txtResult.Text = CStr(largNum)
        Else


            txtResult.Text = "The two are equal."

        End If
    End Sub
End Class
