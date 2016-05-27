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

        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.CurrentDirectory & "\Days") Then
            If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory & "\Days\" & filename) = False Then
                Dim txtstarter As New IO.StreamWriter(My.Computer.FileSystem.CurrentDirectory & "\Days\" & filename, append:=True)
                txtstarter.WriteLine(filename)
                txtstarter.WriteLine("Description" & "," & "Start Time" & "," & "Stop Time" & "," & "Work Time" & "," & "Recorded?")
                txtstarter.Close()
            Else
                Exit Sub
            End If
        Else
            System.IO.Directory.CreateDirectory(My.Computer.FileSystem.CurrentDirectory & "\Days")
            datecheck()
        End If
    End Sub

    Public Sub exportsplits()
        Dim txtwriter As New IO.StreamWriter(My.Computer.FileSystem.CurrentDirectory & "\Days\" & filename, append:=True)
        txtwriter.WriteLine(lstvtimes.Items(splits).Text & "," & lstvtimes.Items(splits).SubItems(1).Text & "," & lstvtimes.Items(splits).SubItems(2).Text & "," & lstvtimes.Items(splits).SubItems(3).Text & "," & lstvtimes.Items(splits).SubItems(4).Text)
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
            If chkbxrecorded.Checked = True Then
                lstvtimes.Items(splits).SubItems.Add("Yes")
                chkbxrecorded.Checked = False
            Else
                lstvtimes.Items(splits).SubItems.Add("No")
            End If
            exportsplits()
            splits = splits + 1
            worktime = 0
            lstvtimes.Items.Add(txtdesc.Text)
            txtdesc.Clear()
            lstvtimes.Items(splits).SubItems.Add(DateAndTime.TimeOfDay)
            lstvtimes.Items(splits).EnsureVisible()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Timer_splitsDataSet.Splits' table. You can move, or remove it, as needed.
        Me.SplitsTableAdapter.Fill(Me.Timer_splitsDataSet.Splits)
        tsslblAppVersion.Text = My.Application.Info.Version.ToString()
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
            Me.Icon = My.Resources.stopwatchpaused
        Else
            tmMain.Enabled = True
            txtdesc.Enabled = True
            btnSplit.Enabled = True
            btnpause.Text = "Pause"
            Me.Icon = My.Resources.stopwatch
        End If
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start(My.Computer.FileSystem.CurrentDirectory & "\Days\" & filename)
    End Sub

    Private Sub btnAddTime_Click(sender As Object, e As EventArgs) Handles btnAddTime.Click
        worktime = worktime + 60
        Dim time = New TimeSpan(0, 0, worktime).ToString("c")
        lblwktm.Text = time
    End Sub

    Private Sub btnMinusTime_Click(sender As Object, e As EventArgs) Handles btnMinusTime.Click
        If worktime >= 60 Then
            worktime = worktime - 60
            Dim time = New TimeSpan(0, 0, worktime).ToString("c")
            lblwktm.Text = time
        Else
        End If
    End Sub

    Private Sub SplitsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SplitsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SplitsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Timer_splitsDataSet)
        MsgBox("Data Saved")

    End Sub

    Private Sub SplitsBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles SplitsBindingNavigator.RefreshItems

    End Sub
End Class
