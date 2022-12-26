
namespace dormitory_manage
{
    partial class house_insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(house_insert));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.home_num = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.room_num = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.end_time = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.start_time = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.task_num = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.ComboBox();
            this.Floot = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "公寓号";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Insert_Click);
            // 
            // home_num
            // 
            this.home_num.Location = new System.Drawing.Point(180, 52);
            this.home_num.Name = "home_num";
            this.home_num.Size = new System.Drawing.Size(109, 30);
            this.home_num.TabIndex = 2;
            this.home_num.TextChanged += new System.EventHandler(this.home_num_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "楼层数";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "性 别";
            // 
            // room_num
            // 
            this.room_num.Location = new System.Drawing.Point(180, 180);
            this.room_num.Name = "room_num";
            this.room_num.Size = new System.Drawing.Size(109, 30);
            this.room_num.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "房间数";
            // 
            // end_time
            // 
            this.end_time.Location = new System.Drawing.Point(600, 116);
            this.end_time.Name = "end_time";
            this.end_time.Size = new System.Drawing.Size(109, 30);
            this.end_time.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "关闭时间";
            // 
            // start_time
            // 
            this.start_time.Location = new System.Drawing.Point(600, 52);
            this.start_time.Name = "start_time";
            this.start_time.Size = new System.Drawing.Size(109, 30);
            this.start_time.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "启用时间";
            // 
            // task_num
            // 
            this.task_num.Location = new System.Drawing.Point(600, 179);
            this.task_num.Name = "task_num";
            this.task_num.Size = new System.Drawing.Size(109, 30);
            this.task_num.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(442, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "工作号";
            // 
            // Sex
            // 
            this.Sex.FormattingEnabled = true;
            this.Sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.Sex.Location = new System.Drawing.Point(180, 245);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(109, 28);
            this.Sex.TabIndex = 16;
            // 
            // Floot
            // 
            this.Floot.FormattingEnabled = true;
            this.Floot.Items.AddRange(new object[] {
            "1楼",
            "2楼",
            "3楼",
            "4楼",
            "5楼",
            "6楼"});
            this.Floot.Location = new System.Drawing.Point(180, 119);
            this.Floot.Name = "Floot";
            this.Floot.Size = new System.Drawing.Size(109, 28);
            this.Floot.TabIndex = 17;
            // 
            // house_insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(805, 453);
            this.Controls.Add(this.Floot);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.task_num);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.end_time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.start_time);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.room_num);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.home_num);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimizeBox = false;
            this.Name = "house_insert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加公寓楼房";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox home_num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox room_num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox end_time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox start_time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox task_num;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Sex;
        private System.Windows.Forms.ComboBox Floot;
    }
}