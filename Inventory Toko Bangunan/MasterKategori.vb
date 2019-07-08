Imports MySql.Data.MySqlClient

Public Class MasterKategori

    Public dtkat As New DataTable

    'Query kategori
    Sub LoadKategori()
        Try
            dtkat = New DataTable
            Dim query As String = "SELECT Kategori FROM master_kategori GROUP by kategori ORDER by kategori"
            adap = New MySqlDataAdapter(query, con)
            adap.Fill(dtkat)
            GridKategori.DataSource = dtkat
        Catch ex As Exception

        End Try
    End Sub


    'Form Load
    Private Sub MasterKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKategori()
    End Sub

    'enable/disable button
    Private Sub BoxKategori_EditValueChanged(sender As Object, e As EventArgs) Handles BoxKategori.EditValueChanged
        If Not BoxKategori.Text = Nothing Then
            btTambah.Enabled = True
        Else
            btTambah.Enabled = False
        End If
    End Sub

    'Menyimpan kategori baru
    Private Sub btTambah_Click(sender As Object, e As EventArgs) Handles btTambah.Click
        Try
            If BoxKategori.Text = Nothing Then
                MessageBox.Show("Untuk menambah kategori, box kategori tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                con.Open()
                Dim sql As String = "INSERT into master_kategori(`kategori`)
                                     VALUES('" & BoxKategori.Text & "');"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            BoxKategori.ResetText()
            LoadKategori()
            MasterBarang_Detail.KategoriBro()
        End Try
    End Sub


    'Setelah form ditutup
    Private Sub MasterKategori_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

End Class