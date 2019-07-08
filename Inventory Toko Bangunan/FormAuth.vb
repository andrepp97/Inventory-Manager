Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography

Public Class FormAuth
    'Deklarasi variabel
    Public username As String

    'MD5 function
    Public Function md5string(ByVal source As String) As String
        Dim bytes() As Byte
        Dim sb As New StringBuilder()

        bytes = Encoding.Default.GetBytes(source)
        bytes = MD5.Create().ComputeHash(bytes)

        For i = 0 To bytes.Length - 1
            sb.Append(bytes(i).ToString("x2"))
        Next

        Return sb.ToString
    End Function


    'Prosedur Login
    Sub Login()
        Try
            Dim hash As FormAuth
            hash = New FormAuth()

            'Select Password
            adap = New MySqlDataAdapter("select password, nama_user from anugerah_jaya.master_users where password = '" & hash.md5string(BoxKode.Text.ToLower) & "' ;", con)
            Dim dtlogin As New DataTable
            adap.Fill(dtlogin)

            If Not dtlogin.Rows.Count = Nothing Then
                username = dtlogin.Rows(0)("nama_user").ToString
                Me.Hide()
                FormMenu.ShowDialog()
            Else
                MessageBox.Show("Kode Akses salah, silahkan coba lagi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BoxKode.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            BoxKode.Clear()
        End Try
    End Sub

    'Saat user tekan tombol [Enter] setelah mengisi kode akses
    Private Sub BoxKode_KeyUp(sender As Object, e As KeyEventArgs) Handles BoxKode.KeyUp
        If e.KeyCode = Keys.Enter Then
            'Login()
            Me.Hide()
            FormMenu.ShowDialog()
        End If
    End Sub

End Class
