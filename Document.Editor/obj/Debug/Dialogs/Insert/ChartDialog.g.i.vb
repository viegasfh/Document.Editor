﻿#ExternalChecksum("..\..\..\..\Dialogs\Insert\ChartDialog.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","6A470FB39048A6CA397548C263D52955")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Fluent
Imports Microsoft.Windows.Controls
Imports Microsoft.Windows.Controls.Primitives
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.DataVisualization.Charting
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell


'''<summary>
'''ChartDialog
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class ChartDialog
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\ChartDialog.xaml",7)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ChartTypeComboBox As Fluent.ComboBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\ChartDialog.xaml",11)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ChartTitleTextBox As Fluent.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\ChartDialog.xaml",13)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ForegroundColorGallery As Fluent.ColorGallery
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\ChartDialog.xaml",16)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents BackgroundColorGallery As Fluent.ColorGallery
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\ChartDialog.xaml",18)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ChartHight As Fluent.Spinner
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\ChartDialog.xaml",19)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ChartWidth As Fluent.Spinner
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\ChartDialog.xaml",21)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents SeriesTitleTextBox As Fluent.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\ChartDialog.xaml",24)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents AddItemButton As Fluent.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\ChartDialog.xaml",25)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents RemoveItemButton As Fluent.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\ChartDialog.xaml",27)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ItemsListBox As System.Windows.Controls.ListBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\ChartDialog.xaml",28)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ItemTitleTextBox As Fluent.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\ChartDialog.xaml",29)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ItemValueBox As Fluent.Spinner
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\ChartDialog.xaml",33)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ChartViewer As System.Windows.Controls.ScrollViewer
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\ChartDialog.xaml",34)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents PreviewCanvas As System.Windows.Controls.Canvas
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\ChartDialog.xaml",35)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents PreviewChart As System.Windows.Controls.DataVisualization.Charting.Chart
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\ChartDialog.xaml",37)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ColumnSeries As System.Windows.Controls.DataVisualization.Charting.ColumnSeries
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\ChartDialog.xaml",38)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents PieSeries As System.Windows.Controls.DataVisualization.Charting.PieSeries
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\ChartDialog.xaml",43)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents OKButton As Fluent.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Dialogs\Insert\ChartDialog.xaml",48)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents CancelButton As Fluent.Button
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/Document.Editor;component/dialogs/insert/chartdialog.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\..\..\Dialogs\Insert\ChartDialog.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            Me.ChartTypeComboBox = CType(target,Fluent.ComboBox)
            Return
        End If
        If (connectionId = 2) Then
            Me.ChartTitleTextBox = CType(target,Fluent.TextBox)
            Return
        End If
        If (connectionId = 3) Then
            Me.ForegroundColorGallery = CType(target,Fluent.ColorGallery)
            Return
        End If
        If (connectionId = 4) Then
            Me.BackgroundColorGallery = CType(target,Fluent.ColorGallery)
            Return
        End If
        If (connectionId = 5) Then
            Me.ChartHight = CType(target,Fluent.Spinner)
            Return
        End If
        If (connectionId = 6) Then
            Me.ChartWidth = CType(target,Fluent.Spinner)
            Return
        End If
        If (connectionId = 7) Then
            Me.SeriesTitleTextBox = CType(target,Fluent.TextBox)
            Return
        End If
        If (connectionId = 8) Then
            Me.AddItemButton = CType(target,Fluent.Button)
            Return
        End If
        If (connectionId = 9) Then
            Me.RemoveItemButton = CType(target,Fluent.Button)
            Return
        End If
        If (connectionId = 10) Then
            Me.ItemsListBox = CType(target,System.Windows.Controls.ListBox)
            Return
        End If
        If (connectionId = 11) Then
            Me.ItemTitleTextBox = CType(target,Fluent.TextBox)
            Return
        End If
        If (connectionId = 12) Then
            Me.ItemValueBox = CType(target,Fluent.Spinner)
            Return
        End If
        If (connectionId = 13) Then
            Me.ChartViewer = CType(target,System.Windows.Controls.ScrollViewer)
            Return
        End If
        If (connectionId = 14) Then
            Me.PreviewCanvas = CType(target,System.Windows.Controls.Canvas)
            Return
        End If
        If (connectionId = 15) Then
            Me.PreviewChart = CType(target,System.Windows.Controls.DataVisualization.Charting.Chart)
            Return
        End If
        If (connectionId = 16) Then
            Me.ColumnSeries = CType(target,System.Windows.Controls.DataVisualization.Charting.ColumnSeries)
            Return
        End If
        If (connectionId = 17) Then
            Me.PieSeries = CType(target,System.Windows.Controls.DataVisualization.Charting.PieSeries)
            Return
        End If
        If (connectionId = 18) Then
            Me.OKButton = CType(target,Fluent.Button)
            Return
        End If
        If (connectionId = 19) Then
            Me.CancelButton = CType(target,Fluent.Button)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class
