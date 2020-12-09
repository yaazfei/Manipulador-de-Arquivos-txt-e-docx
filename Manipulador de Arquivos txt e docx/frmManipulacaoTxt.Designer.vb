<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManipulacaoTxt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtArquivo = New System.Windows.Forms.TextBox()
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.btnAbrirParaAnexar = New System.Windows.Forms.Button()
        Me.btnAnexarLinha = New System.Windows.Forms.Button()
        Me.btnFinal = New System.Windows.Forms.Button()
        Me.cbMin = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnLer = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.lblCaracteres = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.ofdAbrirArquivo = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manipular arquivos .txt"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtArquivo, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTexto, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel4, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 229.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(361, 362)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'txtArquivo
        '
        Me.txtArquivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtArquivo.Location = New System.Drawing.Point(15, 54)
        Me.txtArquivo.Margin = New System.Windows.Forms.Padding(15, 10, 10, 5)
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.Size = New System.Drawing.Size(259, 20)
        Me.txtArquivo.TabIndex = 4
        '
        'txtTexto
        '
        Me.txtTexto.BackColor = System.Drawing.SystemColors.Window
        Me.txtTexto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTexto.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTexto.Location = New System.Drawing.Point(15, 94)
        Me.txtTexto.Margin = New System.Windows.Forms.Padding(15, 10, 10, 5)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTexto.Size = New System.Drawing.Size(259, 214)
        Me.txtTexto.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGravar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAbrirParaAnexar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAnexarLinha)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnFinal)
        Me.FlowLayoutPanel1.Controls.Add(Me.cbMin)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(287, 87)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(71, 223)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'btnGravar
        '
        Me.btnGravar.AutoSize = True
        Me.btnGravar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGravar.Location = New System.Drawing.Point(3, 3)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(60, 27)
        Me.btnGravar.TabIndex = 1
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'btnAbrirParaAnexar
        '
        Me.btnAbrirParaAnexar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirParaAnexar.Location = New System.Drawing.Point(3, 36)
        Me.btnAbrirParaAnexar.Name = "btnAbrirParaAnexar"
        Me.btnAbrirParaAnexar.Size = New System.Drawing.Size(60, 60)
        Me.btnAbrirParaAnexar.TabIndex = 4
        Me.btnAbrirParaAnexar.Text = "Abrir para Anexar"
        Me.btnAbrirParaAnexar.UseVisualStyleBackColor = True
        '
        'btnAnexarLinha
        '
        Me.btnAnexarLinha.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnexarLinha.Location = New System.Drawing.Point(3, 102)
        Me.btnAnexarLinha.Name = "btnAnexarLinha"
        Me.btnAnexarLinha.Size = New System.Drawing.Size(60, 60)
        Me.btnAnexarLinha.TabIndex = 3
        Me.btnAnexarLinha.Text = "Salvar em Anexo"
        Me.btnAnexarLinha.UseVisualStyleBackColor = True
        '
        'btnFinal
        '
        Me.btnFinal.AutoSize = True
        Me.btnFinal.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinal.Location = New System.Drawing.Point(3, 168)
        Me.btnFinal.Name = "btnFinal"
        Me.btnFinal.Size = New System.Drawing.Size(60, 27)
        Me.btnFinal.TabIndex = 7
        Me.btnFinal.Text = "Final"
        Me.btnFinal.UseVisualStyleBackColor = True
        '
        'cbMin
        '
        Me.cbMin.AutoSize = True
        Me.cbMin.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cbMin.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMin.Location = New System.Drawing.Point(3, 201)
        Me.cbMin.Name = "cbMin"
        Me.cbMin.Size = New System.Drawing.Size(66, 17)
        Me.cbMin.TabIndex = 6
        Me.cbMin.Text = "Minimizar"
        Me.cbMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbMin.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.btnLer)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(287, 47)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(71, 34)
        Me.FlowLayoutPanel3.TabIndex = 6
        '
        'btnLer
        '
        Me.btnLer.AutoSize = True
        Me.btnLer.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLer.Location = New System.Drawing.Point(3, 3)
        Me.btnLer.Name = "btnLer"
        Me.btnLer.Size = New System.Drawing.Size(60, 27)
        Me.btnLer.TabIndex = 0
        Me.btnLer.Text = "Ler"
        Me.btnLer.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AllowDrop = True
        Me.FlowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.FlowLayoutPanel2.Controls.Add(Me.btnLimpar)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnAtualizar)
        Me.FlowLayoutPanel2.Controls.Add(Me.lblCaracteres)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 316)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(278, 36)
        Me.FlowLayoutPanel2.TabIndex = 3
        '
        'btnLimpar
        '
        Me.btnLimpar.AutoSize = True
        Me.btnLimpar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.Location = New System.Drawing.Point(215, 3)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(60, 27)
        Me.btnLimpar.TabIndex = 2
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnAtualizar
        '
        Me.btnAtualizar.AutoSize = True
        Me.btnAtualizar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtualizar.Location = New System.Drawing.Point(139, 3)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(70, 27)
        Me.btnAtualizar.TabIndex = 5
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'lblCaracteres
        '
        Me.lblCaracteres.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaracteres.Location = New System.Drawing.Point(37, 0)
        Me.lblCaracteres.Name = "lblCaracteres"
        Me.lblCaracteres.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCaracteres.Size = New System.Drawing.Size(96, 30)
        Me.lblCaracteres.TabIndex = 0
        Me.lblCaracteres.Text = "Caracteres:"
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.AllowDrop = True
        Me.FlowLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.FlowLayoutPanel4.Controls.Add(Me.btnSair)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(287, 316)
        Me.FlowLayoutPanel4.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(71, 36)
        Me.FlowLayoutPanel4.TabIndex = 7
        '
        'btnSair
        '
        Me.btnSair.AutoSize = True
        Me.btnSair.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.Location = New System.Drawing.Point(3, 3)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(60, 27)
        Me.btnSair.TabIndex = 5
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'ofdAbrirArquivo
        '
        Me.ofdAbrirArquivo.FileName = "ofdAbrirArquivo"
        '
        'frmManipulacaoTxt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 362)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.KeyPreview = True
        Me.Name = "frmManipulacaoTxt"
        Me.Text = "Manipulação de .txt"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnLer As Button
    Friend WithEvents btnGravar As Button
    Friend WithEvents txtTexto As TextBox
    Friend WithEvents ofdAbrirArquivo As OpenFileDialog
    Friend WithEvents btnAnexarLinha As Button
    Friend WithEvents txtArquivo As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnAbrirParaAnexar As Button
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents cbMin As CheckBox
    Friend WithEvents lblCaracteres As Label
    Friend WithEvents btnFinal As Button
End Class
