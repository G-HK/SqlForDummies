using Syncfusion.Licensing;
using System.Windows;
namespace SqlForDummies;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        // Register Syncfusion license
        SyncfusionLicenseProvider.RegisterLicense("");
        base.OnStartup(e);
    }
}
