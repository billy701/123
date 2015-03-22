namespace HanYuMatch
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TimeShow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Sumbit_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.Reduce_Btn = new System.Windows.Forms.Button();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Rewrite_Btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Start_Btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SetButton = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CenterPanel);
            this.splitContainer1.Panel1.Controls.Add(this.panel7);
            this.splitContainer1.Panel1.Controls.Add(this.panel6);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(887, 587);
            this.splitContainer1.SplitterDistance = 657;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // CenterPanel
            // 
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(50, 78);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(555, 499);
            this.CenterPanel.TabIndex = 3;
            this.CenterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CenterPanel_Paint);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(605, 78);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(52, 499);
            this.panel7.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(50, 499);
            this.panel6.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "方格数:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 78);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.Location = new System.Drawing.Point(145, 30);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(292, 27);
            this.Title.TabIndex = 0;
            this.Title.Text = "欢迎参加汉字听写大赛";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.Cancel_Btn);
            this.panel4.Controls.Add(this.Reduce_Btn);
            this.panel4.Controls.Add(this.Add_Btn);
            this.panel4.Controls.Add(this.Rewrite_Btn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 427);
            this.panel4.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "书写功能:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.TimeShow);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.Sumbit_Btn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 214);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 213);
            this.panel5.TabIndex = 10;
            // 
            // TimeShow
            // 
            this.TimeShow.AutoSize = true;
            this.TimeShow.Location = new System.Drawing.Point(97, 89);
            this.TimeShow.Name = "TimeShow";
            this.TimeShow.Size = new System.Drawing.Size(0, 12);
            this.TimeShow.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(84, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "剩余时间";
            // 
            // Sumbit_Btn
            // 
            this.Sumbit_Btn.Location = new System.Drawing.Point(66, 129);
            this.Sumbit_Btn.Name = "Sumbit_Btn";
            this.Sumbit_Btn.Size = new System.Drawing.Size(116, 55);
            this.Sumbit_Btn.TabIndex = 5;
            this.Sumbit_Btn.Text = "提交";
            this.Sumbit_Btn.UseVisualStyleBackColor = true;
            this.Sumbit_Btn.Click += new System.EventHandler(this.Sumbit_Btn_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Location = new System.Drawing.Point(27, 128);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(89, 50);
            this.Cancel_Btn.TabIndex = 8;
            this.Cancel_Btn.Text = "撤销";
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            // 
            // Reduce_Btn
            // 
            this.Reduce_Btn.Location = new System.Drawing.Point(136, 60);
            this.Reduce_Btn.Name = "Reduce_Btn";
            this.Reduce_Btn.Size = new System.Drawing.Size(89, 50);
            this.Reduce_Btn.TabIndex = 2;
            this.Reduce_Btn.Text = "减少";
            this.Reduce_Btn.UseVisualStyleBackColor = true;
            // 
            // Add_Btn
            // 
            this.Add_Btn.Location = new System.Drawing.Point(27, 60);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(89, 50);
            this.Add_Btn.TabIndex = 1;
            this.Add_Btn.Text = "增加";
            this.Add_Btn.UseVisualStyleBackColor = true;
            // 
            // Rewrite_Btn
            // 
            this.Rewrite_Btn.Location = new System.Drawing.Point(136, 128);
            this.Rewrite_Btn.Name = "Rewrite_Btn";
            this.Rewrite_Btn.Size = new System.Drawing.Size(89, 50);
            this.Rewrite_Btn.TabIndex = 3;
            this.Rewrite_Btn.Text = "重写";
            this.Rewrite_Btn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Start_Btn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 82);
            this.panel3.TabIndex = 7;
            // 
            // Start_Btn
            // 
            this.Start_Btn.Location = new System.Drawing.Point(70, 6);
            this.Start_Btn.Name = "Start_Btn";
            this.Start_Btn.Size = new System.Drawing.Size(116, 55);
            this.Start_Btn.TabIndex = 0;
            this.Start_Btn.Text = "开始";
            this.Start_Btn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SetButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(229, 78);
            this.panel2.TabIndex = 6;
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(70, 12);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(116, 54);
            this.SetButton.TabIndex = 0;
            this.SetButton.Text = "程序设置";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 587);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "主界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Sumbit_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Rewrite_Btn;
        private System.Windows.Forms.Button Reduce_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Start_Btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label TimeShow;
        private System.Windows.Forms.TextBox textBox1;
    }
}