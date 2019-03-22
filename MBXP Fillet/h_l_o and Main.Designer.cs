namespace MBXP_Fillet
{
    partial class H_i_o
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(H_i_o));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.autoStart = new System.Windows.Forms.ToolStripMenuItem();
            this.email = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "\r\n";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "MBXP Fillet";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit,
            this.autoStart,
            this.email});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(515, 112);
            this.contextMenuStrip.Text = "menu";
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(514, 36);
            this.exit.Text = "退出 exit";
            this.exit.ToolTipText = "exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // autoStart
            // 
            this.autoStart.CheckOnClick = true;
            this.autoStart.Enabled = false;
            this.autoStart.Name = "autoStart";
            this.autoStart.Size = new System.Drawing.Size(514, 36);
            this.autoStart.Text = "将软件放至“启动”文件夹，可开机自启动";
            this.autoStart.Click += new System.EventHandler(this.autoStart_Click);
            // 
            // email
            // 
            this.email.Enabled = false;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(514, 36);
            this.email.Text = "surbowl@gmail.com";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // H_i_o
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(5, 5);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(5, 5);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(5, 5);
            this.Name = "H_i_o";
            this.Opacity = 0.25D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "H_i_o";
            this.TopMost = true;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.H_i_o_Paint);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem email;
        private System.Windows.Forms.ToolStripMenuItem autoStart;
    }
}

