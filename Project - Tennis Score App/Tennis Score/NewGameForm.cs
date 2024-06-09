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
    public partial class NewGameForm : Form
    {
        public NewGameForm()
        {
            InitializeComponent();
        }

        public (string, int) FirstPlayer { get; set; }
        public (string, int) SecondPlayer { get; set; }
        private void ButtonSaveGameClick(object sender, EventArgs e)
        {
            string firstPlayerName = textBoxFirstPlayerName.Text.Trim();
            int firstPlayerPoints = (int)NumericUpDownSecondPlayersPoints.Value;
            if (!CheckIfInputsAreValid())
            {
                ValidateChildren(ValidationConstraints.Enabled);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
        private bool CheckIfInputsAreValid() => !CheckIfPlayerNamesAreEmpty() && !CheckIfPlayerNamesAreSame();
        private bool CheckIfPlayerNamesAreEmpty() => string.IsNullOrEmpty(this.FirstPlayer.Item1) || string.IsNullOrEmpty(this.SecondPlayer.Item1);
        //private bool CheckIfPlayerNamesAreSame() =>

        private void LABFirstPlayer_Click(object sender, EventArgs e)
        {

        }

        private void LABVS_Click(object sender, EventArgs e)
        {

        }

        private void NewGameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
