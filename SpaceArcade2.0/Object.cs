using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace SpaceArcade2._0
{
    class Object
    {
        public int x, y, speed, size;
        public string direction;

        public int shotX, shotY;
        public string shotDirection;

        public Object(int _x, int _y, int _speed, int _size, string _direction)
        {
            x = _x;
            y = _y;
            speed = _speed;
            size = _size;
            direction = _direction;
        }


        // Player Specific Methods //

        public void PlayerMove(int a, int b, Rectangle p, string direction, int speed)
        {
            Rectangle LR = new Rectangle(0, 0, 10, 800);
            Rectangle UR = new Rectangle(0, 10, 800, 10);
            Rectangle RR = new Rectangle(800, 0, 10, 800);
            Rectangle DR = new Rectangle(0, 800, 800, 10);

            if (!p.IntersectsWith(LR) && !p.IntersectsWith(UR) && !p.IntersectsWith(RR) && !p.IntersectsWith(DR))
            {
                if (direction == "left")        { x -= speed; }
                else if (direction == "right")  { x += speed; }
                else if (direction == "up")     { y -= speed; }
                else if (direction == "down")   { y += speed; }
            }
            else if (p.IntersectsWith(LR)) { x += speed; }
            else if (p.IntersectsWith(UR)) { y += speed; }
            else if (p.IntersectsWith(RR)) { x -= speed; }
            else if (p.IntersectsWith(DR)) { y -= speed; }
        }

        public Tuple<Object, Boolean> Shoot(List<Object> astList, List<Object> expList, Rectangle projR, int x, int y, string direction, int speed, long em, int stage)
        {
            Object tempE2 = new Object(0, 0, 0, 0, "");
            Boolean shotHit = false;
            int width = 50 / 2;
            int height = 40 / 2;

            switch (stage)
            {
                case 0:
                    // set initial projectile position
                    if (direction == "left")        { shotX = x; shotY = y + height;            }
                    else if (direction == "right")  { shotX = x + width; shotY = y + height;    }
                    else if (direction == "up")     { shotX = x + height; shotY = y;            }
                    else if (direction == "down")   { shotX = x + height; shotY = y + width;    }
                    stage = 1;  // advance stage
                    break;
                case 1:
                    // cont. movement of projectile
                    if (shotDirection == "left")    { shotX -= speed; }
                    if (shotDirection == "right")   { shotX += speed; }
                    if (shotDirection == "up")      { shotY -= speed; }
                    if (shotDirection == "down")    { shotY += speed; }
                    break;
            }
            if (em > 1200)
            {
                shotDirection = null;
            }


            // check projectile path for asteroids
            foreach (Object a in astList)
            {               
                Rectangle r = new Rectangle(a.x, a.y, a.size, a.size);                
                if (projR.IntersectsWith(r)) { tempE2 = a; shotHit = true; expList.Add(a); }
            }            
            return Tuple.Create(tempE2, shotHit);
        }


        //  Asteroid Specific Methods //

        public void AstMove(List<Object> astList, string direction, int speed)
        {
            // general movement
            if (direction == "left")        { x -= speed; }
            else if (direction == "right")  { x += speed; }
            else if (direction == "up")     { y -= speed; }
            else if (direction == "down")   { y += speed; }
        }

        public Tuple<Object, Boolean> AstCollision(List<Object> astList, List<Object> expList, Rectangle p)
        {
            Object tempE = new Object(0, 0, 0, 0, "");
            Boolean collision = false;

            foreach (Object b in astList)
            {
                Rectangle r = new Rectangle(b.x, b.y, b.size, b.size);

                if (p.IntersectsWith(r))
                {
                    tempE = b;
                    expList.Add(tempE);

                    collision = true;
                }
            }
            return Tuple.Create(tempE, collision);
        }
    }
}
