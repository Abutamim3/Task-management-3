Imports System.IO
Imports System.Windows.Forms

Public Class Form1
    Inherits System.Windows.Forms.Form

    ' تعريف القائمة لتخزين المهام
    Private TaskList As New List(Of TaskItem)
    Private FilePath As String = Path.Combine(Application.StartupPath, "tasks.txt")

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTasks()
        UpdateGrid()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtTitle.Text.Trim() = "" Then
            MessageBox.Show("يرجى إدخال عنوان المهمة.", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim newTask As New TaskItem With {
            .Title = txtTitle.Text,
            .Description = txtDescription.Text,
            .DueDate = dtpDueDate.Value
        }
        TaskList.Add(newTask)
        SaveTasks()
        UpdateGrid()
        ClearInputs()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvTasks.SelectedRows.Count > 0 Then
            Dim index As Integer = dgvTasks.SelectedRows(0).Index
            TaskList.RemoveAt(index)
            SaveTasks()
            UpdateGrid()
        Else
            MessageBox.Show("يرجى تحديد مهمة للحذف.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub LoadTasks()
        If File.Exists(FilePath) Then
            TaskList.Clear()
            Dim lines As String() = File.ReadAllLines(FilePath)
            For Each line In lines
                Dim parts As String() = line.Split("|"c)
                If parts.Length = 3 Then
                    TaskList.Add(New TaskItem With {
                        .Title = parts(0),
                        .Description = parts(1),
                        .DueDate = DateTime.Parse(parts(2))
                    })
                End If
            Next
        End If
    End Sub

    Private Sub SaveTasks()
        Dim lines As New List(Of String)
        For Each task In TaskList
            lines.Add($"{task.Title}|{task.Description}|{task.DueDate}")
        Next
        File.WriteAllLines(FilePath, lines)
    End Sub

    Private Sub UpdateGrid()
        dgvTasks.DataSource = Nothing
        dgvTasks.DataSource = TaskList
    End Sub

    Private Sub ClearInputs()
        txtTitle.Clear()
        txtDescription.Clear()
        dtpDueDate.Value = DateTime.Now
    End Sub
End Class

Public Class TaskItem
    Public Property Title As String
    Public Property Description As String
    Public Property DueDate As DateTime
End Class
