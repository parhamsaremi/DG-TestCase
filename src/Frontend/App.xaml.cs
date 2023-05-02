namespace Frontend;

public partial class App : Application
{
    internal static string DefaultDateTimeFormat = "dddd, dd/MMM/yyyy HH:mm";
    public App()
    {
        InitializeComponent();

        Page mainPage = new EventPage();
        MainPage = new NavigationPage(mainPage);
    }

}
