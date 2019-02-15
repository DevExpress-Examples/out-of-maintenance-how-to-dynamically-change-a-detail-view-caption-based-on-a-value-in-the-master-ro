Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Tab
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Registrator
Imports System.Reflection
Imports DevExpress.XtraEditors

Namespace Q182806
    Public Class MyGridView
        Inherits GridView

        Public Sub New(ByVal control As GridControl)
            MyBase.New(control)
        End Sub

        Public Sub New()
            Me.New(Nothing)
        End Sub

        Protected Overrides ReadOnly Property ViewName() As String
            Get
                Return "MyGridView"
            End Get
        End Property


        Private keyFieldName_Renamed As String

        <Category(CategoryName.Data), DefaultValue(""), TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design"), Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", GetType(System.Drawing.Design.UITypeEditor))> _
        Public Property KeyFieldName() As String
            Get
                Return keyFieldName_Renamed
            End Get
            Set(ByVal value As String)
                keyFieldName_Renamed = value
            End Set
        End Property

        Protected Overrides Sub PopulateTabMasterData(ByVal tabControl As ViewTab, ByVal rowHandle As Integer)
            tabControl.Pages.Clear()
            MyBase.PopulateTabMasterData(tabControl, rowHandle)
            If keyFieldName_Renamed = String.Empty Then
                Return
            End If
            If GridControl.DefaultView.IsZoomedView Then
                ExtendTabCaption(tabControl,keyFieldName_Renamed, True)
            End If
        End Sub

        Private Sub ExtendTabCaption(ByVal tabControl As ViewTab, ByVal keyField As String, ByVal isForZoomed As Boolean)
            For Each page As ViewTabPage In tabControl.Pages
                If Not isForZoomed AndAlso page.Text.Contains(" for ") Then
                    page.Text = page.Text.Remove(page.Text.IndexOf(" for ", 0))
                Else
                    Dim view As MyGridView = CType(GridControl.FocusedView, MyGridView)
                    page.Text &= " for " & view.GetDataRow(0).GetParentRow(view.LevelName)(keyField).ToString()
                End If
            Next page
        End Sub

        Protected Overrides Sub ZoomView(ByVal prevView As BaseView)
            MyBase.ZoomView(prevView)
            CType(ParentView, MyGridView).MyPopulateTabMasterData(True, Me)
            TabControl.LayoutChanged()
        End Sub

        Public Sub MyPopulateTabMasterData(ByVal isViewZoomed As Boolean, ByVal view As BaseView)
            Dim fi As FieldInfo = GetType(BaseView).GetField("tabControl", BindingFlags.Instance Or BindingFlags.NonPublic)
            Dim tab As ViewTab = DirectCast(fi.GetValue(view), ViewTab)
            ExtendTabCaption(tab, CStr(CType(GridControl.MainView, MyGridView).keyFieldName_Renamed), isViewZoomed)
        End Sub

        Public Overrides Sub NormalView()
            MyBase.NormalView()
            CType(ParentView, MyGridView).MyPopulateTabMasterData(False, Me)
            TabControl.LayoutChanged()
        End Sub
    End Class

    Public Class MyGridInfoRegistrator
        Inherits GridInfoRegistrator

        Public Sub New()
            MyBase.New()
        End Sub

        Public Overrides ReadOnly Property ViewName() As String
            Get
                Return "MyGridView"
            End Get
        End Property

        Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
            Return New MyGridView(grid)
        End Function
    End Class

    Public Class MyGridControl
        Inherits GridControl

        Public Sub New()
            MyBase.New()
        End Sub

        Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
            MyBase.RegisterAvailableViewsCore(collection)
            collection.Add(New MyGridInfoRegistrator())
        End Sub
    End Class
End Namespace
