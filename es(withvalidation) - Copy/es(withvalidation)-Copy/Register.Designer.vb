<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbx_mname = New System.Windows.Forms.TextBox()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lbl_telnum = New System.Windows.Forms.Label()
        Me.tbx_cnum = New System.Windows.Forms.TextBox()
        Me.lbl_eadd = New System.Windows.Forms.Label()
        Me.tbx_eadd = New System.Windows.Forms.TextBox()
        Me.lbl_guardian = New System.Windows.Forms.Label()
        Me.tbx_guard = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_studnum = New System.Windows.Forms.Label()
        Me.lbl_lname = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_fname = New System.Windows.Forms.Label()
        Me.lbl_mname = New System.Windows.Forms.Label()
        Me.tbx_lname = New System.Windows.Forms.TextBox()
        Me.tbx_fname = New System.Windows.Forms.TextBox()
        Me.lbl_year = New System.Windows.Forms.Label()
        Me.lbl_section = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbx_hnum = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbx_add = New System.Windows.Forms.TextBox()
        Me.tbx_city = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbx_zip = New System.Windows.Forms.TextBox()
        Me.tip_noempty = New System.Windows.Forms.ToolTip(Me.components)
        Me.tip_nonum = New System.Windows.Forms.ToolTip(Me.components)
        Me.tip_info = New System.Windows.Forms.ToolTip(Me.components)
        Me.Error1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.showage = New System.Windows.Forms.Label()
        Me.cbx_sec = New System.Windows.Forms.ComboBox()
        Me.cbx_adv = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbx_yr = New System.Windows.Forms.ComboBox()
        CType(Me.Error1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Students Information    "
        '
        'tbx_mname
        '
        Me.tbx_mname.Location = New System.Drawing.Point(582, 45)
        Me.tbx_mname.Name = "tbx_mname"
        Me.tbx_mname.Size = New System.Drawing.Size(138, 20)
        Me.tbx_mname.TabIndex = 8
        '
        'btn_submit
        '
        Me.btn_submit.Location = New System.Drawing.Point(669, 413)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(75, 23)
        Me.btn_submit.TabIndex = 16
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'cbGender
        '
        Me.cbGender.AllowDrop = True
        Me.cbGender.AutoCompleteCustomSource.AddRange(New String() {"Male", "Female"})
        Me.cbGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbGender.Location = New System.Drawing.Point(582, 73)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(129, 21)
        Me.cbGender.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Error1.SetError(Me.Label2, "Required")
        Me.Label2.Location = New System.Drawing.Point(494, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Gender:"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(756, 439)
        Me.ShapeContainer1.TabIndex = 30
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.Maroon
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape3.Location = New System.Drawing.Point(8, 225)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(734, 24)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.Maroon
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.Location = New System.Drawing.Point(7, 100)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(734, 24)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.Maroon
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Location = New System.Drawing.Point(7, 10)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(734, 24)
        '
        'lbl_telnum
        '
        Me.lbl_telnum.AutoSize = True
        Me.lbl_telnum.BackColor = System.Drawing.Color.Transparent
        Me.lbl_telnum.Location = New System.Drawing.Point(12, 266)
        Me.lbl_telnum.Name = "lbl_telnum"
        Me.lbl_telnum.Size = New System.Drawing.Size(39, 13)
        Me.lbl_telnum.TabIndex = 31
        Me.lbl_telnum.Text = "Call at:"
        '
        'tbx_cnum
        '
        Me.tbx_cnum.Location = New System.Drawing.Point(79, 285)
        Me.tbx_cnum.Name = "tbx_cnum"
        Me.tbx_cnum.Size = New System.Drawing.Size(129, 20)
        Me.tbx_cnum.TabIndex = 32
        '
        'lbl_eadd
        '
        Me.lbl_eadd.AutoSize = True
        Me.lbl_eadd.BackColor = System.Drawing.Color.Transparent
        Me.lbl_eadd.Location = New System.Drawing.Point(214, 288)
        Me.lbl_eadd.Name = "lbl_eadd"
        Me.lbl_eadd.Size = New System.Drawing.Size(35, 13)
        Me.lbl_eadd.TabIndex = 33
        Me.lbl_eadd.Text = "Email:"
        '
        'tbx_eadd
        '
        Me.tbx_eadd.Location = New System.Drawing.Point(280, 285)
        Me.tbx_eadd.Name = "tbx_eadd"
        Me.tbx_eadd.Size = New System.Drawing.Size(199, 20)
        Me.tbx_eadd.TabIndex = 34
        '
        'lbl_guardian
        '
        Me.lbl_guardian.AutoSize = True
        Me.lbl_guardian.BackColor = System.Drawing.Color.Transparent
        Me.Error1.SetError(Me.lbl_guardian, "Required")
        Me.lbl_guardian.Location = New System.Drawing.Point(214, 314)
        Me.lbl_guardian.Name = "lbl_guardian"
        Me.lbl_guardian.Size = New System.Drawing.Size(53, 13)
        Me.lbl_guardian.TabIndex = 35
        Me.lbl_guardian.Text = "Guardian:"
        '
        'tbx_guard
        '
        Me.tbx_guard.Location = New System.Drawing.Point(280, 314)
        Me.tbx_guard.Name = "tbx_guard"
        Me.tbx_guard.Size = New System.Drawing.Size(199, 20)
        Me.tbx_guard.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(484, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Academic Year:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Error1.SetError(Me.Label5, "Required")
        Me.Label5.Location = New System.Drawing.Point(12, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Address"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Back to Home"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_studnum
        '
        Me.lbl_studnum.AutoSize = True
        Me.lbl_studnum.BackColor = System.Drawing.Color.Transparent
        Me.lbl_studnum.Location = New System.Drawing.Point(12, 142)
        Me.lbl_studnum.Name = "lbl_studnum"
        Me.lbl_studnum.Size = New System.Drawing.Size(87, 13)
        Me.lbl_studnum.TabIndex = 1
        Me.lbl_studnum.Text = "Student Number:"
        '
        'lbl_lname
        '
        Me.lbl_lname.AutoSize = True
        Me.lbl_lname.BackColor = System.Drawing.Color.Transparent
        Me.Error1.SetError(Me.lbl_lname, "Required")
        Me.lbl_lname.Location = New System.Drawing.Point(12, 48)
        Me.lbl_lname.Name = "lbl_lname"
        Me.lbl_lname.Size = New System.Drawing.Size(61, 13)
        Me.lbl_lname.TabIndex = 2
        Me.lbl_lname.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 3
        '
        'lbl_fname
        '
        Me.lbl_fname.AutoSize = True
        Me.lbl_fname.BackColor = System.Drawing.Color.Transparent
        Me.Error1.SetError(Me.lbl_fname, "Required")
        Me.lbl_fname.Location = New System.Drawing.Point(268, 48)
        Me.lbl_fname.Name = "lbl_fname"
        Me.lbl_fname.Size = New System.Drawing.Size(60, 13)
        Me.lbl_fname.TabIndex = 4
        Me.lbl_fname.Text = "First Name:"
        '
        'lbl_mname
        '
        Me.lbl_mname.AutoSize = True
        Me.lbl_mname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mname.Location = New System.Drawing.Point(494, 48)
        Me.lbl_mname.Name = "lbl_mname"
        Me.lbl_mname.Size = New System.Drawing.Size(72, 13)
        Me.lbl_mname.TabIndex = 5
        Me.lbl_mname.Text = "Middle Name:"
        '
        'tbx_lname
        '
        Me.tbx_lname.Location = New System.Drawing.Point(79, 45)
        Me.tbx_lname.Name = "tbx_lname"
        Me.tbx_lname.Size = New System.Drawing.Size(129, 20)
        Me.tbx_lname.TabIndex = 6
        Me.tbx_lname.Text = " "
        '
        'tbx_fname
        '
        Me.tbx_fname.Location = New System.Drawing.Point(334, 45)
        Me.tbx_fname.Name = "tbx_fname"
        Me.tbx_fname.Size = New System.Drawing.Size(129, 20)
        Me.tbx_fname.TabIndex = 7
        '
        'lbl_year
        '
        Me.lbl_year.AutoSize = True
        Me.lbl_year.BackColor = System.Drawing.Color.Transparent
        Me.Error1.SetError(Me.lbl_year, "Required")
        Me.lbl_year.Location = New System.Drawing.Point(12, 167)
        Me.lbl_year.Name = "lbl_year"
        Me.lbl_year.Size = New System.Drawing.Size(39, 13)
        Me.lbl_year.TabIndex = 24
        Me.lbl_year.Text = "Grade:"
        '
        'lbl_section
        '
        Me.lbl_section.AutoSize = True
        Me.lbl_section.BackColor = System.Drawing.Color.Transparent
        Me.Error1.SetError(Me.lbl_section, "Required")
        Me.lbl_section.Location = New System.Drawing.Point(12, 196)
        Me.lbl_section.Name = "lbl_section"
        Me.lbl_section.Size = New System.Drawing.Size(46, 13)
        Me.lbl_section.TabIndex = 26
        Me.lbl_section.Text = "Section:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(12, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Age:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Maroon
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Info
        Me.Label6.Location = New System.Drawing.Point(9, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 20)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Academic Information"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Error1.SetError(Me.Label8, "Required")
        Me.Label8.Location = New System.Drawing.Point(268, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Adviser:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Maroon
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Info
        Me.Label9.Location = New System.Drawing.Point(8, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(174, 20)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Contact Details             "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(32, 288)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Mobile:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(32, 314)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Home:"
        '
        'tbx_hnum
        '
        Me.tbx_hnum.Location = New System.Drawing.Point(79, 312)
        Me.tbx_hnum.Name = "tbx_hnum"
        Me.tbx_hnum.Size = New System.Drawing.Size(129, 20)
        Me.tbx_hnum.TabIndex = 60
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(12, 380)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 13)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "City:"
        '
        'tbx_add
        '
        Me.tbx_add.Location = New System.Drawing.Point(79, 349)
        Me.tbx_add.Name = "tbx_add"
        Me.tbx_add.Size = New System.Drawing.Size(400, 20)
        Me.tbx_add.TabIndex = 62
        '
        'tbx_city
        '
        Me.tbx_city.Location = New System.Drawing.Point(79, 377)
        Me.tbx_city.Name = "tbx_city"
        Me.tbx_city.Size = New System.Drawing.Size(100, 20)
        Me.tbx_city.TabIndex = 63
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(214, 380)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "ZIP Code:"
        '
        'tbx_zip
        '
        Me.tbx_zip.Location = New System.Drawing.Point(280, 377)
        Me.tbx_zip.Name = "tbx_zip"
        Me.tbx_zip.Size = New System.Drawing.Size(106, 20)
        Me.tbx_zip.TabIndex = 65
        '
        'tip_noempty
        '
        Me.tip_noempty.AutoPopDelay = 5000
        Me.tip_noempty.InitialDelay = 500
        Me.tip_noempty.ReshowDelay = 10
        Me.tip_noempty.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        '
        'tip_nonum
        '
        Me.tip_nonum.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        '
        'tip_info
        '
        Me.tip_info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Error1
        '
        Me.Error1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.Error1.ContainerControl = Me
        Me.Error1.RightToLeft = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Error1.SetError(Me.Label15, "Required")
        Me.Label15.Location = New System.Drawing.Point(211, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 68
        Me.Label15.Text = "Birthday:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.DarkRed
        Me.Label14.Location = New System.Drawing.Point(57, 266)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(256, 13)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "*PROVIDE ATLEAST ONE(1) CONTACT NUMBER*"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(262, 72)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 67
        '
        'showage
        '
        Me.showage.AutoSize = True
        Me.showage.BackColor = System.Drawing.Color.Transparent
        Me.showage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.showage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showage.Location = New System.Drawing.Point(39, 76)
        Me.showage.Name = "showage"
        Me.showage.Size = New System.Drawing.Size(12, 15)
        Me.showage.TabIndex = 69
        Me.showage.Text = " "
        Me.showage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cbx_sec
        '
        Me.cbx_sec.FormattingEnabled = True
        Me.cbx_sec.Location = New System.Drawing.Point(64, 193)
        Me.cbx_sec.Name = "cbx_sec"
        Me.cbx_sec.Size = New System.Drawing.Size(141, 21)
        Me.cbx_sec.TabIndex = 71
        '
        'cbx_adv
        '
        Me.cbx_adv.FormattingEnabled = True
        Me.cbx_adv.Location = New System.Drawing.Point(319, 164)
        Me.cbx_adv.Name = "cbx_adv"
        Me.cbx_adv.Size = New System.Drawing.Size(160, 21)
        Me.cbx_adv.TabIndex = 72
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(105, 142)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(12, 15)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = " "
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cbx_yr
        '
        Me.cbx_yr.FormattingEnabled = True
        Me.cbx_yr.Location = New System.Drawing.Point(65, 164)
        Me.cbx_yr.Name = "cbx_yr"
        Me.cbx_yr.Size = New System.Drawing.Size(140, 21)
        Me.cbx_yr.TabIndex = 74
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(756, 439)
        Me.Controls.Add(Me.cbx_yr)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cbx_adv)
        Me.Controls.Add(Me.cbx_sec)
        Me.Controls.Add(Me.showage)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tbx_zip)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tbx_city)
        Me.Controls.Add(Me.tbx_add)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tbx_hnum)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbx_guard)
        Me.Controls.Add(Me.lbl_guardian)
        Me.Controls.Add(Me.tbx_eadd)
        Me.Controls.Add(Me.lbl_eadd)
        Me.Controls.Add(Me.tbx_cnum)
        Me.Controls.Add(Me.lbl_telnum)
        Me.Controls.Add(Me.lbl_section)
        Me.Controls.Add(Me.lbl_year)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbGender)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.tbx_mname)
        Me.Controls.Add(Me.tbx_fname)
        Me.Controls.Add(Me.tbx_lname)
        Me.Controls.Add(Me.lbl_mname)
        Me.Controls.Add(Me.lbl_fname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_lname)
        Me.Controls.Add(Me.lbl_studnum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Fill up the Form"
        CType(Me.Error1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbx_mname As System.Windows.Forms.TextBox
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents cbGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lbl_telnum As System.Windows.Forms.Label
    Friend WithEvents tbx_cnum As System.Windows.Forms.TextBox
    Friend WithEvents lbl_eadd As System.Windows.Forms.Label
    Friend WithEvents tbx_eadd As System.Windows.Forms.TextBox
    Friend WithEvents lbl_guardian As System.Windows.Forms.Label
    Friend WithEvents tbx_guard As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbl_studnum As System.Windows.Forms.Label
    Friend WithEvents lbl_lname As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_fname As System.Windows.Forms.Label
    Friend WithEvents lbl_mname As System.Windows.Forms.Label
    Friend WithEvents tbx_lname As System.Windows.Forms.TextBox
    Friend WithEvents tbx_fname As System.Windows.Forms.TextBox
    Friend WithEvents lbl_year As System.Windows.Forms.Label
    Friend WithEvents lbl_section As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbx_hnum As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbx_add As System.Windows.Forms.TextBox
    Friend WithEvents tbx_city As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbx_zip As System.Windows.Forms.TextBox
    Friend WithEvents tip_noempty As System.Windows.Forms.ToolTip
    Friend WithEvents tip_nonum As System.Windows.Forms.ToolTip
    Friend WithEvents tip_info As System.Windows.Forms.ToolTip
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Error1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents showage As System.Windows.Forms.Label
    Friend WithEvents cbx_sec As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbx_adv As System.Windows.Forms.ComboBox
    Friend WithEvents cbx_yr As System.Windows.Forms.ComboBox

End Class
