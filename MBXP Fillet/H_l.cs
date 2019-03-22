using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MBXP_Fillet
{
    public partial class H_l : Form
    {
        /// <summary>
        /// 左上角不透明圆角
        /// </summary>
        public H_l()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            InitializeComponent();
        }

        private void H_l_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddLine(4, 0, 0, 0);
            path.AddLine(0, 0, 0, 4);
            path.AddArc(0, 0, 8, 8, 180, 90);
            this.Region = new Region(path);
            path.Dispose();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_TOOLWINDOW = 0x80;
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_TOOLWINDOW;      // 不显示在Alt+Tab
                return cp;
            }
        }
    }
}
