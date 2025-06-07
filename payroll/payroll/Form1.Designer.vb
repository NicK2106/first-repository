<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel9 = New Panel()
        Label1 = New Label()
        Panel8 = New Panel()
        Label2 = New Label()
        Panel7 = New Panel()
        Panel6 = New Panel()
        Button4 = New Button()
        Panel5 = New Panel()
        Panel4 = New Panel()
        TextBox1 = New TextBox()
        Panel3 = New Panel()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        Panel2.SuspendLayout()
        Panel9.SuspendLayout()
        Panel8.SuspendLayout()
        Panel4.SuspendLayout()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1414, 687)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = " x"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(21, 676)
        Button2.Name = "Button2"
        Button2.Size = New Size(91, 34)
        Button2.TabIndex = 1
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(118, 676)
        Button3.Name = "Button3"
        Button3.Size = New Size(91, 34)
        Button3.TabIndex = 2
        Button3.Text = "Back"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LimeGreen
        Panel1.Location = New Point(2, 486)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1501, 184)
        Panel1.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.OliveDrab
        Panel2.Controls.Add(Panel9)
        Panel2.Controls.Add(Panel8)
        Panel2.Controls.Add(Panel7)
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Panel4)
        Panel2.Location = New Point(2, 109)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1501, 357)
        Panel2.TabIndex = 4
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.BlanchedAlmond
        Panel9.Controls.Add(Label1)
        Panel9.Location = New Point(81, 11)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(344, 37)
        Panel9.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(97, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 15)
        Label1.TabIndex = 0
        Label1.Text = "Regular & Over Time Pay"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.BlanchedAlmond
        Panel8.Controls.Add(Label2)
        Panel8.Location = New Point(495, 11)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(344, 37)
        Panel8.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(108, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 15)
        Label2.TabIndex = 1
        Label2.Text = "Employee Contribution"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.BlanchedAlmond
        Panel7.Location = New Point(1103, 54)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(291, 27)
        Panel7.TabIndex = 8
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Gold
        Panel6.Location = New Point(1103, 54)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(291, 287)
        Panel6.TabIndex = 7
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Khaki
        Button4.Location = New Point(1173, 11)
        Button4.Name = "Button4"
        Button4.Size = New Size(138, 37)
        Button4.TabIndex = 7
        Button4.Text = "Show Receipt"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Yellow
        Panel5.Location = New Point(495, 11)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(344, 330)
        Panel5.TabIndex = 6
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Yellow
        Panel4.Controls.Add(TextBox1)
        Panel4.Location = New Point(81, 11)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(344, 330)
        Panel4.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(207, 68)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Beige
        Panel3.Location = New Point(2, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1501, 82)
        Panel3.TabIndex = 5
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkOliveGreen
        ClientSize = New Size(1501, 742)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel2.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher

End Class
