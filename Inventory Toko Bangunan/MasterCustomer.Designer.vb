<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterCustomer))
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btAddCust = New DevExpress.XtraEditors.SimpleButton()
        Me.GridCust = New DevExpress.XtraGrid.GridControl()
        Me.ViewCust = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GridCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewCust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.Lavender
        Me.PanelHeader.Controls.Add(Me.Panel1)
        Me.PanelHeader.Controls.Add(Me.Panel2)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(985, 44)
        Me.PanelHeader.TabIndex = 2
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
        Me.Panel2.Controls.Add(Me.btAddCust)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(102, 44)
        Me.Panel2.TabIndex = 2
        '
        'btAddCust
        '
        Me.btAddCust.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAddCust.Appearance.Options.UseFont = True
        Me.btAddCust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAddCust.ImageOptions.Image = CType(resources.GetObject("btAddCust.ImageOptions.Image"), System.Drawing.Image)
        Me.btAddCust.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btAddCust.Location = New System.Drawing.Point(12, 11)
        Me.btAddCust.Name = "btAddCust"
        Me.btAddCust.Size = New System.Drawing.Size(78, 24)
        Me.btAddCust.TabIndex = 1
        Me.btAddCust.Text = "Tambah"
        '
        'GridCust
        '
        Me.GridCust.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCust.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridCust.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.GridCust.EmbeddedNavigator.TextStringFormat = "{0} dari {1}"
        Me.GridCust.Location = New System.Drawing.Point(0, 44)
        Me.GridCust.MainView = Me.ViewCust
        Me.GridCust.Name = "GridCust"
        Me.GridCust.Size = New System.Drawing.Size(985, 441)
        Me.GridCust.TabIndex = 3
        Me.GridCust.UseEmbeddedNavigator = True
        Me.GridCust.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ViewCust})
        '
        'ViewCust
        '
        Me.ViewCust.Appearance.HeaderPanel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewCust.Appearance.HeaderPanel.Options.UseFont = True
        Me.ViewCust.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.ViewCust.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ViewCust.Appearance.Row.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewCust.Appearance.Row.Options.UseFont = True
        Me.ViewCust.GridControl = Me.GridCust
        Me.ViewCust.Name = "ViewCust"
        Me.ViewCust.OptionsBehavior.Editable = False
        Me.ViewCust.OptionsCustomization.AllowFilter = False
        Me.ViewCust.OptionsCustomization.AllowQuickHideColumns = False
        Me.ViewCust.OptionsFind.AlwaysVisible = True
        Me.ViewCust.OptionsFind.FindDelay = 500
        Me.ViewCust.OptionsFind.FindNullPrompt = "Ketik disini untuk mencari..."
        Me.ViewCust.OptionsMenu.EnableColumnMenu = False
        Me.ViewCust.OptionsMenu.EnableFooterMenu = False
        Me.ViewCust.OptionsMenu.EnableGroupPanelMenu = False
        Me.ViewCust.OptionsView.ColumnAutoWidth = False
        '
        'MasterCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 485)
        Me.Controls.Add(Me.GridCust)
        Me.Controls.Add(Me.PanelHeader)
        Me.Name = "MasterCustomer"
        Me.Text = "Pelanggan"
        Me.PanelHeader.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GridCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewCust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btAddCust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridCust As DevExpress.XtraGrid.GridControl
    Friend WithEvents ViewCust As DevExpress.XtraGrid.Views.Grid.GridView
End Class
