using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MBXP_Fillet
{
    public partial class H_r : Form
    {
        /// <summary>
        /// 右上角不透明圆角
        /// </summary>
        public H_r()
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 4, 0);
            InitializeComponent();
        }

        private void H_r_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddLine(4, 4, 4, 0);
            path.AddLine(4, 0, 0, 0);
            path.AddArc(-5, 0, 8, 8, 270, 90);
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
