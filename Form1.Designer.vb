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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.txtInterest = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAnalysis = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnNewLoan = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnMonth = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Noto Mono", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bilancio Prestito"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Noto Mono", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Interessi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Noto Mono", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Numero Pagamenti"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Noto Mono", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(231, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Numero Mesi                     "
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(144, 12)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(202, 20)
        Me.txtBalance.TabIndex = 0
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInterest
        '
        Me.txtInterest.Location = New System.Drawing.Point(144, 71)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(202, 20)
        Me.txtInterest.TabIndex = 1
        Me.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(144, 119)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(202, 20)
        Me.txtMonth.TabIndex = 2
        Me.txtMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPayment
        '
        Me.txtPayment.Location = New System.Drawing.Point(144, 172)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(202, 20)
        Me.txtPayment.TabIndex = 4
        Me.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Noto Mono", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(399, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Analisi Prestito"
        '
        'txtAnalysis
        '
        Me.txtAnalysis.BackColor = System.Drawing.Color.White
        Me.txtAnalysis.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnalysis.Location = New System.Drawing.Point(402, 45)
        Me.txtAnalysis.Multiline = True
        Me.txtAnalysis.Name = "txtAnalysis"
        Me.txtAnalysis.ReadOnly = True
        Me.txtAnalysis.Size = New System.Drawing.Size(357, 149)
        Me.txtAnalysis.TabIndex = 9
        Me.txtAnalysis.TabStop = False
        '
        'btnCompute
        '
        Me.btnCompute.Font = New System.Drawing.Font("Noto Mono", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(90, 290)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(228, 36)
        Me.btnCompute.TabIndex = 6
        Me.btnCompute.Text = "Calcola Pagamenti Mensili"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'btnNewLoan
        '
        Me.btnNewLoan.Enabled = False
        Me.btnNewLoan.Font = New System.Drawing.Font("Noto Mono", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewLoan.Location = New System.Drawing.Point(90, 355)
        Me.btnNewLoan.Name = "btnNewLoan"
        Me.btnNewLoan.Size = New System.Drawing.Size(228, 36)
        Me.btnNewLoan.TabIndex = 7
        Me.btnNewLoan.Text = "Nuova Analisi"
        Me.btnNewLoan.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Noto Mono", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(453, 322)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(228, 36)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPayment
        '
        Me.btnPayment.Font = New System.Drawing.Font("Noto Mono", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.Location = New System.Drawing.Point(365, 169)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(24, 23)
        Me.btnPayment.TabIndex = 5
        Me.btnPayment.Text = "X"
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'btnMonth
        '
        Me.btnMonth.Font = New System.Drawing.Font("Noto Mono", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMonth.Location = New System.Drawing.Point(365, 116)
        Me.btnMonth.Name = "btnMonth"
        Me.btnMonth.Size = New System.Drawing.Size(24, 23)
        Me.btnMonth.TabIndex = 3
        Me.btnMonth.Text = "X"
        Me.btnMonth.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMonth)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNewLoan)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtAnalysis)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtInterest)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assistenza Prestiti"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents txtInterest As TextBox
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAnalysis As TextBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnNewLoan As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPayment As Button
    Friend WithEvents btnMonth As Button
End Class
