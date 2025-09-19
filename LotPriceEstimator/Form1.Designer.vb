<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.ComboBeverage = New System.Windows.Forms.ComboBox()
        Me.NumberQuantity = New System.Windows.Forms.NumericUpDown()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblFinalTotal = New System.Windows.Forms.Label()
        Me.checkDiscount = New System.Windows.Forms.CheckBox()
        CType(Me.NumberQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(147, 109)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 21)
        Me.txtName.TabIndex = 0
        Me.txtName.Text = "Customer Name"
        '
        'ComboBeverage
        '
        Me.ComboBeverage.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBeverage.FormattingEnabled = True
        Me.ComboBeverage.Location = New System.Drawing.Point(147, 135)
        Me.ComboBeverage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBeverage.Name = "ComboBeverage"
        Me.ComboBeverage.Size = New System.Drawing.Size(100, 21)
        Me.ComboBeverage.TabIndex = 1
        Me.ComboBeverage.Text = "Select Coffee"
        '
        'NumberQuantity
        '
        Me.NumberQuantity.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberQuantity.Location = New System.Drawing.Point(275, 109)
        Me.NumberQuantity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NumberQuantity.Name = "NumberQuantity"
        Me.NumberQuantity.Size = New System.Drawing.Size(133, 21)
        Me.NumberQuantity.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(275, 158)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(135, 44)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Place Order"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(424, 121)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(47, 13)
        Me.lblSubtotal.TabIndex = 4
        Me.lblSubtotal.Text = "Subtotal"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblDiscount.Location = New System.Drawing.Point(424, 147)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(76, 13)
        Me.lblDiscount.TabIndex = 5
        Me.lblDiscount.Text = "Discount Total"
        '
        'lblFinalTotal
        '
        Me.lblFinalTotal.AutoSize = True
        Me.lblFinalTotal.Location = New System.Drawing.Point(424, 174)
        Me.lblFinalTotal.Name = "lblFinalTotal"
        Me.lblFinalTotal.Size = New System.Drawing.Size(56, 13)
        Me.lblFinalTotal.TabIndex = 6
        Me.lblFinalTotal.Text = "Final Total"
        '
        'checkDiscount
        '
        Me.checkDiscount.AutoSize = True
        Me.checkDiscount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkDiscount.Location = New System.Drawing.Point(275, 135)
        Me.checkDiscount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.checkDiscount.Name = "checkDiscount"
        Me.checkDiscount.Size = New System.Drawing.Size(135, 17)
        Me.checkDiscount.TabIndex = 7
        Me.checkDiscount.Text = "Apply Loyalty Discount"
        Me.checkDiscount.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LotPriceEstimator.My.Resources.Resources._32145
        Me.ClientSize = New System.Drawing.Size(610, 373)
        Me.Controls.Add(Me.checkDiscount)
        Me.Controls.Add(Me.lblFinalTotal)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.NumberQuantity)
        Me.Controls.Add(Me.ComboBeverage)
        Me.Controls.Add(Me.txtName)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NumberQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents ComboBeverage As ComboBox
    Friend WithEvents NumberQuantity As NumericUpDown
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblFinalTotal As Label
    Friend WithEvents checkDiscount As CheckBox
End Class
