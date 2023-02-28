Imports System.Net.Dns
Imports System.Management
Public Class trace

    'This form is responsible for peforming the trace route function

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try
            'Sub calls the command prompt and performs a trace route to the destination IP address
            Dim sCommand As String = System.Environment.SystemDirectory & "\trace.bat " & txtDestination.Text
            Shell(sCommand, AppWinStyle.NormalFocus, False, 1000000000)

        Catch ex As Exception
            MessageBox.Show("The trace.bat file is not found on this system or can not be opened by this user.  Please contact the Office of Technology @ ext 2195.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Dispose()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'closes the form
        Me.Dispose()
    End Sub
End Class