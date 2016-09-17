using NKH.MindSqualls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NxtLego
{
    public partial class Form1 : Form
    {
        NxtBrick brick;
        public Form1()
        {
            InitializeComponent();

            // Create a NXT brick,
            // and use USB 
            brick = new NxtBrick(NxtCommLinkType.USB, 0);

            // Attach motors to port B and C on the NXT.
            brick.MotorB = new NxtMotor();
            brick.MotorC = new NxtMotor();

            // Connect to the NXT.
            brick.Connect();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Run the motors at 75% power, for a 3600 degree run.
            brick.MotorB.Run(50, 200);
            brick.MotorC.Run(50, 200);
         
        }

        private void Disconnect()
        {
            // Disconnect from the NXT.  
            brick.Disconnect();
        }
    }
}
