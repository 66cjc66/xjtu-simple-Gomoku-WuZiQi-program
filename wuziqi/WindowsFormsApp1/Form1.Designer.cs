
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.五子棋ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.悔棋ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重置棋盘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复盘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存当前棋盘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存当前棋盘ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.打开棋盘文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.换色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.音乐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.播放音乐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.棋盘 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.棋盘)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.五子棋ToolStripMenuItem,
            this.暂停WToolStripMenuItem,
            this.悔棋ToolStripMenuItem,
            this.重置棋盘ToolStripMenuItem,
            this.复盘ToolStripMenuItem,
            this.保存当前棋盘ToolStripMenuItem,
            this.换色ToolStripMenuItem,
            this.音乐ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 五子棋ToolStripMenuItem
            // 
            this.五子棋ToolStripMenuItem.AutoSize = false;
            this.五子棋ToolStripMenuItem.Name = "五子棋ToolStripMenuItem";
            this.五子棋ToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.五子棋ToolStripMenuItem.Text = "五子棋？启动！";
            this.五子棋ToolStripMenuItem.Click += new System.EventHandler(this.五子棋ToolStripMenuItem_Click);
            // 
            // 暂停WToolStripMenuItem
            // 
            this.暂停WToolStripMenuItem.AutoSize = false;
            this.暂停WToolStripMenuItem.Name = "暂停WToolStripMenuItem";
            this.暂停WToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.暂停WToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.暂停WToolStripMenuItem.Text = "暂停游戏&S";
            this.暂停WToolStripMenuItem.Click += new System.EventHandler(this.暂停WToolStripMenuItem_Click);
            // 
            // 悔棋ToolStripMenuItem
            // 
            this.悔棋ToolStripMenuItem.AutoSize = false;
            this.悔棋ToolStripMenuItem.Name = "悔棋ToolStripMenuItem";
            this.悔棋ToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.悔棋ToolStripMenuItem.Text = "悔棋";
            this.悔棋ToolStripMenuItem.Click += new System.EventHandler(this.悔棋ToolStripMenuItem_Click);
            // 
            // 重置棋盘ToolStripMenuItem
            // 
            this.重置棋盘ToolStripMenuItem.AutoSize = false;
            this.重置棋盘ToolStripMenuItem.Name = "重置棋盘ToolStripMenuItem";
            this.重置棋盘ToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.重置棋盘ToolStripMenuItem.Text = "重置棋盘";
            this.重置棋盘ToolStripMenuItem.Click += new System.EventHandler(this.重置棋盘ToolStripMenuItem_Click);
            // 
            // 复盘ToolStripMenuItem
            // 
            this.复盘ToolStripMenuItem.AutoSize = false;
            this.复盘ToolStripMenuItem.Name = "复盘ToolStripMenuItem";
            this.复盘ToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.复盘ToolStripMenuItem.Text = "复盘";
            this.复盘ToolStripMenuItem.Click += new System.EventHandler(this.复盘ToolStripMenuItem_Click);
            // 
            // 保存当前棋盘ToolStripMenuItem
            // 
            this.保存当前棋盘ToolStripMenuItem.AutoSize = false;
            this.保存当前棋盘ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存当前棋盘ToolStripMenuItem1,
            this.打开棋盘文件ToolStripMenuItem});
            this.保存当前棋盘ToolStripMenuItem.Name = "保存当前棋盘ToolStripMenuItem";
            this.保存当前棋盘ToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.保存当前棋盘ToolStripMenuItem.Text = "棋盘";
            // 
            // 保存当前棋盘ToolStripMenuItem1
            // 
            this.保存当前棋盘ToolStripMenuItem1.Name = "保存当前棋盘ToolStripMenuItem1";
            this.保存当前棋盘ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.保存当前棋盘ToolStripMenuItem1.Text = "保存当前棋盘";
            this.保存当前棋盘ToolStripMenuItem1.Click += new System.EventHandler(this.保存当前棋盘ToolStripMenuItem1_Click);
            // 
            // 打开棋盘文件ToolStripMenuItem
            // 
            this.打开棋盘文件ToolStripMenuItem.Name = "打开棋盘文件ToolStripMenuItem";
            this.打开棋盘文件ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.打开棋盘文件ToolStripMenuItem.Text = "打开棋盘文件";
            this.打开棋盘文件ToolStripMenuItem.Click += new System.EventHandler(this.打开棋盘文件ToolStripMenuItem_Click);
            // 
            // 换色ToolStripMenuItem
            // 
            this.换色ToolStripMenuItem.AutoSize = false;
            this.换色ToolStripMenuItem.Name = "换色ToolStripMenuItem";
            this.换色ToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.换色ToolStripMenuItem.Text = "颜色";
            this.换色ToolStripMenuItem.Click += new System.EventHandler(this.换色ToolStripMenuItem_Click);
            // 
            // 音乐ToolStripMenuItem
            // 
            this.音乐ToolStripMenuItem.AutoSize = false;
            this.音乐ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.播放音乐ToolStripMenuItem,
            this.关闭ToolStripMenuItem});
            this.音乐ToolStripMenuItem.Name = "音乐ToolStripMenuItem";
            this.音乐ToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.音乐ToolStripMenuItem.Text = "音乐";
            // 
            // 播放音乐ToolStripMenuItem
            // 
            this.播放音乐ToolStripMenuItem.Name = "播放音乐ToolStripMenuItem";
            this.播放音乐ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.播放音乐ToolStripMenuItem.Text = "播放";
            this.播放音乐ToolStripMenuItem.Click += new System.EventHandler(this.播放音乐ToolStripMenuItem_Click);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // 棋盘
            // 
            this.棋盘.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(214)))), ((int)(((byte)(91)))));
            this.棋盘.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.棋盘.Cursor = System.Windows.Forms.Cursors.Hand;
            this.棋盘.Location = new System.Drawing.Point(0, 35);
            this.棋盘.Margin = new System.Windows.Forms.Padding(4);
            this.棋盘.Name = "棋盘";
            this.棋盘.Size = new System.Drawing.Size(750, 750);
            this.棋盘.TabIndex = 1;
            this.棋盘.TabStop = false;
            this.棋盘.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.棋盘.MouseDown += new System.Windows.Forms.MouseEventHandler(this.棋盘_MouseDown);
            this.棋盘.MouseMove += new System.Windows.Forms.MouseEventHandler(this.棋盘_MouseMove);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(806, 684);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "落子记录";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 20F);
            this.label2.Location = new System.Drawing.Point(801, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 70);
            this.label2.TabIndex = 4;
            this.label2.Text = "黑子先手";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("宋体", 20F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(801, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 59);
            this.label3.TabIndex = 6;
            this.label3.Text = "倒计时：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(767, 367);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 786);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.棋盘);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "乌兹棋";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.棋盘)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 暂停WToolStripMenuItem;
        private System.Windows.Forms.PictureBox 棋盘;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 五子棋ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重置棋盘ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 悔棋ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复盘ToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 保存当前棋盘ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存当前棋盘ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 打开棋盘文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 换色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 音乐ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 播放音乐ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
    }
}

