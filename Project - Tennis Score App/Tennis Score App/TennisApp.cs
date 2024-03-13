namespace Tennis_Score_App
{
    public partial class Main : Form
    {
        private static Dictionary<string, int> playersWithPoints = new();
        private static Dictionary<(string, int), List<(string, int)>> games = new();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FillRankigListView();
            //FillLatesrGamesListView();
        }

        private void FillRankigListView()
        {
            this.LVRanking.Items.Clear();   
            foreach (var player in playersWithPoints.OrderBy(x => x.Value))
            {
                string playerName = player.Key;
                string playerPoints = player.Value.ToString();
                ListViewItem rollinRankingListView = new();

                rollinRankingListView.SubItems[0].Text = playerName;
                rollinRankingListView.SubItems.Add(playerPoints);
                this.LVRanking.Items.Add(rollinRankingListView);
            }
        }
        private static Dictionary<string, int> playersWithPoints = new()
        {
            {"R. Federer", 4},
            {"G. Dimitrov", 5},
            {"R. Nadal", 5}
        };
        private void FillLatesrGamesListView()
        {
            this.LVLatestGames.Items.Clear();
            foreach (var game in games.Remove())
            {
                foreach(var item in game.)
            }
        }
    }
}