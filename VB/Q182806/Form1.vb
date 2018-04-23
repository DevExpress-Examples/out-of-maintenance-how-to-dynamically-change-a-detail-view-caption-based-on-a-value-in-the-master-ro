Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace Q182806
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'issueListDataSet.Users' table. You can move, or remove it, as needed.
			Me.usersTableAdapter.Fill(Me.issueListDataSet.Users)
			itemsTableAdapter1.Fill(issueListDataSet.Items)
			projectsTableAdapter1.Fill(issueListDataSet.Projects)
			schedulerTableAdapter1.Fill(issueListDataSet.Scheduler)
		End Sub
	End Class
End Namespace