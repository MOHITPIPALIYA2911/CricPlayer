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
        Me.GridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnins = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtsrc = New System.Windows.Forms.TextBox()
        Me.src = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcntr = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.btndlt = New System.Windows.Forms.Button()
        Me.btndsp = New System.Windows.Forms.Button()
        Me.btnup = New System.Windows.Forms.Button()
        Me.cntName = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridView
        '
        Me.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridView.Location = New System.Drawing.Point(0, 214)
        Me.GridView.Name = "GridView"
        Me.GridView.RowTemplate.Height = 25
        Me.GridView.Size = New System.Drawing.Size(800, 236)
        Me.GridView.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(311, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cricket players"
        '
        'btnins
        '
        Me.btnins.Location = New System.Drawing.Point(465, 68)
        Me.btnins.Name = "btnins"
        Me.btnins.Size = New System.Drawing.Size(125, 23)
        Me.btnins.TabIndex = 2
        Me.btnins.Text = "Add"
        Me.btnins.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtsrc)
        Me.GroupBox1.Controls.Add(Me.src)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtnor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtnom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtcntr)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 174)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add player"
        '
        'txtsrc
        '
        Me.txtsrc.Location = New System.Drawing.Point(29, 141)
        Me.txtsrc.Name = "txtsrc"
        Me.txtsrc.Size = New System.Drawing.Size(238, 23)
        Me.txtsrc.TabIndex = 9
        '
        'src
        '
        Me.src.Location = New System.Drawing.Point(273, 141)
        Me.src.Name = "src"
        Me.src.Size = New System.Drawing.Size(75, 23)
        Me.src.TabIndex = 8
        Me.src.Text = "Search"
        Me.src.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "No. of runs"
        '
        'txtnor
        '
        Me.txtnor.Location = New System.Drawing.Point(143, 112)
        Me.txtnor.Name = "txtnor"
        Me.txtnor.Size = New System.Drawing.Size(207, 23)
        Me.txtnor.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "No. of matches"
        '
        'txtnom
        '
        Me.txtnom.Location = New System.Drawing.Point(143, 83)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(207, 23)
        Me.txtnom.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Country"
        '
        'txtcntr
        '
        Me.txtcntr.Location = New System.Drawing.Point(143, 54)
        Me.txtcntr.Name = "txtcntr"
        Me.txtcntr.Size = New System.Drawing.Size(207, 23)
        Me.txtcntr.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(143, 25)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(207, 23)
        Me.txtname.TabIndex = 0
        '
        'btndlt
        '
        Me.btndlt.Location = New System.Drawing.Point(465, 116)
        Me.btndlt.Name = "btndlt"
        Me.btndlt.Size = New System.Drawing.Size(125, 23)
        Me.btndlt.TabIndex = 4
        Me.btndlt.Text = "Delete"
        Me.btndlt.UseVisualStyleBackColor = True
        '
        'btndsp
        '
        Me.btndsp.Location = New System.Drawing.Point(621, 116)
        Me.btndsp.Name = "btndsp"
        Me.btndsp.Size = New System.Drawing.Size(125, 23)
        Me.btndsp.TabIndex = 6
        Me.btndsp.Text = "Show all"
        Me.btndsp.UseVisualStyleBackColor = True
        '
        'btnup
        '
        Me.btnup.Location = New System.Drawing.Point(621, 68)
        Me.btnup.Name = "btnup"
        Me.btnup.Size = New System.Drawing.Size(125, 23)
        Me.btnup.TabIndex = 5
        Me.btnup.Text = "Update"
        Me.btnup.UseVisualStyleBackColor = True
        '
        'cntName
        '
        Me.cntName.FormattingEnabled = True
        Me.cntName.Location = New System.Drawing.Point(566, 163)
        Me.cntName.Name = "cntName"
        Me.cntName.Size = New System.Drawing.Size(180, 23)
        Me.cntName.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(465, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 19)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Select country"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cntName)
        Me.Controls.Add(Me.btndsp)
        Me.Controls.Add(Me.btnup)
        Me.Controls.Add(Me.btndlt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnins)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridView)
        Me.Name = "Form1"
        Me.Text = "Cricket players"
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnins As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcntr As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents btndlt As Button
    Friend WithEvents btndsp As Button
    Friend WithEvents btnup As Button
    Friend WithEvents cntName As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtsrc As TextBox
    Friend WithEvents src As Button
End Class
