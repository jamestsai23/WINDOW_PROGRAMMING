namespace WindowsFormsApp11
{
    partial class Form1
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
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAsave = new System.Windows.Forms.ToolStripMenuItem();
            this.nunExit = new System.Windows.Forms.ToolStripMenuItem();
            this.檢視ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.munFont = new System.Windows.Forms.ToolStripMenuItem();
            this.顯示完成事項ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隱藏完成事項ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.尋找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增事項ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.完成事項ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除事項ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.檢視ToolStripMenuItem,
            this.編輯ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.mnuAsave,
            this.nunExit});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(144, 26);
            this.mnuNew.Text = "新增";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(144, 26);
            this.mnuOpen.Text = "開啟";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(144, 26);
            this.mnuSave.Text = "儲存";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuAsave
            // 
            this.mnuAsave.Name = "mnuAsave";
            this.mnuAsave.Size = new System.Drawing.Size(144, 26);
            this.mnuAsave.Text = "另存新檔";
            this.mnuAsave.Click += new System.EventHandler(this.mnuAsave_Click);
            // 
            // nunExit
            // 
            this.nunExit.Name = "nunExit";
            this.nunExit.Size = new System.Drawing.Size(144, 26);
            this.nunExit.Text = "離開";
            this.nunExit.Click += new System.EventHandler(this.munExit_Click);
            // 
            // 檢視ToolStripMenuItem
            // 
            this.檢視ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.munFont,
            this.顯示完成事項ToolStripMenuItem,
            this.隱藏完成事項ToolStripMenuItem});
            this.檢視ToolStripMenuItem.Name = "檢視ToolStripMenuItem";
            this.檢視ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.檢視ToolStripMenuItem.Text = "檢視";
            // 
            // munFont
            // 
            this.munFont.Name = "munFont";
            this.munFont.Size = new System.Drawing.Size(174, 26);
            this.munFont.Text = "字型大小";
            this.munFont.Click += new System.EventHandler(this.munFont_Click);
            // 
            // 顯示完成事項ToolStripMenuItem
            // 
            this.顯示完成事項ToolStripMenuItem.Name = "顯示完成事項ToolStripMenuItem";
            this.顯示完成事項ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.顯示完成事項ToolStripMenuItem.Text = "顯示完成事項";
            this.顯示完成事項ToolStripMenuItem.Click += new System.EventHandler(this.顯示完成事項ToolStripMenuItem_Click);
            // 
            // 隱藏完成事項ToolStripMenuItem
            // 
            this.隱藏完成事項ToolStripMenuItem.Name = "隱藏完成事項ToolStripMenuItem";
            this.隱藏完成事項ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.隱藏完成事項ToolStripMenuItem.Text = "隱藏完成事項";
            this.隱藏完成事項ToolStripMenuItem.Click += new System.EventHandler(this.隱藏完成事項ToolStripMenuItem_Click);
            // 
            // 編輯ToolStripMenuItem
            // 
            this.編輯ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.尋找ToolStripMenuItem,
            this.新增事項ToolStripMenuItem,
            this.完成事項ToolStripMenuItem,
            this.刪除事項ToolStripMenuItem});
            this.編輯ToolStripMenuItem.Name = "編輯ToolStripMenuItem";
            this.編輯ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.編輯ToolStripMenuItem.Text = "編輯";
            // 
            // 尋找ToolStripMenuItem
            // 
            this.尋找ToolStripMenuItem.Name = "尋找ToolStripMenuItem";
            this.尋找ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.尋找ToolStripMenuItem.Text = "尋找";
            this.尋找ToolStripMenuItem.Click += new System.EventHandler(this.尋找ToolStripMenuItem_Click);
            // 
            // 新增事項ToolStripMenuItem
            // 
            this.新增事項ToolStripMenuItem.Name = "新增事項ToolStripMenuItem";
            this.新增事項ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.新增事項ToolStripMenuItem.Text = "新增事項";
            this.新增事項ToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // 完成事項ToolStripMenuItem
            // 
            this.完成事項ToolStripMenuItem.Name = "完成事項ToolStripMenuItem";
            this.完成事項ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.完成事項ToolStripMenuItem.Text = "完成事項";
            this.完成事項ToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // 刪除事項ToolStripMenuItem
            // 
            this.刪除事項ToolStripMenuItem.Name = "刪除事項ToolStripMenuItem";
            this.刪除事項ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.刪除事項ToolStripMenuItem.Text = "刪除事項";
            this.刪除事項ToolStripMenuItem.Click += new System.EventHandler(this.刪除事項ToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(776, 369);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(691, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(691, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuAsave;
        private System.Windows.Forms.ToolStripMenuItem nunExit;
        private System.Windows.Forms.ToolStripMenuItem 檢視ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem munFont;
        private System.Windows.Forms.ToolStripMenuItem 編輯ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 顯示完成事項ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隱藏完成事項ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 尋找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增事項ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 完成事項ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除事項ToolStripMenuItem;
        private System.Windows.Forms.Button button3;
    }
}

