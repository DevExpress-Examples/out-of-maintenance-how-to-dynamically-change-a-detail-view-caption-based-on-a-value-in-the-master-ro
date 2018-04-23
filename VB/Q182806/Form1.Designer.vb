Imports Microsoft.VisualBasic
Imports System
Namespace Q182806
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
			Me.components = New System.ComponentModel.Container()
			Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
			Dim gridLevelNode2 As New DevExpress.XtraGrid.GridLevelNode()
			Dim gridLevelNode3 As New DevExpress.XtraGrid.GridLevelNode()
			Me.gridView2 = New Q182806.MyGridView()
			Me.gridControl1 = New Q182806.MyGridControl()
			Me.usersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.issueListDataSet = New Q182806.IssueListDataSet()
			Me.gridView3 = New Q182806.MyGridView()
			Me.gridView4 = New Q182806.MyGridView()
			Me.gridView1 = New Q182806.MyGridView()
			Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colMiddleName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.usersTableAdapter = New Q182806.IssueListDataSetTableAdapters.UsersTableAdapter()
			Me.itemsTableAdapter1 = New Q182806.IssueListDataSetTableAdapters.ItemsTableAdapter()
			Me.projectsTableAdapter1 = New Q182806.IssueListDataSetTableAdapters.ProjectsTableAdapter()
			Me.schedulerTableAdapter1 = New Q182806.IssueListDataSetTableAdapters.SchedulerTableAdapter()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.usersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.issueListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.KeyFieldName = Nothing
			Me.gridView2.Name = "gridView2"
			Me.gridView2.ViewCaption = "Items"
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.usersBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			gridLevelNode1.LevelTemplate = Me.gridView2
			gridLevelNode1.RelationName = "USERSITEMS1"
			gridLevelNode2.LevelTemplate = Me.gridView3
			gridLevelNode2.RelationName = "USERSPROJECTS"
			gridLevelNode3.LevelTemplate = Me.gridView4
			gridLevelNode3.RelationName = "USERSSCHEDULER"
			Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1, gridLevelNode2, gridLevelNode3})
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(791, 576)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView3, Me.gridView4, Me.gridView1, Me.gridView2})
			' 
			' usersBindingSource
			' 
			Me.usersBindingSource.DataMember = "Users"
			Me.usersBindingSource.DataSource = Me.issueListDataSet
			' 
			' issueListDataSet
			' 
			Me.issueListDataSet.DataSetName = "IssueListDataSet"
			Me.issueListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView3
			' 
			Me.gridView3.GridControl = Me.gridControl1
			Me.gridView3.KeyFieldName = Nothing
			Me.gridView3.Name = "gridView3"
			Me.gridView3.ViewCaption = "Projects"
			' 
			' gridView4
			' 
			Me.gridView4.GridControl = Me.gridControl1
			Me.gridView4.KeyFieldName = Nothing
			Me.gridView4.Name = "gridView4"
			Me.gridView4.ViewCaption = "Shedules"
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colFirstName, Me.colMiddleName, Me.colLastName})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.KeyFieldName = "LastName"
			Me.gridView1.Name = "gridView1"
			' 
			' colID
			' 
			Me.colID.Caption = "ID"
			Me.colID.FieldName = "ID"
			Me.colID.Name = "colID"
			Me.colID.Visible = True
			Me.colID.VisibleIndex = 0
			' 
			' colFirstName
			' 
			Me.colFirstName.Caption = "FirstName"
			Me.colFirstName.FieldName = "FirstName"
			Me.colFirstName.Name = "colFirstName"
			Me.colFirstName.Visible = True
			Me.colFirstName.VisibleIndex = 1
			' 
			' colMiddleName
			' 
			Me.colMiddleName.Caption = "MiddleName"
			Me.colMiddleName.FieldName = "MiddleName"
			Me.colMiddleName.Name = "colMiddleName"
			Me.colMiddleName.Visible = True
			Me.colMiddleName.VisibleIndex = 2
			' 
			' colLastName
			' 
			Me.colLastName.Caption = "LastName"
			Me.colLastName.FieldName = "LastName"
			Me.colLastName.Name = "colLastName"
			Me.colLastName.Visible = True
			Me.colLastName.VisibleIndex = 3
			' 
			' usersTableAdapter
			' 
			Me.usersTableAdapter.ClearBeforeFill = True
			' 
			' itemsTableAdapter1
			' 
			Me.itemsTableAdapter1.ClearBeforeFill = True
			' 
			' projectsTableAdapter1
			' 
			Me.projectsTableAdapter1.ClearBeforeFill = True
			' 
			' schedulerTableAdapter1
			' 
			Me.schedulerTableAdapter1.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(791, 576)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.usersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.issueListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As MyGridControl
		Private gridView1 As MyGridView
		Private issueListDataSet As IssueListDataSet
		Private usersBindingSource As System.Windows.Forms.BindingSource
		Private usersTableAdapter As Q182806.IssueListDataSetTableAdapters.UsersTableAdapter
		Private colID As DevExpress.XtraGrid.Columns.GridColumn
		Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn
		Private colMiddleName As DevExpress.XtraGrid.Columns.GridColumn
		Private colLastName As DevExpress.XtraGrid.Columns.GridColumn
		Private gridView2 As MyGridView
		Private gridView3 As MyGridView
		Private gridView4 As MyGridView
		Private itemsTableAdapter1 As Q182806.IssueListDataSetTableAdapters.ItemsTableAdapter
		Private projectsTableAdapter1 As Q182806.IssueListDataSetTableAdapters.ProjectsTableAdapter
		Private schedulerTableAdapter1 As Q182806.IssueListDataSetTableAdapters.SchedulerTableAdapter
	End Class
End Namespace

