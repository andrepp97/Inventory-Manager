Public Class FormMenu

    Sub btDisable()
        btSupplier.Enabled = False
        btCustomer.Enabled = False
        btBarang.Enabled = False
    End Sub

    Sub btEnable()
        btBarang.Enabled = True
        btCustomer.Enabled = True
        btSupplier.Enabled = True
    End Sub

    'Prosedur open Form Barang
    Sub OpenBarang()
        Try
            btDisable()
            Dim frm As MasterBarang = MasterBarang
            openchild(frm)
            frm.Select()
        Catch ex As Exception

        Finally
            btEnable()
        End Try
    End Sub

    'Prosedur Open new Form Penjualan
    Sub OpenPenjualan()
        Try
            btDisable()
            Dim frm As FormPenjualan = New FormPenjualan With {
                .mode = "Tambah"
            }
            openchild(frm)
            frm.Select()
        Catch ex As Exception

        Finally
            btEnable()
        End Try
    End Sub

    'Prosedur Open new Form Pembelian
    Sub OpenPembelian()
        Try
            btDisable()
            Dim frm As FormPembelian = New FormPembelian With {
                .mode = "Tambah"
            }
            openchild(frm)
            frm.Select()
        Catch ex As Exception

        Finally
            btEnable()
        End Try
    End Sub

    'Prosedur Open Riwayat Pembelian
    Sub OpenRiwayatBeli()
        Try
            btDisable()
            Dim frm As RiwayatPembelian = RiwayatPembelian
            openchild(frm)
            frm.Select()
        Catch ex As Exception

        Finally
            btEnable()
        End Try
    End Sub

    'Prosedur membuka ChildForm di MDI Manager
    Public Sub openchild(frm As Form)
        frm.MdiParent = Me
        frm.Show()
    End Sub


    'Load form
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Membuka form Barang
    Private Sub btBarang_Click(sender As Object, e As EventArgs) Handles btBarang.Click
        OpenBarang()
    End Sub

    'Membuka form Supplier
    Private Sub btKonversi_Click(sender As Object, e As EventArgs) Handles btSupplier.Click
        Try
            btDisable()
            Dim frm As MasterSupplier = MasterSupplier
            openchild(frm)
            MasterSupplier.Select()
        Catch ex As Exception

        Finally
            btEnable()
        End Try
    End Sub

    'Membuka form Customer
    Private Sub btCustomer_Click(sender As Object, e As EventArgs) Handles btCustomer.Click
        Try
            btDisable()
            Dim frm As MasterCustomer = MasterCustomer
            openchild(frm)
            MasterCustomer.Select()
        Catch ex As Exception

        Finally
            btEnable()
        End Try
    End Sub


    'DropDown Button
    Private Sub btPembelian_click(sender As Object, e As EventArgs) Handles btPembelian.Click
        btPembelian.ShowDropDown()
    End Sub

    Private Sub btPenjualan_Click(sender As Object, e As EventArgs) Handles btPenjualan.Click
        btPenjualan.ShowDropDown()
    End Sub


    'Open Form Penjualan
    Private Sub btNewSales_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btNewSales.ItemClick
        OpenPenjualan()
    End Sub

    'Open Form Pembelian
    Private Sub BtNewBeli_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtNewBeli.ItemClick
        OpenPembelian()
    End Sub

    'Open Form Riwayat Pembelian
    Private Sub BtRiwayatBeli_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtRiwayatBeli.ItemClick
        OpenRiwayatBeli()
    End Sub


    'Exit form
    Private Sub FormMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As Integer = MessageBox.Show("Anda yakin ingin keluar ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    'Tutup form Auth setelah form utama ditutup
    Private Sub FormMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormAuth.Close()
    End Sub

End Class