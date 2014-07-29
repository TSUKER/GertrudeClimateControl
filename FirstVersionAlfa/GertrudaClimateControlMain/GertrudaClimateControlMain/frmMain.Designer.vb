<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnSetting = New System.Windows.Forms.Button()
        Me.btnStartStop = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.lblNowTmpC = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNT = New System.Windows.Forms.Label()
        Me.lblNH = New System.Windows.Forms.Label()
        Me.srlCOMPORT = New System.IO.Ports.SerialPort(Me.components)
        Me.tmrIntCheck = New System.Windows.Forms.Timer(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSetting
        '
        Me.btnSetting.Location = New System.Drawing.Point(1, 33)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(115, 26)
        Me.btnSetting.TabIndex = 0
        Me.btnSetting.Text = "настройки"
        Me.btnSetting.UseVisualStyleBackColor = True
        '
        'btnStartStop
        '
        Me.btnStartStop.Location = New System.Drawing.Point(1, 3)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(115, 30)
        Me.btnStartStop.TabIndex = 1
        Me.btnStartStop.Text = "начать слежение"
        Me.btnStartStop.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(1, 59)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(115, 21)
        Me.btnAbout.TabIndex = 2
        Me.btnAbout.Text = "О программе"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'lblNowTmpC
        '
        Me.lblNowTmpC.AutoSize = True
        Me.lblNowTmpC.Location = New System.Drawing.Point(164, 9)
        Me.lblNowTmpC.Name = "lblNowTmpC"
        Me.lblNowTmpC.Size = New System.Drawing.Size(84, 13)
        Me.lblNowTmpC.TabIndex = 3
        Me.lblNowTmpC.Text = "Температура С"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Влажность"
        '
        'lblNT
        '
        Me.lblNT.AutoSize = True
        Me.lblNT.Location = New System.Drawing.Point(282, 9)
        Me.lblNT.Name = "lblNT"
        Me.lblNT.Size = New System.Drawing.Size(13, 13)
        Me.lblNT.TabIndex = 5
        Me.lblNT.Text = "0"
        '
        'lblNH
        '
        Me.lblNH.AutoSize = True
        Me.lblNH.Location = New System.Drawing.Point(282, 26)
        Me.lblNH.Name = "lblNH"
        Me.lblNH.Size = New System.Drawing.Size(21, 13)
        Me.lblNH.TabIndex = 6
        Me.lblNH.Text = "0%"
        '
        'srlCOMPORT
        '
        Me.srlCOMPORT.PortName = "COM55"
        Me.srlCOMPORT.ReadTimeout = 5000
        '
        'tmrIntCheck
        '
        Me.tmrIntCheck.Interval = 10000
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1, 81)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 19)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Выход"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnStartStop
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(329, 103)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblNH)
        Me.Controls.Add(Me.lblNT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNowTmpC)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnStartStop)
        Me.Controls.Add(Me.btnSetting)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Main Window"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSetting As System.Windows.Forms.Button
    Friend WithEvents btnStartStop As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents lblNowTmpC As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNT As System.Windows.Forms.Label
    Friend WithEvents lblNH As System.Windows.Forms.Label
    Friend WithEvents srlCOMPORT As System.IO.Ports.SerialPort
    Friend WithEvents tmrIntCheck As System.Windows.Forms.Timer
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
