namespace XXTEADecrypt
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
            this.label_sign = new System.Windows.Forms.Label();
            this.label_KEY = new System.Windows.Forms.Label();
            this.textBox_sign = new System.Windows.Forms.TextBox();
            this.textBox_KEY = new System.Windows.Forms.TextBox();
            this.button_decrypt = new System.Windows.Forms.Button();
            this.textBox_outputPath = new System.Windows.Forms.TextBox();
            this.textBox_inputPath = new System.Windows.Forms.TextBox();
            this.checkBox_lua = new System.Windows.Forms.CheckBox();
            this.checkBox_luac = new System.Windows.Forms.CheckBox();
            this.checkBox_zip = new System.Windows.Forms.CheckBox();
            this.checkBox_png = new System.Windows.Forms.CheckBox();
            this.checkBox_full = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_custom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_inputCheck = new System.Windows.Forms.Button();
            this.button_outputCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_log = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_sign
            // 
            this.label_sign.AutoSize = true;
            this.label_sign.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_sign.Location = new System.Drawing.Point(9, 33);
            this.label_sign.Name = "label_sign";
            this.label_sign.Size = new System.Drawing.Size(85, 19);
            this.label_sign.TabIndex = 0;
            this.label_sign.Text = "签名值：";
            // 
            // label_KEY
            // 
            this.label_KEY.AutoSize = true;
            this.label_KEY.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_KEY.Location = new System.Drawing.Point(9, 70);
            this.label_KEY.Name = "label_KEY";
            this.label_KEY.Size = new System.Drawing.Size(96, 19);
            this.label_KEY.TabIndex = 1;
            this.label_KEY.Text = "密钥KEY：";
            // 
            // textBox_sign
            // 
            this.textBox_sign.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_sign.Location = new System.Drawing.Point(116, 29);
            this.textBox_sign.Name = "textBox_sign";
            this.textBox_sign.Size = new System.Drawing.Size(382, 26);
            this.textBox_sign.TabIndex = 2;
            // 
            // textBox_KEY
            // 
            this.textBox_KEY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_KEY.Location = new System.Drawing.Point(116, 66);
            this.textBox_KEY.Name = "textBox_KEY";
            this.textBox_KEY.Size = new System.Drawing.Size(382, 26);
            this.textBox_KEY.TabIndex = 3;
            // 
            // button_decrypt
            // 
            this.button_decrypt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_decrypt.Location = new System.Drawing.Point(132, 265);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(87, 35);
            this.button_decrypt.TabIndex = 4;
            this.button_decrypt.Text = "解密";
            this.button_decrypt.UseVisualStyleBackColor = true;
            this.button_decrypt.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_outputPath
            // 
            this.textBox_outputPath.AllowDrop = true;
            this.textBox_outputPath.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_outputPath.Location = new System.Drawing.Point(116, 179);
            this.textBox_outputPath.Name = "textBox_outputPath";
            this.textBox_outputPath.Size = new System.Drawing.Size(382, 22);
            this.textBox_outputPath.TabIndex = 5;
            this.textBox_outputPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_enDragDrop);
            this.textBox_outputPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_enDragEnter);
            // 
            // textBox_inputPath
            // 
            this.textBox_inputPath.AllowDrop = true;
            this.textBox_inputPath.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_inputPath.Location = new System.Drawing.Point(116, 126);
            this.textBox_inputPath.Name = "textBox_inputPath";
            this.textBox_inputPath.Size = new System.Drawing.Size(382, 22);
            this.textBox_inputPath.TabIndex = 6;
            this.textBox_inputPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DeDragDrop);
            this.textBox_inputPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_DeDragEnter);
            // 
            // checkBox_lua
            // 
            this.checkBox_lua.AutoSize = true;
            this.checkBox_lua.Checked = true;
            this.checkBox_lua.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_lua.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_lua.Location = new System.Drawing.Point(241, 212);
            this.checkBox_lua.Name = "checkBox_lua";
            this.checkBox_lua.Size = new System.Drawing.Size(47, 18);
            this.checkBox_lua.TabIndex = 9;
            this.checkBox_lua.Text = "lua";
            this.checkBox_lua.UseVisualStyleBackColor = true;
            // 
            // checkBox_luac
            // 
            this.checkBox_luac.AutoSize = true;
            this.checkBox_luac.Checked = true;
            this.checkBox_luac.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_luac.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_luac.Location = new System.Drawing.Point(294, 212);
            this.checkBox_luac.Name = "checkBox_luac";
            this.checkBox_luac.Size = new System.Drawing.Size(54, 18);
            this.checkBox_luac.TabIndex = 10;
            this.checkBox_luac.Text = "luac";
            this.checkBox_luac.UseVisualStyleBackColor = true;
            // 
            // checkBox_zip
            // 
            this.checkBox_zip.AutoSize = true;
            this.checkBox_zip.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_zip.Location = new System.Drawing.Point(354, 212);
            this.checkBox_zip.Name = "checkBox_zip";
            this.checkBox_zip.Size = new System.Drawing.Size(47, 18);
            this.checkBox_zip.TabIndex = 11;
            this.checkBox_zip.Text = "Zip";
            this.checkBox_zip.UseVisualStyleBackColor = true;
            // 
            // checkBox_png
            // 
            this.checkBox_png.AutoSize = true;
            this.checkBox_png.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_png.Location = new System.Drawing.Point(407, 212);
            this.checkBox_png.Name = "checkBox_png";
            this.checkBox_png.Size = new System.Drawing.Size(47, 18);
            this.checkBox_png.TabIndex = 12;
            this.checkBox_png.Text = "png";
            this.checkBox_png.UseVisualStyleBackColor = true;
            // 
            // checkBox_full
            // 
            this.checkBox_full.AutoSize = true;
            this.checkBox_full.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_full.Location = new System.Drawing.Point(460, 212);
            this.checkBox_full.Name = "checkBox_full";
            this.checkBox_full.Size = new System.Drawing.Size(33, 18);
            this.checkBox_full.TabIndex = 13;
            this.checkBox_full.Text = "*";
            this.checkBox_full.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(9, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "解析格式：";
            // 
            // textBox_custom
            // 
            this.textBox_custom.Location = new System.Drawing.Point(116, 211);
            this.textBox_custom.Name = "textBox_custom";
            this.textBox_custom.Size = new System.Drawing.Size(119, 21);
            this.textBox_custom.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(151, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "自定义格式可以支持简单的\"*\"、“？”通配符使用！";
            // 
            // button_inputCheck
            // 
            this.button_inputCheck.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_inputCheck.Location = new System.Drawing.Point(9, 124);
            this.button_inputCheck.Name = "button_inputCheck";
            this.button_inputCheck.Size = new System.Drawing.Size(87, 30);
            this.button_inputCheck.TabIndex = 17;
            this.button_inputCheck.Text = "输入路径";
            this.button_inputCheck.UseVisualStyleBackColor = true;
            this.button_inputCheck.Click += new System.EventHandler(this.button_inputCheck_Click);
            // 
            // button_outputCheck
            // 
            this.button_outputCheck.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_outputCheck.Location = new System.Drawing.Point(9, 177);
            this.button_outputCheck.Name = "button_outputCheck";
            this.button_outputCheck.Size = new System.Drawing.Size(87, 30);
            this.button_outputCheck.TabIndex = 18;
            this.button_outputCheck.Text = "输出目录";
            this.button_outputCheck.UseVisualStyleBackColor = true;
            this.button_outputCheck.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(122, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "支持文件及文件夹拖放，输入路径可以是文件夹也可以是文件！";
            // 
            // button_encrypt
            // 
            this.button_encrypt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_encrypt.Location = new System.Drawing.Point(334, 265);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(87, 35);
            this.button_encrypt.TabIndex = 20;
            this.button_encrypt.Text = "加密";
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.打开文件ToolStripMenuItem.Text = "打开";
            this.打开文件ToolStripMenuItem.Click += new System.EventHandler(this.打开文件ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem1,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 帮助ToolStripMenuItem1
            // 
            this.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1";
            this.帮助ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.帮助ToolStripMenuItem1.Text = "帮助";
            this.帮助ToolStripMenuItem1.Click += new System.EventHandler(this.帮助ToolStripMenuItem1_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(539, 25);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(2, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "输出日志：";
            // 
            // richTextBox_log
            // 
            this.richTextBox_log.BackColor = System.Drawing.Color.White;
            this.richTextBox_log.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_log.Location = new System.Drawing.Point(84, 306);
            this.richTextBox_log.Name = "richTextBox_log";
            this.richTextBox_log.ReadOnly = true;
            this.richTextBox_log.Size = new System.Drawing.Size(431, 289);
            this.richTextBox_log.TabIndex = 24;
            this.richTextBox_log.Text = "";
            this.richTextBox_log.TextChanged += new System.EventHandler(this.richTextBox_log_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(196, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "输入目录和输出目录请不要以\"\\\"结尾";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(539, 605);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.richTextBox_log);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_outputCheck);
            this.Controls.Add(this.button_inputCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_custom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_full);
            this.Controls.Add(this.checkBox_png);
            this.Controls.Add(this.checkBox_zip);
            this.Controls.Add(this.checkBox_luac);
            this.Controls.Add(this.checkBox_lua);
            this.Controls.Add(this.textBox_inputPath);
            this.Controls.Add(this.textBox_outputPath);
            this.Controls.Add(this.button_decrypt);
            this.Controls.Add(this.textBox_KEY);
            this.Controls.Add(this.textBox_sign);
            this.Controls.Add(this.label_KEY);
            this.Controls.Add(this.label_sign);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "XXTEA解密工具----完全免费！作者QQ:976372587";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_sign;
        private System.Windows.Forms.Label label_KEY;
        private System.Windows.Forms.TextBox textBox_sign;
        private System.Windows.Forms.TextBox textBox_KEY;
        private System.Windows.Forms.Button button_decrypt;
        private System.Windows.Forms.TextBox textBox_outputPath;
        private System.Windows.Forms.TextBox textBox_inputPath;
        private System.Windows.Forms.CheckBox checkBox_lua;
        private System.Windows.Forms.CheckBox checkBox_luac;
        private System.Windows.Forms.CheckBox checkBox_zip;
        private System.Windows.Forms.CheckBox checkBox_png;
        private System.Windows.Forms.CheckBox checkBox_full;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_custom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_inputCheck;
        private System.Windows.Forms.Button button_outputCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RichTextBox richTextBox_log;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Label label5;
    }
}

