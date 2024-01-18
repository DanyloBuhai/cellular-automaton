using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        bool[,] currentGen, nextGen;
        int size, rows, columns, Generation = 0, maxValue = 8, AntDirection = 0, AntX, AntY;
        bool VonN = false, isStarted = false, T = false;

        public Form1()
        {
            InitializeComponent();
            init();
            comboBox1.SelectedIndex = 0;
            cbMode.SelectedIndex = 0;

            for (int i = 0; i < DataForms.RuleTamplate.Length; i++)
            {
                DataForms.RuleTamplate[i] = new Block();
                DataForms.RuleBlock[i] = new Block();
            }

            DataForms.RuleTamplate[0].ul = false;
            DataForms.RuleTamplate[0].ur = false;
            DataForms.RuleTamplate[0].bl = false;
            DataForms.RuleTamplate[0].br = false;

            DataForms.RuleTamplate[1].ul = true;
            DataForms.RuleTamplate[1].ur = false;
            DataForms.RuleTamplate[1].bl = false;
            DataForms.RuleTamplate[1].br = false;

            DataForms.RuleTamplate[2].ul = false;
            DataForms.RuleTamplate[2].ur = true;
            DataForms.RuleTamplate[2].bl = false;
            DataForms.RuleTamplate[2].br = false;

            DataForms.RuleTamplate[3].ul = false;
            DataForms.RuleTamplate[3].ur = false;
            DataForms.RuleTamplate[3].bl = true;
            DataForms.RuleTamplate[3].br = false;

            DataForms.RuleTamplate[4].ul = false;
            DataForms.RuleTamplate[4].ur = false;
            DataForms.RuleTamplate[4].bl = false;
            DataForms.RuleTamplate[4].br = true;

            DataForms.RuleTamplate[5].ul = true;
            DataForms.RuleTamplate[5].ur = false;
            DataForms.RuleTamplate[5].bl = false;
            DataForms.RuleTamplate[5].br = true;

            DataForms.RuleTamplate[6].ul = false;
            DataForms.RuleTamplate[6].ur = true;
            DataForms.RuleTamplate[6].bl = true;
            DataForms.RuleTamplate[6].br = false;

            DataForms.RuleTamplate[7].ul = true;
            DataForms.RuleTamplate[7].ur = true;
            DataForms.RuleTamplate[7].bl = false;
            DataForms.RuleTamplate[7].br = false;

            DataForms.RuleTamplate[8].ul = false;
            DataForms.RuleTamplate[8].ur = false;
            DataForms.RuleTamplate[8].bl = true;
            DataForms.RuleTamplate[8].br = true;

            DataForms.RuleTamplate[9].ul = true;
            DataForms.RuleTamplate[9].ur = false;
            DataForms.RuleTamplate[9].bl = true;
            DataForms.RuleTamplate[9].br = false;

            DataForms.RuleTamplate[10].ul = false;
            DataForms.RuleTamplate[10].ur = true;
            DataForms.RuleTamplate[10].bl = false;
            DataForms.RuleTamplate[10].br = true;

            DataForms.RuleTamplate[11].ul = true;
            DataForms.RuleTamplate[11].ur = true;
            DataForms.RuleTamplate[11].bl = false;
            DataForms.RuleTamplate[11].br = true;

            DataForms.RuleTamplate[12].ul = false;
            DataForms.RuleTamplate[12].ur = true;
            DataForms.RuleTamplate[12].bl = true;
            DataForms.RuleTamplate[12].br = true;

            DataForms.RuleTamplate[13].ul = true;
            DataForms.RuleTamplate[13].ur = true;
            DataForms.RuleTamplate[13].bl = true;
            DataForms.RuleTamplate[13].br = false;

            DataForms.RuleTamplate[14].ul = true;
            DataForms.RuleTamplate[14].ur = false;
            DataForms.RuleTamplate[14].bl = true;
            DataForms.RuleTamplate[14].br = true;

            DataForms.RuleTamplate[15].ul = true;
            DataForms.RuleTamplate[15].ur = true;
            DataForms.RuleTamplate[15].bl = true;
            DataForms.RuleTamplate[15].br = true;
        }

        void init()
        {
            size = (int)tbSize.Value;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            rows = pictureBox1.Height / size - (pictureBox1.Height / size)%2;
            columns = pictureBox1.Width / size - (pictureBox1.Width / size)%2;
            currentGen = new bool[columns, rows];
            graphics.Clear(Color.White);
            Generation = 0;

            AntX = columns / 2;
            AntY = rows / 2;      
        }

        private void nudSize_ValueChanged(object sender, EventArgs e)
        {
            init();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(cbMode.SelectedIndex == 0) NextGeneration(); 
            if(cbMode.SelectedIndex == 1) NextGenerationAnt();
            if(cbMode.SelectedIndex == 2) NextGeneration1D();
            if (cbMode.SelectedIndex == 3) NextGenerationBlock();
            if (cbMode.SelectedIndex != 2)
            {
                if(cbMode.SelectedIndex == 3 && cbReverse.Checked)
                    Generation--;
                else Generation++;
                this.Text = cbMode.Text + ". Покоління: " + Generation;
            }
        }

        private void bntStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            PauseGame();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int XX = (e.Location.X - (e.Location.X % size)) / size;
            int YY = (e.Location.Y - (e.Location.Y % size)) / size;

            if (cbAntPos.Checked)
            {
                AntX = XX;
                AntY = YY;
                cbAntPos.Checked = false;
                return;
            }

            if (cbMode.SelectedIndex == 2 && YY > 0) return;
            if (XX < columns && YY < rows) 
                currentGen[XX, YY] = !currentGen[XX, YY];
            Draw();
        }

        bool isMouseDown = false;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            Draw();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown && (e.X > 0 && e.Y > 0))
            {
                int XX = (e.Location.X - (e.Location.X % size)) / size;
                int YY = (e.Location.Y - (e.Location.Y % size)) / size;
                if (cbMode.SelectedIndex == 2 && YY > 0) return;
                if ((XX < columns && YY < rows) && e.Button == MouseButtons.Left)
                    currentGen[XX, YY] = true;
                if ((XX < columns && YY < rows) && e.Button == MouseButtons.Right)
                    currentGen[XX, YY] = false;
                Draw(); 
            }
        }

        void StopGame()
        {
            cbMode.Enabled = true;
            FormBorderStyle = FormBorderStyle.Sizable;
            currentGen = nextGen = new bool[columns, rows];
            btnStop.Enabled = false;
            bntStart.Enabled = true;
            btnPause.Enabled = false;
            tbSize.Enabled = true;
            timer1.Stop();
            graphics.Clear(Color.White);
            pictureBox1.Refresh();
            isStarted = false;
            btnPause.Text = "Пауза";
            AntX = columns / 2;
            AntY = rows / 2;
        }
        void StartGame()
        {
            Generation = 0;
            cbMode.Enabled = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            bntStart.Enabled = false;
            btnStop.Enabled = true;
            btnPause.Enabled = true;
            tbSize.Enabled = false;
            if (cbRandom.Checked)
            {
                Random random = new Random();
                for (int y = 0; y < rows; y++)
                {
                    for (int x = 0; x < columns; x++)
                    {
                        currentGen[x, y] = random.Next(2) == 0;   
                    }
                    if (cbMode.SelectedIndex == 2) break;
                }
            }
            timer1.Start();
            isStarted = true;
            btnPause.Text = "Пауза";
        }

        void PauseGame()
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
                btnPause.Text = "Пауза";
            }
            else
            {
                timer1.Enabled = false;
                btnPause.Text = "Продовжити";
            }
        }

        private void cbReverse_CheckedChanged(object sender, EventArgs e)
        {
            T = !T;
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            if (isStarted)
                return;
            init();
        }

        private void tbSize_Scroll(object sender, EventArgs e)
        {
            init();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }

        private void nudBorn_ValueChanged(object sender, EventArgs e)
        {
            nudBornMax.Minimum = nudBornMin.Value;
        }

        private void cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMode.SelectedIndex)
            {
                case 0:
                    gb2D.Visible = true;
                    trackBar1.Enabled = true;
                    btnRule.Visible = false;
                    label10.Visible = false;
                    cbReverse.Visible = false;
                    cbAntPos.Visible = false;
                    break;
                case 1:
                    gb2D.Visible = false;
                    trackBar1.Enabled = true;
                    btnRule.Visible = false;
                    label10.Visible = false;
                    cbReverse.Visible = false;
                    cbAntPos.Visible = true;
                    break;
                case 2:
                    gb2D.Visible = false;
                    trackBar1.Enabled = false;
                    btnRule.Visible = true;
                    label10.Visible = true;
                    cbReverse.Visible = false;
                    cbAntPos.Visible = false;
                    break;
                case 3:
                    gb2D.Visible = false;
                    trackBar1.Enabled = true;
                    btnRule.Visible = true;
                    label10.Visible = false;
                    cbReverse.Visible = true;
                    cbAntPos.Visible = false;
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0)
            {
                maxValue = 8;
                VonN = false;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                maxValue = 4;
                VonN = true;
            }

            nudBornMax.Maximum = maxValue;
            nudBornMin.Maximum = maxValue;
            nudDHigh.Maximum = maxValue;
            nudDLow.Maximum = maxValue;
        }
  

        void NextGeneration()
        {
            bool isSame = true;
            nextGen = new bool[columns, rows];
            
            for (int x = 0; x < columns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    int countneighbor = countNeighbor(x, y);
                    bool isAlive = currentGen[x, y];

                    if (!isAlive && (countneighbor >= nudBornMin.Value && countneighbor <= nudBornMax.Value)) nextGen[x, y] = true;
                    else if (isAlive && (countneighbor < nudDLow.Value || countneighbor > nudDHigh.Value)) nextGen[x, y] = false;
                    else nextGen[x, y] = currentGen[x, y];  
                    if(nextGen[x, y] != currentGen[x, y]) isSame = false;
                }
            }
            if(isSame) PauseGame();
            currentGen = nextGen;
            Draw();
        }

        void NextGeneration1D()
        {
            int rowCounter = 0;

            for (rowCounter = 0; rowCounter < rows-1; rowCounter++)
            {
                for (int i = 0; i < columns; i++)
                {
                    bool left, right, current;
                    left = currentGen[(columns + i - 1) % columns, rowCounter];
                    right = currentGen[(columns + i + 1) % columns, rowCounter];
                    current = currentGen[i, rowCounter];
                    if (current == false && (left == false && right == false))
                        currentGen[i, rowCounter+1] = DataForms.state[0]; // 000
                    if (current == false && (left == false && right == true))
                        currentGen[i, rowCounter+1] = DataForms.state[1]; // 001
                    if (current == false && (left == true && right == false))
                        currentGen[i, rowCounter+1] = DataForms.state[2]; // 100
                    if (current == false && (left == true && right == true))
                        currentGen[i, rowCounter+1] = DataForms.state[3]; // 101
                    if (current == true && (left == false && right == false))
                        currentGen[i, rowCounter+1] = DataForms.state[4]; // 010
                    if (current == true && (left == false && right == true))
                        currentGen[i, rowCounter+1] = DataForms.state[5]; // 011
                    if (current == true && (left == true && right == false))
                        currentGen[i, rowCounter+1] = DataForms.state[6]; // 110
                    if (current == true && (left == true && right == true))
                        currentGen[i, rowCounter+1] = DataForms.state[7]; // 111
                }
                Draw();
            }
            PauseGame();
        }


        Block template = new Block();
        Block rule = new Block();
        void NextGenerationBlock()
        {
            int x1, y1;
            bool isSame = true;
            nextGen = new bool[columns, rows];
            Block currentBlock = new Block();
            Block nextGenBlock = new Block();
            for (int x = 0; x < columns; x+=2)
            {
                for (int y = 0; y < rows; y+=2)
                {
                    if (T)
                    {
                        x1=x;
                        y1=y;
                    }
                    else
                    {
                        x1 = x + 1;
                        y1 = y + 1;
                    }
                    currentBlock = getBlock(x1,y1);

                    for(int c = 0; c < DataForms.RuleBlock.Length; c++)
                    {
                        if (!cbReverse.Checked)
                        {
                            template = DataForms.RuleTamplate[c];
                            rule = DataForms.RuleBlock[c];
                        }
                        else
                        {
                            template = DataForms.RuleBlock[c]; 
                            rule = DataForms.RuleTamplate[c];
                        }

                        if (compareBlock(currentBlock, template))
                        {
                            nextGenBlock = rule;
                            nextGen[x1, y1] = nextGenBlock.ul;
                            nextGen[(x1 + 1 + columns) % columns, y1] = nextGenBlock.ur;
                            nextGen[x1, (y1 + 1 + rows) % rows] = nextGenBlock.bl;
                            nextGen[(x1 + 1 + columns) % columns, (y1 + 1 + rows) % rows] = nextGenBlock.br;
                            break;   
                        }
                    }
                    if (!compareBlock(currentBlock, nextGenBlock)) isSame = false;
                }
            }
            
            if (isSame) PauseGame();
            currentGen = nextGen;
            Draw();
            T = !T;
        }

        Block getBlock(int x, int y)
        {
            Block block = new Block();
            block.ul = currentGen[x, y];
            block.ur = currentGen[(x + 1 + columns) % columns, y];
            block.bl = currentGen[x, (y + 1 + rows) % rows];
            block.br = currentGen[(x + 1 + columns) % columns, (y + 1 + rows) % rows];
            return block;
        }

        bool compareBlock(Block rule, Block curr)
        {
            if ((rule.bl == curr.bl && rule.br == curr.br) && (rule.ul == curr.ul && rule.ur == curr.ur))
                return true;
            else return false;
        }

        void NextGenerationAnt()
        {
            nextGen = new bool[columns, rows];

            for (int x = 0; x < columns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    nextGen[x, y] = currentGen[x, y];
                }
            }

            bool isAlive = currentGen[AntX, AntY];
            AntDirection = isAlive ? AntDirection - 1 : AntDirection + 1;
            nextGen[AntX, AntY] = !currentGen[AntX, AntY];
            

            if (AntDirection == 4) AntDirection = 0;
            if (AntDirection == -1) AntDirection = 3;

            switch (AntDirection)
            {
                case 0:
                    AntY = (AntY - 1 + rows) % rows;
                    break;
                case 1:
                    AntX = (AntX - 1 + columns) % columns;
                    break;
                case 2:
                    AntY = (AntY + 1 + rows) % rows;
                    break;
                case 3:
                    AntX = (AntX + 1 + columns) % columns;
                    break;
            }

            currentGen = nextGen;
            Draw();
        }

        private void btnRule_Click(object sender, EventArgs e)
        {
            if(cbMode.SelectedIndex == 3)
            {
                RuleForm ruleform = new RuleForm();
                ruleform.ShowDialog();
            }
            if(cbMode.SelectedIndex == 2)
            {
                RuleForm1D ruleform1D = new RuleForm1D();
                ruleform1D.ShowDialog();
            }
            
        }

        private void cbAntPos_CheckedChanged(object sender, EventArgs e)
        {
            labelAnt.Visible = !labelAnt.Visible;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) 
            {
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Зберегти зображення як...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK) 
                {
                    try
                    {
                        pictureBox1.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Неможливо зберегти зображення", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        void Draw()
        {
            graphics.Clear(Color.White);
            for (int x = 0; x < columns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    if (currentGen[x, y]) graphics.FillRectangle(Brushes.Black, x * size, y * size, size, size);
                }
            }
            pictureBox1.Refresh();
        }

        int countNeighbor(int x,int y)
        {
            int neighbor = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    int c = (x + i + columns) % columns;
                    int r = (y + j + rows) % rows;
                    bool isSelfCheck = c == x && r == y;
                    bool isAlive = currentGen[c, r];
                    bool isNotCorner = true;
                    if (VonN) isNotCorner = c == x || r == y;

                    if (isAlive && !isSelfCheck && isNotCorner)
                    {
                        neighbor++;
                    }
                }
            }
            return neighbor;
        }

        private void tb1DRule_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0' || e.KeyChar == '1')
            {
                return;
            }
            e.Handled = true;
        }
    }
}
