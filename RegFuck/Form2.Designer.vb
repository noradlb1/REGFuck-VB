Namespace RegFuck
	Partial Public Class Form2
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form2))
			Me.progressBar1 = New System.Windows.Forms.ProgressBar()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' progressBar1
			' 
			Me.progressBar1.Location = New System.Drawing.Point(16, 15)
			Me.progressBar1.Margin = New System.Windows.Forms.Padding(4)
			Me.progressBar1.Name = "progressBar1"
			Me.progressBar1.Size = New System.Drawing.Size(779, 28)
			Me.progressBar1.TabIndex = 0
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pictureBox1.Image = My.Resources.hack
			Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
			Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(811, 466)
			Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox1.TabIndex = 1
			Me.pictureBox1.TabStop = False
			' 
			' Form2
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.ClientSize = New System.Drawing.Size(811, 466)
			Me.ControlBox = False
			Me.Controls.Add(Me.progressBar1)
			Me.Controls.Add(Me.pictureBox1)
			Me.DoubleBuffered = True
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Form2"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "pliz wait"
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.Form2_FormClosing)
'			Me.Load += New System.EventHandler(Me.Form2_Load)
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private progressBar1 As System.Windows.Forms.ProgressBar
		Private pictureBox1 As System.Windows.Forms.PictureBox
	End Class
End Namespace