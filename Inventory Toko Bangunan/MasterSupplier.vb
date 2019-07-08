Imports MySql.Data.MySqlClient
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class MasterSupplier

    'Variabel
    Public id_supp, supp, alamat, kota, kontak, telp As String

    'Query master_supplier
    Sub LoadSupplier()
        Dim dtsupp As New DataTable
        Dim query As String = "SELECT id_supplier, nama_supplier as `Nama Pemasok`, Alamat, Kota
                               FROM master_supplier
                               WHERE void = 0  order by 2 ;"
        adap = New MySqlDataAdapter(query, con)
        adap.Fill(dtsupp)
        GridSupplier.DataSource = dtsupp
    End Sub


    'Form Load
    Private Sub MasterSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadSupplier()

            GridSupplier.ForceInitialize()
            ViewSupplier.BestFitColumns()
            ViewSupplier.Columns("id_supplier").Visible = False
        Catch ex As Exception

        End Try
    End Sub

    'Refresh supplier
    Public Sub btRefresh_Click(sender As Object, e As EventArgs) Handles btRefresh.Click
        MasterSupplier_Load(sender, e)
    End Sub

    'Tambah Supplier
    Private Sub btAddSupp_Click(sender As Object, e As EventArgs) Handles btAddSupp.Click
        MasterSupplier_Detail.mode = "Tambah"
        MasterSupplier_Detail.ShowDialog()
    End Sub

    'Membuka detail supplier
    Private Sub ViewSupplier_DoubleClick(sender As Object, e As EventArgs) Handles ViewSupplier.DoubleClick
        Try
            Dim ea As DXMouseEventArgs = TryCast(e, DXMouseEventArgs)
            Dim view As GridView = TryCast(sender, GridView)
            Dim info As GridHitInfo = view.CalcHitInfo(ea.Location)
            If info.InRow OrElse info.InRowCell Then
                id_supp = ViewSupplier.GetFocusedRowCellValue("id_supplier")
                supp = ViewSupplier.GetFocusedRowCellValue("Nama Pemasok")
                alamat = ViewSupplier.GetFocusedRowCellValue("Alamat")
                kota = ViewSupplier.GetFocusedRowCellValue("Kota")

                MasterSupplier_Detail.mode = "Edit"
                MasterSupplier_Detail.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function IsDBNull(v1 As Object, empty As String, v2 As Object) As Object
        Throw New NotImplementedException()
    End Function

End Class