Namespace RegFuck
	Partial Public Class Form3
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.label3 = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Font = New System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label3.Location = New System.Drawing.Point(16, 263)
			Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(72, 28)
			Me.label3.TabIndex = 5
			Me.label3.Text = "Seed: "
			' 
			' Form3
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackgroundImage = My.Resources.done
			Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
			Me.ClientSize = New System.Drawing.Size(789, 303)
			Me.ControlBox = False
			Me.Controls.Add(Me.label3)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Form3"
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "nice"
			Me.TopMost = True
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.Form3_FormClosing)
'			Me.Load += New System.EventHandler(Me.Form3_Load)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label3 As System.Windows.Forms.Label
	End Class
End Namespace