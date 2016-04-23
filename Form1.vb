Public Class frmMain

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstvtimes.Items.Add("Start Time")
        lstvtimes.Items(0).SubItems.Add(DateAndTime.TimeOfDay)
        lstvtimes.Items(0).SubItems.Add(DateAndTime.TimeOfDay)
    End Sub

    Private Sub tmMain_Tick(sender As Object, e As EventArgs) Handles tmMain.Tick
        lbltimertext.Text = DateAndTime.Now
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        tmMain.Enabled = True
    End Sub

    Private Sub btnpause_Click(sender As Object, e As EventArgs) Handles btnpause.Click
        tmMain.Enabled = False
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        lbltimertext.Text = DateAndTime.Now
        tmMain.Enabled = False
    End Sub

    Private Sub lbltimertext_Click(sender As Object, e As EventArgs) Handles lbltimertext.Click

    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click
        IO.File.WriteAllLines(txtexportdest.Text, lstvtimes)
        MsgBox("Complete")
    End Sub
End Class
