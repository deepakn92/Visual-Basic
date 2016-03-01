<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWindowsOnlineShop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWindowsOnlineShop))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.grpShipLocation = New System.Windows.Forms.GroupBox()
        Me.radCan = New System.Windows.Forms.RadioButton()
        Me.radLatAm = New System.Windows.Forms.RadioButton()
        Me.radUSA = New System.Windows.Forms.RadioButton()
        Me.radShipOverngt = New System.Windows.Forms.RadioButton()
        Me.lblShipFeeHd = New System.Windows.Forms.Label()
        Me.lblCostEstimate = New System.Windows.Forms.Label()
        Me.btnShpFee = New System.Windows.Forms.Button()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.picShipping = New System.Windows.Forms.PictureBox()
        Me.grpShipLocation.SuspendLayout()
        CType(Me.picShipping, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Item Weight:"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(224, 13)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(29, 20)
        Me.txtWeight.TabIndex = 1
        '
        'grpShipLocation
        '
        Me.grpShipLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpShipLocation.Controls.Add(Me.radCan)
        Me.grpShipLocation.Controls.Add(Me.radLatAm)
        Me.grpShipLocation.Controls.Add(Me.radUSA)
        Me.grpShipLocation.Location = New System.Drawing.Point(126, 50)
        Me.grpShipLocation.Name = "grpShipLocation"
        Me.grpShipLocation.Size = New System.Drawing.Size(138, 103)
        Me.grpShipLocation.TabIndex = 2
        Me.grpShipLocation.TabStop = False
        '
        'radCan
        '
        Me.radCan.AutoSize = True
        Me.radCan.Location = New System.Drawing.Point(7, 67)
        Me.radCan.Name = "radCan"
        Me.radCan.Size = New System.Drawing.Size(62, 17)
        Me.radCan.TabIndex = 2
        Me.radCan.Text = "Canada"
        Me.radCan.UseVisualStyleBackColor = True
        '
        'radLatAm
        '
        Me.radLatAm.AutoSize = True
        Me.radLatAm.Location = New System.Drawing.Point(7, 43)
        Me.radLatAm.Name = "radLatAm"
        Me.radLatAm.Size = New System.Drawing.Size(89, 17)
        Me.radLatAm.TabIndex = 1
        Me.radLatAm.Text = "Latin America"
        Me.radLatAm.UseVisualStyleBackColor = True
        '
        'radUSA
        '
        Me.radUSA.AutoSize = True
        Me.radUSA.Checked = True
        Me.radUSA.Location = New System.Drawing.Point(7, 19)
        Me.radUSA.Name = "radUSA"
        Me.radUSA.Size = New System.Drawing.Size(89, 17)
        Me.radUSA.TabIndex = 0
        Me.radUSA.TabStop = True
        Me.radUSA.Text = "United States"
        Me.radUSA.UseVisualStyleBackColor = True
        '
        'radShipOverngt
        '
        Me.radShipOverngt.AutoSize = True
        Me.radShipOverngt.Location = New System.Drawing.Point(49, 159)
        Me.radShipOverngt.Name = "radShipOverngt"
        Me.radShipOverngt.Size = New System.Drawing.Size(170, 17)
        Me.radShipOverngt.TabIndex = 3
        Me.radShipOverngt.TabStop = True
        Me.radShipOverngt.Text = "Overnight Shipping Requested"
        Me.radShipOverngt.UseVisualStyleBackColor = True
        '
        'lblShipFeeHd
        '
        Me.lblShipFeeHd.AutoSize = True
        Me.lblShipFeeHd.Location = New System.Drawing.Point(46, 197)
        Me.lblShipFeeHd.Name = "lblShipFeeHd"
        Me.lblShipFeeHd.Size = New System.Drawing.Size(69, 13)
        Me.lblShipFeeHd.TabIndex = 4
        Me.lblShipFeeHd.Text = "Shipping Fee"
        '
        'lblCostEstimate
        '
        Me.lblCostEstimate.AutoSize = True
        Me.lblCostEstimate.Location = New System.Drawing.Point(147, 197)
        Me.lblCostEstimate.Name = "lblCostEstimate"
        Me.lblCostEstimate.Size = New System.Drawing.Size(25, 13)
        Me.lblCostEstimate.TabIndex = 5
        Me.lblCostEstimate.Text = "$88"
        '
        'btnShpFee
        '
        Me.btnShpFee.Location = New System.Drawing.Point(40, 224)
        Me.btnShpFee.Name = "btnShpFee"
        Me.btnShpFee.Size = New System.Drawing.Size(85, 23)
        Me.btnShpFee.TabIndex = 6
        Me.btnShpFee.Text = "Shipping Fee"
        Me.btnShpFee.UseVisualStyleBackColor = True
        '
        'btnClr
        '
        Me.btnClr.Location = New System.Drawing.Point(141, 224)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(75, 23)
        Me.btnClr.TabIndex = 7
        Me.btnClr.Text = "Clear"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'picShipping
        '
        Me.picShipping.Image = CType(resources.GetObject("picShipping.Image"), System.Drawing.Image)
        Me.picShipping.Location = New System.Drawing.Point(12, 13)
        Me.picShipping.Name = "picShipping"
        Me.picShipping.Size = New System.Drawing.Size(101, 140)
        Me.picShipping.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShipping.TabIndex = 8
        Me.picShipping.TabStop = False
        '
        'frmWindowsOnlineShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(309, 262)
        Me.Controls.Add(Me.picShipping)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.btnShpFee)
        Me.Controls.Add(Me.lblCostEstimate)
        Me.Controls.Add(Me.lblShipFeeHd)
        Me.Controls.Add(Me.radShipOverngt)
        Me.Controls.Add(Me.grpShipLocation)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmWindowsOnlineShop"
        Me.Text = "Form1"
        Me.grpShipLocation.ResumeLayout(False)
        Me.grpShipLocation.PerformLayout()
        CType(Me.picShipping, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents grpShipLocation As System.Windows.Forms.GroupBox
    Friend WithEvents radCan As System.Windows.Forms.RadioButton
    Friend WithEvents radLatAm As System.Windows.Forms.RadioButton
    Friend WithEvents radUSA As System.Windows.Forms.RadioButton
    Friend WithEvents radShipOverngt As System.Windows.Forms.RadioButton
    Friend WithEvents lblShipFeeHd As System.Windows.Forms.Label
    Friend WithEvents lblCostEstimate As System.Windows.Forms.Label
    Friend WithEvents btnShpFee As System.Windows.Forms.Button
    Friend WithEvents btnClr As System.Windows.Forms.Button
    Friend WithEvents picShipping As System.Windows.Forms.PictureBox

End Class
