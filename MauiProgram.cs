namespace SimpleLoginUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        #region Building & Fonts
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
        #endregion

        #region Services
        // Services
        builder.Services.AddSingleton<IStudentService, StudentService>();
        builder.Services.AddSingleton<ITajjarService, TajjarService>();
        #endregion

        #region Views
        //Base
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<DashboardPage>();
        builder.Services.AddSingleton<LoadingPage>();
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<MainPage>();

        // Student
        builder.Services.AddSingleton<StudentListPage>();
        builder.Services.AddTransient<AddUpdateStudentDetail>();
        builder.Services.AddTransient<StudentDetailsPage>();

        // Postings
        builder.Services.AddSingleton<PostingListPage>();
        builder.Services.AddTransient<AddUpdatePostingDetail>();
        builder.Services.AddTransient<PostingDetailsPage>();

        // Bids
        builder.Services.AddSingleton<BidListPage>();
        builder.Services.AddTransient<AddUpdateBidDetail>();
        builder.Services.AddTransient<BidDetailsPage>();
        #endregion

        #region View Models
        // Base
        builder.Services.AddSingleton<LoginPageViewModel>();
        builder.Services.AddSingleton<DashboardPageViewModel>();
        builder.Services.AddSingleton<LoadingPageViewModel>();
        builder.Services.AddTransient<LoginPageViewModel>();

        // Student
        builder.Services.AddSingleton<StudentListPageViewModel>();
        builder.Services.AddTransient<AddUpdateStudentDetailViewModel>();
        builder.Services.AddTransient<StudentDetailsViewModel>();

        // Posting
        builder.Services.AddSingleton<PostingListPageViewModel>();
        builder.Services.AddTransient<AddUpdatePostingDetailViewModel>();
        builder.Services.AddTransient<PostingDetailsViewModel>();

        // Bid
        builder.Services.AddSingleton<BidListPageViewModel>();
        builder.Services.AddTransient<AddUpdateBidDetailViewModel>();
        builder.Services.AddTransient<BidDetailsViewModel>();
        #endregion

        #region Build
        return builder.Build();
        #endregion

    }
}
