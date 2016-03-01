<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStateFairTickets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStateFairTickets))
        Me.txtNoOfTickets = New System.Windows.Forms.TextBox()
        Me.picFair = New System.Windows.Forms.PictureBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblNoOfTickets = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnDisplayCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDisplayCost = New System.Windows.Forms.Label()
        CType(Me.picFair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNoOfTickets
        '
        Me.txtNoOfTickets.Location = New System.Drawing.Point(186, 93)
        Me.txtNoOfTickets.Name = "txtNoOfTickets"
        Me.txtNoOfTickets.Size = New System.Drawing.Size(36, 20)
        Me.txtNoOfTickets.TabIndex = 0
        Me.txtNoOfTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picFair
        '
        Me.picFair.Image = CType(resources.GetObject("picFair.Image"), System.Drawing.Image)
        Me.picFair.Location = New System.Drawing.Point(267, 31)
        Me.picFair.Name = "picFair"
        Me.picFair.Size = New System.Drawing.Size(192, 195)
        Me.picFair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFair.TabIndex = 1
        Me.picFair.TabStop = False
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalCost.Location = New System.Drawing.Point(51, 125)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(126, 13)
        Me.lblTotalCost.TabIndex = 2
        Me.lblTotalCost.Text = "Total Cost of Tickets"
        '
        'lblNoOfTickets
        '
        Me.lblNoOfTickets.AutoSize = True
        Me.lblNoOfTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfTickets.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNoOfTickets.Location = New System.Drawing.Point(29, 96)
        Me.lblNoOfTickets.Name = "lblNoOfTickets"
        Me.lblNoOfTickets.Size = New System.Drawing.Size(151, 13)
        Me.lblNoOfTickets.TabIndex = 3
        Me.lblNoOfTickets.Text = "Enter Number Of Tickets:"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblHeading.Location = New System.Drawing.Point(61, 51)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(119, 15)
        Me.lblHeading.TabIndex = 4
        Me.lblHeading.Text = "$12.99 Per Ticket"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTitle.Location = New System.Drawing.Point(12, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(233, 20)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Join Us at the State Fair!"
        '
        'btnDisplayCost
        '
        Me.btnDisplayCost.Location = New System.Drawing.Point(13, 173)
        Me.btnDisplayCost.Name = "btnDisplayCost"
        Me.btnDisplayCost.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplayCost.TabIndex = 6
        Me.btnDisplayCost.Text = "Display Cost"
        Me.btnDisplayCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(96, 173)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(186, 173)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDisplayCost
        '
        Me.lblDisplayCost.AutoSize = True
        Me.lblDisplayCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayCost.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDisplayCost.Location = New System.Drawing.Point(187, 125)
        Me.lblDisplayCost.Name = "lblDisplayCost"
        Me.lblDisplayCost.Size = New System.Drawing.Size(35, 13)
        Me.lblDisplayCost.TabIndex = 9
        Me.lblDisplayCost.Text = "$888"
        '
        'frmStateFairTickets
        '
        Me.AcceptButton = Me.btnDisplayCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(475, 262)
        Me.Controls.Add(Me.lblDisplayCost)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayCost)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.lblNoOfTickets)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.picFair)
        Me.Controls.Add(Me.txtNoOfTickets)
        Me.Name = "frmStateFairTickets"
        Me.Text = "Form1"
        CType(Me.picFair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNoOfTickets As System.Windows.Forms.TextBox
    Friend WithEvents picFair As System.Windows.Forms.PictureBox
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents lblNoOfTickets As System.Windows.Forms.Label
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnDisplayCost As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblDisplayCost As System.Windows.Forms.Label

End Class
