Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms

Public Class frmMinAnexar

    Inherits System.Windows.Forms.Form
    Dim Form1 As New frmManipulacaoTxt()
    Private _Caminho As String

    Dim drag As Boolean = False
    Dim mousex As Integer, mousey As Integer

    ' Public frmManipulacao As frmManipulacaoTxt

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



    Public Sub frmMinAnexar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Dim fluxoTexto As IO.StreamReader
        'Me.KeyPreview = True
        'MessageBox.Show(Caminho)


        If Not IO.File.Exists(Caminho) Then
            MessageBox.Show("Arquivo inválido!", "Salvar Como", MessageBoxButtons.OK)

        Else
            txtMin.Text = ""
            'fluxoTexto = New IO.StreamReader(Caminho)
            ' txtTexto.Text = fluxoTexto.ReadToEnd
            ' fluxoTexto.Close()
        End If
    End Sub




    Public Sub SalvarAnexo(sender As Object, e As KeyEventArgs) Handles txtMin.KeyUp
        ' If My.Computer.Keyboard.CtrlKeyDown AndAlso e.KeyCode = Keys.S Then
        If e.KeyCode = Keys.Enter Then
            'Form1.btnAnexarLinha.PerformClick()

            Dim fluxoTexto As IO.StreamWriter
            ' Dim linhaTexto As String

            If IO.File.Exists(Caminho) Then
                fluxoTexto = New IO.StreamWriter(Caminho, True)
                fluxoTexto.WriteLine(txtMin.Text)
                fluxoTexto.Close()
                txtMin.Text = ""
                'MessageBox.Show("Dados Anexados!")
            Else
                MessageBox.Show("Arquivo inexistente!")
            End If
        End If
    End Sub


    Public Sub lblVoltar_Click(sender As Object, e As EventArgs) Handles lblVoltar.Click

        'MessageBox.Show(Form1.cbMin.CheckState)

        If Form1.cbMin.Checked = True Then

            Form1.cbMin.Checked = False
            'Form1.Show()
            Me.Close()
        End If
        Me.Close()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub





    'Funções para mover a janela

#If coment Then

    Structure MoveForm
        Dim X As Integer
        Dim Y As Integer
    End Structure



    Dim Ponto As New Point

        Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        If e.Button <> MouseButtons.Left Then Exit Sub

        Ponto.X = Me.Left - MousePosition.X
            Ponto.Y = Me.Top - MousePosition.Y

        End Sub

        Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If e.Button <> MouseButtons.Left Then Exit Sub

        Me.Left = Ponto.X + MousePosition.X
            Me.Top = Ponto.Y + MousePosition.Y

        End Sub

#End If




#If coment Then
#Region " Move Form "
    ' [ Move Form ]
    '
    ' // By Elektro 

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

#End Region


#End If


    Private Sub frmMinAnexar_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown, TableLayoutPanel1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frmMinAnexar_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, TableLayoutPanel1.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mousex
            Me.Top = Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub frmMinAnexar_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseUp, TableLayoutPanel1.MouseUp
        drag = False
    End Sub






End Class