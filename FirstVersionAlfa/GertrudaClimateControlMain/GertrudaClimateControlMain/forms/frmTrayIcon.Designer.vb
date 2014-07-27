<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrayIcon
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
        Me.iconTrayMainIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.mainTrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShowMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mainTrayMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'iconTrayMainIcon
        '
        Me.iconTrayMainIcon.BalloonTipText = "Climate Control is started"
        Me.iconTrayMainIcon.BalloonTipTitle = "Gertruda Climate"
        Me.iconTrayMainIcon.ContextMenuStrip = Me.mainTrayMenu
        Me.iconTrayMainIcon.Text = "GCC"
        Me.iconTrayMainIcon.Visible = True
        '
        'mainTrayMenu
        '
        Me.mainTrayMenu.BackColor = System.Drawing.Color.Gray
        Me.mainTrayMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.mainTrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShowMain, Me.mnuSettings, Me.mnuAbout})
        Me.mainTrayMenu.Name = "mainTrayMenu"
        Me.mainTrayMenu.Size = New System.Drawing.Size(134, 70)
        '
        'mnuSettings
        '
        Me.mnuSettings.Name = "mnuSettings"
        Me.mnuSettings.Size = New System.Drawing.Size(133, 22)
        Me.mnuSettings.Text = "Settings"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(133, 22)
        Me.mnuAbout.Text = "About"
        '
        'mnuShowMain
        '
        Me.mnuShowMain.Name = "mnuShowMain"
        Me.mnuShowMain.Size = New System.Drawing.Size(133, 22)
        Me.mnuShowMain.Text = "Show Main"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Please wait..."
        '
        'frmTrayIcon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(153, 80)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTrayIcon"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTrayIcon"
        Me.mainTrayMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents iconTrayMainIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents mainTrayMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuShowMain As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
