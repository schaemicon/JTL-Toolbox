Public Class Form1

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EinstellungenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinstellungenToolStripMenuItem.Click
        Dim f As New Form2
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub DebitorenToolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebitorenToolToolStripMenuItem.Click
        Dim f As New Form3
        f.MdiParent = Me
        f.Show()
    End Sub
End Class
