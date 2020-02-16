Public Class Bingo

    Dim AscendingListBox As New List(Of Integer)
    Dim _Hora As Integer
    Dim _Minutos As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        Reloj.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBingo.Click

        txtFiltro.Text = ""
        lblFiltro.Text = "El numero no ha salido"
        GeneraAleatorio()
        lblNumeroBolitas.Text = "El numero de bolitas salidas son: " & lbxListaNumeros.Items.Count
        OrdenarLista()

    End Sub

    Private Sub GeneraAleatorio()
        Try
            If lbxListaNumeros.Items.Count < 75 Then
                Dim rnd As New Random()
                Dim nuevo As Boolean = False
                'Get a random number from 10 to 99  (2 digits)
                While nuevo = False
                    nuevo = True
                    Dim randomNumber As Integer = rnd.Next(1, 76)
                    If lbxListaNumeros.Items.Count > 0 Then
                        For Each item In lbxListaNumeros.Items
                            If item = randomNumber Then
                                nuevo = False
                            End If
                        Next
                    End If

                    If nuevo Then
                        lbxListaNumeros.Items.Add(randomNumber)
                        EncenderColor(randomNumber)
                        txtUltimoNumero.Text = randomNumber
                    End If
                End While
            Else
                MsgBox("Todas las bolitas ya salieron")
            End If
            lbxListaNumeros.Sorted = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub OrdenarLista()
        If lbxListaNumeros.Items.Count > 1 Then
            AscendingListBox.Clear()
            For i = 0 To lbxListaNumeros.Items.Count - 1
                AscendingListBox.Add(CInt(lbxListaNumeros.Items(i)))
            Next
            AscendingListBox.Sort()
            lbxListaNumeros.Items.Clear()
            For i = 0 To AscendingListBox.Count - 1
                lbxListaNumeros.Items.Add(AscendingListBox(i))
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyUp
        Try
            If txtFiltro.Text <> "" Then
                If lbxListaNumeros.Items.Count > 0 Then
                    lblFiltro.Text = "El numero no ha salido"
                    For Each item In lbxListaNumeros.Items
                        If item = txtFiltro.Text Then
                            lblFiltro.Text = "El numero YA SALIO"
                        End If
                    Next
                Else
                    lblFiltro.Text = "El numero no ha salido"
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Limpiar()
        LimpiaBotones()
        lbxListaNumeros.Items.Clear()
        lblNumeroBolitas.Text = "El numero de bolitas salidas son: 0"
        lblUltimoNumero.Text = "El ultimo numero salido es: "
        txtFiltro.Text = ""
        lblFiltro.Text = "El numero no ha salido"
        txtUltimoNumero.Text = ""
    End Sub

    Private Sub EncenderColor(ByVal numero As Integer)
        Select Case numero
            Case 1
                btn1.BackColor = Color.LimeGreen
            Case 2
                btn2.BackColor = Color.LimeGreen
            Case 3
                btn3.BackColor = Color.LimeGreen
            Case 4
                btn4.BackColor = Color.LimeGreen
            Case 5
                btn5.BackColor = Color.LimeGreen
            Case 6
                btn6.BackColor = Color.LimeGreen
            Case 7
                btn7.BackColor = Color.LimeGreen
            Case 8
                btn8.BackColor = Color.LimeGreen
            Case 9
                btn9.BackColor = Color.LimeGreen
            Case 10
                btn10.BackColor = Color.LimeGreen
            Case 11
                btn11.BackColor = Color.LimeGreen
            Case 12
                btn12.BackColor = Color.LimeGreen
            Case 13
                btn13.BackColor = Color.LimeGreen
            Case 14
                btn14.BackColor = Color.LimeGreen
            Case 15
                btn15.BackColor = Color.LimeGreen
            Case 16
                btn16.BackColor = Color.LimeGreen
            Case 17
                btn17.BackColor = Color.LimeGreen
            Case 18
                btn18.BackColor = Color.LimeGreen
            Case 19
                btn19.BackColor = Color.LimeGreen
            Case 20
                btn20.BackColor = Color.LimeGreen
            Case 21
                btn21.BackColor = Color.LimeGreen
            Case 22
                btn22.BackColor = Color.LimeGreen
            Case 23
                btn23.BackColor = Color.LimeGreen
            Case 24
                btn24.BackColor = Color.LimeGreen
            Case 25
                btn25.BackColor = Color.LimeGreen
            Case 26
                btn26.BackColor = Color.LimeGreen
            Case 27
                btn27.BackColor = Color.LimeGreen
            Case 28
                btn28.BackColor = Color.LimeGreen
            Case 29
                btn29.BackColor = Color.LimeGreen
            Case 30
                btn30.BackColor = Color.LimeGreen
            Case 31
                btn31.BackColor = Color.LimeGreen
            Case 32
                btn32.BackColor = Color.LimeGreen
            Case 33
                btn33.BackColor = Color.LimeGreen
            Case 34
                btn34.BackColor = Color.LimeGreen
            Case 35
                btn35.BackColor = Color.LimeGreen
            Case 36
                btn36.BackColor = Color.LimeGreen
            Case 37
                btn37.BackColor = Color.LimeGreen
            Case 38
                btn38.BackColor = Color.LimeGreen
            Case 39
                btn39.BackColor = Color.LimeGreen
            Case 40
                btn40.BackColor = Color.LimeGreen
            Case 41
                btn41.BackColor = Color.LimeGreen
            Case 42
                btn42.BackColor = Color.LimeGreen
            Case 43
                btn43.BackColor = Color.LimeGreen
            Case 44
                btn44.BackColor = Color.LimeGreen
            Case 45
                btn45.BackColor = Color.LimeGreen
            Case 46
                btn46.BackColor = Color.LimeGreen
            Case 47
                btn47.BackColor = Color.LimeGreen
            Case 48
                btn48.BackColor = Color.LimeGreen
            Case 49
                btn49.BackColor = Color.LimeGreen
            Case 50
                btn50.BackColor = Color.LimeGreen
            Case 51
                btn51.BackColor = Color.LimeGreen
            Case 52
                btn52.BackColor = Color.LimeGreen
            Case 53
                btn53.BackColor = Color.LimeGreen
            Case 54
                btn54.BackColor = Color.LimeGreen
            Case 55
                btn55.BackColor = Color.LimeGreen
            Case 56
                btn56.BackColor = Color.LimeGreen
            Case 57
                btn57.BackColor = Color.LimeGreen
            Case 58
                btn58.BackColor = Color.LimeGreen
            Case 59
                btn59.BackColor = Color.LimeGreen
            Case 60
                btn60.BackColor = Color.LimeGreen
            Case 61
                btn61.BackColor = Color.LimeGreen
            Case 62
                btn62.BackColor = Color.LimeGreen
            Case 63
                btn63.BackColor = Color.LimeGreen
            Case 64
                btn64.BackColor = Color.LimeGreen
            Case 65
                btn65.BackColor = Color.LimeGreen
            Case 66
                btn66.BackColor = Color.LimeGreen
            Case 67
                btn67.BackColor = Color.LimeGreen
            Case 68
                btn68.BackColor = Color.LimeGreen
            Case 69
                btn69.BackColor = Color.LimeGreen
            Case 70
                btn70.BackColor = Color.LimeGreen
            Case 71
                btn71.BackColor = Color.LimeGreen
            Case 72
                btn72.BackColor = Color.LimeGreen
            Case 73
                btn73.BackColor = Color.LimeGreen
            Case 74
                btn74.BackColor = Color.LimeGreen
            Case 75
                btn75.BackColor = Color.LimeGreen
        End Select

    End Sub

    Private Sub LimpiaBotones()
        btn1.BackColor = Color.Transparent
        btn2.BackColor = Color.Transparent
        btn3.BackColor = Color.Transparent
        btn4.BackColor = Color.Transparent
        btn5.BackColor = Color.Transparent
        btn6.BackColor = Color.Transparent
        btn7.BackColor = Color.Transparent
        btn8.BackColor = Color.Transparent
        btn9.BackColor = Color.Transparent
        btn10.BackColor = Color.Transparent
        btn11.BackColor = Color.Transparent
        btn12.BackColor = Color.Transparent
        btn13.BackColor = Color.Transparent
        btn14.BackColor = Color.Transparent
        btn15.BackColor = Color.Transparent
        btn16.BackColor = Color.Transparent
        btn17.BackColor = Color.Transparent
        btn18.BackColor = Color.Transparent
        btn19.BackColor = Color.Transparent
        btn20.BackColor = Color.Transparent
        btn21.BackColor = Color.Transparent
        btn22.BackColor = Color.Transparent
        btn23.BackColor = Color.Transparent
        btn24.BackColor = Color.Transparent
        btn25.BackColor = Color.Transparent
        btn26.BackColor = Color.Transparent
        btn27.BackColor = Color.Transparent
        btn28.BackColor = Color.Transparent
        btn29.BackColor = Color.Transparent
        btn30.BackColor = Color.Transparent
        btn31.BackColor = Color.Transparent
        btn32.BackColor = Color.Transparent
        btn33.BackColor = Color.Transparent
        btn34.BackColor = Color.Transparent
        btn35.BackColor = Color.Transparent
        btn36.BackColor = Color.Transparent
        btn37.BackColor = Color.Transparent
        btn38.BackColor = Color.Transparent
        btn39.BackColor = Color.Transparent
        btn40.BackColor = Color.Transparent
        btn41.BackColor = Color.Transparent
        btn42.BackColor = Color.Transparent
        btn43.BackColor = Color.Transparent
        btn44.BackColor = Color.Transparent
        btn45.BackColor = Color.Transparent
        btn46.BackColor = Color.Transparent
        btn47.BackColor = Color.Transparent
        btn48.BackColor = Color.Transparent
        btn49.BackColor = Color.Transparent
        btn50.BackColor = Color.Transparent
        btn51.BackColor = Color.Transparent
        btn52.BackColor = Color.Transparent
        btn53.BackColor = Color.Transparent
        btn54.BackColor = Color.Transparent
        btn55.BackColor = Color.Transparent
        btn56.BackColor = Color.Transparent
        btn57.BackColor = Color.Transparent
        btn58.BackColor = Color.Transparent
        btn59.BackColor = Color.Transparent
        btn60.BackColor = Color.Transparent
        btn61.BackColor = Color.Transparent
        btn62.BackColor = Color.Transparent
        btn63.BackColor = Color.Transparent
        btn64.BackColor = Color.Transparent
        btn65.BackColor = Color.Transparent
        btn66.BackColor = Color.Transparent
        btn67.BackColor = Color.Transparent
        btn68.BackColor = Color.Transparent
        btn69.BackColor = Color.Transparent
        btn70.BackColor = Color.Transparent
        btn71.BackColor = Color.Transparent
        btn72.BackColor = Color.Transparent
        btn73.BackColor = Color.Transparent
        btn74.BackColor = Color.Transparent
        btn75.BackColor = Color.Transparent
    End Sub

    Private Sub txtUltimoNumero_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUltimoNumero.KeyDown
        e.Handled = True
    End Sub


    Private Sub txtUltimoNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUltimoNumero.KeyPress
        e.Handled = True
    End Sub

    Private Sub Reloj_Tick(sender As Object, e As EventArgs) Handles Reloj.Tick
        Dim _Segundos As Integer = 0
        _Hora = DateTime.Now.TimeOfDay.Hours
        _Minutos = DateTime.Now.TimeOfDay.Minutes
        _Segundos = DateTime.Now.TimeOfDay.Seconds

        If _Hora = 0 And _Minutos = 0 And _Segundos = 0 Then

        End If
    End Sub

End Class
