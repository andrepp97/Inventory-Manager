<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MasterKategori
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterKategori))
        Me.GridKategori = New DevExpress.XtraGrid.GridControl()
        Me.ViewKategori = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BoxKategori = New DevExpress.XtraEditors.TextEdit()
        Me.btTambah = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GridKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BoxKategori.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridKategori
        '
        Me.GridKategori.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridKategori.Location = New System.Drawing.Point(20, 133)
        Me.GridKategori.MainView = Me.ViewKategori
        Me.GridKategori.Name = "GridKategori"
        Me.GridKategori.Size = New System.Drawing.Size(320, 197)
        Me.GridKategori.TabIndex = 2
        Me.GridKategori.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ViewKategori})
        '
        'ViewKategori
        '
        Me.ViewKategori.Appearance.HeaderPanel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewKategori.Appearance.HeaderPanel.Options.UseFont = True
        Me.ViewKategori.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.ViewKategori.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ViewKategori.Appearance.Row.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewKategori.Appearance.Row.Options.UseFont = True
        Me.ViewKategori.GridControl = Me.GridKategori
        Me.ViewKategori.Name = "ViewKategori"
        Me.ViewKategori.OptionsBehavior.Editable = False
        Me.ViewKategori.OptionsCustomization.AllowFilter = False
        Me.ViewKategori.OptionsCustomization.AllowQuickHideColumns = False
        Me.ViewKategori.OptionsFind.AlwaysVisible = True
        Me.ViewKategori.OptionsFind.FindDelay = 500
        Me.ViewKategori.OptionsFind.FindNullPrompt = "Ketik disini untuk mencari..."
        Me.ViewKategori.OptionsMenu.EnableColumnMenu = False
        Me.ViewKategori.OptionsMenu.EnableFooterMenu = False
        Me.ViewKategori.OptionsMenu.EnableGroupPanelMenu = False
        Me.ViewKategori.OptionsView.ShowGroupPanel = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BoxKategori)
        Me.Panel1.Controls.Add(Me.btTambah)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(20, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 55)
        Me.Panel1.TabIndex = 4
        '
        'BoxKategori
        '
        Me.BoxKategori.Location = New System.Drawing.Point(12, 14)
        Me.BoxKategori.Name = "BoxKategori"
        Me.BoxKategori.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.BoxKategori.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxKategori.Properties.Appearance.Options.UseFont = True
        Me.BoxKategori.Properties.NullValuePrompt = "Ketik untuk menambah..."
        Me.BoxKategori.Size = New System.Drawing.Size(202, 24)
        Me.BoxKategori.TabIndex = 5
        '
        'btTambah
        '
        Me.btTambah.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTambah.Appearance.Options.UseFont = True
        Me.btTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btTambah.ImageOptions.Image = CType(resources.GetObject("btTambah.ImageOptions.Image"), System.Drawing.Image)
        Me.btTambah.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btTambah.Location = New System.Drawing.Point(230, 12)
        Me.btTambah.Name = "btTambah"
        Me.btTambah.Size = New System.Drawing.Size(76, 26)
        Me.btTambah.TabIndex = 4
        Me.btTambah.Text = "Tambah"
        '
        'MasterKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 350)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GridKategori)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MasterKategori"
        Me.Resizable = False
        Me.Text = "Kategori Barang"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.GridKategori, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewKategori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.BoxKategori.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridKategori As DevExpress.XtraGrid.GridControl
    Friend WithEvents ViewKategori As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btTambah As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BoxKategori As DevExpress.XtraEditors.TextEdit
End Class
