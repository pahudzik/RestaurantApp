<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
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
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.btnAssistance = New System.Windows.Forms.Button()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.btnAdjustPrice = New System.Windows.Forms.Button()
        Me.btnRemoveItems = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOrder
        '
        Me.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOrder.Location = New System.Drawing.Point(115, 258)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(243, 96)
        Me.btnOrder.TabIndex = 0
        Me.btnOrder.Text = "Place An Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(105, 67)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(670, 55)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Welcome to DarkSide Burgers"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.Location = New System.Drawing.Point(253, 134)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(368, 24)
        Me.lblSubtitle.TabIndex = 3
        Me.lblSubtitle.Text = "This is a Touch-Screen Self-Order System."
        '
        'btnAssistance
        '
        Me.btnAssistance.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAssistance.Location = New System.Drawing.Point(519, 258)
        Me.btnAssistance.Name = "btnAssistance"
        Me.btnAssistance.Size = New System.Drawing.Size(243, 96)
        Me.btnAssistance.TabIndex = 1
        Me.btnAssistance.Text = "Assistance Needed? / Call Attendent"
        Me.btnAssistance.UseVisualStyleBackColor = True
        '
        'dtpTime
        '
        Me.dtpTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTime.Location = New System.Drawing.Point(782, 427)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.Size = New System.Drawing.Size(154, 29)
        Me.dtpTime.TabIndex = 5
        '
        'dtpDate
        '
        Me.dtpDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(782, 471)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(154, 29)
        Me.dtpDate.TabIndex = 6
        '
        'btnAdjustPrice
        '
        Me.btnAdjustPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdjustPrice.Location = New System.Drawing.Point(782, 12)
        Me.btnAdjustPrice.Name = "btnAdjustPrice"
        Me.btnAdjustPrice.Size = New System.Drawing.Size(154, 23)
        Me.btnAdjustPrice.TabIndex = 129
        Me.btnAdjustPrice.Text = "AdjustPrice"
        Me.btnAdjustPrice.UseVisualStyleBackColor = True
        Me.btnAdjustPrice.Visible = False
        '
        'btnRemoveItems
        '
        Me.btnRemoveItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveItems.Location = New System.Drawing.Point(782, 56)
        Me.btnRemoveItems.Name = "btnRemoveItems"
        Me.btnRemoveItems.Size = New System.Drawing.Size(154, 23)
        Me.btnRemoveItems.TabIndex = 130
        Me.btnRemoveItems.TabStop = False
        Me.btnRemoveItems.Text = "Remove Items"
        Me.btnRemoveItems.UseVisualStyleBackColor = True
        Me.btnRemoveItems.Visible = False
        '
        'frmMainMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(948, 512)
        Me.Controls.Add(Me.btnRemoveItems)
        Me.Controls.Add(Me.btnAdjustPrice)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.dtpTime)
        Me.Controls.Add(Me.btnAssistance)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnOrder)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMainMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOrder As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents btnAssistance As Button
    Friend WithEvents dtpTime As DateTimePicker
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents btnAdjustPrice As Button
    Friend WithEvents btnRemoveItems As Button
End Class
