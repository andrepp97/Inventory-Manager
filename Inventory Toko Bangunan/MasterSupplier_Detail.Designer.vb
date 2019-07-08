<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterSupplier_Detail
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterSupplier_Detail))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btSimpan = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BoxKota = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BoxAlamat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BoxSupplier = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GridKontak = New DevExpress.XtraGrid.GridControl()
        Me.ViewKontak = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.jenis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbJenis = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.kontak = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.telepon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BoxKota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridKontak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewKontak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbJenis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.btSimpan)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(20, 60)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(380, 32)
        Me.Panel4.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(118, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(260, 30)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Kolom dengan tanda bintang (*) wajib diisi"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BoxKota)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.BoxAlamat)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BoxSupplier)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(20, 132)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 158)
        Me.Panel1.TabIndex = 25
        '
        'BoxKota
        '
        Me.BoxKota.EditValue = ""
        Me.BoxKota.Location = New System.Drawing.Point(87, 114)
        Me.BoxKota.Name = "BoxKota"
        Me.BoxKota.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxKota.Properties.Appearance.Options.UseFont = True
        Me.BoxKota.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxKota.Properties.AppearanceDropDown.Options.UseFont = True
        Me.BoxKota.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxKota.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.BoxKota.Properties.AppearanceDropDownHeader.Options.UseTextOptions = True
        Me.BoxKota.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BoxKota.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BoxKota.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BoxKota.Properties.ShowFooter = False
        Me.BoxKota.Properties.ShowHeader = False
        Me.BoxKota.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BoxKota.Size = New System.Drawing.Size(276, 26)
        Me.BoxKota.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Kota :"
        '
        'BoxAlamat
        '
        Me.BoxAlamat.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxAlamat.Location = New System.Drawing.Point(87, 54)
        Me.BoxAlamat.Multiline = True
        Me.BoxAlamat.Name = "BoxAlamat"
        Me.BoxAlamat.Size = New System.Drawing.Size(276, 48)
        Me.BoxAlamat.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "*Nama :"
        '
        'BoxSupplier
        '
        Me.BoxSupplier.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxSupplier.Location = New System.Drawing.Point(87, 13)
        Me.BoxSupplier.Name = "BoxSupplier"
        Me.BoxSupplier.Size = New System.Drawing.Size(276, 26)
        Me.BoxSupplier.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Alamat :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(15, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 25)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Pemasok"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(15, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 25)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Kontak"
        '
        'GridKontak
        '
        Me.GridKontak.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridKontak.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.GridKontak.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GridKontak.EmbeddedNavigator.TextStringFormat = "{0} dari {1}"
        Me.GridKontak.Location = New System.Drawing.Point(20, 333)
        Me.GridKontak.MainView = Me.ViewKontak
        Me.GridKontak.Name = "GridKontak"
        Me.GridKontak.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbJenis})
        Me.GridKontak.Size = New System.Drawing.Size(379, 200)
        Me.GridKontak.TabIndex = 31
        Me.GridKontak.UseEmbeddedNavigator = True
        Me.GridKontak.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ViewKontak})
        '
        'ViewKontak
        '
        Me.ViewKontak.Appearance.HeaderPanel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewKontak.Appearance.HeaderPanel.Options.UseFont = True
        Me.ViewKontak.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.ViewKontak.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ViewKontak.Appearance.Row.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewKontak.Appearance.Row.Options.UseFont = True
        Me.ViewKontak.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ViewKontak.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.jenis, Me.kontak, Me.telepon})
        Me.ViewKontak.GridControl = Me.GridKontak
        Me.ViewKontak.Name = "ViewKontak"
        Me.ViewKontak.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.ViewKontak.OptionsCustomization.AllowFilter = False
        Me.ViewKontak.OptionsCustomization.AllowGroup = False
        Me.ViewKontak.OptionsMenu.EnableColumnMenu = False
        Me.ViewKontak.OptionsMenu.EnableFooterMenu = False
        Me.ViewKontak.OptionsMenu.EnableGroupPanelMenu = False
        Me.ViewKontak.OptionsView.ShowGroupPanel = False
        '
        'jenis
        '
        Me.jenis.Caption = "Jenis Kontak"
        Me.jenis.ColumnEdit = Me.cbJenis
        Me.jenis.FieldName = "Jenis Kontak"
        Me.jenis.Name = "jenis"
        Me.jenis.Visible = True
        Me.jenis.VisibleIndex = 0
        '
        'cbJenis
        '
        Me.cbJenis.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.cbJenis.AutoHeight = False
        Me.cbJenis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbJenis.Items.AddRange(New Object() {"Kantor Pusat", "Kantor Cabang", "Agen", "Sales"})
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.NullValuePrompt = "Pilih..."
        Me.cbJenis.ValidateOnEnterKey = True
        '
        'kontak
        '
        Me.kontak.Caption = "Nama Kontak"
        Me.kontak.FieldName = "Nama Kontak"
        Me.kontak.Name = "kontak"
        Me.kontak.Visible = True
        Me.kontak.VisibleIndex = 1
        '
        'telepon
        '
        Me.telepon.Caption = "Telp"
        Me.telepon.FieldName = "Telp"
        Me.telepon.Name = "telepon"
        Me.telepon.Visible = True
        Me.telepon.VisibleIndex = 2
        '
        'MasterSupplier_Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 555)
        Me.Controls.Add(Me.GridKontak)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MasterSupplier_Detail"
        Me.Resizable = False
        Me.Text = "Detail Pemasok"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BoxKota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridKontak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewKontak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbJenis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents btSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BoxSupplier As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BoxAlamat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GridKontak As DevExpress.XtraGrid.GridControl
    Friend WithEvents ViewKontak As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label8 As Label
    Friend WithEvents BoxKota As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kontak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents telepon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbJenis As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
End Class
