<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        lblPrice = New Label()
        GroupBox1 = New GroupBox()
        rbCPU1 = New RadioButton()
        rbCPU2 = New RadioButton()
        rbCPU3 = New RadioButton()
        GroupBox2 = New GroupBox()
        rbOSHome = New RadioButton()
        rbOSPro = New RadioButton()
        GroupBox3 = New GroupBox()
        rbGPU1 = New RadioButton()
        rbGPU2 = New RadioButton()
        rbGPU3 = New RadioButton()
        rbGPU4 = New RadioButton()
        GroupBox4 = New GroupBox()
        rbRAM16 = New RadioButton()
        rbRAM32 = New RadioButton()
        rbRAM64 = New RadioButton()
        GroupBox5 = New GroupBox()
        rbSSD1 = New RadioButton()
        rbSSD2 = New RadioButton()
        rbSSD4 = New RadioButton()
        GroupBox6 = New GroupBox()
        rbWarranty1 = New RadioButton()
        rbWarranty2 = New RadioButton()
        rbWarranty3 = New RadioButton()
        rbWarranty4 = New RadioButton()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox6.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.A24_SouMou_Computer_banner
        PictureBox1.Location = New Point(18, 13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(750, 125)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.SouMou_laptop_700x400
        PictureBox2.Location = New Point(18, 149)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(350, 200)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(45, 352)
        Label1.Name = "Label1"
        Label1.Size = New Size(297, 32)
        Label1.TabIndex = 2
        Label1.Text = "Laptop Model: CIS150AB"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(88, 397)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 16)
        Label2.TabIndex = 3
        Label2.Text = "Price as configured:"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPrice.Location = New Point(219, 384)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(105, 32)
        lblPrice.TabIndex = 4
        lblPrice.Text = "$699.00"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.PeachPuff
        GroupBox1.Controls.Add(rbCPU1)
        GroupBox1.Controls.Add(rbCPU2)
        GroupBox1.Controls.Add(rbCPU3)
        GroupBox1.Font = New Font("Segoe UI", 9.0F)
        GroupBox1.Location = New Point(390, 148)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(382, 93)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Processor Choice"
        ' 
        ' rbCPU1
        ' 
        rbCPU1.AutoSize = True
        rbCPU1.Checked = True
        rbCPU1.Location = New Point(26, 69)
        rbCPU1.Name = "rbCPU1"
        rbCPU1.Size = New Size(278, 19)
        rbCPU1.TabIndex = 2
        rbCPU1.TabStop = True
        rbCPU1.Text = "SouMou Central 10, 10 cores at 4.65 GHz ($Base)"
        rbCPU1.UseVisualStyleBackColor = True
        ' 
        ' rbCPU2
        ' 
        rbCPU2.AutoSize = True
        rbCPU2.Location = New Point(26, 44)
        rbCPU2.Name = "rbCPU2"
        rbCPU2.Size = New Size(280, 19)
        rbCPU2.TabIndex = 1
        rbCPU2.Text = "SouMou Central 14, 14 cores at 5.25 GHz (+$125)"
        rbCPU2.UseVisualStyleBackColor = True
        ' 
        ' rbCPU3
        ' 
        rbCPU3.AutoSize = True
        rbCPU3.Location = New Point(26, 19)
        rbCPU3.Name = "rbCPU3"
        rbCPU3.Size = New Size(280, 19)
        rbCPU3.TabIndex = 0
        rbCPU3.Text = "SouMou Central 18, 18 cores at 6.75 GHz (+$300)"
        rbCPU3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.PaleTurquoise
        GroupBox2.Controls.Add(rbOSHome)
        GroupBox2.Controls.Add(rbOSPro)
        GroupBox2.Font = New Font("Segoe UI", 9.0F)
        GroupBox2.Location = New Point(391, 247)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(381, 71)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "Operating System"
        ' 
        ' rbOSHome
        ' 
        rbOSHome.AutoSize = True
        rbOSHome.Checked = True
        rbOSHome.Location = New Point(26, 43)
        rbOSHome.Name = "rbOSHome"
        rbOSHome.Size = New Size(164, 19)
        rbOSHome.TabIndex = 1
        rbOSHome.TabStop = True
        rbOSHome.Text = "Ventanas 12 Home ($Base)"
        rbOSHome.UseVisualStyleBackColor = True
        ' 
        ' rbOSPro
        ' 
        rbOSPro.AutoSize = True
        rbOSPro.Location = New Point(26, 18)
        rbOSPro.Name = "rbOSPro"
        rbOSPro.Size = New Size(145, 19)
        rbOSPro.TabIndex = 0
        rbOSPro.Text = "Ventanas 12 Pro (+$70)"
        rbOSPro.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.PeachPuff
        GroupBox3.Controls.Add(rbGPU1)
        GroupBox3.Controls.Add(rbGPU2)
        GroupBox3.Controls.Add(rbGPU3)
        GroupBox3.Controls.Add(rbGPU4)
        GroupBox3.Font = New Font("Segoe UI", 9.0F)
        GroupBox3.Location = New Point(391, 324)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(381, 116)
        GroupBox3.TabIndex = 6
        GroupBox3.TabStop = False
        GroupBox3.Text = "Graphics Processing"
        ' 
        ' rbGPU1
        ' 
        rbGPU1.AutoSize = True
        rbGPU1.Checked = True
        rbGPU1.Location = New Point(26, 93)
        rbGPU1.Name = "rbGPU1"
        rbGPU1.Size = New Size(278, 19)
        rbGPU1.TabIndex = 3
        rbGPU1.TabStop = True
        rbGPU1.Text = "SouMou Central 10, 10 cores at 4.65 GHz ($Base)"
        rbGPU1.UseVisualStyleBackColor = True
        ' 
        ' rbGPU2
        ' 
        rbGPU2.AutoSize = True
        rbGPU2.Location = New Point(26, 69)
        rbGPU2.Name = "rbGPU2"
        rbGPU2.Size = New Size(243, 19)
        rbGPU2.TabIndex = 2
        rbGPU2.Text = "XVIDIA QueForce RMX 3000, 4 GB (+$355)"
        rbGPU2.UseVisualStyleBackColor = True
        ' 
        ' rbGPU3
        ' 
        rbGPU3.AutoSize = True
        rbGPU3.Location = New Point(26, 44)
        rbGPU3.Name = "rbGPU3"
        rbGPU3.Size = New Size(243, 19)
        rbGPU3.TabIndex = 1
        rbGPU3.Text = "XVIDIA QueForce RMX 4000, 6 GB (+$575)"
        rbGPU3.UseVisualStyleBackColor = True
        ' 
        ' rbGPU4
        ' 
        rbGPU4.AutoSize = True
        rbGPU4.Location = New Point(26, 19)
        rbGPU4.Name = "rbGPU4"
        rbGPU4.Size = New Size(243, 19)
        rbGPU4.TabIndex = 0
        rbGPU4.Text = "XVIDIA QueForce RMX 5000, 8 GB (+$825)"
        rbGPU4.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.PaleTurquoise
        GroupBox4.Controls.Add(rbRAM16)
        GroupBox4.Controls.Add(rbRAM32)
        GroupBox4.Controls.Add(rbRAM64)
        GroupBox4.Font = New Font("Segoe UI", 9.0F)
        GroupBox4.Location = New Point(392, 446)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(225, 103)
        GroupBox4.TabIndex = 7
        GroupBox4.TabStop = False
        GroupBox4.Text = "RAM Memory"
        ' 
        ' rbRAM16
        ' 
        rbRAM16.AutoSize = True
        rbRAM16.Checked = True
        rbRAM16.Location = New Point(23, 71)
        rbRAM16.Name = "rbRAM16"
        rbRAM16.Size = New Size(185, 19)
        rbRAM16.TabIndex = 3
        rbRAM16.TabStop = True
        rbRAM16.Text = "16 GB RAM, 6400 MT/s ($Base)"
        rbRAM16.UseVisualStyleBackColor = True
        ' 
        ' rbRAM32
        ' 
        rbRAM32.AutoSize = True
        rbRAM32.Location = New Point(23, 47)
        rbRAM32.Name = "rbRAM32"
        rbRAM32.Size = New Size(187, 19)
        rbRAM32.TabIndex = 2
        rbRAM32.Text = "32 GB RAM, 6400 MT/s (+$185)"
        rbRAM32.UseVisualStyleBackColor = True
        ' 
        ' rbRAM64
        ' 
        rbRAM64.AutoSize = True
        rbRAM64.Location = New Point(23, 22)
        rbRAM64.Name = "rbRAM64"
        rbRAM64.Size = New Size(187, 19)
        rbRAM64.TabIndex = 1
        rbRAM64.Text = "64 GB RAM, 7800 MT/s (+$345)"
        rbRAM64.UseVisualStyleBackColor = True
        ' 
        ' GroupBox5
        ' 
        GroupBox5.BackColor = Color.PaleTurquoise
        GroupBox5.Controls.Add(rbSSD1)
        GroupBox5.Controls.Add(rbSSD2)
        GroupBox5.Controls.Add(rbSSD4)
        GroupBox5.Font = New Font("Segoe UI", 9.0F)
        GroupBox5.Location = New Point(625, 446)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(147, 103)
        GroupBox5.TabIndex = 8
        GroupBox5.TabStop = False
        GroupBox5.Text = "Storage"
        ' 
        ' rbSSD1
        ' 
        rbSSD1.AutoSize = True
        rbSSD1.Checked = True
        rbSSD1.Location = New Point(23, 71)
        rbSSD1.Name = "rbSSD1"
        rbSSD1.Size = New Size(70, 19)
        rbSSD1.TabIndex = 3
        rbSSD1.TabStop = True
        rbSSD1.Text = "1 TB SSD"
        rbSSD1.UseVisualStyleBackColor = True
        ' 
        ' rbSSD2
        ' 
        rbSSD2.AutoSize = True
        rbSSD2.Location = New Point(23, 47)
        rbSSD2.Name = "rbSSD2"
        rbSSD2.Size = New Size(113, 19)
        rbSSD2.TabIndex = 2
        rbSSD2.Text = "2 TB SSD (+$225)"
        rbSSD2.UseVisualStyleBackColor = True
        ' 
        ' rbSSD4
        ' 
        rbSSD4.AutoSize = True
        rbSSD4.Location = New Point(23, 22)
        rbSSD4.Name = "rbSSD4"
        rbSSD4.Size = New Size(107, 19)
        rbSSD4.TabIndex = 1
        rbSSD4.Text = "4 TB SSD (+445)"
        rbSSD4.UseVisualStyleBackColor = True
        ' 
        ' GroupBox6
        ' 
        GroupBox6.BackColor = Color.Gainsboro
        GroupBox6.Controls.Add(rbWarranty1)
        GroupBox6.Controls.Add(rbWarranty2)
        GroupBox6.Controls.Add(rbWarranty3)
        GroupBox6.Controls.Add(rbWarranty4)
        GroupBox6.Font = New Font("Segoe UI", 9.0F)
        GroupBox6.Location = New Point(179, 433)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(199, 116)
        GroupBox6.TabIndex = 9
        GroupBox6.TabStop = False
        GroupBox6.Text = "Warranty"
        ' 
        ' rbWarranty1
        ' 
        rbWarranty1.AutoSize = True
        rbWarranty1.Checked = True
        rbWarranty1.Location = New Point(26, 93)
        rbWarranty1.Name = "rbWarranty1"
        rbWarranty1.Size = New Size(148, 19)
        rbWarranty1.TabIndex = 3
        rbWarranty1.TabStop = True
        rbWarranty1.Text = "1 Year Warranty ($Base)"
        rbWarranty1.UseVisualStyleBackColor = True
        ' 
        ' rbWarranty2
        ' 
        rbWarranty2.AutoSize = True
        rbWarranty2.Location = New Point(26, 69)
        rbWarranty2.Name = "rbWarranty2"
        rbWarranty2.Size = New Size(148, 19)
        rbWarranty2.TabIndex = 2
        rbWarranty2.Text = "2 Year Warranty (+12%)"
        rbWarranty2.UseVisualStyleBackColor = True
        ' 
        ' rbWarranty3
        ' 
        rbWarranty3.AutoSize = True
        rbWarranty3.Location = New Point(26, 44)
        rbWarranty3.Name = "rbWarranty3"
        rbWarranty3.Size = New Size(148, 19)
        rbWarranty3.TabIndex = 1
        rbWarranty3.Text = "3 Year Warranty (+16%)"
        rbWarranty3.UseVisualStyleBackColor = True
        ' 
        ' rbWarranty4
        ' 
        rbWarranty4.AutoSize = True
        rbWarranty4.Location = New Point(26, 19)
        rbWarranty4.Name = "rbWarranty4"
        rbWarranty4.Size = New Size(148, 19)
        rbWarranty4.TabIndex = 0
        rbWarranty4.Text = "4 Year Warranty (+20%)"
        rbWarranty4.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(18, 433)
        Label3.Name = "Label3"
        Label3.Size = New Size(145, 88)
        Label3.TabIndex = 10
        Label3.Text = "Price will automatically update with changes in selections."
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 561)
        Controls.Add(Label3)
        Controls.Add(GroupBox6)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(lblPrice)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Laptop Customization"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbCPU3 As RadioButton
    Friend WithEvents rbCPU1 As RadioButton
    Friend WithEvents rbCPU2 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbOSHome As RadioButton
    Friend WithEvents rbOSPro As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbGPU2 As RadioButton
    Friend WithEvents rbGPU3 As RadioButton
    Friend WithEvents rbGPU4 As RadioButton
    Friend WithEvents rbGPU1 As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rbRAM16 As RadioButton
    Friend WithEvents rbRAM32 As RadioButton
    Friend WithEvents rbRAM64 As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rbSSD1 As RadioButton
    Friend WithEvents rbSSD2 As RadioButton
    Friend WithEvents rbSSD4 As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents rbWarranty1 As RadioButton
    Friend WithEvents rbWarranty2 As RadioButton
    Friend WithEvents rbWarranty3 As RadioButton
    Friend WithEvents rbWarranty4 As RadioButton
    Friend WithEvents Label3 As Label

End Class
