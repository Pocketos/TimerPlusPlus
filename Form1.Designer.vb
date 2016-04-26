<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lbltimertext = New System.Windows.Forms.Label()
        Me.tmMain = New System.Windows.Forms.Timer(Me.components)
        Me.btnpause = New System.Windows.Forms.Button()
        Me.lstvtimes = New System.Windows.Forms.ListView()
        Me.chdesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chStartTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chStopTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chworktime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRecorded = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSplit = New System.Windows.Forms.Button()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lblwktm = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.statustripbottom = New System.Windows.Forms.StatusStrip()
        Me.tsslblversion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.chkbxrecorded = New System.Windows.Forms.CheckBox()
        Me.statustripbottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltimertext
        '
        Me.lbltimertext.AutoSize = True
        Me.lbltimertext.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltimertext.Location = New System.Drawing.Point(7, 9)
        Me.lbltimertext.Name = "lbltimertext"
        Me.lbltimertext.Size = New System.Drawing.Size(119, 30)
        Me.lbltimertext.TabIndex = 0
        Me.lbltimertext.Text = "Not Started"
        '
        'tmMain
        '
        Me.tmMain.Interval = 1000
        '
        'btnpause
        '
        Me.btnpause.Enabled = False
        Me.btnpause.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpause.Location = New System.Drawing.Point(559, 79)
        Me.btnpause.Name = "btnpause"
        Me.btnpause.Size = New System.Drawing.Size(188, 63)
        Me.btnpause.TabIndex = 2
        Me.btnpause.Text = "Pause"
        Me.btnpause.UseVisualStyleBackColor = True
        '
        'lstvtimes
        '
        Me.lstvtimes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chdesc, Me.chStartTime, Me.chStopTime, Me.chworktime, Me.chRecorded})
        Me.lstvtimes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvtimes.LabelEdit = True
        Me.lstvtimes.LabelWrap = False
        Me.lstvtimes.Location = New System.Drawing.Point(12, 70)
        Me.lstvtimes.Name = "lstvtimes"
        Me.lstvtimes.Size = New System.Drawing.Size(536, 148)
        Me.lstvtimes.TabIndex = 4
        Me.lstvtimes.UseCompatibleStateImageBehavior = False
        Me.lstvtimes.View = System.Windows.Forms.View.Details
        '
        'chdesc
        '
        Me.chdesc.Text = "Decription"
        Me.chdesc.Width = 180
        '
        'chStartTime
        '
        Me.chStartTime.Text = "Start time"
        Me.chStartTime.Width = 90
        '
        'chStopTime
        '
        Me.chStopTime.Text = "Stop Time"
        Me.chStopTime.Width = 87
        '
        'chworktime
        '
        Me.chworktime.Text = "Time worked"
        Me.chworktime.Width = 111
        '
        'chRecorded
        '
        Me.chRecorded.Text = "Recorded"
        Me.chRecorded.Width = 61
        '
        'btnSplit
        '
        Me.btnSplit.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSplit.Location = New System.Drawing.Point(559, 12)
        Me.btnSplit.Name = "btnSplit"
        Me.btnSplit.Size = New System.Drawing.Size(188, 61)
        Me.btnSplit.TabIndex = 7
        Me.btnSplit.Text = "Split"
        Me.btnSplit.UseVisualStyleBackColor = True
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(12, 43)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(536, 20)
        Me.txtdesc.TabIndex = 8
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(557, 145)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(63, 30)
        Me.lbltime.TabIndex = 9
        Me.lbltime.Text = "Time:"
        '
        'lblwktm
        '
        Me.lblwktm.AutoSize = True
        Me.lblwktm.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwktm.Location = New System.Drawing.Point(623, 145)
        Me.lblwktm.Name = "lblwktm"
        Me.lblwktm.Size = New System.Drawing.Size(64, 30)
        Me.lblwktm.TabIndex = 10
        Me.lblwktm.Text = "None"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(559, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 38)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Review Splits"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'statustripbottom
        '
        Me.statustripbottom.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslblversion})
        Me.statustripbottom.Location = New System.Drawing.Point(0, 238)
        Me.statustripbottom.Name = "statustripbottom"
        Me.statustripbottom.Size = New System.Drawing.Size(759, 22)
        Me.statustripbottom.TabIndex = 12
        Me.statustripbottom.Text = "StatusStrip1"
        '
        'tsslblversion
        '
        Me.tsslblversion.Name = "tsslblversion"
        Me.tsslblversion.Size = New System.Drawing.Size(143, 17)
        Me.tsslblversion.Text = "Timer ++          Version 1.3"
        '
        'chkbxrecorded
        '
        Me.chkbxrecorded.AutoSize = True
        Me.chkbxrecorded.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbxrecorded.Location = New System.Drawing.Point(326, 12)
        Me.chkbxrecorded.Name = "chkbxrecorded"
        Me.chkbxrecorded.Size = New System.Drawing.Size(227, 29)
        Me.chkbxrecorded.TabIndex = 13
        Me.chkbxrecorded.Text = "Mark split as recorded?"
        Me.chkbxrecorded.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 260)
        Me.Controls.Add(Me.chkbxrecorded)
        Me.Controls.Add(Me.statustripbottom)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblwktm)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.btnSplit)
        Me.Controls.Add(Me.lstvtimes)
        Me.Controls.Add(Me.btnpause)
        Me.Controls.Add(Me.lbltimertext)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(775, 300)
        Me.MinimumSize = New System.Drawing.Size(775, 300)
        Me.Name = "frmMain"
        Me.Text = "Timer++"
        Me.statustripbottom.ResumeLayout(False)
        Me.statustripbottom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltimertext As Label
    Friend WithEvents tmMain As Timer
    Friend WithEvents btnpause As Button
    Friend WithEvents lstvtimes As ListView
    Friend WithEvents chStartTime As ColumnHeader
    Friend WithEvents chStopTime As ColumnHeader
    Friend WithEvents chworktime As ColumnHeader
    Friend WithEvents btnSplit As Button
    Friend WithEvents chdesc As ColumnHeader
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents lbltime As Label
    Friend WithEvents lblwktm As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents statustripbottom As StatusStrip
    Friend WithEvents tsslblversion As ToolStripStatusLabel
    Friend WithEvents chRecorded As ColumnHeader
    Friend WithEvents chkbxrecorded As CheckBox
End Class
