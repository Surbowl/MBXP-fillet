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
        /// 主窗体，兼任左上角半透明圆角
        /// </summary>
        public H_i_o()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            InitializeComponent();
            //检查是否开机自启动，绿色软件，此功能暂时停用。
            //this.autoStart.Checked = IsExistKey(Process.GetCurrentProcess().MainModule.ModuleName);
            //SetPenetrate();//鼠标穿透
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
                const int WS_EX_TOOLWINDOW = 0x80;
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_TOOLWINDOW;      // 不显示在Alt+Tab
                return cp;
            }
        }

        private void exit_Click(object sender, System.EventArgs e)
        {
            System.Environment.Exit(0);
        }

        /// <summary>
        /// 绿色软件，此功能暂时禁用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoStart_Click(object sender, System.EventArgs e)
        {
            //bool ie = IsExistKey(Process.GetCurrentProcess().MainModule.ModuleName);
            //if (SetMeStart(!ie))
            //{
            //    this.autoStart.Checked = !ie;
            //}
        }

        private void email_Click(object sender, System.EventArgs e)
        {

        }

        //以下功能未使用
        #region 鼠标穿透
        /*
        /// <summary>
        /// https://blog.csdn.net/arrowzz/article/details/70183153
        /// </summary>
        private const uint WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_STYLE = (-16);
        private const int GWL_EXSTYLE = (-20);
        private const int LWA_ALPHA = 0;

        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(
        IntPtr hwnd,
        int nIndex,
        uint dwNewLong
        );

        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(
        IntPtr hwnd,
        int nIndex
        );

        [DllImport("user32", EntryPoint = "SetLayeredWindowAttributes")]
        private static extern int SetLayeredWindowAttributes(
        IntPtr hwnd,
        int crKey,
        int bAlpha,
        int dwFlags
        );

        /// <summary> 
        /// 设置窗体具有鼠标穿透效果 
        /// </summary> 
        public void SetPenetrate()
        {
            this.TopMost = true;
            SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_TRANSPARENT | WS_EX_LAYERED);
            SetLayeredWindowAttributes(this.Handle, 0, 100, LWA_ALPHA);
        }
        */
        #endregion

        // 绿色软件，此功能暂时停用
        //https://www.cnblogs.com/qiantao/p/9517096.html
        #region 开机自启动AutoStart
        /*
        /// <summary>
        /// 将本程序设为开启自启
        /// </summary>
        /// <param name="onOff">自启开关</param>
        /// <returns></returns>
        public static bool SetMeStart(bool onOff)
        {
            bool isOk = false;
            string appName = Process.GetCurrentProcess().MainModule.ModuleName;
            string appPath = Process.GetCurrentProcess().MainModule.FileName;
            isOk = SetAutoStart(onOff, appName, appPath);
            return isOk;
        }

        /// <summary>
        /// 将应用程序设为或不设为开机启动
        /// </summary>
        /// <param name="onOff">自启开关</param>
        /// <param name="appName">应用程序名</param>
        /// <param name="appPath">应用程序完全路径</param>
        public static bool SetAutoStart(bool onOff, string appName, string appPath)
        {
            bool isOk = true;
            //如果从没有设为开机启动设置到要设为开机启动
            if (!IsExistKey(appName) && onOff)
            {
                isOk = SelfRunning(onOff, appName, @appPath);
            }
            //如果从设为开机启动设置到不要设为开机启动
            else if (IsExistKey(appName) && !onOff)
            {
                isOk = SelfRunning(onOff, appName, @appPath);
            }
            return isOk;
        }

        /// <summary>
        /// 判断注册键值对是否存在，即是否处于开机启动状态
        /// </summary>
        /// <param name="keyName">键值名</param>
        /// <returns></returns>
        private static bool IsExistKey(string keyName)
        {
            try
            {
                bool _exist = false;
                RegistryKey local = Registry.LocalMachine;
                RegistryKey runs = local.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                if (runs == null)
                {
                    RegistryKey key2 = local.CreateSubKey("SOFTWARE");
                    RegistryKey key3 = key2.CreateSubKey("Microsoft");
                    RegistryKey key4 = key3.CreateSubKey("Windows");
                    RegistryKey key5 = key4.CreateSubKey("CurrentVersion");
                    RegistryKey key6 = key5.CreateSubKey("Run");
                    runs = key6;
                }
                string[] runsName = runs.GetValueNames();
                foreach (string strName in runsName)
                {
                    if (strName.ToUpper() == keyName.ToUpper())
                    {
                        _exist = true;
                        return _exist;
                    }
                }
                return _exist;

            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 写入或删除注册表键值对,即设为开机启动或开机不启动
        /// </summary>
        /// <param name="isStart">是否开机启动</param>
        /// <param name="exeName">应用程序名</param>
        /// <param name="path">应用程序路径带程序名</param>
        /// <returns></returns>
        private static bool SelfRunning(bool isStart, string exeName, string path)
        {
            try
            {
                RegistryKey local = Registry.LocalMachine;
                RegistryKey key = local.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                if (key == null)
                {
                    local.CreateSubKey("SOFTWARE//Microsoft//Windows//CurrentVersion//Run");
                }
                //若开机自启动则添加键值对
                if (isStart)
                {
                    key.SetValue(exeName, path);
                    key.Close();
                }
                else//否则删除键值对
                {
                    string[] keyNames = key.GetValueNames();
                    foreach (string keyName in keyNames)
                    {
                        if (keyName.ToUpper() == exeName.ToUpper())
                        {
                            key.DeleteValue(exeName);
                            key.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string ss = ex.Message;
                return false;
                //throw;
            }

            return true;
        }
        */
        #endregion
    }
}
