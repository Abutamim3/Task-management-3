Partial Class Form1
    Inherits System.Windows.Forms.Form

    ' تعريف العناصر كـ WithEvents لتجنب الخطأ
    Private WithEvents lblTitle As Label
    Private WithEvents txtTitle As TextBox
    Private WithEvents lblDescription As Label
    Private WithEvents txtDescription As TextBox
    Private WithEvents lblDueDate As Label
    Private WithEvents dtpDueDate As DateTimePicker
    Private WithEvents btnAdd As Button
    Private WithEvents btnDelete As Button
    Private WithEvents dgvTasks As DataGridView

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvTasks = New System.Windows.Forms.DataGridView()

        CType(Me.dgvTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' lblTitle
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 15)
        Me.lblTitle.Text = "عنوان المهمة"

        ' txtTitle
        Me.txtTitle.Location = New System.Drawing.Point(100, 12)
        Me.txtTitle.Size = New System.Drawing.Size(200, 20)

        ' lblDescription
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(12, 45)
        Me.lblDescription.Text = "الوصف"

        ' txtDescription
        Me.txtDescription.Location = New System.Drawing.Point(100, 42)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Size = New System.Drawing.Size(200, 60)

        ' lblDueDate
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Location = New System.Drawing.Point(12, 115)
        Me.lblDueDate.Text = "تاريخ الاستحقاق"

        ' dtpDueDate
        Me.dtpDueDate.Location = New System.Drawing.Point(100, 110)
        Me.dtpDueDate.Size = New System.Drawing.Size(200, 20)

        ' btnAdd
        Me.btnAdd.Location = New System.Drawing.Point(100, 140)
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.Text = "إضافة"
        Me.btnAdd.UseVisualStyleBackColor = True

        ' btnDelete
        Me.btnDelete.Location = New System.Drawing.Point(225, 140)
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True

        ' dgvTasks
        Me.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTasks.Location = New System.Drawing.Point(12, 180)
        Me.dgvTasks.Size = New System.Drawing.Size(360, 150)

        ' Form1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 341)
        Me.Controls.Add(Me.dgvTasks)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dtpDueDate)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "إدارة المهام"

        CType(Me.dgvTasks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
End Class
