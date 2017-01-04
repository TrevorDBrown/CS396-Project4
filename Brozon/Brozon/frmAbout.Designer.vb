<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pctTrevor = New System.Windows.Forms.PictureBox()
        Me.pctTravis = New System.Windows.Forms.PictureBox()
        Me.lblTravis = New System.Windows.Forms.Label()
        Me.lblTrevor = New System.Windows.Forms.Label()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.tmrTextSlide = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctTrevor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctTravis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Brozon.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(89, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(319, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pctTrevor
        '
        Me.pctTrevor.Image = Global.Brozon.My.Resources.Resources.trevor
        Me.pctTrevor.Location = New System.Drawing.Point(268, 110)
        Me.pctTrevor.Name = "pctTrevor"
        Me.pctTrevor.Size = New System.Drawing.Size(90, 90)
        Me.pctTrevor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctTrevor.TabIndex = 0
        Me.pctTrevor.TabStop = False
        '
        'pctTravis
        '
        Me.pctTravis.Image = Global.Brozon.My.Resources.Resources.travis
        Me.pctTravis.Location = New System.Drawing.Point(139, 110)
        Me.pctTravis.Name = "pctTravis"
        Me.pctTravis.Size = New System.Drawing.Size(90, 90)
        Me.pctTravis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctTravis.TabIndex = 1
        Me.pctTravis.TabStop = False
        '
        'lblTravis
        '
        Me.lblTravis.AutoSize = True
        Me.lblTravis.BackColor = System.Drawing.Color.Transparent
        Me.lblTravis.ForeColor = System.Drawing.Color.White
        Me.lblTravis.Location = New System.Drawing.Point(144, 203)
        Me.lblTravis.Name = "lblTravis"
        Me.lblTravis.Size = New System.Drawing.Size(84, 13)
        Me.lblTravis.TabIndex = 2
        Me.lblTravis.Text = "Travis Anderson"
        '
        'lblTrevor
        '
        Me.lblTrevor.AutoSize = True
        Me.lblTrevor.BackColor = System.Drawing.Color.Transparent
        Me.lblTrevor.ForeColor = System.Drawing.Color.White
        Me.lblTrevor.Location = New System.Drawing.Point(277, 203)
        Me.lblTrevor.Name = "lblTrevor"
        Me.lblTrevor.Size = New System.Drawing.Size(71, 13)
        Me.lblTrevor.TabIndex = 3
        Me.lblTrevor.Text = "Trevor Brown"
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = True
        Me.lblAbout.BackColor = System.Drawing.Color.Transparent
        Me.lblAbout.ForeColor = System.Drawing.Color.White
        Me.lblAbout.Location = New System.Drawing.Point(12, 281)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(803, 13)
        Me.lblAbout.TabIndex = 4
        Me.lblAbout.Text = "(c)2016 Trevor D. Brown and Travis Anderson. All rights reserved. This project wa" &
    "s designed as partial fulfillment of Project 4 in Dr. Wang's section of CS 396 (" &
    "Fall 2016). "
        '
        'tmrTextSlide
        '
        Me.tmrTextSlide.Interval = 1
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(496, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.lblTrevor)
        Me.Controls.Add(Me.lblTravis)
        Me.Controls.Add(Me.pctTravis)
        Me.Controls.Add(Me.pctTrevor)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctTrevor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctTravis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pctTrevor As PictureBox
    Friend WithEvents pctTravis As PictureBox
    Friend WithEvents lblTravis As Label
    Friend WithEvents lblTrevor As Label
    Friend WithEvents lblAbout As Label
    Friend WithEvents tmrTextSlide As Timer
End Class
