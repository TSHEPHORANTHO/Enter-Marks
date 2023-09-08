Public Class Form1
    Private Sub BtnResults_Click(sender As Object, e As EventArgs) Handles BtnResults.Click
        Dim Marks As String

        Marks = CInt(txtMarks.Text)
        If Marks >= 0 And Marks <= 100 Then
            If Marks < 50 Then
                MsgBox("Failed")
            ElseIf Marks >= 50 Then
                MsgBox("Pass")
            End If
        Else
            MsgBox("Invalid Marks! Marks should be between 0 and 100.")

        End If

    End Sub
End Class
