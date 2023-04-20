Imports System
Imports System.Windows.Forms

Namespace RegFuck
	Friend NotInheritable Class Program

		Private Sub New()
		End Sub

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)

			If MessageBox.Show("This program was made to destroy the registry of your computer." & ControlChars.Lf & "Using it will likely make your computer unbootable or unusable." & ControlChars.Lf & "The GUI of this program was made intentionally bad, if you don't know what you do, don't continue." & ControlChars.Lf & ControlChars.Lf & "You have been warned. Clicking Yes will start the program now.", "REGFuck - Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
				Application.Run(New Form1())
			End If
		End Sub
	End Class
End Namespace
