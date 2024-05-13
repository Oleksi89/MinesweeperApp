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
        private Control timerLabel;
        public double TimeElapsed;

        public GameTimer(Control timerLabel)
        {
            this.timerLabel = timerLabel;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // 0.1 second
            timer.Tick += Timer_Tick;
            timerLabel.Text = "000";
            TimeElapsed = 0;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeElapsed += timer.Interval / 1000.0;
            timerLabel.Text = Math.Round(TimeElapsed, 0).ToString().PadLeft(3, '0');

        }

        public void Update(string message)
        {
            switch (message)
            {
                case "game prepared":
                    timer.Stop();
                    TimeElapsed = 0;
                    timerLabel.Text = "000";
                    break;
                case "game started":
                    timer.Start();
                    break;
                case "game ended":
                case "game paused":
                    timer.Stop();
                    break;
                case "game resumed":
                    timer.Start();
                    break;
            }

        }
    }

}
