namespace CleantosafeAssetsManager
{
    partial class TodoListControl
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
            spcTodoMainAndOption = new SplitContainer();
            spcTodoAddAndCheckList = new SplitContainer();
            btnAddTodo = new Button();
            btnAddTodoOption = new Button();
            tbAddTodoTitle = new TextBox();
            clbTodoCheckList = new CheckedListBox();
            tbTodoDescription = new TextBox();
            ((System.ComponentModel.ISupportInitialize)spcTodoMainAndOption).BeginInit();
            spcTodoMainAndOption.Panel1.SuspendLayout();
            spcTodoMainAndOption.Panel2.SuspendLayout();
            spcTodoMainAndOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spcTodoAddAndCheckList).BeginInit();
            spcTodoAddAndCheckList.Panel1.SuspendLayout();
            spcTodoAddAndCheckList.Panel2.SuspendLayout();
            spcTodoAddAndCheckList.SuspendLayout();
            SuspendLayout();
            // 
            // spcTodoMainAndOption
            // 
            spcTodoMainAndOption.Dock = DockStyle.Fill;
            spcTodoMainAndOption.IsSplitterFixed = true;
            spcTodoMainAndOption.Location = new Point(0, 0);
            spcTodoMainAndOption.Name = "spcTodoMainAndOption";
            spcTodoMainAndOption.Orientation = Orientation.Horizontal;
            // 
            // spcTodoMainAndOption.Panel1
            // 
            spcTodoMainAndOption.Panel1.Controls.Add(spcTodoAddAndCheckList);
            // 
            // spcTodoMainAndOption.Panel2
            // 
            spcTodoMainAndOption.Panel2.Controls.Add(tbTodoDescription);
            spcTodoMainAndOption.Size = new Size(389, 777);
            spcTodoMainAndOption.SplitterDistance = 565;
            spcTodoMainAndOption.TabIndex = 1;
            // 
            // spcTodoAddAndCheckList
            // 
            spcTodoAddAndCheckList.Dock = DockStyle.Fill;
            spcTodoAddAndCheckList.FixedPanel = FixedPanel.Panel1;
            spcTodoAddAndCheckList.IsSplitterFixed = true;
            spcTodoAddAndCheckList.Location = new Point(0, 0);
            spcTodoAddAndCheckList.Name = "spcTodoAddAndCheckList";
            spcTodoAddAndCheckList.Orientation = Orientation.Horizontal;
            // 
            // spcTodoAddAndCheckList.Panel1
            // 
            spcTodoAddAndCheckList.Panel1.Controls.Add(btnAddTodo);
            spcTodoAddAndCheckList.Panel1.Controls.Add(btnAddTodoOption);
            spcTodoAddAndCheckList.Panel1.Controls.Add(tbAddTodoTitle);
            // 
            // spcTodoAddAndCheckList.Panel2
            // 
            spcTodoAddAndCheckList.Panel2.Controls.Add(clbTodoCheckList);
            spcTodoAddAndCheckList.Size = new Size(389, 565);
            spcTodoAddAndCheckList.SplitterDistance = 33;
            spcTodoAddAndCheckList.TabIndex = 5;
            // 
            // btnAddTodo
            // 
            btnAddTodo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddTodo.Location = new Point(344, 3);
            btnAddTodo.Name = "btnAddTodo";
            btnAddTodo.Size = new Size(43, 28);
            btnAddTodo.TabIndex = 2;
            btnAddTodo.Text = "추가";
            btnAddTodo.UseVisualStyleBackColor = true;
            // 
            // btnAddTodoOption
            // 
            btnAddTodoOption.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddTodoOption.Location = new Point(301, 3);
            btnAddTodoOption.Name = "btnAddTodoOption";
            btnAddTodoOption.Size = new Size(43, 28);
            btnAddTodoOption.TabIndex = 1;
            btnAddTodoOption.Text = "옵션";
            btnAddTodoOption.UseVisualStyleBackColor = true;
            // 
            // tbAddTodoTitle
            // 
            tbAddTodoTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbAddTodoTitle.Location = new Point(4, 5);
            tbAddTodoTitle.Name = "tbAddTodoTitle";
            tbAddTodoTitle.Size = new Size(294, 23);
            tbAddTodoTitle.TabIndex = 0;
            // 
            // clbTodoCheckList
            // 
            clbTodoCheckList.CheckOnClick = true;
            clbTodoCheckList.Dock = DockStyle.Fill;
            clbTodoCheckList.FormattingEnabled = true;
            clbTodoCheckList.IntegralHeight = false;
            clbTodoCheckList.Location = new Point(0, 0);
            clbTodoCheckList.Name = "clbTodoCheckList";
            clbTodoCheckList.Size = new Size(389, 528);
            clbTodoCheckList.TabIndex = 3;
            // 
            // tbTodoDescription
            // 
            tbTodoDescription.Dock = DockStyle.Fill;
            tbTodoDescription.Location = new Point(0, 0);
            tbTodoDescription.Multiline = true;
            tbTodoDescription.Name = "tbTodoDescription";
            tbTodoDescription.ScrollBars = ScrollBars.Vertical;
            tbTodoDescription.Size = new Size(389, 208);
            tbTodoDescription.TabIndex = 4;
            // 
            // TodoListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(spcTodoMainAndOption);
            Name = "TodoListControl";
            Size = new Size(389, 777);
            spcTodoMainAndOption.Panel1.ResumeLayout(false);
            spcTodoMainAndOption.Panel2.ResumeLayout(false);
            spcTodoMainAndOption.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spcTodoMainAndOption).EndInit();
            spcTodoMainAndOption.ResumeLayout(false);
            spcTodoAddAndCheckList.Panel1.ResumeLayout(false);
            spcTodoAddAndCheckList.Panel1.PerformLayout();
            spcTodoAddAndCheckList.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcTodoAddAndCheckList).EndInit();
            spcTodoAddAndCheckList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer spcTodoMainAndOption;
        private Button btnAddTodoOption;
        private CheckedListBox clbTodoCheckList;
        private TextBox tbAddTodoTitle;
        private Button btnAddTodo;
        private TextBox tbTodoDescription;
        private SplitContainer spcTodoAddAndCheckList;
    }
}
