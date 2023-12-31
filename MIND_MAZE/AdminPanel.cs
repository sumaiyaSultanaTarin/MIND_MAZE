using MIND_MAZE.Properties;
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
    public partial class AdminPanel : Form
    {
        Dashboard dashBoard;
        Easy easy;
        Medium Medium;
        Hard hard;
        Feedback feedback;
        Settings settings;
        public AdminPanel()
        {
            InitializeComponent();
            mdiProp();

        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FloralWhite;
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dashBoard == null)
            {
                dashBoard = new Dashboard();
                dashBoard.FormClosed += Dashboard_FormClosed;
                dashBoard.MdiParent = this;
                dashBoard.Show();
            }
            else
            {
                dashBoard.Activate();
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashBoard = null;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            sidebarTrasition.Start();
        }

        bool sidebarExpand = false;
        private void sidebarTrasition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                menuController.Width -= 5;
                if (menuController.Width <= 57)
                {
                    sidebarExpand = false;
                    sidebarTrasition.Stop();

                    /*pnDeshboard.Width = menuController.Width;
                    pnLogout.Width = menuController.Width;
                    pnResults.Width = menuController.Width;
                    pnFeed.Width = menuController.Width;
                    panel7.Width = menuController.Width;
                    panel8.Width = menuController.Width;
                    panel9.Width = menuController.Width;
                    pnSettings.Width = menuController.Width;*/
                }

            }
            else
            {
                menuController.Width += 5;
                if (menuController.Width >= 155)
                {
                    sidebarExpand = true;
                    sidebarTrasition.Stop();

                    /* pnDeshboard.Width = menuController.Width;
                     pnLogout.Width = menuController.Width;
                     pnResults.Width = menuController.Width;
                     pnFeed.Width = menuController.Width;
                     panel7.Width = menuController.Width;
                     panel8.Width = menuController.Width;
                     panel9.Width = menuController.Width;
                     pnSettings.Width = menuController.Width;*/


                }
            }

        }
        bool resultExpand = false;

        private void ResultTransition_Tick(object sender, EventArgs e)
        {
            if (resultExpand == false)
            {
                ResultSection.Height += 10;
                if (ResultSection.Height >= 185)
                {
                    ResultTransition.Stop();
                    resultExpand = true;
                }
            }
            else
            {
                ResultSection.Height -= 10;
                if (ResultSection.Height <= 54)
                {
                    ResultTransition.Stop();
                    resultExpand = false;
                }
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (feedback == null)
            {
                feedback = new Feedback();
                feedback.FormClosed += Feed_FormClosed;
                feedback.MdiParent = this;
                feedback.Dock = DockStyle.Fill;
                feedback.Show();
            }
            else
            {
                feedback.Activate();
            }
        }

        private void Feed_FormClosed(object sender, FormClosedEventArgs e)
        {
            feedback = null;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (settings == null)
            {
                settings = new Settings();
                settings.FormClosed += Set_FormClosed;
                settings.MdiParent = this;
                settings.Dock = DockStyle.Fill;
                settings.Show();
            }
            else
            {
                settings.Activate();
            }
        }

        private void Set_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings = null;
        }

        private void Results_Click(object sender, EventArgs e)
        {
            ResultTransition.Start();

        }

        private void easy1_Click(object sender, EventArgs e)
        {
                if (easy == null)
                {
                    easy = new Easy();
                    easy.FormClosed += Esay_FormClosed;
                    easy.MdiParent = this;
                    easy.Dock = DockStyle.Fill;
                    easy.Show();
                }
                else
                {
                    easy.Activate();
                }

        }
        private void Esay_FormClosed(object sender, FormClosedEventArgs e)
        {
            easy = null;
        }

        private void medium1_Click(object sender, EventArgs e)
        {
            if (Medium == null)
            {
                Medium = new Medium();
                Medium.FormClosed += Medium_FormClose;
                Medium.MdiParent = this;
                Medium.Dock = DockStyle.Fill;
                Medium.Show();
            }
            else
            {
                Medium.Activate();
            }

        }

        private void Medium_FormClose(object sender, FormClosedEventArgs e)
        {
            Medium = null;
        }

        private void hard1_Click(object sender, EventArgs e)
        {
            if (hard == null)
            {
                hard = new Hard();
                hard.FormClosed += Hard_FormClosed;
                hard.MdiParent = this;
                hard.Dock = DockStyle.Fill;
                hard.Show();
            }
            else
            {
                hard.Activate();
            }

        }

        private void Hard_FormClosed(object sender, FormClosedEventArgs e)
        {
            hard = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void menuController_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
 }

