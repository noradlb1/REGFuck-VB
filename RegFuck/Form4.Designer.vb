Namespace RegFuck
	Partial Public Class Form4
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form4))
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.trackBar1 = New System.Windows.Forms.TrackBar()
			Me.trackBar2 = New System.Windows.Forms.TrackBar()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.trackBar3 = New System.Windows.Forms.TrackBar()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label6 = New System.Windows.Forms.Label()
			Me.trackBar4 = New System.Windows.Forms.TrackBar()
			Me.label7 = New System.Windows.Forms.Label()
			Me.label8 = New System.Windows.Forms.Label()
			Me.button2 = New System.Windows.Forms.Button()
			Me.label9 = New System.Windows.Forms.Label()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.button1 = New System.Windows.Forms.Button()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			DirectCast(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.trackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.trackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.trackBar4, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(642, 9)
			Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(59, 32)
			Me.label2.TabIndex = 5
			Me.label2.Text = "80%"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(18, 9)
			Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(74, 32)
			Me.label1.TabIndex = 4
			Me.label1.Text = "HKCR"
			' 
			' trackBar1
			' 
			Me.trackBar1.LargeChange = 20
			Me.trackBar1.Location = New System.Drawing.Point(22, 37)
			Me.trackBar1.Margin = New System.Windows.Forms.Padding(4)
			Me.trackBar1.Maximum = 100
			Me.trackBar1.Name = "trackBar1"
			Me.trackBar1.Size = New System.Drawing.Size(678, 56)
			Me.trackBar1.SmallChange = 5
			Me.trackBar1.TabIndex = 3
			Me.trackBar1.TickFrequency = 5
			Me.trackBar1.Value = 80
'			Me.trackBar1.Scroll += New System.EventHandler(Me.trackBar1_Scroll)
			' 
			' trackBar2
			' 
			Me.trackBar2.LargeChange = 20
			Me.trackBar2.Location = New System.Drawing.Point(22, 131)
			Me.trackBar2.Margin = New System.Windows.Forms.Padding(4)
			Me.trackBar2.Maximum = 100
			Me.trackBar2.Name = "trackBar2"
			Me.trackBar2.Size = New System.Drawing.Size(678, 56)
			Me.trackBar2.SmallChange = 5
			Me.trackBar2.TabIndex = 3
			Me.trackBar2.TickFrequency = 5
			Me.trackBar2.Value = 100
'			Me.trackBar2.Scroll += New System.EventHandler(Me.trackBar2_Scroll)
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(18, 103)
			Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(59, 32)
			Me.label3.TabIndex = 4
			Me.label3.Text = "HKU"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(642, 103)
			Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(74, 32)
			Me.label4.TabIndex = 5
			Me.label4.Text = "100%"
			' 
			' trackBar3
			' 
			Me.trackBar3.LargeChange = 20
			Me.trackBar3.Location = New System.Drawing.Point(22, 220)
			Me.trackBar3.Margin = New System.Windows.Forms.Padding(4)
			Me.trackBar3.Maximum = 100
			Me.trackBar3.Name = "trackBar3"
			Me.trackBar3.Size = New System.Drawing.Size(678, 56)
			Me.trackBar3.SmallChange = 5
			Me.trackBar3.TabIndex = 3
			Me.trackBar3.TickFrequency = 5
			Me.trackBar3.Value = 2
'			Me.trackBar3.Scroll += New System.EventHandler(Me.trackBar3_Scroll)
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(18, 192)
			Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(74, 32)
			Me.label5.TabIndex = 4
			Me.label5.Text = "HKLM"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(642, 192)
			Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(44, 32)
			Me.label6.TabIndex = 5
			Me.label6.Text = "2%"
			' 
			' trackBar4
			' 
			Me.trackBar4.LargeChange = 20
			Me.trackBar4.Location = New System.Drawing.Point(20, 313)
			Me.trackBar4.Margin = New System.Windows.Forms.Padding(4)
			Me.trackBar4.Maximum = 100
			Me.trackBar4.Name = "trackBar4"
			Me.trackBar4.Size = New System.Drawing.Size(678, 56)
			Me.trackBar4.SmallChange = 5
			Me.trackBar4.TabIndex = 3
			Me.trackBar4.TickFrequency = 5
'			Me.trackBar4.Scroll += New System.EventHandler(Me.trackBar4_Scroll)
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New System.Drawing.Point(18, 285)
			Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(194, 32)
			Me.label7.TabIndex = 4
			Me.label7.Text = "delet chance"
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New System.Drawing.Point(642, 285)
			Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(44, 32)
			Me.label8.TabIndex = 5
			Me.label8.Text = "0%"
			' 
			' button2
			' 
			Me.button2.BackColor = System.Drawing.Color.Black
			Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button2.Font = New System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button2.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(192)))), (CInt((CByte(0)))))
			Me.button2.Location = New System.Drawing.Point(565, 443)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(135, 40)
			Me.button2.TabIndex = 6
			Me.button2.Text = "K"
			Me.button2.UseVisualStyleBackColor = False
'			Me.button2.Click += New System.EventHandler(Me.button2_Click)
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Location = New System.Drawing.Point(19, 382)
			Me.label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(74, 32)
			Me.label9.TabIndex = 4
			Me.label9.Text = "SEED"
			' 
			' textBox1
			' 
			Me.textBox1.BackColor = System.Drawing.Color.Black
			Me.textBox1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(128)))), (CInt((CByte(255)))), (CInt((CByte(128)))))
			Me.textBox1.Location = New System.Drawing.Point(85, 379)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(524, 38)
			Me.textBox1.TabIndex = 7
			Me.textBox1.Text = "fuck"
'			Me.textBox1.TextChanged += New System.EventHandler(Me.textBox1_TextChanged)
			' 
			' button1
			' 
			Me.button1.BackColor = System.Drawing.Color.Black
			Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button1.Font = New System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(192)))), (CInt((CByte(0)))))
			Me.button1.Location = New System.Drawing.Point(615, 379)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(87, 32)
			Me.button1.TabIndex = 6
			Me.button1.Text = "random"
			Me.button1.UseVisualStyleBackColor = False
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pictureBox1.Image = My.Resources.matrix
			Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
			Me.pictureBox1.Margin = New System.Windows.Forms.Padding(5)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(712, 497)
			Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox1.TabIndex = 0
			Me.pictureBox1.TabStop = False
			' 
			' Form4
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(14F, 31F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.Black
			Me.ClientSize = New System.Drawing.Size(712, 497)
			Me.Controls.Add(Me.textBox1)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.label8)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label9)
			Me.Controls.Add(Me.label7)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.trackBar4)
			Me.Controls.Add(Me.trackBar3)
			Me.Controls.Add(Me.trackBar2)
			Me.Controls.Add(Me.trackBar1)
			Me.Controls.Add(Me.pictureBox1)
			Me.Font = New System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(192)))), (CInt((CByte(0)))))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Margin = New System.Windows.Forms.Padding(5)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Form4"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "settingz"
			DirectCast(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.trackBar2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.trackBar3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.trackBar4, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private WithEvents trackBar1 As System.Windows.Forms.TrackBar
		Private WithEvents trackBar2 As System.Windows.Forms.TrackBar
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private WithEvents trackBar3 As System.Windows.Forms.TrackBar
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private WithEvents trackBar4 As System.Windows.Forms.TrackBar
		Private label7 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private WithEvents button2 As System.Windows.Forms.Button
		Private label9 As System.Windows.Forms.Label
		Private WithEvents button1 As System.Windows.Forms.Button
		Public WithEvents textBox1 As System.Windows.Forms.TextBox
	End Class
End Namespace