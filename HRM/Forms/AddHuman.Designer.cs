namespace CleantosafeAssetsManager
{
    partial class AddHuman
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
            grbCommon = new GroupBox();
            tbAddress = new TextBox();
            lbAddr = new Label();
            cbGender = new ComboBox();
            lbGD = new Label();
            dtpBirthDate = new DateTimePicker();
            lbBD = new Label();
            tbPhoneNumber = new TextBox();
            lbPN = new Label();
            tbName = new TextBox();
            lbName = new Label();
            grbSDI = new GroupBox();
            tbMEHSID = new TextBox();
            tbMEHSPW = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbVpassPW = new TextBox();
            label4 = new Label();
            tbVpassID = new TextBox();
            label5 = new Label();
            grbHynix = new GroupBox();
            dtpSTED = new DateTimePicker();
            label3 = new Label();
            tbWelcomePW = new TextBox();
            label7 = new Label();
            tbWelcomeID = new TextBox();
            label8 = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            grbCommon.SuspendLayout();
            grbSDI.SuspendLayout();
            grbHynix.SuspendLayout();
            SuspendLayout();
            // 
            // grbCommon
            // 
            grbCommon.Controls.Add(tbAddress);
            grbCommon.Controls.Add(lbAddr);
            grbCommon.Controls.Add(cbGender);
            grbCommon.Controls.Add(lbGD);
            grbCommon.Controls.Add(dtpBirthDate);
            grbCommon.Controls.Add(lbBD);
            grbCommon.Controls.Add(tbPhoneNumber);
            grbCommon.Controls.Add(lbPN);
            grbCommon.Controls.Add(tbName);
            grbCommon.Controls.Add(lbName);
            grbCommon.Location = new Point(12, 12);
            grbCommon.Name = "grbCommon";
            grbCommon.Size = new Size(195, 174);
            grbCommon.TabIndex = 0;
            grbCommon.TabStop = false;
            grbCommon.Text = "기본 정보";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(67, 138);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(122, 23);
            tbAddress.TabIndex = 4;
            // 
            // lbAddr
            // 
            lbAddr.AutoSize = true;
            lbAddr.Location = new Point(6, 141);
            lbAddr.Name = "lbAddr";
            lbAddr.Size = new Size(31, 15);
            lbAddr.TabIndex = 6;
            lbAddr.Text = "주소";
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "남자", "여자" });
            cbGender.Location = new Point(67, 109);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(122, 23);
            cbGender.TabIndex = 3;
            // 
            // lbGD
            // 
            lbGD.AutoSize = true;
            lbGD.Location = new Point(6, 112);
            lbGD.Name = "lbGD";
            lbGD.Size = new Size(31, 15);
            lbGD.TabIndex = 5;
            lbGD.Text = "성별";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(67, 80);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(122, 23);
            dtpBirthDate.TabIndex = 2;
            // 
            // lbBD
            // 
            lbBD.AutoSize = true;
            lbBD.Location = new Point(6, 83);
            lbBD.Name = "lbBD";
            lbBD.Size = new Size(55, 15);
            lbBD.TabIndex = 4;
            lbBD.Text = "생년월일";
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(67, 51);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(122, 23);
            tbPhoneNumber.TabIndex = 1;
            // 
            // lbPN
            // 
            lbPN.AutoSize = true;
            lbPN.Location = new Point(6, 54);
            lbPN.Name = "lbPN";
            lbPN.Size = new Size(55, 15);
            lbPN.TabIndex = 2;
            lbPN.Text = "전화번호";
            // 
            // tbName
            // 
            tbName.Location = new Point(67, 22);
            tbName.Name = "tbName";
            tbName.Size = new Size(122, 23);
            tbName.TabIndex = 0;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(6, 25);
            lbName.Name = "lbName";
            lbName.Size = new Size(31, 15);
            lbName.TabIndex = 0;
            lbName.Text = "이름";
            // 
            // grbSDI
            // 
            grbSDI.Controls.Add(tbMEHSID);
            grbSDI.Controls.Add(tbMEHSPW);
            grbSDI.Controls.Add(label1);
            grbSDI.Controls.Add(label2);
            grbSDI.Controls.Add(tbVpassPW);
            grbSDI.Controls.Add(label4);
            grbSDI.Controls.Add(tbVpassID);
            grbSDI.Controls.Add(label5);
            grbSDI.Location = new Point(213, 12);
            grbSDI.Name = "grbSDI";
            grbSDI.Size = new Size(195, 174);
            grbSDI.TabIndex = 8;
            grbSDI.TabStop = false;
            grbSDI.Text = "삼성 SDI";
            // 
            // tbMEHSID
            // 
            tbMEHSID.Location = new Point(79, 80);
            tbMEHSID.Name = "tbMEHSID";
            tbMEHSID.Size = new Size(110, 23);
            tbMEHSID.TabIndex = 7;
            // 
            // tbMEHSPW
            // 
            tbMEHSPW.Location = new Point(79, 109);
            tbMEHSPW.Name = "tbMEHSPW";
            tbMEHSPW.Size = new Size(110, 23);
            tbMEHSPW.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 112);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 6;
            label1.Text = "M-EHS PW";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 83);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 5;
            label2.Text = "M-EHS ID";
            // 
            // tbVpassPW
            // 
            tbVpassPW.Location = new Point(79, 51);
            tbVpassPW.Name = "tbVpassPW";
            tbVpassPW.Size = new Size(110, 23);
            tbVpassPW.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 54);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 2;
            label4.Text = "V-PASS PW";
            // 
            // tbVpassID
            // 
            tbVpassID.Location = new Point(79, 22);
            tbVpassID.Name = "tbVpassID";
            tbVpassID.Size = new Size(110, 23);
            tbVpassID.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 25);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 0;
            label5.Text = "V-PASS ID";
            // 
            // grbHynix
            // 
            grbHynix.Controls.Add(dtpSTED);
            grbHynix.Controls.Add(label3);
            grbHynix.Controls.Add(tbWelcomePW);
            grbHynix.Controls.Add(label7);
            grbHynix.Controls.Add(tbWelcomeID);
            grbHynix.Controls.Add(label8);
            grbHynix.Location = new Point(414, 12);
            grbHynix.Name = "grbHynix";
            grbHynix.Size = new Size(234, 174);
            grbHynix.TabIndex = 9;
            grbHynix.TabStop = false;
            grbHynix.Text = "SK 하이닉스";
            // 
            // dtpSTED
            // 
            dtpSTED.Format = DateTimePickerFormat.Short;
            dtpSTED.Location = new Point(117, 80);
            dtpSTED.Name = "dtpSTED";
            dtpSTED.Size = new Size(111, 23);
            dtpSTED.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 83);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 9;
            label3.Text = "안전교육 만료일자";
            // 
            // tbWelcomePW
            // 
            tbWelcomePW.Location = new Point(65, 51);
            tbWelcomePW.Name = "tbWelcomePW";
            tbWelcomePW.Size = new Size(163, 23);
            tbWelcomePW.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 54);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 2;
            label7.Text = "웰컴 PW";
            // 
            // tbWelcomeID
            // 
            tbWelcomeID.Location = new Point(65, 22);
            tbWelcomeID.Name = "tbWelcomeID";
            tbWelcomeID.Size = new Size(163, 23);
            tbWelcomeID.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 25);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 0;
            label8.Text = "웰컴 ID";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.Location = new Point(12, 192);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(316, 23);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "추가";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Tomato;
            btnCancel.Location = new Point(332, 192);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(316, 23);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "취소";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // AddHuman
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 222);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(grbHynix);
            Controls.Add(grbSDI);
            Controls.Add(grbCommon);
            Name = "AddHuman";
            Text = "인원 추가";
            grbCommon.ResumeLayout(false);
            grbCommon.PerformLayout();
            grbSDI.ResumeLayout(false);
            grbSDI.PerformLayout();
            grbHynix.ResumeLayout(false);
            grbHynix.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbCommon;
        private Label lbName;
        private TextBox tbName;
        private Label lbBD;
        private TextBox tbPhoneNumber;
        private Label lbPN;
        private DateTimePicker dtpBirthDate;
        private Label lbGD;
        private TextBox tbAddress;
        private Label lbAddr;
        private ComboBox cbGender;
        private GroupBox grbSDI;
        private TextBox tbMEHSPW;
        private Label label1;
        private Label label2;
        private TextBox tbVpassPW;
        private Label label4;
        private TextBox tbVpassID;
        private Label label5;
        private TextBox tbMEHSID;
        private GroupBox grbHynix;
        private TextBox tbWelcomePW;
        private Label label7;
        private TextBox tbWelcomeID;
        private Label label8;
        private DateTimePicker dtpSTED;
        private Label label3;
        private Button btnAdd;
        private Button btnCancel;
    }
}