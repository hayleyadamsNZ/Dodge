﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Dodge
{
    class Planet
    {
        // declare fields to use in the class

        private int x, y, width, height;//variables for the rectangle
        private Image planetImage;//variable for the planet's image

        private Rectangle planetRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Planet(int spacing)
        {
            x = spacing;
            y = 10;
            width = 20;
            height = 20;
            planetImage = Image.FromFile("planet1.png");
            planetRec = new Rectangle(x, y, width, height);
        }
        // Methods for the Planet class
        public void drawPlanet(Graphics g)
        {
            planetRec = new Rectangle(x, y, width, height);
            g.DrawImage(planetImage, planetRec);
        }
        public void movePlanet()
        {
            y += 5;

            planetRec.Location = new Point(x, y);
            if (planetRec.Y > 400)
            {
                y = 20;
                planetRec.Location = new Point(x, y);
            }
        }
        public int changesy
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }

        }
    }
}
