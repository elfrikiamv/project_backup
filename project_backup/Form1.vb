Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'set name dir "date and time"
        Dim mkdir As String = "date-" & DateString & "-time-" & TimeString.Replace(":", "-")

        Dim project_backup_patch As String = "F:\project_backup\" & mkdir & "\big_data\projects"

        'verifica si ya existe una carpeta con la fecha y hora actual
        If Directory.Exists(project_backup_patch) Then

            Dim dirproject_backup_true As String
            dirproject_backup_true = MsgBox("¡Ya tienes una copia!" & vbNewLine & "¿Quieres remplazarla para continuar?", vbYesNo)

            If (dirproject_backup_true = vbYes) Then

                'delete project_backup_patch and new copy
                Directory.Delete(project_backup_patch, True)
                My.Computer.FileSystem.CopyDirectory("C:\big_data\projects", project_backup_patch, True)
            Else
                End
            End If
        Else

            'crea la carpeta con la fecha y hora, para hacer la copia
            My.Computer.FileSystem.CreateDirectory("F:\project_backup\" & mkdir & "\big_data\projects")
            My.Computer.FileSystem.CopyDirectory("C:\big_data\projects", project_backup_patch, True)

            'msg de copia realizada
            MsgBox("Ya quedo!", MsgBoxStyle.Information, "project_backup")

            End

        End If
    End Sub
End Class
