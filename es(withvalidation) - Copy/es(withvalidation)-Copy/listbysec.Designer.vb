<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listbysec
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tbx_s_sec = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbx_s_yr = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbx_s_course = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_back = New System.Windows.Forms.Label()
        Me.dgv_sec = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_sec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(469, 116)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 23)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "Go"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tbx_s_sec
        '
        Me.tbx_s_sec.BackColor = System.Drawing.SystemColors.Control
        Me.tbx_s_sec.Location = New System.Drawing.Point(224, 118)
        Me.tbx_s_sec.Name = "tbx_s_sec"
        Me.tbx_s_sec.Size = New System.Drawing.Size(43, 20)
        Me.tbx_s_sec.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(159, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 17)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Section:"
        '
        'cbx_s_yr
        '
        Me.cbx_s_yr.BackColor = System.Drawing.SystemColors.Control
        Me.cbx_s_yr.ForeColor = System.Drawing.SystemColors.Info
        Me.cbx_s_yr.FormattingEnabled = True
        Me.cbx_s_yr.Items.AddRange(New Object() {"1st", "2nd", "3rd", "4th", "5th"})
        Me.cbx_s_yr.Location = New System.Drawing.Point(70, 117)
        Me.cbx_s_yr.Name = "cbx_s_yr"
        Me.cbx_s_yr.Size = New System.Drawing.Size(83, 21)
        Me.cbx_s_yr.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 17)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Year:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Course:"
        '
        'cbx_s_course
        '
        Me.cbx_s_course.AllowDrop = True
        Me.cbx_s_course.AutoCompleteCustomSource.AddRange(New String() {"Bachelors of Science in Accountancy", "Bachelors of Science in Applied Mathematics", "Bachelors of Science in Architecture", "Bachelors of Science in Banking and Finance", "Bachelors of Science in Civil Engineering", "Bachelors of Science in Computer Science", "Bachelors of Science in Electronics Communications Engineering", "Bachelors of Science in Electronics Engineering", "Bachelors of Science in Entrepreneurship", "Bachelors of Science in Hotel Restaurant Management", "Bachelors of Science in Human Resource Development Management", "Bachelors of Science in Information Technology", "Bachelors of Science in Marketing Management", "Bachelors of Science in Mass Communication", "Bachelors of Science in Mechanical Engineering", "Bachelors of Science in Office Administration", "Bachelors of Science in Political Science", "Bachelors of Science in Psychology", "Bachelors of Science in Secondary Education", "Diploma in Information Communication Technology", "Diploma in Mechanical Engineering Technology", "Diploma in Office Management Technology"})
        Me.cbx_s_course.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbx_s_course.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_s_course.BackColor = System.Drawing.SystemColors.Control
        Me.cbx_s_course.ForeColor = System.Drawing.SystemColors.Info
        Me.cbx_s_course.FormattingEnabled = True
        Me.cbx_s_course.Items.AddRange(New Object() {"Bachelors of Science in Accountancy", "Bachelors of Science in Applied Mathematics", "Bachelors of Science in Architecture", "Bachelors of Science in Banking and Finance", "Bachelors of Science in Civil Engineering", "Bachelors of Science in Computer Science", "Bachelors of Science in Electronics Communications Engineering", "Bachelors of Science in Electronics Engineering", "Bachelors of Science in Entrepreneurship", "Bachelors of Science in Hotel Restaurant Management", "Bachelors of Science in Human Resource Development Management", "Bachelors of Science in Information Technology", "Bachelors of Science in Marketing Management", "Bachelors of Science in Mass Communication", "Bachelors of Science in Mechanical Engineering", "Bachelors of Science in Office Administration", "Bachelors of Science in Political Science", "Bachelors of Science in Psychology", "Bachelors of Science in Secondary Education", "Diploma in Information Communication Technology", "Diploma in Mechanical Engineering Technology", "Diploma in Office Management Technology"})
        Me.cbx_s_course.Location = New System.Drawing.Point(31, 90)
        Me.cbx_s_course.Name = "cbx_s_course"
        Me.cbx_s_course.Size = New System.Drawing.Size(482, 21)
        Me.cbx_s_course.Sorted = True
        Me.cbx_s_course.TabIndex = 47
        Me.cbx_s_course.Text = "--Select a Course--"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 17)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Search by Section:"
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.WindowText
        Me.LineShape2.BorderWidth = 3
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.SelectionColor = System.Drawing.SystemColors.WindowText
        Me.LineShape2.X1 = 18
        Me.LineShape2.X2 = 512
        Me.LineShape2.Y1 = 20
        Me.LineShape2.Y2 = 20
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.LineShape3, Me.LineShape1, Me.RectangleShape1, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(756, 439)
        Me.ShapeContainer1.TabIndex = 55
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.Black
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.Location = New System.Drawing.Point(456, 327)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(58, 23)
        '
        'LineShape3
        '
        Me.LineShape3.BorderWidth = 3
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 20
        Me.LineShape3.X2 = 514
        Me.LineShape3.Y1 = 328
        Me.LineShape3.Y2 = 328
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 20
        Me.LineShape1.X2 = 514
        Me.LineShape1.Y1 = 148
        Me.LineShape1.Y2 = 148
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.Black
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.Location = New System.Drawing.Point(18, 20)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(112, 23)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Info
        Me.Label2.Location = New System.Drawing.Point(27, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Student's List"
        '
        'lbl_back
        '
        Me.lbl_back.AutoSize = True
        Me.lbl_back.BackColor = System.Drawing.Color.Black
        Me.lbl_back.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_back.ForeColor = System.Drawing.SystemColors.Info
        Me.lbl_back.Location = New System.Drawing.Point(465, 328)
        Me.lbl_back.Name = "lbl_back"
        Me.lbl_back.Size = New System.Drawing.Size(46, 20)
        Me.lbl_back.TabIndex = 57
        Me.lbl_back.Text = "Back"
        '
        'dgv_sec
        '
        Me.dgv_sec.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_sec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_sec.Location = New System.Drawing.Point(27, 163)
        Me.dgv_sec.Name = "dgv_sec"
        Me.dgv_sec.Size = New System.Drawing.Size(484, 150)
        Me.dgv_sec.TabIndex = 58
        '
        'listbysec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(756, 439)
        Me.Controls.Add(Me.dgv_sec)
        Me.Controls.Add(Me.lbl_back)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tbx_s_sec)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbx_s_yr)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbx_s_course)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "listbysec"
        Me.Text = "Form2"
        CType(Me.dgv_sec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tbx_s_sec As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbx_s_yr As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbx_s_course As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lbl_back As System.Windows.Forms.Label
    Friend WithEvents dgv_sec As System.Windows.Forms.DataGridView
End Class
