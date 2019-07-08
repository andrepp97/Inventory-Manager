Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns

Public Class FormPenjualan

    Public mode As String

    'Query pelanggan
    Sub LoadCustomer()
        Dim dtcus As New DataTable
        Dim query As String = "SELECT id_cust `ID`, nama_cust `Pelanggan`, Alamat, Telepon `Telp`
                               FROM master_customer WHERE void <> 1;"
        adap = New MySqlDataAdapter(query, con)
        adap.Fill(dtcus)
        BoxCust.Properties.DataSource = dtcus
        BoxCust.Properties.DisplayMember = "Pelanggan"
        BoxCust.Properties.ValueMember = "ID"
    End Sub

    'Query semua barang
    Sub SemuaBarang()
        Dim dtbarang As New DataTable
        Dim query As String = "SELECT kode_barang AS `Kode`, nama_barang AS `Barang`, Kategori
                               FROM master_barang
                               WHERE `status` <> 'NA'
                               ORDER BY 3,2;"
        adap = New MySqlDataAdapter(query, con)
        adap.Fill(dtbarang)
        SearchBarang.DataSource = dtbarang
        SearchBarang.DisplayMember = "Barang"
        SearchBarang.ValueMember = "Kode"
    End Sub

    'Generate nomor penjualan
    Sub GenerateINV()
        Try
            Dim inv As String
            Dim todate As String = Year(Today) & Month(Today) & DateTime.Now.Day

            Dim dtdate As New DataTable
            Dim query As String = "SELECT no_nota FROM t_penjualan WHERE no_nota like '%" & todate & "%';"
            adap = New MySqlDataAdapter(query, con)
            adap.Fill(dtdate)

            inv = "PO-" & todate & "-" & dtdate.Rows.Count + 1
            BoxNota.Text = inv
        Catch ex As Exception

        End Try
    End Sub


    'Load Form
    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadCustomer()

            If mode = "Tambah" Then
                GenerateINV()
                SemuaBarang()
                RadioTipe.SelectedIndex = 0

                'Initial row for GridView penjualan
                Dim dtnull As New DataTable
                dtnull.Columns.Add("Barang")
                dtnull.Columns.Add("Stok")
                dtnull.Columns.Add("Qty")
                dtnull.Columns.Add("Harga Unit")
                dtnull.Columns.Add("Subtotal")
                dtnull.Rows.Add("", "Stok Utama", 0, 0, 0)
                GridPenjualan.DataSource = dtnull

                'Column uneditable & visible
                ViewPenjualan.Columns("Subtotal").OptionsColumn.AllowEdit = False
            ElseIf mode = "Edit" Then

            End If

            'Footer untuk Grand Total
            ViewPenjualan.Columns("Harga Unit").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
            ViewPenjualan.Columns("Harga Unit").SummaryItem.FieldName = "Harga Unit"
            ViewPenjualan.Columns("Harga Unit").SummaryItem.DisplayFormat = "Grand Total :"

            ViewPenjualan.Columns("Subtotal").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            ViewPenjualan.Columns("Subtotal").SummaryItem.FieldName = "Subtotal"
            ViewPenjualan.Columns("Subtotal").SummaryItem.DisplayFormat = "{0:n0}"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Memilih tipe pembeli
    Private Sub RadioTipe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioTipe.SelectedIndexChanged
        If RadioTipe.SelectedIndex = 0 Then
            BoxCust.Enabled = False
        Else
            BoxCust.Enabled = True
        End If
    End Sub


    'Menghitung Subtotal barang
    Private flag As Boolean = False
    Private Sub ViewPenjualan_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles ViewPenjualan.CellValueChanged
        Dim view As GridView = TryCast(sender, GridView)
        If e.Column.FieldName = "Qty" AndAlso (Not flag) Then
            Dim subtot = e.Value * view.GetRowCellValue(e.RowHandle, "Harga Unit")
            flag = True
            ViewPenjualan.SetRowCellValue(e.RowHandle, "Subtotal", subtot)
            flag = False
        ElseIf e.Column.FieldName = "Harga Unit" AndAlso (Not flag) Then
            Dim subtot = e.Value * view.GetRowCellValue(e.RowHandle, "Qty")
            flag = True
            ViewPenjualan.SetRowCellValue(e.RowHandle, "Subtotal", subtot)
            flag = False
        End If
    End Sub

End Class