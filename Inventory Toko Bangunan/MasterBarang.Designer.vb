<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterBarang
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterBarang))
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btImport = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btAddBarang = New DevExpress.XtraEditors.SimpleButton()
        Me.GridBarang = New DevExpress.XtraGrid.GridControl()
        Me.ViewBarang = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelHeader.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GridBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.Lavender
        Me.PanelHeader.Controls.Add(Me.Panel3)
        Me.PanelHeader.Controls.Add(Me.Panel1)
        Me.PanelHeader.Controls.Add(Me.Panel2)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(990, 44)
        Me.PanelHeader.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btImport)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(204, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(102, 44)
        Me.Panel3.TabIndex = 4
        '
        'btImport
        '
        Me.btImport.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btImport.Appearance.Options.UseFont = True
        Me.btImport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btImport.ImageOptions.Image = CType(resources.GetObject("btImport.ImageOptions.Image"), System.Drawing.Image)
        Me.btImport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btImport.Location = New System.Drawing.Point(12, 11)
        Me.btImport.Name = "btImport"
        Me.btImport.Size = New System.Drawing.Size(78, 24)
        Me.btImport.TabIndex = 1
        Me.btImport.Text = "Import"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btRefresh)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(102, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(102, 44)
        Me.Panel1.TabIndex = 3
        '
        'btRefresh
        '
        Me.btRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRefresh.Appearance.Options.UseFont = True
        Me.btRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btRefresh.ImageOptions.Image = CType(resources.GetObject("btRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.btRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btRefresh.Location = New System.Drawing.Point(12, 11)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(78, 24)
        Me.btRefresh.TabIndex = 1
        Me.btRefresh.Text = "Refresh"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btAddBarang)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(102, 44)
        Me.Panel2.TabIndex = 2
        '
        'btAddBarang
        '
        Me.btAddBarang.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAddBarang.Appearance.Options.UseFont = True
        Me.btAddBarang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAddBarang.ImageOptions.Image = CType(resources.GetObject("btAddBarang.ImageOptions.Image"), System.Drawing.Image)
        Me.btAddBarang.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btAddBarang.Location = New System.Drawing.Point(12, 11)
        Me.btAddBarang.Name = "btAddBarang"
        Me.btAddBarang.Size = New System.Drawing.Size(78, 24)
        Me.btAddBarang.TabIndex = 1
        Me.btAddBarang.Text = "Tambah"
        '
        'GridBarang
        '
        Me.GridBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBarang.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridBarang.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.GridBarang.EmbeddedNavigator.TextStringFormat = "{0} dari {1}"
        Me.GridBarang.Location = New System.Drawing.Point(0, 44)
        Me.GridBarang.MainView = Me.ViewBarang
        Me.GridBarang.Name = "GridBarang"
        Me.GridBarang.Size = New System.Drawing.Size(990, 445)
        Me.GridBarang.TabIndex = 1
        Me.GridBarang.UseEmbeddedNavigator = True
        Me.GridBarang.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ViewBarang})
        '
        'ViewBarang
        '
        Me.ViewBarang.Appearance.HeaderPanel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewBarang.Appearance.HeaderPanel.Options.UseFont = True
        Me.ViewBarang.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.ViewBarang.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ViewBarang.Appearance.Row.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewBarang.Appearance.Row.Options.UseFont = True
        Me.ViewBarang.GridControl = Me.GridBarang
        Me.ViewBarang.Name = "ViewBarang"
        Me.ViewBarang.OptionsBehavior.Editable = False
        Me.ViewBarang.OptionsCustomization.AllowFilter = False
        Me.ViewBarang.OptionsCustomization.AllowQuickHideColumns = False
        Me.ViewBarang.OptionsFind.AlwaysVisible = True
        Me.ViewBarang.OptionsFind.FindDelay = 500
        Me.ViewBarang.OptionsFind.FindNullPrompt = "Ketik disini untuk mencari..."
        Me.ViewBarang.OptionsMenu.EnableColumnMenu = False
        Me.ViewBarang.OptionsMenu.EnableFooterMenu = False
        Me.ViewBarang.OptionsMenu.EnableGroupPanelMenu = False
        Me.ViewBarang.OptionsView.ColumnAutoWidth = False
        '
        'MasterBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 489)
        Me.Controls.Add(Me.GridBarang)
        Me.Controls.Add(Me.PanelHeader)
        Me.Name = "MasterBarang"
        Me.Text = "Barang"
        Me.PanelHeader.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GridBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents GridBarang As DevExpress.XtraGrid.GridControl
    Friend WithEvents ViewBarang As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btAddBarang As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btImport As DevExpress.XtraEditors.SimpleButton
End Class
