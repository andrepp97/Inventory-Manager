<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RiwayatPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RiwayatPembelian))
        Me.ViewRiwayatBeli = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridRiwayatBeli = New DevExpress.XtraGrid.GridControl()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btRefresh = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.ViewRiwayatBeli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridRiwayatBeli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ViewRiwayatBeli
        '
        Me.ViewRiwayatBeli.Appearance.FooterPanel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewRiwayatBeli.Appearance.FooterPanel.Options.UseFont = True
        Me.ViewRiwayatBeli.Appearance.HeaderPanel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewRiwayatBeli.Appearance.HeaderPanel.Options.UseFont = True
        Me.ViewRiwayatBeli.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.ViewRiwayatBeli.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ViewRiwayatBeli.Appearance.Row.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewRiwayatBeli.Appearance.Row.Options.UseFont = True
        Me.ViewRiwayatBeli.GridControl = Me.GridRiwayatBeli
        Me.ViewRiwayatBeli.Name = "ViewRiwayatBeli"
        Me.ViewRiwayatBeli.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.ViewRiwayatBeli.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.ViewRiwayatBeli.OptionsBehavior.Editable = False
        Me.ViewRiwayatBeli.OptionsCustomization.AllowColumnMoving = False
        Me.ViewRiwayatBeli.OptionsCustomization.AllowQuickHideColumns = False
        Me.ViewRiwayatBeli.OptionsFind.AlwaysVisible = True
        Me.ViewRiwayatBeli.OptionsFind.FindDelay = 500
        Me.ViewRiwayatBeli.OptionsFind.FindNullPrompt = "Ketik disini untuk mencari..."
        Me.ViewRiwayatBeli.OptionsMenu.EnableColumnMenu = False
        Me.ViewRiwayatBeli.OptionsMenu.EnableFooterMenu = False
        Me.ViewRiwayatBeli.OptionsMenu.EnableGroupPanelMenu = False
        Me.ViewRiwayatBeli.OptionsNavigation.EnterMoveNextColumn = True
        Me.ViewRiwayatBeli.OptionsView.ShowFooter = True
        Me.ViewRiwayatBeli.OptionsView.ShowGroupPanel = False
        '
        'GridRiwayatBeli
        '
        Me.GridRiwayatBeli.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridRiwayatBeli.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridRiwayatBeli.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.GridRiwayatBeli.EmbeddedNavigator.TextStringFormat = "{0} dari {1}"
        Me.GridRiwayatBeli.Location = New System.Drawing.Point(0, 0)
        Me.GridRiwayatBeli.MainView = Me.ViewRiwayatBeli
        Me.GridRiwayatBeli.Name = "GridRiwayatBeli"
        Me.GridRiwayatBeli.Size = New System.Drawing.Size(1064, 437)
        Me.GridRiwayatBeli.TabIndex = 9
        Me.GridRiwayatBeli.UseEmbeddedNavigator = True
        Me.GridRiwayatBeli.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ViewRiwayatBeli})
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GridRiwayatBeli)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 44)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1064, 437)
        Me.Panel5.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lavender
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1064, 44)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btRefresh)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(102, 44)
        Me.Panel2.TabIndex = 4
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
        'RiwayatPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 481)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RiwayatPembelian"
        Me.Text = "Riwayat Pembelian"
        CType(Me.ViewRiwayatBeli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridRiwayatBeli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ViewRiwayatBeli As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridRiwayatBeli As DevExpress.XtraGrid.GridControl
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btRefresh As DevExpress.XtraEditors.SimpleButton
End Class
