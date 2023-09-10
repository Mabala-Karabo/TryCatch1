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
        txtCalculate = New Button()
        txtX = New TextBox()
        txtY = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' txtCalculate
        ' 
        txtCalculate.Location = New Point(561, 307)
        txtCalculate.Name = "txtCalculate"
        txtCalculate.Size = New Size(112, 34)
        txtCalculate.TabIndex = 0
        txtCalculate.Text = "Calculate"
        txtCalculate.UseVisualStyleBackColor = True
        ' 
        ' txtX
        ' 
        txtX.Location = New Point(291, 143)
        txtX.Name = "txtX"
        txtX.Size = New Size(150, 31)
        txtX.TabIndex = 1
        ' 
        ' txtY
        ' 
        txtY.Location = New Point(291, 196)
        txtY.Name = "txtY"
        txtY.Size = New Size(150, 31)
        txtY.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(239, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(248, 25)
        Label1.TabIndex = 3
        Label1.Text = "Structured Exception handling"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(281, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(160, 25)
        Label2.TabIndex = 4
        Label2.Text = "(System Exception)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(134, 149)
        Label3.Name = "Label3"
        Label3.Size = New Size(151, 25)
        Label3.TabIndex = 5
        Label3.Text = "Enter 1st Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(117, 202)
        Label4.Name = "Label4"
        Label4.Size = New Size(158, 25)
        Label4.TabIndex = 6
        Label4.Text = "Enter 2nd Number"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtY)
        Controls.Add(txtX)
        Controls.Add(txtCalculate)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCalculate As Button
    Friend WithEvents txtX As TextBox
    Friend WithEvents txtY As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
