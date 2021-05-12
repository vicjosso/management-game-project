using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseSim2021
{
    public partial class GameView : Form
    {
        private readonly WorldState theWorld;
        /// <summary>
        /// The constructor for the main window
        /// </summary>
        public GameView(WorldState world)
        {
            InitializeComponent();
            theWorld = world;
        }
        /// <summary>
        /// Method called by the controler whenever some text should be displayed
        /// </summary>
        /// <param name="s"></param>
        public void WriteLine(string s)
        {
            List<string> strs = s.Split('\n').ToList();
            strs.ForEach(str=>outputListBox.Items.Add(str));
            if (outputListBox.Items.Count > 0)
            {
                outputListBox.SelectedIndex = outputListBox.Items.Count - 1;
            }
            outputListBox.Refresh();
        }
        /// <summary>
        /// Method called by the controler whenever a confirmation should be asked
        /// </summary>
        /// <returns>Yes iff confirmed</returns>
        public bool ConfirmDialog()
        {
            string message = "Confirmer ?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            return MessageBox.Show(message, "", buttons) == DialogResult.Yes;
        }
        #region Event handling
        private void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                e.SuppressKeyPress = true; // Or beep.
                GameController.Interpret(inputTextBox.Text);
            }
        }

        private void GameView_Paint(object sender, PaintEventArgs e)
        {
            diffLabel.Text = "Difficulté : " + theWorld.TheDifficulty;
            turnLabel.Text = "Tour " + theWorld.Turns;
            moneyLabel.Text = "Trésor : " + theWorld.Money + " pièces d'or";
            gloryLabel.Text = "Gloire : " + theWorld.Glory;
            
            nextButton.Visible = true;

            //rajouter le draw des indexed values
            //barre
            Rectangle barre = new Rectangle(new Point(0, 0), new Size(Width, Height / 20));
            e.Graphics.DrawRectangle(new Pen(Color.Black), barre);
            
            //benef
            Rectangle benef = new Rectangle(new Point(0, Height / 20), new Size(Width, Height/3 - Height/20));
            e.Graphics.DrawRectangle(new Pen(Color.Black), benef);
            
            //3 trucs
            Rectangle trucs1 = new Rectangle(new Point(0, Height/3), new Size(Width/3, Height / 3 - Height / 20));
            e.Graphics.DrawRectangle(new Pen(Color.Black), trucs1);
            Rectangle trucs2 = new Rectangle(new Point(Width/3, Height / 3), new Size(Width/3, Height / 3 - Height / 20));
            e.Graphics.DrawRectangle(new Pen(Color.Black), trucs2);
            Rectangle trucs3 = new Rectangle(new Point(Width/3+ Width / 3, Height / 3), new Size(Width/3, Height / 3 - Height / 20));
            e.Graphics.DrawRectangle(new Pen(Color.Black), trucs3);

            //poli
            Rectangle poli = new Rectangle(new Point(0, Height / 3 + Height / 3 - Height / 20), new Size(Width, Height / 3 - Height / 20));
            e.Graphics.DrawRectangle(new Pen(Color.Black), poli);
            
        }

        public void LoseDialog(IndexedValue indexedValue)
        {
            if (indexedValue == null) { MessageBox.Show("Partie perdue : dette insurmontable."); }
            else { MessageBox.Show("Partie perdue :" +
                indexedValue.CompletePresentation()); }
            nextButton.Enabled = false;
        }

        public void WinDialog()
        {
            MessageBox.Show("Partie Gagné");
            nextButton.Enabled = false;
        }
        #endregion

        private void NextButton_Click(object sender, EventArgs e)
        {
            GameController.Interpret("suivant"); //utilisé le gamecontroller a fond les ballons
        }

        private void GameView_Load(object sender, EventArgs e)
        {

        }

        private void outputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GameView_ClientSizeChanged(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
