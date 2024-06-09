namespace Tennis_Score
{
    public partial class FormScoreForm : Form
    {
        private static Dictionary<string, int> playerWithPoints = new()
        {
            { ("G. Dimitrov", 3), new List<(string, int)>{("R. Nadal", 2)} },
            { ("R. Nadal", 3), new List<(string, int)>{("R.Federer", 1)} },
            { ("G. Dimitrov", 2), new List<(string, int)>{("R. Federer", 3)} }
        };
        private static Dictionary<(string, int), List<(string, int)>> game = new();
        public FormScoreForm()
        {
            InitializeComponent();
        }

        private void OnLand (object sender, EventArgs e)
        {
            FillRankingListView();
            //FillLatestGamesListView();
        }
        private void FillRankingListView()
        {
            this.listViewRanking.Items.Clear();
            foreach (var player in playerWithPoints.OrderByDescending(x => x.Value))
            {
                string playerName = player.Key;
                string playerPoints = player.Value.ToString();

                ListViewItem rollInRankingListView = new();

                rollInRankingListView.SubItems[0].Text = playerName;
                rollInRankingListView.SubItems.Add(playerPoints);

                this.listViewRanking.Items.Add(rollInRankingListView);
            }
        }

        private void FillLatstGamesListView()
        {
            this.listViewLastGame.Items.Clear();
            foreach(var game in game.Reverse())
            {
                foreach(var item in game.Value)
                {
                    FillListView(game.Key, item);
                }
            }
        }
        private void AddNewGAme((string, int) firstPlayer, (string, int) secondPlayer)
        {
            //FillGammsData(firstPlayer, secondPlayer);

            //FillPlayerWithPoins(firstPlayer);
            //FillPlayerWithPoins(secondPlayer);

            FillRankingListView();
            FillLatstGamesListView();
        }
        private void FillListView((string, int) firstPlayer, (string, int) secondPlayer)
        {
            string winner = GetWinner(firstPlayer, secondPlayer);

            ListViewItem rollInLastestGamesListView = new ListViewItem();

            rollInLastestGamesListView.SubItems[0].Text = firstPlayer.Item1;
            rollInLastestGamesListView.SubItems.Add(secondPlayer.Item1);
            rollInLastestGamesListView.SubItems.Add(winner);
            rollInLastestGamesListView.SubItems.Add($"{firstPlayer.Item2} - {secondPlayer.Item2}");

            this.listViewLastGame.Items.Add(rollInLastestGamesListView);
        }
        private string GetWinner((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if(firstPlayer.Item2 > secondPlayer.Item2)
            {
                return firstPlayer.Item1;
            }
            else if(firstPlayer.Item2 < secondPlayer.Item2)
            {
                return secondPlayer.Item1;
            }
            return "Draw";
        }
        private void AddNewGameButtonClick(object sender, EventArgs e)
        {
            using (NewGameForm newGameForm = new NewGameForm())
            {
                if(newGameForm.ShowDialog() == DialogResult.OK)
                {
                    AddNewGame
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
