﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Std10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Std10))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.StdXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STUDENTDataSet15 = New Micro_Project.STUDENTDataSet15()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GRNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ROLLNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STUDENTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOTHERNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FATHERNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SURNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STANDARDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RELIGIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHONENODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ATTENDANCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Std_XTableAdapter = New Micro_Project.STUDENTDataSet15TableAdapters.std_XTableAdapter()
        CType(Me.StdXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENTDataSet15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Algerian", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(527, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(931, 45)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Details of students studying in standard X."
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StdXBindingSource, "ATTENDANCE", True))
        Me.TextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(224, 837)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(117, 35)
        Me.TextBox13.TabIndex = 77
        '
        'StdXBindingSource
        '
        Me.StdXBindingSource.DataMember = "std X"
        Me.StdXBindingSource.DataSource = Me.STUDENTDataSet15
        '
        'STUDENTDataSet15
        '
        Me.STUDENTDataSet15.DataSetName = "STUDENTDataSet15"
        Me.STUDENTDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StdXBindingSource, "PHONE NO", True))
        Me.TextBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(224, 770)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(154, 35)
        Me.TextBox14.TabIndex = 76
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TextBox13)
        Me.GroupBox1.Controls.Add(Me.TextBox14)
        Me.GroupBox1.Controls.Add(Me.TextBox15)
        Me.GroupBox1.Controls.Add(Me.TextBox16)
        Me.GroupBox1.Controls.Add(Me.TextBox17)
        Me.GroupBox1.Controls.Add(Me.TextBox18)
        Me.GroupBox1.Controls.Add(Me.TextBox19)
        Me.GroupBox1.Controls.Add(Me.TextBox20)
        Me.GroupBox1.Controls.Add(Me.TextBox21)
        Me.GroupBox1.Controls.Add(Me.TextBox22)
        Me.GroupBox1.Controls.Add(Me.TextBox23)
        Me.GroupBox1.Controls.Add(Me.TextBox24)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Aqua
        Me.GroupBox1.Location = New System.Drawing.Point(938, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(807, 918)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details..."
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StdXBindingSource, "RELIGION", True))
        Me.TextBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(224, 696)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(117, 35)
        Me.TextBox15.TabIndex = 75
        '
        'TextBox16
        '
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StdXBindingSource, "Gender", True))
        Me.TextBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(225, 634)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(117, 35)
        Me.TextBox16.TabIndex = 74
        '
        'TextBox17
        '
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StdXBindingSource, "ADDRESS", True))
        Me.TextBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox17.Location = New System.Drawing.Point(224, 544)
        Me.TextBox17.Multiline = True
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(539, 63)
        Me.TextBox17.TabIndex = 73
        Me.TextBox17.Text = " "
        '
        'TextBox18
        '
        Me.TextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StdXBindingSource, "STANDARD", True))
        Me.TextBox18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox18.Location = New System.Drawing.Point(225, 491)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(117, 35)
        Me.TextBox18.TabIndex = 72
        '
        'TextBox19
        '
        Me.TextBox19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StdXBindingSource, "SURNAME", True))
        Me.TextBox19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox19.Location = New System.Drawing.Point(225, 420)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(117, 35)
        Me.TextBox19.TabIndex = 71
        '
        'TextBox20
        '
        Me.TextBox20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StdXBindingSource, "MOTHER NAME", True))
        Me.TextBox20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox20.Location = New System.Drawing.Point(220, 346)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(117, 35)
        Me.TextBox20.TabIndex = 70
        '
        'TextBox21
        '
        Me.TextBox21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StdXBindingSource, "FATHER NAME", True))
        Me.TextBox21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox21.Location = New System.Drawing.Point(220, 274)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(117, 35)
        Me.TextBox21.TabIndex = 69
        '
        'TextBox22
        '
        Me.TextBox22.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StdXBindingSource, "STUDENT NAME", True))
        Me.TextBox22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox22.Location = New System.Drawing.Point(220, 199)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(117, 35)
        Me.TextBox22.TabIndex = 68
        '
        'TextBox23
        '
        Me.TextBox23.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StdXBindingSource, "ROLL NO", True))
        Me.TextBox23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox23.Location = New System.Drawing.Point(220, 126)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(117, 35)
        Me.TextBox23.TabIndex = 67
        '
        'TextBox24
        '
        Me.TextBox24.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StdXBindingSource, "GR NO", True))
        Me.TextBox24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox24.Location = New System.Drawing.Point(220, 53)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(117, 35)
        Me.TextBox24.TabIndex = 66
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Aqua
        Me.Label13.Location = New System.Drawing.Point(36, 840)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 28)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "Attendance" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Aqua
        Me.Label14.Location = New System.Drawing.Point(18, 777)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(166, 28)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "Phone Number"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Aqua
        Me.Label15.Location = New System.Drawing.Point(40, 703)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 28)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Religion"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Aqua
        Me.Label16.Location = New System.Drawing.Point(38, 639)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 28)
        Me.Label16.TabIndex = 62
        Me.Label16.Text = "Gender"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Aqua
        Me.Label17.Location = New System.Drawing.Point(42, 566)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 28)
        Me.Label17.TabIndex = 61
        Me.Label17.Text = "Address"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Aqua
        Me.Label18.Location = New System.Drawing.Point(20, 349)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(169, 28)
        Me.Label18.TabIndex = 60
        Me.Label18.Text = "Mother's Name"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Aqua
        Me.Label19.Location = New System.Drawing.Point(27, 281)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(160, 28)
        Me.Label19.TabIndex = 59
        Me.Label19.Text = "Father's Name"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Aqua
        Me.Label20.Location = New System.Drawing.Point(42, 494)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(105, 28)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "Standard"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Aqua
        Me.Label21.Location = New System.Drawing.Point(31, 206)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(172, 28)
        Me.Label21.TabIndex = 57
        Me.Label21.Text = "Student's Name"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Aqua
        Me.Label22.Location = New System.Drawing.Point(43, 129)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(110, 28)
        Me.Label22.TabIndex = 56
        Me.Label22.Text = "ROLL NO."
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Aqua
        Me.Label23.Location = New System.Drawing.Point(46, 53)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(83, 28)
        Me.Label23.TabIndex = 55
        Me.Label23.Text = "GR NO."
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Aqua
        Me.Label24.Location = New System.Drawing.Point(42, 417)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(104, 28)
        Me.Label24.TabIndex = 54
        Me.Label24.Text = "Surname"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(702, 766)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(130, 57)
        Me.Button5.TabIndex = 61
        Me.Button5.Text = "DELETE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(702, 397)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(130, 57)
        Me.Button4.TabIndex = 60
        Me.Button4.Text = "PREVIOUS"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(702, 523)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 57)
        Me.Button3.TabIndex = 59
        Me.Button3.Text = "ADD NEW"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(702, 643)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 57)
        Me.Button2.TabIndex = 58
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(702, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 57)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "NEXT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GRNODataGridViewTextBoxColumn, Me.ROLLNODataGridViewTextBoxColumn, Me.STUDENTNAMEDataGridViewTextBoxColumn, Me.MOTHERNAMEDataGridViewTextBoxColumn, Me.FATHERNAMEDataGridViewTextBoxColumn, Me.SURNAMEDataGridViewTextBoxColumn, Me.STANDARDDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.RELIGIONDataGridViewTextBoxColumn, Me.PHONENODataGridViewTextBoxColumn, Me.ATTENDANCEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StdXBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(47, 89)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(568, 903)
        Me.DataGridView1.TabIndex = 56
        '
        'GRNODataGridViewTextBoxColumn
        '
        Me.GRNODataGridViewTextBoxColumn.DataPropertyName = "GR NO"
        Me.GRNODataGridViewTextBoxColumn.HeaderText = "GR NO"
        Me.GRNODataGridViewTextBoxColumn.Name = "GRNODataGridViewTextBoxColumn"
        '
        'ROLLNODataGridViewTextBoxColumn
        '
        Me.ROLLNODataGridViewTextBoxColumn.DataPropertyName = "ROLL NO"
        Me.ROLLNODataGridViewTextBoxColumn.HeaderText = "ROLL NO"
        Me.ROLLNODataGridViewTextBoxColumn.Name = "ROLLNODataGridViewTextBoxColumn"
        '
        'STUDENTNAMEDataGridViewTextBoxColumn
        '
        Me.STUDENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "STUDENT NAME"
        Me.STUDENTNAMEDataGridViewTextBoxColumn.HeaderText = "STUDENT NAME"
        Me.STUDENTNAMEDataGridViewTextBoxColumn.Name = "STUDENTNAMEDataGridViewTextBoxColumn"
        '
        'MOTHERNAMEDataGridViewTextBoxColumn
        '
        Me.MOTHERNAMEDataGridViewTextBoxColumn.DataPropertyName = "MOTHER NAME"
        Me.MOTHERNAMEDataGridViewTextBoxColumn.HeaderText = "MOTHER NAME"
        Me.MOTHERNAMEDataGridViewTextBoxColumn.Name = "MOTHERNAMEDataGridViewTextBoxColumn"
        '
        'FATHERNAMEDataGridViewTextBoxColumn
        '
        Me.FATHERNAMEDataGridViewTextBoxColumn.DataPropertyName = "FATHER NAME"
        Me.FATHERNAMEDataGridViewTextBoxColumn.HeaderText = "FATHER NAME"
        Me.FATHERNAMEDataGridViewTextBoxColumn.Name = "FATHERNAMEDataGridViewTextBoxColumn"
        '
        'SURNAMEDataGridViewTextBoxColumn
        '
        Me.SURNAMEDataGridViewTextBoxColumn.DataPropertyName = "SURNAME"
        Me.SURNAMEDataGridViewTextBoxColumn.HeaderText = "SURNAME"
        Me.SURNAMEDataGridViewTextBoxColumn.Name = "SURNAMEDataGridViewTextBoxColumn"
        '
        'STANDARDDataGridViewTextBoxColumn
        '
        Me.STANDARDDataGridViewTextBoxColumn.DataPropertyName = "STANDARD"
        Me.STANDARDDataGridViewTextBoxColumn.HeaderText = "STANDARD"
        Me.STANDARDDataGridViewTextBoxColumn.Name = "STANDARDDataGridViewTextBoxColumn"
        '
        'ADDRESSDataGridViewTextBoxColumn
        '
        Me.ADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.Name = "ADDRESSDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'RELIGIONDataGridViewTextBoxColumn
        '
        Me.RELIGIONDataGridViewTextBoxColumn.DataPropertyName = "RELIGION"
        Me.RELIGIONDataGridViewTextBoxColumn.HeaderText = "RELIGION"
        Me.RELIGIONDataGridViewTextBoxColumn.Name = "RELIGIONDataGridViewTextBoxColumn"
        '
        'PHONENODataGridViewTextBoxColumn
        '
        Me.PHONENODataGridViewTextBoxColumn.DataPropertyName = "PHONE NO"
        Me.PHONENODataGridViewTextBoxColumn.HeaderText = "PHONE NO"
        Me.PHONENODataGridViewTextBoxColumn.Name = "PHONENODataGridViewTextBoxColumn"
        '
        'ATTENDANCEDataGridViewTextBoxColumn
        '
        Me.ATTENDANCEDataGridViewTextBoxColumn.DataPropertyName = "ATTENDANCE"
        Me.ATTENDANCEDataGridViewTextBoxColumn.HeaderText = "ATTENDANCE"
        Me.ATTENDANCEDataGridViewTextBoxColumn.Name = "ATTENDANCEDataGridViewTextBoxColumn"
        '
        'Std_XTableAdapter
        '
        Me.Std_XTableAdapter.ClearBeforeFill = True
        '
        'Std10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1802, 1036)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Std10"
        Me.Text = "Std10"
        CType(Me.StdXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENTDataSet15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents STUDENTDataSet15 As Micro_Project.STUDENTDataSet15
    Friend WithEvents StdXBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Std_XTableAdapter As Micro_Project.STUDENTDataSet15TableAdapters.std_XTableAdapter
    Friend WithEvents GRNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ROLLNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STUDENTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MOTHERNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FATHERNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SURNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STANDARDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RELIGIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PHONENODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ATTENDANCEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class