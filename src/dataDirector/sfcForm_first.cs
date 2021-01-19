using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataDirector
{
    public partial class sfcForm_first : Form
    {
        public sfcForm_first()
        {
            InitializeComponent();
        }

        private void ddForm_first_Load(object sender, EventArgs e)
        {

        }

        private void ddForm_first_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rtView = this.ClientRectangle;
            //string s1 = "数据导演 dataDirector 2020.11.27 v0.0.1";
            string s1 = "SF客户端 2020.11.27 v0.0.1";
            Font font1 = new Font("宋体", 36);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(s1, font1, Brushes.LightBlue, rtView,sf);
            //e.Graphics.DrawString(s1, font1, Brushes.Red, new Point(10, 10));
            font1.Dispose();
        }
    }
}
