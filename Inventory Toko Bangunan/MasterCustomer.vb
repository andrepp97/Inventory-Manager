Imports MySql.Data.MySqlClient
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class MasterCustomer

    'Variabel
    Public id, hutang As Integer
    Public cust, alamat, telp As String

    'Auto fit row
    Sub RowAuto()
        GridCust.ForceInitialize()
        ViewCust.BestFitColumns()
    End Sub

    'Query Customer
    Sub QueryCust()
        Dim dtcust As New DataTable
        Dim query As String = "SELECT id_cust, nama_cust `Nama Customer`, Alamat, telepon `Telp`, saldo_hutang `Saldo Hutang`
                               FROM master_customer
                               WHERE void = 0;"
        adap = New MySqlDataAdapter(query, con)
        adap.Fill(dtcust)
        GridCust.DataSource = dtcust
    End Sub


    'Load Form
    Public Sub MasterCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            QueryCust()
            ViewCust.Columns("id_cust").Visible = False
            RowAuto()
        Catch ex As Exception

        End Try
    End Sub

    'Tambah customer
    Private Sub btAddCust_Click(sender As Object, e As EventArgs) Handles btAddCust.Click
        MasterCustomer_Detail.mode = "Tambah"
        MasterCustomer_Detail.ShowDialog()
    End Sub

    'Refresh button
    Private Sub btRefresh_Click(sender As Object, e As EventArgs) Handles btRefresh.Click
        MasterCustomer_Load(sender, e)
    End Sub

    'Membuka detail Customer
    Private Sub ViewCust_DoubleClick(sender As Object, e As EventArgs) Handles ViewCust.DoubleClick
        Try
            Dim ea As DXMouseEventArgs = TryCast(e, DXMouseEventArgs)
            Dim view As GridView = TryCast(sender, GridView)
            Dim info As GridHitInfo = view.CalcHitInfo(ea.Location)
            If info.InRow OrElse info.InRowCell Then
                id = ViewCust.GetFocusedRowCellValue("id_cust")
                cust = ViewCust.GetFocusedRowCellValue("Nama Customer")
                alamat = ViewCust.GetFocusedRowCellValue("Alamat")
                telp = ViewCust.GetFocusedRowCellValue("Telp")
                hutang = ViewCust.GetFocusedRowCellValue("Saldo Hutang")

                MasterCustomer_Detail.mode = "Edit"
                MasterCustomer_Detail.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class