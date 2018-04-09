Public Class Help

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click 'Triggers this sub when the handle is activated, ie when btnClose is clicked

        Me.Close() 'Closes the current form this is triggered in

    End Sub

    Private Sub btnRulesLink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRulesLink.Click

        Try 'Attempts to run the next portion of code, although if it fails, it has essentially an "else"
            Process.Start("http://www.hasbro.com/common/instruct/Battleship.PDF") 'starts the process necessary to open what's in the parameters, in this case, a pdf so it will open the default browser
        Catch ex As Exception 'if the above code doesnt trigger, this exception will trigger
            MsgBox("Unable to retrieve rules at this time") 'gives the user feedback that the rules could not be accessed
        End Try

    End Sub

    Private Sub btnMoreHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoreHelp.Click

        Try
            Process.Start("https://docs.google.com/document/d/15mOovz3mnzAu-PlM1n_s_Spl4PeZhuot3AP-i7X1Zd4/edit?usp=sharing")
        Catch ex As Exception
            MsgBox("Unable to retrieve help at this time")
        End Try

    End Sub
End Class