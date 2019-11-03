<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class myProgressBar
    Inherits System.Windows.Forms.UserControl

    'UserControl1 überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pic_Frame = New System.Windows.Forms.PictureBox()
        CType(Me.pic_Frame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_Frame
        '
        Me.pic_Frame.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_Frame.Location = New System.Drawing.Point(0, 0)
        Me.pic_Frame.Name = "pic_Frame"
        Me.pic_Frame.Size = New System.Drawing.Size(100, 20)
        Me.pic_Frame.TabIndex = 0
        Me.pic_Frame.TabStop = False
        '
        'myProgressBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pic_Frame)
        Me.MinimumSize = New System.Drawing.Size(100, 20)
        Me.Name = "myProgressBar"
        Me.Size = New System.Drawing.Size(100, 20)
        CType(Me.pic_Frame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pic_Frame As PictureBox
End Class
