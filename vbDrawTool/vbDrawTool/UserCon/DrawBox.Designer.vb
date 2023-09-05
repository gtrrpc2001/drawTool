<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DrawBox
    Inherits System.Windows.Forms.UserControl

    'UserControl은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DrawBox))
        Me.pictureBox_ReSize = New System.Windows.Forms.PictureBox()
        Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnselectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pictureBox_ReSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pictureBox_ReSize
        '
        Me.pictureBox_ReSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox_ReSize.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox_ReSize.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.pictureBox_ReSize.Image = CType(resources.GetObject("pictureBox_ReSize.Image"), System.Drawing.Image)
        Me.pictureBox_ReSize.Location = New System.Drawing.Point(201, 103)
        Me.pictureBox_ReSize.Name = "pictureBox_ReSize"
        Me.pictureBox_ReSize.Size = New System.Drawing.Size(17, 17)
        Me.pictureBox_ReSize.TabIndex = 0
        Me.pictureBox_ReSize.TabStop = False
        '
        'contextMenuStrip1
        '
        Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectAllToolStripMenuItem, Me.UnselectAllToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.DeleteAllToolStripMenuItem, Me.toolStripSeparator1, Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.toolStripSeparator2, Me.PropertiesToolStripMenuItem})
        Me.contextMenuStrip1.Name = "contextMenuStrip1"
        Me.contextMenuStrip1.Size = New System.Drawing.Size(151, 170)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.SelectAllToolStripMenuItem.Text = "전체 선택"
        '
        'UnselectAllToolStripMenuItem
        '
        Me.UnselectAllToolStripMenuItem.Name = "UnselectAllToolStripMenuItem"
        Me.UnselectAllToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.UnselectAllToolStripMenuItem.Text = "전체 해제"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DeleteToolStripMenuItem.Text = "삭제하기"
        '
        'DeleteAllToolStripMenuItem
        '
        Me.DeleteAllToolStripMenuItem.Name = "DeleteAllToolStripMenuItem"
        Me.DeleteAllToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DeleteAllToolStripMenuItem.Text = "전체 삭제하기"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(147, 6)
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Enabled = False
        Me.UndoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.UndoToolStripMenuItem.Text = "실행 취소"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Enabled = False
        Me.RedoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.RedoToolStripMenuItem.Text = "다시 실행"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(147, 6)
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PropertiesToolStripMenuItem.Text = "속성 설정하기"
        '
        'DrawBox
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.pictureBox_ReSize)
        Me.Name = "DrawBox"
        Me.Size = New System.Drawing.Size(218, 120)
        CType(Me.pictureBox_ReSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pictureBox_ReSize As System.Windows.Forms.PictureBox
    Friend WithEvents contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnselectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class