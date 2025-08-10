namespace CleantosafeAssetsManager
{
    partial class AddUpdateEquipment
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
            textBox8 = new TextBox();
            btnSelectImg = new Button();
            tbQty = new TextBox();
            lbQty = new Label();
            btnCancel = new Button();
            btnOk = new Button();
            tbDescription = new TextBox();
            lbDescription = new Label();
            tbPurpose = new TextBox();
            lbPurpose = new Label();
            tbBrandName = new TextBox();
            lbBrandName = new Label();
            tbName = new TextBox();
            lbName = new Label();
            SuspendLayout();
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Top;
            textBox8.BackColor = Color.Black;
            textBox8.Location = new Point(3, 177);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(211, 1);
            textBox8.TabIndex = 41;
            // 
            // btnSelectImg
            // 
            btnSelectImg.Anchor = AnchorStyles.Top;
            btnSelectImg.Location = new Point(3, 148);
            btnSelectImg.Name = "btnSelectImg";
            btnSelectImg.Size = new Size(211, 23);
            btnSelectImg.TabIndex = 40;
            btnSelectImg.Text = "제품 이미지 선택";
            btnSelectImg.UseVisualStyleBackColor = true;
            // 
            // tbQty
            // 
            tbQty.Anchor = AnchorStyles.Top;
            tbQty.Location = new Point(48, 61);
            tbQty.Name = "tbQty";
            tbQty.Size = new Size(166, 23);
            tbQty.TabIndex = 36;
            // 
            // lbQty
            // 
            lbQty.Anchor = AnchorStyles.Top;
            lbQty.AutoSize = true;
            lbQty.Location = new Point(3, 64);
            lbQty.Name = "lbQty";
            lbQty.Size = new Size(31, 15);
            lbQty.TabIndex = 35;
            lbQty.Text = "수량";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top;
            btnCancel.BackColor = Color.Tomato;
            btnCancel.Location = new Point(109, 184);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 23);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "취소";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Top;
            btnOk.BackColor = SystemColors.Control;
            btnOk.Location = new Point(3, 184);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(105, 23);
            btnOk.TabIndex = 33;
            btnOk.Text = "추가";
            btnOk.UseVisualStyleBackColor = false;
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.Top;
            tbDescription.Location = new Point(48, 119);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(166, 23);
            tbDescription.TabIndex = 32;
            // 
            // lbDescription
            // 
            lbDescription.Anchor = AnchorStyles.Top;
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(3, 122);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(31, 15);
            lbDescription.TabIndex = 31;
            lbDescription.Text = "비고";
            // 
            // tbPurpose
            // 
            tbPurpose.Anchor = AnchorStyles.Top;
            tbPurpose.Location = new Point(48, 90);
            tbPurpose.Name = "tbPurpose";
            tbPurpose.Size = new Size(166, 23);
            tbPurpose.TabIndex = 28;
            // 
            // lbPurpose
            // 
            lbPurpose.Anchor = AnchorStyles.Top;
            lbPurpose.AutoSize = true;
            lbPurpose.Location = new Point(3, 93);
            lbPurpose.Name = "lbPurpose";
            lbPurpose.Size = new Size(31, 15);
            lbPurpose.TabIndex = 27;
            lbPurpose.Text = "용도";
            // 
            // tbBrandName
            // 
            tbBrandName.Anchor = AnchorStyles.Top;
            tbBrandName.Location = new Point(48, 32);
            tbBrandName.Name = "tbBrandName";
            tbBrandName.Size = new Size(166, 23);
            tbBrandName.TabIndex = 26;
            // 
            // lbBrandName
            // 
            lbBrandName.Anchor = AnchorStyles.Top;
            lbBrandName.AutoSize = true;
            lbBrandName.Location = new Point(3, 35);
            lbBrandName.Name = "lbBrandName";
            lbBrandName.Size = new Size(43, 15);
            lbBrandName.TabIndex = 25;
            lbBrandName.Text = "제조사";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top;
            tbName.Location = new Point(48, 3);
            tbName.Name = "tbName";
            tbName.Size = new Size(166, 23);
            tbName.TabIndex = 24;
            // 
            // lbName
            // 
            lbName.Anchor = AnchorStyles.Top;
            lbName.AutoSize = true;
            lbName.Location = new Point(3, 6);
            lbName.Name = "lbName";
            lbName.Size = new Size(31, 15);
            lbName.TabIndex = 23;
            lbName.Text = "이름";
            // 
            // AddUpdateEquipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox8);
            Controls.Add(btnSelectImg);
            Controls.Add(tbQty);
            Controls.Add(lbQty);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(tbDescription);
            Controls.Add(lbDescription);
            Controls.Add(tbPurpose);
            Controls.Add(lbPurpose);
            Controls.Add(tbBrandName);
            Controls.Add(lbBrandName);
            Controls.Add(tbName);
            Controls.Add(lbName);
            Name = "AddUpdateEquipment";
            Size = new Size(217, 211);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox8;
        private Button btnSelectImg;
        private TextBox tbQty;
        private Label lbQty;
        private Button btnCancel;
        private Button btnOk;
        private TextBox tbDescription;
        private Label lbDescription;
        private TextBox tbPurpose;
        private Label lbPurpose;
        private TextBox tbBrandName;
        private Label lbBrandName;
        private TextBox tbName;
        private Label lbName;
    }
}
