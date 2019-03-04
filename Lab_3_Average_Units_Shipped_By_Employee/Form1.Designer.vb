<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShippedByEmployee
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
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.txtDisplayUnits1 = New System.Windows.Forms.TextBox()
        Me.txtDisplayUnits2 = New System.Windows.Forms.TextBox()
        Me.txtDisplayUnits3 = New System.Windows.Forms.TextBox()
        Me.lblDisplayAverage1 = New System.Windows.Forms.Label()
        Me.lblDisplayAverage2 = New System.Windows.Forms.Label()
        Me.lblDisplayAverage3 = New System.Windows.Forms.Label()
        Me.lblDisplayCompanyAverage = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.AverageUnitsShippedByEmployeeTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblDays
        '
        Me.lblDays.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDays.Location = New System.Drawing.Point(11, 12)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(70, 27)
        Me.lblDays.TabIndex = 0
        Me.lblDays.Text = "Day 1"
        Me.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUnits
        '
        Me.lblUnits.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUnits.Location = New System.Drawing.Point(11, 50)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(70, 27)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "&Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUnits
        '
        Me.txtUnits.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUnits.Location = New System.Drawing.Point(87, 49)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(100, 28)
        Me.txtUnits.TabIndex = 2
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.txtUnits, "Enter a number of units shipped")
        '
        'lblEmployee1
        '
        Me.lblEmployee1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEmployee1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee1.Location = New System.Drawing.Point(15, 90)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(159, 29)
        Me.lblEmployee1.TabIndex = 3
        Me.lblEmployee1.Text = "Employee 1"
        Me.lblEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee2
        '
        Me.lblEmployee2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEmployee2.Location = New System.Drawing.Point(186, 90)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(159, 29)
        Me.lblEmployee2.TabIndex = 4
        Me.lblEmployee2.Text = "Employee 2"
        Me.lblEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee3
        '
        Me.lblEmployee3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEmployee3.Location = New System.Drawing.Point(358, 90)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(159, 29)
        Me.lblEmployee3.TabIndex = 5
        Me.lblEmployee3.Text = "Employee 3"
        Me.lblEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDisplayUnits1
        '
        Me.txtDisplayUnits1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDisplayUnits1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtDisplayUnits1.Location = New System.Drawing.Point(15, 134)
        Me.txtDisplayUnits1.Multiline = True
        Me.txtDisplayUnits1.Name = "txtDisplayUnits1"
        Me.txtDisplayUnits1.ReadOnly = True
        Me.txtDisplayUnits1.Size = New System.Drawing.Size(159, 151)
        Me.txtDisplayUnits1.TabIndex = 6
        Me.txtDisplayUnits1.TabStop = False
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.txtDisplayUnits1, "Displays a number of units shipped per day for Employee 1")
        '
        'txtDisplayUnits2
        '
        Me.txtDisplayUnits2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDisplayUnits2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtDisplayUnits2.Location = New System.Drawing.Point(186, 134)
        Me.txtDisplayUnits2.Multiline = True
        Me.txtDisplayUnits2.Name = "txtDisplayUnits2"
        Me.txtDisplayUnits2.ReadOnly = True
        Me.txtDisplayUnits2.Size = New System.Drawing.Size(159, 151)
        Me.txtDisplayUnits2.TabIndex = 7
        Me.txtDisplayUnits2.TabStop = False
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.txtDisplayUnits2, "Displays a number of units shipped per day for Employee 2")
        '
        'txtDisplayUnits3
        '
        Me.txtDisplayUnits3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDisplayUnits3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtDisplayUnits3.Location = New System.Drawing.Point(358, 134)
        Me.txtDisplayUnits3.Multiline = True
        Me.txtDisplayUnits3.Name = "txtDisplayUnits3"
        Me.txtDisplayUnits3.ReadOnly = True
        Me.txtDisplayUnits3.Size = New System.Drawing.Size(159, 151)
        Me.txtDisplayUnits3.TabIndex = 8
        Me.txtDisplayUnits3.TabStop = False
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.txtDisplayUnits3, "Displays a number of units shipped per day for Employee 3")
        '
        'lblDisplayAverage1
        '
        Me.lblDisplayAverage1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDisplayAverage1.BackColor = System.Drawing.SystemColors.Control
        Me.lblDisplayAverage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayAverage1.CausesValidation = False
        Me.lblDisplayAverage1.Location = New System.Drawing.Point(15, 301)
        Me.lblDisplayAverage1.Name = "lblDisplayAverage1"
        Me.lblDisplayAverage1.Size = New System.Drawing.Size(159, 31)
        Me.lblDisplayAverage1.TabIndex = 9
        Me.lblDisplayAverage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblDisplayAverage1, "Displays calculated average for Employee 1")
        '
        'lblDisplayAverage2
        '
        Me.lblDisplayAverage2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDisplayAverage2.BackColor = System.Drawing.SystemColors.Control
        Me.lblDisplayAverage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayAverage2.CausesValidation = False
        Me.lblDisplayAverage2.Location = New System.Drawing.Point(186, 301)
        Me.lblDisplayAverage2.Name = "lblDisplayAverage2"
        Me.lblDisplayAverage2.Size = New System.Drawing.Size(159, 31)
        Me.lblDisplayAverage2.TabIndex = 10
        Me.lblDisplayAverage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblDisplayAverage2, "Displays calculated average for Employee 2")
        '
        'lblDisplayAverage3
        '
        Me.lblDisplayAverage3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDisplayAverage3.BackColor = System.Drawing.SystemColors.Control
        Me.lblDisplayAverage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayAverage3.CausesValidation = False
        Me.lblDisplayAverage3.Location = New System.Drawing.Point(358, 301)
        Me.lblDisplayAverage3.Name = "lblDisplayAverage3"
        Me.lblDisplayAverage3.Size = New System.Drawing.Size(159, 29)
        Me.lblDisplayAverage3.TabIndex = 11
        Me.lblDisplayAverage3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblDisplayAverage3, "Displays calculated average for Employee 3")
        '
        'lblDisplayCompanyAverage
        '
        Me.lblDisplayCompanyAverage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDisplayCompanyAverage.BackColor = System.Drawing.SystemColors.Control
        Me.lblDisplayCompanyAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayCompanyAverage.CausesValidation = False
        Me.lblDisplayCompanyAverage.Location = New System.Drawing.Point(15, 348)
        Me.lblDisplayCompanyAverage.Name = "lblDisplayCompanyAverage"
        Me.lblDisplayCompanyAverage.Size = New System.Drawing.Size(502, 37)
        Me.lblDisplayCompanyAverage.TabIndex = 12
        Me.lblDisplayCompanyAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblDisplayCompanyAverage, "Displays calculated company average")
        '
        'btnEnter
        '
        Me.btnEnter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEnter.Location = New System.Drawing.Point(15, 409)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(159, 33)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.btnEnter, "Click to Enter a value")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(186, 409)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(159, 33)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.btnReset, "Click to Reset the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.Location = New System.Drawing.Point(358, 409)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(159, 33)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.btnExit, "Click to Exit the Form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAverageUnitsShippedByEmployee
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(532, 474)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblDisplayCompanyAverage)
        Me.Controls.Add(Me.lblDisplayAverage3)
        Me.Controls.Add(Me.lblDisplayAverage2)
        Me.Controls.Add(Me.lblDisplayAverage1)
        Me.Controls.Add(Me.txtDisplayUnits3)
        Me.Controls.Add(Me.txtDisplayUnits2)
        Me.Controls.Add(Me.txtDisplayUnits1)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblDays)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(550, 521)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(550, 521)
        Me.Name = "frmAverageUnitsShippedByEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDays As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents txtDisplayUnits1 As TextBox
    Friend WithEvents txtDisplayUnits2 As TextBox
    Friend WithEvents txtDisplayUnits3 As TextBox
    Friend WithEvents lblDisplayAverage1 As Label
    Friend WithEvents lblDisplayAverage2 As Label
    Friend WithEvents lblDisplayAverage3 As Label
    Friend WithEvents lblDisplayCompanyAverage As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents AverageUnitsShippedByEmployeeTips As ToolTip
End Class
