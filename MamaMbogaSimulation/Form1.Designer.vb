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
        Me.btnArrive = New System.Windows.Forms.Button()
        Me.btnAskPrice = New System.Windows.Forms.Button()
        Me.btnBargain = New System.Windows.Forms.Button()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lstLog = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnArrive
        '
        Me.btnArrive.Location = New System.Drawing.Point(360, 12)
        Me.btnArrive.Name = "btnArrive"
        Me.btnArrive.Size = New System.Drawing.Size(114, 39)
        Me.btnArrive.TabIndex = 0
        Me.btnArrive.Text = "Customer Arrives"
        Me.btnArrive.UseVisualStyleBackColor = True
        '
        'btnAskPrice
        '
        Me.btnAskPrice.Location = New System.Drawing.Point(360, 48)
        Me.btnAskPrice.Name = "btnAskPrice"
        Me.btnAskPrice.Size = New System.Drawing.Size(114, 38)
        Me.btnAskPrice.TabIndex = 1
        Me.btnAskPrice.Text = "Ask Price"
        Me.btnAskPrice.UseVisualStyleBackColor = True
        '
        'btnBargain
        '
        Me.btnBargain.Location = New System.Drawing.Point(360, 85)
        Me.btnBargain.Name = "btnBargain"
        Me.btnBargain.Size = New System.Drawing.Size(114, 27)
        Me.btnBargain.TabIndex = 2
        Me.btnBargain.Text = "Bargain"
        Me.btnBargain.UseVisualStyleBackColor = True
        '
        'btnBuy
        '
        Me.btnBuy.Location = New System.Drawing.Point(360, 109)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(114, 23)
        Me.btnBuy.TabIndex = 3
        Me.btnBuy.Text = "Pay"
        Me.btnBuy.UseVisualStyleBackColor = True
        '
        'btnStock
        '
        Me.btnStock.Location = New System.Drawing.Point(360, 129)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(114, 43)
        Me.btnStock.TabIndex = 4
        Me.btnStock.Text = "Add Stock"
        Me.btnStock.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(333, 175)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(107, 13)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "Current system status"
        '
        'lstLog
        '
        Me.lstLog.FormattingEnabled = True
        Me.lstLog.Location = New System.Drawing.Point(-1, 195)
        Me.lstLog.Name = "lstLog"
        Me.lstLog.Size = New System.Drawing.Size(789, 238)
        Me.lstLog.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstLog)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnStock)
        Me.Controls.Add(Me.btnBuy)
        Me.Controls.Add(Me.btnBargain)
        Me.Controls.Add(Me.btnAskPrice)
        Me.Controls.Add(Me.btnArrive)
        Me.Name = "Form1"
        Me.Text = " mamabongasimulation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnArrive As Button
    Friend WithEvents btnAskPrice As Button
    Friend WithEvents btnBargain As Button
    Friend WithEvents btnBuy As Button
    Friend WithEvents btnStock As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents lstLog As ListBox
End Class
