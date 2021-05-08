using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoll
{
    public partial class DiceRollFrom : Form
    {
        public DiceRollFrom()
        {
            InitializeComponent();
        }

        private async void RollButton_Click(object sender, EventArgs e)
        {
            RollButton.Text = "Rolling-it !!";
            RollButton.Enabled = false;

            Random random = new Random();
            
            for(int  i = 0; i < 20; i++)
            {
                int num = random.Next(1, 6);
                LabelNumber.Text = Convert.ToString(num);

                switch (num)
                {
                    case 1:
                        pictureBox.Image = DiceRoll.Properties.Resources.num1;
                        break;
                    case 2:
                        pictureBox.Image = DiceRoll.Properties.Resources.num2;
                        break;
                    case 3:
                        pictureBox.Image = DiceRoll.Properties.Resources.num3;
                        break;
                    case 4:
                        pictureBox.Image = DiceRoll.Properties.Resources.num4;
                        break;
                    case 5:
                        pictureBox.Image = DiceRoll.Properties.Resources.num5;
                        break;
                    case 6:
                        pictureBox.Image = DiceRoll.Properties.Resources.num6;
                        break;
                }
                await Task.Delay(100);
            }

            RollButton.Enabled = true;
            RollButton.Text = "Roll-A-Dice";
        }

        
    }
}
