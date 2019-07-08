Imports MySql.Data.MySqlClient
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class MasterBarang

    'Variable
    Public kode, barang, kategori, satuan1, satuan2 As String
    Public stok1, stok2, hBeli, hJual, hBeli2, hJual2 As Integer

    'Auto fit row
    Sub RowAuto()
        GridBarang.ForceInitialize()
        ViewBarang.BestFitColumns()
    End Sub

    'Query data barang
    Sub QueryBarang()
        Dim dtbarang As New DataTable
        Dim query As String = "SELECT b.kode_barang AS `Kode`, b.Nama_Barang AS `Nama Barang`, Kategori, Stok1, Satuan1, IF(Stok2 = NULL, 0, stok2) AS `Stok2`, Satuan2, h_beli1 AS `Harga Beli 1`, h_jual1 AS `Harga Jual 1`, h_beli2 AS `Harga Beli 2`, h_jual2 AS `Harga Jual 2`,
                               IF(`status`='A','Aktif',IF(`status`='NA','Non-Aktif',IF(`status`='CT','Cepat Terjual',IF(`status`='LT','Lama Terjual','Tidak Laku')))) `Status`
                               FROM master_barang b, (SELECT t1.*
                                                      FROM t_harga t1
                                                      WHERE t1.tgl = (SELECT t2.tgl
                                                                      FROM t_harga t2
                                                                      WHERE t2.kode_barang = t1.kode_barang            
                                                                      ORDER BY t2.tgl DESC
                                                                      LIMIT 1)) AS h
                                WHERE b.kode_barang = h.kode_barang
                                ORDER BY 3,2;"
        adap = New MySqlDataAdapter(query, con)
        adap.Fill(dtbarang)
        GridBarang.DataSource = dtbarang
    End Sub

    'Prosedur New Barang
    Sub NewBarang()
        Try
            Dim frm As MasterBarang_Detail = New MasterBarang_Detail With {.Text = "Tambah Barang", .mode = "Tambah"}
            FormMenu.openchild(frm)
        Catch ex As Exception
        End Try
    End Sub

    'Prosedur Detail Barang
    Sub DBarang()
        Try
            Dim frm As MasterBarang_Detail = MasterBarang_Detail
            frm.mode = "Edit"
            FormMenu.openchild(frm)
            frm.Select()
        Catch ex As Exception
        End Try
    End Sub


    'Load form
    Public Sub MasterBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            QueryBarang()
            ViewBarang.Columns("Kode").Visible = False
            ViewBarang.Columns("Harga Beli 1").Visible = False
            ViewBarang.Columns("Harga Beli 2").Visible = False
            RowAuto()
        Catch ex As Exception

        End Try
    End Sub

    'Tambah barang
    Private Sub btAddBarang_Click(sender As Object, e As EventArgs) Handles btAddBarang.Click
        NewBarang()
    End Sub

    'Refresh button
    Private Sub btRefresh_Click_1(sender As Object, e As EventArgs) Handles btRefresh.Click
        MasterBarang_Load(sender, e)
    End Sub

    'Form Impor Barang
    Private Sub btImport_Click(sender As Object, e As EventArgs) Handles btImport.Click
        ImportBarang.ShowDialog()
    End Sub

    'Display pemisah ribuan
    Private Sub ViewBarang_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles ViewBarang.CustomColumnDisplayText
        Try
            If e.Column.FieldName = "Harga Jual 1" Or e.Column.FieldName = "Harga Jual 2" Then
                e.DisplayText = String.Format("{0:n0}", e.Value)
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Menampilkan detail barang saat Double Click
    Private Sub ViewBarang_DoubleClick(sender As Object, e As EventArgs) Handles ViewBarang.DoubleClick
        Try
            Dim ea As DXMouseEventArgs = TryCast(e, DXMouseEventArgs)
            Dim view As GridView = TryCast(sender, GridView)
            Dim info As GridHitInfo = view.CalcHitInfo(ea.Location)
            If info.InRow OrElse info.InRowCell Then
                kode = ViewBarang.GetFocusedRowCellValue("Kode")
                barang = ViewBarang.GetFocusedRowCellValue("Nama Barang")
                kategori = ViewBarang.GetFocusedRowCellValue("Kategori")
                stok1 = ViewBarang.GetFocusedRowCellValue("Stok1")
                satuan1 = ViewBarang.GetFocusedRowCellValue("Satuan1")
                stok2 = ViewBarang.GetFocusedRowCellValue("Stok2")
                satuan2 = ViewBarang.GetFocusedRowCellValue("Satuan2")
                hBeli = ViewBarang.GetFocusedRowCellValue("Harga Beli 1")
                hJual = ViewBarang.GetFocusedRowCellValue("Harga Jual 1")
                hBeli2 = ViewBarang.GetFocusedRowCellValue("Harga Beli 2")
                hJual2 = ViewBarang.GetFocusedRowCellValue("Harga Jual 2")

                MasterBarang_Detail.Text = "Barang (" & barang & ")"
                DBarang()
                MasterBarang_Detail.MasterBarang_Detail_Load(sender, e)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function IsDBNull(v1 As Object, empty As String, v2 As Object) As Object
        Throw New NotImplementedException()
    End Function

End Class