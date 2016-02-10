<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBreakfastMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBreakfastMenu))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnFood = New System.Windows.Forms.Button()
        Me.btnDrinks = New System.Windows.Forms.Button()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnAdminLogin = New System.Windows.Forms.Button()
        Me.lblItem4Price = New System.Windows.Forms.Label()
        Me.lblItem3Price = New System.Windows.Forms.Label()
        Me.lblItem2Price = New System.Windows.Forms.Label()
        Me.lblItem1Price = New System.Windows.Forms.Label()
        Me.pbxItem1 = New System.Windows.Forms.PictureBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnAdjustPrice = New System.Windows.Forms.Button()
        Me.pbxItem2 = New System.Windows.Forms.PictureBox()
        Me.pbxItem3 = New System.Windows.Forms.PictureBox()
        Me.pbxItem4 = New System.Windows.Forms.PictureBox()
        Me.pnlHeader.SuspendLayout()
        CType(Me.pbxItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Controls.Add(Me.btnFood)
        Me.pnlHeader.Controls.Add(Me.btnDrinks)
        Me.pnlHeader.Controls.Add(Me.dtpDate)
        Me.pnlHeader.Controls.Add(Me.dtpTime)
        Me.pnlHeader.Controls.Add(Me.btnCancel)
        Me.pnlHeader.Controls.Add(Me.btnHome)
        Me.pnlHeader.Location = New System.Drawing.Point(26, 33)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(857, 51)
        Me.pnlHeader.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(16, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(315, 23)
        Me.lblHeader.TabIndex = 8
        Me.lblHeader.Text = "Touch the Screen to Select Food/Drinks"
        '
        'btnFood
        '
        Me.btnFood.Location = New System.Drawing.Point(500, 2)
        Me.btnFood.Name = "btnFood"
        Me.btnFood.Size = New System.Drawing.Size(82, 41)
        Me.btnFood.TabIndex = 7
        Me.btnFood.Text = "Food"
        Me.btnFood.UseVisualStyleBackColor = True
        '
        'btnDrinks
        '
        Me.btnDrinks.Location = New System.Drawing.Point(589, 2)
        Me.btnDrinks.Name = "btnDrinks"
        Me.btnDrinks.Size = New System.Drawing.Size(82, 41)
        Me.btnDrinks.TabIndex = 6
        Me.btnDrinks.Text = "Drinks"
        Me.btnDrinks.UseVisualStyleBackColor = True
        '
        'dtpDate
        '
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(384, 24)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(110, 20)
        Me.dtpDate.TabIndex = 5
        '
        'dtpTime
        '
        Me.dtpTime.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTime.Location = New System.Drawing.Point(384, 3)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.Size = New System.Drawing.Size(110, 20)
        Me.dtpTime.TabIndex = 4
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(765, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(82, 41)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(677, 2)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(82, 41)
        Me.btnHome.TabIndex = 3
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.Location = New System.Drawing.Point(896, 518)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(147, 69)
        Me.btnOrder.TabIndex = 18
        Me.btnOrder.Text = "Complete Entire Order and Send To Kitchen"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnAdminLogin
        '
        Me.btnAdminLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdminLogin.Location = New System.Drawing.Point(889, 16)
        Me.btnAdminLogin.Name = "btnAdminLogin"
        Me.btnAdminLogin.Size = New System.Drawing.Size(154, 23)
        Me.btnAdminLogin.TabIndex = 19
        Me.btnAdminLogin.Text = "Admin Logon"
        Me.btnAdminLogin.UseVisualStyleBackColor = True
        '
        'lblItem4Price
        '
        Me.lblItem4Price.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblItem4Price.AutoSize = True
        Me.lblItem4Price.Location = New System.Drawing.Point(470, 462)
        Me.lblItem4Price.Name = "lblItem4Price"
        Me.lblItem4Price.Size = New System.Drawing.Size(39, 16)
        Me.lblItem4Price.TabIndex = 119
        Me.lblItem4Price.Text = "Price"
        '
        'lblItem3Price
        '
        Me.lblItem3Price.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblItem3Price.AutoSize = True
        Me.lblItem3Price.Location = New System.Drawing.Point(148, 462)
        Me.lblItem3Price.Name = "lblItem3Price"
        Me.lblItem3Price.Size = New System.Drawing.Size(39, 16)
        Me.lblItem3Price.TabIndex = 118
        Me.lblItem3Price.Text = "Price"
        '
        'lblItem2Price
        '
        Me.lblItem2Price.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblItem2Price.AutoSize = True
        Me.lblItem2Price.Location = New System.Drawing.Point(470, 285)
        Me.lblItem2Price.Name = "lblItem2Price"
        Me.lblItem2Price.Size = New System.Drawing.Size(39, 16)
        Me.lblItem2Price.TabIndex = 113
        Me.lblItem2Price.Text = "Price"
        '
        'lblItem1Price
        '
        Me.lblItem1Price.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblItem1Price.AutoSize = True
        Me.lblItem1Price.Location = New System.Drawing.Point(139, 285)
        Me.lblItem1Price.Name = "lblItem1Price"
        Me.lblItem1Price.Size = New System.Drawing.Size(82, 16)
        Me.lblItem1Price.TabIndex = 112
        Me.lblItem1Price.Text = "Price:   $2.57"
        '
        'pbxItem1
        '
        Me.pbxItem1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxItem1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxItem1.Image = CType(resources.GetObject("pbxItem1.Image"), System.Drawing.Image)
        Me.pbxItem1.InitialImage = CType(resources.GetObject("pbxItem1.InitialImage"), System.Drawing.Image)
        Me.pbxItem1.Location = New System.Drawing.Point(142, 171)
        Me.pbxItem1.Name = "pbxItem1"
        Me.pbxItem1.Size = New System.Drawing.Size(142, 108)
        Me.pbxItem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxItem1.TabIndex = 109
        Me.pbxItem1.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(892, 480)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(105, 24)
        Me.lblTotal.TabIndex = 127
        Me.lblTotal.Text = "Order Total"
        '
        'btnAdjustPrice
        '
        Me.btnAdjustPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdjustPrice.Location = New System.Drawing.Point(908, 45)
        Me.btnAdjustPrice.Name = "btnAdjustPrice"
        Me.btnAdjustPrice.Size = New System.Drawing.Size(117, 23)
        Me.btnAdjustPrice.TabIndex = 128
        Me.btnAdjustPrice.Text = "AdjustPrice"
        Me.btnAdjustPrice.UseVisualStyleBackColor = True
        Me.btnAdjustPrice.Visible = False
        '
        'pbxItem2
        '
        Me.pbxItem2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxItem2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxItem2.Image = CType(resources.GetObject("pbxItem2.Image"), System.Drawing.Image)
        Me.pbxItem2.InitialImage = CType(resources.GetObject("pbxItem2.InitialImage"), System.Drawing.Image)
        Me.pbxItem2.Location = New System.Drawing.Point(460, 171)
        Me.pbxItem2.Name = "pbxItem2"
        Me.pbxItem2.Size = New System.Drawing.Size(142, 108)
        Me.pbxItem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxItem2.TabIndex = 129
        Me.pbxItem2.TabStop = False
        '
        'pbxItem3
        '
        Me.pbxItem3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxItem3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxItem3.Image = CType(resources.GetObject("pbxItem3.Image"), System.Drawing.Image)
        Me.pbxItem3.InitialImage = CType(resources.GetObject("pbxItem3.InitialImage"), System.Drawing.Image)
        Me.pbxItem3.Location = New System.Drawing.Point(142, 342)
        Me.pbxItem3.Name = "pbxItem3"
        Me.pbxItem3.Size = New System.Drawing.Size(142, 108)
        Me.pbxItem3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxItem3.TabIndex = 130
        Me.pbxItem3.TabStop = False
        '
        'pbxItem4
        '
        Me.pbxItem4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxItem4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxItem4.Image = CType(resources.GetObject("pbxItem4.Image"), System.Drawing.Image)
        Me.pbxItem4.InitialImage = CType(resources.GetObject("pbxItem4.InitialImage"), System.Drawing.Image)
        Me.pbxItem4.Location = New System.Drawing.Point(460, 342)
        Me.pbxItem4.Name = "pbxItem4"
        Me.pbxItem4.Size = New System.Drawing.Size(142, 108)
        Me.pbxItem4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxItem4.TabIndex = 131
        Me.pbxItem4.TabStop = False
        '
        'frmBreakfastMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1080, 617)
        Me.Controls.Add(Me.pbxItem4)
        Me.Controls.Add(Me.pbxItem3)
        Me.Controls.Add(Me.pbxItem2)
        Me.Controls.Add(Me.btnAdjustPrice)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblItem4Price)
        Me.Controls.Add(Me.lblItem3Price)
        Me.Controls.Add(Me.lblItem2Price)
        Me.Controls.Add(Me.lblItem1Price)
        Me.Controls.Add(Me.pbxItem1)
        Me.Controls.Add(Me.btnAdminLogin)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBreakfastMenu"
        Me.Text = "frmBreakfastMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.pbxItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As Panel
    Private WithEvents dtpDate As DateTimePicker
    Private WithEvents dtpTime As DateTimePicker
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnFood As Button
    Friend WithEvents btnDrinks As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnAdminLogin As Button
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblItem4Price As Label
    Friend WithEvents lblItem3Price As Label
    Friend WithEvents lblItem2Price As Label
    Friend WithEvents lblItem1Price As Label
    Friend WithEvents pbxItem1 As PictureBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnAdjustPrice As Button
    Friend WithEvents pbxItem2 As PictureBox
    Friend WithEvents pbxItem3 As PictureBox
    Friend WithEvents pbxItem4 As PictureBox
End Class
