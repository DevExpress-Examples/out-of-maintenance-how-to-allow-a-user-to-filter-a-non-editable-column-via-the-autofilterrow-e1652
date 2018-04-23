Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim r As New Random()
			For i As Integer = 0 To 99
				dataTable1.Rows.Add(r.NextDouble()*100)
			Next i
		End Sub

		Private Sub gridView1_CustomRowCellEdit(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gridView1.CustomRowCellEdit
			If e.RowHandle <> GridControl.AutoFilterRowHandle Then
				e.RepositoryItem = repositoryItemProgressBar1
			End If
		End Sub
	End Class
End Namespace