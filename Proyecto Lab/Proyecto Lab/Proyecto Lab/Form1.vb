﻿Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            Msg1.Show()
        End If

        If TextBox1.Text = My.Settings.Usuario And TextBox2.Text = My.Settings.Clave Then
            Form2.Show() 'Puse el form2 por que todavia no esta echo el menu, aqui va el form de menu'
            Hide()

        Else
            Msg1.Show()





        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Hide()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Parent = PictureBox1
        Label5.BackColor = Color.Transparent
        'Con el siguiente codigo ponemos los labels transparentes
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
