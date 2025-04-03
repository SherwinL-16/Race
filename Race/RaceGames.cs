using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    public class RaceGames
    {
        private Runners[] runners;
        private bool raceOver = false;
        private Random random = new Random();
        private Form1 form;

        public RaceGames(Form1 form)
        {
            this.form = form;
            InitializeRace();
        }

        private void InitializeRace()
        {
            
            runners = new Runners[3];
            runners[0] = new Runners(form.lblRunner1, form, random, () => raceOver, () => raceOver = true);
            runners[1] = new Runners(form.lblRunner2, form, random, () => raceOver, () => raceOver = true);
            runners[2] = new Runners(form.lblRunner3, form, random, () => raceOver, () => raceOver = true);
        }

        public void StartRace()
        {
            raceOver = false;
            foreach (var runner in runners)
            {
                runner.StartRunning();
            }
        }

        public void RestartRace()
        {
            raceOver = true;
            foreach (var runner in runners)
            {
                runner.ResetPosition();
            }
        }

        public void QuitGame()
        {
            Application.Exit();
        }
    }
}
