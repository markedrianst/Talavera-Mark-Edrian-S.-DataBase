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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HallName = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.TelNo = New System.Windows.Forms.TextBox()
        Me.HallMngr = New System.Windows.Forms.TextBox()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Close = New System.Windows.Forms.Button()
        Me.Newbtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hall Name "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Telephone No "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Hall Manager"
        '
        'HallName
        '
        Me.HallName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HallName.Location = New System.Drawing.Point(134, 46)
        Me.HallName.Name = "HallName"
        Me.HallName.Size = New System.Drawing.Size(177, 26)
        Me.HallName.TabIndex = 5
        '
        'Address
        '
        Me.Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.Location = New System.Drawing.Point(134, 99)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(177, 26)
        Me.Address.TabIndex = 6
        '
        'TelNo
        '
        Me.TelNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelNo.Location = New System.Drawing.Point(134, 146)
        Me.TelNo.Name = "TelNo"
        Me.TelNo.Size = New System.Drawing.Size(177, 26)
        Me.TelNo.TabIndex = 7
        '
        'HallMngr
        '
        Me.HallMngr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HallMngr.Location = New System.Drawing.Point(134, 192)
        Me.HallMngr.Name = "HallMngr"
        Me.HallMngr.Size = New System.Drawing.Size(177, 26)
        Me.HallMngr.TabIndex = 8
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(331, 146)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(116, 40)
        Me.Delete.TabIndex = 9
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Edit
        '
        Me.Edit.Location = New System.Drawing.Point(331, 46)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(116, 40)
        Me.Edit.TabIndex = 10
        Me.Edit.Text = "Edit"
        Me.Edit.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(331, 190)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(116, 40)
        Me.Cancel.TabIndex = 11
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(331, 92)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(116, 40)
        Me.save.TabIndex = 12
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Peru
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Close)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.save)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.HallName)
        Me.Panel1.Controls.Add(Me.HallMngr)
        Me.Panel1.Controls.Add(Me.Address)
        Me.Panel1.Controls.Add(Me.TelNo)
        Me.Panel1.Controls.Add(Me.Delete)
        Me.Panel1.Controls.Add(Me.Cancel)
        Me.Panel1.Controls.Add(Me.Newbtn)
        Me.Panel1.Controls.Add(Me.Edit)
        Me.Panel1.Location = New System.Drawing.Point(27, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(506, 265)
        Me.Panel1.TabIndex = 13
        '
        'Close
        '
        Me.Close.Location = New System.Drawing.Point(331, 190)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(116, 40)
        Me.Close.TabIndex = 13
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = True
        '
        'Newbtn
        '
        Me.Newbtn.Location = New System.Drawing.Point(331, 46)
        Me.Newbtn.Name = "Newbtn"
        Me.Newbtn.Size = New System.Drawing.Size(116, 40)
        Me.Newbtn.TabIndex = 14
        Me.Newbtn.Text = "New"
        Me.Newbtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(237, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 22)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Hall Table"
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(27, 346)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(506, 197)
        Me.ListView1.TabIndex = 16
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(565, 588)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Data Base"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents HallName As TextBox
    Friend WithEvents Address As TextBox
    Friend WithEvents TelNo As TextBox
    Friend WithEvents HallMngr As TextBox
    Friend WithEvents Delete As Button
    Friend WithEvents Edit As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents save As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Close As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Newbtn As Button
    Friend WithEvents ListView1 As ListView
End Class
