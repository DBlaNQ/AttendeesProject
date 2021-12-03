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
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.matchesLabel = New System.Windows.Forms.Label()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.delBtn = New System.Windows.Forms.Button()
        Me.fNameBox = New System.Windows.Forms.TextBox()
        Me.lNameBox = New System.Windows.Forms.TextBox()
        Me.mNumberBox = New System.Windows.Forms.TextBox()
        Me.cityBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.editBtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'searchBtn
        '
        Me.searchBtn.Location = New System.Drawing.Point(615, 67)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(151, 53)
        Me.searchBtn.TabIndex = 1
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(1035, 426)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(83, 27)
        Me.exitBtn.TabIndex = 3
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'searchBox
        '
        Me.searchBox.Location = New System.Drawing.Point(615, 38)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(151, 23)
        Me.searchBox.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(615, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Search"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(612, 266)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 25
        Me.DataGridView2.Size = New System.Drawing.Size(408, 187)
        Me.DataGridView2.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(847, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 15)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Filters"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ID", "First Name", "Last Name", "Mobile Number", "City"})
        Me.ComboBox1.Location = New System.Drawing.Point(847, 34)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(615, 244)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 15)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Search Results:"
        '
        'matchesLabel
        '
        Me.matchesLabel.AutoSize = True
        Me.matchesLabel.Location = New System.Drawing.Point(706, 244)
        Me.matchesLabel.Name = "matchesLabel"
        Me.matchesLabel.Size = New System.Drawing.Size(13, 15)
        Me.matchesLabel.TabIndex = 24
        Me.matchesLabel.Text = "0"
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(444, 32)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(125, 37)
        Me.addBtn.TabIndex = 0
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'delBtn
        '
        Me.delBtn.Location = New System.Drawing.Point(444, 146)
        Me.delBtn.Name = "delBtn"
        Me.delBtn.Size = New System.Drawing.Size(125, 37)
        Me.delBtn.TabIndex = 2
        Me.delBtn.Text = "Delete"
        Me.delBtn.UseVisualStyleBackColor = True
        '
        'fNameBox
        '
        Me.fNameBox.Location = New System.Drawing.Point(22, 40)
        Me.fNameBox.Name = "fNameBox"
        Me.fNameBox.Size = New System.Drawing.Size(335, 23)
        Me.fNameBox.TabIndex = 4
        '
        'lNameBox
        '
        Me.lNameBox.Location = New System.Drawing.Point(21, 97)
        Me.lNameBox.Name = "lNameBox"
        Me.lNameBox.Size = New System.Drawing.Size(335, 23)
        Me.lNameBox.TabIndex = 5
        '
        'mNumberBox
        '
        Me.mNumberBox.Location = New System.Drawing.Point(21, 154)
        Me.mNumberBox.Name = "mNumberBox"
        Me.mNumberBox.Size = New System.Drawing.Size(335, 23)
        Me.mNumberBox.TabIndex = 6
        '
        'cityBox
        '
        Me.cityBox.Location = New System.Drawing.Point(21, 211)
        Me.cityBox.Name = "cityBox"
        Me.cityBox.Size = New System.Drawing.Size(335, 23)
        Me.cityBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Mobile Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "City"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "List of Attendees"
        '
        'editBtn
        '
        Me.editBtn.Location = New System.Drawing.Point(444, 89)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Size = New System.Drawing.Size(125, 37)
        Me.editBtn.TabIndex = 14
        Me.editBtn.Text = "Edit"
        Me.editBtn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 266)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(558, 187)
        Me.DataGridView1.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 466)
        Me.Controls.Add(Me.matchesLabel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.editBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cityBox)
        Me.Controls.Add(Me.mNumberBox)
        Me.Controls.Add(Me.lNameBox)
        Me.Controls.Add(Me.fNameBox)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.delBtn)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.addBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Attendees Viewer"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents searchBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents searchBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents matchesLabel As Label
    Friend WithEvents addBtn As Button
    Friend WithEvents delBtn As Button
    Friend WithEvents fNameBox As TextBox
    Friend WithEvents lNameBox As TextBox
    Friend WithEvents mNumberBox As TextBox
    Friend WithEvents cityBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents editBtn As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
