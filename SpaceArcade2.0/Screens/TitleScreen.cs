using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceArcade2._0
{
    public partial class TitleScreen : UserControl
    {
        public SingleScreen ss = new SingleScreen();

        public TitleScreen()
        {
            InitializeComponent();
        }

        private void SingleButton_Click(object sender, EventArgs e)
        {            
            Initiate();                        
            this.Controls.Remove(this);

            ss = new SingleScreen();
            ss.Location = new Point((this.Width - ss.Width) / 2, (this.Height - ss.Height) / 2);
            this.Controls.Add(ss);
        }

        public void Initiate()
        {
            SingleButton.Dispose();
            QuitButton.Dispose();
            pictureBox1.Dispose();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TitleScreen_Load(object sender, EventArgs e)
        {
            this.Focus();

            ss.Dispose();           
            SingleButton.Focus();
        }
    }
}
