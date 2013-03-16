using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace Races
{
    class Greyhound
    {
        public int StartingPosition = 20;
        public int RacetrackLength = 500;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random ran;

        public Greyhound(PictureBox picture)
        {
            MyPictureBox = picture;
        }

        public bool Run()
        {
            ran = new Random();
            int step = ran.Next(5);
            Point p = MyPictureBox.Location;
            p.X += step;
            Location = p.X;

            MyPictureBox.Location = p;
            if (p.X >= RacetrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void TakeStartingPosition()
        {
            Location = StartingPosition;
        }
    }
}
