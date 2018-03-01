<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EvenLog
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListEvents = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListEvents
        '
        Me.ListEvents.BackColor = System.Drawing.Color.Black
        Me.ListEvents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListEvents.ForeColor = System.Drawing.Color.Lime
        Me.ListEvents.FormattingEnabled = True
        Me.ListEvents.ItemHeight = 15
        Me.ListEvents.Location = New System.Drawing.Point(0, 0)
        Me.ListEvents.Name = "ListEvents"
        Me.ListEvents.Size = New System.Drawing.Size(528, 433)
        Me.ListEvents.TabIndex = 0
        '
        'EvenLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 433)
        Me.Controls.Add(Me.ListEvents)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EvenLog"
        Me.Text = "EvenLog"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListEvents As ListBox
End Class
