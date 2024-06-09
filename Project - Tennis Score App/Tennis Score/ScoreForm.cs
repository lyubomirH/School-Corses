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
        private static Dictionary<(string, int), List<(string, int)>> games = new();
        public FormScoreForm()
        {
            InitializeComponent();
        }

        private void OnLand (object sender, EventArgs e)
        {
            FillRankingListView();
            FillLatestGamesListView();
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
            foreach(var game in games.Reverse())
            {
                foreach(var item in game.Value)
                {
                    FillListView(game.Key, item);
                }
            }
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
                    AddNewGame(newGameForm.FirstPlayer, newGameForm.SecondPlayer);
                }
            }
        }
        private void AddNewGame((string, int) firstPlayer, (string, int) secondPlayer)
        {
            FillGamesData(firstPlayer, secondPlayer);

            FillPlayerWithPoints(firstPlayer);
            FillPlayerWithPoints(secondPlayer);

            FillRankingListView();
            FillLatstGamesListView();
        }
        private void FillGamesData((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (games.ContainsKey(firstPlayer))
            {
                games[firstPlayer].Add(secondPlayer);
            }
            else if (games.ContainsKey(secondPlayer))
            {
                games[secondPlayer].Add(firstPlayer);
            }
            else
            {
                games.Add(firstPlayer, new List<(string, int)> { secondPlayer });
            }
        }
        private void FillPlayerWithPoints((string, int) player)
        {
            if (playerWithPoints.ContainsKey(player.Item1))
            {
                playerWithPoints[player.Item1] = player.Item2;
            }
            else
            {
                playerWithPoints.Add(player.Item1, player.Item2);
            }
        }
        private void ViewProFileButtonClick(object sender, EventArgs e)
        {
            ListViewItem selectedRow = this.listViewRanking.SelectedItems[0];

            ListViewSubItem playerNameCell = selectedRow.SubItems[0];

            string playerName = playerNameCell.Text;

            using (PlayerInfoForm playerInfoForm = new PlayerInfoForm(playerName, GetPlayerGames(playerName)))
            {
                playerInfoForm.ShowDialog();
            }
        }
        private Dictionary<(string, int), List<(string, int)>> GetPlayerGames(string playerName) => games.Where(x => x.Key.Item1 == playerName).ToDictionary(x => x.Key, x => x.Value.Where(y => y.Item1 == playerName || x.Key.Item1 == playerName).ToList());

        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
