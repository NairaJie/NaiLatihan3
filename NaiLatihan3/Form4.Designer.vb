<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.NamaTki = New System.Windows.Forms.Label()
        Me.Tujuan = New System.Windows.Forms.Label()
        Me.BiayaKeberangkatan = New System.Windows.Forms.Label()
        Me.BiayaVisa = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BiayaKeberangkatanHasil = New System.Windows.Forms.Label()
        Me.BiayaAdminitrasiHasil = New System.Windows.Forms.Label()
        Me.TotalBiayaHasil = New System.Windows.Forms.Label()
        Me.TbVisa = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ButtonProsses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NamaTki
        '
        Me.NamaTki.AutoSize = True
        Me.NamaTki.Location = New System.Drawing.Point(65, 46)
        Me.NamaTki.Name = "NamaTki"
        Me.NamaTki.Size = New System.Drawing.Size(55, 13)
        Me.NamaTki.TabIndex = 0
        Me.NamaTki.Text = "Nama TKI"
        '
        'Tujuan
        '
        Me.Tujuan.AutoSize = True
        Me.Tujuan.Location = New System.Drawing.Point(65, 89)
        Me.Tujuan.Name = "Tujuan"
        Me.Tujuan.Size = New System.Drawing.Size(40, 13)
        Me.Tujuan.TabIndex = 1
        Me.Tujuan.Text = "Tujuan"
        '
        'BiayaKeberangkatan
        '
        Me.BiayaKeberangkatan.AutoSize = True
        Me.BiayaKeberangkatan.Location = New System.Drawing.Point(65, 131)
        Me.BiayaKeberangkatan.Name = "BiayaKeberangkatan"
        Me.BiayaKeberangkatan.Size = New System.Drawing.Size(109, 13)
        Me.BiayaKeberangkatan.TabIndex = 2
        Me.BiayaKeberangkatan.Text = "Biaya Keberangkatan"
        '
        'BiayaVisa
        '
        Me.BiayaVisa.AutoSize = True
        Me.BiayaVisa.Location = New System.Drawing.Point(65, 176)
        Me.BiayaVisa.Name = "BiayaVisa"
        Me.BiayaVisa.Size = New System.Drawing.Size(53, 13)
        Me.BiayaVisa.TabIndex = 3
        Me.BiayaVisa.Text = "BiayaVisa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Biaya Adminitrasi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(65, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Biaya"
        '
        'BiayaKeberangkatanHasil
        '
        Me.BiayaKeberangkatanHasil.AutoSize = True
        Me.BiayaKeberangkatanHasil.Location = New System.Drawing.Point(196, 131)
        Me.BiayaKeberangkatanHasil.Name = "BiayaKeberangkatanHasil"
        Me.BiayaKeberangkatanHasil.Size = New System.Drawing.Size(55, 13)
        Me.BiayaKeberangkatanHasil.TabIndex = 6
        Me.BiayaKeberangkatanHasil.Text = "========"
        '
        'BiayaAdminitrasiHasil
        '
        Me.BiayaAdminitrasiHasil.AutoSize = True
        Me.BiayaAdminitrasiHasil.Location = New System.Drawing.Point(196, 220)
        Me.BiayaAdminitrasiHasil.Name = "BiayaAdminitrasiHasil"
        Me.BiayaAdminitrasiHasil.Size = New System.Drawing.Size(67, 13)
        Me.BiayaAdminitrasiHasil.TabIndex = 7
        Me.BiayaAdminitrasiHasil.Text = "=========="
        '
        'TotalBiayaHasil
        '
        Me.TotalBiayaHasil.AutoSize = True
        Me.TotalBiayaHasil.Location = New System.Drawing.Point(196, 262)
        Me.TotalBiayaHasil.Name = "TotalBiayaHasil"
        Me.TotalBiayaHasil.Size = New System.Drawing.Size(55, 13)
        Me.TotalBiayaHasil.TabIndex = 8
        Me.TotalBiayaHasil.Text = "========"
        '
        'TbVisa
        '
        Me.TbVisa.Location = New System.Drawing.Point(199, 176)
        Me.TbVisa.Name = "TbVisa"
        Me.TbVisa.Size = New System.Drawing.Size(179, 20)
        Me.TbVisa.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(199, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(179, 20)
        Me.TextBox2.TabIndex = 10
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Malaysia", "Singapore", "Turki", "Arab"})
        Me.ComboBox1.Location = New System.Drawing.Point(199, 89)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(179, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'ButtonProsses
        '
        Me.ButtonProsses.Location = New System.Drawing.Point(163, 319)
        Me.ButtonProsses.Name = "ButtonProsses"
        Me.ButtonProsses.Size = New System.Drawing.Size(75, 23)
        Me.ButtonProsses.TabIndex = 12
        Me.ButtonProsses.Text = "Prosses"
        Me.ButtonProsses.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 450)
        Me.Controls.Add(Me.ButtonProsses)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TbVisa)
        Me.Controls.Add(Me.TotalBiayaHasil)
        Me.Controls.Add(Me.BiayaAdminitrasiHasil)
        Me.Controls.Add(Me.BiayaKeberangkatanHasil)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BiayaVisa)
        Me.Controls.Add(Me.BiayaKeberangkatan)
        Me.Controls.Add(Me.Tujuan)
        Me.Controls.Add(Me.NamaTki)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NamaTki As Label
    Friend WithEvents Tujuan As Label
    Friend WithEvents BiayaKeberangkatan As Label
    Friend WithEvents BiayaVisa As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BiayaKeberangkatanHasil As Label
    Friend WithEvents BiayaAdminitrasiHasil As Label
    Friend WithEvents TotalBiayaHasil As Label
    Friend WithEvents TbVisa As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ButtonProsses As Button
End Class
