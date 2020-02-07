<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits MetroFramework.Forms.MetroForm

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
        Me.MetroPanel = New MetroFramework.Controls.MetroPanel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblLogout = New System.Windows.Forms.Label()
        Me.btnUserAccount = New System.Windows.Forms.Button()
        Me.btnSmsSetting = New System.Windows.Forms.Button()
        Me.btnAnnouncement = New System.Windows.Forms.Button()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.btnSection = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.MetroPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel
        '
        Me.MetroPanel.AllowDrop = True
        Me.MetroPanel.BackColor = System.Drawing.Color.White
        Me.MetroPanel.Controls.Add(Me.lblDate)
        Me.MetroPanel.Controls.Add(Me.lblTime)
        Me.MetroPanel.Controls.Add(Me.Button1)
        Me.MetroPanel.Controls.Add(Me.lblLogout)
        Me.MetroPanel.Controls.Add(Me.btnUserAccount)
        Me.MetroPanel.Controls.Add(Me.btnSmsSetting)
        Me.MetroPanel.Controls.Add(Me.btnAnnouncement)
        Me.MetroPanel.Controls.Add(Me.btnRecord)
        Me.MetroPanel.Controls.Add(Me.btnSection)
        Me.MetroPanel.Controls.Add(Me.btnDashboard)
        Me.MetroPanel.Controls.Add(Me.btnStudent)
        Me.MetroPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MetroPanel.HorizontalScrollbarBarColor = True
        Me.MetroPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel.HorizontalScrollbarSize = 10
        Me.MetroPanel.Location = New System.Drawing.Point(20, 60)
        Me.MetroPanel.Name = "MetroPanel"
        Me.MetroPanel.Size = New System.Drawing.Size(219, 670)
        Me.MetroPanel.TabIndex = 0
        Me.MetroPanel.UseCustomBackColor = True
        Me.MetroPanel.UseCustomForeColor = True
        Me.MetroPanel.UseStyleColors = True
        Me.MetroPanel.VerticalScrollbarBarColor = True
        Me.MetroPanel.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel.VerticalScrollbarSize = 10
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.White
        Me.lblDate.Font = New System.Drawing.Font("Bahnschrift", 8.25!)
        Me.lblDate.ForeColor = System.Drawing.Color.Black
        Me.lblDate.Location = New System.Drawing.Point(3, 13)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 9
        Me.lblDate.Text = "Date"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.White
        Me.lblTime.Font = New System.Drawing.Font("Bahnschrift", 8.25!)
        Me.lblTime.ForeColor = System.Drawing.Color.Black
        Me.lblTime.Location = New System.Drawing.Point(3, 26)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(30, 13)
        Me.lblTime.TabIndex = 10
        Me.lblTime.Text = "Time"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(6, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(198, 28)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Manage Teacher"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblLogout
        '
        Me.lblLogout.AutoSize = True
        Me.lblLogout.BackColor = System.Drawing.Color.White
        Me.lblLogout.Font = New System.Drawing.Font("Bahnschrift", 8.25!)
        Me.lblLogout.ForeColor = System.Drawing.Color.Black
        Me.lblLogout.Location = New System.Drawing.Point(3, 486)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(41, 13)
        Me.lblLogout.TabIndex = 11
        Me.lblLogout.Text = "Logout"
        '
        'btnUserAccount
        '
        Me.btnUserAccount.BackColor = System.Drawing.Color.White
        Me.btnUserAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnUserAccount.FlatAppearance.BorderSize = 0
        Me.btnUserAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserAccount.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserAccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUserAccount.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnUserAccount.Location = New System.Drawing.Point(6, 311)
        Me.btnUserAccount.Name = "btnUserAccount"
        Me.btnUserAccount.Size = New System.Drawing.Size(198, 28)
        Me.btnUserAccount.TabIndex = 23
        Me.btnUserAccount.Text = "User Account"
        Me.btnUserAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUserAccount.UseVisualStyleBackColor = False
        '
        'btnSmsSetting
        '
        Me.btnSmsSetting.BackColor = System.Drawing.Color.White
        Me.btnSmsSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSmsSetting.FlatAppearance.BorderSize = 0
        Me.btnSmsSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSmsSetting.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSmsSetting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSmsSetting.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSmsSetting.Location = New System.Drawing.Point(6, 243)
        Me.btnSmsSetting.Name = "btnSmsSetting"
        Me.btnSmsSetting.Size = New System.Drawing.Size(198, 28)
        Me.btnSmsSetting.TabIndex = 21
        Me.btnSmsSetting.Text = "SMS Setting"
        Me.btnSmsSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSmsSetting.UseVisualStyleBackColor = False
        '
        'btnAnnouncement
        '
        Me.btnAnnouncement.BackColor = System.Drawing.Color.White
        Me.btnAnnouncement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAnnouncement.FlatAppearance.BorderSize = 0
        Me.btnAnnouncement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnouncement.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnouncement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAnnouncement.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAnnouncement.Location = New System.Drawing.Point(6, 209)
        Me.btnAnnouncement.Name = "btnAnnouncement"
        Me.btnAnnouncement.Size = New System.Drawing.Size(198, 28)
        Me.btnAnnouncement.TabIndex = 22
        Me.btnAnnouncement.Text = "Announcement"
        Me.btnAnnouncement.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAnnouncement.UseVisualStyleBackColor = False
        '
        'btnRecord
        '
        Me.btnRecord.BackColor = System.Drawing.Color.White
        Me.btnRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRecord.FlatAppearance.BorderSize = 0
        Me.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecord.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecord.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRecord.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnRecord.Location = New System.Drawing.Point(6, 277)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(198, 28)
        Me.btnRecord.TabIndex = 20
        Me.btnRecord.Text = "Record"
        Me.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRecord.UseVisualStyleBackColor = False
        '
        'btnSection
        '
        Me.btnSection.BackColor = System.Drawing.Color.White
        Me.btnSection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSection.FlatAppearance.BorderSize = 0
        Me.btnSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSection.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSection.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSection.Location = New System.Drawing.Point(6, 135)
        Me.btnSection.Name = "btnSection"
        Me.btnSection.Size = New System.Drawing.Size(198, 28)
        Me.btnSection.TabIndex = 19
        Me.btnSection.Text = "Manage Section"
        Me.btnSection.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSection.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.White
        Me.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDashboard.Location = New System.Drawing.Point(6, 63)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(198, 28)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnStudent
        '
        Me.btnStudent.BackColor = System.Drawing.Color.White
        Me.btnStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnStudent.FlatAppearance.BorderSize = 0
        Me.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudent.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnStudent.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnStudent.Location = New System.Drawing.Point(6, 99)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(198, 28)
        Me.btnStudent.TabIndex = 18
        Me.btnStudent.Text = "Manage Student"
        Me.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStudent.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'mainPanel
        '
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(239, 60)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(1041, 670)
        Me.mainPanel.TabIndex = 4
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 750)
        Me.Controls.Add(Me.mainPanel)
        Me.Controls.Add(Me.MetroPanel)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name = "MainForm"
        Me.Style = MetroFramework.MetroColorStyle.White
        Me.MetroPanel.ResumeLayout(False)
        Me.MetroPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblLogout As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnUserAccount As Button
    Friend WithEvents btnAnnouncement As Button
    Friend WithEvents btnSmsSetting As Button
    Friend WithEvents btnRecord As Button
    Friend WithEvents btnSection As Button
    Friend WithEvents mainPanel As Panel
    Friend WithEvents Button1 As Button
End Class
