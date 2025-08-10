namespace CleantosafeAssetsManager
{
    /*
     *  ===========================================================================
     *  작성자     : @yoon
     *  최초 작성일: 2025.06.19
     *  
     *  < 목적 >
     *  - CleantosafeAssetsManager의 Todo 화면울 구현한다.
     *  
     *  < TODO >
     *  
     *  < History >
     *  2025.06.19 @yoon
     *  - 최초 작성
     *  ===========================================================================
     */

    public partial class TodoListControl : TodoList
    {

        // ====================================================================
        // PROPERTIES
        // ====================================================================

        /// <summary>
        /// TodoManager
        /// </summary>
        private readonly TodoManager TodoManager;


        // ====================================================================
        // CONSTRUCTORS
        // ====================================================================

        public TodoListControl(IChangeDate changeDate)
        {
            InitializeComponent();

            // @yoon 2025.06.26
            // 아래 코드는 이벤트 순서 때문에 순서가 바뀌면 안됨.
            TodoManager = new TodoManager(changeDate);
            changeDate.AddChangeDateEvent((s, e) => { UpdateTodoList(); });
            changeDate.AddChangeDateEvent((s, e) => { tbTodoDescription.Text = string.Empty; });
            // end


            // chain event
            btnAddTodoOption.Click      += CreateOptionForm;
            btnAddTodo.Click            += AddTodo;
            clbTodoCheckList.MouseDown  += ClearSelectedItemInTodoList;
            clbTodoCheckList.ItemCheck  += ReplaceTodoTitle;
            clbTodoCheckList.ItemCheck  += DisplayDescription;
            clbTodoCheckList.ItemCheck  += SetCurrentTodo;
            tbTodoDescription.LostFocus += UpdateDescription;
        }

        /// <summary>
        /// <seealso cref="tbTodoDescription"/>이 <seealso cref="Control.LostFocus"/>될 때
        /// <seealso cref="Todo.TodoOption.Description"/>을 <seealso cref="tbTodoDescription"/> 내용으로 수정한다.
        /// </summary>
        /// <param name="sender"><seealso cref="TextBox"/></param>
        /// <param name="e"><seealso cref="Control.LostFocus"/></param>
        private void UpdateDescription(object? sender, EventArgs e)
        {
            if (sender is not TextBox tb)
                return;
            if (TodoManager.CurrentTodo == null)
                return;
            
            TodoManager.CurrentTodo.Option ??= new Todo.TodoOption();
            
            TodoManager.CurrentTodo.Option.Description = tbTodoDescription.Text;
        }


        // ====================================================================
        // METHODS
        // ====================================================================

        /// <summary>
        /// 옵션이 추가된 <seealso cref="Todo"/> 생성 <seealso cref="Form"/>을 생성한다.
        /// </summary>
        /// <param name="sender"><seealso cref="Button"/></param>
        /// <param name="e"><seealso cref="Button.OnClick(EventArgs)"/></param>
        private void CreateOptionForm(object? sender, EventArgs e)
        {
            using (TodoOption todoOption = new TodoOption(TodoManager))
                todoOption.ShowDialog(this);

            UpdateTodoList();
        }

        /// <summary>
        /// <seealso cref="Todo"/>를 추가한다.
        /// </summary>
        /// <param name="sender"><seealso cref="Button"/></param>
        /// <param name="e"><seealso cref="Button.OnClick(EventArgs)"/></param>
        private void AddTodo(object? sender, EventArgs e)
        {
            string title = tbAddTodoTitle.Text;

            if (string.IsNullOrEmpty(title))
                return;

            TodoManager.AddTodo(title);
            clbTodoCheckList.ClearSelected();

            UpdateTodoList();
        }

        /// <summary>
        /// <seealso cref="clbTodoCheckList"/>의 Title 제목을 항목의 체크 여부에 따라 수정한다.
        /// </summary>
        /// <param name="sender"><seealso cref="CheckedListBox"/></param>
        /// <param name="e"><seealso cref="CheckedListBox.ItemCheck"/></param>
        private void ReplaceTodoTitle(object? sender, EventArgs e)
        {
            if (sender is not CheckedListBox clb)
                return;
            int index = clb.SelectedIndex;
            if (0 > index)
                return;

            this.BeginInvoke((MethodInvoker)delegate
            {
                if (index < 0)
                    return;

                bool   check = clb.GetItemChecked(index);
                string title = TodoManager.TodoList[index].Title;
                if (check)
                {
                    TodoManager.TodoList[index].Title  = $"[DONE] {title}";
                    TodoManager.TodoList[index].IsDone = true;
                }
                else
                {
                    TodoManager.TodoList[index].Title  = title.Replace("[DONE] ", "");
                    TodoManager.TodoList[index].IsDone = false;
                }

                UpdateTodoList();
            });
        }

        /// <summary>
        /// TodoCheckList에서 빈공간 선택 시 선택했던 아이템을 선택해제 한다.
        /// </summary>
        /// <param name="sender"><seealso cref="CheckedListBox"/></param>
        /// <param name="e"><seealso cref="MouseEventArgs"/></param>
        private void ClearSelectedItemInTodoList(object? sender, MouseEventArgs e)
        {
            int index = clbTodoCheckList.IndexFromPoint(e.Location);

            if (index == ListBox.NoMatches)
            {
                // 선택 해제
                clbTodoCheckList.ClearSelected();
                return;
            }

            // 유효한 항목 클릭이면 선택 처리
            clbTodoCheckList.SelectedIndex = index;
        }

        /// <summary>
        /// <seealso cref="clbTodoCheckList"/> 항목을 업데이트 한다.
        /// </summary>
        private void UpdateTodoList()
        {
            // stop ui - clbTodoCheckList
            clbTodoCheckList.SuspendLayout();

            #region [OLD] - set data
            // data binding
            //clbTodoCheckList.DataSource    = TodoManager.TodoList;
            //clbTodoCheckList.DisplayMember = nameof(Todo.Title);
            //clbTodoCheckList.ValueMember   = nameof(Todo.IsDone);

            // set item checked
            //for (int i = 0; i < TodoManager.TodoList.Count; i++)
            //{
            //    //Todo todo = (Todo)clbTodoCheckList.Items[i];
            //    //clbTodoCheckList.SetItemChecked(i, todo.IsDone);
            //    clbTodoCheckList.SetItemChecked(i, TodoManager.TodoList[i].IsDone);
            //}
            #endregion

            #region [NEW] - set data

            // clear
            clbTodoCheckList.Items.Clear();

            for (int i = 0; i < TodoManager.TodoList.Count; i++)
            {
                clbTodoCheckList.Items.Add(TodoManager.TodoList[i].Title);

                if (TodoManager.TodoList[i].IsDone)
                    clbTodoCheckList.SetItemChecked(i, true);
            }

            #endregion

            // on ui - clbTodoCheckList
            clbTodoCheckList.ResumeLayout();
        }

        /// <summary>
        /// <seealso cref="clbTodoCheckList"/>에 선택한 아이템(<seealso cref="Todo"/>)의 상세 설명을 표시한다.
        /// </summary>
        /// <param name="sender"><seealso cref="clbTodoCheckList"/></param>
        /// <param name="e"><seealso cref="CheckedListBox.ItemCheck"/></param>
        private void DisplayDescription(object? sender, ItemCheckEventArgs e)
        {
            if (sender is not CheckedListBox clb)
                return;

            if (0 > clb.SelectedIndex)
                return;

            tbTodoDescription.Text = string.Empty;

            Todo selectTodo = TodoManager.TodoList[clb.SelectedIndex];
            if (selectTodo.Option == null)
                return;

            tbTodoDescription.Text = selectTodo.Option.Description;
        }

        /// <summary>
        /// <seealso cref="clbTodoCheckList"/>에서 선택한 아이템의 인덱스로 <seealso cref="TodoManager.TodoList"/>에서 todo를 선택한다.
        /// </summary>
        /// <param name="sender"><seealso cref="CheckedListBox"/></param>
        /// <param name="e"><seealso cref="CheckedListBox.ItemCheck"/></param>
        private void SetCurrentTodo(object? sender, ItemCheckEventArgs e)
        {
            if (sender is not CheckedListBox clb)
                return;

            TodoManager.SetCurrentTodo(clb.SelectedIndex);
        }
    }
}
