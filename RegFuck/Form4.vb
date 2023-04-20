Imports System
Imports System.Windows.Forms

Namespace RegFuck
	Partial Public Class Form4
		Inherits Form

		Public Shared hkcr As Double = 0.05
		Public Shared hku As Double = 1.0
		Public Shared hklm As Double = 0.0
		Public Shared del As Double = 0.05

		Public Shared seed As Integer = (New Random()).Next()

		Public Sub New()
			InitializeComponent()

			textBox1.Text = seed.ToString()

			trackBar1.Value = CInt(Math.Truncate(hkcr * 100))
			label2.Text = trackBar1.Value & "%"

			trackBar2.Value = CInt(Math.Truncate(hku * 100))
			label4.Text = trackBar2.Value & "%"

			trackBar3.Value = CInt(Math.Truncate(hklm * 100))
			label6.Text = trackBar3.Value & "%"

			trackBar4.Value = CInt(Math.Truncate(del * 100))
			label8.Text = trackBar4.Value & "%"
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			Close()
		End Sub

		Private Sub trackBar1_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles trackBar1.Scroll
			hkcr = trackBar1.Value / 100.0
			label2.Text = trackBar1.Value & "%"
		End Sub

		Private Sub trackBar2_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles trackBar2.Scroll
			hku = trackBar2.Value / 100.0
			label4.Text = trackBar2.Value & "%"
		End Sub

		Private Sub trackBar3_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles trackBar3.Scroll
			hklm = trackBar3.Value / 100.0
			label6.Text = trackBar3.Value & "%"
		End Sub

		Private Sub trackBar4_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles trackBar4.Scroll
			del = trackBar4.Value / 100.0
			label8.Text = trackBar4.Value & "%"
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			textBox1.Text = (New Random()).Next().ToString()
		End Sub

		Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textBox1.TextChanged
			If Not Integer.TryParse(textBox1.Text, seed) Then
				seed = textBox1.Text.GetHashCode()
			End If
		End Sub
	End Class
End Namespace
