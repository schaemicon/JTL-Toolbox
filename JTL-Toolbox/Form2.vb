Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PropertyGrid1.SelectedObject = My.Settings
        ' Attribute for the user-scope settings.
        Dim userAttr As New System.Configuration.UserScopedSettingAttribute
        Dim attrs As New System.ComponentModel.AttributeCollection(userAttr)
        PropertyGrid1.BrowsableAttributes = attrs
    End Sub
End Class