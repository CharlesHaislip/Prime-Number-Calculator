Option Strict On
Option Explicit On
Public Class IDRange
    'Checks that the form can close and find the numbers in the range
    Function Close_Check() As Boolean
        If txtHigh.Text Is Nothing OrElse txtLow.Text Is Nothing Then
            'Notify user that a field is empty
            MessageBox.Show("Please check that the fields are not empty.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf Not (IsNumeric(txtHigh.Text) Or IsNumeric(txtLow.Text)) Then
            'Notify the user the data is not valid
            MessageBox.Show("Please check that the data you entered is valid.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            'Set High and low for comparison
            High = CInt(txtHigh.Text)
            Low = CInt(txtLow.Text)
            If intCA - 1 < High Then
                'Notify the user that the range is not valid
                MessageBox.Show("Those values have not been found yet", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
                High = Nothing
                Low = Nothing
                Return False
            End If
            If Low >= High Then
                'Notify the user that fields are mixed up or equal to
                MessageBox.Show("The lesser value either in or equal to the higher field.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Reset variables
                High = Nothing
                Low = Nothing
                Return False
            ElseIf Low = High Then
                'Ensures the user does not enter two fields that are the same.
                MessageBox.Show("The two filds are the same. Please change one of them.", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'May proceed
                Return True
            End If
        End If

        Return False

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim tst As Boolean = Close_Check()
        If tst = True Then
            Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'don't calculate
        RangeHalt = True
        Close()
    End Sub

    Private Sub frm_clsing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Sets the 'do not calculate' flag
        If (High = Nothing Or Low = Nothing) Then
            RangeHalt = True
        End If
    End Sub

End Class