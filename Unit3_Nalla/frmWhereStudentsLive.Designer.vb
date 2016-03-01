<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWhereStudentsLive
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWhereStudentsLive))
        Me.mnuWhereStudentsLive = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnMileage = New System.Windows.Forms.Button()
        Me.lstMileage = New System.Windows.Forms.ListBox()
        Me.lblAverageMileage = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mnuWhereStudentsLive.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuWhereStudentsLive
        '
        Me.mnuWhereStudentsLive.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuWhereStudentsLive.Location = New System.Drawing.Point(0, 0)
        Me.mnuWhereStudentsLive.Name = "mnuWhereStudentsLive"
        Me.mnuWhereStudentsLive.Size = New System.Drawing.Size(609, 24)
        Me.mnuWhereStudentsLive.TabIndex = 0
        Me.mnuWhereStudentsLive.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lblTitle.Location = New System.Drawing.Point(119, 206)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(310, 29)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Where Our Students Live"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMileage
        '
        Me.btnMileage.BackColor = System.Drawing.Color.SteelBlue
        Me.btnMileage.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMileage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMileage.Location = New System.Drawing.Point(167, 250)
        Me.btnMileage.Name = "btnMileage"
        Me.btnMileage.Size = New System.Drawing.Size(224, 49)
        Me.btnMileage.TabIndex = 2
        Me.btnMileage.Text = "Enter Mileage"
        Me.btnMileage.UseVisualStyleBackColor = False
        '
        'lstMileage
        '
        Me.lstMileage.FormattingEnabled = True
        Me.lstMileage.Location = New System.Drawing.Point(435, 206)
        Me.lstMileage.Name = "lstMileage"
        Me.lstMileage.Size = New System.Drawing.Size(54, 173)
        Me.lstMileage.TabIndex = 3
        '
        'lblAverageMileage
        '
        Me.lblAverageMileage.AutoSize = True
        Me.lblAverageMileage.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblAverageMileage.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageMileage.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblAverageMileage.Location = New System.Drawing.Point(70, 409)
        Me.lblAverageMileage.Name = "lblAverageMileage"
        Me.lblAverageMileage.Size = New System.Drawing.Size(464, 18)
        Me.lblAverageMileage.TabIndex = 4
        Me.lblAverageMileage.Text = "Our students live an average of XXX.XX miles from the school"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(124, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(337, 162)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'frmWhereStudentsLive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(609, 462)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblAverageMileage)
        Me.Controls.Add(Me.lstMileage)
        Me.Controls.Add(Me.btnMileage)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuWhereStudentsLive)
        Me.MainMenuStrip = Me.mnuWhereStudentsLive
        Me.Name = "frmWhereStudentsLive"
        Me.Text = "How Far Away Are Students' Homes?"
        Me.mnuWhereStudentsLive.ResumeLayout(False)
        Me.mnuWhereStudentsLive.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuWhereStudentsLive As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnMileage As System.Windows.Forms.Button
    Friend WithEvents lstMileage As System.Windows.Forms.ListBox
    Friend WithEvents lblAverageMileage As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
