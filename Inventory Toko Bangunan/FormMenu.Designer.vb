<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.MdiManager = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BtNewBeli = New DevExpress.XtraBars.BarButtonItem()
        Me.BtRiwayatBeli = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.btSupplier = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btBarang = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.btPembelian = New DevExpress.XtraEditors.DropDownButton()
        Me.PopupPembelian = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.btPenjualan = New DevExpress.XtraEditors.DropDownButton()
        Me.PopupPenjualan = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btNewSales = New DevExpress.XtraBars.BarButtonItem()
        Me.btRiwayatSales = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.btNewJual = New DevExpress.XtraBars.BarButtonItem()
        Me.btRiwayatJual = New DevExpress.XtraBars.BarLargeButtonItem()
        CType(Me.MdiManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLeft.SuspendLayout()
        CType(Me.PopupPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MdiManager
        '
        Me.MdiManager.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MdiManager.AppearancePage.Header.Options.UseFont = True
        Me.MdiManager.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MdiManager.AppearancePage.HeaderActive.Options.UseFont = True
        Me.MdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders
        Me.MdiManager.MdiParent = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(20, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1240, 40)
        Me.Panel1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1240, 40)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TB. ANUGERAH JAYA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BtNewBeli, Me.BtRiwayatBeli})
        Me.BarManager1.MaxItemId = 2
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(20, 60)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1240, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(20, 700)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1240, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(20, 60)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 640)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1260, 60)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 640)
        '
        'BtNewBeli
        '
        Me.BtNewBeli.Caption = "Pembelian Baru"
        Me.BtNewBeli.Id = 0
        Me.BtNewBeli.ImageOptions.Image = CType(resources.GetObject("BtNewBeli.ImageOptions.Image"), System.Drawing.Image)
        Me.BtNewBeli.ImageOptions.LargeImage = CType(resources.GetObject("BtNewBeli.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtNewBeli.ItemAppearance.Hovered.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtNewBeli.ItemAppearance.Hovered.Options.UseFont = True
        Me.BtNewBeli.ItemAppearance.Normal.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtNewBeli.ItemAppearance.Normal.Options.UseFont = True
        Me.BtNewBeli.Name = "BtNewBeli"
        '
        'BtRiwayatBeli
        '
        Me.BtRiwayatBeli.Caption = "Riwayat Pembelian"
        Me.BtRiwayatBeli.Id = 1
        Me.BtRiwayatBeli.ImageOptions.Image = CType(resources.GetObject("BtRiwayatBeli.ImageOptions.Image"), System.Drawing.Image)
        Me.BtRiwayatBeli.ImageOptions.LargeImage = CType(resources.GetObject("BtRiwayatBeli.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtRiwayatBeli.ItemAppearance.Hovered.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtRiwayatBeli.ItemAppearance.Hovered.Options.UseFont = True
        Me.BtRiwayatBeli.ItemAppearance.Normal.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtRiwayatBeli.ItemAppearance.Normal.Options.UseFont = True
        Me.BtRiwayatBeli.Name = "BtRiwayatBeli"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'btSupplier
        '
        Me.btSupplier.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSupplier.Appearance.Options.UseFont = True
        Me.btSupplier.Appearance.Options.UseTextOptions = True
        Me.btSupplier.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSupplier.ImageOptions.Image = CType(resources.GetObject("btSupplier.ImageOptions.Image"), System.Drawing.Image)
        Me.btSupplier.Location = New System.Drawing.Point(3, 90)
        Me.btSupplier.Name = "btSupplier"
        Me.btSupplier.Size = New System.Drawing.Size(134, 40)
        Me.btSupplier.TabIndex = 2
        Me.btSupplier.Text = "Pemasok"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MASTER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btBarang
        '
        Me.btBarang.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBarang.Appearance.Options.UseFont = True
        Me.btBarang.Appearance.Options.UseTextOptions = True
        Me.btBarang.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btBarang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btBarang.ImageOptions.Image = CType(resources.GetObject("btBarang.ImageOptions.Image"), System.Drawing.Image)
        Me.btBarang.Location = New System.Drawing.Point(3, 44)
        Me.btBarang.Name = "btBarang"
        Me.btBarang.Size = New System.Drawing.Size(134, 40)
        Me.btBarang.TabIndex = 4
        Me.btBarang.Text = "Barang"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "TRANSAKSI"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btCustomer
        '
        Me.btCustomer.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCustomer.Appearance.Options.UseFont = True
        Me.btCustomer.Appearance.Options.UseTextOptions = True
        Me.btCustomer.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCustomer.ImageOptions.Image = CType(resources.GetObject("btCustomer.ImageOptions.Image"), System.Drawing.Image)
        Me.btCustomer.Location = New System.Drawing.Point(3, 136)
        Me.btCustomer.Name = "btCustomer"
        Me.btCustomer.Size = New System.Drawing.Size(134, 40)
        Me.btCustomer.TabIndex = 6
        Me.btCustomer.Text = "Pelanggan"
        '
        'btPembelian
        '
        Me.btPembelian.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPembelian.Appearance.Options.UseFont = True
        Me.btPembelian.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btPembelian.DropDownControl = Me.PopupPembelian
        Me.btPembelian.ImageOptions.Image = CType(resources.GetObject("btPembelian.ImageOptions.Image"), System.Drawing.Image)
        Me.btPembelian.Location = New System.Drawing.Point(3, 260)
        Me.btPembelian.Name = "btPembelian"
        Me.btPembelian.Size = New System.Drawing.Size(134, 40)
        Me.btPembelian.TabIndex = 7
        Me.btPembelian.Text = "Pembelian"
        '
        'PopupPembelian
        '
        Me.PopupPembelian.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BtNewBeli), New DevExpress.XtraBars.LinkPersistInfo(Me.BtRiwayatBeli)})
        Me.PopupPembelian.Manager = Me.BarManager1
        Me.PopupPembelian.Name = "PopupPembelian"
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelLeft.Controls.Add(Me.btPenjualan)
        Me.PanelLeft.Controls.Add(Me.btPembelian)
        Me.PanelLeft.Controls.Add(Me.btCustomer)
        Me.PanelLeft.Controls.Add(Me.Label2)
        Me.PanelLeft.Controls.Add(Me.btBarang)
        Me.PanelLeft.Controls.Add(Me.Label1)
        Me.PanelLeft.Controls.Add(Me.btSupplier)
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Location = New System.Drawing.Point(20, 100)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(140, 600)
        Me.PanelLeft.TabIndex = 2
        '
        'btPenjualan
        '
        Me.btPenjualan.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPenjualan.Appearance.Options.UseFont = True
        Me.btPenjualan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btPenjualan.DropDownControl = Me.PopupPenjualan
        Me.btPenjualan.ImageOptions.Image = CType(resources.GetObject("btPenjualan.ImageOptions.Image"), System.Drawing.Image)
        Me.btPenjualan.Location = New System.Drawing.Point(3, 306)
        Me.btPenjualan.Name = "btPenjualan"
        Me.btPenjualan.Size = New System.Drawing.Size(134, 40)
        Me.btPenjualan.TabIndex = 8
        Me.btPenjualan.Text = "Penjualan"
        '
        'PopupPenjualan
        '
        Me.PopupPenjualan.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btNewSales), New DevExpress.XtraBars.LinkPersistInfo(Me.btRiwayatSales)})
        Me.PopupPenjualan.Manager = Me.BarManager2
        Me.PopupPenjualan.Name = "PopupPenjualan"
        '
        'btNewSales
        '
        Me.btNewSales.Caption = "Penjualan Baru"
        Me.btNewSales.Id = 2
        Me.btNewSales.ImageOptions.Image = CType(resources.GetObject("btNewSales.ImageOptions.Image"), System.Drawing.Image)
        Me.btNewSales.ImageOptions.LargeImage = CType(resources.GetObject("btNewSales.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btNewSales.ItemAppearance.Hovered.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNewSales.ItemAppearance.Hovered.Options.UseFont = True
        Me.btNewSales.ItemAppearance.Normal.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNewSales.ItemAppearance.Normal.Options.UseFont = True
        Me.btNewSales.ItemAppearance.Pressed.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNewSales.ItemAppearance.Pressed.Options.UseFont = True
        Me.btNewSales.Name = "btNewSales"
        '
        'btRiwayatSales
        '
        Me.btRiwayatSales.Caption = "Riwayat Penjualan"
        Me.btRiwayatSales.Id = 3
        Me.btRiwayatSales.ImageOptions.Image = CType(resources.GetObject("btRiwayatSales.ImageOptions.Image"), System.Drawing.Image)
        Me.btRiwayatSales.ImageOptions.LargeImage = CType(resources.GetObject("btRiwayatSales.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btRiwayatSales.ItemAppearance.Hovered.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRiwayatSales.ItemAppearance.Hovered.Options.UseFont = True
        Me.btRiwayatSales.ItemAppearance.Normal.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRiwayatSales.ItemAppearance.Normal.Options.UseFont = True
        Me.btRiwayatSales.ItemAppearance.Pressed.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRiwayatSales.ItemAppearance.Pressed.Options.UseFont = True
        Me.btRiwayatSales.Name = "btRiwayatSales"
        '
        'BarManager2
        '
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btNewJual, Me.btRiwayatJual, Me.btNewSales, Me.btRiwayatSales})
        Me.BarManager2.MaxItemId = 4
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(20, 60)
        Me.BarDockControl1.Manager = Me.BarManager2
        Me.BarDockControl1.Size = New System.Drawing.Size(1240, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(20, 700)
        Me.BarDockControl2.Manager = Me.BarManager2
        Me.BarDockControl2.Size = New System.Drawing.Size(1240, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(20, 60)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 640)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1260, 60)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 640)
        '
        'btNewJual
        '
        Me.btNewJual.Caption = "Penjualan Baru"
        Me.btNewJual.Id = 0
        Me.btNewJual.ImageOptions.Image = CType(resources.GetObject("btNewJual.ImageOptions.Image"), System.Drawing.Image)
        Me.btNewJual.ImageOptions.LargeImage = CType(resources.GetObject("btNewJual.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btNewJual.ItemAppearance.Hovered.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNewJual.ItemAppearance.Hovered.Options.UseFont = True
        Me.btNewJual.ItemAppearance.Normal.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNewJual.ItemAppearance.Normal.Options.UseFont = True
        Me.btNewJual.Name = "btNewJual"
        '
        'btRiwayatJual
        '
        Me.btRiwayatJual.Caption = "Riwayat Penjualan"
        Me.btRiwayatJual.Id = 1
        Me.btRiwayatJual.ImageOptions.Image = CType(resources.GetObject("btRiwayatJual.ImageOptions.Image"), System.Drawing.Image)
        Me.btRiwayatJual.ImageOptions.LargeImage = CType(resources.GetObject("btRiwayatJual.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btRiwayatJual.ItemAppearance.Hovered.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRiwayatJual.ItemAppearance.Hovered.Options.UseFont = True
        Me.btRiwayatJual.ItemAppearance.Normal.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRiwayatJual.ItemAppearance.Normal.Options.UseFont = True
        Me.btRiwayatJual.Name = "btRiwayatJual"
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.PanelLeft)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.IsMdiContainer = True
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "FormMenu"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Text = "INVENTORY MANAGER"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.TransparencyKey = System.Drawing.Color.Empty
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MdiManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLeft.ResumeLayout(False)
        CType(Me.PopupPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MdiManager As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents btPembelian As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents btCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As Label
    Friend WithEvents btBarang As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btSupplier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents BtNewBeli As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtRiwayatBeli As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents PopupPembelian As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btPenjualan As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btNewJual As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btRiwayatJual As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents PopupPenjualan As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btNewSales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btRiwayatSales As DevExpress.XtraBars.BarButtonItem
End Class
