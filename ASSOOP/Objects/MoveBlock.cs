using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSOOP.Objects
{
    public class MoveBlock : Block
    {
        public enum DirectionType {Right,left};
        public DirectionType Direction = 0;
        public DirectionType preDirection = 0;
        public enum ActionType { Idle=0,Run,Attack};
        public ActionType Action =0;
        public ActionType preAction = 0;
        public enum JumpType {Stand,Jumping,Falling};
        public JumpType Jump = 0;
        public Timer tick = new Timer();
        public MoveBlock()
        {
            tick.Enabled = true;
            tick.Interval = 1;
            
        }
    }
}
