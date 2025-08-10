namespace CleantosafeAssetsManager
{
    partial class HRMControl
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
            tbSearch = new TextBox();
            lbSearch = new Label();
            lvList = new ListView();
            chName = new ColumnHeader();
            chPhoneNumber = new ColumnHeader();
            chBirthDate = new ColumnHeader();
            chGender = new ColumnHeader();
            chAddress = new ColumnHeader();
            textBox2 = new TextBox();
            gbDetail = new GroupBox();
            pnlDetailView = new Panel();
            cbDetailSelector = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            gbDetail.SuspendLayout();
            SuspendLayout();
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbSearch.Location = new Point(545, 3);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(100, 23);
            tbSearch.TabIndex = 1;
            // 
            // lbSearch
            // 
            lbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(508, 6);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(31, 15);
            lbSearch.TabIndex = 2;
            lbSearch.Text = "검색";
            // 
            // lvHRList
            // 
            lvList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvList.Columns.AddRange(new ColumnHeader[] { chName, chPhoneNumber, chBirthDate, chGender, chAddress });
            lvList.FullRowSelect = true;
            lvList.GridLines = true;
            lvList.Location = new Point(3, 32);
            lvList.Name = "lvHRList";
            lvList.Size = new Size(642, 668);
            lvList.TabIndex = 3;
            lvList.UseCompatibleStateImageBehavior = false;
            lvList.View = View.Details;
            // 
            // chName
            // 
            chName.Text = "이름";
            chName.Width = 55;
            // 
            // chPhoneNumber
            // 
            chPhoneNumber.Text = "전화번호";
            chPhoneNumber.Width = 110;
            // 
            // chBirthDate
            // 
            chBirthDate.Text = "생년월일";
            chBirthDate.Width = 90;
            // 
            // chGender
            // 
            chGender.Text = "성별";
            chGender.Width = 50;
            // 
            // chAddress
            // 
            chAddress.Text = "주소";
            chAddress.Width = 330;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBox2.BackColor = Color.Black;
            textBox2.Location = new Point(651, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1, 697);
            textBox2.TabIndex = 0;
            textBox2.TabStop = false;
            // 
            // gbDetail
            // 
            gbDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gbDetail.Controls.Add(pnlDetailView);
            gbDetail.Controls.Add(cbDetailSelector);
            gbDetail.Location = new Point(658, 6);
            gbDetail.Name = "gbDetail";
            gbDetail.Size = new Size(277, 694);
            gbDetail.TabIndex = 4;
            gbDetail.TabStop = false;
            gbDetail.Text = "상세 정보";
            // 
            // pnlDetailView
            // 
            pnlDetailView.Dock = DockStyle.Bottom;
            pnlDetailView.Location = new Point(3, 55);
            pnlDetailView.Name = "pnlDetailView";
            pnlDetailView.Size = new Size(271, 636);
            pnlDetailView.TabIndex = 1;
            // 
            // cbDetailSelector
            // 
            cbDetailSelector.FormattingEnabled = true;
            cbDetailSelector.Location = new Point(6, 26);
            cbDetailSelector.Name = "cbDetailSelector";
            cbDetailSelector.Size = new Size(265, 23);
            cbDetailSelector.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(90, 161, 69);
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "추가";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(84, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "수정";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Tomato;
            btnRemove.Location = new Point(165, 3);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "삭제";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // HRMControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(gbDetail);
            Controls.Add(textBox2);
            Controls.Add(lvList);
            Controls.Add(lbSearch);
            Controls.Add(tbSearch);
            Name = "HRMControl";
            Size = new Size(938, 703);
            gbDetail.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbSearch;
        private Label lbSearch;
        private ListView lvList;
        private ColumnHeader chName;
        private ColumnHeader chPhoneNumber;
        private ColumnHeader chBirthDate;
        private TextBox textBox2;
        private GroupBox gbDetail;
        private ComboBox cbDetailSelector;
        private Panel pnlDetailView;
        private ColumnHeader chGender;
        private ColumnHeader chAddress;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
    }
}
