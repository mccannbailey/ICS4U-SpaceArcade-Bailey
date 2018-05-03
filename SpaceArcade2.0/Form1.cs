using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceArcade2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Form f = this.FindForm();
            WindowState = FormWindowState.Maximized;

            TitleScreen ms = new TitleScreen() { Width = 800, Height = 800 };
            ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);

            f.Controls.Add(ms);
        }
    }
}
