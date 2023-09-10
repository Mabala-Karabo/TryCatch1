Public Class Form1
    Private Sub txtCalculate_Click(sender As Object, e As EventArgs) Handles txtCalculate.Click
        ' Declare variables.
        Dim x As Integer = txtX.Text
        Dim y As Integer = txtY.Text
        Dim z As String

        ' Set up structured error handling.
        Try
            ' Attemp to perform the required operation.
            z = x \ y
            MsgBox(z)
        Catch ex As Exception
            ' Show the exception's message.
            MsgBox("Error, you cannot divide by zero")
            MsgBox(ex.ToString)
            ' Show the stack trace, which is a list of methods
            ' that are currently executing.

        Finally
            '    ' This line executes whether or not the exception occurs.
            MsgBox("finally block")
        End Try
    End Sub
End Class
