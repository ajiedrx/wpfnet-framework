// ReSharper disable InvalidXmlDocComment
/// <summary>
/// This packages contains UI Elements related.
/// </summary>
/// <remarks>
/// Usage guide : 
/// <list type="number">
/// <item>Change the root of the xaml to MyWindow or MyUserControl</item>
/// <code>
/// <basic:MyWindow>
/// </MyWindow>
/// </code>
/// <item>Add the basic namespace into xaml</item>
/// <code>
/// <basic:MyWindow
///        xmlns:basic="clr-namespace:MyFramework.basic"
///        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
///        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
///        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
///        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
///        xmlns:barchart="clr-namespace:MyFramework.chart.barchart"
///        x:Class="MyFramework.MainWindow"
///        mc:Ignorable="d"
///        Title="MainWindow" Height="752.804" Width="1154.673">
///   <Grid Margin = "0,0,-275,-165" >
///   </Grid>
/// </MyWindow>
/// </code>
/// <item>Drag the UI Element from Visual Studio Toolbox</item>
/// <item>Give property name (Name=" ") to the dragged UI Element in XAML Components.</item>
/// <code>
/// <Button x:Name="testButton_btn" Content="Button" HorizontalAlignment="Left"/>
/// </code>
/// <item>Instansiate the builder.</item>
/// <item>Use the builder with the UIElements.</item>
/// <item>For more detailed Builder usage, please refer to packages documentations.</item>
/// </list>
/// </remarks>

namespace Velacro{
    /// <summary>
    /// This is MyFramework
    /// </summary>

    /// <summary>
    /// This packages contains Charts related.
    /// </summary>
    /// <remarks>
    /// Usage guide : 
    /// <list type="number">
    /// <item>Change the root of the xaml to MyWindow or MyUserControl</item>
    /// <code>
    /// <basic:MyWindow>
    /// </MyWindow>
    /// </code>
    /// <item>Add the basic namespace into xaml</item>
    /// <code>
    /// <basic:MyWindow
    ///        xmlns:basic="clr-namespace:MyFramework.basic"
    ///        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    ///        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    ///        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    ///        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    ///        xmlns:barchart="clr-namespace:MyFramework.chart.barchart"
    ///        x:Class="MyFramework.MainWindow"
    ///        mc:Ignorable="d"
    ///        Title="MainWindow" Height="752.804" Width="1154.673">
    ///   <Grid Margin = "0,0,-275,-165" >
    ///   </Grid>
    /// </MyWindow>
    /// </code>
    /// <item>Drag the Charts from Visual Studio Toolbox</item>
    /// <item>Give property name (x:Name=" ") to the dragged Chart in XAML Components.</item>
    /// <code>
    /// <Button x:Name="barChart_bc" HorizontalAlignment="Left"/>
    /// </code>
    /// <item>Instansiate the builder.</item>
    /// <item>Use the builder with the Charts.</item>
    /// <item>For more detailed Builder usage, please refer to packages documentations.</item>
    /// </list>
    /// </remarks>
}