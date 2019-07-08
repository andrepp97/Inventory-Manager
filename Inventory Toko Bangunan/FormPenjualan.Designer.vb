<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPenjualan))
        Me.ViewPenjualan = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Barang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SearchBarang = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.ViewBarang = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Stok = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbStok = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.Jumlah = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BoxQty = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.HargaUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BoxHarga = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Subtotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridPenjualan = New DevExpress.XtraGrid.GridControl()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ListBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridBarang = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BoxSubtotal = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BoxBayar = New DevExpress.XtraEditors.TextEdit()
        Me.btSimpan = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RadioTipe = New DevExpress.XtraEditors.RadioGroup()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BoxCust = New DevExpress.XtraEditors.LookUpEdit()
        Me.DateBeli = New MetroFramework.Controls.MetroDateTime()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BoxNota = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BoxCatatan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.ViewPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxSubtotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.BoxBayar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.RadioTipe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxCust.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ViewPenjualan
        '
        Me.ViewPenjualan.Appearance.FooterPanel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewPenjualan.Appearance.FooterPanel.Options.UseFont = True
        Me.ViewPenjualan.Appearance.HeaderPanel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewPenjualan.Appearance.HeaderPanel.Options.UseFont = True
        Me.ViewPenjualan.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.ViewPenjualan.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ViewPenjualan.Appearance.Row.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewPenjualan.Appearance.Row.Options.UseFont = True
        Me.ViewPenjualan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Barang, Me.Stok, Me.Jumlah, Me.HargaUnit, Me.Subtotal})
        Me.ViewPenjualan.GridControl = Me.GridPenjualan
        Me.ViewPenjualan.Name = "ViewPenjualan"
        Me.ViewPenjualan.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.ViewPenjualan.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.ViewPenjualan.OptionsCustomization.AllowColumnMoving = False
        Me.ViewPenjualan.OptionsCustomization.AllowFilter = False
        Me.ViewPenjualan.OptionsCustomization.AllowGroup = False
        Me.ViewPenjualan.OptionsCustomization.AllowQuickHideColumns = False
        Me.ViewPenjualan.OptionsEditForm.PopupEditFormWidth = 1000
        Me.ViewPenjualan.OptionsFind.FindDelay = 500
        Me.ViewPenjualan.OptionsFind.FindNullPrompt = "Ketik disini untuk mencari..."
        Me.ViewPenjualan.OptionsMenu.EnableColumnMenu = False
        Me.ViewPenjualan.OptionsMenu.EnableFooterMenu = False
        Me.ViewPenjualan.OptionsMenu.EnableGroupPanelMenu = False
        Me.ViewPenjualan.OptionsNavigation.EnterMoveNextColumn = True
        Me.ViewPenjualan.OptionsView.ShowFooter = True
        Me.ViewPenjualan.OptionsView.ShowGroupPanel = False
        '
        'Barang
        '
        Me.Barang.AppearanceCell.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Barang.AppearanceCell.Options.UseFont = True
        Me.Barang.AppearanceHeader.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Barang.AppearanceHeader.Options.UseFont = True
        Me.Barang.Caption = "Barang"
        Me.Barang.ColumnEdit = Me.SearchBarang
        Me.Barang.FieldName = "Barang"
        Me.Barang.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.Barang.Image = CType(resources.GetObject("Barang.Image"), System.Drawing.Image)
        Me.Barang.Name = "Barang"
        Me.Barang.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Barang.OptionsColumn.AllowMove = False
        Me.Barang.OptionsColumn.AllowShowHide = False
        Me.Barang.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.Barang.Visible = True
        Me.Barang.VisibleIndex = 0
        Me.Barang.Width = 252
        '
        'SearchBarang
        '
        Me.SearchBarang.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.SearchBarang.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBarang.Appearance.Options.UseFont = True
        Me.SearchBarang.AppearanceDropDown.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBarang.AppearanceDropDown.Options.UseFont = True
        Me.SearchBarang.AppearanceFocused.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBarang.AppearanceFocused.Options.UseFont = True
        Me.SearchBarang.AutoHeight = False
        Me.SearchBarang.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.SearchBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchBarang.MaxLength = 45
        Me.SearchBarang.Name = "SearchBarang"
        Me.SearchBarang.NullText = ""
        Me.SearchBarang.NullValuePrompt = "Pilih Barang..."
        Me.SearchBarang.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.NoBorder
        Me.SearchBarang.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SearchBarang.Tag = ""
        Me.SearchBarang.ValidateOnEnterKey = True
        Me.SearchBarang.View = Me.ViewBarang
        Me.SearchBarang.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        '
        'ViewBarang
        '
        Me.ViewBarang.Appearance.HeaderPanel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewBarang.Appearance.HeaderPanel.Options.UseFont = True
        Me.ViewBarang.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.ViewBarang.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ViewBarang.Appearance.Row.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewBarang.Appearance.Row.Options.UseFont = True
        Me.ViewBarang.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.ViewBarang.Name = "ViewBarang"
        Me.ViewBarang.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.ViewBarang.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.ViewBarang.OptionsBehavior.Editable = False
        Me.ViewBarang.OptionsCustomization.AllowColumnMoving = False
        Me.ViewBarang.OptionsCustomization.AllowGroup = False
        Me.ViewBarang.OptionsCustomization.AllowQuickHideColumns = False
        Me.ViewBarang.OptionsEditForm.PopupEditFormWidth = 1000
        Me.ViewBarang.OptionsFind.AlwaysVisible = True
        Me.ViewBarang.OptionsFind.FindDelay = 500
        Me.ViewBarang.OptionsFind.FindNullPrompt = "Ketik untuk mencari..."
        Me.ViewBarang.OptionsMenu.EnableColumnMenu = False
        Me.ViewBarang.OptionsMenu.EnableFooterMenu = False
        Me.ViewBarang.OptionsMenu.EnableGroupPanelMenu = False
        Me.ViewBarang.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.ViewBarang.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.ViewBarang.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.ViewBarang.OptionsView.ShowGroupPanel = False
        '
        'Stok
        '
        Me.Stok.Caption = "Stok"
        Me.Stok.ColumnEdit = Me.cbStok
        Me.Stok.FieldName = "Stok"
        Me.Stok.Name = "Stok"
        Me.Stok.Visible = True
        Me.Stok.VisibleIndex = 1
        Me.Stok.Width = 185
        '
        'cbStok
        '
        Me.cbStok.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.cbStok.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStok.Appearance.Options.UseFont = True
        Me.cbStok.AppearanceDropDown.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStok.AppearanceDropDown.Options.UseFont = True
        Me.cbStok.AppearanceFocused.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStok.AppearanceFocused.Options.UseFont = True
        Me.cbStok.AutoHeight = False
        Me.cbStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbStok.DropDownRows = 4
        Me.cbStok.Items.AddRange(New Object() {"Stok Utama", "Stok Kedua"})
        Me.cbStok.Name = "cbStok"
        Me.cbStok.NullText = "Stok Utama"
        Me.cbStok.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbStok.ValidateOnEnterKey = True
        '
        'Jumlah
        '
        Me.Jumlah.AppearanceCell.Options.UseTextOptions = True
        Me.Jumlah.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Jumlah.Caption = "Qty"
        Me.Jumlah.ColumnEdit = Me.BoxQty
        Me.Jumlah.DisplayFormat.FormatString = "n0"
        Me.Jumlah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Jumlah.FieldName = "Qty"
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.OptionsColumn.AllowShowHide = False
        Me.Jumlah.Visible = True
        Me.Jumlah.VisibleIndex = 2
        Me.Jumlah.Width = 150
        '
        'BoxQty
        '
        Me.BoxQty.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.BoxQty.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxQty.Appearance.Options.UseFont = True
        Me.BoxQty.AutoHeight = False
        Me.BoxQty.DisplayFormat.FormatString = "n0"
        Me.BoxQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BoxQty.Mask.EditMask = "n0"
        Me.BoxQty.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.BoxQty.Mask.UseMaskAsDisplayFormat = True
        Me.BoxQty.Name = "BoxQty"
        Me.BoxQty.NullText = "0"
        Me.BoxQty.NullValuePrompt = "0"
        Me.BoxQty.ValidateOnEnterKey = True
        '
        'HargaUnit
        '
        Me.HargaUnit.AppearanceCell.Options.UseTextOptions = True
        Me.HargaUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.HargaUnit.Caption = "Harga Unit"
        Me.HargaUnit.ColumnEdit = Me.BoxHarga
        Me.HargaUnit.FieldName = "Harga Unit"
        Me.HargaUnit.Name = "HargaUnit"
        Me.HargaUnit.Visible = True
        Me.HargaUnit.VisibleIndex = 3
        Me.HargaUnit.Width = 237
        '
        'BoxHarga
        '
        Me.BoxHarga.AutoHeight = False
        Me.BoxHarga.DisplayFormat.FormatString = "n0"
        Me.BoxHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BoxHarga.Mask.EditMask = "n0"
        Me.BoxHarga.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.BoxHarga.Mask.UseMaskAsDisplayFormat = True
        Me.BoxHarga.Name = "BoxHarga"
        Me.BoxHarga.NullText = "0"
        Me.BoxHarga.ValidateOnEnterKey = True
        '
        'Subtotal
        '
        Me.Subtotal.AppearanceCell.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subtotal.AppearanceCell.Options.UseFont = True
        Me.Subtotal.AppearanceCell.Options.UseTextOptions = True
        Me.Subtotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Subtotal.Caption = "Subtotal"
        Me.Subtotal.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.Subtotal.DisplayFormat.FormatString = "n0"
        Me.Subtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Subtotal.FieldName = "Subtotal"
        Me.Subtotal.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.OptionsColumn.AllowEdit = False
        Me.Subtotal.OptionsColumn.AllowShowHide = False
        Me.Subtotal.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.Subtotal.Visible = True
        Me.Subtotal.VisibleIndex = 4
        Me.Subtotal.Width = 260
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemTextEdit1.Appearance.Options.UseFont = True
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatString = "n0"
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.NullText = "0"
        Me.RepositoryItemTextEdit1.ValidateOnEnterKey = True
        '
        'GridPenjualan
        '
        Me.GridPenjualan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPenjualan.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPenjualan.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.GridPenjualan.EmbeddedNavigator.TextStringFormat = "{0} dari {1}"
        Me.GridPenjualan.Location = New System.Drawing.Point(0, 0)
        Me.GridPenjualan.MainView = Me.ViewPenjualan
        Me.GridPenjualan.Name = "GridPenjualan"
        Me.GridPenjualan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbStok, Me.RepositoryItemLookUpEdit1, Me.ListBarang, Me.GridBarang, Me.SearchBarang, Me.BoxQty, Me.BoxHarga, Me.BoxSubtotal, Me.RepositoryItemTextEdit1})
        Me.GridPenjualan.Size = New System.Drawing.Size(1094, 207)
        Me.GridPenjualan.TabIndex = 9
        Me.GridPenjualan.UseEmbeddedNavigator = True
        Me.GridPenjualan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ViewPenjualan})
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'ListBarang
        '
        Me.ListBarang.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.ListBarang.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBarang.Appearance.Options.UseFont = True
        Me.ListBarang.AppearanceDropDown.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBarang.AppearanceDropDown.Options.UseFont = True
        Me.ListBarang.AppearanceDropDownHeader.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBarang.AppearanceDropDownHeader.Options.UseFont = True
        Me.ListBarang.AppearanceDropDownHeader.Options.UseTextOptions = True
        Me.ListBarang.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ListBarang.AutoHeight = False
        Me.ListBarang.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.ListBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ListBarang.Name = "ListBarang"
        Me.ListBarang.NullText = ""
        Me.ListBarang.NullValuePrompt = "Pilih Barang..."
        Me.ListBarang.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ListBarang.ShowFooter = False
        Me.ListBarang.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ListBarang.ValidateOnEnterKey = True
        '
        'GridBarang
        '
        Me.GridBarang.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridBarang.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridBarang.Appearance.Options.UseFont = True
        Me.GridBarang.AppearanceDropDown.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridBarang.AppearanceDropDown.Options.UseFont = True
        Me.GridBarang.AppearanceFocused.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridBarang.AppearanceFocused.Options.UseFont = True
        Me.GridBarang.AutoHeight = False
        Me.GridBarang.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.GridBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridBarang.MaxLength = 45
        Me.GridBarang.Name = "GridBarang"
        Me.GridBarang.NullText = ""
        Me.GridBarang.NullValuePrompt = "Pilih Barang..."
        Me.GridBarang.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridBarang.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridBarang.ValidateOnEnterKey = True
        Me.GridBarang.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'BoxSubtotal
        '
        Me.BoxSubtotal.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.BoxSubtotal.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxSubtotal.Appearance.Options.UseFont = True
        Me.BoxSubtotal.AutoHeight = False
        Me.BoxSubtotal.DisplayFormat.FormatString = "n0"
        Me.BoxSubtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BoxSubtotal.Mask.EditMask = "n0"
        Me.BoxSubtotal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.BoxSubtotal.Name = "BoxSubtotal"
        Me.BoxSubtotal.NullText = "0"
        Me.BoxSubtotal.ValidateOnEnterKey = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GridPenjualan)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 152)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1094, 327)
        Me.Panel5.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Lavender
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 207)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1094, 120)
        Me.Panel3.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.BoxBayar)
        Me.Panel6.Controls.Add(Me.btSimpan)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(794, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(300, 120)
        Me.Panel6.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Jumlah Bayar :"
        '
        'BoxBayar
        '
        Me.BoxBayar.Location = New System.Drawing.Point(138, 16)
        Me.BoxBayar.Name = "BoxBayar"
        Me.BoxBayar.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxBayar.Properties.Appearance.Options.UseFont = True
        Me.BoxBayar.Properties.Appearance.Options.UseTextOptions = True
        Me.BoxBayar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.BoxBayar.Properties.DisplayFormat.FormatString = "n0"
        Me.BoxBayar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BoxBayar.Properties.Mask.EditMask = "n0"
        Me.BoxBayar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.BoxBayar.Properties.NullText = "0"
        Me.BoxBayar.Size = New System.Drawing.Size(150, 24)
        Me.BoxBayar.TabIndex = 2
        '
        'btSimpan
        '
        Me.btSimpan.Appearance.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSimpan.Appearance.Options.UseFont = True
        Me.btSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSimpan.ImageOptions.Image = CType(resources.GetObject("btSimpan.ImageOptions.Image"), System.Drawing.Image)
        Me.btSimpan.Location = New System.Drawing.Point(138, 72)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(150, 36)
        Me.btSimpan.TabIndex = 1
        Me.btSimpan.Text = "SIMPAN"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lavender
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1094, 152)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(715, 152)
        Me.Panel2.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.RadioTipe)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.BoxCust)
        Me.Panel4.Controls.Add(Me.DateBeli)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.BoxNota)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.BoxCatatan)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(12, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(690, 124)
        Me.Panel4.TabIndex = 8
        '
        'RadioTipe
        '
        Me.RadioTipe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioTipe.Location = New System.Drawing.Point(260, 31)
        Me.RadioTipe.Name = "RadioTipe"
        Me.RadioTipe.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.RadioTipe.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioTipe.Properties.Appearance.Options.UseBackColor = True
        Me.RadioTipe.Properties.Appearance.Options.UseFont = True
        Me.RadioTipe.Properties.Columns = 2
        Me.RadioTipe.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Umum", "Umum"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Pelanggan", "Pelanggan")})
        Me.RadioTipe.Size = New System.Drawing.Size(225, 26)
        Me.RadioTipe.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(257, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Tipe Pembeli"
        '
        'BoxCust
        '
        Me.BoxCust.EditValue = ""
        Me.BoxCust.Enabled = False
        Me.BoxCust.Location = New System.Drawing.Point(260, 86)
        Me.BoxCust.Name = "BoxCust"
        Me.BoxCust.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxCust.Properties.Appearance.Options.UseFont = True
        Me.BoxCust.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxCust.Properties.AppearanceDropDown.Options.UseFont = True
        Me.BoxCust.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxCust.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.BoxCust.Properties.AppearanceDropDownHeader.Options.UseTextOptions = True
        Me.BoxCust.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BoxCust.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BoxCust.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BoxCust.Properties.ShowFooter = False
        Me.BoxCust.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BoxCust.Size = New System.Drawing.Size(225, 26)
        Me.BoxCust.TabIndex = 18
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
        Me.DateBeli.Location = New System.Drawing.Point(15, 83)
        Me.DateBeli.MinimumSize = New System.Drawing.Size(0, 29)
        Me.DateBeli.Name = "DateBeli"
        Me.DateBeli.Size = New System.Drawing.Size(229, 29)
        Me.DateBeli.TabIndex = 15
        Me.DateBeli.UseCustomBackColor = True
        Me.DateBeli.UseCustomForeColor = True
        Me.DateBeli.UseStyleColors = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "No. Penjualan"
        '
        'BoxNota
        '
        Me.BoxNota.Enabled = False
        Me.BoxNota.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxNota.Location = New System.Drawing.Point(15, 31)
        Me.BoxNota.Name = "BoxNota"
        Me.BoxNota.Size = New System.Drawing.Size(229, 26)
        Me.BoxNota.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(498, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Catatan"
        '
        'BoxCatatan
        '
        Me.BoxCatatan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxCatatan.Location = New System.Drawing.Point(501, 31)
        Me.BoxCatatan.Multiline = True
        Me.BoxCatatan.Name = "BoxCatatan"
        Me.BoxCatatan.Size = New System.Drawing.Size(174, 81)
        Me.BoxCatatan.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tgl Penjualan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(257, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pelanggan"
        '
        'Qty
        '
        Me.Qty.Caption = "Qty"
        Me.Qty.FieldName = "qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 3
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 479)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormPenjualan"
        Me.Text = "Penjualan"
        CType(Me.ViewPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxHarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxSubtotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.BoxBayar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.RadioTipe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxCust.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ViewPenjualan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridPenjualan As DevExpress.XtraGrid.GridControl
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BoxCust As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DateBeli As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label6 As Label
    Friend WithEvents BoxNota As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BoxCatatan As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioTipe As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents cbStok As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HargaUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BoxBayar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridBarang As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Jumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SearchBarang As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents BoxQty As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BoxHarga As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BoxSubtotal As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ViewBarang As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Subtotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
