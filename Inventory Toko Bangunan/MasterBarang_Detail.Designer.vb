<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MasterBarang_Detail
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterBarang_Detail))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btSimpan = New DevExpress.XtraEditors.SimpleButton()
        Me.btAddHarga = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GridHarga = New DevExpress.XtraGrid.GridControl()
        Me.ViewHarga = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BoxHjual2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BoxHbeli2 = New System.Windows.Forms.TextBox()
        Me.BoxStok2 = New System.Windows.Forms.NumericUpDown()
        Me.BoxSatuan2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BoxHjual1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BoxHbeli1 = New System.Windows.Forms.TextBox()
        Me.BoxStok1 = New System.Windows.Forms.NumericUpDown()
        Me.BoxSatuan1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BoxKategori = New DevExpress.XtraEditors.LookUpEdit()
        Me.btAddKategori = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BoxBarang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tipHarga = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipHarga2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.GridHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BoxStok2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.BoxStok1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.BoxKategori.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.btSimpan)
        Me.Panel4.Controls.Add(Me.btAddHarga)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(20, 20)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1024, 32)
        Me.Panel4.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(762, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(260, 30)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Kolom dengan tanda bintang (*) wajib diisi"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btSimpan
        '
        Me.btSimpan.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSimpan.Appearance.Options.UseFont = True
        Me.btSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSimpan.Enabled = False
        Me.btSimpan.ImageOptions.Image = CType(resources.GetObject("btSimpan.ImageOptions.Image"), System.Drawing.Image)
        Me.btSimpan.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btSimpan.Location = New System.Drawing.Point(10, 3)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(80, 24)
        Me.btSimpan.TabIndex = 2
        Me.btSimpan.Text = "Simpan"
        '
        'btAddHarga
        '
        Me.btAddHarga.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAddHarga.Appearance.Options.UseFont = True
        Me.btAddHarga.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAddHarga.ImageOptions.Image = CType(resources.GetObject("btAddHarga.ImageOptions.Image"), System.Drawing.Image)
        Me.btAddHarga.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btAddHarga.Location = New System.Drawing.Point(105, 3)
        Me.btAddHarga.Name = "btAddHarga"
        Me.btAddHarga.Size = New System.Drawing.Size(92, 24)
        Me.btAddHarga.TabIndex = 3
        Me.btAddHarga.Text = "Harga Baru"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.GridHarga)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(467, 52)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(577, 489)
        Me.Panel5.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Teal
        Me.Label11.Location = New System.Drawing.Point(-1, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 20)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Riwayat Harga"
        '
        'GridHarga
        '
        Me.GridHarga.Location = New System.Drawing.Point(3, 35)
        Me.GridHarga.MainView = Me.ViewHarga
        Me.GridHarga.Name = "GridHarga"
        Me.GridHarga.Size = New System.Drawing.Size(573, 426)
        Me.GridHarga.TabIndex = 27
        Me.GridHarga.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ViewHarga})
        '
        'ViewHarga
        '
        Me.ViewHarga.Appearance.HeaderPanel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewHarga.Appearance.HeaderPanel.Options.UseFont = True
        Me.ViewHarga.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.ViewHarga.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ViewHarga.Appearance.Row.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewHarga.Appearance.Row.Options.UseFont = True
        Me.ViewHarga.GridControl = Me.GridHarga
        Me.ViewHarga.Name = "ViewHarga"
        Me.ViewHarga.OptionsBehavior.Editable = False
        Me.ViewHarga.OptionsCustomization.AllowFilter = False
        Me.ViewHarga.OptionsCustomization.AllowGroup = False
        Me.ViewHarga.OptionsCustomization.AllowSort = False
        Me.ViewHarga.OptionsMenu.EnableColumnMenu = False
        Me.ViewHarga.OptionsMenu.EnableFooterMenu = False
        Me.ViewHarga.OptionsMenu.EnableGroupPanelMenu = False
        Me.ViewHarga.OptionsView.ShowGroupPanel = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(20, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(447, 489)
        Me.Panel1.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Teal
        Me.Label8.Location = New System.Drawing.Point(-4, 308)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 20)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Stok Kedua"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.BoxHjual2)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.BoxHbeli2)
        Me.Panel2.Controls.Add(Me.BoxStok2)
        Me.Panel2.Controls.Add(Me.BoxSatuan2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(0, 331)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(441, 130)
        Me.Panel2.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Harga Jual :"
        '
        'BoxHjual2
        '
        Me.BoxHjual2.Enabled = False
        Me.BoxHjual2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxHjual2.Location = New System.Drawing.Point(107, 90)
        Me.BoxHjual2.Name = "BoxHjual2"
        Me.BoxHjual2.Size = New System.Drawing.Size(316, 26)
        Me.BoxHjual2.TabIndex = 28
        Me.BoxHjual2.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 16)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Harga Beli :"
        '
        'BoxHbeli2
        '
        Me.BoxHbeli2.Enabled = False
        Me.BoxHbeli2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxHbeli2.Location = New System.Drawing.Point(107, 49)
        Me.BoxHbeli2.Name = "BoxHbeli2"
        Me.BoxHbeli2.Size = New System.Drawing.Size(316, 26)
        Me.BoxHbeli2.TabIndex = 27
        Me.BoxHbeli2.Text = "0"
        Me.tipHarga.SetToolTip(Me.BoxHbeli2, "Harga harus diisi dengan nominal. Sistem akan otomatis mengubah nominal menjadi k" &
        "ode.")
        '
        'BoxStok2
        '
        Me.BoxStok2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxStok2.Location = New System.Drawing.Point(107, 12)
        Me.BoxStok2.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.BoxStok2.Name = "BoxStok2"
        Me.BoxStok2.Size = New System.Drawing.Size(120, 26)
        Me.BoxStok2.TabIndex = 25
        Me.BoxStok2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BoxSatuan2
        '
        Me.BoxSatuan2.BackColor = System.Drawing.SystemColors.Info
        Me.BoxSatuan2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BoxSatuan2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BoxSatuan2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxSatuan2.FormattingEnabled = True
        Me.BoxSatuan2.Location = New System.Drawing.Point(241, 11)
        Me.BoxSatuan2.Name = "BoxSatuan2"
        Me.BoxSatuan2.Size = New System.Drawing.Size(182, 28)
        Me.BoxSatuan2.Sorted = True
        Me.BoxSatuan2.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Stok 2 :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Teal
        Me.Label12.Location = New System.Drawing.Point(-4, 142)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 20)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Stok Utama"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.BoxHjual1)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.BoxHbeli1)
        Me.Panel3.Controls.Add(Me.BoxStok1)
        Me.Panel3.Controls.Add(Me.BoxSatuan1)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(0, 165)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(441, 130)
        Me.Panel3.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "*Harga Jual :"
        '
        'BoxHjual1
        '
        Me.BoxHjual1.Enabled = False
        Me.BoxHjual1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxHjual1.Location = New System.Drawing.Point(105, 95)
        Me.BoxHjual1.Name = "BoxHjual1"
        Me.BoxHjual1.Size = New System.Drawing.Size(316, 26)
        Me.BoxHjual1.TabIndex = 24
        Me.BoxHjual1.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "*Harga Beli :"
        '
        'BoxHbeli1
        '
        Me.BoxHbeli1.Enabled = False
        Me.BoxHbeli1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxHbeli1.Location = New System.Drawing.Point(106, 51)
        Me.BoxHbeli1.Name = "BoxHbeli1"
        Me.BoxHbeli1.Size = New System.Drawing.Size(316, 26)
        Me.BoxHbeli1.TabIndex = 23
        Me.BoxHbeli1.Text = "0"
        Me.tipHarga.SetToolTip(Me.BoxHbeli1, "Harga harus diisi dengan nominal. Sistem akan otomatis mengubah nominal menjadi k" &
        "ode.")
        '
        'BoxStok1
        '
        Me.BoxStok1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxStok1.Location = New System.Drawing.Point(106, 11)
        Me.BoxStok1.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.BoxStok1.Name = "BoxStok1"
        Me.BoxStok1.Size = New System.Drawing.Size(120, 26)
        Me.BoxStok1.TabIndex = 21
        Me.BoxStok1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BoxSatuan1
        '
        Me.BoxSatuan1.BackColor = System.Drawing.SystemColors.Info
        Me.BoxSatuan1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BoxSatuan1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BoxSatuan1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxSatuan1.FormattingEnabled = True
        Me.BoxSatuan1.Location = New System.Drawing.Point(241, 10)
        Me.BoxSatuan1.Name = "BoxSatuan1"
        Me.BoxSatuan1.Size = New System.Drawing.Size(180, 28)
        Me.BoxSatuan1.Sorted = True
        Me.BoxSatuan1.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Stok 1 :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(-4, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 20)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Barang"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.BoxKategori)
        Me.Panel6.Controls.Add(Me.btAddKategori)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.BoxBarang)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Location = New System.Drawing.Point(0, 35)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(442, 94)
        Me.Panel6.TabIndex = 27
        '
        'BoxKategori
        '
        Me.BoxKategori.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BoxKategori.EditValue = ""
        Me.BoxKategori.Location = New System.Drawing.Point(106, 53)
        Me.BoxKategori.Name = "BoxKategori"
        Me.BoxKategori.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxKategori.Properties.Appearance.Options.UseFont = True
        Me.BoxKategori.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxKategori.Properties.AppearanceDropDown.Options.UseFont = True
        Me.BoxKategori.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxKategori.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.BoxKategori.Properties.AppearanceDropDownHeader.Options.UseTextOptions = True
        Me.BoxKategori.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BoxKategori.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BoxKategori.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BoxKategori.Properties.ShowFooter = False
        Me.BoxKategori.Properties.ShowHeader = False
        Me.BoxKategori.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BoxKategori.Size = New System.Drawing.Size(264, 26)
        Me.BoxKategori.TabIndex = 33
        '
        'btAddKategori
        '
        Me.btAddKategori.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAddKategori.Image = Global.Inventory_Toko_Bangunan.My.Resources.Resources.add
        Me.btAddKategori.Location = New System.Drawing.Point(387, 52)
        Me.btAddKategori.Name = "btAddKategori"
        Me.btAddKategori.Size = New System.Drawing.Size(36, 27)
        Me.btAddKategori.TabIndex = 18
        Me.btAddKategori.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "*Nama :"
        '
        'BoxBarang
        '
        Me.BoxBarang.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxBarang.Location = New System.Drawing.Point(106, 11)
        Me.BoxBarang.Name = "BoxBarang"
        Me.BoxBarang.Size = New System.Drawing.Size(317, 26)
        Me.BoxBarang.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Kategori :"
        '
        'tipHarga
        '
        Me.tipHarga.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.tipHarga.ToolTipTitle = "Harga Beli"
        '
        'tipHarga2
        '
        Me.tipHarga2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.tipHarga2.ToolTipTitle = "Harga Beli"
        '
        'MasterBarang_Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1064, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MasterBarang_Detail"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.Text = "Detail Barang"
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.GridHarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewHarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BoxStok2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BoxStok1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.BoxKategori.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btAddHarga As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents GridHarga As DevExpress.XtraGrid.GridControl
    Friend WithEvents ViewHarga As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BoxStok2 As NumericUpDown
    Friend WithEvents BoxSatuan2 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents BoxHjual1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BoxHbeli1 As TextBox
    Friend WithEvents BoxStok1 As NumericUpDown
    Friend WithEvents BoxSatuan1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BoxKategori As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btAddKategori As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BoxBarang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents BoxHbeli2 As TextBox
    Friend WithEvents BoxHjual2 As TextBox
    Friend WithEvents tipHarga As ToolTip
    Friend WithEvents tipHarga2 As ToolTip
End Class
