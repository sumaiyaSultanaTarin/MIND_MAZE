using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIND_MAZE
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        bool menuExpand = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarMove.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            menuMove.Start();
        }

        private void menuMove_Tick(object sender, EventArgs e)
        {
            if(menuExpand==false) 
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 130)
                {
                    menuMove.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if(menuContainer.Height <=43)
                {
                    menuMove.Stop();
                    menuExpand = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        bool sidebarExpand = true;
        private void sidebarMove_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 5;
                if(sidebar.Width <=37)
                {
                    sidebarExpand= false;
                    sidebarMove.Stop();

                    pnDashboard.Width = sidebar.Width;
                    pnAbout.Width = sidebar.Width;
                    pnSettings.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                    
                    menuContainer.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if(sidebar.Width>=156 )
                {
                    sidebarExpand= true;
                    sidebarMove.Stop();

                    pnDashboard.Width = sidebar.Width;
                    pnAbout.Width = sidebar.Width;
                    pnSettings.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;

                    
                    menuContainer.Width = sidebar.Width;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
