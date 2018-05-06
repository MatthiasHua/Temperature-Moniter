Imports System.Drawing

Public Class Main

    Public num As Integer = 50 '同屏实时显示的数量
    Public data(num) As Double '存放显示的数据/循环数组
    Public index As Integer = 0 '循环数组的首个元素
    Public max As Integer = 40 '最大数值
    Public min As Integer = 0 '最小数值
    Public run As Integer = 0 '运行状态


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load '初始化窗口大小，载入端口列表
        Me.Width = 800
        Me.Height = 400
        refreshCOM()
    End Sub

    Private Sub refreshCOM() Handles refresh.Click '刷新端口列表
        com.Items.Clear()
        com.Text = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            com.Items.Add(sp)
        Next
        If com.Items.Count > 0 Then
            com.SelectedIndex = 0
        Else
            status.Text = "未连接"
            status.ForeColor = Color.Red
        End If
    End Sub

    Private Sub setTemperature() '读取一个温度并写入数据表中
        index = (index + 1) Mod 50
        data(index) = getTemperature()
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles start.Click '开始按钮
        If run = 0 Then
            run = 1
            Timer1.Interval = interval.Text
            Timer1.Enabled = True
            interval.Enabled = False
            refresh.Enabled = False
            com.Enabled = False
            start.Text = "暂停"
        Else
            run = 0
            Timer1.Enabled = False
            interval.Enabled = True
            refresh.Enabled = True
            com.Enabled = True
            start.Text = "开始"
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick '定时更新温度数据和图表
        'Dim MyGraphics As Graphics = Me.Panel1.CreateGraphics()
        'Me.DoubleBuffered = True
        Dim bmp As Bitmap = New Bitmap(Chart.Width, Chart.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)

        Chart.Refresh()
        setTemperature()
        temperature.Text = data(index)

        Dim MyPen As New Pen(Color.Black)
        For i = 1 To 49
            g.DrawLine(MyPen, calX(i), calY(i), calX(i + 1), calY(i + 1))
        Next
        Chart.CreateGraphics().DrawImage(bmp, 0, 0)
    End Sub

    Private Function calX(i As Integer) '计算x坐标
        Return Chart.Width * (i - 1) \ (num - 1)
    End Function

    Private Function calY(i As Integer) '计算y坐标
        Return (max - data((i + index) Mod num)) * Chart.Height \ (max - min)
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles com.SelectedIndexChanged '端口连接
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If

        With SerialPort1
            .PortName = com.Text
            .BaudRate = 9600

            .Parity = IO.Ports.Parity.None '奇偶校验
            .DataBits = 8 '数据位
            .StopBits = IO.Ports.StopBits.One '停止位
        End With
        SerialPort1.Open() '打开串口
        status.Text = "已连接"
        status.ForeColor = Color.Green
        start.Enabled = True
    End Sub

    Public Function getTemperature() As Double '读取温度
        If SerialPort1.IsOpen Then
            SerialPort1.Write(" ") '发送读取温度请求
            Dim temperature As Double
            Dim byteToRead As Int16 = SerialPort1.BytesToRead '读取缓冲区的字节长度
            Dim ch(byteToRead) As Byte
            SerialPort1.Read(ch, 0, byteToRead) '接收数据
            If ch.Length >= 2 Then
                temperature = (ch(0) * 255 + ch(1)) / 10 '计算温度
                System.Console.WriteLine(temperature)
                Return temperature
            End If
            Return 0
        End If
        Return -1
    End Function
End Class
