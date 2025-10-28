namespace painter
{
    partial class form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.線條粗細ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.線條樣式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.處存檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.藍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.紅ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.細ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.短虛線ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.直線ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.長虛線ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.長短虛線ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.線條粗細ToolStripMenuItem,
            this.線條樣式ToolStripMenuItem,
            this.處存檔案ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.藍ToolStripMenuItem,
            this.黑ToolStripMenuItem,
            this.紅ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem1.Text = "畫筆色彩";
            // 
            // 線條粗細ToolStripMenuItem
            // 
            this.線條粗細ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.細ToolStripMenuItem,
            this.中ToolStripMenuItem,
            this.出ToolStripMenuItem});
            this.線條粗細ToolStripMenuItem.Name = "線條粗細ToolStripMenuItem";
            this.線條粗細ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.線條粗細ToolStripMenuItem.Text = "線條粗細";
            // 
            // 線條樣式ToolStripMenuItem
            // 
            this.線條樣式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.短虛線ToolStripMenuItem,
            this.直線ToolStripMenuItem,
            this.長虛線ToolStripMenuItem,
            this.長短虛線ToolStripMenuItem});
            this.線條樣式ToolStripMenuItem.Name = "線條樣式ToolStripMenuItem";
            this.線條樣式ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.線條樣式ToolStripMenuItem.Text = "線條樣式";
            // 
            // 處存檔案ToolStripMenuItem
            // 
            this.處存檔案ToolStripMenuItem.Name = "處存檔案ToolStripMenuItem";
            this.處存檔案ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.處存檔案ToolStripMenuItem.Text = "處存檔案";
            this.處存檔案ToolStripMenuItem.Click += new System.EventHandler(this.處存檔案ToolStripMenuItem_Click);
            // 
            // 藍ToolStripMenuItem
            // 
            this.藍ToolStripMenuItem.Name = "藍ToolStripMenuItem";
            this.藍ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.藍ToolStripMenuItem.Text = "藍";
            this.藍ToolStripMenuItem.Click += new System.EventHandler(this.藍ToolStripMenuItem_Click);
            // 
            // 黑ToolStripMenuItem
            // 
            this.黑ToolStripMenuItem.Name = "黑ToolStripMenuItem";
            this.黑ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.黑ToolStripMenuItem.Text = "黑";
            this.黑ToolStripMenuItem.Click += new System.EventHandler(this.黑ToolStripMenuItem_Click);
            // 
            // 紅ToolStripMenuItem
            // 
            this.紅ToolStripMenuItem.Name = "紅ToolStripMenuItem";
            this.紅ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.紅ToolStripMenuItem.Text = "紅";
            this.紅ToolStripMenuItem.Click += new System.EventHandler(this.紅ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(13, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 386);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "清除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 細ToolStripMenuItem
            // 
            this.細ToolStripMenuItem.Name = "細ToolStripMenuItem";
            this.細ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.細ToolStripMenuItem.Text = "細";
            this.細ToolStripMenuItem.Click += new System.EventHandler(this.細ToolStripMenuItem_Click);
            // 
            // 中ToolStripMenuItem
            // 
            this.中ToolStripMenuItem.Name = "中ToolStripMenuItem";
            this.中ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.中ToolStripMenuItem.Text = "中";
            this.中ToolStripMenuItem.Click += new System.EventHandler(this.中ToolStripMenuItem_Click);
            // 
            // 出ToolStripMenuItem
            // 
            this.出ToolStripMenuItem.Name = "出ToolStripMenuItem";
            this.出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.出ToolStripMenuItem.Text = "粗";
            this.出ToolStripMenuItem.Click += new System.EventHandler(this.出ToolStripMenuItem_Click);
            // 
            // 短虛線ToolStripMenuItem
            // 
            this.短虛線ToolStripMenuItem.Name = "短虛線ToolStripMenuItem";
            this.短虛線ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.短虛線ToolStripMenuItem.Text = "短虛線";
            this.短虛線ToolStripMenuItem.Click += new System.EventHandler(this.短虛線ToolStripMenuItem_Click);
            // 
            // 直線ToolStripMenuItem
            // 
            this.直線ToolStripMenuItem.Name = "直線ToolStripMenuItem";
            this.直線ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.直線ToolStripMenuItem.Text = "直線";
            this.直線ToolStripMenuItem.Click += new System.EventHandler(this.直線ToolStripMenuItem_Click);
            // 
            // 長虛線ToolStripMenuItem
            // 
            this.長虛線ToolStripMenuItem.Name = "長虛線ToolStripMenuItem";
            this.長虛線ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.長虛線ToolStripMenuItem.Text = "長虛線";
            this.長虛線ToolStripMenuItem.Click += new System.EventHandler(this.長虛線ToolStripMenuItem_Click);
            // 
            // 長短虛線ToolStripMenuItem
            // 
            this.長短虛線ToolStripMenuItem.Name = "長短虛線ToolStripMenuItem";
            this.長短虛線ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.長短虛線ToolStripMenuItem.Text = "長短虛線";
            this.長短虛線ToolStripMenuItem.Click += new System.EventHandler(this.長短虛線ToolStripMenuItem_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "form";
            this.Text = "小畫家";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 藍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 黑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 紅ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 線條粗細ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 線條樣式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 處存檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 細ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem 短虛線ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 直線ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 長虛線ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 長短虛線ToolStripMenuItem;
    }
}

