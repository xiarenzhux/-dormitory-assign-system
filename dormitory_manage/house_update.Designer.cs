
namespace dormitory_manage
{
    partial class house_update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(house_update));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.house_num = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.task_num = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.close_time = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.start_time = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.home_num = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.floor_num = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.house_num);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.task_num);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.sex);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.close_time);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.start_time);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.home_num);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.floor_num);
            this.splitContainer1.Size = new System.Drawing.Size(805, 453);
            this.splitContainer1.SplitterDistance = 98;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(635, 38);
            this.button2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 47);
            this.button2.TabIndex = 8;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Select_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "请输入要修改的公寓号";
            // 
            // textBox1
            // 
            this.house_num.Location = new System.Drawing.Point(287, 44);
            this.house_num.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.house_num.Name = "textBox1";
            this.house_num.Size = new System.Drawing.Size(175, 35);
            this.house_num.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(444, 280);
            this.button3.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 54);
            this.button3.TabIndex = 20;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Close_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(409, 200);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "工作号";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 280);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Update_Click);
            // 
            // textBox6
            // 
            this.task_num.Location = new System.Drawing.Point(545, 197);
            this.task_num.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.task_num.Name = "textBox6";
            this.task_num.Size = new System.Drawing.Size(127, 35);
            this.task_num.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(409, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "性别";
            // 
            // textBox7
            // 
            this.sex.Location = new System.Drawing.Point(545, 122);
            this.sex.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.sex.Name = "textBox7";
            this.sex.Size = new System.Drawing.Size(127, 35);
            this.sex.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(409, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "关闭时间";
            // 
            // textBox5
            // 
            this.close_time.Location = new System.Drawing.Point(545, 47);
            this.close_time.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.close_time.Name = "textBox5";
            this.close_time.Size = new System.Drawing.Size(127, 35);
            this.close_time.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(59, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "启用时间";
            // 
            // textBox4
            // 
            this.start_time.Location = new System.Drawing.Point(191, 197);
            this.start_time.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.start_time.Name = "textBox4";
            this.start_time.Size = new System.Drawing.Size(127, 35);
            this.start_time.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(59, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "房间数";
            // 
            // textBox3
            // 
            this.home_num.Location = new System.Drawing.Point(191, 122);
            this.home_num.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.home_num.Name = "textBox3";
            this.home_num.Size = new System.Drawing.Size(127, 35);
            this.home_num.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(59, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "楼层数";
            // 
            // textBox2
            // 
            this.floor_num.Location = new System.Drawing.Point(191, 47);
            this.floor_num.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.floor_num.Name = "textBox2";
            this.floor_num.Size = new System.Drawing.Size(127, 35);
            this.floor_num.TabIndex = 8;
            // 
            // house_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 453);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "house_update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "公寓楼房更新";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox house_num;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox task_num;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox close_time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox start_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox home_num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox floor_num;
        private System.Windows.Forms.Button button3;
    }
}