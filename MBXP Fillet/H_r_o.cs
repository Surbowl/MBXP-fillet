using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MBXP_Fillet
{
    public partial class H_r_o : Form
    {
        /// <summary>
        /// 右上角半透明圆角
        /// </summary>
        public H_r_o()
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 5, 0);
            InitializeComponent();
        }

        private void h_r_o_Paint(object sender, PaintEventArgs e)
        { 
            GraphicsPath path = new GraphicsPath();
            path.AddLine(5, 5, 5, 0);
            path.AddLine(5, 0, 0, 0);
            path.AddArc(-6, 0, 10, 10, 270, 90);
            this.Region = new Region(path);
            path.Dispose();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80;      // 不显示在Alt+Tab
                return cp;
            }
        }
    }
}
