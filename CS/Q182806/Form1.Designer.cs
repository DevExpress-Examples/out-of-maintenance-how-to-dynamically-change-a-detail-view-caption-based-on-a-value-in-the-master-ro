namespace Q182806
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new Q182806.MyGridView();
            this.gridControl1 = new Q182806.MyGridControl();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issueListDataSet = new Q182806.IssueListDataSet();
            this.gridView3 = new Q182806.MyGridView();
            this.gridView4 = new Q182806.MyGridView();
            this.gridView1 = new Q182806.MyGridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.usersTableAdapter = new Q182806.IssueListDataSetTableAdapters.UsersTableAdapter();
            this.itemsTableAdapter1 = new Q182806.IssueListDataSetTableAdapters.ItemsTableAdapter();
            this.projectsTableAdapter1 = new Q182806.IssueListDataSetTableAdapters.ProjectsTableAdapter();
            this.schedulerTableAdapter1 = new Q182806.IssueListDataSetTableAdapters.SchedulerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.KeyFieldName = null;
            this.gridView2.Name = "gridView2";
            this.gridView2.ViewCaption = "Items";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.usersBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "USERSITEMS1";
            gridLevelNode2.LevelTemplate = this.gridView3;
            gridLevelNode2.RelationName = "USERSPROJECTS";
            gridLevelNode3.LevelTemplate = this.gridView4;
            gridLevelNode3.RelationName = "USERSSCHEDULER";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2,
            gridLevelNode3});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(791, 576);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3,
            this.gridView4,
            this.gridView1,
            this.gridView2});
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.issueListDataSet;
            // 
            // issueListDataSet
            // 
            this.issueListDataSet.DataSetName = "IssueListDataSet";
            this.issueListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.KeyFieldName = null;
            this.gridView3.Name = "gridView3";
            this.gridView3.ViewCaption = "Projects";
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gridControl1;
            this.gridView4.KeyFieldName = null;
            this.gridView4.Name = "gridView4";
            this.gridView4.ViewCaption = "Shedules";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFirstName,
            this.colMiddleName,
            this.colLastName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.KeyFieldName = "LastName";
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "FirstName";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            // 
            // colMiddleName
            // 
            this.colMiddleName.Caption = "MiddleName";
            this.colMiddleName.FieldName = "MiddleName";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.Visible = true;
            this.colMiddleName.VisibleIndex = 2;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "LastName";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 3;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // itemsTableAdapter1
            // 
            this.itemsTableAdapter1.ClearBeforeFill = true;
            // 
            // projectsTableAdapter1
            // 
            this.projectsTableAdapter1.ClearBeforeFill = true;
            // 
            // schedulerTableAdapter1
            // 
            this.schedulerTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 576);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyGridControl gridControl1;
        private MyGridView gridView1;
        private IssueListDataSet issueListDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Q182806.IssueListDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colMiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private MyGridView gridView2;
        private MyGridView gridView3;
        private MyGridView gridView4;
        private Q182806.IssueListDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter1;
        private Q182806.IssueListDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter1;
        private Q182806.IssueListDataSetTableAdapters.SchedulerTableAdapter schedulerTableAdapter1;
    }
}

