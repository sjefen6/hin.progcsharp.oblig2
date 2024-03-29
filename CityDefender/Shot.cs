﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CityDefender 
{
    class Shot : GameObject
    {
        private double angle;
        private bool active;

        //Konstruktør
        public Shot(float x, float y, double a)
        {
            this.angle = a;
            this.xCoord = x + 15;
            this.yCoord = y;
            active = true;
        }

        public Boolean Active
        {
            get { return active; }
            set { active = false; }
        }

        public override Rectangle getRect()
        {
            return new Rectangle((int)xCoord-2, (int)yCoord-2, 4, 4); 
        }

        //Beveger skuddet hvis det er aktivt
        public void moveShot()
        {
            if (active)
            {
                xCoord += 8f * (float)Math.Cos(angle);
                yCoord += 8f * (float)Math.Sin(angle);

                //Deaktiverer seg selv hvis den ser at den er utenfor banen
                if (xCoord < 0 || xCoord > 600 || yCoord < 0 || yCoord > 538)
                {
                    this.active = false;
                }
            }
        }

        public override void draw(System.Drawing.Graphics g)
        {
            if (active)
            {
                g.FillEllipse(Brushes.Black, xCoord - 2f, yCoord - 2f, 4f, 4f);
            }
        }
    }
}
