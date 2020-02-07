<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GateAttendance
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
        Me.lblPortName = New System.Windows.Forms.Label()
        Me.lblrfidno = New System.Windows.Forms.Label()
        Me.lblLoginStatus = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblSMSStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPortName
        '
        Me.lblPortName.AutoSize = True
        Me.lblPortName.Location = New System.Drawing.Point(10, 158)
        Me.lblPortName.Name = "lblPortName"
        Me.lblPortName.Size = New System.Drawing.Size(54, 13)
        Me.lblPortName.TabIndex = 21
        Me.lblPortName.Text = "PortName"
        Me.lblPortName.Visible = False
        '
        'lblrfidno
        '
        Me.lblrfidno.AutoSize = True
        Me.lblrfidno.Location = New System.Drawing.Point(10, 126)
        Me.lblrfidno.Name = "lblrfidno"
        Me.lblrfidno.Size = New System.Drawing.Size(38, 13)
        Me.lblrfidno.TabIndex = 20
        Me.lblrfidno.Text = "Rfidno"
        Me.lblrfidno.Visible = False
        '
        'lblLoginStatus
        '
        Me.lblLoginStatus.Font = New System.Drawing.Font("Castellar", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginStatus.Location = New System.Drawing.Point(2, 660)
        Me.lblLoginStatus.Name = "lblLoginStatus"
        Me.lblLoginStatus.Size = New System.Drawing.Size(1290, 63)
        Me.lblLoginStatus.TabIndex = 19
        Me.lblLoginStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSMSStatus
        '
        Me.lblSMSStatus.AutoSize = True
        Me.lblSMSStatus.Location = New System.Drawing.Point(13, 735)
        Me.lblSMSStatus.Name = "lblSMSStatus"
        Me.lblSMSStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblSMSStatus.TabIndex = 23
        '
        'GateAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 710)
        Me.Controls.Add(Me.lblPortName)
        Me.Controls.Add(Me.lblrfidno)
        Me.Controls.Add(Me.lblLoginStatus)
        Me.Controls.Add(Me.lblSMSStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GateAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GateAttendance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPortName As Label
    Friend WithEvents lblrfidno As Label
    Friend WithEvents lblLoginStatus As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblSMSStatus As Label
End Class
