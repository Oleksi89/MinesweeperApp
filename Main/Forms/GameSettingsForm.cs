using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class GameSettingsForm : Form
    {
        private Game game;

        public GameSettingsForm(Game game)
        {
            InitializeComponent();
            this.game = game;
            LoadSettings();
        }

        private void LoadSettings()
        {
            
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            
        }
    }

}
