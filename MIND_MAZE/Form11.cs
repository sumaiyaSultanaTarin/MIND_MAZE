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
    public partial class Form11 : Form
    {
        Form16 menu2;
        Form15 menu1;
        Form14 settings;
        Form13 about;
        Form12 dashboard;
        Form17 logout;
        public Form11()
        {
            InitializeComponent();
            mdiProp();
        }
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
        bool menuExpand=false;
        private void mdiProp() 
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand==false) 
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >=110) 
                { 
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if(menuContainer.Height <=33)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand) 
            {
                sidebar.Width-= 5;
                if(sidebar.Width <= 46)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

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
                if(sidebar.Width >= 150)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnDashboard.Width = sidebar.Width;
                    pnAbout.Width = sidebar.Width;
                    pnSettings.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                    menuContainer.Width=sidebar.Width;
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dashboard==null)
            {
                dashboard=new Form12();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard= null;
        }

        private void submenu1_Click(object sender, EventArgs e)
        {
            if(menu1==null)
            {
                menu1=new Form15();
                menu1.FormClosed += Menu1_FormClosed;
                menu1.MdiParent = this;
                menu1.Dock=DockStyle.Fill;
                menu1.Show();
            }
            else
            {
                menu1.Activate();
            }
        }

        private void Menu1_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu1 = null;
        }

        private void submenu2_Click(object sender, EventArgs e)
        {
            if (menu2 == null)
            {
                menu2 = new Form16();
                menu2.FormClosed += Menu2_FormClosed;
                menu2.MdiParent = this;
                menu2.Dock = DockStyle.Fill;
                menu2.Show();
            }
            else
            {
                menu2.Activate();
            }
        }
        private void Menu2_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu2 = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (about == null)
            {
                about = new Form13();
                about.FormClosed += About_FormClosed;
                about.MdiParent = this;
                about.Dock = DockStyle.Fill;
                about.Show();
            }
            else
            {
                about.Activate();
            }
        }
        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            about = null;
        }

        private void gf_Click(object sender, EventArgs e)
        {
            if (settings == null)
            {
                settings = new Form14();
                settings.FormClosed += Settings_FormClosed;
                settings.MdiParent = this;
                settings.Dock = DockStyle.Fill;
                settings.Show();
            }
            else
            {
                settings.Activate();
            }
        }
        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings = null;
        }

        private void hh_Click(object sender, EventArgs e)
        {
            if (logout == null)
            {
                logout = new Form17();
                logout.FormClosed += Logout_FormClosed;
                logout.MdiParent = this;
                logout.Dock = DockStyle.Fill;
                logout.Show();
            }
            else
            {
                logout.Activate();
            }
        }
        private void Logout_FormClosed(object sender, FormClosedEventArgs e)
        {
            logout = null;
        }
    }
}
