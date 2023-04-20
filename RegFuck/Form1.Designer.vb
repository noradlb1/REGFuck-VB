Namespace RegFuck
	Partial Public Class Form1
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.trackBar1 = New System.Windows.Forms.TrackBar()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.button1 = New System.Windows.Forms.Button()
			Me.label3 = New System.Windows.Forms.Label()
			Me.button2 = New System.Windows.Forms.Button()
			DirectCast(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' trackBar1
			' 
			Me.trackBar1.LargeChange = 20
			Me.trackBar1.Location = New System.Drawing.Point(53, 15)
			Me.trackBar1.Margin = New System.Windows.Forms.Padding(4)
			Me.trackBar1.Maximum = 100
			Me.trackBar1.Name = "trackBar1"
			Me.trackBar1.Size = New System.Drawing.Size(640, 56)
			Me.trackBar1.SmallChange = 5
			Me.trackBar1.TabIndex = 0
			Me.trackBar1.TickFrequency = 5
			Me.trackBar1.Value = 80
'			Me.trackBar1.Scroll += New System.EventHandler(Me.trackBar1_Scroll)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(31, 54)
			Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(78, 28)
			Me.label1.TabIndex = 1
			Me.label1.Text = "PUSSY"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.Location = New System.Drawing.Point(595, 54)
			Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(153, 28)
			Me.label2.TabIndex = 2
			Me.label2.Text = "REST IN PISS"
			' 
			' button1
			' 
			Me.button1.Font = New System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button1.Location = New System.Drawing.Point(21, 315)
			Me.button1.Margin = New System.Windows.Forms.Padding(4)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(728, 79)
			Me.button1.TabIndex = 3
			Me.button1.Text = "DO IT"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Font = New System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label3.Location = New System.Drawing.Point(512, 74)
			Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(67, 28)
			Me.label3.TabIndex = 4
			Me.label3.Text = "label3"
			' 
			' button2
			' 
			Me.button2.BackColor = System.Drawing.Color.Black
			Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button2.Font = New System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button2.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(192)))), (CInt((CByte(0)))))
			Me.button2.Location = New System.Drawing.Point(561, 251)
			Me.button2.Margin = New System.Windows.Forms.Padding(4)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(188, 57)
			Me.button2.TabIndex = 5
			Me.button2.Text = "settingz for 1337 h4x0rz"
			Me.button2.UseVisualStyleBackColor = False
'			Me.button2.Click += New System.EventHandler(Me.button2_Click)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackgroundImage = My.Resources.fuck
			Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
			Me.ClientSize = New System.Drawing.Size(765, 409)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.trackBar1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.MaximizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "REGFuck"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			DirectCast(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents trackBar1 As System.Windows.Forms.TrackBar
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private WithEvents button1 As System.Windows.Forms.Button
		Private label3 As System.Windows.Forms.Label
		Private WithEvents button2 As System.Windows.Forms.Button
	End Class
End Namespace

