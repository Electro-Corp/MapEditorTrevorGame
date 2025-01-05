using Microsoft.Win32;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Security.Cryptography.Xml;

namespace TrevorGridThingy
{
    struct Tile
    {
        /*
            1 = initial placing of yellow
            10 = yellow placed in the last few ticks 
            11 = red that converted from a yellow 
            12 = red that is being placed now
            2 = green
            3 = blue 
            4 = purple 
            5 = orange
        */
        public int num = 0;

        public Tile(int num)
        {
            this.num = num;
        }

        public Color getColor()
        {
            Color retCol = Color.Yellow;
            switch (num)
            {
                case 0:
                    retCol = Color.White;
                    break;
                case 1:
                    retCol = Color.Yellow;
                    break;
                case 2:
                    retCol = Color.Green;
                    break;
                case 3:
                    retCol = Color.Blue;
                    break;
                case 4:
                    retCol = Color.Purple;
                    break;
                case 5:
                    retCol = Color.Orange;
                    break;
                case 10:
                    retCol = Color.LightYellow;
                    break;
                case 11:
                    retCol = Color.DarkRed;
                    break;
                case 12:
                    retCol = Color.Red;
                    break;
            }
            return retCol;
        }

   
    }

    struct Tick
    {
        public List<List<Tile>> tiles = new List<List<Tile>>();
        public Tick()
        {

        }

        public String toString()
        {
            string swag = "";
            for(int y = 0; y < tiles.Count; y++)
            {
                string cur = "[";
                for(int x = 0; x < tiles[y].Count; x++)
                {
                    if (x == 0)
                        cur += tiles[y][x].num.ToString();
                    else
                        cur += "," + tiles[y][x].num.ToString();
                }
                cur += "]";
                if(y == 0)
                {
                    swag += cur;
                }
                else
                {
                    swag += "," + cur;
                }
            }
            swag += "]";
            return swag;
        }
    }

    struct Board
    {
        public List<Tick> ticks = new List<Tick>();

        public Board()
        {

        }
    }
    public partial class MainWindow : Form
    {
        Button currentButton = null;
        int currentColor = 1;

        Board board;

        int currentTick = 0;

        int yellow_speed = 2;
        int speed = 1;

        bool started = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        public void generateNewMap(int width, int height, int ticks, int ySpeed, int nSpeed)
        {
            yellow_speed = ySpeed;
            speed = nSpeed;
            this.Show();
            toolStripStatusLabel1.Text = "Current tick: " + currentTick.ToString();
            trackBar1.Minimum = 0;
            trackBar1.Maximum = ticks - 1;

            

            board = new Board();
            for (int i = 0; i < ticks; i++)
            {
                Tick tick = new Tick();
                for (int y = 0; y < height; y++)
                {
                    List<Tile> tiles = new List<Tile>();
                    for (int x = 0; x < width; x++)
                    {
                        tiles.Add(new Tile(0));
                    }
                    tick.tiles.Add(tiles);
                }
                board.ticks.Add(tick);
            }

            yellowSpeedUpDown.Maximum = ticks - 1;
            speedUpDown.Maximum = ticks - 1;
            yellowSpeedUpDown.Value = yellow_speed;
            speedUpDown.Value = speed;
            

            refreshTick(0);

            started = true;

        }

        private void refreshTick(int n)
        {
            currentTick = n;
            trackBar1.Value = currentTick;
            toolStripStatusLabel1.Text = "Recalculating...";
            groupBox1.Controls.Clear();
            // Load tick
            Tick tick = board.ticks[n];
            for (int y = 0; y < tick.tiles.Count; y++)
            {
                for (int x = 0; x < tick.tiles[y].Count; x++)
                {
                    Button tileTemp = new Button();
                    tileTemp.Size = new Size(50, 50);
                    tileTemp.Location = new Point(20 + x * tileTemp.Size.Width, 20 + y * tileTemp.Size.Height);
                    tileTemp.Text = $"{x},{y}";
                    tileTemp.Click += TileTemp_Click;
                    tileTemp.Tag = new Point(x, y);
                    tileTemp.BackColor = tick.tiles[y][x].getColor();

                    // yellow
                    if (tick.tiles[y][x].num == 1)
                    {
                        if (currentTick + 1 < trackBar1.Maximum)
                        {
                            // We're good to go
                            board.ticks[currentTick + 1].tiles[y][x] = new Tile(10);
                            for(int i = 1; i < Math.Min(yellow_speed, trackBar1.Maximum - currentTick); i++)
                            {
                                board.ticks[currentTick + i].tiles[y][x] = new Tile(10);
                            }
                            if (currentTick + yellow_speed < trackBar1.Maximum)
                            {
                                board.ticks[currentTick + yellow_speed].tiles[y][x] = new Tile(11);
                            }
                            // Calculate some shit (how long red boi stay)
                            for (int i = yellow_speed + 1; i < Math.Min(speed, trackBar1.Maximum - (currentTick + yellow_speed)); i++)
                            {
                                board.ticks[currentTick + i].tiles[y][x] = new Tile(11);
                            }
                        }
                        else
                        {

                        }

                    }


                    groupBox1.Controls.Add(tileTemp);
                }
            }
            groupBox1.Refresh();
            toolStripStatusLabel1.Text = "Tick: " + currentTick.ToString();
        }

        private void TileTemp_Click(object sender, EventArgs e)
        {
            Button clickButton = sender as Button;
            currentButton = clickButton;
            Point pos = (Point)currentButton.Tag;
            (board.ticks[currentTick].tiles[pos.Y][pos.X]) = new Tile(currentColor);
            currentButton.BackColor = board.ticks[currentTick].tiles[pos.Y][pos.X].getColor();


            refreshTick(currentTick);

        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            currentColor = 1;
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            currentColor = 11;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            currentColor = 2;
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            currentColor = 3;
        }


        private void purpleButton_Click(object sender, EventArgs e)
        {
            currentColor = 4;
        }

        private void orangeButton_Click(object sender, EventArgs e)
        {
            currentColor = 5;
        }

        private void whiteButton_Click(object sender, EventArgs e)
        {
            currentColor = 0;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentTick = trackBar1.Value;
            toolStripStatusLabel1.Text = "Current tick: " + currentTick.ToString();
            refreshTick(currentTick);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            String list = "[";
            for (int i = 0; i < trackBar1.Maximum; i++)
            {
                if (i == 0)
                {
                    list += board.ticks[i].toString();
                }
                else
                {
                    list += "," + board.ticks[i].toString();
                }
            }
            list += "]";
            //MessageBox.Show(list);
            Clipboard.SetText(list);
        }

        private async void yellowSpeedUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (started)
            {
                yellow_speed = (int)yellowSpeedUpDown.Value;
                for (int i = 0; i < trackBar1.Maximum; i++)
                {
                    refreshTick(i);
                }

                refreshTick(currentTick);
            }
            else
            {
                yellow_speed = (int)yellowSpeedUpDown.Value;
            }
        }


        private async void speedUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (started)
            {
                speed = (int)speedUpDown.Value;
                for (int i = 0; i < trackBar1.Maximum; i++)
                {
                    refreshTick(i);
                }

                refreshTick(currentTick);
            }
            else
            {
                speed = (int)speedUpDown.Value;
            }
        }

        private void InvokeOnUIThread(Action action)
        {
            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            if (MessageBox.Show("You sure you wanna exit?", "You're... you're leaving me??", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
