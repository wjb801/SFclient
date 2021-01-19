using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dataDirector
{
    public partial class sfcMDI : Form
    {
        public sfcMDI()
        {
            InitializeComponent();
        }

        private void ddMDI_Paint(object sender, PaintEventArgs e)
        {
            //foreach (Control ctl in this.Controls)
            //{
            //    try
            //    {
            //        // Attempt to cast the control to type MdiClient.
            //        ctlMDI = (MdiClient)ctl;

            //        // Set the BackColor of the MdiClient control.
            //        ctlMDI.BackColor = this.BackColor;
            //    }
            //    catch (InvalidCastException exc)
            //    {
            //        // Catch and ignore the error if casting failed.
            //    }
            //}

            //foreach (Control ctl in this.Controls)
            //{
            //    var ctlMDI = (MdiClient)ctl;
            //    if(ctlMDI!=null)
            //    {
            //        //ctlMDI.BackColor = Color.LightCoral; //ok

            //        //Rectangle rtView = ctlMDI.ClientRectangle;
            //        //string s1 = "数据导演 dataDirector 2020.11.27 v0.0.1";
            //        //Font font1 = new Font("宋体", 36);
            //        ////ctlMDI.CreateGraphics().DrawString(s1, font1, Brushes.Red, rtView);
            //        //ctlMDI.CreateGraphics().DrawString(s1, font1, Brushes.Red,new Point(10,10));
            //        //font1.Dispose();
            //    }
            //}



        }

        private void MENU_SYS_QUIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MENU_MODULE_MAP_Click(object sender, EventArgs e)
        {
            //**单实例
            //private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
            //{
            //    if (form1 == null || form1.IsDisposed)
            //    {
            //        form1 = new Form1();
            //        form1.MdiParent = this;
            //        form1.Show();
            //    }
            //    else { form1.Activate(); }
            //}

            sfcForm_map ddm = new sfcForm_map();
            ddm.MdiParent = this;
            ddm.Show();
        }

        private void ddMDI_Load(object sender, EventArgs e)
        {
            sfcForm_first w = new sfcForm_first();
            w.MdiParent = this;
            w.WindowState = FormWindowState.Maximized;
            w.Show();
        }
    }
}
