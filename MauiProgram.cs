using SimpleLoginUI.ViewModels;
using SimpleLoginUI.ViewModels.Dashboard;
using SimpleLoginUI.ViewModels.Startup;
using SimpleLoginUI.Views.Dashboard;
using SimpleLoginUI.Views.Startup;

namespace SimpleLoginUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        // Services
        builder.Services.AddSingleton<IStudentService, StudentService>();

        //Views
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<DashboardPage>();
        builder.Services.AddSingleton<LoadingPage>();
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<StudentListPage>();
        builder.Services.AddTransient<AddUpdateStudentDetail>();
        builder.Services.AddTransient<StudentDetailsPage>();

        //View Models
        builder.Services.AddSingleton<LoginPageViewModel>();
        builder.Services.AddSingleton<DashboardPageViewModel>();
        builder.Services.AddSingleton<LoadingPageViewModel>();
        builder.Services.AddSingleton<StudentListPageViewModel>();
        builder.Services.AddTransient<AddUpdateStudentDetailViewModel>();
        builder.Services.AddTransient<StudentDetailsViewModel>();
        builder.Services.AddTransient<LoginPageViewModel>();
        return builder.Build();
	}
}
