namespace CleantosafeAssetsManager
{
    partial class EquipmentControl
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
            btnRemove = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            tbSearch = new TextBox();
            lbSearch = new Label();
            lvList = new ListView();
            chName = new ColumnHeader();
            chBrand = new ColumnHeader();
            chQty = new ColumnHeader();
            chPurpose = new ColumnHeader();
            chDescription = new ColumnHeader();
            chTag = new ColumnHeader();
            SuspendLayout();
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Tomato;
            btnRemove.Location = new Point(165, 3);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 27;
            btnRemove.Text = "삭제";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(90, 161, 69);
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "추가";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(84, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "수정";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbSearch.Location = new Point(531, 3);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(100, 23);
            tbSearch.TabIndex = 22;
            // 
            // lbSearch
            // 
            lbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(494, 6);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(31, 15);
            lbSearch.TabIndex = 23;
            lbSearch.Text = "검색";
            // 
            // lvList
            // 
            lvList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvList.Columns.AddRange(new ColumnHeader[] { chName, chBrand, chQty, chPurpose, chTag, chDescription });
            lvList.FullRowSelect = true;
            lvList.GridLines = true;
            lvList.Location = new Point(3, 32);
            lvList.Name = "lvList";
            lvList.Size = new Size(628, 628);
            lvList.TabIndex = 24;
            lvList.UseCompatibleStateImageBehavior = false;
            lvList.View = View.Details;
            // 
            // chName
            // 
            chName.Text = "이름";
            chName.Width = 100;
            // 
            // chBrand
            // 
            chBrand.Text = "제조사";
            chBrand.Width = 70;
            // 
            // chQty
            // 
            chQty.Text = "수량";
            chQty.Width = 40;
            // 
            // chPurpose
            // 
            chPurpose.Text = "용도";
            chPurpose.Width = 200;
            // 
            // chDescription
            // 
            chDescription.DisplayIndex = 4;
            chDescription.Text = "비고";
            // 
            // chTag
            // 
            chTag.Text = "태그";
            // 
            // EquipmentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(tbSearch);
            Controls.Add(lbSearch);
            Controls.Add(lvList);
            Name = "EquipmentControl";
            Size = new Size(634, 663);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemove;
        private Button btnAdd;
        private Button btnUpdate;
        private TextBox tbSearch;
        private Label lbSearch;
        private ListView lvList;
        private ColumnHeader chName;
        private ColumnHeader chBrand;
        private ColumnHeader chQty;
        private ColumnHeader chPurpose;
        private ColumnHeader chDescription;
        private ColumnHeader chTag;
    }
}
