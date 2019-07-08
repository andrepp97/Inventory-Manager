Imports MySql.Data.MySqlClient

Public Class MasterBarang_Detail

    'Variabel
    Public mode, queryharga, kodebarang, kodebarangfix As String
    Public EditHarga = 0

    'Generate Kode Barang
    Sub GenerateCode()
        Try
            Dim kode2 As String = ""
            Dim ArrBarang As String() = BoxBarang.Text.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)

            For j = 0 To ArrBarang.Length - 1
                kode2 = kode2 & ArrBarang(j).Substring(0, 2)
            Next

            kodebarang = kode2.ToUpper

            Dim dtkode As New DataTable
            Dim query As String = "SELECT kode_barang FROM master_barang
                                   WHERE kode_barang like '%" & kodebarang & "%' ;"
            adap = New MySqlDataAdapter(query, con)
            adap.Fill(dtkode)

            kodebarangfix = kodebarang & "-" & dtkode.Rows.Count + 1
        Catch ex As Exception

        End Try
    End Sub

    'Query kategori barang
    Sub KategoriBro()
        Try
            Dim dtkategori As New DataTable
            Dim query As String = "SELECT kategori FROM master_kategori GROUP by kategori ORDER by kategori"
            adap = New MySqlDataAdapter(query, con)
            adap.Fill(dtkategori)
            BoxKategori.Properties.DataSource = dtkategori
            BoxKategori.Properties.DisplayMember = "kategori"
        Catch ex As Exception

        End Try
    End Sub

    'Query satuan
    Sub SatuanBro()
        Try
            Dim dtsatuan1, dtsatuan2 As New DataTable
            Dim query As String = "SELECT satuan FROM master_satuan ORDER by 1"
            adap = New MySqlDataAdapter(query, con)
            adap.Fill(dtsatuan1)
            adap.Fill(dtsatuan2)
            dtsatuan2.Rows.Add("-")
            BoxSatuan1.DataSource = dtsatuan1
            BoxSatuan1.DisplayMember = "satuan"
            BoxSatuan2.DataSource = dtsatuan2
            BoxSatuan2.DisplayMember = "satuan"
        Catch ex As Exception

        End Try
    End Sub

    'Query riwayat harga
    Sub RiwayatHarga()
        Dim idBarang As String = ""
        Dim dtharga As New DataTable
        If mode = "Tambah" Then
            idBarang = kodebarangfix
        ElseIf mode = "Edit" Then
            idBarang = MasterBarang.kode
        End If

        queryharga = "SELECT tgl as `Tanggal`, h_beli1 as `Harga Beli 1`, h_jual1 as `Harga Jual 1`, h_beli2 as `Harga Beli 2`, h_jual2 as `Harga Jual 2`
                      FROM t_harga
                      WHERE kode_barang = '" & idBarang & "'
                      ORDER by 1 desc ;"
        adap = New MySqlDataAdapter(queryharga, con)
        adap.Fill(dtharga)
        GridHarga.DataSource = dtharga
    End Sub

    'Function untuk konversi harga menjadi kode
    Function ConvertPrice(ByVal beli As Double, ByVal kodeharga As String) As String
        Dim TempBeli = beli / 1000
        Dim hstring As String = TempBeli.ToString
        Dim harray As Char() = hstring.ToCharArray
        kodeharga = Nothing

        For i = 0 To harray.Length - 1
            If Not harray(i) = "." Then
                Dim dt As New DataTable
                Dim query As String = "SELECT kode FROM master_kode WHERE id = '" & harray(i) & "' ;"
                adap = New MySqlDataAdapter(query, con)
                adap.Fill(dt)
                kodeharga = kodeharga + dt.Rows(0)(0).ToString
            Else
                kodeharga = kodeharga + ","
            End If
        Next

        Return kodeharga
    End Function

    ''Konversi Harga Beli ke bentuk Kode
    'Sub converth()
    '    Dim htampung As Double = BoxHbeli1.Text / 1000
    '    Dim hstring As String = htampung.ToString
    '    Dim harray As Char() = hstring.ToCharArray

    '    For i = 0 To harray.Length - 1
    '        If Not harray(i) = "." Then
    '            Dim dt As New DataTable
    '            Dim query As String = "SELECT kode FROM master_kode WHERE id = '" & harray(i) & "' ;"
    '            adap = New MySqlDataAdapter(query, con)
    '            adap.Fill(dt)
    '            kodeharga = kodeharga + dt.Rows(0)(0).ToString
    '        Else
    '            kodeharga = kodeharga + ","
    '        End If
    '    Next

    '    BoxHbeli1.Text = kodeharga
    'End Sub


    'Form Load
    Public Sub MasterBarang_Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            KategoriBro()
            SatuanBro()

            'Cek apakah mode Tambah atau Edit
            If mode = "Tambah" Then
                BoxBarang.ReadOnly = False
                BoxHjual1.Enabled = True
                BoxHbeli1.Enabled = True
                BoxHjual2.Enabled = True
                BoxHbeli2.Enabled = True
                btAddHarga.Visible = False
            ElseIf mode = "Edit" Then
                BoxBarang.Text = MasterBarang.barang
                BoxKategori.SelectedText = MasterBarang.kategori
                BoxStok1.Value = MasterBarang.stok1
                BoxStok2.Value = MasterBarang.stok2
                BoxSatuan1.Text = MasterBarang.satuan1
                BoxSatuan2.Text = MasterBarang.satuan2
                BoxHjual1.Text = MasterBarang.hJual
                BoxHbeli1.Text = MasterBarang.hBeli
                BoxHbeli1.Text = ConvertPrice(BoxHbeli1.Text, "")
                BoxHbeli2.Text = ConvertPrice(BoxHbeli2.Text, "")
            End If
        Catch ex As Exception

        Finally
            RiwayatHarga()
        End Try
    End Sub

    'Display pemisah ribuan
    Private Sub ViewHarga_CustomColumnDisplayText_1(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles ViewHarga.CustomColumnDisplayText
        Try
            If e.Column.FieldName = "Harga Jual 1" Or e.Column.FieldName = "Harga Jual 2" Then
                e.DisplayText = String.Format("{0:n0}", e.Value)
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Enable/disable button
    Private Sub BoxBarang_TextChanged(sender As Object, e As EventArgs) Handles BoxHjual1.TextChanged, BoxHbeli1.TextChanged, BoxBarang.TextChanged
        If Not BoxBarang.Text = Nothing And Not BoxHjual1.Text = Nothing And Not BoxHbeli1.Text = Nothing Then
            btSimpan.Enabled = True
        Else
            btSimpan.Enabled = False
        End If
    End Sub


    'Mencegah null value
    Private Sub BoxHbeli2_Enter(sender As Object, e As EventArgs) Handles BoxHbeli2.Enter
        If BoxHbeli2.Text = "0" Then
            BoxHbeli2.ResetText()
        End If
    End Sub

    Private Sub BoxHbeli2_Leave(sender As Object, e As EventArgs) Handles BoxHbeli2.Leave
        If BoxHbeli2.Text = Nothing Then
            BoxHbeli2.Text = 0
        End If
    End Sub

    Private Sub BoxHjual2_Enter(sender As Object, e As EventArgs) Handles BoxHjual2.Enter
        If BoxHjual2.Text = "0" Then
            BoxHjual2.ResetText()
        End If
    End Sub

    Private Sub BoxHjual2_Leave(sender As Object, e As EventArgs) Handles BoxHjual2.Leave
        If BoxHjual2.Text = Nothing Then
            BoxHjual2.Text = 0
        End If
    End Sub

    Private Sub BoxHjual1_Enter(sender As Object, e As EventArgs) Handles BoxHjual1.Enter
        If BoxHjual1.Text = "0" Then
            BoxHjual1.ResetText()
        End If
    End Sub

    Private Sub BoxHjual1_Leave(sender As Object, e As EventArgs) Handles BoxHjual1.Leave
        If BoxHjual1.Text = Nothing Then
            BoxHjual1.Text = 0
        End If
    End Sub

    Private Sub BoxHbeli1_Enter(sender As Object, e As EventArgs) Handles BoxHbeli1.Enter
        If BoxHbeli1.Text = "0" Then
            BoxHbeli1.ResetText()
        End If
    End Sub

    Private Sub BoxHbeli1_Leave(sender As Object, e As EventArgs) Handles BoxHbeli1.Leave
        If BoxHbeli1.Text = Nothing Then
            BoxHbeli1.Text = 0
        End If
    End Sub

    Private Sub InputNumbersOnly(sender As Object, e As KeyPressEventArgs) Handles BoxHjual2.KeyPress, BoxHjual1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    'Tambah Harga Baru
    Private Sub btAddHarga_Click(sender As Object, e As EventArgs) Handles btAddHarga.Click
        BoxHbeli1.ResetText()
        BoxHbeli2.ResetText()

        BoxHbeli1.Enabled = True
        BoxHjual1.Enabled = True
        BoxHbeli2.Enabled = True
        BoxHjual2.Enabled = True
        EditHarga = 1
        btAddHarga.Enabled = False

        Dim tip = "Harus diisi dengan angka. Sistem akan otomatis mengubah angka menjadi kode."
        tipHarga.Show(tip, BoxHbeli1)
        tipHarga2.Show(tip, BoxHbeli2)
    End Sub

    'Menampilkan form kategori
    Private Sub btAddKategori_Click_1(sender As Object, e As EventArgs) Handles btAddKategori.Click
        MasterKategori.ShowDialog()
    End Sub

    'Simpan perubahan
    Private Sub btSimpan_Click(sender As Object, e As EventArgs) Handles btSimpan.Click
        Dim status = 0
        Try
            If mode = "Tambah" Then
                con.Open()

                GenerateCode()

                'Insert barang
                Dim sql As String = "INSERT into master_barang VALUES('" & kodebarangfix & "', '" & BoxBarang.Text & "', '" & BoxKategori.Text & "', '" & BoxStok1.Value & "', '" & BoxSatuan1.Text & "', '" & BoxStok2.Value & "', '" & BoxSatuan2.Text & "', 'A');"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                'Insert harga
                Dim sql2 As String = "INSERT into t_harga VALUES(date(now()), '" & kodebarangfix & "', '" & BoxHbeli1.Text & "', '" & BoxHjual1.Text & "', '" & BoxHbeli2.Text & "', '" & BoxHjual2.Text & "', 0);"
                cmd = New MySqlCommand(sql2, con)
                cmd.ExecuteNonQuery()

                status = 1

                con.Close()
            ElseIf mode = "Edit" Then
                con.Open()

                'Tambah harga baru saat user menambah
                Try
                    If EditHarga = 1 Then
                        Dim sql3 As String = "INSERT into t_harga VALUES(date(now()), '" & MasterBarang.kode & "', '" & BoxHbeli1.Text & "', '" & BoxHjual1.Text & "', '" & BoxHbeli2.Text & "', '" & BoxHjual2.Text & "', 0);"
                        cmd = New MySqlCommand(sql3, con)
                        cmd.ExecuteNonQuery()
                    End If

                    'Update tabel Master_Barang
                    Dim sql As String = "UPDATE master_barang
                                         SET nama_barang = '" & BoxBarang.Text & "', kategori = '" & BoxKategori.Text & "', stok1 = '" & BoxStok1.Value & "', satuan1 = '" & BoxSatuan1.Text & "', stok2 = '" & BoxStok2.Value & "', satuan2 = '" & BoxSatuan2.Text & "'
                                         WHERE kode_barang = '" & MasterBarang.kode & "' ;"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    status = 1
                Catch ex As Exception
                    MessageBox.Show("Menambah harga baru dibatasi hanya 1x dalam sehari untuk tiap barang.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

                con.Close()
            End If

            'Konversi harga ke kode dilakukan di kondisi tertentu
            If status = 1 And (mode = "Tambah" Or EditHarga = 1) Then
                BoxHbeli1.Text = ConvertPrice(BoxHbeli1.Text, "")
                BoxHbeli2.Text = ConvertPrice(BoxHbeli2.Text, "")
            End If

            'Jika insert/update berhasil, show message
            If status = 1 Then
                MessageBox.Show("Data " & BoxBarang.Text & " berhasil disimpan.", "Detail Barang", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            RiwayatHarga()
            BoxHbeli1.Enabled = False
            BoxHjual1.Enabled = False
            EditHarga = 0
            MasterBarang.MasterBarang_Load(sender, e)
            con.Dispose()
        End Try
    End Sub


    'Form Closed
    Private Sub MasterBarang_Detail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

End Class