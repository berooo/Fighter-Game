<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PicturePopeye = New System.Windows.Forms.PictureBox()
        Me.PictureEnemy = New System.Windows.Forms.PictureBox()
        Me.btnAttack = New System.Windows.Forms.Button()
        Me.btnSpawn = New System.Windows.Forms.Button()
        Me.ProgressBarPopeye = New System.Windows.Forms.ProgressBar()
        Me.ProgressBarEnemy = New System.Windows.Forms.ProgressBar()
        Me.radioSpinach = New System.Windows.Forms.RadioButton()
        Me.lblSpinachLeft = New System.Windows.Forms.Label()
        Me.timerDelay = New System.Windows.Forms.Timer(Me.components)
        Me.lblPopHealth = New System.Windows.Forms.Label()
        Me.lblEnemyHealth = New System.Windows.Forms.Label()
        Me.btnHideAndShow = New System.Windows.Forms.Button()
        CType(Me.PicturePopeye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEnemy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicturePopeye
        '
        Me.PicturePopeye.Image = CType(resources.GetObject("PicturePopeye.Image"), System.Drawing.Image)
        Me.PicturePopeye.InitialImage = CType(resources.GetObject("PicturePopeye.InitialImage"), System.Drawing.Image)
        Me.PicturePopeye.Location = New System.Drawing.Point(30, 89)
        Me.PicturePopeye.Name = "PicturePopeye"
        Me.PicturePopeye.Size = New System.Drawing.Size(172, 224)
        Me.PicturePopeye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicturePopeye.TabIndex = 0
        Me.PicturePopeye.TabStop = False
        '
        'PictureEnemy
        '
        Me.PictureEnemy.Image = Global.Game_GUI.My.Resources.Resources.cartoon_zombie
        Me.PictureEnemy.Location = New System.Drawing.Point(317, 89)
        Me.PictureEnemy.Name = "PictureEnemy"
        Me.PictureEnemy.Size = New System.Drawing.Size(172, 224)
        Me.PictureEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureEnemy.TabIndex = 1
        Me.PictureEnemy.TabStop = False
        '
        'btnAttack
        '
        Me.btnAttack.Location = New System.Drawing.Point(30, 36)
        Me.btnAttack.Name = "btnAttack"
        Me.btnAttack.Size = New System.Drawing.Size(99, 31)
        Me.btnAttack.TabIndex = 2
        Me.btnAttack.Text = "Attack"
        Me.btnAttack.UseVisualStyleBackColor = True
        '
        'btnSpawn
        '
        Me.btnSpawn.Location = New System.Drawing.Point(317, 38)
        Me.btnSpawn.Name = "btnSpawn"
        Me.btnSpawn.Size = New System.Drawing.Size(184, 29)
        Me.btnSpawn.TabIndex = 3
        Me.btnSpawn.Text = "Spawn Enemy"
        Me.btnSpawn.UseVisualStyleBackColor = True
        '
        'ProgressBarPopeye
        '
        Me.ProgressBarPopeye.Location = New System.Drawing.Point(30, 344)
        Me.ProgressBarPopeye.Maximum = 250
        Me.ProgressBarPopeye.Name = "ProgressBarPopeye"
        Me.ProgressBarPopeye.Size = New System.Drawing.Size(184, 29)
        Me.ProgressBarPopeye.TabIndex = 4
        '
        'ProgressBarEnemy
        '
        Me.ProgressBarEnemy.Location = New System.Drawing.Point(317, 344)
        Me.ProgressBarEnemy.Name = "ProgressBarEnemy"
        Me.ProgressBarEnemy.Size = New System.Drawing.Size(184, 29)
        Me.ProgressBarEnemy.TabIndex = 5
        '
        'radioSpinach
        '
        Me.radioSpinach.AutoSize = True
        Me.radioSpinach.Location = New System.Drawing.Point(147, 46)
        Me.radioSpinach.Name = "radioSpinach"
        Me.radioSpinach.Size = New System.Drawing.Size(116, 19)
        Me.radioSpinach.TabIndex = 6
        Me.radioSpinach.TabStop = True
        Me.radioSpinach.Text = "Use Spinach"
        Me.radioSpinach.UseVisualStyleBackColor = True
        '
        'lblSpinachLeft
        '
        Me.lblSpinachLeft.AutoSize = True
        Me.lblSpinachLeft.Location = New System.Drawing.Point(147, 68)
        Me.lblSpinachLeft.Name = "lblSpinachLeft"
        Me.lblSpinachLeft.Size = New System.Drawing.Size(119, 15)
        Me.lblSpinachLeft.TabIndex = 7
        Me.lblSpinachLeft.Text = "Spinach Left:3"
        '
        'timerDelay
        '
        Me.timerDelay.Interval = 1000
        '
        'lblPopHealth
        '
        Me.lblPopHealth.AutoSize = True
        Me.lblPopHealth.Location = New System.Drawing.Point(27, 390)
        Me.lblPopHealth.Name = "lblPopHealth"
        Me.lblPopHealth.Size = New System.Drawing.Size(63, 15)
        Me.lblPopHealth.TabIndex = 8
        Me.lblPopHealth.Text = "Health:"
        '
        'lblEnemyHealth
        '
        Me.lblEnemyHealth.AutoSize = True
        Me.lblEnemyHealth.Location = New System.Drawing.Point(314, 390)
        Me.lblEnemyHealth.Name = "lblEnemyHealth"
        Me.lblEnemyHealth.Size = New System.Drawing.Size(63, 15)
        Me.lblEnemyHealth.TabIndex = 9
        Me.lblEnemyHealth.Text = "Health:"
        '
        'btnHideAndShow
        '
        Me.btnHideAndShow.Location = New System.Drawing.Point(30, 424)
        Me.btnHideAndShow.Name = "btnHideAndShow"
        Me.btnHideAndShow.Size = New System.Drawing.Size(471, 23)
        Me.btnHideAndShow.TabIndex = 10
        Me.btnHideAndShow.Text = "Hide Log"
        Me.btnHideAndShow.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 459)
        Me.Controls.Add(Me.btnHideAndShow)
        Me.Controls.Add(Me.lblEnemyHealth)
        Me.Controls.Add(Me.lblPopHealth)
        Me.Controls.Add(Me.lblSpinachLeft)
        Me.Controls.Add(Me.radioSpinach)
        Me.Controls.Add(Me.ProgressBarEnemy)
        Me.Controls.Add(Me.ProgressBarPopeye)
        Me.Controls.Add(Me.btnSpawn)
        Me.Controls.Add(Me.btnAttack)
        Me.Controls.Add(Me.PictureEnemy)
        Me.Controls.Add(Me.PicturePopeye)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PicturePopeye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEnemy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicturePopeye As PictureBox
    Friend WithEvents PictureEnemy As PictureBox
    Friend WithEvents btnAttack As Button
    Friend WithEvents btnSpawn As Button
    Friend WithEvents ProgressBarPopeye As ProgressBar
    Friend WithEvents ProgressBarEnemy As ProgressBar
    Friend WithEvents radioSpinach As RadioButton
    Friend WithEvents lblSpinachLeft As Label
    Friend WithEvents timerDelay As Timer
    Friend WithEvents lblPopHealth As Label
    Friend WithEvents lblEnemyHealth As Label
    Friend WithEvents btnHideAndShow As Button
End Class
