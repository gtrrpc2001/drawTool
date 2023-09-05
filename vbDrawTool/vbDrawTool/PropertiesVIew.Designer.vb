<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PropertiesVIew
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.button_Cancel = New System.Windows.Forms.Button()
        Me.button_Save = New System.Windows.Forms.Button()
        Me.combobox_PenWidth = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.button_SelectColor = New System.Windows.Forms.Button()
        Me.label_Color = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button_SelectBackgroudColor = New System.Windows.Forms.Button()
        Me.label_BackgroundColor = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.colorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'button_Cancel
        '
        Me.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_Cancel.Location = New System.Drawing.Point(153, 119)
        Me.button_Cancel.Name = "button_Cancel"
        Me.button_Cancel.Size = New System.Drawing.Size(93, 25)
        Me.button_Cancel.TabIndex = 15
        Me.button_Cancel.Text = "취 소"
        Me.button_Cancel.UseVisualStyleBackColor = True
        '
        'button_Save
        '
        Me.button_Save.BackColor = System.Drawing.Color.Transparent
        Me.button_Save.Location = New System.Drawing.Point(38, 119)
        Me.button_Save.Name = "button_Save"
        Me.button_Save.Size = New System.Drawing.Size(93, 25)
        Me.button_Save.TabIndex = 14
        Me.button_Save.Text = "저 장"
        Me.button_Save.UseVisualStyleBackColor = False
        '
        'combobox_PenWidth
        '
        Me.combobox_PenWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_PenWidth.FormattingEnabled = True
        Me.combobox_PenWidth.Location = New System.Drawing.Point(88, 76)
        Me.combobox_PenWidth.Name = "combobox_PenWidth"
        Me.combobox_PenWidth.Size = New System.Drawing.Size(82, 20)
        Me.combobox_PenWidth.TabIndex = 13
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(9, 79)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(55, 12)
        Me.label2.TabIndex = 11
        Me.label2.Text = "Pen 두께"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'button_SelectColor
        '
        Me.button_SelectColor.Location = New System.Drawing.Point(185, 12)
        Me.button_SelectColor.Name = "button_SelectColor"
        Me.button_SelectColor.Size = New System.Drawing.Size(38, 25)
        Me.button_SelectColor.TabIndex = 10
        Me.button_SelectColor.Text = "..."
        Me.button_SelectColor.UseVisualStyleBackColor = True
        '
        'label_Color
        '
        Me.label_Color.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label_Color.Location = New System.Drawing.Point(88, 13)
        Me.label_Color.Name = "label_Color"
        Me.label_Color.Size = New System.Drawing.Size(82, 22)
        Me.label_Color.TabIndex = 9
        Me.label_Color.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(7, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(57, 12)
        Me.label1.TabIndex = 8
        Me.label1.Text = "테두리 색"
        '
        'button_SelectBackgroudColor
        '
        Me.button_SelectBackgroudColor.Location = New System.Drawing.Point(185, 45)
        Me.button_SelectBackgroudColor.Name = "button_SelectBackgroudColor"
        Me.button_SelectBackgroudColor.Size = New System.Drawing.Size(38, 25)
        Me.button_SelectBackgroudColor.TabIndex = 18
        Me.button_SelectBackgroudColor.Text = "..."
        Me.button_SelectBackgroudColor.UseVisualStyleBackColor = True
        '
        'label_BackgroundColor
        '
        Me.label_BackgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label_BackgroundColor.Location = New System.Drawing.Point(88, 45)
        Me.label_BackgroundColor.Name = "label_BackgroundColor"
        Me.label_BackgroundColor.Size = New System.Drawing.Size(82, 22)
        Me.label_BackgroundColor.TabIndex = 17
        Me.label_BackgroundColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(19, 50)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(45, 12)
        Me.label4.TabIndex = 16
        Me.label4.Text = "배경 색"
        '
        'PropertiesVIew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(278, 152)
        Me.Controls.Add(Me.button_SelectBackgroudColor)
        Me.Controls.Add(Me.label_BackgroundColor)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.button_Cancel)
        Me.Controls.Add(Me.button_Save)
        Me.Controls.Add(Me.combobox_PenWidth)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.button_SelectColor)
        Me.Controls.Add(Me.label_Color)
        Me.Controls.Add(Me.label1)
        Me.Name = "PropertiesVIew"
        Me.Text = "속성"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents button_Cancel As System.Windows.Forms.Button
    Private WithEvents button_Save As System.Windows.Forms.Button
    Private combobox_PenWidth As System.Windows.Forms.ComboBox
    Private label2 As System.Windows.Forms.Label
    Private WithEvents button_SelectColor As System.Windows.Forms.Button
    Private label_Color As System.Windows.Forms.Label
    Private label1 As System.Windows.Forms.Label
    Private WithEvents button_SelectBackgroudColor As System.Windows.Forms.Button
    Private label_BackgroundColor As System.Windows.Forms.Label
    Private label4 As System.Windows.Forms.Label
    Private colorDialog1 As System.Windows.Forms.ColorDialog
End Class
