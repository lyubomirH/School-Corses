using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennis_Score
{
    public partial class PlayerInfoForm : Form
    {
        private string playerName;
        private Dictionary<(string, int), List<(string, int)>> games = new();
        private (string, int) currentPlayer = new();
        private (string, int) competiter = new();

        public PlayerInfoForm(string playerName, Dictionary<(string, int), List<(string, int)>> games)
        {
            InitializeComponent();
            
            this.games = games;
            this.playerName = playerName;

            this.LABPlayerName.Text = playerName;

            FillVictoriesAndLossesListViews();
        }
        private void FillVictoriesAndLossesListViews()
        {
            ClearListViews();
            foreach(var game in games)
            {
                string firstPlayerName = game.Key.Item1;
                int firstPlayerPointns = game.Key.Item2;
                foreach(var item in game.Value)
                {
                    string secondPlayerName = item.Item1;
                    int secondPlayerPoints = item.Item2;
                     (this.currentPlayer,this.competiter) = 
                       GetCurrentPlayerAndCompetitor((firstPlayerName, firstPlayerPointns),
                       (secondPlayerName, secondPlayerPoints));
                    UpdeteListView();
                }
            }
        }

        private void ClearListViews()
        {
            this.listViewDraw.Items.Clear();
            this.listViewLosses.Items.Clear();
            this.listViewVictories.Items.Clear();
        }
        private ((string, int), (string, int)) GetCurrentPlayerAndCompetitor((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if(firstPlayer.Item1 == playerName)
            {
                return (firstPlayer, secondPlayer);
            }
            return (secondPlayer, firstPlayer);
        }
        private void UpdeteListView()
        {
            string competitoeName = competiter.Item1;
            int currentPlayerPoints = currentPlayer.Item2;
            int competitorPoits = competiter.Item2;
            string score = $"{currentPlayerPoints} - {competitorPoits}";

            ListView currentListView = GetCurrentListView(currentPlayerPoints, competitorPoits);
            AddDataToListView(competitoeName, score,currentListView);
        }
        private ListView GetCurrentListView(int currentPlayerPoints, int competitorPoints)
        {
            if (currentPlayerPoints > competitorPoints)
            {
                return this.listViewVictories;
            }
            if (currentPlayerPoints < competitorPoints)
            {
                return this.listViewLosses;
            }
            return this.listViewDraw;
        }
        private void AddDataToListView(string competitor, string score, ListView listView)
        {
            ListViewItem listViewItem = new ListViewItem();

            listViewItem.SubItems[0].Text = competitor;
            listViewItem.SubItems.Add(score);
            listView.Items.Add(listViewItem);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
