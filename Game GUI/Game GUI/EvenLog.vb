Public Class EvenLog
    ' Private Sub ListEvents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListEvents.SelectedIndexChanged

    ' End Sub
    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        ListEvents.Items.Add("Event Logger Has Successfully Loaded")
        ListEvents.Items.Add("------------------------------------")
    End Sub
    Public Sub AddEvent(ByVal strEvent As String)
        ListEvents.Items.Add(strEvent)
    End Sub

End Class