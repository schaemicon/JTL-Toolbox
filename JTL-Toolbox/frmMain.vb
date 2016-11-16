Public Class frmMain
    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DebitorenToolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebitorenToolToolStripMenuItem.Click

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EinstellungenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinstellungenToolStripMenuItem.Click
        Dim f As New frmSettings
        f.MdiParent = Me
        f.Show()

    End Sub
End Class