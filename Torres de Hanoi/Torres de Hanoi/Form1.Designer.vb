﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txtNoDiscos = New System.Windows.Forms.TextBox()
        Me.BtAPorEl = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(368, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buenos dias ¿Qur tal tu dia ?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(346, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Indica con cuantos Discos deseas Jugar  "
        '
        'txtNoDiscos
        '
        Me.txtNoDiscos.Location = New System.Drawing.Point(398, 256)
        Me.txtNoDiscos.Name = "txtNoDiscos"
        Me.txtNoDiscos.Size = New System.Drawing.Size(100, 20)
        Me.txtNoDiscos.TabIndex = 2
        '
        'BtAPorEl
        '
        Me.BtAPorEl.Location = New System.Drawing.Point(398, 395)
        Me.BtAPorEl.Name = "BtAPorEl"
        Me.BtAPorEl.Size = New System.Drawing.Size(75, 23)
        Me.BtAPorEl.TabIndex = 3
        Me.BtAPorEl.Text = "A Por El"
        Me.BtAPorEl.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 571)
        Me.Controls.Add(Me.BtAPorEl)
        Me.Controls.Add(Me.txtNoDiscos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNoDiscos As System.Windows.Forms.TextBox
    Friend WithEvents BtAPorEl As System.Windows.Forms.Button
End Class
