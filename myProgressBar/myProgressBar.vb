Imports System.ComponentModel

Public Class myProgressBar
    Private _p As Integer = 0
    Private _t As String = ""

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Description("Set the value of progress"), Browsable(True)>
    Public Property myValue As Integer
        Get
            Return _p
        End Get
        Set(value As Integer)
            _p = value

            pic_Frame.Refresh()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Description("Set the text of the control"), Browsable(True)>
    Public Property myText As String
        Get
            Return _t
        End Get
        Set(value As String)
            _t = value

            pic_Frame.Refresh()
        End Set
    End Property

    Private Sub pic_Frame_Paint(sender As Object, e As PaintEventArgs) Handles pic_Frame.Paint
        e.Graphics.Clear(pic_Frame.BackColor)
        e.Graphics.DrawRectangle(New Pen(Brushes.Gray, 1), 0, 0, pic_Frame.ClientSize.Width - 1, pic_Frame.ClientSize.Height - 1)

        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        Dim sf As New StringFormat()
        sf.Alignment = StringAlignment.Near
        sf.LineAlignment = StringAlignment.Center

        Dim color As Brush

        Select Case myValue
            Case < 10
                color = Brushes.Red
            Case < 20
                color = Brushes.Orange
            Case Else
                color = Brushes.LightGreen
        End Select

        Dim width As Integer
        width = pic_Frame.ClientSize.Width / 100 * myValue

        e.Graphics.FillRectangle(color, 0, 0, width, pic_Frame.ClientSize.Height)
        e.Graphics.DrawRectangle(New Pen(Brushes.Gray, 1), 0, 0, pic_Frame.ClientSize.Width - 1, pic_Frame.ClientSize.Height - 1)
        e.Graphics.DrawString(myText, Me.Font, Brushes.Black, pic_Frame.ClientRectangle, sf)
    End Sub
End Class
