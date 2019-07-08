<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPembelian))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btSimpan = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupStatus = New DevExpress.XtraEditors.GroupControl()
        Me.CekLunas = New DevExpress.XtraEditors.CheckEdit()
        Me.CekBarang = New DevExpress.XtraEditors.CheckEdit()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbBarang = New DevExpress.XtraEditors.CheckEdit()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Radio10 = New System.Windows.Forms.RadioButton()
        Me.Radio30 = New System.Windows.Forms.RadioButton()
        Me.Radio7 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateJtempo = New MetroFramework.Controls.MetroDateTime()
        Me.BoxKontak = New DevExpress.XtraEditors.LookUpEdit()
        Me.BoxSupp = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateBeli = New MetroFramework.Controls.MetroDateTime()
        Me.DateDatang = New MetroFramework.Controls.MetroDateTime()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BoxNota = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BoxCatatan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GridPembelian = New DevExpress.XtraGrid.GridControl()
        Me.ViewPembelian = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GroupStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupStatus.SuspendLayout()
        CType(Me.CekLunas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CekBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.cbBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.BoxKontak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxSupp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.GridPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lavender
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1164, 180)
        Me.Panel1.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btSimpan)
        Me.Panel3.Controls.Add(Me.GroupStatus)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(980, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(184, 180)
        Me.Panel3.TabIndex = 5
        '
        'btSimpan
        '
        Me.btSimpan.Appearance.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSimpan.Appearance.Options.UseFont = True
        Me.btSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSimpan.Enabled = False
        Me.btSimpan.ImageOptions.Image = CType(resources.GetObject("btSimpan.ImageOptions.Image"), System.Drawing.Image)
        Me.btSimpan.Location = New System.Drawing.Point(16, 108)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(150, 36)
        Me.btSimpan.TabIndex = 0
        Me.btSimpan.Text = "SIMPAN"
        '
        'GroupStatus
        '
        Me.GroupStatus.AppearanceCaption.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupStatus.AppearanceCaption.Options.UseFont = True
        Me.GroupStatus.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupStatus.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupStatus.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.GroupStatus.Controls.Add(Me.CekLunas)
        Me.GroupStatus.Controls.Add(Me.CekBarang)
        Me.GroupStatus.Location = New System.Drawing.Point(16, 12)
        Me.GroupStatus.Name = "GroupStatus"
        Me.GroupStatus.Size = New System.Drawing.Size(150, 82)
        Me.GroupStatus.TabIndex = 4
        Me.GroupStatus.Text = "Status"
        '
        'CekLunas
        '
        Me.CekLunas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CekLunas.Location = New System.Drawing.Point(5, 57)
        Me.CekLunas.Name = "CekLunas"
        Me.CekLunas.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekLunas.Properties.Appearance.Options.UseFont = True
        Me.CekLunas.Properties.Caption = "Lunas"
        Me.CekLunas.Size = New System.Drawing.Size(138, 20)
        Me.CekLunas.TabIndex = 0
        '
        'CekBarang
        '
        Me.CekBarang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CekBarang.Location = New System.Drawing.Point(5, 31)
        Me.CekBarang.Name = "CekBarang"
        Me.CekBarang.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CekBarang.Properties.Appearance.Options.UseFont = True
        Me.CekBarang.Properties.Caption = "Barang Masuk"
        Me.CekBarang.Size = New System.Drawing.Size(138, 20)
        Me.CekBarang.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbBarang)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(904, 180)
        Me.Panel2.TabIndex = 6
        '
        'cbBarang
        '
        Me.cbBarang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbBarang.Location = New System.Drawing.Point(12, 155)
        Me.cbBarang.Name = "cbBarang"
        Me.cbBarang.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBarang.Properties.Appearance.Options.UseFont = True
        Me.cbBarang.Properties.Caption = "Tampilkan barang yang dipilih"
        Me.cbBarang.Size = New System.Drawing.Size(216, 22)
        Me.cbBarang.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Radio10)
        Me.Panel4.Controls.Add(Me.Radio30)
        Me.Panel4.Controls.Add(Me.Radio7)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.DateJtempo)
        Me.Panel4.Controls.Add(Me.BoxKontak)
        Me.Panel4.Controls.Add(Me.BoxSupp)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.DateBeli)
        Me.Panel4.Controls.Add(Me.DateDatang)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.BoxNota)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.BoxCatatan)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(12, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(881, 132)
        Me.Panel4.TabIndex = 8
        '
        'Radio10
        '
        Me.Radio10.AutoSize = True
        Me.Radio10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Radio10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio10.Location = New System.Drawing.Point(567, 67)
        Me.Radio10.Name = "Radio10"
        Me.Radio10.Size = New System.Drawing.Size(54, 21)
        Me.Radio10.TabIndex = 24
        Me.Radio10.Text = "n/10"
        Me.Radio10.UseVisualStyleBackColor = True
        '
        'Radio30
        '
        Me.Radio30.AutoSize = True
        Me.Radio30.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Radio30.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio30.Location = New System.Drawing.Point(633, 67)
        Me.Radio30.Name = "Radio30"
        Me.Radio30.Size = New System.Drawing.Size(54, 21)
        Me.Radio30.TabIndex = 23
        Me.Radio30.Text = "n/30"
        Me.Radio30.UseVisualStyleBackColor = True
        '
        'Radio7
        '
        Me.Radio7.AutoSize = True
        Me.Radio7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Radio7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio7.Location = New System.Drawing.Point(507, 67)
        Me.Radio7.Name = "Radio7"
        Me.Radio7.Size = New System.Drawing.Size(47, 21)
        Me.Radio7.TabIndex = 22
        Me.Radio7.Text = "n/7"
        Me.Radio7.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(504, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Jatuh Tempo"
        '
        'DateJtempo
        '
        Me.DateJtempo.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateJtempo.CalendarMonthBackground = System.Drawing.Color.Cornsilk
        Me.DateJtempo.CalendarTitleBackColor = System.Drawing.Color.White
        Me.DateJtempo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateJtempo.CustomFormat = "yyyy-MM-dd"
        Me.DateJtempo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateJtempo.Location = New System.Drawing.Point(507, 32)
        Me.DateJtempo.MinimumSize = New System.Drawing.Size(0, 29)
        Me.DateJtempo.Name = "DateJtempo"
        Me.DateJtempo.Size = New System.Drawing.Size(180, 29)
        Me.DateJtempo.TabIndex = 20
        Me.DateJtempo.UseCustomBackColor = True
        Me.DateJtempo.UseCustomForeColor = True
        Me.DateJtempo.UseStyleColors = True
        '
        'BoxKontak
        '
        Me.BoxKontak.EditValue = ""
        Me.BoxKontak.Location = New System.Drawing.Point(312, 85)
        Me.BoxKontak.Name = "BoxKontak"
        Me.BoxKontak.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxKontak.Properties.Appearance.Options.UseFont = True
        Me.BoxKontak.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxKontak.Properties.AppearanceDropDown.Options.UseFont = True
        Me.BoxKontak.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxKontak.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.BoxKontak.Properties.AppearanceDropDownHeader.Options.UseTextOptions = True
        Me.BoxKontak.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BoxKontak.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BoxKontak.Properties.DropDownRows = 6
        Me.BoxKontak.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BoxKontak.Properties.ShowFooter = False
        Me.BoxKontak.Size = New System.Drawing.Size(180, 24)
        Me.BoxKontak.TabIndex = 19
        '
        'BoxSupp
        '
        Me.BoxSupp.EditValue = ""
        Me.BoxSupp.Location = New System.Drawing.Point(312, 33)
        Me.BoxSupp.Name = "BoxSupp"
        Me.BoxSupp.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxSupp.Properties.Appearance.Options.UseFont = True
        Me.BoxSupp.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxSupp.Properties.AppearanceDropDown.Options.UseFont = True
        Me.BoxSupp.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxSupp.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.BoxSupp.Properties.AppearanceDropDownHeader.Options.UseTextOptions = True
        Me.BoxSupp.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BoxSupp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BoxSupp.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BoxSupp.Properties.ShowFooter = False
        Me.BoxSupp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BoxSupp.Size = New System.Drawing.Size(180, 24)
        Me.BoxSupp.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(156, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Tgl Kedatangan"
        '
        'DateBeli
        '
        Me.DateBeli.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateBeli.CalendarMonthBackground = System.Drawing.Color.Cornsilk
        Me.DateBeli.CalendarTitleBackColor = System.Drawing.Color.White
        Me.DateBeli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateBeli.CustomFormat = "yyyy-MM-dd"
        Me.DateBeli.Enabled = False
        Me.DateBeli.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateBeli.Location = New System.Drawing.Point(15, 85)
        Me.DateBeli.MinimumSize = New System.Drawing.Size(0, 29)
        Me.DateBeli.Name = "DateBeli"
        Me.DateBeli.Size = New System.Drawing.Size(138, 29)
        Me.DateBeli.TabIndex = 15
        Me.DateBeli.UseCustomBackColor = True
        Me.DateBeli.UseCustomForeColor = True
        Me.DateBeli.UseStyleColors = True
        '
        'DateDatang
        '
        Me.DateDatang.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDatang.CalendarMonthBackground = System.Drawing.Color.Cornsilk
        Me.DateDatang.CalendarTitleBackColor = System.Drawing.Color.White
        Me.DateDatang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateDatang.CustomFormat = "yyyy-MM-dd"
        Me.DateDatang.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDatang.Location = New System.Drawing.Point(159, 85)
        Me.DateDatang.MinimumSize = New System.Drawing.Size(0, 29)
        Me.DateDatang.Name = "DateDatang"
        Me.DateDatang.Size = New System.Drawing.Size(138, 29)
        Me.DateDatang.TabIndex = 0
        Me.DateDatang.UseCustomBackColor = True
        Me.DateDatang.UseCustomForeColor = True
        Me.DateDatang.UseStyleColors = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "No. Pembelian"
        '
        'BoxNota
        '
        Me.BoxNota.Enabled = False
        Me.BoxNota.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxNota.Location = New System.Drawing.Point(15, 33)
        Me.BoxNota.Name = "BoxNota"
        Me.BoxNota.Size = New System.Drawing.Size(282, 23)
        Me.BoxNota.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(699, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Catatan"
        '
        'BoxCatatan
        '
        Me.BoxCatatan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxCatatan.Location = New System.Drawing.Point(702, 32)
        Me.BoxCatatan.Multiline = True
        Me.BoxCatatan.Name = "BoxCatatan"
        Me.BoxCatatan.Size = New System.Drawing.Size(165, 82)
        Me.BoxCatatan.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tgl Pembelian"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(309, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Kontak"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(309, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pemasok"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GridPembelian)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 180)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1164, 381)
        Me.Panel5.TabIndex = 10
        '
        'GridPembelian
        '
        Me.GridPembelian.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPembelian.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPembelian.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.GridPembelian.EmbeddedNavigator.TextStringFormat = "{0} dari {1}"
        Me.GridPembelian.Location = New System.Drawing.Point(0, 0)
        Me.GridPembelian.MainView = Me.ViewPembelian
        Me.GridPembelian.Name = "GridPembelian"
        Me.GridPembelian.Size = New System.Drawing.Size(1164, 381)
        Me.GridPembelian.TabIndex = 9
        Me.GridPembelian.UseEmbeddedNavigator = True
        Me.GridPembelian.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ViewPembelian})
        '
        'ViewPembelian
        '
        Me.ViewPembelian.Appearance.FooterPanel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewPembelian.Appearance.FooterPanel.Options.UseFont = True
        Me.ViewPembelian.Appearance.HeaderPanel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewPembelian.Appearance.HeaderPanel.Options.UseFont = True
        Me.ViewPembelian.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.ViewPembelian.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ViewPembelian.Appearance.Row.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewPembelian.Appearance.Row.Options.UseFont = True
        Me.ViewPembelian.GridControl = Me.GridPembelian
        Me.ViewPembelian.Name = "ViewPembelian"
        Me.ViewPembelian.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.ViewPembelian.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.ViewPembelian.OptionsCustomization.AllowColumnMoving = False
        Me.ViewPembelian.OptionsCustomization.AllowFilter = False
        Me.ViewPembelian.OptionsCustomization.AllowGroup = False
        Me.ViewPembelian.OptionsCustomization.AllowQuickHideColumns = False
        Me.ViewPembelian.OptionsFind.AlwaysVisible = True
        Me.ViewPembelian.OptionsFind.FindDelay = 500
        Me.ViewPembelian.OptionsFind.FindNullPrompt = "Ketik disini untuk mencari..."
        Me.ViewPembelian.OptionsMenu.EnableColumnMenu = False
        Me.ViewPembelian.OptionsMenu.EnableFooterMenu = False
        Me.ViewPembelian.OptionsMenu.EnableGroupPanelMenu = False
        Me.ViewPembelian.OptionsNavigation.EnterMoveNextColumn = True
        Me.ViewPembelian.OptionsSelection.MultiSelect = True
        Me.ViewPembelian.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.ViewPembelian.OptionsView.ShowFooter = True
        Me.ViewPembelian.OptionsView.ShowGroupPanel = False
        '
        'FormPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 561)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormPembelian"
        Me.Text = "Pembelian"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.GroupStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupStatus.ResumeLayout(False)
        CType(Me.CekLunas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CekBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.cbBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.BoxKontak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxSupp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.GridPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GridPembelian As DevExpress.XtraGrid.GridControl
    Friend WithEvents ViewPembelian As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupStatus As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CekLunas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CekBarang As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents BoxCatatan As TextBox
    Friend WithEvents BoxNota As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DateBeli As MetroFramework.Controls.MetroDateTime
    Friend WithEvents DateDatang As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label7 As Label
    Friend WithEvents BoxSupp As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BoxKontak As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents DateJtempo As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Radio7 As RadioButton
    Friend WithEvents Radio30 As RadioButton
    Friend WithEvents Radio10 As RadioButton
    Friend WithEvents cbBarang As DevExpress.XtraEditors.CheckEdit
End Class
