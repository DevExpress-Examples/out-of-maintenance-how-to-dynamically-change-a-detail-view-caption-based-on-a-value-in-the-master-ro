using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System.ComponentModel;
using DevExpress.XtraGrid.Tab;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Registrator;
using System.Reflection;
using DevExpress.XtraEditors;

namespace Q182806
{
    public class MyGridView : GridView
    {
        public MyGridView(GridControl control) : base(control) { }

        public MyGridView() : this(null) { }

        protected override string ViewName { get { return "MyGridView"; } }

        private string keyFieldName;

        [Category(CategoryName.Data), DefaultValue(""),
    		TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design"),
    		Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", typeof(System.Drawing.Design.UITypeEditor))]
        public string KeyFieldName
        {
            get { return keyFieldName; }
            set { keyFieldName = value; }
        }

        protected override void PopulateTabMasterData(ViewTab tabControl, int rowHandle)
        {
            tabControl.Pages.Clear();
            base.PopulateTabMasterData(tabControl, rowHandle);
            if (keyFieldName == string.Empty) return;
            if (GridControl.DefaultView.IsZoomedView)
            {
                ExtendTabCaption(tabControl,keyFieldName, true);
            }
        }

        private void ExtendTabCaption(ViewTab tabControl, string keyField, bool isForZoomed)
        {
            foreach (ViewTabPage page in tabControl.Pages)
            {
                if (!isForZoomed && page.Text.Contains(" for "))
                    page.Text = page.Text.Remove(page.Text.IndexOf(" for ", 0));
                else
                {
                    MyGridView view = (MyGridView)GridControl.FocusedView;
                    page.Text += " for " + view.GetDataRow(0).GetParentRow(view.LevelName)[keyField].ToString();
                }
            }
        }

        protected override void ZoomView(BaseView prevView)
        {
            base.ZoomView(prevView);
            ((MyGridView)ParentView).MyPopulateTabMasterData(true, this);
            TabControl.LayoutChanged();
        }

        public void MyPopulateTabMasterData(bool isViewZoomed, BaseView view)
        {
            FieldInfo fi = typeof(BaseView).GetField("tabControl", BindingFlags.Instance | BindingFlags.NonPublic);
            ViewTab tab = (ViewTab)fi.GetValue(view);
            ExtendTabCaption(tab, (string)((MyGridView)GridControl.MainView).keyFieldName, isViewZoomed);
        }

        public override void NormalView()
        {
            base.NormalView();
            ((MyGridView)ParentView).MyPopulateTabMasterData(false, this);
            TabControl.LayoutChanged();
        }
    }

    public class MyGridInfoRegistrator : GridInfoRegistrator
    {
        public MyGridInfoRegistrator() : base() { }

        public override string ViewName { get { return "MyGridView"; } }

        public override BaseView CreateView(GridControl grid) { return new MyGridView(grid); }
    }

    public class MyGridControl : GridControl
    {
        public MyGridControl() : base() { }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridInfoRegistrator());
        }
    }
}
