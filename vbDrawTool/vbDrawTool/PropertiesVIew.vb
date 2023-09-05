Imports System.Globalization

Public Class PropertiesVIew
    Private Const maxWidth As Integer = 10
    Public Property PenWidth As Integer
    Public Property Color As Color
    Public Property BackGroundColor As Color
    Public Sub New()
    End Sub
    Sub New(color As Color, backgroundColor As Color, Optional penWidth As Integer = 1)
        InitializeComponent()
        InitControls()
        label_Color.BackColor = color
        label_BackgroundColor.BackColor = backgroundColor
        combobox_PenWidth.Text = penWidth.ToString()
    End Sub
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles button_Save.Click
        Color = label_Color.BackColor
        MainController.Instance.LastUsedColor = Color
        BackGroundColor = label_BackgroundColor.BackColor
        MainController.Instance.LastUesdBackgoroundColor = BackGroundColor
        PenWidth = Int32.Parse(combobox_PenWidth.Text)
        MainController.Instance.LastUsedPenWidth = PenWidth
        Me.DialogResult = DialogResult.OK
    End Sub
    Private Sub Button_SelectColor_Click(sender As Object, e As EventArgs) Handles button_SelectColor.Click
        colorDialog1.Color = label_Color.BackColor
        If colorDialog1.ShowDialog(Me) = DialogResult.OK Then
            label_Color.BackColor = colorDialog1.Color
        End If
    End Sub
    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles button_Cancel.Click
        colorDialog1.Color = label_BackgroundColor.BackColor
        If colorDialog1.ShowDialog(Me) = DialogResult.OK Then
            label_BackgroundColor.BackColor = colorDialog1.Color
        End If
    End Sub

    Private Sub InitControls()
        For i = 1 To maxWidth
            combobox_PenWidth.Items.Add(i.ToString(CultureInfo.InvariantCulture))
        Next
    End Sub
End Class