<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.ovlScope = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.lneScope = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblPower = New System.Windows.Forms.Label()
        Me.tmrTargetMovement = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblAmmoCount = New System.Windows.Forms.Label()
        Me.tmrEndGame = New System.Windows.Forms.Timer(Me.components)
        Me.btnStart = New System.Windows.Forms.Button()
        Me.pctCannon = New System.Windows.Forms.PictureBox()
        Me.pctPlayerTwo = New System.Windows.Forms.PictureBox()
        Me.pctTarget = New System.Windows.Forms.PictureBox()
        Me.pctAtom = New System.Windows.Forms.PictureBox()
        Me.grpArrowKeys = New System.Windows.Forms.GroupBox()
        Me.radWADS = New System.Windows.Forms.RadioButton()
        Me.radArrow = New System.Windows.Forms.RadioButton()
        Me.pctTitle = New System.Windows.Forms.PictureBox()
        Me.tmrTextSlide = New System.Windows.Forms.Timer(Me.components)
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.grpPlayerMode = New System.Windows.Forms.GroupBox()
        Me.radPlayerVsComputer = New System.Windows.Forms.RadioButton()
        Me.radPlayerVsPlayer = New System.Windows.Forms.RadioButton()
        Me.lblPlayerTwoScore = New System.Windows.Forms.Label()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.lblPause = New System.Windows.Forms.Label()
        Me.tmrKeys = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pctCannon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPlayerTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctTarget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctAtom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArrowKeys.SuspendLayout()
        CType(Me.pctTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPlayerMode.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Interval = 1
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.ovlScope, Me.lneScope})
        Me.ShapeContainer1.Size = New System.Drawing.Size(784, 562)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'ovlScope
        '
        Me.ovlScope.BorderColor = System.Drawing.Color.Red
        Me.ovlScope.FillGradientColor = System.Drawing.Color.Red
        Me.ovlScope.Location = New System.Drawing.Point(-382, 225)
        Me.ovlScope.Name = "ovlScope"
        Me.ovlScope.Size = New System.Drawing.Size(500, 500)
        '
        'lneScope
        '
        Me.lneScope.BorderColor = System.Drawing.Color.Red
        Me.lneScope.Name = "lneScope"
        Me.lneScope.X1 = 12
        Me.lneScope.X2 = 123
        Me.lneScope.Y1 = 10
        Me.lneScope.Y2 = 10
        '
        'lblPower
        '
        Me.lblPower.AutoSize = True
        Me.lblPower.BackColor = System.Drawing.Color.Transparent
        Me.lblPower.ForeColor = System.Drawing.Color.White
        Me.lblPower.Location = New System.Drawing.Point(15, 75)
        Me.lblPower.Name = "lblPower"
        Me.lblPower.Size = New System.Drawing.Size(66, 13)
        Me.lblPower.TabIndex = 4
        Me.lblPower.Text = "Power Label"
        '
        'tmrTargetMovement
        '
        Me.tmrTargetMovement.Interval = 1
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(15, 29)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(64, 13)
        Me.lblScore.TabIndex = 6
        Me.lblScore.Text = "Score Label"
        '
        'lblAmmoCount
        '
        Me.lblAmmoCount.AutoSize = True
        Me.lblAmmoCount.BackColor = System.Drawing.Color.Transparent
        Me.lblAmmoCount.ForeColor = System.Drawing.Color.White
        Me.lblAmmoCount.Location = New System.Drawing.Point(12, 49)
        Me.lblAmmoCount.Name = "lblAmmoCount"
        Me.lblAmmoCount.Size = New System.Drawing.Size(121, 13)
        Me.lblAmmoCount.TabIndex = 7
        Me.lblAmmoCount.Text = "Ammunition Count Label"
        '
        'tmrEndGame
        '
        Me.tmrEndGame.Interval = 1
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(336, 315)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(112, 42)
        Me.btnStart.TabIndex = 14
        Me.btnStart.Text = "&Start Game"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'pctCannon
        '
        Me.pctCannon.BackColor = System.Drawing.Color.Transparent
        Me.pctCannon.Image = Global.Brozon.My.Resources.Resources.Cannon
        Me.pctCannon.Location = New System.Drawing.Point(6, 186)
        Me.pctCannon.Name = "pctCannon"
        Me.pctCannon.Size = New System.Drawing.Size(73, 78)
        Me.pctCannon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctCannon.TabIndex = 12
        Me.pctCannon.TabStop = False
        '
        'pctPlayerTwo
        '
        Me.pctPlayerTwo.BackColor = System.Drawing.Color.Transparent
        Me.pctPlayerTwo.Image = Global.Brozon.My.Resources.Resources.player2
        Me.pctPlayerTwo.Location = New System.Drawing.Point(3, 299)
        Me.pctPlayerTwo.Name = "pctPlayerTwo"
        Me.pctPlayerTwo.Size = New System.Drawing.Size(90, 90)
        Me.pctPlayerTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctPlayerTwo.TabIndex = 11
        Me.pctPlayerTwo.TabStop = False
        '
        'pctTarget
        '
        Me.pctTarget.BackColor = System.Drawing.Color.Transparent
        Me.pctTarget.Image = Global.Brozon.My.Resources.Resources.Target
        Me.pctTarget.Location = New System.Drawing.Point(3, 411)
        Me.pctTarget.Name = "pctTarget"
        Me.pctTarget.Size = New System.Drawing.Size(90, 90)
        Me.pctTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctTarget.TabIndex = 10
        Me.pctTarget.TabStop = False
        '
        'pctAtom
        '
        Me.pctAtom.BackColor = System.Drawing.Color.Transparent
        Me.pctAtom.Image = Global.Brozon.My.Resources.Resources.Cannonball
        Me.pctAtom.Location = New System.Drawing.Point(12, 114)
        Me.pctAtom.Name = "pctAtom"
        Me.pctAtom.Size = New System.Drawing.Size(50, 50)
        Me.pctAtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctAtom.TabIndex = 0
        Me.pctAtom.TabStop = False
        '
        'grpArrowKeys
        '
        Me.grpArrowKeys.Controls.Add(Me.radWADS)
        Me.grpArrowKeys.Controls.Add(Me.radArrow)
        Me.grpArrowKeys.ForeColor = System.Drawing.Color.White
        Me.grpArrowKeys.Location = New System.Drawing.Point(496, 399)
        Me.grpArrowKeys.Name = "grpArrowKeys"
        Me.grpArrowKeys.Size = New System.Drawing.Size(200, 71)
        Me.grpArrowKeys.TabIndex = 15
        Me.grpArrowKeys.TabStop = False
        Me.grpArrowKeys.Text = "Arrow Keys"
        '
        'radWADS
        '
        Me.radWADS.AutoSize = True
        Me.radWADS.Location = New System.Drawing.Point(6, 42)
        Me.radWADS.Name = "radWADS"
        Me.radWADS.Size = New System.Drawing.Size(84, 17)
        Me.radWADS.TabIndex = 1
        Me.radWADS.TabStop = True
        Me.radWADS.Text = "WASD Keys"
        Me.radWADS.UseVisualStyleBackColor = True
        '
        'radArrow
        '
        Me.radArrow.AutoSize = True
        Me.radArrow.Checked = True
        Me.radArrow.Location = New System.Drawing.Point(6, 19)
        Me.radArrow.Name = "radArrow"
        Me.radArrow.Size = New System.Drawing.Size(78, 17)
        Me.radArrow.TabIndex = 0
        Me.radArrow.TabStop = True
        Me.radArrow.Text = "Arrow Keys"
        Me.radArrow.UseVisualStyleBackColor = True
        '
        'pctTitle
        '
        Me.pctTitle.BackgroundImage = Global.Brozon.My.Resources.Resources.logo
        Me.pctTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctTitle.Location = New System.Drawing.Point(197, 186)
        Me.pctTitle.Name = "pctTitle"
        Me.pctTitle.Size = New System.Drawing.Size(403, 107)
        Me.pctTitle.TabIndex = 16
        Me.pctTitle.TabStop = False
        '
        'tmrTextSlide
        '
        Me.tmrTextSlide.Interval = 1
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(336, 370)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(112, 42)
        Me.btnAbout.TabIndex = 14
        Me.btnAbout.Text = "&About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(336, 428)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(112, 42)
        Me.btnQuit.TabIndex = 14
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'grpPlayerMode
        '
        Me.grpPlayerMode.Controls.Add(Me.radPlayerVsComputer)
        Me.grpPlayerMode.Controls.Add(Me.radPlayerVsPlayer)
        Me.grpPlayerMode.ForeColor = System.Drawing.Color.White
        Me.grpPlayerMode.Location = New System.Drawing.Point(496, 315)
        Me.grpPlayerMode.Name = "grpPlayerMode"
        Me.grpPlayerMode.Size = New System.Drawing.Size(200, 75)
        Me.grpPlayerMode.TabIndex = 17
        Me.grpPlayerMode.TabStop = False
        Me.grpPlayerMode.Text = "Player Mode"
        '
        'radPlayerVsComputer
        '
        Me.radPlayerVsComputer.AutoSize = True
        Me.radPlayerVsComputer.Location = New System.Drawing.Point(6, 42)
        Me.radPlayerVsComputer.Name = "radPlayerVsComputer"
        Me.radPlayerVsComputer.Size = New System.Drawing.Size(119, 17)
        Me.radPlayerVsComputer.TabIndex = 1
        Me.radPlayerVsComputer.Text = "Player vs. Computer"
        Me.radPlayerVsComputer.UseVisualStyleBackColor = True
        '
        'radPlayerVsPlayer
        '
        Me.radPlayerVsPlayer.AutoSize = True
        Me.radPlayerVsPlayer.Checked = True
        Me.radPlayerVsPlayer.Location = New System.Drawing.Point(6, 19)
        Me.radPlayerVsPlayer.Name = "radPlayerVsPlayer"
        Me.radPlayerVsPlayer.Size = New System.Drawing.Size(103, 17)
        Me.radPlayerVsPlayer.TabIndex = 0
        Me.radPlayerVsPlayer.TabStop = True
        Me.radPlayerVsPlayer.Text = "Player vs. Player"
        Me.radPlayerVsPlayer.UseVisualStyleBackColor = True
        '
        'lblPlayerTwoScore
        '
        Me.lblPlayerTwoScore.AutoSize = True
        Me.lblPlayerTwoScore.ForeColor = System.Drawing.Color.White
        Me.lblPlayerTwoScore.Location = New System.Drawing.Point(101, 29)
        Me.lblPlayerTwoScore.Name = "lblPlayerTwoScore"
        Me.lblPlayerTwoScore.Size = New System.Drawing.Size(120, 13)
        Me.lblPlayerTwoScore.TabIndex = 18
        Me.lblPlayerTwoScore.Text = "Player Two Score Label"
        '
        'lblWinner
        '
        Me.lblWinner.AutoSize = True
        Me.lblWinner.ForeColor = System.Drawing.Color.White
        Me.lblWinner.Location = New System.Drawing.Point(92, 75)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(41, 13)
        Me.lblWinner.TabIndex = 19
        Me.lblWinner.Text = "Winner"
        '
        'lblPause
        '
        Me.lblPause.AutoSize = True
        Me.lblPause.ForeColor = System.Drawing.Color.White
        Me.lblPause.Location = New System.Drawing.Point(113, 114)
        Me.lblPause.Name = "lblPause"
        Me.lblPause.Size = New System.Drawing.Size(43, 13)
        Me.lblPause.TabIndex = 20
        Me.lblPause.Text = "Paused"
        '
        'tmrKeys
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.lblPause)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.lblPlayerTwoScore)
        Me.Controls.Add(Me.grpPlayerMode)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.pctTitle)
        Me.Controls.Add(Me.grpArrowKeys)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.pctCannon)
        Me.Controls.Add(Me.pctPlayerTwo)
        Me.Controls.Add(Me.pctTarget)
        Me.Controls.Add(Me.lblAmmoCount)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblPower)
        Me.Controls.Add(Me.pctAtom)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brozon"
        CType(Me.pctCannon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPlayerTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctTarget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctAtom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArrowKeys.ResumeLayout(False)
        Me.grpArrowKeys.PerformLayout()
        CType(Me.pctTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPlayerMode.ResumeLayout(False)
        Me.grpPlayerMode.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrUpdate As Timer
    Friend WithEvents pctAtom As PictureBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents lneScope As PowerPacks.LineShape
    Friend WithEvents ovlScope As PowerPacks.OvalShape
    Friend WithEvents lblPower As Label
    Friend WithEvents tmrTargetMovement As Timer
    Friend WithEvents lblScore As Label
    Friend WithEvents lblAmmoCount As Label
    Friend WithEvents pctTarget As PictureBox
    Friend WithEvents pctPlayerTwo As PictureBox
    Friend WithEvents pctCannon As PictureBox
    Friend WithEvents tmrEndGame As Timer
    Friend WithEvents btnStart As Button
    Friend WithEvents grpArrowKeys As GroupBox
    Friend WithEvents radWADS As RadioButton
    Friend WithEvents radArrow As RadioButton
    Friend WithEvents pctTitle As PictureBox
    Friend WithEvents tmrTextSlide As Timer
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents grpPlayerMode As GroupBox
    Friend WithEvents radPlayerVsComputer As RadioButton
    Friend WithEvents radPlayerVsPlayer As RadioButton
    Friend WithEvents lblPlayerTwoScore As Label
    Friend WithEvents lblWinner As Label
    Friend WithEvents lblPause As Label
    Friend WithEvents tmrKeys As Timer
End Class
