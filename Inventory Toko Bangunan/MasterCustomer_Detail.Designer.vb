<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterCustomer_Detail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterCustomer_Detail))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btSimpan = New DevExpress.XtraEditors.SimpleButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BoxTelp = New System.Windows.Forms.TextBox()
        Me.BoxAlamat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BoxNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.Panel4.Size = New System.Drawing.Size(360, 32)
        Me.Panel4.TabIndex = 24
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(15, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 25)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "General"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.BoxTelp)
        Me.Panel1.Controls.Add(Me.BoxAlamat)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BoxNama)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(20, 133)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 163)
        Me.Panel1.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Telp :"
        '
        'BoxTelp
        '
        Me.BoxTelp.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxTelp.Location = New System.Drawing.Point(82, 117)
        Me.BoxTelp.Name = "BoxTelp"
        Me.BoxTelp.Size = New System.Drawing.Size(260, 26)
        Me.BoxTelp.TabIndex = 23
        '
        'BoxAlamat
        '
        Me.BoxAlamat.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxAlamat.Location = New System.Drawing.Point(82, 54)
        Me.BoxAlamat.Multiline = True
        Me.BoxAlamat.Name = "BoxAlamat"
        Me.BoxAlamat.Size = New System.Drawing.Size(260, 48)
        Me.BoxAlamat.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "*Nama :"
        '
        'BoxNama
        '
        Me.BoxNama.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxNama.Location = New System.Drawing.Point(82, 13)
        Me.BoxNama.Name = "BoxNama"
        Me.BoxNama.Size = New System.Drawing.Size(260, 26)
        Me.BoxNama.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Alamat :"
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(109, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(249, 30)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Kolom dengan tanda bintang (*) wajib diisi"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MasterCustomer_Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 320)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MasterCustomer_Detail"
        Me.Resizable = False
        Me.Text = "Detail Customer"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents btSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents BoxTelp As TextBox
    Friend WithEvents BoxAlamat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BoxNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
End Class
