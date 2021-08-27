Public Class Form1

    ' variável para salvar os inputs numéricos
    Dim numInput As Integer

    ' variável para salvar a operação escolhida
    Dim operacao As String

    'configurando os números de cada botão
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtResultado.Text = txtResultado.Text & 0
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtResultado.Text = txtResultado.Text & 1
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtResultado.Text = txtResultado.Text & 2
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtResultado.Text = txtResultado.Text & 3
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtResultado.Text = txtResultado.Text & 4
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtResultado.Text = txtResultado.Text & 5
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtResultado.Text = txtResultado.Text & 6
    End Sub

    Private Sub bnt7_Click(sender As Object, e As EventArgs) Handles bnt7.Click
        txtResultado.Text = txtResultado.Text & 7
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtResultado.Text = txtResultado.Text & 8
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtResultado.Text = txtResultado.Text & 9
    End Sub

    'configurando os números de cada botão
    Private Sub btnSomar_Click(sender As Object, e As EventArgs) Handles btnSomar.Click
        operacao = "somar"
        numInput = txtResultado.Text
        txtResultado.Text = Nothing
    End Sub

    Private Sub btnSubtrair_Click(sender As Object, e As EventArgs) Handles btnSubtrair.Click
        operacao = "subtrair"
        numInput = txtResultado.Text
        txtResultado.Text = Nothing
    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        operacao = "multiplicar"
        numInput = txtResultado.Text
        txtResultado.Text = Nothing
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        operacao = "dividir"
        numInput = txtResultado.Text
        txtResultado.Text = Nothing
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        If (operacao = "somar") Then
            txtResultado.Text = numInput + txtResultado.Text
        ElseIf (operacao = "subtrair") Then
            txtResultado.Text = numInput - txtResultado.Text
        ElseIf (operacao = "multiplicar") Then
            txtResultado.Text = numInput * txtResultado.Text
        ElseIf (operacao = "dividir") Then
            If (txtResultado.Text = 0) Then
                MessageBox.Show("Não é possível dividir o valor por zero. Por favor, refaça seu cálculo.")
                txtResultado.Text = ""
            ElseIf (Not txtResultado.Text = 0) Then
                txtResultado.Text = numInput / txtResultado.Text
            End If
        End If
    End Sub
    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtResultado.Text = Nothing
        numInput = 0
        operacao = Nothing
    End Sub
End Class
