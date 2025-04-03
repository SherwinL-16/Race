using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    public class Runners
    {
        private Label runnerLabel;
        private Form1 form;
        private Random random;
        private Func<bool> isRaceOver;
        private Action setRaceOver;
        private Thread runnerThread;
        private int startX;

        public Runners(Label label, Form1 form, Random random, Func<bool> isRaceOver, Action setRaceOver)
        {
            this.runnerLabel = label;
            this.form = form;
            this.random = random;
            this.isRaceOver = isRaceOver;
            this.setRaceOver = setRaceOver;
            this.startX = label.Left; // Save initial position
        }

        public void StartRunning()
        {
            runnerThread = new Thread(() =>
            {
                while (runnerLabel.Left < form.FinishLineX && !isRaceOver())
                {
                    int moveDistance = random.Next(5, 15);
                    form.Invoke(new Action(() => runnerLabel.Left += moveDistance));
                    Thread.Sleep(100);
                }

                if (!isRaceOver())
                {
                    setRaceOver();
                    form.Invoke(new Action(() => MessageBox.Show(runnerLabel.Text + " wins!")));
                }
            });

            runnerThread.IsBackground = true;
            runnerThread.Start();
        }

        public void ResetPosition()
        {
            if (runnerThread != null && runnerThread.IsAlive)
            {
                runnerThread.Abort();
            }
            form.Invoke(new Action(() => runnerLabel.Left = startX));
        }
    }
}
