<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.txtPetName = New System.Windows.Forms.TextBox()
        Me.txtSmsApiKey = New System.Windows.Forms.TextBox()
        Me.checkSmsEnable = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSMSfrom = New System.Windows.Forms.TextBox()
        Me.txtSMSto = New System.Windows.Forms.TextBox()
        Me.txtSMSmsg = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbCOMport = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAply = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPetName
        '
        Me.txtPetName.Location = New System.Drawing.Point(138, 16)
        Me.txtPetName.Name = "txtPetName"
        Me.txtPetName.Size = New System.Drawing.Size(167, 20)
        Me.txtPetName.TabIndex = 0
        '
        'txtSmsApiKey
        '
        Me.txtSmsApiKey.Location = New System.Drawing.Point(138, 125)
        Me.txtSmsApiKey.Name = "txtSmsApiKey"
        Me.txtSmsApiKey.Size = New System.Drawing.Size(170, 20)
        Me.txtSmsApiKey.TabIndex = 1
        '
        'checkSmsEnable
        '
        Me.checkSmsEnable.AutoSize = True
        Me.checkSmsEnable.Location = New System.Drawing.Point(16, 108)
        Me.checkSmsEnable.Name = "checkSmsEnable"
        Me.checkSmsEnable.Size = New System.Drawing.Size(171, 17)
        Me.checkSmsEnable.TabIndex = 2
        Me.checkSmsEnable.Text = "Включить СМС уведомления"
        Me.checkSmsEnable.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Имя питомца"
        '
        'txtSMSfrom
        '
        Me.txtSMSfrom.Location = New System.Drawing.Point(138, 155)
        Me.txtSMSfrom.Name = "txtSMSfrom"
        Me.txtSMSfrom.Size = New System.Drawing.Size(169, 20)
        Me.txtSMSfrom.TabIndex = 4
        '
        'txtSMSto
        '
        Me.txtSMSto.Location = New System.Drawing.Point(138, 177)
        Me.txtSMSto.Name = "txtSMSto"
        Me.txtSMSto.Size = New System.Drawing.Size(170, 20)
        Me.txtSMSto.TabIndex = 5
        '
        'txtSMSmsg
        '
        Me.txtSMSmsg.Location = New System.Drawing.Point(13, 220)
        Me.txtSMSmsg.Name = "txtSMSmsg"
        Me.txtSMSmsg.Size = New System.Drawing.Size(294, 20)
        Me.txtSMSmsg.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "API ключ SMS.ru"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Имя отправителя СМС"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Получатель СМС"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(295, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Текст СМС ( {PET_NAME} - заменяется на имя питомца)"
        '
        'cmbCOMport
        '
        Me.cmbCOMport.FormattingEnabled = True
        Me.cmbCOMport.Location = New System.Drawing.Point(138, 60)
        Me.cmbCOMport.Name = "cmbCOMport"
        Me.cmbCOMport.Size = New System.Drawing.Size(164, 21)
        Me.cmbCOMport.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "COM порт устройства"
        '
        'btnAply
        '
        Me.btnAply.Location = New System.Drawing.Point(150, 246)
        Me.btnAply.Name = "btnAply"
        Me.btnAply.Size = New System.Drawing.Size(156, 33)
        Me.btnAply.TabIndex = 13
        Me.btnAply.Text = "Применить"
        Me.btnAply.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(15, 246)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(129, 33)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Отмена"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 288)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAply)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbCOMport)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSMSmsg)
        Me.Controls.Add(Me.txtSMSto)
        Me.Controls.Add(Me.txtSMSfrom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.checkSmsEnable)
        Me.Controls.Add(Me.txtSmsApiKey)
        Me.Controls.Add(Me.txtPetName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSettings"
        Me.Text = "Setting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPetName As System.Windows.Forms.TextBox
    Friend WithEvents txtSmsApiKey As System.Windows.Forms.TextBox
    Friend WithEvents checkSmsEnable As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSMSfrom As System.Windows.Forms.TextBox
    Friend WithEvents txtSMSto As System.Windows.Forms.TextBox
    Friend WithEvents txtSMSmsg As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbCOMport As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnAply As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
