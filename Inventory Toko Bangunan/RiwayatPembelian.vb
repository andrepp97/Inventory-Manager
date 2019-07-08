Imports MySql.Data.MySqlClient
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class RiwayatPembelian

    'Variabel
    Public nota, tglbeli, tgldatang, jtempo, supp, catatan As String
    Public sBarang, sBayar As Boolean

    'Query Pembelian
    Sub QueryPembelian()
        Dim dt As New DataTable
        Dim sql = "SELECT no_nota `No. Pembelian`, tgl_beli `Tgl Pembelian`, tgl_kedatangan `Tgl Kedatangan`, nama_supplier `Supplier`,
	               IF(status_barang = 0, 'Belum Masuk', 'Masuk') `Status Barang`, IF(status_bayar = 0, 'Belum Lunas', 'Lunas') `Status Bayar`, Total, jatuh_tempo `Jatuh Tempo`,Catatan
                   FROM t_pembelian p, master_supplier s
                   WHERE p.id_supplier = s.id_supplier;"
        adap = New MySqlDataAdapter(sql, con)
        adap.Fill(dt)
        GridRiwayatBeli.DataSource = dt
    End Sub


    'Load Form
    Sub RiwayatPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            QueryPembelian()
            ViewRiwayatBeli.Columns("Catatan").Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Refresh button
    Private Sub btRefresh_Click(sender As Object, e As EventArgs) Handles btRefresh.Click
        RiwayatPembelian_Load(sender, e)
    End Sub

    'Display text pemisah ribuan
    Private Sub ViewRiwayatBeli_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles ViewRiwayatBeli.CustomColumnDisplayText
        Try
            If e.Column.FieldName = "Total" Then
                e.DisplayText = String.Format("{0:n0}", e.Value)
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Membuka detail Pembelian
    Private Sub ViewRiwayatBeli_DoubleClick(sender As Object, e As EventArgs) Handles ViewRiwayatBeli.DoubleClick
        Try
            Dim ea As DXMouseEventArgs = TryCast(e, DXMouseEventArgs)
            Dim view As GridView = TryCast(sender, GridView)
            Dim info As GridHitInfo = view.CalcHitInfo(ea.Location)
            If info.InRow OrElse info.InRowCell Then
                nota = ViewRiwayatBeli.GetFocusedRowCellValue("No. Pembelian")
                tglbeli = ViewRiwayatBeli.GetFocusedRowCellValue("Tgl Pembelian")
                tgldatang = ViewRiwayatBeli.GetFocusedRowCellValue("Tgl Kedatangan")
                jtempo = ViewRiwayatBeli.GetFocusedRowCellValue("Jatuh Tempo")
                supp = ViewRiwayatBeli.GetFocusedRowCellValue("Supplier")
                catatan = ViewRiwayatBeli.GetFocusedRowCellValue("Catatan")

                If ViewRiwayatBeli.GetFocusedRowCellValue("Status Barang") = "Masuk" Then
                    sBarang = True
                Else
                    sBarang = False
                End If

                If ViewRiwayatBeli.GetFocusedRowCellValue("Status Bayar") = "Lunas" Then
                    sBayar = True
                Else
                    sBayar = False
                End If

                'Open the form
                FormPembelian.mode = "Edit"
                Dim frm As FormPembelian = FormPembelian
                FormMenu.openchild(frm)
                FormPembelian.Select()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function IsDBNull(v1 As Object, empty As String, v2 As Object) As Object
        Throw New NotImplementedException()
    End Function

End Class