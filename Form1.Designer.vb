<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lbltimertext = New System.Windows.Forms.Label()
        Me.tmMain = New System.Windows.Forms.Timer(Me.components)
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnpause = New System.Windows.Forms.Button()
        Me.lstvtimes = New System.Windows.Forms.ListView()
        Me.chStartTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chStopTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chworktime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnExport = New System.Windows.Forms.Button()
        Me.txtexportdest = New System.Windows.Forms.TextBox()
        Me.btnSplit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbltimertext
        '
        Me.lbltimertext.AutoSize = True
        Me.lbltimertext.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltimertext.Location = New System.Drawing.Point(12, 14)
        Me.lbltimertext.Name = "lbltimertext"
        Me.lbltimertext.Size = New System.Drawing.Size(153, 37)
        Me.lbltimertext.TabIndex = 0
        Me.lbltimertext.Text = "Not Started"
        '
        'tmMain
        '
        Me.tmMain.Interval = 1000
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(361, 81)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(93, 63)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnpause
        '
        Me.btnpause.Enabled = False
        Me.btnpause.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpause.Location = New System.Drawing.Point(460, 81)
        Me.btnpause.Name = "btnpause"
        Me.btnpause.Size = New System.Drawing.Size(95, 63)
        Me.btnpause.TabIndex = 2
        Me.btnpause.Text = "Pause"
        Me.btnpause.UseVisualStyleBackColor = True
        '
        'lstvtimes
        '
        Me.lstvtimes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chStartTime, Me.chStopTime, Me.chworktime})
        Me.lstvtimes.Location = New System.Drawing.Point(12, 53)
        Me.lstvtimes.Name = "lstvtimes"
        Me.lstvtimes.Size = New System.Drawing.Size(343, 156)
        Me.lstvtimes.TabIndex = 4
        Me.lstvtimes.UseCompatibleStateImageBehavior = False
        Me.lstvtimes.View = System.Windows.Forms.View.Details
        '
        'chStartTime
        '
        Me.chStartTime.Text = "Start time"
        Me.chStartTime.Width = 100
        '
        'chStopTime
        '
        Me.chStopTime.Text = "Stop Time"
        Me.chStopTime.Width = 100
        '
        'chworktime
        '
        Me.chworktime.Text = "Time worked"
        Me.chworktime.Width = 100
        '
        'BtnExport
        '
        Me.BtnExport.Enabled = False
        Me.BtnExport.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExport.Location = New System.Drawing.Point(361, 150)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(194, 33)
        Me.BtnExport.TabIndex = 5
        Me.BtnExport.Text = "Export Running Log"
        Me.BtnExport.UseVisualStyleBackColor = True
        '
        'txtexportdest
        '
        Me.txtexportdest.Location = New System.Drawing.Point(362, 189)
        Me.txtexportdest.Name = "txtexportdest"
        Me.txtexportdest.Size = New System.Drawing.Size(193, 20)
        Me.txtexportdest.TabIndex = 6
        Me.txtexportdest.Text = "C:\Users\Tyler\Documents\"
        '
        'btnSplit
        '
        Me.btnSplit.Enabled = False
        Me.btnSplit.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSplit.Location = New System.Drawing.Point(362, 14)
        Me.btnSplit.Name = "btnSplit"
        Me.btnSplit.Size = New System.Drawing.Size(193, 61)
        Me.btnSplit.TabIndex = 7
        Me.btnSplit.Text = "Split"
        Me.btnSplit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 228)
        Me.Controls.Add(Me.btnSplit)
        Me.Controls.Add(Me.txtexportdest)
        Me.Controls.Add(Me.BtnExport)
        Me.Controls.Add(Me.lstvtimes)
        Me.Controls.Add(Me.btnpause)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lbltimertext)
        Me.Name = "frmMain"
        Me.Text = "Timer++"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltimertext As Label
    Friend WithEvents tmMain As Timer
    Friend WithEvents btnStart As Button
    Friend WithEvents btnpause As Button
    Friend WithEvents lstvtimes As ListView
    Friend WithEvents chStartTime As ColumnHeader
    Friend WithEvents chStopTime As ColumnHeader
    Friend WithEvents chworktime As ColumnHeader
    Friend WithEvents BtnExport As Button
    Friend WithEvents txtexportdest As TextBox
    Friend WithEvents btnSplit As Button
End Class
