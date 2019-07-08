Imports MySql.Data.MySqlClient

Public Class MasterCustomer_Detail

    'Variabel
    Public mode As String

    'Load Form
    Private Sub MasterCustomer_Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If mode = "Tambah" Then

        ElseIf mode = "Edit" Then
            BoxNama.Text = MasterCustomer.cust
            BoxAlamat.Text = MasterCustomer.alamat
            BoxTelp.Text = MasterCustomer.telp
        End If
    End Sub

    'Text nama changed
    Private Sub BoxNama_TextChanged(sender As Object, e As EventArgs) Handles BoxNama.TextChanged
        If Not BoxNama.Text = Nothing Then
            btSimpan.Enabled = True
        Else
            btSimpan.Enabled = False
        End If
    End Sub

    'Input only numbers
    Private Sub BoxTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BoxTelp.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'Insert ke tabel Master_Cust
    Private Sub btSimpan_Click(sender As Object, e As EventArgs) Handles btSimpan.Click
        Try
            con.Open()
            If mode = "Tambah" Then

                'Insert customer
                Dim sql As String = "INSERT into master_customer(`nama_cust`, `alamat`, `telepon`, `saldo_hutang`, `void`)
                                     VALUES('" & BoxNama.Text & "', '" & BoxAlamat.Text & "', '" & BoxTelp.Text & "', 0, 0) ;"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

            ElseIf mode = "Edit" Then

                'Update customer
                Dim sql2 As String = "UPDATE master_customer set nama_cust = '" & BoxNama.Text & "', alamat = '" & BoxAlamat.Text & "', telepon = '" & BoxTelp.Text & "'
                                      WHERE id_cust = '" & MasterCustomer.id & "' ;"
                cmd = New MySqlCommand(sql2, con)
                cmd.ExecuteNonQuery()

            End If
            con.Close()
            MessageBox.Show("Data " & BoxNama.Text & " berhasil disimpan.", "Detail Customer", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Dispose()
            MasterCustomer.MasterCustomer_Load(sender, e)
        End Try
    End Sub


    'Form Closed
    Private Sub MasterCustomer_Detail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

End Class