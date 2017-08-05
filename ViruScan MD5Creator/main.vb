Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Public Class main

    Private Sub ButtonBrowse_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBrowse.Click
        If OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TextBoxPath.Text = OpenFileDialog.FileName
        End If
    End Sub

    Private Function GetMD5(ByVal path As String) As String
        Dim Md5 As New MD5CryptoServiceProvider
        Dim filestream As New FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        Md5.ComputeHash(filestream)
        Dim hash As Byte() = Md5.Hash
        Dim buffer As New StringBuilder
        Dim hashByte As Byte

        For Each hashByte In hash
            buffer.Append(String.Format("{0:X2}", hashByte))
        Next

        Return buffer.ToString
    End Function

    Private Sub ButtonGetMD5_Click(sender As System.Object, e As System.EventArgs) Handles ButtonGetMD5.Click
        TextBoxOutput.Text = GetMD5(TextBoxPath.Text)
    End Sub

    Private Sub ButtonGetMultiMD5_Click(sender As System.Object, e As System.EventArgs) Handles ButtonGetMultiMD5.Click
        BackgroundWorker.RunWorkerAsync()
    End Sub

    Private Sub ButtonBrowseInput_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBrowseInput.Click
        If OpenFileDialogMulti.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'TextBoxInput.Text = OpenFileDialogMulti.FileNames
            Dim count As Integer = 0
            For Each value As String In OpenFileDialogMulti.FileNames
                TextBoxInput.AppendText(OpenFileDialogMulti.FileNames(count) + vbCrLf)
                count += 1
            Next
        End If
    End Sub

    Private Sub ButtonBrowseOutput_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBrowseOutput.Click
        If SaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBoxHashfile.Text = SaveFileDialog.FileName
            My.Settings.MultiOutputPath = SaveFileDialog.FileName
        End If
    End Sub

    Private Sub BackgroundWorker_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork
        Dim paths As New List(Of String)
        For Each value As String In OpenFileDialogMulti.FileNames
            paths.Add(value)
        Next
        Dim md5s = GetMultiMD5(paths)
        Dim outputpath = SaveFileDialog.FileName
        WriteMD5s(md5s, outputpath)
        MsgBox("Done")
    End Sub

    Private Function GetMultiMD5(ByVal paths As List(Of String)) As List(Of String)
        Dim output As New List(Of String)
        For Each value As String In paths
            output.Add(GetMD5(value))
        Next
        Return output
    End Function

    Private Sub WriteMD5s(ByVal md5s As List(Of String), ByVal file As String)
        Dim sw As IO.StreamWriter
        sw = New IO.StreamWriter(file, True)
        For Each value As String In md5s
            sw.WriteLine(value)
        Next
        sw.Close()
    End Sub

    Private Sub main_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'My.Settings.Save()
    End Sub

    Private Sub main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'OpenFileDialog.FileName = My.Settings("SingleInputPath")
        'OpenFileDialogMulti.FileNames = My.Settings("MultiInputPath")
        TextBoxHashfile.Text = My.Settings.MultiOutputPath
    End Sub
End Class
