namespace StressReliefMiniGames
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(BubbleWrapPop), typeof(BubbleWrapPop));
            Routing.RegisterRoute(nameof(ConnectingDots), typeof(ConnectingDots));
            Routing.RegisterRoute(nameof(RedOrBluePill), typeof(RedOrBluePill));
        }
    }
}
