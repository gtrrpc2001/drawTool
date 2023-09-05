<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToolBar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToolBar))
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStripButtonNew = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButtonOpen = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButtonSave = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButtonSelect = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButtonRectangle = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButtonEllipse = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButtonLine = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButtonPencil = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButtonUndo = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButtonRedo = New System.Windows.Forms.ToolStripButton()
        Me.toolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolStrip1
        '
        Me.toolStrip1.AutoSize = False
        Me.toolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolStrip1.GripMargin = New System.Windows.Forms.Padding(0)
        Me.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButtonNew, Me.toolStripButtonOpen, Me.toolStripButtonSave, Me.toolStripButtonSelect, Me.toolStripButtonRectangle, Me.toolStripButtonEllipse, Me.toolStripButtonLine, Me.toolStripButtonPencil, Me.toolStripButtonUndo, Me.toolStripButtonRedo})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.toolStrip1.Size = New System.Drawing.Size(535, 24)
        Me.toolStrip1.TabIndex = 2
        Me.toolStrip1.Text = "toolStrip1"
        '
        'toolStripButtonNew
        '
        Me.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButtonNew.Image = CType(resources.GetObject("toolStripButtonNew.Image"), System.Drawing.Image)
        Me.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Silver
        Me.toolStripButtonNew.Name = "toolStripButtonNew"
        Me.toolStripButtonNew.Size = New System.Drawing.Size(29, 21)
        Me.toolStripButtonNew.Text = "New"
        Me.toolStripButtonNew.ToolTipText = "새로 만들기"
        '
        'toolStripButtonOpen
        '
        Me.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButtonOpen.Image = CType(resources.GetObject("toolStripButtonOpen.Image"), System.Drawing.Image)
        Me.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Silver
        Me.toolStripButtonOpen.Name = "toolStripButtonOpen"
        Me.toolStripButtonOpen.Size = New System.Drawing.Size(29, 21)
        Me.toolStripButtonOpen.Text = "Open"
        Me.toolStripButtonOpen.ToolTipText = "불러오기"
        '
        'toolStripButtonSave
        '
        Me.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButtonSave.Image = CType(resources.GetObject("toolStripButtonSave.Image"), System.Drawing.Image)
        Me.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Silver
        Me.toolStripButtonSave.Name = "toolStripButtonSave"
        Me.toolStripButtonSave.Size = New System.Drawing.Size(29, 21)
        Me.toolStripButtonSave.Text = "Save"
        Me.toolStripButtonSave.ToolTipText = "저장하기"
        '
        'toolStripButtonSelect
        '
        Me.toolStripButtonSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButtonSelect.Image = CType(resources.GetObject("toolStripButtonSelect.Image"), System.Drawing.Image)
        Me.toolStripButtonSelect.ImageTransparentColor = System.Drawing.Color.Silver
        Me.toolStripButtonSelect.Name = "toolStripButtonSelect"
        Me.toolStripButtonSelect.Size = New System.Drawing.Size(29, 21)
        Me.toolStripButtonSelect.Text = "Select"
        Me.toolStripButtonSelect.ToolTipText = "객체 선택하기"
        '
        'toolStripButtonRectangle
        '
        Me.toolStripButtonRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButtonRectangle.Image = CType(resources.GetObject("toolStripButtonRectangle.Image"), System.Drawing.Image)
        Me.toolStripButtonRectangle.ImageTransparentColor = System.Drawing.Color.Silver
        Me.toolStripButtonRectangle.Name = "toolStripButtonRectangle"
        Me.toolStripButtonRectangle.Size = New System.Drawing.Size(29, 21)
        Me.toolStripButtonRectangle.Text = "Rectangle"
        Me.toolStripButtonRectangle.ToolTipText = "사각형 그리기"
        '
        'toolStripButtonEllipse
        '
        Me.toolStripButtonEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButtonEllipse.Image = CType(resources.GetObject("toolStripButtonEllipse.Image"), System.Drawing.Image)
        Me.toolStripButtonEllipse.ImageTransparentColor = System.Drawing.Color.Silver
        Me.toolStripButtonEllipse.Name = "toolStripButtonEllipse"
        Me.toolStripButtonEllipse.Size = New System.Drawing.Size(29, 21)
        Me.toolStripButtonEllipse.Text = "Ellipse"
        Me.toolStripButtonEllipse.ToolTipText = "원 그리기"
        '
        'toolStripButtonLine
        '
        Me.toolStripButtonLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButtonLine.Image = CType(resources.GetObject("toolStripButtonLine.Image"), System.Drawing.Image)
        Me.toolStripButtonLine.ImageTransparentColor = System.Drawing.Color.Silver
        Me.toolStripButtonLine.Name = "toolStripButtonLine"
        Me.toolStripButtonLine.Size = New System.Drawing.Size(29, 21)
        Me.toolStripButtonLine.Text = "Line"
        Me.toolStripButtonLine.ToolTipText = "줄 그리기"
        '
        'toolStripButtonPencil
        '
        Me.toolStripButtonPencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButtonPencil.Image = CType(resources.GetObject("toolStripButtonPencil.Image"), System.Drawing.Image)
        Me.toolStripButtonPencil.ImageTransparentColor = System.Drawing.Color.Silver
        Me.toolStripButtonPencil.Name = "toolStripButtonPencil"
        Me.toolStripButtonPencil.Size = New System.Drawing.Size(29, 21)
        Me.toolStripButtonPencil.Text = "Pencil"
        Me.toolStripButtonPencil.ToolTipText = "연필"
        '
        'toolStripButtonUndo
        '
        Me.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButtonUndo.Enabled = False
        Me.toolStripButtonUndo.Image = CType(resources.GetObject("toolStripButtonUndo.Image"), System.Drawing.Image)
        Me.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.White
        Me.toolStripButtonUndo.Name = "toolStripButtonUndo"
        Me.toolStripButtonUndo.Size = New System.Drawing.Size(29, 21)
        Me.toolStripButtonUndo.Text = "Undo"
        Me.toolStripButtonUndo.ToolTipText = "실행 취소"
        '
        'toolStripButtonRedo
        '
        Me.toolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButtonRedo.Enabled = False
        Me.toolStripButtonRedo.Image = CType(resources.GetObject("toolStripButtonRedo.Image"), System.Drawing.Image)
        Me.toolStripButtonRedo.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolStripButtonRedo.Name = "toolStripButtonRedo"
        Me.toolStripButtonRedo.Size = New System.Drawing.Size(29, 21)
        Me.toolStripButtonRedo.Text = "Redo"
        Me.toolStripButtonRedo.ToolTipText = "다시 실행"
        '
        'ToolBar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Controls.Add(Me.toolStrip1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ToolBar"
        Me.Size = New System.Drawing.Size(535, 24)
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents toolStripButtonNew As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButtonOpen As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButtonSave As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButtonSelect As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButtonRectangle As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButtonEllipse As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButtonLine As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButtonPencil As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButtonUndo As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButtonRedo As System.Windows.Forms.ToolStripButton
End Class
