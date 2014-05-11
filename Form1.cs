using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlikaKopce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEng_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Text";
            btnOk.Text = "Ok";
        }

        private void btnMkd_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Македонски текст";
            btnOk.Text = "Разбирам";

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }

    class MyButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            SolidBrush br = new SolidBrush(Color.Red);
            SolidBrush by = new SolidBrush(Color.Yellow);
            e.Graphics.FillEllipse(br, 10, this.Size.Height / 2 - 10, 20, 20);
            e.Graphics.FillEllipse(by, 15, this.Size.Height / 2 - 5, 10, 10);

            br.Dispose();
            by.Dispose();
        }
    }
}
