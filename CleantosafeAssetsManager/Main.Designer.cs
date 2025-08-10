namespace CleantosafeAssetsManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            statusStrip1 = new StatusStrip();
            menuStrip1 = new MenuStrip();
            파일FToolStripMenuItem = new ToolStripMenuItem();
            종료XToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            mcMain = new MonthCalendar();
            grbTodo = new GroupBox();
            grbForm = new GroupBox();
            tbcMain = new TabControl();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            grbForm.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 815);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1441, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 파일FToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1441, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            파일FToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 종료XToolStripMenuItem });
            파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            파일FToolStripMenuItem.Size = new Size(61, 20);
            파일FToolStripMenuItem.Text = "파일 (&F)";
            // 
            // 종료XToolStripMenuItem
            // 
            종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
            종료XToolStripMenuItem.Size = new Size(117, 22);
            종료XToolStripMenuItem.Text = "종료 (&X)";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(mcMain);
            splitContainer1.Panel1.Controls.Add(grbTodo);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(grbForm);
            splitContainer1.Size = new Size(1441, 791);
            splitContainer1.SplitterDistance = 238;
            splitContainer1.TabIndex = 2;
            // 
            // mcMain
            // 
            mcMain.Location = new Point(9, 9);
            mcMain.Name = "mcMain";
            mcMain.TabIndex = 0;
            // 
            // grbTodo
            // 
            grbTodo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grbTodo.Location = new Point(9, 183);
            grbTodo.Name = "grbTodo";
            grbTodo.Size = new Size(220, 605);
            grbTodo.TabIndex = 0;
            grbTodo.TabStop = false;
            grbTodo.Text = "TODO LIST";
            // 
            // grbForm
            // 
            grbForm.Controls.Add(tbcMain);
            grbForm.Dock = DockStyle.Fill;
            grbForm.Location = new Point(0, 0);
            grbForm.Name = "grbForm";
            grbForm.Size = new Size(1199, 791);
            grbForm.TabIndex = 0;
            grbForm.TabStop = false;
            grbForm.Text = "화면";
            // 
            // tbcMain
            // 
            tbcMain.Dock = DockStyle.Fill;
            tbcMain.Location = new Point(3, 19);
            tbcMain.Name = "tbcMain";
            tbcMain.SelectedIndex = 0;
            tbcMain.Size = new Size(1193, 769);
            tbcMain.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1441, 837);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "[Demo] 클린투세이프 자산 관리자";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            grbForm.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 파일FToolStripMenuItem;
        private ToolStripMenuItem 종료XToolStripMenuItem;
        private SplitContainer splitContainer1;
        private GroupBox grbTodo;
        private MonthCalendar mcMain;
        private GroupBox grbForm;
        private TabControl tbcMain;
    }
}
