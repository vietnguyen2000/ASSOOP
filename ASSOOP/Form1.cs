using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASSOOP.Objects;
using ASSOOP.Objects.MainCharacter;

namespace ASSOOP
{
    public partial class Form1 : Form
    {
        MainCharacter Samurai;
        Keys[] Key = new Keys[4] { Keys.Left, Keys.Right, Keys.Up, Keys.Space };
        bool[] BKey = new bool[4];
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1280, 720);

            Samurai = new MainCharacter();
            this.Controls.Add(Samurai.box);

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int i = 0;
            for (i = 0; i < 4; i++)
            {
                if (e.KeyCode == Key[i])
                {
                    BKey[i] = true;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            int i = 0;
            for (i = 0; i < 4; i++)
            {
                if (e.KeyCode == Key[i])
                {
                    BKey[i] = false;
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Samurai.Move(BKey);
        }
    }
}
