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
        Me.Name1 = New System.Windows.Forms.TextBox()
        Me.Test1 = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.ComboJ4 = New System.Windows.Forms.ComboBox()
        Me.comboJ2 = New System.Windows.Forms.ComboBox()
        Me.comboJ1 = New System.Windows.Forms.ComboBox()
        Me.ComboJ3 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.results = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Name1
        '
        Me.Name1.Location = New System.Drawing.Point(-1, 34)
        Me.Name1.Name = "Name1"
        Me.Name1.Size = New System.Drawing.Size(254, 26)
        Me.Name1.TabIndex = 0
        Me.Name1.Text = "Jim"
        '
        'Test1
        '
        Me.Test1.Location = New System.Drawing.Point(12, 388)
        Me.Test1.Name = "Test1"
        Me.Test1.Size = New System.Drawing.Size(175, 50)
        Me.Test1.TabIndex = 1
        Me.Test1.Text = "Test"
        Me.Test1.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(139, 20)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Contestant1Name"
        '
        'ComboJ4
        '
        Me.ComboJ4.FormattingEnabled = True
        Me.ComboJ4.Items.AddRange(New Object() {"Y", "N"})
        Me.ComboJ4.Location = New System.Drawing.Point(610, 32)
        Me.ComboJ4.Name = "ComboJ4"
        Me.ComboJ4.Size = New System.Drawing.Size(67, 28)
        Me.ComboJ4.TabIndex = 3
        Me.ComboJ4.Text = "N"
        '
        'comboJ2
        '
        Me.comboJ2.FormattingEnabled = True
        Me.comboJ2.Items.AddRange(New Object() {"Y", "N"})
        Me.comboJ2.Location = New System.Drawing.Point(464, 34)
        Me.comboJ2.Name = "comboJ2"
        Me.comboJ2.Size = New System.Drawing.Size(67, 28)
        Me.comboJ2.TabIndex = 4
        Me.comboJ2.Text = "N"
        '
        'comboJ1
        '
        Me.comboJ1.FormattingEnabled = True
        Me.comboJ1.Items.AddRange(New Object() {"Y", "N"})
        Me.comboJ1.Location = New System.Drawing.Point(391, 34)
        Me.comboJ1.Name = "comboJ1"
        Me.comboJ1.Size = New System.Drawing.Size(67, 28)
        Me.comboJ1.TabIndex = 5
        Me.comboJ1.Text = "N"
        '
        'ComboJ3
        '
        Me.ComboJ3.FormattingEnabled = True
        Me.ComboJ3.Items.AddRange(New Object() {"Y", "N"})
        Me.ComboJ3.Location = New System.Drawing.Point(537, 32)
        Me.ComboJ3.Name = "ComboJ3"
        Me.ComboJ3.Size = New System.Drawing.Size(67, 28)
        Me.ComboJ3.TabIndex = 6
        Me.ComboJ3.Text = "N"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(387, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "J1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(474, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "J2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(547, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "J3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(620, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "J4"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.results)
        Me.Panel1.Controls.Add(Me.ComboJ3)
        Me.Panel1.Controls.Add(Me.Name1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ComboJ4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.comboJ2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.comboJ1)
        Me.Panel1.Location = New System.Drawing.Point(40, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(694, 120)
        Me.Panel1.TabIndex = 12
        '
        'results
        '
        Me.results.AutoSize = True
        Me.results.Location = New System.Drawing.Point(61, 81)
        Me.results.Name = "results"
        Me.results.Size = New System.Drawing.Size(63, 20)
        Me.results.TabIndex = 12
        Me.results.Text = "Results"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Test1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Name1 As TextBox
    Friend WithEvents Test1 As Button
    Friend WithEvents lblName As Label
    Friend WithEvents ComboJ4 As ComboBox
    Friend WithEvents comboJ2 As ComboBox
    Friend WithEvents comboJ1 As ComboBox
    Friend WithEvents ComboJ3 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents results As Label
End Class
