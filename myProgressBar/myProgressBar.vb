Imports System.ComponentModel

Public Class myProgressBar
    Private _p As Integer
    Private _t As String
    Private _f As Font
    Private _c As Color

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

    Public Shadows Property Font As Font
        Get
            Return _f
        End Get
        Set(value As Font)
            _f = value

            pic_Frame.Refresh()
        End Set
    End Property

    Public Shadows Property ForeColor As Color
        Get
            Return _c
        End Get
        Set(value As Color)
            _c = value

            pic_Frame.Refresh()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Description("Set color of the different stacks"), Browsable(True)>
    Public Property stacks As List(Of Stack)

    Public Sub New()
        stacks = New List(Of Stack)
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        myText = ""
        myValue = 0
        Font = New Font("Microsoft Sans Serif", 8.25)
        ForeColor = Color.Black

        'stacks.add(New Stack(10, Color.Red))
        'stacks.Add(New Stack(20, Color.Orange))
        'stacks.Add(New Stack(100, Color.Green))
    End Sub


    Private Sub pic_Frame_Paint(sender As Object, e As PaintEventArgs) Handles pic_Frame.Paint
        e.Graphics.Clear(pic_Frame.BackColor)
        e.Graphics.DrawRectangle(New Pen(Brushes.Gray, 1), 0, 0, pic_Frame.ClientSize.Width - 1, pic_Frame.ClientSize.Height - 1)

        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        Dim sf As New StringFormat()
        sf.Alignment = StringAlignment.Near
        sf.LineAlignment = StringAlignment.Center

        Dim color As Brush = Brushes.Green

        'stacks = stacks.OrderBy(Function(x) x.MaxValue).ToList()
        stacks.Sort(Function(x, y) x.MaxValue.CompareTo(y.MaxValue))

        For Each stack In stacks
            If myValue <= stack.MaxValue Then
                color = New SolidBrush(stack.Color)
                Exit For
            End If
        Next

        Dim width As Integer
        width = pic_Frame.ClientSize.Width / 100 * myValue

        e.Graphics.FillRectangle(color, 0, 0, width, pic_Frame.ClientSize.Height)
        e.Graphics.DrawRectangle(New Pen(Brushes.Gray, 1), 0, 0, pic_Frame.ClientSize.Width - 1, pic_Frame.ClientSize.Height - 1)

        Dim b As New SolidBrush(ForeColor)
        e.Graphics.DrawString(Me.myText, Me.Font, b, pic_Frame.ClientRectangle, sf)
    End Sub

    Private Sub pic_Frame_Resize(sender As Object, e As EventArgs) Handles pic_Frame.Resize
        pic_Frame.Refresh()
    End Sub

    ' TODO create Handler for RESIZE
End Class

Public Class Stack
    Private _mv As Integer
    Private _c As Color

    Public Property MaxValue As Integer
        Get
            Return _mv
        End Get
        Set(value As Integer)
            _mv = value
        End Set
    End Property

    Public Property Color As Color
        Get
            Return _c
        End Get
        Set(value As Color)
            _c = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(INmv As Integer, INc As Color)
        Me.MaxValue = INmv
        Me.Color = INc
    End Sub

    Public Function compareTo(INstack As Stack) As Integer
        Select Case Me.MaxValue - INstack.MaxValue
            Case < 0
                Return -1
            Case = 0
                Return 0
            Case > 0
                Return 1
        End Select

        Return 0
    End Function
End Class