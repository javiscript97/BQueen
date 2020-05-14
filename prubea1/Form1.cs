using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace prubea1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondoHome.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            btnHome.TabStop = false;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.FlatAppearance.BorderSize = 0;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {   
            Form Form2 = new Form2();
            this.Hide();
            Form2.ShowDialog();
            Close();
            
        }
    }
}
