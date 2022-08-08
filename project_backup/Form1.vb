Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim project_backup_patch As String = "F:\project_backup\" & DateString & "\big_data\projects"

        'verifica si ya existe una carpeta con la fecha actual para hacer la copia
        If Directory.Exists(project_backup_patch) Then

            My.Computer.FileSystem.CopyDirectory("C:\big_data\projects", "F:\project_backup\" & DateString & "\big_data\projects", True)
        Else

            'crea la carpeta con la fecha y hace la copia
            My.Computer.FileSystem.CreateDirectory("F:\project_backup\" & DateString & "\big_data\projects")
            My.Computer.FileSystem.CopyDirectory("C:\big_data\projects", "F:\project_backup\" & DateString & "\big_data\projects", True)
        End If

        MsgBox("Ya quedo!", MsgBoxStyle.Information, "#")

        End

    End Sub
End Class
