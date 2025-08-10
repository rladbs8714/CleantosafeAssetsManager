namespace CleantosafeAssetsManager
{
    partial class SamsungSDIDetailInfo
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
            tbMEHSID = new TextBox();
            tbMEHSPW = new TextBox();
            lbMPW = new Label();
            lbMID = new Label();
            tbVpassPW = new TextBox();
            lbVPW = new Label();
            tbVpassID = new TextBox();
            lbVID = new Label();
            SuspendLayout();
            // 
            // tbMEHSID
            // 
            tbMEHSID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbMEHSID.Location = new Point(78, 61);
            tbMEHSID.Name = "tbMEHSID";
            tbMEHSID.ReadOnly = true;
            tbMEHSID.Size = new Size(190, 23);
            tbMEHSID.TabIndex = 15;
            // 
            // tbMEHSPW
            // 
            tbMEHSPW.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbMEHSPW.Location = new Point(78, 90);
            tbMEHSPW.Name = "tbMEHSPW";
            tbMEHSPW.ReadOnly = true;
            tbMEHSPW.Size = new Size(190, 23);
            tbMEHSPW.TabIndex = 16;
            // 
            // lbMPW
            // 
            lbMPW.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbMPW.AutoSize = true;
            lbMPW.Location = new Point(5, 93);
            lbMPW.Name = "lbMPW";
            lbMPW.Size = new Size(67, 15);
            lbMPW.TabIndex = 13;
            lbMPW.Text = "M-EHS PW";
            // 
            // lbMID
            // 
            lbMID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbMID.AutoSize = true;
            lbMID.Location = new Point(5, 64);
            lbMID.Name = "lbMID";
            lbMID.Size = new Size(61, 15);
            lbMID.TabIndex = 11;
            lbMID.Text = "M-EHS ID";
            // 
            // tbVpassPW
            // 
            tbVpassPW.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbVpassPW.Location = new Point(78, 32);
            tbVpassPW.Name = "tbVpassPW";
            tbVpassPW.ReadOnly = true;
            tbVpassPW.Size = new Size(190, 23);
            tbVpassPW.TabIndex = 14;
            // 
            // lbVPW
            // 
            lbVPW.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbVPW.AutoSize = true;
            lbVPW.Location = new Point(5, 35);
            lbVPW.Name = "lbVPW";
            lbVPW.Size = new Size(71, 15);
            lbVPW.TabIndex = 10;
            lbVPW.Text = "V-PASS PW";
            // 
            // tbVpassID
            // 
            tbVpassID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbVpassID.Location = new Point(78, 3);
            tbVpassID.Name = "tbVpassID";
            tbVpassID.ReadOnly = true;
            tbVpassID.Size = new Size(190, 23);
            tbVpassID.TabIndex = 12;
            // 
            // lbVID
            // 
            lbVID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbVID.AutoSize = true;
            lbVID.Location = new Point(5, 6);
            lbVID.Name = "lbVID";
            lbVID.Size = new Size(65, 15);
            lbVID.TabIndex = 9;
            lbVID.Text = "V-PASS ID";
            // 
            // SamsungSDIDetailInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbMEHSID);
            Controls.Add(tbMEHSPW);
            Controls.Add(lbMPW);
            Controls.Add(lbMID);
            Controls.Add(tbVpassPW);
            Controls.Add(lbVPW);
            Controls.Add(tbVpassID);
            Controls.Add(lbVID);
            Name = "SamsungSDIDetailInfo";
            Size = new Size(271, 636);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMEHSID;
        private TextBox tbMEHSPW;
        private Label lbMPW;
        private Label lbMID;
        private TextBox tbVpassPW;
        private Label lbVPW;
        private TextBox tbVpassID;
        private Label lbVID;
    }
}
