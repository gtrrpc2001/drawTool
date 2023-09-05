<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainView
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainView))
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.editToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnselectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.drawToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pointerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rectangleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ellipseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pencilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panel_Draw = New System.Windows.Forms.Panel()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.userControl_DrawBox1 = New DrawBox()
        Me.userControl_ToolBar1 = New ToolBar()
        Me.menuStrip1.SuspendLayout()
        Me.panel_Draw.SuspendLayout()
        Me.SuspendLayout()
        Me.menuStrip1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((85)))))), (CInt(((CByte((85)))))), (CInt(((CByte((85)))))))
        Me.menuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.menuStrip1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((255)))))), (CInt(((CByte((255)))))))
        Me.menuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.editToolStripMenuItem, Me.drawToolStripMenuItem, Me.helpToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.menuStrip1.Size = New System.Drawing.Size(193, 24)
        Me.menuStrip1.TabIndex = 1
        Me.menuStrip1.Text = "menuStrip1"
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripMenuItem, Me.openToolStripMenuItem, Me.saveToolStripMenuItem, Me.toolStripMenuItem2, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(43, 24)
        Me.fileToolStripMenuItem.Text = "파일"
        Me.newToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((85)))))), (CInt(((CByte((85)))))), (CInt(((CByte((85)))))))
        Me.newToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver
        Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
        Me.newToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.newToolStripMenuItem.Text = "새로 만들기"
        'AddHandler Me.newToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.NewToolStripMenuItem_Click)
        Me.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((85)))))), (CInt(((CByte((85)))))), (CInt(((CByte((85)))))))
        Me.openToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver
        Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
        Me.openToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.openToolStripMenuItem.Text = "불러오기"
        'AddHandler Me.openToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.FileLoadToolStripMenuItem_Click)
        Me.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((85)))))), (CInt(((CByte((85)))))), (CInt(((CByte((85)))))))
        Me.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver
        Me.saveToolStripMenuItem.Name = "saveToolStripMenuItem"
        Me.saveToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.saveToolStripMenuItem.Text = "저장하기"
        'AddHandler Me.saveToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.SaveFileToolStripMenuItem_Click)
        Me.toolStripMenuItem2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(135, 6)
        Me.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((85)))))), (CInt(((CByte((85)))))), (CInt(((CByte((85)))))))
        Me.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.exitToolStripMenuItem.Text = "종료"
        'AddHandler Me.exitToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.ExitToolStripMenuItem_Click)
        Me.editToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectAllToolStripMenuItem, Me.UnselectAllToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.DeleteAllToolStripMenuItem, Me.toolStripMenuItem3, Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.toolStripMenuItem4, Me.PropertiesToolStripMenuItem})
        Me.editToolStripMenuItem.Name = "editToolStripMenuItem"
        Me.editToolStripMenuItem.Size = New System.Drawing.Size(43, 24)
        Me.editToolStripMenuItem.Text = "편집"
        Me.SelectAllToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((85)))))), (CInt(((CByte((85)))))), (CInt(((CByte((85)))))))
        Me.SelectAllToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.SelectAllToolStripMenuItem.Text = "전체 선택"
        'AddHandler Me.SelectAllToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.SelectAllToolStripMenuItem_Click)
        Me.UnselectAllToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((85)))))), (CInt(((CByte((85)))))), (CInt(((CByte((85)))))))
        Me.UnselectAllToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.UnselectAllToolStripMenuItem.Name = "UnselectAllToolStripMenuItem"
        Me.UnselectAllToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.UnselectAllToolStripMenuItem.Text = "전체 해제"
        ' AddHandler Me.UnselectAllToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.UnselectAllToolStripMenuItem_Click)
        Me.DeleteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((85)))))), (CInt(((CByte((85)))))), (CInt(((CByte((85)))))))
        Me.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DeleteToolStripMenuItem.Text = "삭제하기"
        ' AddHandler Me.DeleteToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.DeleteToolStripMenuItem_Click)
        Me.DeleteAllToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((85)))))), (CInt(((CByte((85)))))), (CInt(((CByte((85)))))))
        Me.DeleteAllToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DeleteAllToolStripMenuItem.Name = "DeleteAllToolStripMenuItem"
        Me.DeleteAllToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DeleteAllToolStripMenuItem.Text = "전체 삭제하기"
        ' AddHandler Me.DeleteAllToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.deleteAllToolStripMenuItem_Click)
        Me.toolStripMenuItem3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.toolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.toolStripMenuItem3.Name = "toolStripMenuItem3"
        Me.toolStripMenuItem3.Size = New System.Drawing.Size(147, 6)
        Me.UndoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((85)))))), (CInt(((CByte((85)))))), (CInt(((CByte((85)))))))
        Me.UndoToolStripMenuItem.Enabled = False
        Me.UndoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.UndoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.UndoToolStripMenuItem.Text = "실행 취소"
        ' AddHandler Me.UndoToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.UndoToolStripMenuItem_Click)
        Me.RedoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((85)))))), (CInt(((CByte((85)))))), (CInt(((CByte((85)))))))
        Me.RedoToolStripMenuItem.Enabled = False
        Me.RedoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RedoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.RedoToolStripMenuItem.Text = "다시 실행"
        ' AddHandler Me.RedoToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.redoToolStripMenuItem_Click)
        Me.toolStripMenuItem4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.toolStripMenuItem4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.toolStripMenuItem4.Name = "toolStripMenuItem4"
        Me.toolStripMenuItem4.Size = New System.Drawing.Size(147, 6)
        Me.PropertiesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((85)))))), (CInt(((CByte((85)))))), (CInt(((CByte((85)))))))
        Me.PropertiesToolStripMenuItem.Enabled = False
        Me.PropertiesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PropertiesToolStripMenuItem.Text = "속성 설정하기"
        ' AddHandler Me.PropertiesToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.PropertiesToolStripMenuItem_Click)
        Me.drawToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pointerToolStripMenuItem, Me.rectangleToolStripMenuItem, Me.ellipseToolStripMenuItem, Me.lineToolStripMenuItem, Me.pencilToolStripMenuItem})
        Me.drawToolStripMenuItem.Name = "drawToolStripMenuItem"
        Me.drawToolStripMenuItem.Size = New System.Drawing.Size(43, 24)
        Me.drawToolStripMenuItem.Text = "도구"
        Me.pointerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((85)))))), (CInt(((CByte((85)))))), (CInt(((CByte((85)))))))
        Me.pointerToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.pointerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver
        Me.pointerToolStripMenuItem.Name = "pointerToolStripMenuItem"
        Me.pointerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.pointerToolStripMenuItem.Text = "선택 하기"
        ' AddHandler Me.pointerToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.SelectToolStripMenuItem_Click)
        Me.rectangleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((85)))))), (CInt(((CByte((85)))))), (CInt(((CByte((85)))))))
        Me.rectangleToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.rectangleToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver
        Me.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem"
        Me.rectangleToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.rectangleToolStripMenuItem.Text = "사각형"
        ' AddHandler Me.rectangleToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.RectangleToolStripMenuItem_Click)
        Me.ellipseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((85)))))), (CInt(((CByte((85)))))), (CInt(((CByte((85)))))))
        Me.ellipseToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ellipseToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver
        Me.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem"
        Me.ellipseToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ellipseToolStripMenuItem.Text = "원"
        '  AddHandler Me.ellipseToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.EllipseToolStripMenuItem_Click)
        Me.lineToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((85)))))), (CInt(((CByte((85)))))), (CInt(((CByte((85)))))))
        Me.lineToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.lineToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver
        Me.lineToolStripMenuItem.Name = "lineToolStripMenuItem"
        Me.lineToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.lineToolStripMenuItem.Text = "선"
        '  AddHandler Me.lineToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.LineToolStripMenuItem_Click)
        Me.pencilToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((85)))))), (CInt(((CByte((85)))))), (CInt(((CByte((85)))))))
        Me.pencilToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.pencilToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver
        Me.pencilToolStripMenuItem.Name = "pencilToolStripMenuItem"
        Me.pencilToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.pencilToolStripMenuItem.Text = "연필"
        ' AddHandler Me.pencilToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.PencilToolStripMenuItem_Click)
        Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aboutToolStripMenuItem})
        Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
        Me.helpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.helpToolStripMenuItem.Text = "도움말"
        Me.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((85)))))), (CInt(((CByte((85)))))), (CInt(((CByte((85)))))))
        Me.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.aboutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.aboutToolStripMenuItem.Text = "확인"
        ' AddHandler Me.aboutToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.aboutToolStripMenuItem_Click)
        Me.panel_Draw.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
        Me.panel_Draw.AutoScroll = True
        Me.panel_Draw.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((95)))))), (CInt(((CByte((95)))))), (CInt(((CByte((95)))))))
        Me.panel_Draw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_Draw.Controls.Add(Me.userControl_DrawBox1)
        Me.panel_Draw.Location = New System.Drawing.Point(0, 51)
        Me.panel_Draw.Name = "panel_Draw"
        Me.panel_Draw.Size = New System.Drawing.Size(642, 358)
        Me.panel_Draw.TabIndex = 3
        Me.saveFileDialog1.Filter = "DTF 파일 (*.DTF)|*.DTF"
        Me.saveFileDialog1.Title = "DTF 파일 저장하기"
        Me.openFileDialog1.Filter = "DTF 파일 (*.DTF)|*.DTF"
        Me.openFileDialog1.Title = "DTF 파일 불러오기"
        Me.userControl_DrawBox1.BackColor = System.Drawing.SystemColors.Window
        Me.userControl_DrawBox1.Location = New System.Drawing.Point(0, 0)
        Me.userControl_DrawBox1.Name = "userControl_DrawBox1"
        Me.userControl_DrawBox1.Size = New System.Drawing.Size(619, 334)
        Me.userControl_DrawBox1.TabIndex = 0
        Me.userControl_ToolBar1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
        Me.userControl_ToolBar1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((92)))))), (CInt(((CByte((92)))))), (CInt(((CByte((92)))))))
        Me.userControl_ToolBar1.Location = New System.Drawing.Point(0, 24)
        Me.userControl_ToolBar1.Margin = New System.Windows.Forms.Padding(0)
        Me.userControl_ToolBar1.Name = "userControl_ToolBar1"
        Me.userControl_ToolBar1.Size = New System.Drawing.Size(647, 29)
        Me.userControl_ToolBar1.TabIndex = 2
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((85)))))), (CInt(((CByte((85)))))), (CInt(((CByte((85)))))))
        Me.ClientSize = New System.Drawing.Size(642, 409)
        Me.Controls.Add(Me.panel_Draw)
        Me.Controls.Add(Me.userControl_ToolBar1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Name = "MainView"
        Me.Text = "DrawTool"
        ' AddHandler Me.FormClosing, New System.Windows.Forms.FormClosingEventHandler(AddressOf Me.MainView_FormClosing)
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.panel_Draw.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Private menuStrip1 As System.Windows.Forms.MenuStrip
    Private fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents newToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents openToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents saveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private editToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents UnselectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents DeleteAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private drawToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents pointerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents rectangleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ellipseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents lineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents pencilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private userControl_ToolBar1 As ToolBar
    Private panel_Draw As System.Windows.Forms.Panel
    Private userControl_DrawBox1 As DrawBox
    Private WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
