<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lnHostel = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSelection = New System.Windows.Forms.Button()
        Me.Headerlbl = New System.Windows.Forms.Label()
        Me.Instructlbl = New System.Windows.Forms.Label()
        Me.Confirmlbl = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picDublinHostel = New System.Windows.Forms.PictureBox()
        Me.picLondonHostel = New System.Windows.Forms.PictureBox()
        CType(Me.picDublinHostel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLondonHostel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lnHostel
        '
        Me.lnHostel.AutoSize = True
        Me.lnHostel.BackColor = System.Drawing.Color.Wheat
        Me.lnHostel.Cursor = System.Windows.Forms.Cursors.Default
        Me.lnHostel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lnHostel.Location = New System.Drawing.Point(10, 153)
        Me.lnHostel.Name = "lnHostel"
        Me.lnHostel.Size = New System.Drawing.Size(86, 23)
        Me.lnHostel.TabIndex = 2
        Me.lnHostel.Text = "London Hostel"
        Me.lnHostel.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.Wheat
        Me.Button2.Location = New System.Drawing.Point(199, 153)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Dublin Hostel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnSelection
        '
        Me.btnSelection.AutoSize = True
        Me.btnSelection.BackColor = System.Drawing.Color.Wheat
        Me.btnSelection.Enabled = False
        Me.btnSelection.Location = New System.Drawing.Point(102, 153)
        Me.btnSelection.Name = "btnSelection"
        Me.btnSelection.Size = New System.Drawing.Size(91, 23)
        Me.btnSelection.TabIndex = 4
        Me.btnSelection.Text = "Select Location"
        Me.btnSelection.UseVisualStyleBackColor = False
        '
        'Headerlbl
        '
        Me.Headerlbl.AutoSize = True
        Me.Headerlbl.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Headerlbl.ForeColor = System.Drawing.Color.Black
        Me.Headerlbl.Location = New System.Drawing.Point(14, 9)
        Me.Headerlbl.Name = "Headerlbl"
        Me.Headerlbl.Size = New System.Drawing.Size(263, 25)
        Me.Headerlbl.TabIndex = 5
        Me.Headerlbl.Text = "Select a Hostel Location"
        '
        'Instructlbl
        '
        Me.Instructlbl.AutoSize = True
        Me.Instructlbl.Location = New System.Drawing.Point(44, 189)
        Me.Instructlbl.Name = "Instructlbl"
        Me.Instructlbl.Size = New System.Drawing.Size(203, 13)
        Me.Instructlbl.TabIndex = 6
        Me.Instructlbl.Text = "Identify your choice then select a location"
        '
        'Confirmlbl
        '
        Me.Confirmlbl.AutoSize = True
        Me.Confirmlbl.Location = New System.Drawing.Point(44, 211)
        Me.Confirmlbl.Name = "Confirmlbl"
        Me.Confirmlbl.Size = New System.Drawing.Size(176, 13)
        Me.Confirmlbl.TabIndex = 7
        Me.Confirmlbl.Text = "You have selected a hostel location"
        Me.Confirmlbl.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(102, 236)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picDublinHostel
        '
        Me.picDublinHostel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDublinHostel.Image = Global.WindowsApplication1.My.Resources.Resources.Dublin
        Me.picDublinHostel.Location = New System.Drawing.Point(151, 41)
        Me.picDublinHostel.Name = "picDublinHostel"
        Me.picDublinHostel.Size = New System.Drawing.Size(121, 90)
        Me.picDublinHostel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDublinHostel.TabIndex = 1
        Me.picDublinHostel.TabStop = False
        Me.picDublinHostel.Visible = False
        '
        'picLondonHostel
        '
        Me.picLondonHostel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLondonHostel.Image = Global.WindowsApplication1.My.Resources.Resources.London
        Me.picLondonHostel.Location = New System.Drawing.Point(10, 41)
        Me.picLondonHostel.Name = "picLondonHostel"
        Me.picLondonHostel.Size = New System.Drawing.Size(124, 90)
        Me.picLondonHostel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLondonHostel.TabIndex = 0
        Me.picLondonHostel.TabStop = False
        Me.picLondonHostel.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Confirmlbl)
        Me.Controls.Add(Me.Instructlbl)
        Me.Controls.Add(Me.Headerlbl)
        Me.Controls.Add(Me.btnSelection)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lnHostel)
        Me.Controls.Add(Me.picDublinHostel)
        Me.Controls.Add(Me.picLondonHostel)
        Me.Name = "Form1"
        Me.Text = "European Hostel"
        CType(Me.picDublinHostel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLondonHostel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picLondonHostel As System.Windows.Forms.PictureBox
    Friend WithEvents picDublinHostel As System.Windows.Forms.PictureBox
    Friend WithEvents lnHostel As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnSelection As System.Windows.Forms.Button
    Friend WithEvents Headerlbl As System.Windows.Forms.Label
    Friend WithEvents Instructlbl As System.Windows.Forms.Label
    Friend WithEvents Confirmlbl As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
