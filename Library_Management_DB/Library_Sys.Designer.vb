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
        Me.Save_btn = New System.Windows.Forms.Button()
        Me.Update_btn = New System.Windows.Forms.Button()
        Me.Delete_btn = New System.Windows.Forms.Button()
        Me.ID_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fst_name_txt = New System.Windows.Forms.TextBox()
        Me.ph_num = New System.Windows.Forms.TextBox()
        Me.lst_name_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.email_txt = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.nxt_bt = New System.Windows.Forms.Button()
        Me.Edit_bt = New System.Windows.Forms.Button()
        Me.Add_bt = New System.Windows.Forms.Button()
        Me.Search_bt = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Save_btn
        '
        Me.Save_btn.Location = New System.Drawing.Point(235, 453)
        Me.Save_btn.Name = "Save_btn"
        Me.Save_btn.Size = New System.Drawing.Size(87, 44)
        Me.Save_btn.TabIndex = 0
        Me.Save_btn.Text = "Save"
        Me.Save_btn.UseVisualStyleBackColor = True
        Me.Save_btn.Visible = False
        '
        'Update_btn
        '
        Me.Update_btn.Location = New System.Drawing.Point(365, 453)
        Me.Update_btn.Name = "Update_btn"
        Me.Update_btn.Size = New System.Drawing.Size(87, 44)
        Me.Update_btn.TabIndex = 1
        Me.Update_btn.Text = "Update"
        Me.Update_btn.UseVisualStyleBackColor = True
        Me.Update_btn.Visible = False
        '
        'Delete_btn
        '
        Me.Delete_btn.Location = New System.Drawing.Point(503, 453)
        Me.Delete_btn.Name = "Delete_btn"
        Me.Delete_btn.Size = New System.Drawing.Size(87, 44)
        Me.Delete_btn.TabIndex = 2
        Me.Delete_btn.Text = "Delete"
        Me.Delete_btn.UseVisualStyleBackColor = True
        '
        'ID_txt
        '
        Me.ID_txt.Enabled = False
        Me.ID_txt.Location = New System.Drawing.Point(135, 29)
        Me.ID_txt.Multiline = True
        Me.ID_txt.Name = "ID_txt"
        Me.ID_txt.Size = New System.Drawing.Size(125, 38)
        Me.ID_txt.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID"
        '
        'fst_name_txt
        '
        Me.fst_name_txt.Enabled = False
        Me.fst_name_txt.Location = New System.Drawing.Point(135, 99)
        Me.fst_name_txt.Multiline = True
        Me.fst_name_txt.Name = "fst_name_txt"
        Me.fst_name_txt.Size = New System.Drawing.Size(125, 38)
        Me.fst_name_txt.TabIndex = 6
        '
        'ph_num
        '
        Me.ph_num.Enabled = False
        Me.ph_num.Location = New System.Drawing.Point(135, 250)
        Me.ph_num.Multiline = True
        Me.ph_num.Name = "ph_num"
        Me.ph_num.Size = New System.Drawing.Size(125, 38)
        Me.ph_num.TabIndex = 7
        '
        'lst_name_txt
        '
        Me.lst_name_txt.Enabled = False
        Me.lst_name_txt.Location = New System.Drawing.Point(135, 176)
        Me.lst_name_txt.Multiline = True
        Me.lst_name_txt.Name = "lst_name_txt"
        Me.lst_name_txt.Size = New System.Drawing.Size(125, 38)
        Me.lst_name_txt.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Contact Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Last Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "First Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Email"
        '
        'email_txt
        '
        Me.email_txt.Enabled = False
        Me.email_txt.Location = New System.Drawing.Point(135, 315)
        Me.email_txt.Multiline = True
        Me.email_txt.Name = "email_txt"
        Me.email_txt.Size = New System.Drawing.Size(163, 38)
        Me.email_txt.TabIndex = 14
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(135, 372)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(80, 21)
        Me.RadioButton1.TabIndex = 16
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Member"
        Me.RadioButton1.UseVisualStyleBackColor = True
        Me.RadioButton1.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(255, 372)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(78, 21)
        Me.RadioButton2.TabIndex = 17
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Student"
        Me.RadioButton2.UseVisualStyleBackColor = True
        Me.RadioButton2.Visible = False
        '
        'nxt_bt
        '
        Me.nxt_bt.Location = New System.Drawing.Point(365, 393)
        Me.nxt_bt.Name = "nxt_bt"
        Me.nxt_bt.Size = New System.Drawing.Size(87, 44)
        Me.nxt_bt.TabIndex = 18
        Me.nxt_bt.Text = "Next"
        Me.nxt_bt.UseVisualStyleBackColor = True
        '
        'Edit_bt
        '
        Me.Edit_bt.Location = New System.Drawing.Point(365, 453)
        Me.Edit_bt.Name = "Edit_bt"
        Me.Edit_bt.Size = New System.Drawing.Size(87, 44)
        Me.Edit_bt.TabIndex = 19
        Me.Edit_bt.Text = "Edit"
        Me.Edit_bt.UseVisualStyleBackColor = True
        '
        'Add_bt
        '
        Me.Add_bt.Location = New System.Drawing.Point(235, 453)
        Me.Add_bt.Name = "Add_bt"
        Me.Add_bt.Size = New System.Drawing.Size(87, 44)
        Me.Add_bt.TabIndex = 20
        Me.Add_bt.Text = "Add"
        Me.Add_bt.UseVisualStyleBackColor = True
        '
        'Search_bt
        '
        Me.Search_bt.Location = New System.Drawing.Point(637, 453)
        Me.Search_bt.Name = "Search_bt"
        Me.Search_bt.Size = New System.Drawing.Size(87, 44)
        Me.Search_bt.TabIndex = 21
        Me.Search_bt.Text = "Search"
        Me.Search_bt.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(503, 56)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(478, 232)
        Me.DataGridView1.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 536)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Search_bt)
        Me.Controls.Add(Me.Add_bt)
        Me.Controls.Add(Me.Edit_bt)
        Me.Controls.Add(Me.nxt_bt)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.email_txt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lst_name_txt)
        Me.Controls.Add(Me.ph_num)
        Me.Controls.Add(Me.fst_name_txt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ID_txt)
        Me.Controls.Add(Me.Delete_btn)
        Me.Controls.Add(Me.Update_btn)
        Me.Controls.Add(Me.Save_btn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Save_btn As Button
    Friend WithEvents Update_btn As Button
    Friend WithEvents Delete_btn As Button
    Friend WithEvents ID_txt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents fst_name_txt As TextBox
    Friend WithEvents ph_num As TextBox
    Friend WithEvents lst_name_txt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents email_txt As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents nxt_bt As Button
    Friend WithEvents Edit_bt As Button
    Friend WithEvents Add_bt As Button
    Friend WithEvents Search_bt As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
