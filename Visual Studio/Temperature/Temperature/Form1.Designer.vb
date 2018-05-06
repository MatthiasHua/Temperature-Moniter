<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.refresh = New System.Windows.Forms.Button()
        Me.start = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.interval = New System.Windows.Forms.TextBox()
        Me.com = New System.Windows.Forms.ComboBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.status = New System.Windows.Forms.Label()
        Me.Chart = New System.Windows.Forms.Panel()
        Me.temperature = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'refresh
        '
        Me.refresh.Location = New System.Drawing.Point(1394, 532)
        Me.refresh.Name = "refresh"
        Me.refresh.Size = New System.Drawing.Size(129, 50)
        Me.refresh.TabIndex = 0
        Me.refresh.Text = "刷新端口"
        Me.refresh.UseVisualStyleBackColor = True
        '
        'start
        '
        Me.start.Enabled = False
        Me.start.Location = New System.Drawing.Point(1240, 532)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(133, 50)
        Me.start.TabIndex = 1
        Me.start.Text = "开始监控"
        Me.start.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'interval
        '
        Me.interval.Font = New System.Drawing.Font("宋体", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.interval.Location = New System.Drawing.Point(1380, 346)
        Me.interval.Name = "interval"
        Me.interval.Size = New System.Drawing.Size(121, 50)
        Me.interval.TabIndex = 4
        Me.interval.Text = "1000"
        Me.interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'com
        '
        Me.com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.com.Font = New System.Drawing.Font("宋体", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.com.FormattingEnabled = True
        Me.com.Location = New System.Drawing.Point(1380, 430)
        Me.com.Name = "com"
        Me.com.Size = New System.Drawing.Size(121, 45)
        Me.com.TabIndex = 0
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.ForeColor = System.Drawing.Color.Red
        Me.status.Location = New System.Drawing.Point(86, 650)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(82, 24)
        Me.status.TabIndex = 5
        Me.status.Text = "未连接"
        '
        'Chart
        '
        Me.Chart.BackColor = System.Drawing.Color.White
        Me.Chart.Location = New System.Drawing.Point(79, 102)
        Me.Chart.Name = "Chart"
        Me.Chart.Size = New System.Drawing.Size(1138, 515)
        Me.Chart.TabIndex = 2
        '
        'temperature
        '
        Me.temperature.AutoSize = True
        Me.temperature.Font = New System.Drawing.Font("宋体", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.temperature.Location = New System.Drawing.Point(1258, 236)
        Me.temperature.Name = "temperature"
        Me.temperature.Size = New System.Drawing.Size(41, 43)
        Me.temperature.TabIndex = 3
        Me.temperature.Text = "-"
        Me.temperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(1372, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 43)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "℃"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(1243, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 43)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "当前温度"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 43)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "温度监控"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(1234, 353)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(335, 33)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "采样间隔          ms"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(1245, 437)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 33)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "端口:"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1616, 697)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.com)
        Me.Controls.Add(Me.interval)
        Me.Controls.Add(Me.temperature)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.refresh)
        Me.Controls.Add(Me.Chart)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Main"
        Me.Text = "温度监控"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents refresh As Button
    Friend WithEvents start As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents interval As TextBox
    Friend WithEvents com As ComboBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents status As Label
    Friend WithEvents Chart As Panel
    Friend WithEvents temperature As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
