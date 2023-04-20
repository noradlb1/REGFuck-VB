Imports System
Imports System.Windows.Forms

Namespace RegFuck
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Hide()
			CType(New Form2(Math.Pow(2, (trackBar1.Value / (100.0 / 12)) - 12)), Form2).ShowDialog()
		End Sub

		Private Sub trackBar1_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles trackBar1.Scroll
			label3.Text = String.Format("{0:F2}%", Math.Pow(2, (trackBar1.Value / (100.0/12))-12)*100)
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			label3.Text = String.Format("{0:F2}%", Math.Pow(2, (trackBar1.Value / (100.0 / 12)) - 12) * 100)
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			CType(New Form4(), Form4).ShowDialog()
		End Sub
	End Class
End Namespace
