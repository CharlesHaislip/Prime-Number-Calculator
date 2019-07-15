<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrimeN
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
        Me.btn1P = New System.Windows.Forms.Button()
        Me.btnF = New System.Windows.Forms.Button()
        Me.lstDisp = New System.Windows.Forms.ListBox()
        Me.txtGetArray = New System.Windows.Forms.TextBox()
        Me.btnNP = New System.Windows.Forms.Button()
        Me.txtNP = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadIDRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToDoListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveArrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadArrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateBackupFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadBackupFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteArrayFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThreadingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SingleThreadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultiThreadedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThreadsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThreadsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThreadsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.progMain = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLrgID = New System.Windows.Forms.Label()
        Me.lblLrgN = New System.Windows.Forms.Label()
        Me.lblTimeS = New System.Windows.Forms.Label()
        Me.cbFindPrime = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTimeMS = New System.Windows.Forms.Label()
        Me.lblTimeMin = New System.Windows.Forms.Label()
        Me.radCalculating = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn1P
        '
        Me.btn1P.Location = New System.Drawing.Point(12, 219)
        Me.btn1P.Name = "btn1P"
        Me.btn1P.Size = New System.Drawing.Size(97, 23)
        Me.btn1P.TabIndex = 0
        Me.btn1P.Text = "Find One Prime"
        Me.btn1P.UseCompatibleTextRendering = True
        Me.btn1P.UseVisualStyleBackColor = True
        '
        'btnF
        '
        Me.btnF.Location = New System.Drawing.Point(12, 277)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(97, 23)
        Me.btnF.TabIndex = 5
        Me.btnF.Text = "Fetch One Prime"
        Me.btnF.UseVisualStyleBackColor = True
        '
        'lstDisp
        '
        Me.lstDisp.FormattingEnabled = True
        Me.lstDisp.Location = New System.Drawing.Point(12, 27)
        Me.lstDisp.MultiColumn = True
        Me.lstDisp.Name = "lstDisp"
        Me.lstDisp.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstDisp.Size = New System.Drawing.Size(337, 186)
        Me.lstDisp.TabIndex = 2
        Me.lstDisp.TabStop = False
        '
        'txtGetArray
        '
        Me.txtGetArray.Location = New System.Drawing.Point(115, 279)
        Me.txtGetArray.Name = "txtGetArray"
        Me.txtGetArray.Size = New System.Drawing.Size(100, 20)
        Me.txtGetArray.TabIndex = 6
        '
        'btnNP
        '
        Me.btnNP.Location = New System.Drawing.Point(12, 248)
        Me.btnNP.Name = "btnNP"
        Me.btnNP.Size = New System.Drawing.Size(97, 23)
        Me.btnNP.TabIndex = 1
        Me.btnNP.Text = "Find Primes"
        Me.btnNP.UseCompatibleTextRendering = True
        Me.btnNP.UseVisualStyleBackColor = True
        '
        'txtNP
        '
        Me.txtNP.Location = New System.Drawing.Point(115, 250)
        Me.txtNP.Name = "txtNP"
        Me.txtNP.Size = New System.Drawing.Size(100, 20)
        Me.txtNP.TabIndex = 2
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(12, 306)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(97, 23)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.FileToolStripMenuItem, Me.VersionToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(361, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadRangeToolStripMenuItem, Me.LoadIDRangeToolStripMenuItem, Me.ResetToolStripMenuItem, Me.ClearTextToolStripMenuItem, Me.CreditsToolStripMenuItem, Me.ToDoListToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'LoadRangeToolStripMenuItem
        '
        Me.LoadRangeToolStripMenuItem.Name = "LoadRangeToolStripMenuItem"
        Me.LoadRangeToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.LoadRangeToolStripMenuItem.Text = "Load Prime Number Range"
        '
        'LoadIDRangeToolStripMenuItem
        '
        Me.LoadIDRangeToolStripMenuItem.Name = "LoadIDRangeToolStripMenuItem"
        Me.LoadIDRangeToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.LoadIDRangeToolStripMenuItem.Text = "Load ID Range"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ClearTextToolStripMenuItem
        '
        Me.ClearTextToolStripMenuItem.Name = "ClearTextToolStripMenuItem"
        Me.ClearTextToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ClearTextToolStripMenuItem.Text = "Clear Text"
        '
        'CreditsToolStripMenuItem
        '
        Me.CreditsToolStripMenuItem.Name = "CreditsToolStripMenuItem"
        Me.CreditsToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.CreditsToolStripMenuItem.Text = "Credits"
        '
        'ToDoListToolStripMenuItem
        '
        Me.ToDoListToolStripMenuItem.Name = "ToDoListToolStripMenuItem"
        Me.ToDoListToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ToDoListToolStripMenuItem.Text = "To Do List"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveArrayToolStripMenuItem, Me.LoadArrayToolStripMenuItem, Me.CreateBackupFileToolStripMenuItem, Me.LoadBackupFileToolStripMenuItem, Me.DeleteArrayFileToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveArrayToolStripMenuItem
        '
        Me.SaveArrayToolStripMenuItem.Name = "SaveArrayToolStripMenuItem"
        Me.SaveArrayToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.SaveArrayToolStripMenuItem.Text = "Save Array"
        '
        'LoadArrayToolStripMenuItem
        '
        Me.LoadArrayToolStripMenuItem.Name = "LoadArrayToolStripMenuItem"
        Me.LoadArrayToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.LoadArrayToolStripMenuItem.Text = "Load Array"
        '
        'CreateBackupFileToolStripMenuItem
        '
        Me.CreateBackupFileToolStripMenuItem.Name = "CreateBackupFileToolStripMenuItem"
        Me.CreateBackupFileToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CreateBackupFileToolStripMenuItem.Text = "Create Backup File"
        '
        'LoadBackupFileToolStripMenuItem
        '
        Me.LoadBackupFileToolStripMenuItem.Name = "LoadBackupFileToolStripMenuItem"
        Me.LoadBackupFileToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.LoadBackupFileToolStripMenuItem.Text = "Load Backup File"
        '
        'DeleteArrayFileToolStripMenuItem
        '
        Me.DeleteArrayFileToolStripMenuItem.Name = "DeleteArrayFileToolStripMenuItem"
        Me.DeleteArrayFileToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.DeleteArrayFileToolStripMenuItem.Text = "Delete Array File"
        '
        'VersionToolStripMenuItem
        '
        Me.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem"
        Me.VersionToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.VersionToolStripMenuItem.Text = "Version"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThreadingToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ThreadingToolStripMenuItem
        '
        Me.ThreadingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SingleThreadToolStripMenuItem, Me.MultiThreadedToolStripMenuItem})
        Me.ThreadingToolStripMenuItem.Name = "ThreadingToolStripMenuItem"
        Me.ThreadingToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ThreadingToolStripMenuItem.Text = "Threading (NOT IMPLEMENTED)"
        '
        'SingleThreadToolStripMenuItem
        '
        Me.SingleThreadToolStripMenuItem.Name = "SingleThreadToolStripMenuItem"
        Me.SingleThreadToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SingleThreadToolStripMenuItem.Text = "Single Thread"
        '
        'MultiThreadedToolStripMenuItem
        '
        Me.MultiThreadedToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThreadsToolStripMenuItem, Me.ThreadsToolStripMenuItem1, Me.ThreadsToolStripMenuItem2})
        Me.MultiThreadedToolStripMenuItem.Name = "MultiThreadedToolStripMenuItem"
        Me.MultiThreadedToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.MultiThreadedToolStripMenuItem.Text = "Multi-Threaded"
        '
        'ThreadsToolStripMenuItem
        '
        Me.ThreadsToolStripMenuItem.Name = "ThreadsToolStripMenuItem"
        Me.ThreadsToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ThreadsToolStripMenuItem.Text = "2 Threads"
        '
        'ThreadsToolStripMenuItem1
        '
        Me.ThreadsToolStripMenuItem1.Name = "ThreadsToolStripMenuItem1"
        Me.ThreadsToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.ThreadsToolStripMenuItem1.Text = "3 Threads"
        '
        'ThreadsToolStripMenuItem2
        '
        Me.ThreadsToolStripMenuItem2.Name = "ThreadsToolStripMenuItem2"
        Me.ThreadsToolStripMenuItem2.Size = New System.Drawing.Size(125, 22)
        Me.ThreadsToolStripMenuItem2.Text = "4 Threads"
        '
        'progMain
        '
        Me.progMain.Location = New System.Drawing.Point(115, 306)
        Me.progMain.Name = "progMain"
        Me.progMain.Size = New System.Drawing.Size(234, 23)
        Me.progMain.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Largest Prime:"
        '
        'lblLrgID
        '
        Me.lblLrgID.AutoSize = True
        Me.lblLrgID.Location = New System.Drawing.Point(191, 16)
        Me.lblLrgID.Name = "lblLrgID"
        Me.lblLrgID.Size = New System.Drawing.Size(30, 13)
        Me.lblLrgID.TabIndex = 10
        Me.lblLrgID.Text = "ID: 0"
        '
        'lblLrgN
        '
        Me.lblLrgN.AutoSize = True
        Me.lblLrgN.Location = New System.Drawing.Point(191, 29)
        Me.lblLrgN.Name = "lblLrgN"
        Me.lblLrgN.Size = New System.Drawing.Size(56, 13)
        Me.lblLrgN.TabIndex = 11
        Me.lblLrgN.Text = "Number: 2"
        '
        'lblTimeS
        '
        Me.lblTimeS.AutoSize = True
        Me.lblTimeS.Location = New System.Drawing.Point(191, 29)
        Me.lblTimeS.Name = "lblTimeS"
        Me.lblTimeS.Size = New System.Drawing.Size(58, 13)
        Me.lblTimeS.TabIndex = 12
        Me.lblTimeS.Text = "0 Seconds"
        '
        'cbFindPrime
        '
        Me.cbFindPrime.DisplayMember = "0"
        Me.cbFindPrime.FormattingEnabled = True
        Me.cbFindPrime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbFindPrime.Items.AddRange(New Object() {"Find 'X' Primes", "Find Until 'X' Prime"})
        Me.cbFindPrime.Location = New System.Drawing.Point(221, 249)
        Me.cbFindPrime.Name = "cbFindPrime"
        Me.cbFindPrime.Size = New System.Drawing.Size(128, 21)
        Me.cbFindPrime.TabIndex = 14
        Me.cbFindPrime.Text = "Find 'X' Primes"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblLrgID)
        Me.GroupBox1.Controls.Add(Me.lblLrgN)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 335)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 46)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Prime Number Stats"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTimeMS)
        Me.GroupBox3.Controls.Add(Me.lblTimeMin)
        Me.GroupBox3.Controls.Add(Me.lblTimeS)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 387)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(337, 65)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Calculation Time"
        '
        'lblTimeMS
        '
        Me.lblTimeMS.AutoSize = True
        Me.lblTimeMS.Location = New System.Drawing.Point(191, 16)
        Me.lblTimeMS.Name = "lblTimeMS"
        Me.lblTimeMS.Size = New System.Drawing.Size(73, 13)
        Me.lblTimeMS.TabIndex = 14
        Me.lblTimeMS.Text = "0 Milliseconds"
        '
        'lblTimeMin
        '
        Me.lblTimeMin.AutoSize = True
        Me.lblTimeMin.Location = New System.Drawing.Point(191, 42)
        Me.lblTimeMin.Name = "lblTimeMin"
        Me.lblTimeMin.Size = New System.Drawing.Size(53, 13)
        Me.lblTimeMin.TabIndex = 13
        Me.lblTimeMin.Text = "0 Minutes"
        '
        'radCalculating
        '
        Me.radCalculating.AutoSize = True
        Me.radCalculating.Enabled = False
        Me.radCalculating.Location = New System.Drawing.Point(227, 222)
        Me.radCalculating.Name = "radCalculating"
        Me.radCalculating.Size = New System.Drawing.Size(88, 17)
        Me.radCalculating.TabIndex = 17
        Me.radCalculating.TabStop = True
        Me.radCalculating.Text = "Is Calculating"
        Me.radCalculating.UseVisualStyleBackColor = True
        '
        'PrimeN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(361, 464)
        Me.Controls.Add(Me.radCalculating)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbFindPrime)
        Me.Controls.Add(Me.progMain)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtNP)
        Me.Controls.Add(Me.btnNP)
        Me.Controls.Add(Me.txtGetArray)
        Me.Controls.Add(Me.lstDisp)
        Me.Controls.Add(Me.btnF)
        Me.Controls.Add(Me.btn1P)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "PrimeN"
        Me.Text = "Prime Number Finder"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn1P As Button
    Friend WithEvents btnF As Button
    Friend WithEvents lstDisp As ListBox
    Friend WithEvents txtGetArray As TextBox
    Friend WithEvents btnNP As Button
    Friend WithEvents txtNP As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreditsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveArrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadArrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents progMain As ProgressBar
    Friend WithEvents DeleteArrayFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateBackupFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadBackupFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadRangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadIDRangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToDoListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLrgID As Label
    Friend WithEvents lblLrgN As Label
    Friend WithEvents lblTimeS As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbFindPrime As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents radCalculating As RadioButton
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThreadingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SingleThreadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MultiThreadedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThreadsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThreadsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ThreadsToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents lblTimeMin As Label
    Friend WithEvents lblTimeMS As Label
End Class
