<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.TextBoxPath = New System.Windows.Forms.TextBox()
        Me.LabelFile = New System.Windows.Forms.Label()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.TextBoxOutput = New System.Windows.Forms.TextBox()
        Me.ButtonGetMD5 = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonGetMultiMD5 = New System.Windows.Forms.Button()
        Me.ButtonBrowseOutput = New System.Windows.Forms.Button()
        Me.ButtonBrowseInput = New System.Windows.Forms.Button()
        Me.TextBoxHashfile = New System.Windows.Forms.TextBox()
        Me.TextBoxInput = New System.Windows.Forms.TextBox()
        Me.OpenFileDialogMulti = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxPath
        '
        Me.TextBoxPath.Location = New System.Drawing.Point(41, 12)
        Me.TextBoxPath.Name = "TextBoxPath"
        Me.TextBoxPath.Size = New System.Drawing.Size(251, 20)
        Me.TextBoxPath.TabIndex = 0
        '
        'LabelFile
        '
        Me.LabelFile.AutoSize = True
        Me.LabelFile.Location = New System.Drawing.Point(12, 12)
        Me.LabelFile.Name = "LabelFile"
        Me.LabelFile.Size = New System.Drawing.Size(23, 13)
        Me.LabelFile.TabIndex = 1
        Me.LabelFile.Text = "File"
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.Location = New System.Drawing.Point(299, 9)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBrowse.TabIndex = 2
        Me.ButtonBrowse.Text = "Browse..."
        Me.ButtonBrowse.UseVisualStyleBackColor = True
        '
        'TextBoxOutput
        '
        Me.TextBoxOutput.HideSelection = False
        Me.TextBoxOutput.Location = New System.Drawing.Point(12, 66)
        Me.TextBoxOutput.Name = "TextBoxOutput"
        Me.TextBoxOutput.ReadOnly = True
        Me.TextBoxOutput.Size = New System.Drawing.Size(362, 20)
        Me.TextBoxOutput.TabIndex = 3
        '
        'ButtonGetMD5
        '
        Me.ButtonGetMD5.Location = New System.Drawing.Point(12, 37)
        Me.ButtonGetMD5.Name = "ButtonGetMD5"
        Me.ButtonGetMD5.Size = New System.Drawing.Size(362, 23)
        Me.ButtonGetMD5.TabIndex = 4
        Me.ButtonGetMD5.Text = "Get MD5"
        Me.ButtonGetMD5.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Title = "Browse for a file"
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.Label2)
        Me.GroupBox.Controls.Add(Me.Label1)
        Me.GroupBox.Controls.Add(Me.ButtonGetMultiMD5)
        Me.GroupBox.Controls.Add(Me.ButtonBrowseOutput)
        Me.GroupBox.Controls.Add(Me.ButtonBrowseInput)
        Me.GroupBox.Controls.Add(Me.TextBoxHashfile)
        Me.GroupBox.Controls.Add(Me.TextBoxInput)
        Me.GroupBox.Location = New System.Drawing.Point(12, 96)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(361, 143)
        Me.GroupBox.TabIndex = 5
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Multiple files"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Hash file"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Files"
        '
        'ButtonGetMultiMD5
        '
        Me.ButtonGetMultiMD5.Location = New System.Drawing.Point(6, 110)
        Me.ButtonGetMultiMD5.Name = "ButtonGetMultiMD5"
        Me.ButtonGetMultiMD5.Size = New System.Drawing.Size(349, 27)
        Me.ButtonGetMultiMD5.TabIndex = 4
        Me.ButtonGetMultiMD5.Text = "Get MD5"
        Me.ButtonGetMultiMD5.UseVisualStyleBackColor = True
        '
        'ButtonBrowseOutput
        '
        Me.ButtonBrowseOutput.Location = New System.Drawing.Point(287, 83)
        Me.ButtonBrowseOutput.Name = "ButtonBrowseOutput"
        Me.ButtonBrowseOutput.Size = New System.Drawing.Size(69, 20)
        Me.ButtonBrowseOutput.TabIndex = 3
        Me.ButtonBrowseOutput.Text = "Browse"
        Me.ButtonBrowseOutput.UseVisualStyleBackColor = True
        '
        'ButtonBrowseInput
        '
        Me.ButtonBrowseInput.Location = New System.Drawing.Point(287, 19)
        Me.ButtonBrowseInput.Name = "ButtonBrowseInput"
        Me.ButtonBrowseInput.Size = New System.Drawing.Size(68, 20)
        Me.ButtonBrowseInput.TabIndex = 2
        Me.ButtonBrowseInput.Text = "Browse"
        Me.ButtonBrowseInput.UseVisualStyleBackColor = True
        '
        'TextBoxHashfile
        '
        Me.TextBoxHashfile.Location = New System.Drawing.Point(58, 84)
        Me.TextBoxHashfile.Name = "TextBoxHashfile"
        Me.TextBoxHashfile.Size = New System.Drawing.Size(224, 20)
        Me.TextBoxHashfile.TabIndex = 1
        '
        'TextBoxInput
        '
        Me.TextBoxInput.Location = New System.Drawing.Point(58, 19)
        Me.TextBoxInput.Multiline = True
        Me.TextBoxInput.Name = "TextBoxInput"
        Me.TextBoxInput.Size = New System.Drawing.Size(222, 59)
        Me.TextBoxInput.TabIndex = 0
        '
        'OpenFileDialogMulti
        '
        Me.OpenFileDialogMulti.Multiselect = True
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.Filter = "Text files|*.txt|All files|*.*"
        '
        'BackgroundWorker
        '
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 251)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.ButtonGetMD5)
        Me.Controls.Add(Me.TextBoxOutput)
        Me.Controls.Add(Me.ButtonBrowse)
        Me.Controls.Add(Me.LabelFile)
        Me.Controls.Add(Me.TextBoxPath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.Text = "ViruScan MD5Creator"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxPath As System.Windows.Forms.TextBox
    Friend WithEvents LabelFile As System.Windows.Forms.Label
    Friend WithEvents ButtonBrowse As System.Windows.Forms.Button
    Friend WithEvents TextBoxOutput As System.Windows.Forms.TextBox
    Friend WithEvents ButtonGetMD5 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonGetMultiMD5 As System.Windows.Forms.Button
    Friend WithEvents ButtonBrowseOutput As System.Windows.Forms.Button
    Friend WithEvents ButtonBrowseInput As System.Windows.Forms.Button
    Friend WithEvents TextBoxHashfile As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxInput As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialogMulti As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker

End Class
