Imports MySql.Data.MySqlClient

Public Class MasterSupplier_Detail

    Public mode As String
    Dim idSupp, idSuppFix As String

    'Generate id supplier
    Sub GenerateID()
        Try
            Dim kode As String = ""
            Dim ArrSupp As String() = BoxSupplier.Text.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)

            For i = 0 To ArrSupp.Length - 1
                kode = kode & ArrSupp(i).Substring(0, 1)
            Next

            idSupp = kode.ToUpper

            Dim dtkode As New DataTable
            Dim query As String = "SELECT id_supplier from master_supplier where id_supplier like '%" & idSupp & "%' ;"
            adap = New MySqlDataAdapter(query, con)
            adap.Fill(dtkode)

            idSuppFix = idSupp & "-" & dtkode.Rows.Count + 1
        Catch ex As Exception

        End Try
    End Sub

    'Query master_kota
    Sub LoadKota()
        Dim dtkota As New DataTable
        Dim query As String = "SELECT kota FROM master_kota order by kota"
        adap = New MySqlDataAdapter(query, con)
        adap.Fill(dtkota)
        BoxKota.Properties.DataSource = dtkota
        BoxKota.Properties.DisplayMember = "kota"
    End Sub

    'Query kontak
    Sub LoadKontak()
        Try
            Dim dtkon As New DataTable
            Dim query As String = "SELECT jenis `Jenis Kontak`, nama_kontak `Nama Kontak`, telepon `Telp`
                                   FROM t_kontak
                                   WHERE id_supplier = '" & MasterSupplier.id_supp & "' and void = 0;"
            adap = New MySqlDataAdapter(query, con)
            adap.Fill(dtkon)
            GridKontak.DataSource = dtkon
        Catch ex As Exception

        End Try
    End Sub


    'Form Load
    Private Sub MasterSupplier_Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadKota()
            LoadKontak()

            If mode = "Edit" Then
                'Load data dari form MasterSupplier
                BoxSupplier.Text = MasterSupplier.supp
                BoxAlamat.Text = MasterSupplier.alamat
                BoxKota.SelectedText = MasterSupplier.kota
            ElseIf mode = "Tambah" Then
                Me.Text = "Tambah Pemasok"

                If ViewKontak.DataRowCount > 0 Then
                    RemoveKontak()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Text supplier changed
    Private Sub BoxSupplier_TextChanged(sender As Object, e As EventArgs) Handles BoxSupplier.TextChanged
        If Not BoxSupplier.Text = Nothing Then
            btSimpan.Enabled = True
        Else
            btSimpan.Enabled = False
        End If
    End Sub


    'Remove rows from GridView Kontak
    Sub RemoveKontak()
        For i = ViewKontak.DataRowCount - 1 To 0 Step -1
            ViewKontak.DeleteRow(i)
        Next
        ViewKontak.AddNewRow()
    End Sub

    'Simpan Supplier
    Private Sub btSimpan_Click(sender As Object, e As EventArgs) Handles btSimpan.Click
        Try
            Dim status = 0
            con.Open()

            If mode = "Tambah" Then

                GenerateID()

                'Insert ke tabel Master_Supplier
                Dim sql As String = "INSERT into master_supplier
                                     VALUES('" & idSuppFix & "','" & BoxSupplier.Text & "', '" & BoxAlamat.Text & "', '" & BoxKota.Text & "', 0);"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                'Insert ke t_kontak
                For i = 0 To ViewKontak.DataRowCount - 1
                    Dim sql0 As String = "INSERT into t_kontak
                                          VALUES('" & idSuppFix & "', '" & ViewKontak.GetRowCellValue(i, "Jenis Kontak") & "', '" & ViewKontak.GetRowCellValue(i, "Nama Kontak") & "', '" & ViewKontak.GetRowCellValue(i, "Telp") & "', 0)"
                    cmd = New MySqlCommand(sql0, con)
                    cmd.ExecuteNonQuery()
                Next

                status = 1

                If status = 1 Then
                    RemoveKontak()
                End If
            ElseIf mode = "Edit" Then

                'Delete kontak
                Dim del As String = "DELETE FROM t_kontak WHERE id_supplier = '" & MasterSupplier.id_supp & "' ;"
                cmd = New MySqlCommand(del, con)
                cmd.ExecuteNonQuery()

                'Update Master_supplier
                Dim sql1 As String = "UPDATE master_supplier
                                      SET nama_supplier = '" & BoxSupplier.Text & "', alamat = '" & BoxAlamat.Text & "', kota = '" & BoxKota.Text & "'
                                      WHERE id_supplier = '" & MasterSupplier.id_supp & "'"
                cmd = New MySqlCommand(sql1, con)
                cmd.ExecuteNonQuery()

                'Insert ulang ke t_kontak
                For i = 0 To ViewKontak.DataRowCount - 1
                    Dim sql0 As String = "INSERT into t_kontak
                                          VALUES('" & MasterSupplier.id_supp & "', '" & ViewKontak.GetRowCellValue(i, "Jenis Kontak") & "', '" & ViewKontak.GetRowCellValue(i, "Nama Kontak") & "', '" & ViewKontak.GetRowCellValue(i, "Telp") & "', 0)"
                    cmd = New MySqlCommand(sql0, con)
                    cmd.ExecuteNonQuery()
                Next

                status = 1

            End If

            If status = 1 Then
                MessageBox.Show("Data " & BoxSupplier.Text & " berhasil disimpan.", "Detail Pemasok", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BoxSupplier.ResetText()
                BoxAlamat.ResetText()
                BoxKota.ResetText()
            End If

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Dispose()
            MasterSupplier.btRefresh_Click(sender, e)
        End Try
    End Sub


    'Form ditutup
    Private Sub MasterSupplier_Detail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

End Class