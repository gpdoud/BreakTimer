using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakTimerProject {

    public partial class Form1 : Form {

        Timer timer = new Timer();

        public Form1() {
            InitializeComponent();
            timer.Tick += TimerTick;
            timer.Start();
        }

        public void TimerTick(object sender, EventArgs args) {
            var now = DateTime.Now.Ticks;
            var then = new DateTime(2017, 06, 07, 15, 15, 00).Ticks;

            this.Timer.Text = (new DateTime(then - now)).ToString("mm:ss");
            var left = (this.Size.Width - this.Timer.Width) / 2;
            var top = (this.Size.Height - this.Timer.Height) / 2 - (this.Timer.Height / 2);
            this.Timer.Left = left;
            this.Timer.Top = top;
        }
    }
}
