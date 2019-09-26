using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASSOOP.Objects;
using System.Drawing;
using System.Windows.Forms;
using ASSOOP;

namespace ASSOOP.Objects.MainCharacter
{
    public class MainCharacter : MoveBlock
    {
        public MainCharacter()
        {
            this.box = new System.Windows.Forms.PictureBox();

            this.box.BackColor = System.Drawing.Color.Transparent;
            this.box.Image = global::ASSOOP.Objects.MainCharacter.MainCharacter_Resource.rightSamuraiIDLE; ;
            this.box.Location = new System.Drawing.Point(500, 500);
            this.box.Name = "Main";
            this.box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box.Size = new Size(230, 230);
            this.box.TabStop = true;
            tick.Tick += new System.EventHandler(this.Tick_Tick);

        }

        public void Move(bool[] BKey)
        {
            if (BKey[2] == true) //BKey[2]==true  is the key up is pressing
            {
                //code for jump
            }
            else if (BKey[0] == true) //BKey[0]==true is the key left is pressing
            {
                preDirection = Direction;
                Direction = DirectionType.left;
                preAction = Action;
                Action = ActionType.Run;
            }
            else if (BKey[1] == true) //BKey[1]==true is the key right is pressing
            {
                preDirection = Direction;
                Direction = DirectionType.Right;
                preAction = Action;
                Action = ActionType.Run;
            }
            else if (BKey[3]==true) //BKey[2]==true is the key space is pressing
            {
                preAction = Action;
                Action = ActionType.Attack;
            }
            else
            {
                preAction = Action;
                Action = ActionType.Idle;
            }
        }
        private void Tick_Tick(object sender, EventArgs e) //refresh the animation for each action
        {
            switch (Action)
            {
                case ActionType.Run:
                    if(Direction==DirectionType.left)
                    {
                        if (preAction != Action || preDirection != Direction)       //check image cũ có trùng với image mới
                            this.box.Image = ASSOOP.Objects.MainCharacter.MainCharacter_Resource.leftSamuraiRUN;
                        this.box.Left -= 5;
                    }
                    else if (Direction == DirectionType.Right)
                    {
                        if (preAction != Action || preDirection != Direction)
                            this.box.Image = ASSOOP.Objects.MainCharacter.MainCharacter_Resource.rightSamuraiRUN;
                        this.box.Left += 5;
                    }
                    break;
                case ActionType.Attack:
                    if (Direction == DirectionType.left)
                    {
                        if (preAction != Action || preDirection != Direction)
                            this.box.Image = ASSOOP.Objects.MainCharacter.MainCharacter_Resource.leftSamuraiATTACK;
                    }
                    else if (Direction == DirectionType.Right)
                    {
                        if (preAction != Action || preDirection != Direction)
                            this.box.Image = ASSOOP.Objects.MainCharacter.MainCharacter_Resource.rightSamuraiATTACK;
                    }
                    break;
                case ActionType.Idle:
                    if (Direction == DirectionType.left)
                    {
                        if (preAction != Action || preDirection != Direction)
                            this.box.Image = ASSOOP.Objects.MainCharacter.MainCharacter_Resource.leftSamuraiIDLE;
                    }
                    else if (Direction == DirectionType.Right)
                    {
                        if (preAction != Action || preDirection != Direction)
                            this.box.Image = ASSOOP.Objects.MainCharacter.MainCharacter_Resource.rightSamuraiIDLE;
                    }
                    break;
            }
        }
    }
}
