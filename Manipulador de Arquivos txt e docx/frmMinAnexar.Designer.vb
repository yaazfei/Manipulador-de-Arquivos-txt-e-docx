<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMinAnexar
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblVoltar = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackgroundImage = Global.Manipulador_de_Arquivos_txt_e_docx.My.Resources.Resources.atom1
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.886436!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.11356!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtMin, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(596, 37)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txtMin
        '
        Me.txtMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtMin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMin.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.txtMin.ForeColor = System.Drawing.SystemColors.Window
        Me.txtMin.Location = New System.Drawing.Point(52, 5)
        Me.txtMin.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(539, 16)
        Me.txtMin.TabIndex = 6
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel2.Controls.Add(Me.lblVoltar)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(41, 31)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'lblVoltar
        '
        Me.lblVoltar.AutoSize = True
        Me.lblVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblVoltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblVoltar.Location = New System.Drawing.Point(3, 2)
        Me.lblVoltar.Name = "lblVoltar"
        Me.lblVoltar.Size = New System.Drawing.Size(19, 20)
        Me.lblVoltar.TabIndex = 0
        Me.lblVoltar.Text = ">"
        '
        'frmMinAnexar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Manipulador_de_Arquivos_txt_e_docx.My.Resources.Resources.Nova_Imagem_de_Bitmap
        Me.ClientSize = New System.Drawing.Size(596, 37)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(90, 570)
        Me.Name = "frmMinAnexar"
        Me.Opacity = 0.4R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "MinAnexar"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents lblVoltar As Label
    Friend WithEvents txtMin As TextBox
End Class
