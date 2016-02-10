<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddModifiers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddModifiers))
        Me.btnAdminLogin = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnSauces = New System.Windows.Forms.Button()
        Me.btnCheeses = New System.Windows.Forms.Button()
        Me.btnToppings = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.pbxItem = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.chkModifier3 = New System.Windows.Forms.CheckBox()
        Me.chkModifier4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.chkModifier2 = New System.Windows.Forms.CheckBox()
        Me.chkModifier1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.pbxDecrement = New System.Windows.Forms.PictureBox()
        Me.pbxIncrement = New System.Windows.Forms.PictureBox()
        Me.lblItemQuantity = New System.Windows.Forms.Label()
        Me.lblItemDescription = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        CType(Me.pbxItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDecrement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxIncrement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdminLogin
        '
        Me.btnAdminLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdminLogin.Location = New System.Drawing.Point(1233, 20)
        Me.btnAdminLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdminLogin.Name = "btnAdminLogin"
        Me.btnAdminLogin.Size = New System.Drawing.Size(205, 28)
        Me.btnAdminLogin.TabIndex = 115
        Me.btnAdminLogin.Text = "Admin Logon"
        Me.btnAdminLogin.UseVisualStyleBackColor = True
        '
        'pnlHeader
        '
        Me.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Controls.Add(Me.btnSauces)
        Me.pnlHeader.Controls.Add(Me.btnCheeses)
        Me.pnlHeader.Controls.Add(Me.btnToppings)
        Me.pnlHeader.Controls.Add(Me.btnCancel)
        Me.pnlHeader.Location = New System.Drawing.Point(92, 52)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1200, 59)
        Me.pnlHeader.TabIndex = 108
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(39, 12)
        Me.lblHeader.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(346, 24)
        Me.lblHeader.TabIndex = 9
        Me.lblHeader.Text = "Touch the Screen to Select Food/Drinks"
        '
        'btnSauces
        '
        Me.btnSauces.Location = New System.Drawing.Point(703, 4)
        Me.btnSauces.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSauces.Name = "btnSauces"
        Me.btnSauces.Size = New System.Drawing.Size(117, 52)
        Me.btnSauces.TabIndex = 3
        Me.btnSauces.Text = "Sauces"
        Me.btnSauces.UseVisualStyleBackColor = True
        '
        'btnCheeses
        '
        Me.btnCheeses.Location = New System.Drawing.Point(828, 4)
        Me.btnCheeses.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCheeses.Name = "btnCheeses"
        Me.btnCheeses.Size = New System.Drawing.Size(117, 52)
        Me.btnCheeses.TabIndex = 2
        Me.btnCheeses.Text = "Cheeses"
        Me.btnCheeses.UseVisualStyleBackColor = True
        '
        'btnToppings
        '
        Me.btnToppings.Location = New System.Drawing.Point(953, 4)
        Me.btnToppings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnToppings.Name = "btnToppings"
        Me.btnToppings.Size = New System.Drawing.Size(117, 52)
        Me.btnToppings.TabIndex = 1
        Me.btnToppings.Text = "Toppings"
        Me.btnToppings.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(1079, 4)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(117, 52)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(1233, 565)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(212, 64)
        Me.btnConfirm.TabIndex = 116
        Me.btnConfirm.Text = "Confirm This Order"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'pbxItem
        '
        Me.pbxItem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxItem.Location = New System.Drawing.Point(304, 176)
        Me.pbxItem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbxItem.Name = "pbxItem"
        Me.pbxItem.Size = New System.Drawing.Size(223, 194)
        Me.pbxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxItem.TabIndex = 117
        Me.pbxItem.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(949, 306)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(88, 20)
        Me.CheckBox1.TabIndex = 118
        Me.CheckBox1.Text = "Topping 8"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'chkModifier3
        '
        Me.chkModifier3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkModifier3.AutoSize = True
        Me.chkModifier3.Location = New System.Drawing.Point(824, 279)
        Me.chkModifier3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkModifier3.Name = "chkModifier3"
        Me.chkModifier3.Size = New System.Drawing.Size(88, 20)
        Me.chkModifier3.TabIndex = 119
        Me.chkModifier3.Text = "Topping 3"
        Me.chkModifier3.UseVisualStyleBackColor = True
        '
        'chkModifier4
        '
        Me.chkModifier4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkModifier4.AutoSize = True
        Me.chkModifier4.Location = New System.Drawing.Point(824, 307)
        Me.chkModifier4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkModifier4.Name = "chkModifier4"
        Me.chkModifier4.Size = New System.Drawing.Size(88, 20)
        Me.chkModifier4.TabIndex = 120
        Me.chkModifier4.Text = "Topping 4"
        Me.chkModifier4.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(949, 250)
        Me.CheckBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(88, 20)
        Me.CheckBox4.TabIndex = 123
        Me.CheckBox4.Text = "Topping 6"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(949, 222)
        Me.CheckBox7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(88, 20)
        Me.CheckBox7.TabIndex = 126
        Me.CheckBox7.Text = "Topping 5"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'chkModifier2
        '
        Me.chkModifier2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkModifier2.AutoSize = True
        Me.chkModifier2.Location = New System.Drawing.Point(824, 251)
        Me.chkModifier2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkModifier2.Name = "chkModifier2"
        Me.chkModifier2.Size = New System.Drawing.Size(88, 20)
        Me.chkModifier2.TabIndex = 129
        Me.chkModifier2.Text = "Topping 2"
        Me.chkModifier2.UseVisualStyleBackColor = True
        '
        'chkModifier1
        '
        Me.chkModifier1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkModifier1.AutoSize = True
        Me.chkModifier1.Location = New System.Drawing.Point(824, 222)
        Me.chkModifier1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkModifier1.Name = "chkModifier1"
        Me.chkModifier1.Size = New System.Drawing.Size(88, 20)
        Me.chkModifier1.TabIndex = 128
        Me.chkModifier1.Text = "Topping 1"
        Me.chkModifier1.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Location = New System.Drawing.Point(950, 278)
        Me.CheckBox12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(88, 20)
        Me.CheckBox12.TabIndex = 127
        Me.CheckBox12.Text = "Topping 7"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'pbxDecrement
        '
        Me.pbxDecrement.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxDecrement.Image = CType(resources.GetObject("pbxDecrement.Image"), System.Drawing.Image)
        Me.pbxDecrement.Location = New System.Drawing.Point(137, 238)
        Me.pbxDecrement.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbxDecrement.Name = "pbxDecrement"
        Me.pbxDecrement.Size = New System.Drawing.Size(133, 62)
        Me.pbxDecrement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxDecrement.TabIndex = 130
        Me.pbxDecrement.TabStop = False
        '
        'pbxIncrement
        '
        Me.pbxIncrement.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxIncrement.Image = CType(resources.GetObject("pbxIncrement.Image"), System.Drawing.Image)
        Me.pbxIncrement.Location = New System.Drawing.Point(563, 238)
        Me.pbxIncrement.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbxIncrement.Name = "pbxIncrement"
        Me.pbxIncrement.Size = New System.Drawing.Size(133, 62)
        Me.pbxIncrement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxIncrement.TabIndex = 131
        Me.pbxIncrement.TabStop = False
        '
        'lblItemQuantity
        '
        Me.lblItemQuantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblItemQuantity.AutoSize = True
        Me.lblItemQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemQuantity.Location = New System.Drawing.Point(300, 152)
        Me.lblItemQuantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblItemQuantity.Name = "lblItemQuantity"
        Me.lblItemQuantity.Size = New System.Drawing.Size(114, 16)
        Me.lblItemQuantity.TabIndex = 132
        Me.lblItemQuantity.Text = "Burger Quantity"
        '
        'lblItemDescription
        '
        Me.lblItemDescription.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblItemDescription.AutoSize = True
        Me.lblItemDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemDescription.Location = New System.Drawing.Point(191, 374)
        Me.lblItemDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblItemDescription.Name = "lblItemDescription"
        Me.lblItemDescription.Size = New System.Drawing.Size(306, 16)
        Me.lblItemDescription.TabIndex = 133
        Me.lblItemDescription.Text = "Burger image above pulled from food menu"
        '
        'frmAddModifiers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1461, 640)
        Me.Controls.Add(Me.lblItemDescription)
        Me.Controls.Add(Me.lblItemQuantity)
        Me.Controls.Add(Me.pbxIncrement)
        Me.Controls.Add(Me.pbxDecrement)
        Me.Controls.Add(Me.chkModifier2)
        Me.Controls.Add(Me.btnAdminLogin)
        Me.Controls.Add(Me.chkModifier1)
        Me.Controls.Add(Me.CheckBox12)
        Me.Controls.Add(Me.CheckBox7)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.chkModifier4)
        Me.Controls.Add(Me.chkModifier3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.pbxItem)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmAddModifiers"
        Me.Text = "frmAddModifiers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.pbxItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDecrement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxIncrement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdminLogin As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnSauces As Button
    Friend WithEvents btnCheeses As Button
    Friend WithEvents btnToppings As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents pbxItem As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents chkModifier3 As CheckBox
    Friend WithEvents chkModifier4 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents chkModifier2 As CheckBox
    Friend WithEvents chkModifier1 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents pbxDecrement As PictureBox
    Friend WithEvents pbxIncrement As PictureBox
    Friend WithEvents lblItemQuantity As Label
    Friend WithEvents lblItemDescription As Label
End Class
