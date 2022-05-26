Public Class Form1
    Dim FrstNm As Decimal
    Dim ScndNm As Decimal
    Dim Sum As Decimal
    Dim Oprtns As Integer
    Dim Oprtr_Selector As Boolean = False

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If Oprtr_Selector = True Then
            ScndNm = TextBox1.Text
            If Oprtns = 1 Then
                Sum = FrstNm + ScndNm
                TextBox1.Text = Sum
            ElseIf Oprtns = 2 Then
                Sum = FrstNm - ScndNm
                TextBox1.Text = Sum
            ElseIf Oprtns = 3 Then
                Sum = FrstNm * ScndNm
                TextBox1.Text = Sum
            ElseIf Oprtns = 4 Then
                Sum = FrstNm / ScndNm
                TextBox1.Text = Sum
            Else
                If ScndNm = 0 Then
                    TextBox1.Text = "Error!"
                Else
                    TextBox1.Text = FrstNm / ScndNm
                End If
            End If
            Oprtr_Selector = False
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("              Developed by " & vbNewLine & "         Mehmet Fatih Şahin" & vbNewLine & "                 200403663")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "1"
        Else
            TextBox1.Text = "1"
        End If
    End Sub

    Private Sub Button1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button1.KeyPress
        If Asc(e.KeyChar) = 97 Then
            Button1.Focus()
            If TextBox1.Text <> "0" Then
                TextBox1.Text += "1"
            Else
                TextBox1.Text = "1"
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "2"
        Else
            TextBox1.Text = "2"
        End If
    End Sub

    Private Sub Button2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button2.KeyPress
        If Asc(e.KeyChar) = 98 Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text += "2"
            Else
                TextBox1.Text = "2"
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "3"
        Else
            TextBox1.Text = "3"
        End If
    End Sub

    Private Sub Button3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button3.KeyPress
        If Asc(e.KeyChar) = 99 Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text += "3"
            Else
                TextBox1.Text = "3"
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "4"
        Else
            TextBox1.Text = "4"
        End If
    End Sub

    Private Sub Button4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button4.KeyPress
        If Asc(e.KeyChar) = 100 Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text += "4"
            Else
                TextBox1.Text = "4"
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "5"
        Else
            TextBox1.Text = "5"
        End If
    End Sub

    Private Sub Button5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button5.KeyPress
        If Asc(e.KeyChar) = 101 Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text += "5"
            Else
                TextBox1.Text = "5"
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "6"
        Else
            TextBox1.Text = "6"
        End If
    End Sub

    Private Sub Button6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button6.KeyPress
        If Asc(e.KeyChar) = 102 Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text += "6"
            Else
                TextBox1.Text = "6"
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "7"
        Else
            TextBox1.Text = "7"
        End If
    End Sub

    Private Sub Button7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button7.KeyPress
        If Asc(e.KeyChar) = 103 Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text += "7"
            Else
                TextBox1.Text = "7"
            End If
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "8"
        Else
            TextBox1.Text = "8"
        End If
    End Sub

    Private Sub Button8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button8.KeyPress
        If Asc(e.KeyChar) = 104 Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text += "8"
            Else
                TextBox1.Text = "8"
            End If
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "9"
        Else
            TextBox1.Text = "9"
        End If
    End Sub

    Private Sub Button9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button9.KeyPress
        If Asc(e.KeyChar) = 105 Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text += "9"
            Else
                TextBox1.Text = "9"
            End If
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "0"
        End If
    End Sub

    Private Sub Button10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button10.KeyPress
        If Asc(e.KeyChar) = 96 Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text += "0"
            End If
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub Button15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button15.KeyPress
        If Asc(e.KeyChar) = 27 Then
            TextBox1.Text = "0"
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim check = InStr(TextBox1.Text, ",")
        If check < 1 Then
            TextBox1.Text = TextBox1.Text + ","
        End If
    End Sub
    Private Sub Button16_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button16.KeyPress
        If Asc(e.KeyChar) = 188 Then
            Dim check = InStr(TextBox1.Text, ",")
            If check < 1 Then
                TextBox1.Text = TextBox1.Text + ","
            End If
        End If
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        FrstNm = TextBox1.Text
        TextBox1.Text = "0"
        Oprtr_Selector = True
        Oprtns = 1  '  = +
    End Sub

    Private Sub Button14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button14.KeyPress
        If Asc(e.KeyChar) = 107 Then
            FrstNm = TextBox1.Text
            TextBox1.Text = "0"
            Oprtr_Selector = True
            Oprtns = 1  '  = +
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        FrstNm = TextBox1.Text
        TextBox1.Text = "0"
        Oprtr_Selector = True
        Oprtns = 2  '  = -
    End Sub

    Private Sub Button13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button13.KeyPress
        If Asc(e.KeyChar) = 109 Then
            FrstNm = TextBox1.Text
            TextBox1.Text = "0"
            Oprtr_Selector = True
            Oprtns = 2  '  = -
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        FrstNm = TextBox1.Text
        TextBox1.Text = "0"
        Oprtr_Selector = True
        Oprtns = 3  '  = *
    End Sub

    Private Sub Button12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button12.KeyPress
        If Asc(e.KeyChar) = 106 Then
            FrstNm = TextBox1.Text
            TextBox1.Text = "0"
            Oprtr_Selector = True
            Oprtns = 3  '  = *
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        FrstNm = TextBox1.Text
        TextBox1.Text = "0"
        Oprtr_Selector = True
        Oprtns = 4  '  = /
    End Sub

    Private Sub Button11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button11.KeyPress
        If Asc(e.KeyChar) = 111 Then
            FrstNm = TextBox1.Text
            TextBox1.Text = "0"
            Oprtr_Selector = True
            Oprtns = 4  '  = /
        End If
    End Sub

    Private Sub Button17_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button17.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Oprtr_Selector = True Then
                ScndNm = TextBox1.Text
                If Oprtns = 1 Then
                    Sum = FrstNm + ScndNm
                    TextBox1.Text = Sum
                ElseIf Oprtns = 2 Then
                    Sum = FrstNm - ScndNm
                    TextBox1.Text = Sum
                ElseIf Oprtns = 3 Then
                    Sum = FrstNm * ScndNm
                    TextBox1.Text = Sum
                ElseIf Oprtns = 4 Then
                    Sum = FrstNm / ScndNm
                    TextBox1.Text = Sum
                Else
                    If ScndNm = 0 Then
                        TextBox1.Text = "Error!"
                    Else
                        TextBox1.Text = FrstNm / ScndNm
                    End If
                End If
                Oprtr_Selector = False
            End If
        End If
    End Sub
End Class
