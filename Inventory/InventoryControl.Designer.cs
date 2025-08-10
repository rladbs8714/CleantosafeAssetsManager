namespace CleantosafeAssetsManager
{
    partial class InventoryControl
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
            gbDetail = new GroupBox();
            textBox2 = new TextBox();
            tbcInventory = new TabControl();
            tpChemical = new TabPage();
            tpEquipment = new TabPage();
            tpSupplies = new TabPage();
            tbcInventory.SuspendLayout();
            SuspendLayout();
            // 
            // gbDetail
            // 
            gbDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gbDetail.Location = new Point(658, 6);
            gbDetail.Name = "gbDetail";
            gbDetail.Size = new Size(277, 694);
            gbDetail.TabIndex = 12;
            gbDetail.TabStop = false;
            gbDetail.Text = "상세 정보";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBox2.BackColor = Color.Black;
            textBox2.Location = new Point(651, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1, 697);
            textBox2.TabIndex = 8;
            textBox2.TabStop = false;
            // 
            // tbcInventory
            // 
            tbcInventory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbcInventory.Controls.Add(tpChemical);
            tbcInventory.Controls.Add(tpEquipment);
            tbcInventory.Controls.Add(tpSupplies);
            tbcInventory.Location = new Point(3, 6);
            tbcInventory.Name = "tbcInventory";
            tbcInventory.SelectedIndex = 0;
            tbcInventory.Size = new Size(642, 691);
            tbcInventory.TabIndex = 16;
            // 
            // tpChemical
            // 
            tpChemical.Location = new Point(4, 24);
            tpChemical.Name = "tpChemical";
            tpChemical.Padding = new Padding(3);
            tpChemical.Size = new Size(634, 663);
            tpChemical.TabIndex = 0;
            tpChemical.Text = "약품";
            tpChemical.UseVisualStyleBackColor = true;
            // 
            // tpEquipment
            // 
            tpEquipment.Location = new Point(4, 24);
            tpEquipment.Name = "tpEquipment";
            tpEquipment.Padding = new Padding(3);
            tpEquipment.Size = new Size(634, 663);
            tpEquipment.TabIndex = 1;
            tpEquipment.Text = "장비";
            tpEquipment.UseVisualStyleBackColor = true;
            // 
            // tpSupplies
            // 
            tpSupplies.Location = new Point(4, 24);
            tpSupplies.Name = "tpSupplies";
            tpSupplies.Size = new Size(634, 663);
            tpSupplies.TabIndex = 2;
            tpSupplies.Text = "재료/소모품";
            tpSupplies.UseVisualStyleBackColor = true;
            // 
            // InventoryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbcInventory);
            Controls.Add(gbDetail);
            Controls.Add(textBox2);
            Name = "InventoryControl";
            Size = new Size(938, 703);
            tbcInventory.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox gbDetail;
        private TextBox textBox2;
        private TabControl tbcInventory;
        private TabPage tpChemical;
        private TabPage tpEquipment;
        private TabPage tpSupplies;
    }
}
