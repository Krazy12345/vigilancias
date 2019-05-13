<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaginaInicia
    Inherits System.Windows.Forms.Form

    ' save data
    Private dataSave As DisciplinaSave()


    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()

        Me.SuspendLayout()

        Dim painel As New FlowLayoutPanel
        painel.AutoScroll = True
        painel.WrapContents = True
        Me.Controls.Add(painel)


        '
        'Label3
        '
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Página Inicial"



        For Each disc As DisciplinaSave In Me.dataSave
            Dim botao As New System.Windows.Forms.Button()
            botao.Name = disc.nome
            botao.Text = disc.nome

            AddHandler botao.Click, AddressOf BasicHandler

            painel.Controls.Add(botao)
        Next


        'Me.Button3.Location = New System.Drawing.Point(24, 104)
        'Me.Button3.Name = "Button3"
        'Me.Button3.Size = New System.Drawing.Size(75, 23)
        'Me.Button3.TabIndex = 6
        'Me.Button3.Text = "Disciplina 3"
        'Me.Button3.UseVisualStyleBackColor = True

        '
        'PaginaInicia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(259, 228)
        Me.Controls.Add(Me.Label3)
        Me.Name = "PaginaInicia"
        Me.Text = "v"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend Sub BasicHandler(sender As Object, e As EventArgs)
        Dim selectedBtn As Button = sender
        Dim clickedName As String = selectedBtn.Name





        For Each disc As DisciplinaSave In Me.dataSave
            If disc.nome = clickedName Then
                Dim disciplina As New Disciplina(disc)
                Me.Hide()
                disciplina.Show()
            End If

        Next


    End Sub

    Public Sub New(dataSave As DisciplinaSave())
        Me.dataSave = dataSave

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
