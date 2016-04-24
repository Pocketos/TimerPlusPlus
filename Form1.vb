Public Class frmMain

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

        filename = currentday & "-" & currentmonth & "-" & currentyear & ".txt"

    End Sub

    Public Sub exportsplits()
        Dim txtwriter As New IO.StreamWriter(txtexportdest.Text & filename, append:=True)
        txtwriter.WriteLine("Start Time" & "   " & "Stop Time" & "   " & "Work Time")
        For Each ListItem As ListViewItem In lstvtimes.Items
            txtwriter.WriteLine(ListItem.Text & "   " & ListItem.SubItems(1).Text & "   " & ListItem.SubItems(2).Text)
        Next
        txtwriter.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datecheck()
    End Sub

    Private Sub tmMain_Tick(sender As Object, e As EventArgs) Handles tmMain.Tick
        lbltimertext.Text = DateAndTime.Now
        worktime = worktime + 1
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        btnSplit.Enabled = True
        btnpause.Enabled = True
        BtnExport.Enabled = True
        tmMain.Enabled = True
        lstvtimes.Items.Add(DateAndTime.TimeOfDay)
    End Sub

    Private Sub btnpause_Click(sender As Object, e As EventArgs) Handles btnpause.Click
        If tmMain.Enabled = True Then
            tmMain.Enabled = False
            lbltimertext.Text = "PAUSED"
        Else
            tmMain.Enabled = True
        End If
    End Sub

    Private Sub lbltimertext_Click(sender As Object, e As EventArgs) Handles lbltimertext.Click

    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click
        Dim txtwriter As New IO.StreamWriter(txtexportdest.Text)
        lstvtimes.Items(splits).SubItems.Add(0)
        lstvtimes.Items(splits).SubItems.Add(0)
        For Each ListItem As ListViewItem In lstvtimes.Items
            txtwriter.WriteLine(ListItem.Text & "   " & ListItem.SubItems(1).Text & "   " & ListItem.SubItems(2).Text)
        Next
        txtwriter.Close()
        MsgBox("Complete")
    End Sub

    Private Sub btnSplit_Click(sender As Object, e As EventArgs) Handles btnSplit.Click
        lstvtimes.Items(splits).SubItems.Add(DateAndTime.TimeOfDay)
        Dim time = New TimeSpan(0, 0, worktime).ToString("c")
        lstvtimes.Items(splits).SubItems.Add(time)
        exportsplits()
        splits = splits + 1
        worktime = 0
        lstvtimes.Items.Add(DateAndTime.TimeOfDay)
    End Sub
End Class
