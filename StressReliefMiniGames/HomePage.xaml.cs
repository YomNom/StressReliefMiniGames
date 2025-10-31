namespace StressReliefMiniGames;

public partial class HomePage : ContentPage
{
	public List<GameClass> gameList = new List<GameClass>
	{
		new GameClass { Name = "Bubble Wrap Pop", Caption = "Tap. Dot. Repeat.", Route = "BubbleWrapPop"},
		new GameClass { Name = "Connecting Dots", Caption = "Match and Clear Your Mind", Route = "ConnectingDots"},
		new GameClass { Name = "Red or Blue Pill", Caption = "Choose Your Path", Route = "RedOrBluePill"}
    };
	public HomePage()
	{
		InitializeComponent();
		GamesCV.ItemsSource = gameList;
    }

	private async void GameCV_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		var selectedGame = e.CurrentSelection.FirstOrDefault() as GameClass;
		if (selectedGame != null)
		{
			await Shell.Current.GoToAsync(selectedGame.Route);
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}