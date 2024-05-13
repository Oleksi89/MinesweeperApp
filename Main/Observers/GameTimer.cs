using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    [Serializable]
    public class GameTimer : IGameObserver
    {
        private System.Windows.Forms.Timer timer;
        private Label timerLabel;
        public double TimeElapsed;

        public GameTimer(Label timerLabel)
        {
            this.timerLabel = timerLabel;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // 0.1 second
            timer.Tick += Timer_Tick;
            timerLabel.Text = "0";
            TimeElapsed = 0;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeElapsed += timer.Interval / 1000.0;
            timerLabel.Text = Math.Round(TimeElapsed, 0).ToString().PadLeft(3, '0');

        }

        public void Update(string message)
        {
            if (message != "game started" && message != "game ended")
                return;

            if (message == "game started")
            {
                timer.Stop();
                TimeElapsed = 0;
                timer.Start();
            }
            else if (message == "game ended")
            {
                timer.Stop();

            }
        }
    }

}
