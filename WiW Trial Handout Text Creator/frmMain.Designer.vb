<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.linkBugreport = New System.Windows.Forms.LinkLabel()
        Me.lblWeeks = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPeriod2 = New System.Windows.Forms.Label()
        Me.txtNickname = New System.Windows.Forms.TextBox()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comboCutoff = New System.Windows.Forms.ComboBox()
        Me.buttonGenerateText = New System.Windows.Forms.Button()
        Me.buttonResetForm = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dateCalendar = New System.Windows.Forms.MonthCalendar()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.linkBugreport)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblWeeks)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPeriod2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtNickname)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPeriod)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.comboCutoff)
        Me.SplitContainer1.Panel1.Controls.Add(Me.buttonGenerateText)
        Me.SplitContainer1.Panel1.Controls.Add(Me.buttonResetForm)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(596, 354)
        Me.SplitContainer1.SplitterDistance = 172
        Me.SplitContainer1.TabIndex = 0
        Me.SplitContainer1.TabStop = False
        '
        'linkBugreport
        '
        Me.linkBugreport.AutoSize = True
        Me.linkBugreport.Location = New System.Drawing.Point(12, 331)
        Me.linkBugreport.Name = "linkBugreport"
        Me.linkBugreport.Size = New System.Drawing.Size(155, 13)
        Me.linkBugreport.TabIndex = 28
        Me.linkBugreport.TabStop = True
        Me.linkBugreport.Text = "http://tmsn.at/trial-handout.htm"
        '
        'lblWeeks
        '
        Me.lblWeeks.AutoSize = True
        Me.lblWeeks.Location = New System.Drawing.Point(12, 263)
        Me.lblWeeks.Name = "lblWeeks"
        Me.lblWeeks.Size = New System.Drawing.Size(73, 13)
        Me.lblWeeks.TabIndex = 27
        Me.lblWeeks.Text = "(need update)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nickname"
        '
        'lblPeriod2
        '
        Me.lblPeriod2.AutoSize = True
        Me.lblPeriod2.Location = New System.Drawing.Point(12, 298)
        Me.lblPeriod2.Name = "lblPeriod2"
        Me.lblPeriod2.Size = New System.Drawing.Size(73, 13)
        Me.lblPeriod2.TabIndex = 26
        Me.lblPeriod2.Text = "(need update)"
        '
        'txtNickname
        '
        Me.txtNickname.Location = New System.Drawing.Point(15, 31)
        Me.txtNickname.MaxLength = 120
        Me.txtNickname.Name = "txtNickname"
        Me.txtNickname.Size = New System.Drawing.Size(120, 20)
        Me.txtNickname.TabIndex = 0
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Location = New System.Drawing.Point(12, 244)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(73, 13)
        Me.lblPeriod.TabIndex = 25
        Me.lblPeriod.Text = "(need update)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Cutoff?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Selected Period"
        '
        'comboCutoff
        '
        Me.comboCutoff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboCutoff.FormattingEnabled = True
        Me.comboCutoff.Items.AddRange(New Object() {"yes", "no"})
        Me.comboCutoff.Location = New System.Drawing.Point(15, 88)
        Me.comboCutoff.Name = "comboCutoff"
        Me.comboCutoff.Size = New System.Drawing.Size(120, 21)
        Me.comboCutoff.TabIndex = 1
        '
        'buttonGenerateText
        '
        Me.buttonGenerateText.Enabled = False
        Me.buttonGenerateText.Location = New System.Drawing.Point(15, 166)
        Me.buttonGenerateText.Name = "buttonGenerateText"
        Me.buttonGenerateText.Size = New System.Drawing.Size(120, 30)
        Me.buttonGenerateText.TabIndex = 3
        Me.buttonGenerateText.Text = "Select A Period First"
        Me.buttonGenerateText.UseVisualStyleBackColor = True
        '
        'buttonResetForm
        '
        Me.buttonResetForm.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonResetForm.Location = New System.Drawing.Point(15, 130)
        Me.buttonResetForm.Name = "buttonResetForm"
        Me.buttonResetForm.Size = New System.Drawing.Size(120, 30)
        Me.buttonResetForm.TabIndex = 21
        Me.buttonResetForm.Text = "Reset"
        Me.buttonResetForm.UseVisualStyleBackColor = True
        Me.buttonResetForm.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dateCalendar, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(420, 354)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dateCalendar
        '
        Me.dateCalendar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateCalendar.BackColor = System.Drawing.Color.White
        Me.dateCalendar.CalendarDimensions = New System.Drawing.Size(2, 2)
        Me.dateCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.dateCalendar.ForeColor = System.Drawing.Color.Black
        Me.dateCalendar.Location = New System.Drawing.Point(10, 33)
        Me.dateCalendar.Margin = New System.Windows.Forms.Padding(0)
        Me.dateCalendar.MaxSelectionCount = 36
        Me.dateCalendar.Name = "dateCalendar"
        Me.dateCalendar.ShowWeekNumbers = True
        Me.dateCalendar.TabIndex = 2
        Me.dateCalendar.TitleBackColor = System.Drawing.Color.Silver
        Me.dateCalendar.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dateCalendar.TrailingForeColor = System.Drawing.Color.Gray
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(252, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Trial Period (Select with mouse)"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 354)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "WiW Trial Handout"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblWeeks As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPeriod2 As System.Windows.Forms.Label
    Friend WithEvents txtNickname As System.Windows.Forms.TextBox
    Friend WithEvents lblPeriod As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents comboCutoff As System.Windows.Forms.ComboBox
    Friend WithEvents buttonGenerateText As System.Windows.Forms.Button
    Friend WithEvents buttonResetForm As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dateCalendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents linkBugreport As System.Windows.Forms.LinkLabel

End Class
