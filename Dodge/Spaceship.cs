﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Dodge
{
    class Spaceship
    {
        // declare fields to use in the class

        private int x, y, width, height;//variables for the rectangle
        private Image spaceship;//variable for the planet's image

        private Rectangle spaceRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Spaceship()
        {
            x = 10;
            y = 360;
            width = 40;
            height = 40;
            spaceship = Image.FromFile("alien1.png");
            spaceRec = new Rectangle(x, y, width, height);
        }
        //methods
        public void drawSpaceship(Graphics g)
        {
            spaceRec = new Rectangle(x, y, width, height);
            g.DrawImage(spaceship, spaceRec);
        }
        public void moveSpaceship(string move)
        {
            spaceRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (spaceRec.Location.X > 450) // is spaceship within 50 of right side
                {

                    x = 450;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    x += 5;
                    spaceRec.Location = new Point(x, y);
                }

            }
            if (move == "left")
            {
                if (spaceRec.Location.X < 10) // is spaceship within 10 of left side
                {

                    x = 10;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    x -= 5;
                    spaceRec.Location = new Point(x, y);
                }

            }
        }
    }
}
