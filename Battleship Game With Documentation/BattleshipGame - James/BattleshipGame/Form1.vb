Public Class frmBattleship

    'Student Name: James Halley     Grade: Twelve
    'Assessment Task: Three         Year: 2016

    'Declaration:
    'I hereby certify that this assignment is entirely my own work, except where I have 'acknowledged all material and sources used in the prepartion of the assignment. I certify 'that all typing/keystrokes have been done by me.

    'I also certify that the material contained in this assignment has not been previously 'submitted by me or assessment in any formal course of study, and that I have not copied in part or whole, or otherwise plagiarised the work of other students and/or persons.

    'This program is desgined as a free user riendly, interactive and recreational product

    Private Sub btn2Player_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2Player.Click 'Runs this sub everytime btn2Player is clicked

        _2_Player.Show() 'Shows/opens the form _2_Player
        Me.Close() 'Closes the current form that runs this

    End Sub

    Private Sub btnCPUPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCPUPlayer.Click

        _1_Player.Show() 'Opens the form _1_Player
        Me.Close()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Help.Close() 'Closes the form help so then in case it was still open when the user tries to exit the program
        Me.Close()

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click

        Help.Show() 'Shows the help form

    End Sub
End Class
