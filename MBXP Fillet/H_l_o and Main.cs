using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

/*
 * 
 * 本软件仅适用于 Huawei Matebook X Pro
 * 仅适用于3000x2000分辨率，175%-200% DPI，且不支持外接显示器
 * 各种待完善= =。
 * 此软件是本人课余作品，纯属兴趣，与华为官方无任何关系
 * 本人24K纯菜，求各位大大指点= =。
 * Email:  surbowl@gmail.com
 * 
 */

namespace MBXP_Fillet
{
    public partial class H_i_o : Form
    {
        /// <summary>
        /// 左上角半透明圆角,兼任主窗体
        /// </summary>
        public H_i_o()
        {
            InitializeComponent();
            this.notifyIcon.Visible = true;
            new H_r_o().Show();
            new H_l().Show();
            new H_r().Show();
        }

        private void H_i_o_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddLine(5, 0, 0, 0);
            path.AddLine(0, 0, 0, 5);
            path.AddArc(0, 0, 10, 10, 180, 90);
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

        private void exit_Click(object sender, System.EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
