namespace Tennis_Score
{
    public partial class FormScoreForm : Form
    {
        private static Dictionary<string, int> playerWithPoints = new()
        {
            { "R. Federer", 4 },
            { "G. dimitrov", 5},
            { "R. Nadal", 5}
        };
        private static Dictionary<(string, int), List<(string, int)>> game = new();
        public FormScoreForm()
        {
            InitializeComponent();
        }

        private void OnLand (object sender, EventArgs e)
        {
            //FillRankingListView();
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
                    //FillListView(game.Key, item);
                }
            }
        }
        private void FillListView((string, int) firstPlayer, (string, int) secondPlayer)
        {
            //string winner = GetWinner(firstPlayer, secondPlayer);

            ListViewItem rollInLastestGamesListView = new ListViewItem();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
