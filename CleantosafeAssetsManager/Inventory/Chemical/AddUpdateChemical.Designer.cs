namespace CleantosafeAssetsManager
{
    partial class AddUpdateChemical
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            lbName = new Label();
            tbName = new TextBox();
            tbBrandName = new TextBox();
            lbBrandName = new Label();
            tbPurpose = new TextBox();
            lbPurpose = new Label();
            tbpHMin = new TextBox();
            lbpH = new Label();
            tbDescription = new TextBox();
            lbDescription = new Label();
            btnCancel = new Button();
            btnOk = new Button();
            tbQty = new TextBox();
            lbQty = new Label();
            label7 = new Label();
            tbpHMax = new TextBox();
            btnSelectMsds = new Button();
            btnSelectImg = new Button();
            textBox8 = new TextBox();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(3, 6);
            lbName.Name = "lbName";
            lbName.Size = new Size(31, 15);
            lbName.TabIndex = 0;
            lbName.Text = "이름";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbName.Location = new Point(48, 3);
            tbName.Name = "tbName";
            tbName.Size = new Size(166, 23);
            tbName.TabIndex = 1;
            // 
            // tbBrandName
            // 
            tbBrandName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbBrandName.Location = new Point(48, 32);
            tbBrandName.Name = "tbBrandName";
            tbBrandName.Size = new Size(166, 23);
            tbBrandName.TabIndex = 3;
            // 
            // lbBrandName
            // 
            lbBrandName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbBrandName.AutoSize = true;
            lbBrandName.Location = new Point(3, 35);
            lbBrandName.Name = "lbBrandName";
            lbBrandName.Size = new Size(43, 15);
            lbBrandName.TabIndex = 2;
            lbBrandName.Text = "제조사";
            // 
            // tbPurpose
            // 
            tbPurpose.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbPurpose.Location = new Point(48, 119);
            tbPurpose.Name = "tbPurpose";
            tbPurpose.Size = new Size(166, 23);
            tbPurpose.TabIndex = 5;
            // 
            // lbPurpose
            // 
            lbPurpose.AutoSize = true;
            lbPurpose.Location = new Point(3, 122);
            lbPurpose.Name = "lbPurpose";
            lbPurpose.Size = new Size(31, 15);
            lbPurpose.TabIndex = 4;
            lbPurpose.Text = "용도";
            // 
            // tbpHMin
            // 
            tbpHMin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbpHMin.Location = new Point(48, 90);
            tbpHMin.Name = "tbpHMin";
            tbpHMin.Size = new Size(70, 23);
            tbpHMin.TabIndex = 7;
            // 
            // lbpH
            // 
            lbpH.AutoSize = true;
            lbpH.Location = new Point(3, 93);
            lbpH.Name = "lbpH";
            lbpH.Size = new Size(23, 15);
            lbpH.TabIndex = 6;
            lbpH.Text = "pH";
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbDescription.Location = new Point(48, 148);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(166, 23);
            tbDescription.TabIndex = 9;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(3, 151);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(31, 15);
            lbDescription.TabIndex = 8;
            lbDescription.Text = "비고";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.BackColor = Color.Tomato;
            btnCancel.Location = new Point(109, 242);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "취소";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnOk.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnOk.BackColor = SystemColors.Control;
            btnOk.Location = new Point(3, 242);
            btnOk.Name = "btnAdd";
            btnOk.Size = new Size(105, 23);
            btnOk.TabIndex = 14;
            btnOk.Text = "추가";
            btnOk.UseVisualStyleBackColor = false;
            // 
            // tbQty
            // 
            tbQty.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbQty.Location = new Point(48, 61);
            tbQty.Name = "tbQty";
            tbQty.Size = new Size(166, 23);
            tbQty.TabIndex = 17;
            // 
            // lbQty
            // 
            lbQty.AutoSize = true;
            lbQty.Location = new Point(3, 64);
            lbQty.Name = "lbQty";
            lbQty.Size = new Size(31, 15);
            lbQty.TabIndex = 16;
            lbQty.Text = "수량";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(124, 93);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 18;
            label7.Text = "-";
            // 
            // tbpHMax
            // 
            tbpHMax.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbpHMax.Location = new Point(144, 90);
            tbpHMax.Name = "tbpHMax";
            tbpHMax.Size = new Size(70, 23);
            tbpHMax.TabIndex = 19;
            // 
            // btnSelectMsds
            // 
            btnSelectMsds.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSelectMsds.Location = new Point(3, 177);
            btnSelectMsds.Name = "btnSelectMsds";
            btnSelectMsds.Size = new Size(211, 23);
            btnSelectMsds.TabIndex = 20;
            btnSelectMsds.Text = "MSDS 선택";
            btnSelectMsds.UseVisualStyleBackColor = true;
            // 
            // btnSelectImg
            // 
            btnSelectImg.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSelectImg.Location = new Point(3, 206);
            btnSelectImg.Name = "btnSelectImg";
            btnSelectImg.Size = new Size(211, 23);
            btnSelectImg.TabIndex = 21;
            btnSelectImg.Text = "제품 이미지 선택";
            btnSelectImg.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox8.BackColor = Color.Black;
            textBox8.Location = new Point(3, 235);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(211, 1);
            textBox8.TabIndex = 22;
            // 
            // AddUpdateChemical
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox8);
            Controls.Add(btnSelectImg);
            Controls.Add(btnSelectMsds);
            Controls.Add(tbpHMax);
            Controls.Add(label7);
            Controls.Add(tbQty);
            Controls.Add(lbQty);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(tbDescription);
            Controls.Add(lbDescription);
            Controls.Add(tbpHMin);
            Controls.Add(lbpH);
            Controls.Add(tbPurpose);
            Controls.Add(lbPurpose);
            Controls.Add(tbBrandName);
            Controls.Add(lbBrandName);
            Controls.Add(tbName);
            Controls.Add(lbName);
            Name = "AddUpdateChemical";
            Size = new Size(217, 269);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private TextBox tbName;
        private TextBox tbBrandName;
        private Label lbBrandName;
        private TextBox tbPurpose;
        private Label lbPurpose;
        private TextBox tbpHMin;
        private Label lbpH;
        private TextBox tbDescription;
        private Label lbDescription;
        private Button btnCancel;
        private Button btnOk;
        private TextBox tbQty;
        private Label lbQty;
        private Label label7;
        private TextBox tbpHMax;
        private Button btnSelectMsds;
        private Button btnSelectImg;
        private TextBox textBox8;
    }
}
