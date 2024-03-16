<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.NamaPembeli = New System.Windows.Forms.Label()
        Me.NamaBarang = New System.Windows.Forms.Label()
        Me.HargaJual = New System.Windows.Forms.Label()
        Me.JumlahBeli = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.JumlahHargaHasil = New System.Windows.Forms.Label()
        Me.DiskonHasil = New System.Windows.Forms.Label()
        Me.TotalBayarHasil = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TbHargaJual = New System.Windows.Forms.TextBox()
        Me.TbJumlahBeli = New System.Windows.Forms.TextBox()
        Me.ButtonProsses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NamaPembeli
        '
        Me.NamaPembeli.AutoSize = True
        Me.NamaPembeli.Location = New System.Drawing.Point(88, 58)
        Me.NamaPembeli.Name = "NamaPembeli"
        Me.NamaPembeli.Size = New System.Drawing.Size(75, 13)
        Me.NamaPembeli.TabIndex = 0
        Me.NamaPembeli.Text = "Nama Pembeli"
        '
        'NamaBarang
        '
        Me.NamaBarang.AutoSize = True
        Me.NamaBarang.Location = New System.Drawing.Point(88, 97)
        Me.NamaBarang.Name = "NamaBarang"
        Me.NamaBarang.Size = New System.Drawing.Size(72, 13)
        Me.NamaBarang.TabIndex = 1
        Me.NamaBarang.Text = "Nama Barang"
        '
        'HargaJual
        '
        Me.HargaJual.AutoSize = True
        Me.HargaJual.Location = New System.Drawing.Point(88, 137)
        Me.HargaJual.Name = "HargaJual"
        Me.HargaJual.Size = New System.Drawing.Size(58, 13)
        Me.HargaJual.TabIndex = 2
        Me.HargaJual.Text = "Harga Jual"
        '
        'JumlahBeli
        '
        Me.JumlahBeli.AutoSize = True
        Me.JumlahBeli.Location = New System.Drawing.Point(88, 179)
        Me.JumlahBeli.Name = "JumlahBeli"
        Me.JumlahBeli.Size = New System.Drawing.Size(60, 13)
        Me.JumlahBeli.TabIndex = 3
        Me.JumlahBeli.Text = "Jumlah Beli"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(88, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Diskon "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(88, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Bayar"
        '
        'JumlahHargaHasil
        '
        Me.JumlahHargaHasil.AutoSize = True
        Me.JumlahHargaHasil.Location = New System.Drawing.Point(188, 218)
        Me.JumlahHargaHasil.Name = "JumlahHargaHasil"
        Me.JumlahHargaHasil.Size = New System.Drawing.Size(49, 13)
        Me.JumlahHargaHasil.TabIndex = 7
        Me.JumlahHargaHasil.Text = "======="
        '
        'DiskonHasil
        '
        Me.DiskonHasil.AutoSize = True
        Me.DiskonHasil.Location = New System.Drawing.Point(188, 260)
        Me.DiskonHasil.Name = "DiskonHasil"
        Me.DiskonHasil.Size = New System.Drawing.Size(49, 13)
        Me.DiskonHasil.TabIndex = 8
        Me.DiskonHasil.Text = "======="
        '
        'TotalBayarHasil
        '
        Me.TotalBayarHasil.AutoSize = True
        Me.TotalBayarHasil.Location = New System.Drawing.Point(188, 304)
        Me.TotalBayarHasil.Name = "TotalBayarHasil"
        Me.TotalBayarHasil.Size = New System.Drawing.Size(43, 13)
        Me.TotalBayarHasil.TabIndex = 9
        Me.TotalBayarHasil.Text = "======"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(191, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 20)
        Me.TextBox1.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(191, 97)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(146, 20)
        Me.TextBox2.TabIndex = 11
        '
        'TbHargaJual
        '
        Me.TbHargaJual.Location = New System.Drawing.Point(191, 137)
        Me.TbHargaJual.Name = "TbHargaJual"
        Me.TbHargaJual.Size = New System.Drawing.Size(146, 20)
        Me.TbHargaJual.TabIndex = 12
        '
        'TbJumlahBeli
        '
        Me.TbJumlahBeli.Location = New System.Drawing.Point(191, 176)
        Me.TbJumlahBeli.Name = "TbJumlahBeli"
        Me.TbJumlahBeli.Size = New System.Drawing.Size(146, 20)
        Me.TbJumlahBeli.TabIndex = 13
        '
        'ButtonProsses
        '
        Me.ButtonProsses.Location = New System.Drawing.Point(162, 356)
        Me.ButtonProsses.Name = "ButtonProsses"
        Me.ButtonProsses.Size = New System.Drawing.Size(75, 23)
        Me.ButtonProsses.TabIndex = 14
        Me.ButtonProsses.Text = "Prosses"
        Me.ButtonProsses.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 450)
        Me.Controls.Add(Me.ButtonProsses)
        Me.Controls.Add(Me.TbJumlahBeli)
        Me.Controls.Add(Me.TbHargaJual)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TotalBayarHasil)
        Me.Controls.Add(Me.DiskonHasil)
        Me.Controls.Add(Me.JumlahHargaHasil)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.JumlahBeli)
        Me.Controls.Add(Me.HargaJual)
        Me.Controls.Add(Me.NamaBarang)
        Me.Controls.Add(Me.NamaPembeli)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NamaPembeli As Label
    Friend WithEvents NamaBarang As Label
    Friend WithEvents HargaJual As Label
    Friend WithEvents JumlahBeli As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents JumlahHargaHasil As Label
    Friend WithEvents DiskonHasil As Label
    Friend WithEvents TotalBayarHasil As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TbHargaJual As TextBox
    Friend WithEvents TbJumlahBeli As TextBox
    Friend WithEvents ButtonProsses As Button
End Class
