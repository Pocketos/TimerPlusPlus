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
        Me.tsslblAppName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslblAppVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.chkbxrecorded = New System.Windows.Forms.CheckBox()
        Me.btnMinusTime = New System.Windows.Forms.Button()
        Me.btnAddTime = New System.Windows.Forms.Button()
        Me.Timer_splitsDataSet = New Timer__.Timer_splitsDataSet()
        Me.SplitsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitsTableAdapter = New Timer__.Timer_splitsDataSetTableAdapters.SplitsTableAdapter()
        Me.TableAdapterManager = New Timer__.Timer_splitsDataSetTableAdapters.TableAdapterManager()
        Me.SplitsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SplitsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SplitsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.statustripbottom.SuspendLayout()
        CType(Me.Timer_splitsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitsBindingNavigator.SuspendLayout()
        CType(Me.SplitsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnpause.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpause.Location = New System.Drawing.Point(559, 66)
        Me.btnpause.Name = "btnpause"
        Me.btnpause.Size = New System.Drawing.Size(188, 48)
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
        Me.lstvtimes.Size = New System.Drawing.Size(536, 165)
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
        Me.btnSplit.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSplit.Location = New System.Drawing.Point(559, 12)
        Me.btnSplit.Name = "btnSplit"
        Me.btnSplit.Size = New System.Drawing.Size(188, 48)
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
        Me.lbltime.Location = New System.Drawing.Point(585, 141)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(63, 30)
        Me.lbltime.TabIndex = 9
        Me.lbltime.Text = "Time:"
        '
        'lblwktm
        '
        Me.lblwktm.AutoSize = True
        Me.lblwktm.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwktm.Location = New System.Drawing.Point(634, 141)
        Me.lblwktm.Name = "lblwktm"
        Me.lblwktm.Size = New System.Drawing.Size(89, 30)
        Me.lblwktm.TabIndex = 10
        Me.lblwktm.Text = "00:00:00"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(559, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 37)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Review Splits"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'statustripbottom
        '
        Me.statustripbottom.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslblAppName, Me.tsslblAppVersion})
        Me.statustripbottom.Location = New System.Drawing.Point(0, 574)
        Me.statustripbottom.Name = "statustripbottom"
        Me.statustripbottom.Size = New System.Drawing.Size(1109, 22)
        Me.statustripbottom.TabIndex = 12
        Me.statustripbottom.Text = "StatusStrip1"
        '
        'tsslblAppName
        '
        Me.tsslblAppName.Name = "tsslblAppName"
        Me.tsslblAppName.Size = New System.Drawing.Size(57, 17)
        Me.tsslblAppName.Text = "Timer ++"
        '
        'tsslblAppVersion
        '
        Me.tsslblAppVersion.Name = "tsslblAppVersion"
        Me.tsslblAppVersion.Size = New System.Drawing.Size(22, 17)
        Me.tsslblAppVersion.Text = "0.0"
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
        'btnMinusTime
        '
        Me.btnMinusTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinusTime.Location = New System.Drawing.Point(559, 120)
        Me.btnMinusTime.Name = "btnMinusTime"
        Me.btnMinusTime.Size = New System.Drawing.Size(26, 72)
        Me.btnMinusTime.TabIndex = 14
        Me.btnMinusTime.Text = "-"
        Me.btnMinusTime.UseVisualStyleBackColor = True
        '
        'btnAddTime
        '
        Me.btnAddTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTime.Location = New System.Drawing.Point(721, 120)
        Me.btnAddTime.Name = "btnAddTime"
        Me.btnAddTime.Size = New System.Drawing.Size(26, 72)
        Me.btnAddTime.TabIndex = 15
        Me.btnAddTime.Text = "+"
        Me.btnAddTime.UseVisualStyleBackColor = True
        '
        'Timer_splitsDataSet
        '
        Me.Timer_splitsDataSet.DataSetName = "Timer_splitsDataSet"
        Me.Timer_splitsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SplitsBindingSource
        '
        Me.SplitsBindingSource.DataMember = "Splits"
        Me.SplitsBindingSource.DataSource = Me.Timer_splitsDataSet
        '
        'SplitsTableAdapter
        '
        Me.SplitsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SplitsTableAdapter = Me.SplitsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Timer__.Timer_splitsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SplitsBindingNavigator
        '
        Me.SplitsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SplitsBindingNavigator.BindingSource = Me.SplitsBindingSource
        Me.SplitsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SplitsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SplitsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SplitsBindingNavigatorSaveItem})
        Me.SplitsBindingNavigator.Location = New System.Drawing.Point(0, 549)
        Me.SplitsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SplitsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SplitsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SplitsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SplitsBindingNavigator.Name = "SplitsBindingNavigator"
        Me.SplitsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SplitsBindingNavigator.Size = New System.Drawing.Size(1109, 25)
        Me.SplitsBindingNavigator.TabIndex = 16
        Me.SplitsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SplitsBindingNavigatorSaveItem
        '
        Me.SplitsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SplitsBindingNavigatorSaveItem.Image = CType(resources.GetObject("SplitsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SplitsBindingNavigatorSaveItem.Name = "SplitsBindingNavigatorSaveItem"
        Me.SplitsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SplitsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SplitsDataGridView
        '
        Me.SplitsDataGridView.AutoGenerateColumns = False
        Me.SplitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SplitsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn1})
        Me.SplitsDataGridView.DataSource = Me.SplitsBindingSource
        Me.SplitsDataGridView.Location = New System.Drawing.Point(12, 241)
        Me.SplitsDataGridView.Name = "SplitsDataGridView"
        Me.SplitsDataGridView.Size = New System.Drawing.Size(536, 220)
        Me.SplitsDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TaskID"
        Me.DataGridViewTextBoxColumn1.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "TaskID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "description"
        Me.DataGridViewTextBoxColumn2.FillWeight = 150.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "starttime"
        Me.DataGridViewTextBoxColumn3.HeaderText = "starttime"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "stoptime"
        Me.DataGridViewTextBoxColumn4.HeaderText = "stoptime"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "worktime"
        Me.DataGridViewTextBoxColumn5.HeaderText = "worktime"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "recrded"
        Me.DataGridViewCheckBoxColumn1.FillWeight = 50.0!
        Me.DataGridViewCheckBoxColumn1.HeaderText = "recrded"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 596)
        Me.Controls.Add(Me.SplitsDataGridView)
        Me.Controls.Add(Me.SplitsBindingNavigator)
        Me.Controls.Add(Me.btnAddTime)
        Me.Controls.Add(Me.btnMinusTime)
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
        Me.MinimumSize = New System.Drawing.Size(775, 300)
        Me.Name = "frmMain"
        Me.Text = "Timer++"
        Me.statustripbottom.ResumeLayout(False)
        Me.statustripbottom.PerformLayout()
        CType(Me.Timer_splitsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitsBindingNavigator.ResumeLayout(False)
        Me.SplitsBindingNavigator.PerformLayout()
        CType(Me.SplitsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tsslblAppName As ToolStripStatusLabel
    Friend WithEvents chRecorded As ColumnHeader
    Friend WithEvents chkbxrecorded As CheckBox
    Friend WithEvents btnMinusTime As Button
    Friend WithEvents btnAddTime As Button
    Friend WithEvents tsslblAppVersion As ToolStripStatusLabel
    Friend WithEvents Timer_splitsDataSet As Timer_splitsDataSet
    Friend WithEvents SplitsBindingSource As BindingSource
    Friend WithEvents SplitsTableAdapter As Timer_splitsDataSetTableAdapters.SplitsTableAdapter
    Friend WithEvents TableAdapterManager As Timer_splitsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SplitsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents SplitsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents SplitsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
End Class
