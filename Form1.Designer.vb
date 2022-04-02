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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtp1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtp2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtp3 = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(154, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COMPRA DE PRODUCTOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Script MT Bold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(154, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingrese el valor del producto 1"
        '
        'txtp1
        '
        Me.txtp1.Location = New System.Drawing.Point(164, 163)
        Me.txtp1.Name = "txtp1"
        Me.txtp1.Size = New System.Drawing.Size(222, 23)
        Me.txtp1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Script MT Bold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(154, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(244, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ingrese el valor del producto 2"
        '
        'txtp2
        '
        Me.txtp2.Location = New System.Drawing.Point(164, 229)
        Me.txtp2.Name = "txtp2"
        Me.txtp2.Size = New System.Drawing.Size(222, 23)
        Me.txtp2.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Script MT Bold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(154, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(244, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ingrese el valor del producto 3"
        '
        'txtp3
        '
        Me.txtp3.Location = New System.Drawing.Point(164, 296)
        Me.txtp3.Name = "txtp3"
        Me.txtp3.Size = New System.Drawing.Size(222, 23)
        Me.txtp3.TabIndex = 3
        '
        'btncalcular
        '
        Me.btncalcular.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btncalcular.Font = New System.Drawing.Font("Segoe Print", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btncalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btncalcular.Location = New System.Drawing.Point(164, 339)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(222, 35)
        Me.btncalcular.TabIndex = 4
        Me.btncalcular.Text = "Calcular Totales"
        Me.btncalcular.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(238, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 67)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(565, 442)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.txtp3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtp2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtp1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RONY RODRIGUEZ"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtp1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtp2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtp3 As TextBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
