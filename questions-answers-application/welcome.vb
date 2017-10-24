Imports System.Data.SqlClient

Public Class welcome
    Protected db As New db
    Protected Sub LoadQuestions()
        db.sql = "SELECT * FROM questions ORDER BY created_at DESC;"
        db.fill(dgvQuestions)
    End Sub
    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        LoadQuestions()
    End Sub

    Private Sub welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadQuestions()
    End Sub

    Private Sub dgvQuestions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvQuestions.CellContentClick

    End Sub
End Class
