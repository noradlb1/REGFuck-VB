Imports System
Imports System.Windows.Forms

Namespace RegFuck
	Partial Public Class Form3
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form3_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			label3.Text = "Seed: " & Form4.seed
		End Sub

		Private Sub Form3_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
			e.Cancel = True
		End Sub
	End Class
End Namespace
