//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("SWIM.Views.UsagePage.xaml", "Views/UsagePage.xaml", typeof(global::SWIM.Views.UsagePage))]

namespace SWIM.Views {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\UsagePage.xaml")]
    public partial class UsagePage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.SfChart.XForms.SfChart barChart;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.SfChart.XForms.NumericalAxis yAxis;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.SfChart.XForms.ColumnSeries chartSeries;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(UsagePage));
            barChart = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.SfChart.XForms.SfChart>(this, "barChart");
            yAxis = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.SfChart.XForms.NumericalAxis>(this, "yAxis");
            chartSeries = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.SfChart.XForms.ColumnSeries>(this, "chartSeries");
        }
    }
}
