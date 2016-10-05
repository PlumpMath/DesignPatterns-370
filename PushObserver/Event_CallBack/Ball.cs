using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_CallBack
{
    class Ball
    {
        public event EventHandler BallInPlay;
        protected void OnBallInPlay(BallEventArgs e)
        {
            EventHandler ballInPlay = BallInPlay;
            if (ballInPlay != null)
                ballInPlay(this, e);
        }

        public Bat GetNewBat()
        {
            return new Bat(new BatCallback(OnBallInPlay));
        }
    }
}
