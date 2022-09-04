using SimpleLoginUI.Models;
using SimpleLoginUI.ViewModels;
using SimpleLoginUI.Views.Dashboard;

namespace SimpleLoginUI;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        this.BindingContext = new AppShellViewModel();
        Routing.RegisterRoute(nameof(AddUpdateStudentDetail), typeof(AddUpdateStudentDetail));
        Routing.RegisterRoute(nameof(StudentDetailsPage), typeof(StudentDetailsPage));
        Routing.RegisterRoute(nameof(StudentListPage), typeof(StudentListPage));
    }
}
