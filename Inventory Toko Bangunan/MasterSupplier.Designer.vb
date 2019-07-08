<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MasterSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterSupplier))
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btAddSupp = New DevExpress.XtraEditors.SimpleButton()
        Me.GridSupplier = New DevExpress.XtraGrid.GridControl()
        Me.ViewSupplier = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelHeader.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GridSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.Lavender
        Me.PanelHeader.Controls.Add(Me.Panel2)
        Me.PanelHeader.Controls.Add(Me.Panel3)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(969, 44)
        Me.PanelHeader.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btRefresh)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(102, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(102, 44)
        Me.Panel2.TabIndex = 5
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btAddSupp)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(102, 44)
        Me.Panel3.TabIndex = 4
        '
        'btAddSupp
        '
        Me.btAddSupp.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAddSupp.Appearance.Options.UseFont = True
        Me.btAddSupp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAddSupp.ImageOptions.Image = CType(resources.GetObject("btAddSupp.ImageOptions.Image"), System.Drawing.Image)
        Me.btAddSupp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btAddSupp.Location = New System.Drawing.Point(12, 11)
        Me.btAddSupp.Name = "btAddSupp"
        Me.btAddSupp.Size = New System.Drawing.Size(78, 24)
        Me.btAddSupp.TabIndex = 1
        Me.btAddSupp.Text = "Tambah"
        '
        'GridSupplier
        '
        Me.GridSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSupplier.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridSupplier.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.GridSupplier.EmbeddedNavigator.TextStringFormat = "{0} dari {1}"
        Me.GridSupplier.Location = New System.Drawing.Point(0, 44)
        Me.GridSupplier.MainView = Me.ViewSupplier
        Me.GridSupplier.Name = "GridSupplier"
        Me.GridSupplier.Size = New System.Drawing.Size(969, 423)
        Me.GridSupplier.TabIndex = 2
        Me.GridSupplier.UseEmbeddedNavigator = True
        Me.GridSupplier.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ViewSupplier})
        '
        'ViewSupplier
        '
        Me.ViewSupplier.Appearance.HeaderPanel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewSupplier.Appearance.HeaderPanel.Options.UseFont = True
        Me.ViewSupplier.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.ViewSupplier.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ViewSupplier.Appearance.Row.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewSupplier.Appearance.Row.Options.UseFont = True
        Me.ViewSupplier.GridControl = Me.GridSupplier
        Me.ViewSupplier.Name = "ViewSupplier"
        Me.ViewSupplier.OptionsBehavior.Editable = False
        Me.ViewSupplier.OptionsCustomization.AllowFilter = False
        Me.ViewSupplier.OptionsCustomization.AllowQuickHideColumns = False
        Me.ViewSupplier.OptionsFind.AlwaysVisible = True
        Me.ViewSupplier.OptionsFind.FindDelay = 500
        Me.ViewSupplier.OptionsFind.FindNullPrompt = "Ketik disini untuk mencari..."
        Me.ViewSupplier.OptionsMenu.EnableColumnMenu = False
        Me.ViewSupplier.OptionsMenu.EnableFooterMenu = False
        Me.ViewSupplier.OptionsMenu.EnableGroupPanelMenu = False
        Me.ViewSupplier.OptionsView.ColumnAutoWidth = False
        '
        'MasterSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 467)
        Me.Controls.Add(Me.GridSupplier)
        Me.Controls.Add(Me.PanelHeader)
        Me.Name = "MasterSupplier"
        Me.Text = "Pemasok"
        Me.PanelHeader.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.GridSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents GridSupplier As DevExpress.XtraGrid.GridControl
    Friend WithEvents ViewSupplier As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btAddSupp As DevExpress.XtraEditors.SimpleButton
End Class
