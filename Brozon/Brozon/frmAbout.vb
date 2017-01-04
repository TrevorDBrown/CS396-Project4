' Brozon - a cannonball game.
' (c)2016 Trevor D. Brown and Travis Anderson. All rights reserved.
' CS 396 - Fall 2016 - Dr. Wang
' Project 4
'
' This program was written for partial fulfilment of requirements for
' CS 396 (Fall 2016), Project 4.

' frmAbout - The form that displays information about the game and about the developers.

' -------------------------------------------------------------------------


Public NotInheritable Class frmAbout

    ' formAbout_Load: the event handler for when the About form loads.
    Private Sub frmAbout_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Start the text slide timer.
        tmrTextSlide.Start()

    End Sub

    ' frmAbout_Click: the event handler for when the About form is clicked.
    Private Sub frmAbout_Click(sender As Object, e As EventArgs) Handles MyBase.Click

        ' Stop the text slide timer.
        tmrTextSlide.Stop()
        ' Close the form.
        Me.Close()
    End Sub

    ' pctTrevor_Click: the event handler for when the picture of Trevor Brown is clicked.
    Private Sub pctTrevor_Click(sender As Object, e As EventArgs) Handles pctTrevor.Click
        ' Philippians 4:13
        ' Howard R. Hughes - 1905-1976
        ' Steven P. Jobs - 1955-2011

        ' Open Trevor D. Brown's personal website.
        Process.Start("http://personal.trevordylanbrown.com/")
        ' Stop the text slide timer.
        tmrTextSlide.Stop()
        ' Close the form.
        Me.Close()
    End Sub

    ' pctTravis_Click: the event handler for when the picture of Travis Anderson is clicked.
    Private Sub pctTravis_Click(sender As Object, e As EventArgs) Handles pctTravis.Click

    End Sub

    ' tmrTextSlide_Tick: the event handler for when the text slide timer ticks.
    Private Sub tmrTextSlide_Tick(sender As Object, e As EventArgs) Handles tmrTextSlide.Tick
        ' If the label is on screen, move it to the left by 1 pixel
        ' If the label is off screen to the left, reset to the right of the screen.
        If (lblAbout.Right <= 0) Then
            lblAbout.Left = Me.Width
        Else
            lblAbout.Left = lblAbout.Left - 1
        End If
    End Sub
End Class
