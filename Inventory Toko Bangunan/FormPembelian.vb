Imports MySql.Data.MySqlClient
Imports DevExpress.Utils
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns

Public Class FormPembelian

    'Variabel
    Public mode As String
    Dim dtbarang As New DataTable
    Dim tglterima As String = "null"
    Dim StatBarang, StatBayar, counter As Integer
    Public ListBro, RowKeys, Qty, Harga As Object()


    'Query Supplier
    Sub LoadSupplier()
        Try
            Dim dtsupp As New DataTable
            Dim query As String = "SELECT id_supplier as `ID`, nama_supplier as `Pemasok`
                                   FROM master_supplier
                                   ORDER by 2;"
            adap = New MySqlDataAdapter(query, con)
            adap.Fill(dtsupp)
            BoxSupp.Properties.DataSource = dtsupp
            BoxSupp.Properties.DisplayMember = "Pemasok"
            BoxSupp.Properties.ValueMember = "ID"
        Catch ex As Exception

        End Try
    End Sub

    'Query semua barang
    Sub SemuaBarang()
        Try
            dtbarang = New DataTable
            Dim query As String = "SELECT kode_barang as `Kode`, nama_barang as `Barang`, Kategori, 0 as `Qty`, 0 as `Harga Unit`, 0 as `Subtotal`
                                   FROM master_barang
                                   WHERE `status` <> 'NA'
                                   ORDER by 3,2;"
            adap = New MySqlDataAdapter(query, con)
            adap.Fill(dtbarang)
            GridPembelian.DataSource = dtbarang
        Catch ex As Exception

        End Try
    End Sub

    'Query barang sesuai PO
    Sub BarangPO()
        Try
            Dim dt As New DataTable
            Dim query As String = "SELECT mb.kode_barang as `Kode`, nama_barang as `Barang`, Kategori, Qty, harga_beli `Harga Unit`, qty*harga_beli `Subtotal`
                                   FROM master_barang mb, d_pembelian dp
                                   WHERE mb.kode_barang = dp.kode_barang and no_nota = '" & RiwayatPembelian.nota & "';"
            adap = New MySqlDataAdapter(query, con)
            adap.Fill(dt)
            GridPembelian.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub

    'Generate nomor pembelian
    Sub GeneratePO()
        Try
            Dim ponumber As String
            Dim todate As String = Year(Today) & Month(Today) & DateTime.Now.Day

            Dim dtdate As New DataTable
            Dim query As String = "SELECT no_nota FROM t_pembelian WHERE no_nota like '%" & todate & "%';"
            adap = New MySqlDataAdapter(query, con)
            adap.Fill(dtdate)

            ponumber = "PO-" & todate & "-" & dtdate.Rows.Count + 1
            BoxNota.Text = ponumber
        Catch ex As Exception

        End Try
    End Sub


    'Form Load
    Private Sub BarangMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadSupplier()

            If mode = "Tambah" Then
                SemuaBarang()
                GeneratePO()
                BoxSupp.ItemIndex = 0

                'Column uneditable
                ViewPembelian.Columns("Barang").OptionsColumn.AllowEdit = False
                ViewPembelian.Columns("Kategori").OptionsColumn.AllowEdit = False
                ViewPembelian.Columns("Subtotal").OptionsColumn.AllowEdit = False

            ElseIf mode = "Edit" Then

                Me.Text = "Pembelian (" & RiwayatPembelian.nota & ")"
                btSimpan.Enabled = True
                cbBarang.Visible = False
                ViewPembelian.OptionsBehavior.Editable = False
                ViewPembelian.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect
                BarangPO()

                'Fill the selected data
                BoxNota.Text = RiwayatPembelian.nota
                DateBeli.Value = RiwayatPembelian.tglbeli
                DateDatang.Value = RiwayatPembelian.tgldatang
                DateJtempo.Value = RiwayatPembelian.jtempo
                BoxSupp.SelectedText = RiwayatPembelian.supp
                BoxCatatan.Text = RiwayatPembelian.catatan

                'Disable the radio buttons
                Radio7.Enabled = False
                Radio10.Enabled = False
                Radio30.Enabled = False

                If RiwayatPembelian.sBarang = True Then
                    CekBarang.Checked = True
                Else
                    CekBarang.Checked = False
                End If

                If RiwayatPembelian.sBayar = True Then
                    CekLunas.Checked = True
                Else
                    CekLunas.Checked = False
                End If
            End If

            'Atur kolom visible/tidak
            ViewPembelian.Columns("Kode").Visible = False

            'Footer untuk Grand Total
            ViewPembelian.Columns("Harga Unit").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
            ViewPembelian.Columns("Harga Unit").SummaryItem.FieldName = "Harga Unit"
            ViewPembelian.Columns("Harga Unit").SummaryItem.DisplayFormat = "Grand Total :"

            ViewPembelian.Columns("Subtotal").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            ViewPembelian.Columns("Subtotal").SummaryItem.FieldName = "Subtotal"
            ViewPembelian.Columns("Subtotal").SummaryItem.DisplayFormat = "{0:n0}"
        Catch ex As Exception

        End Try
    End Sub

    'Memilih supplier
    Private Sub BoxSupp_EditValueChanged(sender As Object, e As EventArgs) Handles BoxSupp.EditValueChanged
        Try
            Dim dtinfo As New DataTable
            Dim query As String = "SELECT IF(nama_kontak = NULL OR nama_kontak = '', jenis, CONCAT(jenis,' (',nama_kontak,')')) AS `Kontak`, Telepon as `Telp`
                                   FROM t_kontak
                                   WHERE id_supplier = '" & BoxSupp.EditValue.ToString & "';"
            adap = New MySqlDataAdapter(query, con)
            adap.Fill(dtinfo)
            BoxKontak.Properties.DataSource = dtinfo
            BoxKontak.Properties.DisplayMember = "Kontak"
            BoxKontak.ItemIndex = 0
        Catch ex As Exception
        End Try
    End Sub

    'Display text pemisah ribuan
    Private Sub ViewPembelian_CustomColumnDisplayText(sender As Object, e As CustomColumnDisplayTextEventArgs) Handles ViewPembelian.CustomColumnDisplayText
        Try
            If e.Column.FieldName = "Harga Unit" Or e.Column.FieldName = "Subtotal" Then
                e.DisplayText = String.Format("{0:n0}", e.Value)
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Menghitung Subtotal barang
    Private flag As Boolean = False
    Private Sub ViewPembelian_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles ViewPembelian.CellValueChanged
        Dim view As GridView = TryCast(sender, GridView)
        If e.Column.FieldName = "Qty" AndAlso (Not flag) Then
            Dim subtot = e.Value * view.GetRowCellValue(e.RowHandle, "Harga Unit")
            flag = True
            view.SetRowCellValue(e.RowHandle, "Subtotal", subtot)
            flag = False
        ElseIf e.Column.FieldName = "Harga Unit" AndAlso (Not flag) Then
            Dim subtot = e.Value * view.GetRowCellValue(e.RowHandle, "Qty")
            flag = True
            view.SetRowCellValue(e.RowHandle, "Subtotal", subtot)
            flag = False
        End If
    End Sub

    'Cek apakah sudah lunas
    Private Sub CekLunas_CheckedChanged(sender As Object, e As EventArgs) Handles CekLunas.CheckedChanged
        If CekLunas.Checked = True Then
            StatBayar = 1
        Else
            StatBayar = 0
        End If
    End Sub

    'Cek apakah barang sudah masuk
    Private Sub CekBarang_CheckedChanged(sender As Object, e As EventArgs) Handles CekBarang.CheckedChanged
        If CekBarang.Checked = True Then
            StatBarang = 1
            tglterima = "'" & Today & "'"
        Else
            StatBarang = 0
            tglterima = "NULL"
        End If
    End Sub

    'Jatuh tempo n/7
    Private Sub Radio7_CheckedChanged(sender As Object, e As EventArgs) Handles Radio7.CheckedChanged
        If Radio7.Checked = True Then
            Dim d = Today.Date
            DateJtempo.Value = d.AddDays(+7)
        End If
    End Sub

    'Jatuh tempo n/10
    Private Sub Radio10_CheckedChanged(sender As Object, e As EventArgs) Handles Radio10.CheckedChanged
        If Radio10.Checked = True Then
            Dim d = Today.Date
            DateJtempo.Value = d.AddDays(+10)
        End If
    End Sub

    'Jatuh tempo n/30
    Private Sub Radio30_CheckedChanged(sender As Object, e As EventArgs) Handles Radio30.CheckedChanged
        If Radio30.Checked = True Then
            Dim d = Today.Date
            DateJtempo.Value = d.AddDays(+30)
        End If
    End Sub


    'Cek pemilihan Date (tidak boleh H-)
    Private Sub DateJtempo_ValueChanged(sender As Object, e As EventArgs) Handles DateJtempo.ValueChanged
        If mode = "Tambah" And DateJtempo.Value < Today.Date Then
            MessageBox.Show("Tanggal Jatuh Tempo tidak boleh sebelum hari ini.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DateJtempo.Value = Today.Date
        End If
    End Sub

    Private Sub DateDatang_ValueChanged(sender As Object, e As EventArgs) Handles DateDatang.ValueChanged
        If mode = "Tambah" And DateDatang.Value < Today.Date Then
            MessageBox.Show("Tanggal Kedatangan Barang tidak boleh sebelum hari ini.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DateDatang.Value = Today.Date
        End If
    End Sub

    Private Sub DateBeli_ValueChanged(sender As Object, e As EventArgs) Handles DateBeli.ValueChanged
        If mode = "Tambah" And DateBeli.Value < Today.Date Then
            MessageBox.Show("Tanggal Pembelian tidak boleh sebelum hari ini.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DateBeli.Value = Today.Date
        End If
    End Sub


    'Menampung barang yg dipilih ke View terpisah
    Private Function GetTableOfSelectedRows(ByVal view As GridView) As DataTable
        Dim resultTable As New DataTable

        If TypeOf view.DataSource Is DataView Then
            Dim sourceTable As DataTable = CType(view.DataSource, DataView).Table
            resultTable = sourceTable.Clone()
            Dim rowHandle As Integer

            For Each rowHandle In view.GetSelectedRows()
                Dim row As DataRow = view.GetDataRow(rowHandle)
                resultTable.Rows.Add(row.ItemArray)
            Next rowHandle
            resultTable.AcceptChanges()
        End If

        Return resultTable
    End Function

    'Menampilkan barang yg dipilih saja
    Private Sub cbBarang_CheckedChanged(sender As Object, e As EventArgs) Handles cbBarang.CheckedChanged
        If cbBarang.Checked = True Then
            counter = GetTableOfSelectedRows(ViewPembelian).Rows.Count
            ListBro = New Object(counter - 1) {}

            Dim dtBro As DataTable = GetTableOfSelectedRows(ViewPembelian)
            GridPembelian.DataSource = dtBro
            ViewPembelian.SelectAll()

            For j = 0 To counter - 1
                ListBro(j) = GetTableOfSelectedRows(ViewPembelian).Rows(j)("Kode")
            Next
        Else
            SemuaBarang()
            Dim i As Integer = 0
            Do While i < counter
                ViewPembelian.FocusedRowHandle = ViewPembelian.LocateByValue("Kode", ListBro(i))
                ViewPembelian.SelectRow(ViewPembelian.FocusedRowHandle)
                i += 1
            Loop
        End If
    End Sub


    'Prosedur tampung barang 
    Sub TampungBarang()
        Dim rowHandles As Integer() = ViewPembelian.GetSelectedRows()
        RowKeys = New Object(rowHandles.Length - 1) {}
        Qty = New Object(rowHandles.Length - 1) {}
        Harga = New Object(rowHandles.Length - 1) {}
        Dim i As Integer = 0

        Do While i < rowHandles.Length
            RowKeys(i) = ViewPembelian.GetRowCellValue(rowHandles(i), "Kode")
            Qty(i) = ViewPembelian.GetRowCellValue(rowHandles(i), "Qty")
            Harga(i) = ViewPembelian.GetRowCellValue(rowHandles(i), "Harga Unit")
            i += 1
        Loop
    End Sub

    'Menampung barang yang dipilih
    Private Sub ViewPembelian_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles ViewPembelian.SelectionChanged
        If mode = "Tambah" Then
            Try
                TampungBarang()

                If RowKeys.Count < 1 Then
                    btSimpan.Enabled = False
                Else
                    btSimpan.Enabled = True
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub


    'Insert ke database (t_pembelian , d_pembelian)
    Private Sub btSimpan_Click(sender As Object, e As EventArgs) Handles btSimpan.Click
        'Open Connection
        con.Open()

        'Status untuk cek apakah insert/update berhasil
        Dim status = 0
        Dim status1 = 0
        Dim status2 = 0

        'Mengambil nilai Grand Total
        Dim Gtotal As String = ViewPembelian.Columns("Subtotal").SummaryText
        Gtotal = Gtotal.Replace(",", "")

        If mode = "Tambah" Then
            Try
                GeneratePO()
                TampungBarang()

                'Insert ke tabel t_pembelian
                Dim sql As String = "INSERT into t_pembelian
                                     VALUES('" & BoxNota.Text & "', '" & DateBeli.Value.Date.ToString("yyyy-MM-dd") & "', '" & DateDatang.Value.Date.ToString("yyyy-MM-dd") & "',
                                            '" & BoxSupp.EditValue.ToString & "', '" & BoxKontak.Text & "', '" & StatBarang & "', '" & StatBayar & "', '" & Gtotal & "', '" & DateJtempo.Value.ToString("yyyy-MM-dd") & "'," & tglterima & ", '" & BoxCatatan.Text & "')"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                status = 1

                'Jika insert ke t_pembelian berhasil, baru melakukan insert d_pembelian
                If status = 1 Then
                    'Insert ke tabel d_pembelian
                    For i = 0 To ViewPembelian.SelectedRowsCount - 1
                        Dim sql2 As String = "INSERT into d_pembelian
                                              VALUES('" & BoxNota.Text & "', '" & RowKeys(i) & "', '" & Qty(i) & "', '" & Harga(i) & "', 0);"
                        cmd = New MySqlCommand(sql2, con)
                        cmd.ExecuteNonQuery()
                    Next
                    status1 = 1
                End If

                'Masuk ke form Riwayat Pembelian setelah proses diatas berhasil 
                If status = 1 And status1 = 1 Then
                    FormMenu.OpenRiwayatBeli()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Dispose()
            End Try

        ElseIf mode = "Edit" Then

            Try
                'Update tabel t_pembelian
                Dim sql As String = "UPDATE t_pembelian
                                     SET tgl_kedatangan = '" & DateDatang.Value.ToString("yyyy-MM-dd") & "', id_supplier = '" & BoxSupp.EditValue.ToString & "', kontak = '" & BoxKontak.Text & "', status_barang = '" & StatBarang & "', status_bayar = '" & StatBayar & "',
                                         jatuh_tempo = '" & DateJtempo.Value.ToString("yyyy-MM-dd") & "', tgl_terima = " & tglterima & ", catatan = '" & BoxCatatan.Text & "'
                                     WHERE no_nota = '" & BoxNota.Text & "' ;"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                status2 = 1
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Dispose()
            End Try

        End If

        'Update stok barang
        Dim statStok = 0
        Try
            If (status = 1 And status1 = 1) Or status2 = 1 Then
                If StatBarang = 1 Then
                    For i = 0 To ViewPembelian.DataRowCount - 1
                        Dim kodebar = ViewPembelian.GetRowCellValue(i, "Kode")

                        'Open Connection
                        con.Open()

                        'Query stok barang nya + ditambahkan dengan QTY pembelian
                        Dim query = "SELECT kode_barang, stok1 FROM master_barang WHERE kode_barang = '" & kodebar & "';"
                        adap = New MySqlDataAdapter(query, con)
                        Dim dts As New DataTable
                        adap.Fill(dts)
                        Dim Cstok = dts.Rows(0)("stok1").ToString
                        Dim Nstok = Cstok + ViewPembelian.GetRowCellValue(i, "Qty")

                        'Update stok
                        Dim sql As String = "UPDATE master_barang SET stok1 = '" & Nstok & "' WHERE kode_barang = '" & kodebar & "';"
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                        'Close connection
                        con.Close()
                    Next
                    statStok = 1
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Dispose()
        End Try

        'Close connection
        con.Close()

        'Tampilkan notif jika Insert/Update berhasil
        If (status = 1 And status1 = 1) Or status2 = 1 Then
            If statStok = 1 Then
                MessageBox.Show("Berhasil menyimpan pembelian " & BoxNota.Text, "Pembelian", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If

    End Sub

End Class