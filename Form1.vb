Public Class frmMain

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short

    Public splits As Integer = 0
    Public worktime As Integer = 0
    Public filename As String

    Public Sub datecheck()
        Dim currentdate As Date = Today
        Dim currentmonth As String
        Dim currentday As String
        Dim currentyear As String
        currentmonth = Month(currentdate)
        currentday = DateAndTime.Day(currentdate)
        currentyear = Year(currentdate)

        filename = currentday & "-" & currentmonth & "-" & currentyear & ".csv"

        Dim txtstarter As New IO.StreamWriter(txtexportdest.Text & filename, append:=True)
        txtstarter.WriteLine(filename)
        txtstarter.WriteLine("Description" & "," & "Start Time" & "," & "Stop Time" & "," & "Work Time")
        txtstarter.Close()

    End Sub

    Public Sub exportsplits()
        Dim txtwriter As New IO.StreamWriter(txtexportdest.Text & filename, append:=True)
        txtwriter.WriteLine(txtdesc.Text & "," & lstvtimes.Items(splits).SubItems(1).Text & "," & lstvtimes.Items(splits).SubItems(2).Text & "," & lstvtimes.Items(splits).SubItems(3).Text)
        txtwriter.Close()
    End Sub

    Public Sub Split()
        If tmMain.Enabled = False Then
            lstvtimes.Items.Add(txtdesc.Text)
            txtdesc.Clear()
            lstvtimes.Items(splits).SubItems.Add(DateAndTime.TimeOfDay)
            tmMain.Enabled = True
            btnpause.Enabled = True
        Else
            lstvtimes.Items(splits).SubItems.Add(DateAndTime.TimeOfDay)
            Dim time = New TimeSpan(0, 0, worktime).ToString("c")
            lstvtimes.Items(splits).SubItems.Add(time)
            exportsplits()
            splits = splits + 1
            worktime = 0
            lstvtimes.Items.Add(txtdesc.Text)
            txtdesc.Clear()
            lstvtimes.Items(splits).SubItems.Add(DateAndTime.TimeOfDay)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datecheck()
    End Sub

    Private Sub tmMain_Tick(sender As Object, e As EventArgs) Handles tmMain.Tick
        lbltimertext.Text = DateAndTime.Now
        worktime = worktime + 1
        Dim time = New TimeSpan(0, 0, worktime).ToString("c")
        lblwktm.Text = time
    End Sub

    Private Sub btnpause_Click(sender As Object, e As EventArgs) Handles btnpause.Click
        If tmMain.Enabled = True Then
            tmMain.Enabled = False
            lbltimertext.Text = "PAUSED"
            btnpause.Text = "Resume"
            txtdesc.Enabled = False
            btnSplit.Enabled = False
        Else
            tmMain.Enabled = True
            txtdesc.Enabled = True
            btnSplit.Enabled = True
            btnpause.Text = "Pause"
        End If
    End Sub

    Private Sub lbltimertext_Click(sender As Object, e As EventArgs) Handles lbltimertext.Click

    End Sub

    Private Sub btnSplit_Click(sender As Object, e As EventArgs) Handles btnSplit.Click
        Split()
    End Sub

    Private Sub txtdesc_KeyDown(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdesc.KeyDown
        If e.KeyValue = Keys.Enter Then
            e.SuppressKeyPress = True
            Split()
        Else
        End If
    End Sub

    Private Function IsNumeric(keyChar As Object) As Boolean
        Throw New NotImplementedException()
    End Function
End Class
