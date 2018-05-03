using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Media;

namespace SpaceArcade2._0
{
    public partial class SingleScreen : UserControl
    {
        #region Global Values
        WindowScreen ws;

        SoundPlayer AstSound = new SoundPlayer(Properties.Resources.AstHit);
        SoundPlayer PlayerSound = new SoundPlayer(Properties.Resources.PlayerHit);

        Object PlayerShip = new Object(370, 360, 10, 0, "up");
        Object tempE = new Object(0, 0, 0, 0, "");
        Object tempE2 = new Object(0, 0, 0, 0, "");

        Stopwatch ShootWatch = new Stopwatch();
        Stopwatch AsteroidWatch = new Stopwatch();
        Stopwatch ExpWatch = new Stopwatch();
        Stopwatch GraceWatch = new Stopwatch();

        Random randNum = new Random();

        List<Object> asteroidList = new List<Object>();
        List<Object> expList = new List<Object>();

        Boolean spaceDown, mDown;
        Boolean gameOver = false;
        Boolean shotFired = false;
        Boolean gracePeriod = false;

        Image playerImage = Properties.Resources.Player0;        
        Image heart = Properties.Resources.heart;
        Image explosionImage1 = Properties.Resources.explosion0;
        Image explosionImage2 = Properties.Resources.explosion1;
        Image explosionImage3 = Properties.Resources.explosion2;

        int rocksHit = 0;
        int playerSpeed = 0;
        int playerLives = 3;
        int stage = 0;

        long ElapsedMillis;

        const int PROJSPEED = 20;
        const int MAXSPEED = 15;
        const int PLAYSIZE = 800;
        const int PLAYERHEIGHT = 50, PLAYERWIDTH = 50;

        SolidBrush astBrush;
        SolidBrush projBrush = new SolidBrush(Color.White);

        Rectangle playerRect = new Rectangle(370, 360, 10, 0);
        #endregion

        public SingleScreen()
        {
            InitializeComponent();
            this.Focus();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // General Movement 
            if (spaceDown)  // speed up player
            {
                for (int i = 0; i < MAXSPEED; i++)
                {
                    if (playerSpeed >= MAXSPEED) { playerSpeed = MAXSPEED; }
                    playerSpeed += 2;
                }
            }
            else if (playerSpeed > 0 && !spaceDown) // slow down speed
            {
                playerSpeed--;
            }
            PlayerShip.PlayerMove(PlayerShip.x, PlayerShip.y, playerRect, PlayerShip.direction, playerSpeed);
            playerRect = new Rectangle(PlayerShip.x, PlayerShip.y, PLAYERWIDTH, PLAYERHEIGHT);

            #region Player Shooting            

            if (mDown && !shotFired) { shotFired = true; }

            if (shotFired)
            {
                Rectangle projRect = new Rectangle(PlayerShip.shotX, PlayerShip.shotY, 10, 10);
                Boolean shotHit = false;

                ShootWatch.Start();
                ElapsedMillis = ShootWatch.ElapsedMilliseconds;

                if (PlayerShip.shotDirection == null) { PlayerShip.shotDirection = PlayerShip.direction; }  // set direction of shot

                // assign Object and boolean
                tempE = PlayerShip.Shoot(asteroidList, expList, projRect, PlayerShip.x, PlayerShip.y, PlayerShip.shotDirection, PROJSPEED, ElapsedMillis, stage).Item1;
                shotHit = PlayerShip.Shoot(asteroidList, expList, projRect, PlayerShip.x, PlayerShip.y, PlayerShip.shotDirection, PROJSPEED, ElapsedMillis, stage).Item2;

                // if shot has been detected
                if (shotHit)
                {
                    rocksHit++;
                    shotHit = false;
                    AstSound.Play();
                }

                if (ElapsedMillis >= 1200)
                {
                    ShootWatch.Reset();
                    shotFired = false;
                    stage = 0;
                }
                if (ElapsedMillis < 1200) { stage = 1; }
            }
            asteroidList.Remove(tempE);
            #endregion            

            #region Asteroid Movements            

            if (AsteroidWatch.ElapsedMilliseconds == 0) { AsteroidWatch.Start(); }

            // check and create new asteroids
            if (AsteroidWatch.ElapsedMilliseconds > 1000 && asteroidList.Count < 6)
            {
                CreateAsteroids();
                AsteroidWatch.Reset();
            }    

            // move each asteroid and check collisions
            foreach (Object a in asteroidList)
            {
                a.AstMove(asteroidList, a.direction, a.speed);
   
                playerRect = new Rectangle(PlayerShip.x, PlayerShip.y, PLAYERWIDTH, PLAYERHEIGHT);

                tempE2 = a.AstCollision(asteroidList, expList, playerRect).Item1;

                // if collision is detected, do this
                if (a.AstCollision(asteroidList, expList, playerRect).Item2 == true && !gracePeriod)
                {
                    PlayerSound.Play();
                    gracePeriod = true;                    
                    GraceWatch.Start();

                    if (playerLives == 3)       { playerLives = 2; }
                    else if (playerLives == 2)  { playerLives = 1; }
                    else if (playerLives == 1)  { playerLives = 0; }
                    else { playerLives = 0; }
                }
            }
            if (GraceWatch.ElapsedMilliseconds > 1000)
            {
                gracePeriod = false;
                GraceWatch.Reset();
            }
            asteroidList.Remove(tempE2);

            // remove off screen asteroids
            // TODO - Move to class method
            for (int i = 0; i < asteroidList.Count; i++)
            {
                if (asteroidList[i].x < -100) { asteroidList.Remove(asteroidList[i]); break; }
                if (asteroidList[i].x > 900) { asteroidList.Remove(asteroidList[i]); break; }
                
            }

            for (int i = 0; i < asteroidList.Count; i++)
            {
                if (asteroidList[i].y < -100) { asteroidList.Remove(asteroidList[i]); break; }
                if (asteroidList[i].y > 900) { asteroidList.Remove(asteroidList[i]); break; }
            }
            #endregion

            CountLabel.Text = Convert.ToString(rocksHit);
            CheckHealth();
            Refresh();
        }

        private void SingleScreen_Paint(object sender, PaintEventArgs e)
        {
            // draw player            
            if (PlayerShip.direction == "left" || PlayerShip.direction == "right")
            {
                e.Graphics.DrawImage(playerImage, PlayerShip.x, PlayerShip.y, PLAYERHEIGHT, PLAYERWIDTH);
            }
            else if (PlayerShip.direction == "up" || PlayerShip.direction == "down")
            {
                e.Graphics.DrawImage(playerImage, PlayerShip.x, PlayerShip.y, PLAYERWIDTH, PLAYERHEIGHT);
            }

            // draw projectile
            if (shotFired == true)
            {
                e.Graphics.FillRectangle(projBrush, PlayerShip.shotX, PlayerShip.shotY, 10, 10);
            }

            // draw asteroids
            foreach (Object a in asteroidList)
            {
                astBrush = NewBrush();

                e.Graphics.FillRectangle(astBrush, a.x, a.y, a.size, a.size);                
            }

            // draw exploding asteroids
            foreach (Object a in expList)
            {
                ExpWatch.Start();
                e.Graphics.DrawImage(explosionImage3, tempE.x, tempE.y, tempE.size, tempE.size);
            }
            if (gameOver) { e.Graphics.Clear(Color.Transparent); }
        }

        private void SingleScreen_Load(object sender, EventArgs e)
        {
            // reset values
            PlayerShip = new Object(370, 360, 10, 0, "up");
            asteroidList.Clear();
            rocksHit = 0;
            playerSpeed = 0;
            playerLives = 3;
            stage = 0;
            gameOver = false;
            shotFired = false;
            gracePeriod = false;

            CountLabel.Visible = true;
            rockLabel.Visible = true;

            outputLabel.Text = "Ready!";
            int x = this.Width / 2 - outputLabel.Width / 2;
            int y = this.Height / 2 - outputLabel.Height * 2;
            outputLabel.Location = new Point(x, y);

            Refresh();
            Thread.Sleep(1000);

            outputLabel.Text = "Go!";
            x = this.Width / 2 - outputLabel.Width / 2;
            y = this.Height / 2 - outputLabel.Height * 2;
            outputLabel.Location = new Point(x, y);
            Refresh();

            Thread.Sleep(500);
            outputLabel.Text = "";

            GameTimer.Enabled = true;
        }


        // Custom Methods

        public void GameOver()
        {
            GameTimer.Stop();

            outputLabel.ForeColor = Color.Red;
            outputLabel.Text = "Game Over";
            int x = this.Width / 2 - outputLabel.Width / 2;
            int y = this.Height / 2 - outputLabel.Height * 2;
            outputLabel.Location = new Point(x, y);

            Refresh();
            Thread.Sleep(2000);

            outputLabel.Text = "";
            CountLabel.Visible = false;
            rockLabel.Visible = false;

            this.Controls.Remove(this);     
            TitleScreen ts = new TitleScreen();
            ts.Location = new Point((this.Width - ts.Width) / 2, (this.Height - ts.Height) / 2);
            this.Controls.Add(ts);

            Refresh();     
        }

        public void CheckHealth()
        {
            // TODO - fix hearts not showing after playing again
            // boxes appear black, does not display an image. playerlives are reset properly.

            heartBox1.BackgroundImage = heart;
            heartBox2.BackgroundImage = heart;
            heartBox3.BackgroundImage = heart;
            // update player lives
            switch (playerLives)
            {
                case 0:
                    heartBox1.BackgroundImage = null;
                    heartBox2.BackgroundImage = null;
                    heartBox3.BackgroundImage = null;
                    gameOver = true;
                    GameOver();
                    break;
                case 1:
                    heartBox1.BackgroundImage = heart;
                    heartBox2.BackgroundImage = null;
                    heartBox3.BackgroundImage = null;
                    break;
                case 2:
                    heartBox1.BackgroundImage = heart;
                    heartBox2.BackgroundImage = heart;
                    heartBox3.BackgroundImage = null;
                    break;
                case 3:
                    heartBox1.BackgroundImage = heart;
                    heartBox2.BackgroundImage = heart;
                    heartBox3.BackgroundImage = heart;
                    break;
            }
        }

        public void CreateAsteroids()
        {            
            // left
            Object a = new Object(-50, randNum.Next(0, PLAYSIZE), randNum.Next(6, 20), randNum.Next(40, 120), "right");
            asteroidList.Add(a);

            // right
            Object b = new Object(PLAYSIZE + 50, randNum.Next(0, PLAYSIZE), randNum.Next(6, 20), randNum.Next(50, 120), "left");
            asteroidList.Add(b);

            // top
            Object c = new Object(randNum.Next(0, PLAYSIZE), -50, randNum.Next(6, 20), randNum.Next(50, 120), "down");
            asteroidList.Add(c);

            // bottom
            Object d = new Object(randNum.Next(0, PLAYSIZE), PLAYSIZE + 50, randNum.Next(6, 20), randNum.Next(50, 120), "up");
            asteroidList.Add(d);
        }

        public SolidBrush NewBrush()
        {
            SolidBrush db = new SolidBrush(Color.Cyan);
            int i = randNum.Next(1, 4);
                    
            switch (i)
            {
                case 1:
                    db = new SolidBrush(Color.Cyan);
                    break;
                case 2:
                    db = new SolidBrush(Color.Magenta);
                    break;
                case 3:
                    db = new SolidBrush(Color.Yellow);
                    break;
            }

            return db;
        }


        // Key down & up

        private void SingleScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    PlayerShip.direction = "left";
                    playerImage = Properties.Resources.Player270;
                    break;
                case Keys.Right:
                    PlayerShip.direction = "right";
                    playerImage = Properties.Resources.Player90;
                    break;
                case Keys.Up:
                    PlayerShip.direction = "up";
                    playerImage = Properties.Resources.Player0;
                    break;
                case Keys.Down:
                    PlayerShip.direction = "down";
                    playerImage = Properties.Resources.Player180;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.M:
                    mDown = true;
                    break;
                case Keys.Escape:
                    if (GameTimer.Enabled)
                    {
                        GameTimer.Enabled = false;

                        ws = new WindowScreen();
                        ws.Location = new Point((this.Width - ws.Width) / 2, (this.Height - ws.Height) / 2);
                        this.Controls.Add(ws);
                    }
                    else { GameTimer.Enabled = true; ws.Dispose(); } 
                    break;
            }
        }

        private void SingleScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spaceDown = false;
                    break;
                case Keys.M:
                    mDown = false;
                    break;
            }
        }
    }
}
