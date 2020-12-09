Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing


Public Class frmManipulacaoTxt
    Inherits System.Windows.Forms.Form
    'Dim frmMinAnexar = frmMinAnexar()


#If coment Then
    Private _Caminho As String

    Public Property Caminho() As String
        Set(ByVal value As String)
            _Caminho = value
        End Set
        Get
            Return _Caminho
        End Get
    End Property




    Sub New(ByVal str As String)
        InitializeComponent()


        Caminho = str
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub frmManipulacaoTxt_Load(sender As Object, e As EventArgs) Handles Me.Load
        MessageBox.Show(Caminho)

        If Not IO.File.Exists(Caminho) Then
            MessageBox.Show("Arquivo inválido!", "Salvar Como", MessageBoxButtons.OK)

        Else
            txtArquivo.Text = Caminho
        End If
    End Sub
#End If

    'Abaixo são os códigos para liberar hotkeys no form
    Public Sub SalvarAnexo(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If My.Computer.Keyboard.CtrlKeyDown AndAlso e.KeyCode = Keys.S Then
            btnAnexarLinha.PerformClick()
        End If
    End Sub


#If coment Then
    Private Sub txtTexto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTexto.KeyPress

        Dim ctrlKey As Boolean
        Dim s As Boolean

        ctrlKey = Keys.ControlKey
        S = Keys.S

        If ctrlKey And s = True Then
            MessageBox.Show("Hotkey ctrl+S foi pressionada")

        End If
    End Sub



#End If


#If coment Then

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Long) As Integer

    Private Sub ManipulacaoTxt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.enabled = True
        Timer1.interval = 1

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim ctrlKey As Boolean
        Dim s As Boolean

        ctrlKey = GetAsyncKeyState(Keys.ControlKey)
        s = GetAsyncKeyState(Keys.S)

        If ctrlKey And s = True Then

            MessageBox.Show("Hotkey ctrl+S foi pressionada")

        End If

    End Sub
    
#End If

#If coment Then
        Me.KeyPreview = True
    End Sub

    Private Sub ManipulacaoTxt_KeyDown(sender As Object, e As System.Windows.Form.KeyEventArgs) Handles txtTexto.KeyDown
        If e.Ctrl And e.KeyCode.ToString = "S" Then
            'When the user presses both the 'CTRL' key and 'S' key,
            'KeyPreview is set to False, and a message apperas
            'This message is onlu displayed when KeyPreview is set to True.
            Me.KeyPreview = False
            MessageBox.Show("KeyPreview funcionou do form")
        End If




    End Sub

#End If


    Public Sub btnLer_Click(sender As Object, e As EventArgs) Handles btnLer.Click

        Dim caminho As DialogResult
        Dim Arquivo As String
        Dim fluxoTexto As IO.StreamReader

        ofdAbrirArquivo.FileName = "Nome Arquivo"
        ofdAbrirArquivo.Filter = "Arquivos Textos(*.txt)|*.txt"
        caminho = ofdAbrirArquivo.ShowDialog
        Arquivo = ofdAbrirArquivo.FileName
        'MessageBox.Show(Arquivo)

        If Not IO.File.Exists(Arquivo) Then
            MessageBox.Show("Arquivo inválido!", "Salvar Como", MessageBoxButtons.OK)

        Else
            fluxoTexto = New IO.StreamReader(Arquivo)
            txtTexto.Text = fluxoTexto.ReadToEnd
            txtArquivo.Text = ofdAbrirArquivo.FileName
            fluxoTexto.Close()
            ' Else
            '     MessageBox.Show("Escolha um Arquivo!")
        End If
    End Sub



#If coment Then

        If Arquivo = Nothing Then
            MessageBox.Show("Arquivo inválido!", "Salvar Como", MessageBoxButtons.OK)
            Close()
        Else
            fluxoTexto = New IO.StreamReader(Arquivo)
            txtTexto.Text = fluxoTexto.ReadToEnd
            txtArquivo.Text = ofdAbrirArquivo.FileName
            fluxoTexto.Close()

        End If
    End Sub
#End If


    Public Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        'Feito a partir do substituir arquivo
        Dim fluxoTexto As IO.StreamWriter
        ' Dim linhaTexto As String
        ' Dim salvarNovo As SaveFileDialog = New SaveFileDialog()
        Dim caminho As DialogResult
        Dim Arquivo As String

        If IO.File.Exists(txtArquivo.Text) Then
            If MessageBox.Show("Tem certeza que deseja sobreescrever o arquivo?", "My Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                fluxoTexto = New IO.StreamWriter(txtArquivo.Text)
                fluxoTexto.WriteLine(txtTexto.Text)
                fluxoTexto.Close()
                MessageBox.Show("Dados Salvos!")
            End If

        ElseIf MessageBox.Show("Arquivo inexistente! Deseja criar um novo arquivo?", "My Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ofdAbrirArquivo.CheckFileExists = False
            ofdAbrirArquivo.FileName = "Novo arquivo de texto"
            ofdAbrirArquivo.Filter = "Arquivo Texto(*.txt)|*.txt"
            caminho = ofdAbrirArquivo.ShowDialog
            Arquivo = ofdAbrirArquivo.FileName

            If Not IO.File.Exists(txtArquivo.Text) Then

                fluxoTexto = New IO.StreamWriter(Arquivo)
                fluxoTexto.Write(txtTexto.Text)
                fluxoTexto.Close()
                MessageBox.Show("Salvo em novo arquivo!")
            Else
                Close()

            End If
        End If
    End Sub



    Public Sub btnAnexarLinha_Click(sender As Object, e As EventArgs) Handles btnAnexarLinha.Click
        Dim fluxoTexto As IO.StreamWriter
        ' Dim linhaTexto As String

        If IO.File.Exists(txtArquivo.Text) Then
            fluxoTexto = New IO.StreamWriter(txtArquivo.Text, True)
            fluxoTexto.WriteLine(txtTexto.Text)
            fluxoTexto.Close()
            txtTexto.Text = ""
            'MessageBox.Show("Dados Anexados!")
        Else
            MessageBox.Show("Arquivo inexistente!")
        End If




    End Sub

    Public Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        If MessageBox.Show(" Tem certeza que quer limpar tudo?", "My Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            txtTexto.Text = ""
        End If

    End Sub

    Public Sub btnAbrirParaAnexar_Click(sender As Object, e As EventArgs) Handles btnAbrirParaAnexar.Click

        Dim caminho As DialogResult
        Dim Arquivo As String
        Dim fluxoTexto As IO.StreamReader

        ofdAbrirArquivo.FileName = "Nome Arquivo"
        ofdAbrirArquivo.Filter = "Arquivos Textos(*.txt)|*.txt"
        caminho = ofdAbrirArquivo.ShowDialog
        Arquivo = ofdAbrirArquivo.FileName

        If Not IO.File.Exists(Arquivo) Then
            MessageBox.Show("Arquivo inválido!", "Salvar Como", MessageBoxButtons.OK)

        Else
            txtTexto.Text = ""
            fluxoTexto = New IO.StreamReader(Arquivo)
            ' txtTexto.Text = fluxoTexto.ReadToEnd
            txtArquivo.Text = ofdAbrirArquivo.FileName
            fluxoTexto.Close()
        End If

    End Sub


    Public Sub btnSair_Click_1(sender As Object, e As EventArgs) Handles btnSair.Click
        If MessageBox.Show(" Tem certeza que quer sair? Não se esqueça de salvar antes!", "My Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub


    Public Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        Dim fluxoTexto As IO.StreamReader

        If IO.File.Exists(txtArquivo.Text) Then
            fluxoTexto = New IO.StreamReader(txtArquivo.Text)

            While Not fluxoTexto.EndOfStream
                ' fluxoTexto = New IO.StreamReader(Arquivo)
                txtTexto.Text = fluxoTexto.ReadToEnd

            End While
            lblCaracteres.Text = "Caracteres: " & Len(txtTexto.Text)
            'Dim numCaracteres As Integer
            'numCaracteres = Len(txtTexto.Text)
            'lblCaracteres.Text = ("Caracteres:" + numCaracteres)
            fluxoTexto.Close()
        Else
            MessageBox.Show("Arquivo inexistente!")
        End If

    End Sub


    Public Sub cbMin_CheckedChanged(sender As Object, e As EventArgs) Handles cbMin.CheckedChanged
        'frmMinAnexar = New frmMinAnexar
        If cbMin.Checked = True Then


            If Not txtArquivo.Text = Nothing Then

                Dim Form2 As New frmMinAnexar(txtArquivo.Text)

                Form2.Caminho = txtArquivo.Text
                Form2.Show()
                'Me.Hide()

            Else
                MessageBox.Show("Escolha um arquivo para anexo antes!")
                cbMin.Checked = False
            End If

        ElseIf cbMin.Checked = False Then
            Dim Form2 As New frmMinAnexar(txtArquivo.Text)
            'Form2.lblVoltar_Click()
            'Form2.Close()
        End If
    End Sub


    Private Sub btnFinal_Click(sender As Object, e As EventArgs) Handles btnFinal.Click
        txtTexto.SelectionStart = txtTexto.TextLength
        txtTexto.ScrollToCaret()

    End Sub
End Class
