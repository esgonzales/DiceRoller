using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceProgram
{
    public partial class Form1 : Form
    {
        Image[] dice_Images;
        int[] dice;
        Random rand;

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            roll_Btn.MouseEnter += new EventHandler(roll_Btn_MouseEnter);
            roll_Btn.MouseLeave += new EventHandler(roll_Btn_MouseLeave);
            roll_Btn.MouseDown += new MouseEventHandler(roll_Btn_MouseDown);
            roll_Btn.MouseUp += new MouseEventHandler(roll_Btn_MouseUp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dice_Images = new Image[7];
            dice_Images[0] = Properties.Resources.die_0;
            dice_Images[1] = Properties.Resources.die_1;
            dice_Images[2] = Properties.Resources.die_2;
            dice_Images[3] = Properties.Resources.die_3;
            dice_Images[4] = Properties.Resources.die_4;
            dice_Images[5] = Properties.Resources.die_5;
            dice_Images[6] = Properties.Resources.die_6;
            
            dice = new int[3] { 0, 0, 0 };

            rand = new Random();
        }

        private void roll_Btn_Click(object sender, EventArgs e)
        {
            roll_Dice();
        }

        private void roll_Dice()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = rand.Next(1, 6 + 1);
            }
            die_1.Image = dice_Images[dice[0]];
            die_2.Image = dice_Images[dice[1]];

        }
    
        private void roll_Btn_MouseEnter(object sender, EventArgs e)
        {
            this.roll_Btn.Image = ((System.Drawing.Image)(Properties.Resources.btn_hover));
        }

        private void roll_Btn_MouseLeave(object sender, EventArgs e)
        {
            this.roll_Btn.Image = ((System.Drawing.Image)(Properties.Resources.btn_off));
        }

        private void roll_Btn_MouseDown(object sender, MouseEventArgs e)
        {
            this.roll_Btn.Image = ((System.Drawing.Image)(Properties.Resources.btn_click));
        }

        private void roll_Btn_MouseUp(object sender, MouseEventArgs e)
        {
            this.roll_Btn.Image = ((System.Drawing.Image)(Properties.Resources.btn_hover));
        }

    }
}
