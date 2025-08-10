namespace CleantosafeAssetsManager
{
    partial class TodoOption
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
            tbTitle = new TextBox();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            btnToDefault = new Button();
            label3 = new Label();
            dtpEnd = new DateTimePicker();
            textBox1 = new TextBox();
            label2 = new Label();
            dtpStart = new DateTimePicker();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            cbDoubleCheck = new CheckBox();
            tbDetailContent = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tbTitle
            // 
            tbTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbTitle.Location = new Point(6, 37);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(220, 23);
            tbTitle.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 555);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(233, 28);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "추가";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(btnToDefault);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpEnd);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpStart);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbTitle);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(233, 202);
            groupBox1.TabIndex = 10000;
            groupBox1.TabStop = false;
            groupBox1.Text = "General";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.Black;
            textBox2.Location = new Point(6, 200);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 0);
            textBox2.TabIndex = 8;
            // 
            // btnToDefault
            // 
            btnToDefault.Location = new Point(6, 171);
            btnToDefault.Name = "btnToDefault";
            btnToDefault.Size = new Size(220, 23);
            btnToDefault.TabIndex = 7;
            btnToDefault.Text = "Default";
            btnToDefault.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 124);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 6;
            label3.Text = "End";
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(6, 142);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(220, 23);
            dtpEnd.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.Black;
            textBox1.Location = new Point(6, 66);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 1);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 80);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "Start";
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(6, 98);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(220, 23);
            dtpStart.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(cbDoubleCheck);
            groupBox2.Controls.Add(tbDetailContent);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 220);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(233, 329);
            groupBox2.TabIndex = 10001;
            groupBox2.TabStop = false;
            groupBox2.Text = "Options";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.BackColor = Color.Black;
            textBox4.Location = new Point(6, 297);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(220, 0);
            textBox4.TabIndex = 9;
            // 
            // cbDoubleCheck
            // 
            cbDoubleCheck.CheckAlign = ContentAlignment.MiddleRight;
            cbDoubleCheck.Location = new Point(6, 304);
            cbDoubleCheck.Name = "cbDoubleCheck";
            cbDoubleCheck.Size = new Size(220, 19);
            cbDoubleCheck.TabIndex = 4;
            cbDoubleCheck.Text = "DoubleCheck";
            cbDoubleCheck.UseVisualStyleBackColor = true;
            // 
            // tbDetailContent
            // 
            tbDetailContent.Location = new Point(6, 37);
            tbDetailContent.Multiline = true;
            tbDetailContent.Name = "tbDetailContent";
            tbDetailContent.ScrollBars = ScrollBars.Vertical;
            tbDetailContent.Size = new Size(220, 254);
            tbDetailContent.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 0;
            label4.Text = "Detail Content";
            // 
            // TodoOption
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 594);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnAdd);
            Name = "TodoOption";
            Text = "TodoOption";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbTitle;
        private Button btnAdd;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private DateTimePicker dtpStart;
        private Label label3;
        private DateTimePicker dtpEnd;
        private Button btnToDefault;
        private TextBox textBox2;
        private Label label4;
        private TextBox tbDetailContent;
        private TextBox textBox4;
        private CheckBox cbDoubleCheck;
    }
}