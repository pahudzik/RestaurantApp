<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAfternoonMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAfternoonMenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.btnFood = New System.Windows.Forms.Button()
        Me.btnDrinks = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblItem1Price = New System.Windows.Forms.Label()
        Me.btnAdminLogin = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.pbxItem1 = New System.Windows.Forms.PictureBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnAdjustPrice = New System.Windows.Forms.Button()
        Me.pbxItem4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pbxItem2 = New System.Windows.Forms.PictureBox()
        Me.lblItem4Price = New System.Windows.Forms.Label()
        Me.lblItem3Price = New System.Windows.Forms.Label()
        Me.lblItem2Price = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pbxItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.Controls.Add(Me.lblHeader)
        Me.Panel1.Controls.Add(Me.dtpDate)
        Me.Panel1.Controls.Add(Me.dtpTime)
        Me.Panel1.Controls.Add(Me.btnFood)
        Me.Panel1.Controls.Add(Me.btnDrinks)
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Location = New System.Drawing.Point(16, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1171, 59)
        Me.Panel1.TabIndex = 0
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
        'dtpDate
        '
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(508, 31)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(145, 20)
        Me.dtpDate.TabIndex = 7
        '
        'dtpTime
        '
        Me.dtpTime.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTime.Location = New System.Drawing.Point(508, 4)
        Me.dtpTime.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.Size = New System.Drawing.Size(145, 20)
        Me.dtpTime.TabIndex = 6
        '
        'btnFood
        '
        Me.btnFood.Location = New System.Drawing.Point(661, 4)
        Me.btnFood.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFood.Name = "btnFood"
        Me.btnFood.Size = New System.Drawing.Size(117, 52)
        Me.btnFood.TabIndex = 3
        Me.btnFood.Text = "Food"
        Me.btnFood.UseVisualStyleBackColor = True
        '
        'btnDrinks
        '
        Me.btnDrinks.Location = New System.Drawing.Point(787, 4)
        Me.btnDrinks.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDrinks.Name = "btnDrinks"
        Me.btnDrinks.Size = New System.Drawing.Size(117, 52)
        Me.btnDrinks.TabIndex = 2
        Me.btnDrinks.Text = "Drinks"
        Me.btnDrinks.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(912, 4)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(117, 52)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(1037, 4)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(117, 52)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblItem1Price
        '
        Me.lblItem1Price.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblItem1Price.AutoSize = True
        Me.lblItem1Price.Location = New System.Drawing.Point(272, 391)
        Me.lblItem1Price.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblItem1Price.Name = "lblItem1Price"
        Me.lblItem1Price.Size = New System.Drawing.Size(39, 16)
        Me.lblItem1Price.TabIndex = 68
        Me.lblItem1Price.Text = "Price"
        '
        'btnAdminLogin
        '
        Me.btnAdminLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdminLogin.Location = New System.Drawing.Point(1314, 11)
        Me.btnAdminLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdminLogin.Name = "btnAdminLogin"
        Me.btnAdminLogin.Size = New System.Drawing.Size(205, 28)
        Me.btnAdminLogin.TabIndex = 66
        Me.btnAdminLogin.Text = "Admin Logon"
        Me.btnAdminLogin.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.Location = New System.Drawing.Point(1267, 520)
        Me.btnOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(212, 95)
        Me.btnOrder.TabIndex = 65
        Me.btnOrder.Text = "Complete Entire Order and Send To Kitchen"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'pbxItem1
        '
        Me.pbxItem1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxItem1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxItem1.Image = CType(resources.GetObject("pbxItem1.Image"), System.Drawing.Image)
        Me.pbxItem1.InitialImage = CType(resources.GetObject("pbxItem1.InitialImage"), System.Drawing.Image)
        Me.pbxItem1.Location = New System.Drawing.Point(256, 277)
        Me.pbxItem1.Margin = New System.Windows.Forms.Padding(4)
        Me.pbxItem1.Name = "pbxItem1"
        Me.pbxItem1.Size = New System.Drawing.Size(152, 108)
        Me.pbxItem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxItem1.TabIndex = 60
        Me.pbxItem1.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(1263, 479)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(105, 24)
        Me.lblTotal.TabIndex = 107
        Me.lblTotal.Text = "Order Total"
        '
        'btnAdjustPrice
        '
        Me.btnAdjustPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdjustPrice.Location = New System.Drawing.Point(1368, 44)
        Me.btnAdjustPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdjustPrice.Name = "btnAdjustPrice"
        Me.btnAdjustPrice.Size = New System.Drawing.Size(100, 28)
        Me.btnAdjustPrice.TabIndex = 129
        Me.btnAdjustPrice.Text = "AdjustPrice"
        Me.btnAdjustPrice.UseVisualStyleBackColor = True
        Me.btnAdjustPrice.Visible = False
        '
        'pbxItem4
        '
        Me.pbxItem4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxItem4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxItem4.Image = CType(resources.GetObject("pbxItem4.Image"), System.Drawing.Image)
        Me.pbxItem4.InitialImage = CType(resources.GetObject("pbxItem4.InitialImage"), System.Drawing.Image)
        Me.pbxItem4.Location = New System.Drawing.Point(584, 448)
        Me.pbxItem4.Name = "pbxItem4"
        Me.pbxItem4.Size = New System.Drawing.Size(142, 108)
        Me.pbxItem4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxItem4.TabIndex = 139
        Me.pbxItem4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = CType(resources.GetObject("PictureBox3.InitialImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(266, 448)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(142, 108)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 138
        Me.PictureBox3.TabStop = False
        '
        'pbxItem2
        '
        Me.pbxItem2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxItem2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxItem2.Image = CType(resources.GetObject("pbxItem2.Image"), System.Drawing.Image)
        Me.pbxItem2.InitialImage = CType(resources.GetObject("pbxItem2.InitialImage"), System.Drawing.Image)
        Me.pbxItem2.Location = New System.Drawing.Point(584, 277)
        Me.pbxItem2.Name = "pbxItem2"
        Me.pbxItem2.Size = New System.Drawing.Size(142, 108)
        Me.pbxItem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxItem2.TabIndex = 137
        Me.pbxItem2.TabStop = False
        '
        'lblItem4Price
        '
        Me.lblItem4Price.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblItem4Price.AutoSize = True
        Me.lblItem4Price.Location = New System.Drawing.Point(594, 568)
        Me.lblItem4Price.Name = "lblItem4Price"
        Me.lblItem4Price.Size = New System.Drawing.Size(39, 16)
        Me.lblItem4Price.TabIndex = 136
        Me.lblItem4Price.Text = "Price"
        '
        'lblItem3Price
        '
        Me.lblItem3Price.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblItem3Price.AutoSize = True
        Me.lblItem3Price.Location = New System.Drawing.Point(272, 568)
        Me.lblItem3Price.Name = "lblItem3Price"
        Me.lblItem3Price.Size = New System.Drawing.Size(39, 16)
        Me.lblItem3Price.TabIndex = 135
        Me.lblItem3Price.Text = "Price"
        '
        'lblItem2Price
        '
        Me.lblItem2Price.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblItem2Price.AutoSize = True
        Me.lblItem2Price.Location = New System.Drawing.Point(594, 391)
        Me.lblItem2Price.Name = "lblItem2Price"
        Me.lblItem2Price.Size = New System.Drawing.Size(39, 16)
        Me.lblItem2Price.TabIndex = 134
        Me.lblItem2Price.Text = "Price"
        '
        'frmAfternoonMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1532, 811)
        Me.Controls.Add(Me.pbxItem4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.pbxItem2)
        Me.Controls.Add(Me.lblItem4Price)
        Me.Controls.Add(Me.lblItem3Price)
        Me.Controls.Add(Me.lblItem2Price)
        Me.Controls.Add(Me.btnAdjustPrice)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblItem1Price)
        Me.Controls.Add(Me.btnAdminLogin)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.pbxItem1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAfternoonMenu"
        Me.Text = "pbxItem3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbxItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnFood As Button
    Friend WithEvents btnDrinks As Button
    Private WithEvents dtpDate As DateTimePicker
    Private WithEvents dtpTime As DateTimePicker
    Friend WithEvents lblItem1Price As Label
    Friend WithEvents btnAdminLogin As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents pbxItem1 As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnAdjustPrice As Button
    Friend WithEvents pbxItem4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents pbxItem2 As PictureBox
    Friend WithEvents lblItem4Price As Label
    Friend WithEvents lblItem3Price As Label
    Friend WithEvents lblItem2Price As Label
End Class
