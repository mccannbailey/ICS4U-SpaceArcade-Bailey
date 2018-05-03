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
    public partial class WindowScreen : UserControl
    {
        public WindowScreen()
        {
            InitializeComponent();
            this.Focus();
        }

        private void WindowScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Dispose();
                    break;
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            //this.Controls.Remove(this);
            //TitleScreen ts = new TitleScreen();
            //ts.Location = new Point((this.Width - ts.Width) / 2, (this.Height - ts.Height) / 2);
            //this.Controls.Add(ts);

            // TODO - fix screen switch
            Application.Restart();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
