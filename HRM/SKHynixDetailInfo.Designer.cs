namespace CleantosafeAssetsManager
{
    partial class SKHynixDetailInfo
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
            label3 = new Label();
            tbWelcomePW = new TextBox();
            label7 = new Label();
            tbWelcomeID = new TextBox();
            label8 = new Label();
            tbSTED = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 64);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 14;
            label3.Text = "안전교육 만료일자";
            // 
            // tbWelcomePW
            // 
            tbWelcomePW.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbWelcomePW.Location = new Point(64, 32);
            tbWelcomePW.Name = "tbWelcomePW";
            tbWelcomePW.ReadOnly = true;
            tbWelcomePW.Size = new Size(204, 23);
            tbWelcomePW.TabIndex = 16;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(5, 35);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 13;
            label7.Text = "웰컴 PW";
            // 
            // tbWelcomeID
            // 
            tbWelcomeID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbWelcomeID.Location = new Point(64, 3);
            tbWelcomeID.Name = "tbWelcomeID";
            tbWelcomeID.ReadOnly = true;
            tbWelcomeID.Size = new Size(204, 23);
            tbWelcomeID.TabIndex = 15;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(5, 6);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 12;
            label8.Text = "웰컴 ID";
            // 
            // tbSTED
            // 
            tbSTED.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbSTED.Location = new Point(116, 61);
            tbSTED.Name = "tbSTED";
            tbSTED.ReadOnly = true;
            tbSTED.Size = new Size(152, 23);
            tbSTED.TabIndex = 17;
            // 
            // SKHynixDetailInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbSTED);
            Controls.Add(label3);
            Controls.Add(tbWelcomePW);
            Controls.Add(label7);
            Controls.Add(tbWelcomeID);
            Controls.Add(label8);
            Name = "SKHynixDetailInfo";
            Size = new Size(271, 636);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox tbWelcomePW;
        private Label label7;
        private TextBox tbWelcomeID;
        private Label label8;
        private TextBox tbSTED;
    }
}
