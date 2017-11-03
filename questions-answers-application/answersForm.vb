Public Class answersForm
    Protected db As New db
    Protected question_id As Integer

    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        question_id = qid
    End Sub

    Protected Sub LoadAnswers()
        db.sql = "Select * FROM answers where question_id = @question_id"
        db.bind("@question_id", qid)
        db.fill(dgvAnswers)
    End Sub

End Class