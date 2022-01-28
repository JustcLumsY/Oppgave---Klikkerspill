using System;

namespace Oppgave___Klikkerspill
{
    public class ClickerGame
    {
       public int Points = 0;
       public int PointsPerClick = 1;
       public int PointsPerClickIncrease = 1;
  
        public ClickerGame(int points, int pointsPerClick, int pointsPerClickIncrease)
        {
            Points = points;
            PointsPerClick = pointsPerClick;
            PointsPerClickIncrease = pointsPerClickIncrease;
        }

        public void Click()
        {
            Points += PointsPerClick;
        }

        public void Upgrade()
        {
            if (Points < 10) return;
            Points -= 10;
            PointsPerClick += PointsPerClickIncrease;
        }

        public void SuperUpgrade()
        {
            if (Points < 100) return;
            Points -= 100;
            PointsPerClickIncrease++;
        }
    }
}