' Brozon - a cannonball game.
' (c)2016 Trevor D. Brown and Travis Anderson. All rights reserved.
' CS 396 - Fall 2016 - Dr. Wang
' Project 4
'
' This program was written for partial fulfilment of requirements for
' CS 396 (Fall 2016), Project 4.

' frmMain - This is the primary form of the game.

' -------------------------------------------------------------------------

' Import packages to be used in frmMain
Imports System.Drawing.Drawing2D
Imports Microsoft.VisualBasic.PowerPacks

Public Class frmMain

    ' Declare variables to be used throughout this form.
    ' Cursor coordinate variables (to help determine cursor position)
    Dim intCursorX As Integer
    Dim intCursorY As Integer

    ' Line variables (to help generate a line while the mouse moves)
    Dim bolProjectileInMotion As Boolean
    Dim decSlope As Decimal
    Dim decDistance As Decimal
    Dim decRise As Decimal
    Dim decRun As Decimal

    ' Projectile variables (to establish the projectile position)
    Dim decProjectileX As Decimal
    Dim decProjectileY As Decimal
    Dim decCurrentProjectileX As Decimal
    Dim decCurrentProjectileY As Decimal

    ' Obstacle variables (to establish the obstacle position)
    Dim intObstacleTimeCount As Integer
    Dim intObstacleX As Integer
    Dim intObstacleY As Integer
    Dim bolObstacleVisible As Boolean

    ' Game variables (used throughout game play)
    Dim intScore As Integer
    Dim intAmmoCount As Integer
    Dim bolPlayerTwoComputer As Boolean

    ' Player Two variables
    ' Player Two's X and Y coordinates variables
    Dim intPlayerTwoX As Integer
    Dim intPlayerTwoY As Integer
    ' Player Two's score variable
    Dim intPlayerTwoScore As Integer
    ' Player Two's key codes variables
    Dim intKeyUp As Integer
    Dim intKeyDown As Integer
    Dim intKeyLeft As Integer
    Dim intKeyRight As Integer
    ' Player Two's visibility variables
    Dim bolPlayerVisible As Boolean
    Dim intPlayerVisibleCounter As Integer

    ' Aesthetics Variables
    ' Sound Effect Counter variable.
    'Dim intSoundEffect As Integer
    ' GameAudio instantiation
    'Dim SoundEffectCall As New GameAudio
    ' Volume Adjustment variable (to be used only at the end of the game)
    Dim intVolumeAdjustForEndGame As Integer
    ' Text Slide variables.
    Dim intTextPauseCount As Integer
    Dim intTextSlideCount As Integer
    ' Game paused variales
    Dim bolIsGamePaused As Boolean
    Dim intPauseLabelCounter As Integer
    Dim bolPauseLabelVisible As Boolean

    ' Additional Functions:
    ' Asynchronous Keystroke Determination
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Short


    ' frmMain_Load - the event that handles when the form loads.
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Hide all gameplay elements from the screen on form load.
        lneScope.Hide()
        ovlScope.Hide()
        lblAmmoCount.Hide()
        lblPower.Hide()
        lblScore.Hide()
        lblPlayerTwoScore.Hide()
        lblWinner.Hide()
        lblPause.Hide()
        pctPlayerTwo.Hide()
        pctTarget.Hide()
        pctCannon.Hide()
        pctAtom.Hide()
        grpPlayerMode.Hide()
        grpArrowKeys.Hide()
        btnStart.Hide()
        btnAbout.Hide()
        btnQuit.Hide()
        bolIsGamePaused = False

        ' Position the Title PictureBox in its starting position.
        pctTitle.Location = New System.Drawing.Point((Me.Width / 2) - (pctTitle.Width / 2), (Me.Height / 2) - (pctTitle.Height / 2))
        ' Start the text slide timer.
        tmrTextSlide.Start()

    End Sub

    ' tmrUpdate_Tick - the event that handles every tick of the tmrUpdate timer.
    ' The following code will run with every tick.
    Private Sub tmrUpdate_Tick(sender As Object, e As EventArgs) Handles tmrUpdate.Tick
        If (bolIsGamePaused = False) Then
            If bolPlayerTwoComputer = True Then
                ' Obstacle Visibility Conditions
                If bolObstacleVisible = True And intObstacleTimeCount <= 100 Then
                    ' If theThen obstacle Is visible, but has been present For less than 100 ticks,
                    ' just increment the obstacle time count by one.
                    intObstacleTimeCount += 1

                ElseIf bolObstacleVisible = True And intObstacleTimeCount > 100 Then
                    ' If the obstacle is visible, and has been present for more 100 ticks,
                    ' hide the obstacle, move it to outside of the form, so it won't interfere
                    ' with a moving projectile, and reset the timer count.
                    bolObstacleVisible = False
                    pctPlayerTwo.Hide()
                    pctPlayerTwo.Location = New System.Drawing.Point(Me.Width, Me.Height)
                    intObstacleTimeCount = 0

                ElseIf bolObstacleVisible = False And intObstacleTimeCount <= 50 Then
                    ' If the obstacle is hidden, and has been hidden for less than 50 ticks,
                    ' increment the time counter by one.
                    intObstacleTimeCount += 1

                ElseIf bolObstacleVisible = False And intObstacleTimeCount > 50 Then
                    ' If the obstacle is hidden, and has been hidden for more than 50 ticks,
                    ' reset the timer counter, determine the position of the obstable by 
                    ' randomizing X And Y coordinates within the specified bounds, set the 
                    ' X And Y coordinates For the obstacle, set the obstacle visible flag to true,
                    ' and show the obstacle.
                    intObstacleTimeCount = 0
                    intObstacleX = CType(((Me.Width - pctPlayerTwo.Width) * Rnd() + 0), Integer)
                    intObstacleY = CType((((Me.Height - (ovlScope.Height))) * Rnd() + (pctTarget.Height + 10)), Integer)
                    pctPlayerTwo.Location = New System.Drawing.Point(intObstacleX, intObstacleY)
                    bolObstacleVisible = True
                    pctPlayerTwo.Show()

                End If

            Else
                ' Player Two Movement Control Conditions
                ' Note: All movement is bounded by the sides of the form,
                '       and by virtual boundaries above Player One's space and below
                '       the target space.
                If (GetAsyncKeyState(intKeyUp) And GetAsyncKeyState(intKeyLeft) And pctPlayerTwo.Top > (3 * (pctTarget.Height / 4))) Then
                    ' If Player Two presses Up and Left on the keyboard,
                    ' Move Player Two's obstacle up and to the left.
                    pctPlayerTwo.Top = pctPlayerTwo.Top - 3
                    pctPlayerTwo.Left = pctPlayerTwo.Left - 3


                ElseIf (GetAsyncKeyState(intKeyUp) And GetAsyncKeyState(intKeyRight) And pctPlayerTwo.Top > (3 * (pctTarget.Height / 4))) Then
                    ' If Player Two presses Up and Right on the keyboard,
                    ' Move Player Two's obstacle up and to the right.
                    pctPlayerTwo.Top = pctPlayerTwo.Top - 3
                    pctPlayerTwo.Left = pctPlayerTwo.Left + 3


                ElseIf (GetAsyncKeyState(intKeyDown) And GetAsyncKeyState(intKeyLeft) And pctPlayerTwo.Bottom < (Me.Height - (ovlScope.Height / 2)) - 10) Then
                    ' If Player Two presses Down and Left on the keyboard,
                    ' Move Player Two's obstacle down and to the left.
                    pctPlayerTwo.Top = pctPlayerTwo.Top + 3
                    pctPlayerTwo.Left = pctPlayerTwo.Left - 3


                ElseIf (GetAsyncKeyState(intKeyDown) And GetAsyncKeyState(intKeyRight) And pctPlayerTwo.Bottom < (Me.Height - (ovlScope.Height / 2)) - 10) Then
                    ' If Player Two presses Down and Right on the keyboard,
                    ' Move Player Two's obstacle down and to the right.
                    pctPlayerTwo.Top = pctPlayerTwo.Top + 3
                    pctPlayerTwo.Left = pctPlayerTwo.Left + 3


                ElseIf (GetAsyncKeyState(intKeyUp) And pctPlayerTwo.Top > (3 * (pctTarget.Height / 4))) Then
                    ' If Player Two presses Up on the keyboard,
                    ' Move Player Two's obstacle up.
                    pctPlayerTwo.Top = pctPlayerTwo.Top - 3


                ElseIf (GetAsyncKeyState(intKeyDown) And pctPlayerTwo.Bottom < (Me.Height - (ovlScope.Height / 2)) - 10) Then
                    ' If Player Two presses Down on the keyboard,
                    ' Move Player Two's obstacle down.
                    pctPlayerTwo.Top = pctPlayerTwo.Top + 3


                ElseIf (GetAsyncKeyState(intKeyLeft)) Then
                    ' If Player Two presses Left on the keyboard,
                    ' Move Player Two's obstacle left.
                    pctPlayerTwo.Left = pctPlayerTwo.Left - 3


                ElseIf (GetAsyncKeyState(intKeyRight)) Then
                    ' If Player Two presses Right on the keyboard,
                    ' Move Player Two's obstacle right.
                    pctPlayerTwo.Left = pctPlayerTwo.Left + 3

                End If

                ' Player Two off screen relocation
                If (pctPlayerTwo.Left < 0 - pctPlayerTwo.Width) Then
                    ' If Player Two is too far to the left, reposition to the far right side of the screen.
                    pctPlayerTwo.Left = Me.Width

                ElseIf (pctPlayerTwo.Right > Me.Width + pctPlayerTwo.Width) Then
                    ' If Player Two is too far to the right, reposition to the far left side of the screen.
                    pctPlayerTwo.Left = 0 - pctPlayerTwo.Width
                End If

                ' Player Two visibility toggle
                If (bolPlayerVisible = False And GetAsyncKeyState(32)) Then
                    ' If Player Two is currently not visible and the Space Bar is pressed,
                    ' Show Player Two's obstacle and change the value of bolPlayerVisible to True.
                    pctPlayerTwo.Show()
                    bolPlayerVisible = True

                ElseIf (bolPlayerVisible = True And intPlayerVisibleCounter <= 100) Then
                    ' If Player Two is currently visible and the player visible counter is less than or equal to 100,
                    ' increment the counter by 1.
                    intPlayerVisibleCounter += 1

                ElseIf (bolPlayerVisible = True And intPlayerVisibleCounter > 100) Then
                    ' If Player Two is currently visible and the player visible counter is greater than 100,
                    ' Reset the counter, hide Player Two's obstacle, and change the value of bolPlayerVisible to False.
                    intPlayerVisibleCounter = 0
                    pctPlayerTwo.Hide()
                    bolPlayerVisible = False
                End If
            End If


            ' Projectile in Motion condition
            If bolProjectileInMotion = True Then

                ' Determine the current position of the projectile.
                decCurrentProjectileX = pctAtom.Left
                decCurrentProjectileY = pctAtom.Top

                ' Using the computed "rise" and "run" of the projectile slope,
                ' move the projectile accordingly.
                pctAtom.Left += (decRun * 0.035)
                pctAtom.Top += (decRise * 0.035)

                ' Impact Conditions ------------------------------------------------------------

                ' Condition if the projectile misses all objects on screen. 
                If (pctAtom.Top < (0 - pctAtom.Height) Or pctAtom.Right < (0 - pctAtom.Width) Or pctAtom.Left > (Me.Width + pctAtom.Width)) Then
                    ' If the projectile goes out of the form, reset the motion flag,
                    ' and reposition the projectile to its starting position.
                    bolProjectileInMotion = False
                    pctAtom.Top = Me.Height - 25
                    pctAtom.Left = (Me.Width / 2) - 25
                    ovlScope.Show()
                    pctCannon.Show()

                    ' Condition if the projectile impacts the target
                ElseIf (pctAtom.Top <= pctTarget.Bottom And pctAtom.Left <= pctTarget.Right And pctAtom.Right >= pctTarget.Left And pctAtom.Top > pctTarget.Top) Then
                    ' If the projectile impacts the target, report a successful hit,
                    ' update the score by adding 100 points, reset the motion flag, and
                    ' reposition the projectile to its starting positon.
                    intScore += 100
                    lblScore.Text = "Player One: " + intScore.ToString
                    bolProjectileInMotion = False
                    pctAtom.Top = Me.Height - 25
                    pctAtom.Left = (Me.Width / 2) - 25
                    ovlScope.Show()
                    pctCannon.Show()

                    ' Condition if the projectile impacts Player Two's obstacle
                ElseIf (pctAtom.Top <= pctPlayerTwo.Bottom And pctAtom.Left <= pctPlayerTwo.Right And pctAtom.Right >= pctPlayerTwo.Left And pctAtom.Top > pctPlayerTwo.Top) Then
                    ' If the projectile impacts Player Two's obstacle, update Player Two's
                    ' score by adding 100 points, reset the motion flag, and reposition the
                    ' projectile to its starting position.
                    intPlayerTwoScore = intPlayerTwoScore + 100

                    ' Chaning text based on Player vs. Player/Player vs. Computer toggle
                    If (bolPlayerTwoComputer = False) Then
                        ' If Player Two is Human,
                        ' Update the label using "Player Two" as the leading text.
                        lblPlayerTwoScore.Text = "Player Two: " + intPlayerTwoScore.ToString

                    ElseIf (bolPlayerTwoComputer = True) Then
                        ' If Player Two is Computer,
                        ' Update the label using "Computer" as the leading text.
                        lblPlayerTwoScore.Text = "Computer: " + intPlayerTwoScore.ToString

                    End If

                    ' Regardless of impact condition, run the following code:

                    ' Change the projectile in motion flag to False, and reposition the projectile.
                    ' Also, show any hidden elements that help launch projectile.
                    bolProjectileInMotion = False
                    pctAtom.Top = Me.Height - 25
                    pctAtom.Left = (Me.Width / 2) - 25
                    ovlScope.Show()
                    pctCannon.Show()
                    pctPlayerTwo.Show()
                    bolPlayerVisible = True

                End If
            End If

            ' End Game condition
            If bolProjectileInMotion = False And intAmmoCount = 0 Then
                ' If the projectile in motion flag is false, and Player One is out of ammo, 
                ' stop all timers, and hide all gameplay elements from the screen.
                tmrTargetMovement.Stop()
                tmrUpdate.Stop()
                tmrEndGame.Start()
                lneScope.Hide()
                ovlScope.Hide()
                lblAmmoCount.Hide()
                lblPower.Hide()
                lblScore.Hide()
                lblPlayerTwoScore.Hide()
                pctPlayerTwo.Hide()
                pctTarget.Hide()
                pctCannon.Hide()
            End If
        End If

    End Sub

    ' ovlScope_Click: the event that handles any clicks inside of the ovlScope object.
    Private Sub ovlScope_MouseDown(sender As Object, e As EventArgs) Handles ovlScope.MouseDown

        ' Condition if no projectile is in motion.
        If bolProjectileInMotion = False Then
            ' If no projectile is already in motion, compute the "rise" and "run" of
            ' the currently generated line. Then, hide the line, change the motion flag
            ' to true, decrement the ammunition count by 1, and update the text of the
            ' ammunition count label.
            decRise = lneScope.Y2 - lneScope.Y1
            decRun = lneScope.X2 - lneScope.X1
            lneScope.Hide()
            ovlScope.Hide()
            pctCannon.Hide()
            bolProjectileInMotion = True
            intAmmoCount -= 1
            lblAmmoCount.Text = "Ammo: " + intAmmoCount.ToString

        End If


    End Sub

    ' ovlScope_MouseMove - the event that handles mouse movement in the ovlScope object.
    Private Sub ovlScope_MouseMove(sender As Object, e As MouseEventArgs) Handles ovlScope.MouseMove
        ' Compute the cursor's position, relative to the top-left corner of the ovlScope object.
        intCursorX = ((Me.Width / 2) - (ovlScope.Width / 2)) + e.X
        intCursorY = ((Me.Height) - (ovlScope.Height / 2)) + e.Y

        ' Compute the distance between the start point of the line, and the end point (aka the cursor)
        decDistance = Math.Sqrt(Math.Pow(intCursorX - lneScope.StartPoint.X, 2) + Math.Pow(intCursorY - lneScope.StartPoint.Y, 2))

        ' Condition if no projectile is in motion.
        If bolProjectileInMotion = False Then
            ' If the projectile is not in motion:
            ' Condition if the distance of the line is less than 120 pixels
            If (decDistance < 120) Then
                ' If the line is less than 120 pixels in length, change the color 
                ' of the line and oval to green.
                lneScope.BorderColor = Color.Green

                ' Condition if the distance of the line is between 120 and 200 pixels
            ElseIf (decDistance >= 120 And decDistance < 200) Then
                ' If the line is between 120 and 200 pixels, change the color 
                ' of the line and oval to yellow
                lneScope.BorderColor = Color.Yellow

                ' Condition if the distance of the line is greater than 200 pixels.
            ElseIf (decDistance >= 200) Then
                ' If the line is greater than 200 pixels, change the color
                ' of the line and oval to red.
                lneScope.BorderColor = Color.Red

            End If

            ' Report the current "power leve" of the "cannon" by computing the
            ' percentage of the line's distance from the edge of the oval.
            lblPower.Text = "Power: " + CType(((decDistance / 250) * 100), Integer).ToString + "%"

            ' Update the end point of the line to the current position of the cursor.
            lneScope.EndPoint = New System.Drawing.Point(intCursorX, intCursorY)

            ' Keep the line visible.
            lneScope.Show()

            ' Condition if the projectile is in motion.
        Else
            ' If a projectile is in motion, hide the line and oval, and do no other
            ' computations.
            lneScope.Hide()
            ovlScope.Hide()
            pctCannon.Hide()
        End If

    End Sub

    'tmrTargetMovement_Tick - the event that handles the tmrTargetMovement timer ticks.
    Private Sub tmrTargetMovement_Tick(sender As Object, e As EventArgs) Handles tmrTargetMovement.Tick
        If (bolIsGamePaused = False) Then
            ' Condition if the left of the target is greater than the left edge of the form, minus its own width.
            If pctTarget.Left > (0 - pctTarget.Width) Then
                ' If the target is to the right of the left edge of the form,
                ' Move the target to the left by 5 pixels.
                pctTarget.Left = pctTarget.Left - 5

                ' Condition if the target is beyond the left edge of theh form, minus its own width.
            ElseIf pctTarget.Left <= (0 - pctTarget.Width) Then
                ' If the target is to the left of the left edge of the form,
                ' reposition the target to the right edge of the form, and change
                ' the text of the target to "Try again!"
                pctTarget.Left = Me.Width
            End If
        End If

    End Sub

    ' tmrEndGame_Tick: the event handler for the end game timer tick.
    Private Sub tmrEndGame_Tick(sender As Object, e As EventArgs) Handles tmrEndGame.Tick
        ' Stop the Keys timer
        tmrKeys.Stop()

        If intVolumeAdjustForEndGame > 1 Then
            ' If the game background volume is above 1:
            ' Reduce the volume by 10.
            intVolumeAdjustForEndGame = intVolumeAdjustForEndGame - 10

            ' Show all of the game options.
            pctTitle.Show()
            btnStart.Show()
            btnAbout.Show()
            btnQuit.Show()
            grpPlayerMode.Show()
            grpArrowKeys.Show()
            radPlayerVsPlayer.Checked = True
            radArrow.Checked = True

            ' Winner Display condition
            If (intScore > intPlayerTwoScore) Then
                ' If Player One's score is greater than Player Two's
                ' Player One wins!
                ' Display the Target, and the text "Player One Wins!"
                pctTarget.Location = New System.Drawing.Point(pctTitle.Left, btnStart.Top)
                pctTarget.Show()
                lblWinner.Text = "Player One Wins!"
                lblWinner.Location = New System.Drawing.Point(pctTarget.Left, pctTarget.Bottom - lblWinner.Height)
                lblWinner.Show()
            ElseIf (intScore < intPlayerTwoScore) Then
                ' If Player Two's score is greater than Player One's
                ' Player Two wins!
                ' Display Player Two's obstacle.
                pctPlayerTwo.Location = New System.Drawing.Point(pctTitle.Left, btnStart.Top)
                pctPlayerTwo.Show()

                ' Player vs. Player/Player vs. Computer condition
                If (bolPlayerTwoComputer = False) Then
                    ' If Player Two is Human,
                    ' Display "Player Two Wins!"
                    lblWinner.Text = "Player Two Wins!"
                Else
                    ' If Player Two is Computer,
                    ' Display "Computer Wins!"
                    lblWinner.Text = "Computer Wins!"
                End If

                ' Position the Winner label below the picture of the winner.
                lblWinner.Location = New System.Drawing.Point(pctPlayerTwo.Left, pctPlayerTwo.Bottom - lblWinner.Height)
                lblWinner.Show()
            Else
                ' If the game ends in a tie,
                ' Display both the target and player two.
                ' Display the Winner label as "Tie!"
                pctTarget.Location = New System.Drawing.Point(pctTitle.Left - pctTarget.Width, btnStart.Top)
                pctTarget.Show()
                pctPlayerTwo.Location = New System.Drawing.Point(pctTitle.Left, pctTarget.Top)
                pctPlayerTwo.Show()
                lblWinner.Text = "Tie!"
                lblWinner.Location = New System.Drawing.Point(pctPlayerTwo.Left, pctPlayerTwo.Bottom - lblWinner.Height)
                lblWinner.Show()
            End If
        Else

            ' End the end game timer.
            tmrEndGame.Stop()
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        ' Position the initial scope line, and the containing oval shapes.
        lneScope.StartPoint = New System.Drawing.Point(Me.Width / 2, Me.Height)
        lneScope.EndPoint = New System.Drawing.Point(Me.Width / 2, Me.Height - (ovlScope.Height / 2))
        ovlScope.Location = New System.Drawing.Point((Me.Width / 2) - (ovlScope.Width / 2), (Me.Height - (ovlScope.Height / 2)))
        ovlScope.BorderColor = Color.White
        ovlScope.BorderWidth = 5
        lneScope.BorderWidth = 10

        ' Position all of the game data labels at the bottom of the form, and set their initial values.
        intScore = 0
        intPlayerTwoScore = 0
        intAmmoCount = 20

        lblPower.Text = "Power: 100%"
        lblPower.Location = New System.Drawing.Point(0, Me.Height - 50)
        lblAmmoCount.Text = "Ammo: " + intAmmoCount.ToString
        lblAmmoCount.Location = New System.Drawing.Point(0, lblPower.Top - lblPower.Height - 10)
        lblScore.Text = "Player One: 0"
        lblScore.Location = New System.Drawing.Point(0, lblAmmoCount.Top - lblAmmoCount.Height - 10)

        ' Position the projectile in its inital positon and define its initial movement state, which is not in motion. 
        pctAtom.Top = Me.Height - 25
        pctAtom.Left = (Me.Width / 2) - 25
        bolProjectileInMotion = False

        If (radPlayerVsPlayer.Checked = True) Then
            ' If Player Two human, then set label to Player Two.
            bolPlayerTwoComputer = False
            lblPlayerTwoScore.Text = "Player Two: 0"
            lblPlayerTwoScore.Location = New System.Drawing.Point(Me.Width - lblPlayerTwoScore.Width - 50, Me.Height - 50)

        ElseIf (radPlayerVsComputer.Checked = True) Then
            ' If Player Two computer, then set label to Computer.
            bolPlayerTwoComputer = True
            lblPlayerTwoScore.Text = "Computer: 0"
            lblPlayerTwoScore.Location = New System.Drawing.Point(Me.Width - lblPlayerTwoScore.Width - 50, Me.Height - 50)

        End If

        ' Set the initial values of the obstacle.
        If bolPlayerTwoComputer = True Then
            pctPlayerTwo.Hide()
            bolObstacleVisible = False
            intObstacleTimeCount = 0
            intObstacleX = Me.Width
            intObstacleY = Me.Height
        Else
            pctPlayerTwo.Hide()
            bolPlayerVisible = False
            pctPlayerTwo.Location = New System.Drawing.Point(355, 250)
        End If


        ' Set the initial values of the target.
        pctTarget.Location = New System.Drawing.Point(Me.Width, 10)

        ' Player Two's values initialization.
        intPlayerTwoScore = 0


        ' Arrow Keys initialization
        If (radArrow.Checked = True) Then
            ' If the Arrow Keys radio button is selected,
            ' Set the Arrow keys to be the arrow keys.
            intKeyUp = 38
            intKeyDown = 40
            intKeyLeft = 37
            intKeyRight = 39

        ElseIf (radWADS.Checked = True) Then
            ' If the WADS radio button is checked,
            ' Set the Arrow Keys to be the WASD keys.
            intKeyUp = 87
            intKeyDown = 83
            intKeyLeft = 65
            intKeyRight = 68
        End If

        ' Positon the Cannon image
        pctCannon.Location = New System.Drawing.Point((Me.Width / 2) - (pctCannon.Width / 2), (Me.Height - pctCannon.Height))

        ' Set the volume variable to 1000
        ' NOTE: this does not set the actual volume. This is used with a timer.
        intVolumeAdjustForEndGame = 1000

        ' Start Target Movement, Update, and Key Listener timers.
        tmrTargetMovement.Start()
        tmrUpdate.Start()
        tmrKeys.Start()

        ' Show gameplay elements on screen.
        lneScope.Show()
        ovlScope.Show()
        lblAmmoCount.Show()
        lblPower.Show()
        lblScore.Show()
        lblPlayerTwoScore.Show()
        pctTarget.Show()
        pctAtom.Show()
        pctCannon.Show()

        ' Hide Game selection screen elements.
        pctTitle.Hide()
        btnStart.Hide()
        btnAbout.Hide()
        btnQuit.Hide()
        grpPlayerMode.Hide()
        grpArrowKeys.Hide()
        lblWinner.Hide()

        tmrTargetMovement.Start()
        tmrUpdate.Start()
        tmrEndGame.Stop()

    End Sub

    ' tmrTextSlide_Tick - the event handler for the text slide timer tick.
    Private Sub tmrTextSlide_Tick(sender As Object, e As EventArgs) Handles tmrTextSlide.Tick

        ' Text Slide Conditions.
        If (intTextPauseCount <= 50) Then
            ' If the Text Pause Count is less than or equal to 50
            ' Increment the pause count by one.
            intTextPauseCount += 1

        ElseIf (intTextSlideCount <= 150 And intTextPauseCount > 50) Then
            ' If the Pause Count is greater than 50, and the Slide Count is less than or equal to 150,
            ' Increment the Slide Count by 1
            ' Move the Title PictureBox up by 1 pixel
            intTextSlideCount += 1
            pctTitle.Top = pctTitle.Top - 1

        ElseIf (intTextSlideCount > 150 And intTextPauseCount > 50) Then
            ' If the Text Slide Count is greater than 50 and the Text Pause Count is greater than 50,
            ' Reset both counters.
            intTextPauseCount = 0
            intTextSlideCount = 0
            ' Stop the Text Slide Counter.
            tmrTextSlide.Stop()

            ' Show the Game Selection Screen elements.
            btnStart.Show()
            btnStart.Location = New System.Drawing.Point((Me.Width / 2) - (btnStart.Width / 2), (pctTitle.Top + pctTitle.Height + 20))
            btnAbout.Show()
            btnAbout.Location = New System.Drawing.Point((Me.Width / 2) - (btnAbout.Width / 2), (btnStart.Top + btnStart.Height + 10))
            btnQuit.Show()
            btnQuit.Location = New System.Drawing.Point((Me.Width / 2) - (btnQuit.Width / 2), (btnAbout.Top + btnAbout.Height + 10))
            grpPlayerMode.Show()
            grpPlayerMode.Location = New System.Drawing.Point((Me.Width / 2) + btnStart.Width + 10, btnStart.Top)
            grpArrowKeys.Show()
            grpArrowKeys.Location = New System.Drawing.Point((Me.Width / 2) + btnAbout.Width + 10, (grpPlayerMode.Top + grpPlayerMode.Height + 10))

        End If
    End Sub

    ' btnAbout_Click - the event handler for the about button click.
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        ' Show the About form.
        frmAbout.Show()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        ' Terminate Application.
        Application.Exit()
    End Sub

    ' radPlayerVsPlayer_CheckedChanged - the event handler if the Player vs. Player or Player vs. Computer radio buttons checked changed.
    Private Sub radPlayerVsPlayer_CheckedChanged(sender As Object, e As EventArgs) Handles radPlayerVsPlayer.CheckedChanged, radPlayerVsComputer.CheckedChanged

        If radPlayerVsComputer.Checked = True Then
            ' If Player vs. Computer is checked,
            ' Hide the Arrow Keys group box.
            grpArrowKeys.Hide()
        Else
            ' If Player vs. Player is checked,
            ' Show the Arrow Keys group box.
            grpArrowKeys.Show()
        End If
    End Sub

    ' tmrKeys_Tick - the event handler for the keys timer tick.
    Private Sub tmrKeys_Tick(sender As Object, e As EventArgs) Handles tmrKeys.Tick

        If (GetAsyncKeyState(80) And bolIsGamePaused = False) Then
            ' If The P key is pressed during gameplay,
            ' "Pause the Game"
            ' Hide all gameplay elements.
            ' Pause any active audio streams.
            ' Position the Title PictureBox and Pause Label.
            ' Stop the Update Timer.
            lneScope.Hide()
            ovlScope.Hide()
            lblAmmoCount.Hide()
            lblPower.Hide()
            lblScore.Hide()
            lblPlayerTwoScore.Hide()
            pctPlayerTwo.Hide()
            pctTarget.Hide()
            pctCannon.Hide()
            pctAtom.Hide()
            bolIsGamePaused = True
            bolPauseLabelVisible = True
            pctTitle.Show()
            lblPause.Show()
            lblPause.Location = New System.Drawing.Point((Me.Width / 2) - (lblPause.Width / 2), (pctTitle.Bottom + lblPause.Height))
            tmrUpdate.Stop()

        ElseIf (bolIsGamePaused = True And GetAsyncKeyState(80)) Then
            ' If the Game is paused, and the P key is pressed,
            ' "Unpause the Game"

            If (bolProjectileInMotion = False) Then
                ' If a projectile was not in motion when the game was paused,
                ' Show all gameplay elements in their initial states.
                ' Resume all audio streams.
                ' Start the Update timer.
                lneScope.Show()
                ovlScope.Show()
                pctCannon.Show()
                lblAmmoCount.Show()
                lblPower.Show()
                lblScore.Show()
                lblPlayerTwoScore.Show()
                pctPlayerTwo.Show()
                bolPlayerVisible = True
                pctTarget.Show()
                pctAtom.Show()
                bolIsGamePaused = False
                pctTitle.Hide()
                lblPause.Hide()
                bolPauseLabelVisible = False
                tmrUpdate.Start()

            ElseIf (bolProjectileInMotion = True) Then
                ' If a projectile was in motion when the game was paused,
                ' only show the elements visible while a projectile is in motion.
                ' Resume any active audio streams.
                ' Start the Update timer.
                lblAmmoCount.Show()
                lblPower.Show()
                lblScore.Show()
                lblPlayerTwoScore.Show()
                pctPlayerTwo.Show()
                bolPlayerVisible = True
                pctTarget.Show()
                pctAtom.Show()
                bolIsGamePaused = False
                pctTitle.Hide()
                lblPause.Hide()
                bolPauseLabelVisible = False
                tmrUpdate.Start()
            End If
        End If

        If GetAsyncKeyState(27) Then
            ' If the Escape Key is pressed during the game,
            ' Terminate the application.
            Application.Exit()
        End If

        ' Pause Label flashing during pause.
        If (bolIsGamePaused = True) Then
            ' If the game is paused,
            ' run the following code:

            If (bolPauseLabelVisible = True And intPauseLabelCounter <= 30) Then
                ' If the Pause Label is visible, and the Pause Label Counter is less than or equal to 30,
                ' Increment the pause label counter by 10.
                intPauseLabelCounter += 10

            ElseIf (bolPauseLabelVisible = True And intPauseLabelCounter > 30) Then
                ' If the Pause Label is visible, and the Pause Label Counter is greater than 30,
                ' Reset the counter.
                ' Hide the pause label.
                ' Change the Pause Label Visible flag to False.
                intPauseLabelCounter = 0
                lblPause.Hide()
                bolPauseLabelVisible = False

            ElseIf (bolPauseLabelVisible = False And intPauseLabelCounter <= 30) Then
                ' If the Pause Label is not visible, and the Pause Label Counter is less than or equal to 30,
                ' Increment the Pause Label Counter by 10.
                intPauseLabelCounter += 10

            ElseIf (bolPauseLabelVisible = False And intPauseLabelCounter > 30) Then
                ' If the Pause Label is not visible, and the Pause Label Counter is greater than 30,
                ' Reset the counter.
                ' Show the pause label.
                ' Change the Pause Label Visible flag to True.
                intPauseLabelCounter = 0
                lblPause.Show()
                bolPauseLabelVisible = True

            End If

        End If

    End Sub

End Class