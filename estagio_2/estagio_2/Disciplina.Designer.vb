<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Disciplina
    Inherits System.Windows.Forms.Form

    Private saveData As DisciplinaSave

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
        'Me.Button3 = New System.Windows.Forms.Button()
        'Me.Button2 = New System.Windows.Forms.Button()
        'Me.Button1 = New System.Windows.Forms.Button()
        'Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        'Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        'Me.Label6 = New System.Winddows.Forms.Label()
        'Me.Label5 = New System.Windows.Forms.Label()
        'Me.TextBox2 = New System.Windows.Forms.TextBox()
        'Me.TextBox1 = New System.Windows.Forms.TextBox()
        'Me.Label4 = New System.Windows.Forms.Label()
        'Me.Label3 = New System.Windows.Forms.Label()
        'Me.Label2 = New System.Windows.Forms.Label()


        Dim nameLabel = New System.Windows.Forms.Label()
        Dim tabs = New System.Windows.Forms.TabControl()
        Me.SuspendLayout()



        'Label1
        '
        nameLabel.AutoSize = True
        nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        nameLabel.Location = New System.Drawing.Point(-3, -2)
        nameLabel.Name = saveData.nome
        nameLabel.Size = New System.Drawing.Size(64, 25)
        nameLabel.TabIndex = 13
        nameLabel.Text = saveData.nome
        Me.Controls.Add(nameLabel)


        tabs.Left = 5
        tabs.Top = 30
        tabs.Size = New Size(1000, 500)
        tabs.Font = New Font("aerial", 13, FontStyle.Regular)
        tabs.Alignment = TabAlignment.Top

        ' add a tab for each date
        For Each data As DataSave In saveData.datas

            Dim tab As New TabPage(data.data)
            tabs.TabPages.Add(tab)

            tab.Size = tab.Parent.Size

            ' create layout manager
            Dim tabela As New TableLayoutPanel()
            tab.Controls.Add(tabela)
            tabela.ColumnCount = 4
            tabela.RowCount = 2
            tabela.Size = tabela.Parent.Size
            tabela.AutoScroll = True

            Dim Label3 = New System.Windows.Forms.Label()
            Label3.Text = " Convocados :"
            Label3.AutoSize = True
            Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            tabela.Controls.Add(Label3, 3, 0)
            'convocados
            Dim convocados As New ListBox
            convocados.DataSource = data.convocados
            tabela.Controls.Add(convocados, 3, 1)

            Dim Label2 = New System.Windows.Forms.Label()
            Label2.Text = " Docentes :"
            Label2.AutoSize = True
            Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            tabela.Controls.Add(Label2, 2, 0)
            'docentes
            Dim docentes As New ListBox
            docentes.DataSource = data.docentes
            tabela.Controls.Add(docentes, 2, 1)

            Dim Label1 = New System.Windows.Forms.Label()
            Label1.Text = " Hora :"
            Label1.AutoSize = True
            Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            tabela.Controls.Add(Label1, 1, 0)
            'hora
            Dim hora As New TextBox
            hora.Text = data.hora
            tabela.Controls.Add(hora, 0, 1)

            Dim Label0 = New System.Windows.Forms.Label()
            Label0.Text = " Salas :"
            Label0.AutoSize = True
            Label0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            tabela.Controls.Add(Label0, 0, 0)
            'salas
            Dim salas As New ListBox
            salas.DataSource = data.salas
            tabela.Controls.Add(salas, 1, 1)

            'botao voltar para tras
            Me.Button1 = New System.Windows.Forms.Button()

            Me.Button1.Location = New System.Drawing.Point(520, 190)
            Me.Button1.Name = "button1"
            Me.Button1.Size = New System.Drawing.Size(75, 23)
            Me.Button1.TabIndex = 2
            Me.Button1.Text = "voltar"
            Me.Button1.UseVisualStyleBackColor = True

            Me.Controls.Add(Button1)

            '
            Me.Button2 = New System.Windows.Forms.Button()

            Me.Button2.Location = New System.Drawing.Point(30, 190)
            Me.Button2.Name = "button2"
            Me.Button2.Size = New System.Drawing.Size(35, 23)
            Me.Button2.TabIndex = 2
            Me.Button2.Text = "+"
            Me.Button2.UseVisualStyleBackColor = True

            Me.Controls.Add(Button2)

            '

            Me.Button3 = New System.Windows.Forms.Button()

            Me.Button3.Location = New System.Drawing.Point(120, 190)
            Me.Button3.Name = "button3"
            Me.Button3.Size = New System.Drawing.Size(100, 23)
            Me.Button3.TabIndex = 2
            Me.Button3.Text = "adicionar"
            Me.Button3.UseVisualStyleBackColor = True

            Me.Controls.Add(Button3)

            '
            Me.Button4 = New System.Windows.Forms.Button()

            Me.button4.Location = New System.Drawing.Point(290, 190)
            Me.Button4.Name = "button4"
            Me.Button4.Size = New System.Drawing.Size(35, 23)
            Me.Button4.TabIndex = 2
            Me.Button4.Text = "+"
            Me.Button4.UseVisualStyleBackColor = True

            Me.Controls.Add(Button4)

            '
            Me.Button5 = New System.Windows.Forms.Button()

            Me.button5.Location = New System.Drawing.Point(400, 190)
            Me.Button5.Name = "button5"
            Me.Button5.Size = New System.Drawing.Size(35, 23)
            Me.Button5.TabIndex = 2
            Me.Button5.Text = "+"
            Me.Button5.UseVisualStyleBackColor = True

            Me.Controls.Add(Button5)

        Next


        Me.Controls.Add(tabs)


        ''Button3
        ''
        'Me.Button3.BackColor = System.Drawing.Color.Silver
        'Me.Button3.Location = New System.Drawing.Point(196, 287)
        'Me.Button3.Name = "Button3"
        'Me.Button3.Size = New System.Drawing.Size(115, 23)
        'Me.Button3.TabIndex = 25
        'Me.Button3.Text = "Sair do programa"
        'Me.Button3.UseVisualStyleBackColor = False
        ''
        ''Button2
        ''
        'Me.Button2.BackColor = System.Drawing.Color.Chartreuse
        'Me.Button2.Location = New System.Drawing.Point(235, 198)
        'Me.Button2.Name = "Button2"
        'Me.Button2.Size = New System.Drawing.Size(76, 46)
        'Me.Button2.TabIndex = 24
        'Me.Button2.Text = "Guardar"
        'Me.Button2.UseVisualStyleBackColor = False
        ''
        ''Button1
        ''
        'Me.Button1.Location = New System.Drawing.Point(236, 250)
        'Me.Button1.Name = "Button1"
        'Me.Button1.Size = New System.Drawing.Size(75, 23)
        'Me.Button1.TabIndex = 23
        'Me.Button1.Text = "voltar"
        'Me.Button1.UseVisualStyleBackColor = True
        ''
        ''RichTextBox2
        ''
        'Me.RichTextBox2.Location = New System.Drawing.Point(142, 158)
        'Me.RichTextBox2.Name = "RichTextBox2"
        'Me.RichTextBox2.Size = New System.Drawing.Size(76, 115)
        'Me.RichTextBox2.TabIndex = 22
        'Me.RichTextBox2.Text = ""
        ''
        ''RichTextBox1
        ''
        'Me.RichTextBox1.Location = New System.Drawing.Point(12, 158)
        'Me.RichTextBox1.Name = "RichTextBox1"
        'Me.RichTextBox1.Size = New System.Drawing.Size(76, 115)
        'Me.RichTextBox1.TabIndex = 21
        'Me.RichTextBox1.Text = ""
        ''
        ''Label6
        ''
        'Me.Label6.AutoSize = True
        'Me.Label6.Location = New System.Drawing.Point(142, 132)
        'Me.Label6.Name = "Label6"
        'Me.Label6.Size = New System.Drawing.Size(76, 13)
        'Me.Label6.TabIndex = 20
        'Me.Label6.Text = "Convocados : "
        ''
        ''Label5
        ''
        'Me.Label5.AutoSize = True
        'Me.Label5.Location = New System.Drawing.Point(9, 132)
        'Me.Label5.Name = "Label5"
        'Me.Label5.Size = New System.Drawing.Size(62, 13)
        'Me.Label5.TabIndex = 19
        'Me.Label5.Text = "Docentes : "
        ''
        ''TextBox2
        ''
        'Me.TextBox2.Location = New System.Drawing.Point(45, 71)
        'Me.TextBox2.Name = "TextBox2"
        'Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        'Me.TextBox2.TabIndex = 18
        ''
        ''TextBox1
        ''
        'Me.TextBox1.Location = New System.Drawing.Point(45, 45)
        'Me.TextBox1.Name = "TextBox1"
        'Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        'Me.TextBox1.TabIndex = 17
        ''
        ''Label4
        ''
        'Me.Label4.AutoSize = True
        'Me.Label4.Location = New System.Drawing.Point(-6, 20)
        'Me.Label4.Name = "Label4"
        'Me.Label4.Size = New System.Drawing.Size(94, 13)
        'Me.Label4.TabIndex = 16
        'Me.Label4.Text = "-----------------------------"
        ''
        ''Label3
        ''
        'Me.Label3.AutoSize = True
        'Me.Label3.Location = New System.Drawing.Point(-3, 78)
        'Me.Label3.Name = "Label3"
        'Me.Label3.Size = New System.Drawing.Size(42, 13)
        'Me.Label3.TabIndex = 15
        'Me.Label3.Text = "Hora ->"
        ''
        ''Label2
        ''
        'Me.Label2.AutoSize = True
        'Me.Label2.Location = New System.Drawing.Point(-3, 52)
        'Me.Label2.Name = "Label2"
        'Me.Label2.Size = New System.Drawing.Size(45, 13)
        'Me.Label2.TabIndex = 14
        'Me.Label2.Text = "Salas ->"

        ''
        ''Data1
        ''
        'Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        'Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        'Me.ClientSize = New System.Drawing.Size(340, 333)
        'Me.Controls.Add(Me.Button3)
        'Me.Controls.Add(Me.Button2)
        'Me.Controls.Add(Me.Button1)
        'Me.Controls.Add(Me.RichTextBox2)
        'Me.Controls.Add(Me.RichTextBox1)
        'Me.Controls.Add(Me.Label6)
        'Me.Controls.Add(Me.Label5)
        'Me.Controls.Add(Me.TextBox2)
        'Me.Controls.Add(Me.TextBox1)
        'Me.Controls.Add(Me.Label4)
        'Me.Controls.Add(Me.Label3)
        'Me.Controls.Add(Me.Label2)

        'Me.Name = "Data1"
        'Me.Text = "Form3"
        'Me.ResumeLayout(False)
        'Me.PerformLayout()

    End Sub
    Friend WithEvents button5 As Button
    Friend WithEvents button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label


    Public Sub New(dataSave As DisciplinaSave)
        saveData = dataSave

        ' This call is required by the designer.
        InitializeComponent()

        Me.SuspendLayout()

        Using painel As New FlowLayoutPanel
            painel.AutoScroll = True
            painel.WrapContents = True
            Me.Controls.Add(painel)
        End Using


        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class