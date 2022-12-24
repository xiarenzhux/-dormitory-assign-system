
namespace dormitory_manage
{
    partial class manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.主页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.公寓楼房管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加公寓楼房ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除公寓楼房ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询公寓楼房ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改公寓楼房ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.公寓寝室管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加公寓寝室ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除公寓寝室ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询公寓寝室ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改公寓寝室ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改学生信息ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.学生寝室分配ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.num);
            this.splitContainer1.Panel1.Controls.Add(this.name);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.menuStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1061, 587);
            this.splitContainer1.SplitterDistance = 156;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(118, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "修改密码";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.change_password);
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.num.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num.Location = new System.Drawing.Point(131, 60);
            this.num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(69, 20);
            this.num.TabIndex = 5;
            this.num.Text = "工作号";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.name.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(131, 17);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(49, 20);
            this.name.TabIndex = 4;
            this.name.Text = "姓名";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 109);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(618, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "确认修改";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.correct_change);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Location = new System.Drawing.Point(451, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 27);
            this.textBox2.TabIndex = 4;
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(451, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "确认密码";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "新密码";
            this.label1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主页ToolStripMenuItem,
            this.公寓楼房管理ToolStripMenuItem,
            this.公寓寝室管理ToolStripMenuItem,
            this.学生信息管理ToolStripMenuItem,
            this.学生寝室分配ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1061, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 主页ToolStripMenuItem
            // 
            this.主页ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.主页ToolStripMenuItem.Font = new System.Drawing.Font("楷体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.主页ToolStripMenuItem.Name = "主页ToolStripMenuItem";
            this.主页ToolStripMenuItem.Size = new System.Drawing.Size(36, 28);
            this.主页ToolStripMenuItem.Text = " ";
            // 
            // 公寓楼房管理ToolStripMenuItem
            // 
            this.公寓楼房管理ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.公寓楼房管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加公寓楼房ToolStripMenuItem,
            this.删除公寓楼房ToolStripMenuItem,
            this.查询公寓楼房ToolStripMenuItem,
            this.修改公寓楼房ToolStripMenuItem});
            this.公寓楼房管理ToolStripMenuItem.Font = new System.Drawing.Font("楷体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.公寓楼房管理ToolStripMenuItem.Name = "公寓楼房管理ToolStripMenuItem";
            this.公寓楼房管理ToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.公寓楼房管理ToolStripMenuItem.Text = "公寓楼房管理";
            // 
            // 添加公寓楼房ToolStripMenuItem
            // 
            this.添加公寓楼房ToolStripMenuItem.Name = "添加公寓楼房ToolStripMenuItem";
            this.添加公寓楼房ToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.添加公寓楼房ToolStripMenuItem.Text = "添加公寓楼房";
            this.添加公寓楼房ToolStripMenuItem.Click += new System.EventHandler(this.Insert_House_ToolStripMenuItem_Click);
            // 
            // 删除公寓楼房ToolStripMenuItem
            // 
            this.删除公寓楼房ToolStripMenuItem.Name = "删除公寓楼房ToolStripMenuItem";
            this.删除公寓楼房ToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.删除公寓楼房ToolStripMenuItem.Text = "删除公寓楼房";
            this.删除公寓楼房ToolStripMenuItem.Click += new System.EventHandler(this.Delete_House_ToolStripMenuItem_Click);
            // 
            // 查询公寓楼房ToolStripMenuItem
            // 
            this.查询公寓楼房ToolStripMenuItem.Name = "查询公寓楼房ToolStripMenuItem";
            this.查询公寓楼房ToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.查询公寓楼房ToolStripMenuItem.Text = "查询公寓楼房";
            this.查询公寓楼房ToolStripMenuItem.Click += new System.EventHandler(this.Select_House_ToolStripMenuItem_Click);
            // 
            // 修改公寓楼房ToolStripMenuItem
            // 
            this.修改公寓楼房ToolStripMenuItem.Name = "修改公寓楼房ToolStripMenuItem";
            this.修改公寓楼房ToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.修改公寓楼房ToolStripMenuItem.Text = "修改公寓楼房";
            this.修改公寓楼房ToolStripMenuItem.Click += new System.EventHandler(this.Update_House_ToolStripMenuItem_Click);
            // 
            // 公寓寝室管理ToolStripMenuItem
            // 
            this.公寓寝室管理ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.公寓寝室管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加公寓寝室ToolStripMenuItem,
            this.删除公寓寝室ToolStripMenuItem,
            this.查询公寓寝室ToolStripMenuItem,
            this.修改公寓寝室ToolStripMenuItem});
            this.公寓寝室管理ToolStripMenuItem.Font = new System.Drawing.Font("楷体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.公寓寝室管理ToolStripMenuItem.Name = "公寓寝室管理ToolStripMenuItem";
            this.公寓寝室管理ToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.公寓寝室管理ToolStripMenuItem.Text = "公寓寝室管理";
            // 
            // 添加公寓寝室ToolStripMenuItem
            // 
            this.添加公寓寝室ToolStripMenuItem.Name = "添加公寓寝室ToolStripMenuItem";
            this.添加公寓寝室ToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.添加公寓寝室ToolStripMenuItem.Text = "添加公寓寝室";
            this.添加公寓寝室ToolStripMenuItem.Click += new System.EventHandler(this.Insert_Bedroom_ToolStripMenuItem_Click);
            // 
            // 删除公寓寝室ToolStripMenuItem
            // 
            this.删除公寓寝室ToolStripMenuItem.Name = "删除公寓寝室ToolStripMenuItem";
            this.删除公寓寝室ToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.删除公寓寝室ToolStripMenuItem.Text = "删除公寓寝室";
            this.删除公寓寝室ToolStripMenuItem.Click += new System.EventHandler(this.Delete_Bedroom_ToolStripMenuItem_Click);
            // 
            // 查询公寓寝室ToolStripMenuItem
            // 
            this.查询公寓寝室ToolStripMenuItem.Name = "查询公寓寝室ToolStripMenuItem";
            this.查询公寓寝室ToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.查询公寓寝室ToolStripMenuItem.Text = "查询公寓寝室";
            this.查询公寓寝室ToolStripMenuItem.Click += new System.EventHandler(this.Select_Bedroom_Click);
            // 
            // 修改公寓寝室ToolStripMenuItem
            // 
            this.修改公寓寝室ToolStripMenuItem.Name = "修改公寓寝室ToolStripMenuItem";
            this.修改公寓寝室ToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.修改公寓寝室ToolStripMenuItem.Text = "修改公寓寝室";
            this.修改公寓寝室ToolStripMenuItem.Click += new System.EventHandler(this.Update_Bedroom_ToolStripMenuItem_Click);
            // 
            // 学生信息管理ToolStripMenuItem
            // 
            this.学生信息管理ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.学生信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加学生信息ToolStripMenuItem,
            this.删除学生信息ToolStripMenuItem,
            this.修改学生信息ToolStripMenuItem,
            this.修改学生信息ToolStripMenuItem1});
            this.学生信息管理ToolStripMenuItem.Font = new System.Drawing.Font("楷体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.学生信息管理ToolStripMenuItem.Name = "学生信息管理ToolStripMenuItem";
            this.学生信息管理ToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.学生信息管理ToolStripMenuItem.Text = "学生信息管理";
            // 
            // 添加学生信息ToolStripMenuItem
            // 
            this.添加学生信息ToolStripMenuItem.Name = "添加学生信息ToolStripMenuItem";
            this.添加学生信息ToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.添加学生信息ToolStripMenuItem.Text = "添加学生信息";
            this.添加学生信息ToolStripMenuItem.Click += new System.EventHandler(this.Student_Insert_Click);
            // 
            // 删除学生信息ToolStripMenuItem
            // 
            this.删除学生信息ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.删除学生信息ToolStripMenuItem.Name = "删除学生信息ToolStripMenuItem";
            this.删除学生信息ToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.删除学生信息ToolStripMenuItem.Text = "删除学生信息";
            this.删除学生信息ToolStripMenuItem.Click += new System.EventHandler(this.Student_Delete_Click);
            // 
            // 修改学生信息ToolStripMenuItem
            // 
            this.修改学生信息ToolStripMenuItem.Name = "修改学生信息ToolStripMenuItem";
            this.修改学生信息ToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.修改学生信息ToolStripMenuItem.Text = "查询学生信息";
            this.修改学生信息ToolStripMenuItem.Click += new System.EventHandler(this.Student_Select_Click);
            // 
            // 修改学生信息ToolStripMenuItem1
            // 
            this.修改学生信息ToolStripMenuItem1.Name = "修改学生信息ToolStripMenuItem1";
            this.修改学生信息ToolStripMenuItem1.Size = new System.Drawing.Size(238, 28);
            this.修改学生信息ToolStripMenuItem1.Text = "修改学生信息";
            this.修改学生信息ToolStripMenuItem1.Click += new System.EventHandler(this.修改学生信息ToolStripMenuItem1_Click);
            // 
            // 学生寝室分配ToolStripMenuItem
            // 
            this.学生寝室分配ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.学生寝室分配ToolStripMenuItem.Font = new System.Drawing.Font("楷体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.学生寝室分配ToolStripMenuItem.Name = "学生寝室分配ToolStripMenuItem";
            this.学生寝室分配ToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.学生寝室分配ToolStripMenuItem.Text = "学生寝室分配";
            // 
            // manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 587);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生宿舍管理系统";
            this.Load += new System.EventHandler(this.manager_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 主页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 公寓楼房管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加公寓楼房ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除公寓楼房ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询公寓楼房ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 公寓寝室管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加公寓寝室ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除公寓寝室ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询公寓寝室ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生寝室分配ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改公寓楼房ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改公寓寝室ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改学生信息ToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}